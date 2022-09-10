using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PW2N
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SquareFinder_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TaskPages.CirclePage());            
        }

        private async void CenturyFinder_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TaskPages.CenturyPage());
        }

        private void Help_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Справка", "8. Реализовать расчет задачи:\r\n• " +
                "Даны два круга с общим центром и радиусами R1 и R2 (R1 > R2). " +
                "Найти площади этих кругов S1 и S2, а также площадь S3 кольца, внешний радиус которого равен " +
                "R1, внутренний радиус равен R2: S1 = PI*(R1)2," +
                " S2 = PI*(R2)2, S3 = S1 – S2. В качестве значения PI использовать 3.14.\r\n•" +
                " Дан номер некоторого года (целое положительное число). Определить " +
                "соответствующий ему номер столетия, учитывая, что, к примеру, началом 20 столетия был 1901 год.\r\n", "OK");
        }
    }
}
