using Model.Ef;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Bussiness
{
    public class Reception
    {
        CRMDataContext db = null;
        public Reception()
        {
            db = new CRMDataContext();
        }
        public List<AppointmentViewModel> GetListAppointmetByOffset(int id_center, string startdate, string enddate, string keyword, int pageNo, int pageSize, out int total)
        {
            try
            {

                List<AppointmentViewModel> list = new List<AppointmentViewModel>();

                SqlConnection con = new SqlConnection();
                con = Common.Common.Util.Getconnect();
                SqlCommand cmd = new SqlCommand("usp_GetListAppointmentbyCenter", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add(new SqlParameter("@loaida", loaida));
                cmd.Parameters.Add(new SqlParameter("@id_center", id_center));
                cmd.Parameters.Add(new SqlParameter("@startdate", ConvertTodate(startdate)));
                cmd.Parameters.Add(new SqlParameter("@enddate", ConvertTodate(enddate)));
                cmd.Parameters.Add(new SqlParameter("@keyword", keyword));
                cmd.Parameters.Add(new SqlParameter("@pageNo", pageNo));
                cmd.Parameters.Add(new SqlParameter("@pageSize", pageSize));
                cmd.Parameters.Add("@totalRecord", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                total = Convert.ToInt16(cmd.Parameters["@totalRecord"].Value);

                foreach (DataRow rowItem in dt.Rows)
                {
                    AppointmentViewModel item = new AppointmentViewModel();

                    item.id = int.Parse(rowItem["id"].ToString());
                    item.fullname = rowItem["fullname"].ToString();
                    item.app_date = Common.Common.Common.ConvertDateTimeNoSecond(rowItem["app_date"].ToString());
                    item.frame = rowItem["name_frame"].ToString();
                    item.status_name = rowItem["status_name"].ToString();
                    item.name_telesale = rowItem["telesale"].ToString();
                    item.name_center = rowItem["name_center"].ToString();
                    item.date_come = string.IsNullOrEmpty(rowItem["date_come"].ToString()) ? "" : Convert.ToDateTime(rowItem["date_come"]).ToString("dd-MM-yyyy HH:mm");
                    item.mobile = rowItem["mobile"].ToString();
                    item.source = rowItem["source"].ToString();
                    item.male = rowItem["male"].ToString();
                    list.Add(item);
                }
                //result.Data = list;
                //result.Total = total;

                return list;
            }
            catch (Exception ex)
            {
                Common.Common.Util.write_log(ex.Message.ToString(), "Reception.txt");
                total = 0;
                return null;
                throw;
            }
        }
        public string ConvertTodate(string date)
        {
            string[] sa = date.Split('-');
            string strNew = sa[2] + "-" + sa[1] + "-" + sa[0];
            return strNew;
        }
    }
}
