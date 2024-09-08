using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HS_QuanLyBaoTri.Models
{
    public class LocationModel
    {
        public string Department { get; set; }
        public string GroupEquipments { get; set; }
        public string ViTri { get; set; }
        public static List<LocationModel> ConvertBindingSourceToLocationList(BindingSource bindingSource)
        {
            DataView dataView = (DataView)bindingSource.List;
            DataTable dataTable = dataView.ToTable();
            if (dataTable != null)
            {
                List<LocationModel> lst = new List<LocationModel>();
                foreach (DataRow item in dataTable.Rows)
                {
                    LocationModel newModel = new LocationModel();
                    newModel.Department = item["Department"].ToString().Trim();
                    newModel.ViTri = item["ViTri"].ToString().Trim();
                    newModel.GroupEquipments = item["GroupEquipments"].ToString().Trim();
                    lst.Add(newModel);
                }
                return lst;
            }

            return new List<LocationModel>();
        }
    }
}
