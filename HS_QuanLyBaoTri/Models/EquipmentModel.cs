using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HS_QuanLyBaoTri.Models
{
    public class EquipmentModel
    {
        public string IDEquipments { get; set; }
        public string Department { get; set; }
        public string GroupEquipments { get; set; }
        public string Equipments { get; set; }
        public string Describes { get; set; }
        public static List<EquipmentModel> ConvertBindingSourceToEquipmentList(BindingSource bindingSource)
        {
            DataView dataView = (DataView)bindingSource.List;
            DataTable dataTable = dataView.ToTable();
            if (dataTable != null)
            {
                List<EquipmentModel> lst = new List<EquipmentModel>();
                foreach (DataRow item in dataTable.Rows)
                {
                    EquipmentModel newModel = new EquipmentModel();
                    newModel.Department = item["Department"].ToString().Trim();
                    newModel.IDEquipments = item["IDEquipments"].ToString().Trim();
                    newModel.GroupEquipments = item["GroupEquipments"].ToString().Trim();
                    newModel.Equipments = item["Equipments"].ToString().Trim();
                    newModel.Describes = item["Describes"].ToString().Trim();
                    lst.Add(newModel);
                }
                return lst;
            }

            return new List<EquipmentModel>();
        }
    }
}
