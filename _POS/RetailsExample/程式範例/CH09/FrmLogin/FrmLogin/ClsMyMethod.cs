using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;//使用雜湊加密所需引用的命名空間

namespace My
{
    public class MyMethod
    {
        #region 雜湊加密,此方法需要搭配一個　位元組陣列 轉字串的方法(要自己撰寫程式碼)

        /// <summary>
        /// 雜湊加密,此方法需要搭配一個　位元組陣列 轉字串的方法(要自己撰寫程式碼)
        /// MD5 訊息摘要5(Message Digest 5 , MD5)
        /// SHA1 安全雜湊演算法(Secure Hashing Algorithm , SHA1)
        /// </summary>
        /// <param name="enCrypType">"MD5"或"SHA1"</param>
        /// <param name="bufstring">欲進行加密字串</param>
        /// <returns>回傳加密字串</returns>
        public static string HashEncryption(string enCrypType, string bufstring)
        {

            try
            {
                if (enCrypType == "MD5")
                {
                    MD5 md5 = new MD5CryptoServiceProvider();
                    byte[] dataArray = Encoding.UTF8.GetBytes(bufstring);
                    byte[] result = md5.ComputeHash(dataArray);
                    return byteArrayToString(result);
                }
                else if (enCrypType == "SHA1")
                {
                    SHA1 sha1 = new SHA1CryptoServiceProvider();
                    byte[] dataArray = Encoding.UTF8.GetBytes(bufstring);
                    byte[] result = sha1.ComputeHash(dataArray);
                    return byteArrayToString(result);
                }
                else
                {
                    return "error:可能是加密型態錯誤";
                }

            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }

        #endregion



        #region 將位元組陣列內容轉換成文字

        /// <summary>
        /// 將位元組陣列內容轉換成文字
        /// </summary>
        /// <param name="buf">傳入位元組陣列</param>
        /// <returns>文字</returns>
        public static string byteArrayToString(byte[] buf)
        {
            string result = "";
            foreach (byte var in buf)
            {
                result = result + var.ToString();
            }
            return result;
        }

        #endregion
    }
}
