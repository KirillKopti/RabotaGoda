using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RabotaGoda
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Oktoober : ContentPage
    {
        public Oktoober()
        {
            InitializeComponent();
            Grid grd = new Grid
            {
                RowDefinitions =
                {
                  new RowDefinition {Height=new GridLength(1,GridUnitType.Star)},
                  new RowDefinition {Height=new GridLength(1,GridUnitType.Star)},
                  new RowDefinition {Height=new GridLength(1,GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };
            Label nimetus = new Label { Text = "November", FontSize = 50 };
            Image img = new Image { Source = "November.jpg" };
            Label kirjeldus = new Label { Text = "Давай, нажми на картинку" };
            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Доп. инфо", "9 октября - Всемирный день яйца \n Яичница, я иду ", "закрыть");
                img.Opacity = 0;
            };
            img.GestureRecognizers.Add(tap1);
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }
    }
}