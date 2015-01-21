using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;

namespace MikeWang.Libs
{
    public class stringHelper
    {
        /// <summary>
        /// 取得client端IP
        /// </summary>
        /// <returns>傳回使用者IP</returns>
        public static String getClientIP()
        {
            HttpRequest request = HttpContext.Current.Request;
            // 判斷是否有代理伺服器，"HTTP_VIA" 若為空值則沒有
            if (String.IsNullOrEmpty((String)request.ServerVariables["HTTP_VIA"]))
                return (String)request.ServerVariables["REMOTE_ADDR"];
            else
                return (String)request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        }

        /// <summary>
        /// 取得目前Session的總Bytes數值
        /// </summary>
        /// <returns>傳回Session大小 (long)</returns>
        public static long getSessionBytes()
        {
            long totalSessionBytes = 0;
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter b = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            System.IO.MemoryStream m;
            foreach (var obj in HttpContext.Current.Session)
            {
                m = new System.IO.MemoryStream();
                b.Serialize(m, obj);
                totalSessionBytes += m.Length;
            }
            return totalSessionBytes;
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="txtInput">輸入字串</param>
        /// <param name="salt">是否加鹽</param>
        /// <returns>MD5編碼後的字串</returns>
        public static String getMd5Hash(String txtInput, String salt = "")
        {
            if (!String.IsNullOrEmpty(salt)) txtInput += salt;
            MD5 md5Hasher = MD5.Create();
            Byte[] MD5data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(txtInput));

            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < MD5data.Length; i++)
            {
                sBuilder.Append(MD5data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        /// <summary>
        /// SHA256加密 (SHA2)
        /// </summary>
        /// <param name="txtInput">輸入字串</param>
        /// <param name="salt">是否加鹽</param>
        /// <returns>SHA256編碼後的字串</returns>
        public static String getSHA256Hash(String txtInput, String salt = "")
        {
            if (!String.IsNullOrEmpty(salt)) txtInput += salt;
            var sha256Hasher = new SHA256CryptoServiceProvider();

            Byte[] SHAData = sha256Hasher.ComputeHash(Encoding.Default.GetBytes(txtInput));
            string result = Convert.ToBase64String(SHAData);

            return result;
        }

        /// <summary>
        /// SHA512加密 (SHA2)
        /// </summary>
        /// <param name="txtInput">輸入字串</param>
        /// <param name="salt">是否加鹽</param>
        /// <returns>SHA512編碼後的字串</returns>
        public static String getSHA512Hash(String txtInput, String salt = "")
        {
            if (!String.IsNullOrEmpty(salt)) txtInput += salt;
            var sha512Hasher = new SHA512CryptoServiceProvider();

            Byte[] SHAData = sha512Hasher.ComputeHash(Encoding.Default.GetBytes(txtInput));
            string result = Convert.ToBase64String(SHAData);

            return result;
        }


        /// <summary>
        /// 彈出alert視窗
        /// </summary>
        /// <param name="strKey">JS的索引名稱</param>
        /// <param name="strInfo">要alert顯示的文字</param>
        /// <param name="Location">是否要加入網址轉向 [選填]</param>
        /// <param name="history">是否使用history回到上一頁 [選填]</param>
        public static void showMessageBox(string strKey, string strInfo, string Location = null, int history = 0)
        {
            Page page = HttpContext.Current.Handler as Page;

            if (!page.ClientScript.IsClientScriptBlockRegistered(strKey))
            {
                string strjs = "alert('" + strInfo + "');";
                if (history != 0)
                {
                    Location = null;
                    strjs += "window.history.go(" + history + ");";
                }
                if (!string.IsNullOrEmpty(Location)) strjs += "window.location.replace('" + Location + "');";
                page.ClientScript.RegisterClientScriptBlock(page.GetType(), strKey, strjs, true);
            }
        }
    }
}
