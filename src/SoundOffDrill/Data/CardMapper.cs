using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SoundOffDrill.Biz;

namespace SoundOffDrill.Data
{
    public class CardMapper
    {
        public List<Card> RetrieveCards()
        {
            List<Card> cards;

            using (StreamReader reader = new StreamReader("Cards.json"))
            {
                // Figured this out from
                // https://www.newtonsoft.com/json/help/html/ToObjectComplex.htm
                string json = reader.ReadToEnd();
                var data = JObject.Parse(json);
                JArray a = (JArray)data["Cards"];
                cards = a.ToObject<List<Card>>();
            }

            return cards;
        }
    }
}
