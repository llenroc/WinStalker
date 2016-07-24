using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinStalker.Core.Model;
using WinStalker.Core.Services;

namespace WinStalker.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = args[0];

            StalkService ss = new StalkService();
            Person p = ss.GetPerson(email);

            Console.WriteLine(JsonConvert.SerializeObject(p, Formatting.Indented));
            Console.ReadLine();
        }
    }
}
