using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks; 
    {
        public void send()
        {
            Console.WriteLine("Hello World!");
            SendEmail(GetUserName(), GetPassword());
            Console.ReadLine();
        }

        public static void SendEmail(string fromAddress, string password)
        {
            using SmtpClient email = new SmtpClient
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = "smtp.gmail.com",
                Port = 587,
                Credentials = new NetworkCredential(fromAddress, password)
            };

            string subjet = "Reminder";
            string body = $"hi sir i am  vignesh @ {DateTime.UtcNow:F}";
            try
            {
                Console.WriteLine("sending email ********");
                email.Send(fromAddress, ToAddress(), subjet, body);
                Console.WriteLine("email sent **********");
            }
            catch (SmtpException e)
            {
                Console.WriteLine(e);

            }


        }
        public static string GetUserName()
        {
            return "eswaranevignesh@gmail.com";

        }
        public static string GetPassword()
        {
            return "tgbapdjspgklhziz";
        }


        public static string ToAddress()
        {
            return "sureshkumar.duraisamy@anaiyaantechnologies.com";
        }
    }
}
