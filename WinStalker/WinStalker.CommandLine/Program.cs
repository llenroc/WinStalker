using Newtonsoft.Json;
using System;
using WinStalker.Core.Model;
using WinStalker.Core.Services;

namespace WinStalker.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {

            string email = null;

            if (args.Length != 0)
            {
                email = args[0];
            }
            
            if (email == null) {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Enter the e-mail to be stalked:");
                Console.WriteLine("-------------------------------");
                email = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("E-mail being stalked:");
                Console.WriteLine("---------------------");
                Console.WriteLine(email);
            }

            Console.WriteLine();
            Console.WriteLine();

            try
            {
                StalkService ss = new StalkService();
                Person person = ss.GetPerson(email);

                Console.WriteLine("-------------");
                Console.WriteLine("Person found:");
                Console.WriteLine("-------------");
                Console.WriteLine(JsonConvert.SerializeObject(person, Formatting.Indented));
            }
            catch (Exception e)
            {
                Console.WriteLine("------");
                Console.WriteLine("ERROR:");
                Console.WriteLine("------");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
