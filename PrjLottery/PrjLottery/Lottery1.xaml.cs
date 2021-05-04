using PrjLottery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace PrjLottery
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lottery1 : ContentPage
    {
        public Lottery1()
        {
            InitializeComponent();
           
           
            Nums.Text = "樂透號碼"+(new CLott()).RanLot();
           
            
           
        }
    }
}