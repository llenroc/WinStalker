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

            string email = "marcioggs@gmail.com"; // args[0];
            
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

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("-------------------------");
                Console.WriteLine("Social network URL icons:");
                Console.WriteLine("-------------------------");

                foreach (SocialNetwork sn in person.SocialNetworks)
                {
                    Console.WriteLine(sn.TypeName + ": " + ss.GetSocialNetworkIconURL(sn.TypeId));
                }
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
