using System;

namespace OilPriceUI.Models
{
    public class Data
    {
        public DateTime priceDate { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public Province province { get; set; }
        public District district { get; set; }
        public string priceData { get; set; }
    }
}
