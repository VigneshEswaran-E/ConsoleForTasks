using System;
using System.Net;
using System.Net.Mail;
using TaskSMTP;
using TaskReadAndWrite;
using Read_Date_From_JSON_File;
namespace ConsoleAppSMTP
{
    class Program
    {
       static void Main (string[] args)
        {
            ReadDate obj = new ReadDate();
            obj.DI();
            
            // ReadAndWrite data = new ReadAndWrite();
            //data.File();

           // smtp obj = new ();
           // obj.send();
        }
        
    }
}
