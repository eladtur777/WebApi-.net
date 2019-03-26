using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalTest.Models
{
    public class ClientsLatestVersion
    {
        public int id { get; set; }
        public string TZ { get; set; }
        public string AccountNumber { get; set; }
        public bool IsShowBtnLatest { get; set; }
        public bool IsLatest { get; set; }
    }
}