using System;
using System.IO;


namespace TaskReadAndWrite
{
    public class ReadAndWrite
    {
        public void File()
        {
            string data;
            StreamReader Reader = null;
            StreamWriter writer = null;
            try
            {
                Reader = new StreamReader("C:\\Users\\Anaiyaan\\Desktop\\read.txt");

                data = Reader.ReadLine();
                while (data != null)
                {
                    Console.WriteLine(data);
                    data = Reader.ReadLine();
                }
                Reader.Close();
                writer = new StreamWriter("C:\\Users\\Anaiyaan\\Desktop\\write.txt");
                writer.WriteLine("hi i am vignesh");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                writer.Close();
            }
        }
    }
}
