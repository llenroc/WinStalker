using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinStalker_Core.Model;
using Newtonsoft.Json;

namespace WinStalker_Core.Services
{
    public class StalkService : IStalkService
    {
        public async Task<Person> GetPerson()
        {
            var personJson = "";
            /*var file = await GetFile();
            using (var sRead = new StreamReader(await file.OpenStreamForReadAsync()))
                productsJson = await sRead.ReadToEndAsync();*/
            return JsonConvert.DeserializeObject<Person>(personJson);
        }

    }
    public interface IStalkService
    {
        Task<Person> GetPerson();
    }
}
