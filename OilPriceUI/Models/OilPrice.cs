using System.Collections.Generic;

namespace OilPriceUI.Models
{
    public class OilPrice
    {
        public bool success { get; set; }
        public string message { get; set; }
        public List<Data> data { get; set; }
        public int totalRecords { get; set; }
    }
}
