using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venesa.Data.Untils
{
    public class Untils
    {
        public static void write_log(string logMessage, string fileName)
        {
            string root = System.Web.HttpContext.Current.Server.MapPath("~/Logs/" + DateTime.Now.ToString("yyyy-M-d") + "/");
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            string filePath = root + fileName;
            if (!System.IO.File.Exists(filePath))
            {
                System.IO.File.WriteAllText(filePath, "Start LogMessage");
            }
            try
            {
                using (StreamWriter w = System.IO.File.AppendText(filePath))
                {
                    w.WriteLine("\r\n-------------------------------");
                    w.WriteLine("TimeLog  : {0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    w.WriteLine("Error: " + "{0}", logMessage);
                    w.Close();
                }
            }
            catch (Exception ex)
            {
                //ex.Message 
            }
        }
    }
}
