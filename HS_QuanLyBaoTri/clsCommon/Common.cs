using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Collections;
using System.Drawing;

namespace HS_QuanLyBaoTri.clsCommon
{
    public class Common
    {
        public static string _username;
        public static string _pass;
        public static string _idstaff;
        public static bool _suUser = false;
        public static bool _adminLocal = false;
        public static bool _editer = false;
        public static bool _viewer = false;
        public static string _idDept = string.Empty;
        public static string _Dept = string.Empty;
        public static string _namepc = string.Empty;
        //public static string _connection = (@"Data Source=172.17.25.192\kcs_hsg;Initial Catalog=HS-QuanLyBaoTri;User ID=sa;Password=ktcn2015");
        public static string _connection = (@"Data Source=DESKTOP-OLD38M1;Initial Catalog=HS-QuanLyBaoTri;User ID=sa;Password=12345678;TrustServerCertificate=True");
        //public static string _pathfileImage = @"\\172.17.25.192\Folder_VTDP_Share\File_anh\";
        public static string _pathfileImage = @"D:\CONG VIEC HOA SEN\Backup Code App VTBT\20240823\FileLuuAnhvaDoc\Folder_VTDP_Share\File_anh";
        //public static string _pathfileImageProblem = @"\\172.17.25.192\Folder_VTDP_Share\File_anh\Anh_SuCo\";
        public static string _pathfileImageProblem = @"D:\CONG VIEC HOA SEN\Backup Code App VTBT\20240823\FileLuuAnhvaDoc\Folder_VTDP_Share\File_anh\Anh_SuCo";
        //public static string _pathfileDocument = @"\\172.17.25.192\Folder_VTDP_Share\Document\";
        public static string _pathfileDocument = @" D:\CONG VIEC HOA SEN\Backup Code App VTBT\20240823\FileLuuAnhvaDoc\Folder_VTDP_Share\Document";
       

        public static byte[] convertImage(Image _img)
        {
            using (MemoryStream m = new MemoryStream())
            {
                {
                    Bitmap map = new Bitmap(_img, new Size(250, 130));
                    map.Save(m, _img.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    // Convert byte[] to Base64 String
                    //ClsCommonConstant._imagebase64 = Convert.ToBase64String(imageBytes);
                    return imageBytes;
                }
            }
        }


        public static int GetMaxIDCode(string msc)
        {
            string _msc = msc.Trim();
            int i = 0;
            int _pos = 0;
            for (i = 0; i < _msc.Length; i++)
            {
                if (char.IsDigit(_msc[i]))
                {
                    _pos = i;
                    break;
                }
            }
            return _pos;
        }
        public static SqlConnection _con = new SqlConnection(@"Data Source=DESKTOP-OLD38M1;Initial Catalog=HS-QuanLyBaoTri;User ID=sa;Password=12345678;TrustServerCertificate=True");
        
        public static void ExcuteQuery(string sql) //Thực thi cái lệnh INSERT, DELETE, ....
        {
            if (_con.State == ConnectionState.Open)
            {
                _con.Close();
            }
            _con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public static void ExcuteCMD(SqlCommand cmd)
        {
            if (_con.State == ConnectionState.Open)
            {
                _con.Close();
            }
            _con.Open();
            //     SqlCommand cmd = new SqlCommand();
            cmd.Connection = _con;
            //     cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public static DataTable SQLReadDatabaseClient(string sql)
        {
            DataTable dt = new DataTable();
            if (_con.State == ConnectionState.Open)
            {
                _con.Close();
            }
            SqlCommand com = new SqlCommand(sql, _con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            return dt;
        }
        public static int Save_Image(int _split, string id, byte[] _bimage)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@split", _split);
                cmd.Parameters.AddWithValue("@idEquip", id);
                cmd.Parameters.AddWithValue("@imagebase64",_bimage);
                cmd.CommandText = "Message_Save_Image";
                _con.Open();
                cmd.ExecuteNonQuery();
                _con.Close();
                return 1;
            }
            catch
            {
                _con.Close();
                return 0;
            }
        }
        public static int Save_ImageProblem(int _split, string id, byte[] _bimage)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@split", _split);
                cmd.Parameters.AddWithValue("@idProblem", id);
                cmd.Parameters.AddWithValue("@imagebase64", _bimage);
                cmd.CommandText = "Message_Save_Image_Problem";
                _con.Open();
                cmd.ExecuteNonQuery();
                _con.Close();
                return 1;
            }
            catch
            {
                _con.Close();
                return 0;
            }
        }

        public static DataTable Execute_Get_ImageEQ(string _id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDEquipments", _id);
            cmd.CommandText = "Data_Get_ImageByIDEquipments";
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            adap.Fill(dt);
            return dt;
        }

        public static DataTable Execute_Get_Image_Problems(string _id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDProblems", _id);
            cmd.CommandText = "Data_Get_ImageProblem";
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            adap.Fill(dt);
            return dt;
        }
        public static DataTable Execute_Get_DetailEQ(string _id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDEquipments", _id);
            cmd.CommandText = "Data_Get_DetailEQ";
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            adap.Fill(dt);
            return dt;
        }
        public static DataTable Get_UserLogIn(string _idstaff, int split)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhanvien", _idstaff);
            cmd.Parameters.AddWithValue("@split", split);
            cmd.CommandText = "Data_Get_UserLogIn";
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            adap.Fill(dt);
            return dt;
        }
        public static DataTable Get_SaveAccount(string _namepc)
        {
            
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@namepc", _namepc);
                cmd.CommandText = "Data_Get_SaveAccount";
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            
        }
        public static bool Execute_Update_Scaned(int _split,string _machineCode, double _quantity, DateTime _dateImport,string _tenkho,string _GhichuKK)
        {
            SqlConnection _conStock = new SqlConnection(@"Data Source=DESKTOP-OLD38M1;Initial Catalog=HS-QuanLyBaoTri;User ID=sa;Password=12345678;TrustServerCertificate=True");
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conStock;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@split", _split);
                cmd.Parameters.AddWithValue("@MACHINE_CODE", _machineCode);
                cmd.Parameters.AddWithValue("@STOCK", _tenkho);
                cmd.Parameters.AddWithValue("@QUANTITY_BAK", _quantity);
                cmd.Parameters.AddWithValue("@DATE_IMPORT", _dateImport);
                cmd.Parameters.AddWithValue("@GhichuKiemKe", _GhichuKK);
                cmd.CommandText = "Message_Update_Scaned";
                _conStock.Open();
                cmd.ExecuteNonQuery();
                _conStock.Close();
                return true;
            }
            catch
            {
                _conStock.Close();
                return false;
            }
        }
    }
}
