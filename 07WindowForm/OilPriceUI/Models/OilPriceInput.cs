using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilPriceUI.Models
{
    public class OilPriceInput
    {
        public int provinceId { get; set; }
        public object districtId { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public int pageSize { get; set; }
        public int pageIndex { get; set; }
    }
}
