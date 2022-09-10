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
    public partial class CenturyPage : ContentPage
    {
        public CenturyPage()
        {
            InitializeComponent();
        }

        private void FindCentury_Clicked(object sender, EventArgs e)
        {
            try
            {                
                Century.Text = TaskClasses.CenturyFind.GetCentury(Convert.ToInt32(Year.Text)).ToString();
            }
            catch
            {
                DisplayAlert("Ошибка", "Необходим год в виде целого и положительного числа", "OK");
            }
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            Century.Text = "";
            Year.Text = "";
        }
    }
}