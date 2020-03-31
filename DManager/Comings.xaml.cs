﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DManager
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Comings : ContentPage
    {
        public Comings()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ComingViewModel();
        }
    }
}