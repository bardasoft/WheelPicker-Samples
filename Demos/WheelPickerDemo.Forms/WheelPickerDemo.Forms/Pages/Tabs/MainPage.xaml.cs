﻿using System;
using WheelPickerDemo.Forms.Models;
using Xamarin.Forms;

namespace WheelPickerDemo.Forms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageModel();
        }

        private void ButtonSpin_OnClicked(object sender, EventArgs e)
        {
            WheelImagePicker.Spin(-100,0);
        }
    }

    internal class MainPageModel
    {
        public ImageWheelModel PickerModel { get; } = new ImageWheelModel();
    }
}