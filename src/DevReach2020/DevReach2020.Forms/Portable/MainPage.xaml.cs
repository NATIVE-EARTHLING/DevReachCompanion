﻿using System.Diagnostics;
using DevReach2020.Forms.Portable.Helpers;
using DevReach2020.Forms.Portable.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DevReach2020.Forms.Portable
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage, ITabAwarePage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel { TabAwarePage = this };
        }

        public void SelectTab(string tabName)
        {
            switch (tabName)
            {
                case AppConstants.HomeTabName:
                    MainTabView.SelectedItem = MainTabView.Items[0];
                    break;
                case AppConstants.LiveTabName:
                    MainTabView.SelectedItem = MainTabView.Items[1];
                    break;
                case AppConstants.AboutTabName:
                    MainTabView.SelectedItem = MainTabView.Items[2];
                    break;
                default:
                    Trace.WriteLine($"Invalid selection: {tabName}");
                    break;
            }
        }
    }
}