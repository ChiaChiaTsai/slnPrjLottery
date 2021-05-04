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
    public partial class xfunc : ContentPage
    {
        public xfunc()
        {
            InitializeComponent();
            
        }
        private void btn_click(object sender,EventArgs e) 
        {
            
            double A, B, C;
            A = Convert.ToDouble(a.Text);
            B = Convert.ToDouble(b.Text);
            C = Convert.ToDouble(c.Text);
            double Ans1,Ans2, va;
            va = Math.Sqrt(B*B-4*A*C);
            Ans1 = (-B + va) / (2 * A);
            Ans2 = (-B - va) / (2 * A);
            Ans.Text = " Ans1=" + Ans1.ToString("0.0#")+" Ans2="+Ans2.ToString("0.0#");


        }

    }
}