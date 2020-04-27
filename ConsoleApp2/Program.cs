using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.cristalix\\updates\\Minigames\\";
            string file = "options.txt";

            string full_file = Path + file;
            try
            {
                string text = File.ReadAllText(full_file);
                text = text.Replace("gamma:1.0", "gamma:1000.0");
                File.WriteAllText(full_file, text);

            }
            catch(Exception)
            {
                Console.WriteLine("Что-то пошло не так...\nНажмите любую кнопку чтобы продолжить");
            }
            Console.WriteLine("Нажмите любую кнопку чтобы продолжить");
            Console.ReadKey();
        }
    }
}
