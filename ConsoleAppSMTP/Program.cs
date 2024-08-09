using System;
using System.Net;
using System.Net.Mail;
using TaskSMTP;
using TaskReadAndWrite;
using Read_Date_From_JSON_File;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ConsoleAppSMTP
{
    class Program
    {
       static void Main (string[] args)
        {

           var serviceCollection = new ServiceCollection();
            IConfiguration configuration;
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsetting.Json")
                .Build();
            serviceCollection.AddSingleton<IConfiguration>(configuration);

            Smtp obj = new Smtp(configuration);
            obj.send();
           
            // ReadDate obj = new ReadDate();
            //obj.DI();

            // ReadAndWrite data = new ReadAndWrite();
            //data.File();

            // Smtp obj = new Smtp ();
         //  obj.send();
        }
        
    }
}
