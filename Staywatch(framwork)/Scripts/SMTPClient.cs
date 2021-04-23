using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;

namespace Staywatch_framwork_
{
    class SMTPClient
    {
        private SmtpClient companyMail;
        public SMTPClient()
        {
            companyMail = new SmtpClient("smtp.gmail.com", 587);
            companyMail.EnableSsl = true;
            companyMail.Timeout = 5000;
            companyMail.DeliveryMethod = SmtpDeliveryMethod.Network;
            companyMail.UseDefaultCredentials = false;
            companyMail.Credentials = new NetworkCredential("StayWatchOfficial@gmail.com", "StayWatch@Hello123");
        }
        #region Checks
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new System.Net.WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
    #endregion
    #region Requests
    public static bool ForgetPasswordMail(string _newPassword,string _mail)
        {
            if (CheckForInternetConnection())
            {
                try
                {
                    SMTPClient obj = new SMTPClient();
                    MailMessage msg = new MailMessage();
                    msg.To.Add(_mail);
                    msg.From = new MailAddress("StayWatchOfficial@gmail.com");
                    msg.Subject = "Regarding The request of Forgot Password";
                    msg.Body = "The Paswword recover Request is Processed Succesfully and New Password is : " + _newPassword;
                    obj.companyMail.Send(msg);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error At : " + e);
                    return false;
                }
            }
            
            return false;
        }
        public static bool SignupMail(string _MailId)
        {
            if (CheckForInternetConnection())
            {
                try
                {
                    SMTPClient obj = new SMTPClient();
                    MailMessage msg = new MailMessage();
                    msg.To.Add(_MailId);
                    msg.From = new MailAddress("StayWatchOfficial@gmail.com");
                    msg.Subject = "Regarding the registration of new Account";
                    msg.Body = "Welcome To the Staywatch Services we are happy to have you!! _Staywatch Team ";
                    obj.companyMail.Send(msg);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e);
                    return false;
                }
            }
            return false;
        }
        public static bool LoginAlert()
        {
            if (CheckForInternetConnection())
            {
                try
                {
                    SMTPClient obj = new SMTPClient();
                    MailMessage msg = new MailMessage();
                    msg.To.Add(DataClass.CurrentMailId);
                    msg.From = new MailAddress("StayWatchOfficial@gmail.com");
                    msg.Subject = "Regarding the Recent Login of the account Was it you??";
                    msg.Body = "Recent Login was detected !!";
                    obj.companyMail.Send(msg);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e);
                    return false;
                }
            }
            return false;
        }
        #endregion
    }
}