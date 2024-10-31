using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\II Novbe\\Desktop\\";


            bool f = false;

                Console.WriteLine("1 folder yaradir 2 file yaradir");
            do
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Folder Yarat");
                        string folderName = Console.ReadLine();
                        if (!Directory.Exists(path + folderName))
                        {
                            Directory.CreateDirectory(path + folderName);
                        }
                        else
                        {
                            throw new Exception("var bu fayldan");
                        }
                        break;
                    case "2":
                        Console.WriteLine("File yarat");
                        string fileName = Console.ReadLine();
                        if (Directory.Exists(path + fileName))
                        {
                            File.Create(path + fileName+".txt");

                            string ws = Console.ReadLine();

                            if (ws == "Y")
                            {
                                Console.WriteLine("nice");
                                using(StreamWriter sw = new StreamWriter(path +  fileName+ ".txt", true))
                                {
                                    string data = Console.ReadLine();
                                    sw.WriteLine(data);
                                }
                            }
                            if (ws == "N")
                            {
                                Console.WriteLine("not bad");
                                using (StreamReader st = new StreamReader(path + fileName + ".txt"))
                                {
                                    st.ReadToEnd();
                                } 
                                
                            }
                        }
                        break;
                        case "0":
                         f = true;
                        break;
                }


            } while (!f);



        }
    }
}
