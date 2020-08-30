using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace Common.Common
{
    public static class Util
    {
        public static void write_log(string logMessage, string fileName)
        {
            string root = HttpContext.Current.Server.MapPath("~/Logs/" + DateTime.Now.ToString("yyyy-M-d") + "/");
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
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public static SqlConnection Getconnect()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["CRMDataContext"].ConnectionString);
        }
    }
}
