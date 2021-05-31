using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingTest.Common
{
    public class Helper
    {
        public static TDestination Convert<TDestination>(object source)
        {
            var jsonSource = Newtonsoft.Json.JsonConvert.SerializeObject(source, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TDestination>(jsonSource);
        }
    }
}