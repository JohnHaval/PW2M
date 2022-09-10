using PW2N.TaskClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PW2N.TaskPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CirclePage : ContentPage
    {
        public CirclePage()
        {
            InitializeComponent();
        }

        private void FindSquares_Clicked(object sender, EventArgs e)
        {
            try
            {
                SquareFind pack = new SquareFind(Convert.ToDouble(Radius1.Text), Convert.ToDouble(Radius2.Text));                
                Square1.Text = pack.FindS1().ToString();
                Square2.Text = pack.FindS2().ToString();
                Square3.Text = pack.FindS3().ToString();
            }
            catch(Exception ex)
            {
                DisplayAlert("Ошибка", ex.Message, "OK");
            }
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            Radius1.Text = "";
            Radius2.Text = "";
            Square1.Text = "";
            Square2.Text = "";
            Square3.Text = "";
        }
    }
}