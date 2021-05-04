using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrjLottery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Cal();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
