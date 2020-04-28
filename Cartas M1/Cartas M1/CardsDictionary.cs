using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas_M1
{
    class CardsDictionary
    {
        CardsDictionary(string content) {
            Dictionary<string, List<Cards>> cards = JsonConvert.DeserializeObject<Dictionary<string, List<Cards>>>(content);
        }
        
    }
}
