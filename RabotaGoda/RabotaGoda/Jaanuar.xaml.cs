﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RabotaGoda
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Jaanuar : ContentPage
    {
        public Jaanuar()
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
                ColumnDefinitions=
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };
            Label nimetus = new Label { Text = "Jaanuar", FontSize = 50 };
            Image img = new Image { Source = "Jaanuar.jpg" };
            Label kirjeldus = new Label { Text = "Давай, нажми на картинку и узнаешь интересный факт, но знай, что это одноразовое действие)" };
            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Доп. инфо", "11 января - Международный день спасибо \n Пожалуйста ", "закрыть");
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