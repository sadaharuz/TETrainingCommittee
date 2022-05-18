using OilPriceUI.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using System.Windows.Forms;

namespace OilPriceUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            pbPtt.LoadAsync("https://www.pttplc.com/uploads/About/about-logo.png");
            pbGasPrice01.LoadAsync("https://orapiweb.pttor.com/uploads/images/20220228_235526_2006.jpg");
            pbGasPrice02.LoadAsync("https://orapiweb.pttor.com/uploads/images/20220228_212905_1792.jpg");
            pbGasPrice03.LoadAsync("https://orapiweb.pttor.com/uploads/images/20220228_235644_7690.jpg");
            pbGasPrice04.LoadAsync("https://orapiweb.pttor.com/uploads/images/20220228_235628_3471.jpg");
            pbGasPrice05.LoadAsync("https://orapiweb.pttor.com/uploads/images/20220228_235543_9179.jpg");
            pbGasPrice06.LoadAsync("https://orapiweb.pttor.com/uploads/images/20220228_235707_6258.jpg");
            pbGasPrice07.LoadAsync("https://orapiweb.pttor.com/uploads/images/20220228_235726_7704.jpg");
            pbGasPrice08.LoadAsync("https://orapiweb.pttor.com/uploads/images/20220228_235744_8995.jpg");
            pbGasPrice09.LoadAsync("https://orapiweb.pttor.com/uploads/images/20220228_235804_6726.jpg");
            pbGasPrice10.LoadAsync("https://orapiweb.pttor.com/uploads/images/20220228_235820_5403.jpg");
            var requestData = new OilPriceInput()
            {
                provinceId = 1,
                districtId = null,
                year = DateTime.Now.Year,
                month = DateTime.Now.Month,
                pageSize = 1000000,
                pageIndex = 0
            };
            var client = new RestClient("https://orapiweb1.pttor.com/api/oilprice/search");
            var request = new RestRequest().AddJsonBody(requestData);
            var result = await client.PostAsync<OilPrice>(request);
            var currentOilPriceData = result.data[0];
            var priceDatas = JsonSerializer.Deserialize<List<PriceData>>(currentOilPriceData.priceData);
            lbDateUpdated.Text = (new DateTime(currentOilPriceData.year, currentOilPriceData.month, currentOilPriceData.day)).ToString("dd MMMM yyyy", new CultureInfo("th"));
            lbGasPrice01.Text = priceDatas[0].Price.ToString("n2");
            lbGasPrice02.Text = priceDatas[1].Price.ToString("n2");
            lbGasPrice03.Text = priceDatas[2].Price.ToString("n2");
            lbGasPrice04.Text = priceDatas[3].Price.ToString("n2");
            lbGasPrice05.Text = priceDatas[4].Price.ToString("n2");
            lbGasPrice06.Text = priceDatas[5].Price.ToString("n2");
            lbGasPrice07.Text = priceDatas[6].Price.ToString("n2");
            lbGasPrice08.Text = priceDatas[7].Price.ToString("n2");
            lbGasPrice09.Text = priceDatas[8].Price.ToString("n2");
            lbGasPrice10.Text = priceDatas[9].Price.ToString("n2");
            
        }
    }
}
