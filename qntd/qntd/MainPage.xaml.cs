using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace qntd
{
    public partial class MainPage : ContentPage
    {
        int quantidade = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Soma(object sender, EventArgs e)
        {
            quantidade++;
            Lblqntd.Text = quantidade.ToString();
        }

        private void Subtrair(object sender, EventArgs e)
        {
            if (quantidade > 0) { 
            quantidade--;
            Lblqntd.Text = quantidade.ToString();
            }
            else
            {
                quantidade = 0;
            }
        }
    }
}
