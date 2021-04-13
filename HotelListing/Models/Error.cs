using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
    public class Error
    {
        public int StatusCode { get; set; }

        public string Messege { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
