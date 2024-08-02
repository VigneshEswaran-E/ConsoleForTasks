using System;
using System.IO;
namespace ReadWriteFiles
{
    public class Class1
    {
       

        static void Main(string [] args)
        {
            string data;
            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                reader = new StreamReader("C:\\dog.txt");
                data = reader.ReadLine();
                while(data != null)
                {
                    Console.WriteLine(data);
                    data = reader.ReadLine();
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                reader
            }
            

        }
    }
    
    
}
