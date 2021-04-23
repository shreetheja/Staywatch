using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Numerics;

namespace Staywatch_framwork_
{
    class DataClass
    {
        public enum regexCompare{ isNull,email,phone};
        public static string CurrentUsername = null;
        public static string Realuser_Name = null;
        public static string CurrentMailId = null;
        public static string CurrentPhoneNumber = null;
        public static string DOB = null;
        public static string age = null;
        public static bool isAdmin = false;
        public static List<string> cache = new List<string>();

        #region Form Validation
        public static bool isFormValid(regexCompare Type,List<string> values)
        {
            switch (Type)
            {
                case regexCompare.isNull: 
                {
                        foreach(string str in values)
                        {
                            if(str.Length == 0)
                            {
                                return false;
                            }
                        }
                        return true;
                }
                
               
                default:return false;
            }

        }
        public static bool isFormValid(regexCompare Type,string values)
        {
            switch (Type)
            {
                case regexCompare.phone:
                    {
                            
                            if (values.Length == 10)
                            {
                            BigInteger number;
                            Console.WriteLine(BigInteger.TryParse(values, out number));
                            return BigInteger.TryParse(values,out number);
                            }
                            else
                            {
                                return false;
                            }
                        
                      
                    }
                    case regexCompare.email:
                    {
                      
                            try
                            {
                                MailAddress mail = new MailAddress(values);
                            }
                            catch (Exception e)
                            {
                            Console.WriteLine("Error : " + e);

                            return false;
                            }
                        
                        return true;
                    }
                default: return false;
            }
            
        }
        #endregion

    }
}
