using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace debitiNBE
{

    public class UserData
    {
        [JsonProperty("username")]
        public string UserName { get; set; } = "not legged";

        [JsonProperty("ID_user")]
        public int ID_User { get; set; } = -1;


        public IList<RequestData> AcceptedCrediti;
        public IList<RequestData> AcceptedDebiti;

    }


    public class RequestData
    {
        [JsonProperty("ID_Request")]
        public int ID_Request { get; set; }
        [JsonProperty("ID_Mandante")]
        public int ID_Mandante { get; set; }
        [JsonProperty("User")]
        public string User { get; set; }
        [JsonProperty("Importo")]
        public float Importo { get; set; }

        [JsonProperty("ID_SaldoRequest")]
        public int ID_SaldoRequest { get; set; }
        [JsonProperty("CreditoRichistaSaldo")]
        public float CreditoRichistaSaldo { get; set; }

    }

}
