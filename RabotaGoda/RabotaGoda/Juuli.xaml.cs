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
    public partial class Juuli : TabbedPage
    {
        public Juuli()
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
        }
    }
}