using System;
using WinStalker.Core.ExternalServices;

namespace WinStalker.Core.Tests.ExternalServices
{
    public class MockPersonService : IPersonService
    {
        public string GetPerson(string email)
        {
            string person = null;
            string fileName;

            switch (email)
            {
                case "teste-200@istalker.com":
                    fileName = "http-200.txt";
                    break;
                case "teste-202@istalker.com":
                    fileName = "http-202.txt";
                    break;
                case "teste-404@istalker.com":
                    fileName = "http-404.txt";
                    break;
                case "teste-500@istalker.com":
                    fileName = "http-500.txt";
                    break;
                default:
                    throw new System.Exception("Teste não implementado.");
                    
            }

            person = ReadMockFile(fileName);
            return person;
        }

        private string ReadMockFile(string fileName)
        {
            string[] teste = System.IO.File.ReadAllLines("MockData\\" + fileName);
            return string.Join(Environment.NewLine, teste); ;
        }
    }
}
