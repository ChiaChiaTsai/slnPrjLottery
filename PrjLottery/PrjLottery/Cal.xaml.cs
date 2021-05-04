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
    public partial class Cal : ContentPage
    {
        public Cal()
        {
            InitializeComponent();
        }
        double n1 = 0,n0=0;
        int count = 0;
        string op = "",op1="";
        bool optb=false;
        private void BtnNum_Clicked(object sender, EventArgs e)
        {
            //int n = Convert.ToInt32(AnsN.Text);
            //string input = (sender as Button).Text;

            //    if (n == 0)
            //    { AnsN.Text = input; }
            //    else
            //    { AnsN.Text += input; }
            int n = Convert.ToInt32(AnsN.Text);
            string input = (sender as Button).Text;
            if (n == 0||optb) 
            { AnsN.Text = input; optb = false; }
            else { AnsN.Text += input; }
            
        }
           
           
          
        private void  BtnOpe_Clicked(object sender, EventArgs e)
        {
            //n1 = Convert.ToInt32(AnsN.Text);
            //op = (sender as Button).Text;
            //AnsN.Text = "0";
            
            n1 = Convert.ToInt32(AnsN.Text);
             string op0 = op;
            op = (sender as Button).Text;
            if (count > 0)
            {
               
                if (op0 == "+") { AnsN.Text = (n0 + n1).ToString(); n1 = Convert.ToInt32(AnsN.Text); count = 0; }
                else if (op0 == "-") { AnsN.Text = (n0 - n1).ToString(); n1 = Convert.ToInt32(AnsN.Text); count = 0; }
                else if (op0 == "*") { AnsN.Text = (n0 * n1).ToString(); n1 = Convert.ToInt32(AnsN.Text); count = 0; }
                else if (op0 == "/") { AnsN.Text = (n0 / n1).ToString(); n1 = Convert.ToInt32(AnsN.Text); count = 0; }
                else { AnsN.Text = "Error"; optb = true; }
                n0 = n1;
            }
            else {n0 = n1;} 
            count++;
            optb = true;
            
        }
        private void BtnEqual_Clicked(object sender, EventArgs e)
        {
            //double n2 = Convert.ToInt32(AnsN.Text);
            //if (op == "+")
            //{ AnsN.Text = (n1 + n2).ToString(); }
            //else if (op == "-")
            //{ AnsN.Text = (n1 - n2).ToString(); }
            //else if (op == "*")
            //{ AnsN.Text = (n1 * n2).ToString(); }
            //else if (op == "/"&&n2!=0)
            //{
            //    double x = n1 / n2;
            //    AnsN.Text = (x).ToString(); }
            //else
            //{ AnsN.Text = "Error"; }

            double n2 = Convert.ToDouble(AnsN.Text);
            if (op == "+")
            { AnsN.Text = (n1 + n2).ToString(); }
            else if (op == "-")
            { AnsN.Text = (n1 - n2).ToString(); }
            else if (op == "*")
            { AnsN.Text = (n1 * n2).ToString(); }
            else if (op == "/" && n2 != 0)
            {
                double x = n1 / n2;
                AnsN.Text = (x).ToString();
            }
            else
            { AnsN.Text = "Error"; }

            count = 0;
            
            optb = true;




        }
    }
}