using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JournalLibrary
{
    public static class Helper
    {
        public static string CalculateMD5(string input)
        {
            try
            {
                using (MD5 mds = MD5.Create())
                {
                    byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                    byte[] hashBytes = mds.ComputeHash(inputBytes);

                    StringBuilder sb = new StringBuilder();
                    foreach (var item in hashBytes)
                        sb.Append(item.ToString("X2"));                      
                    
                    return sb.ToString();
                }
            }
            catch
            {

                return string.Empty;
            }


        }
    }
}
