﻿using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using MySql.Data.MySqlClient; 

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ProjetBD
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
           //lvliste.ItemsSource = Singleton.getInstance().GetCompagnie();
        }

        //private void iDeconnexion_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    ContentDialog dialog = new ContentDialog();
        //    dialog.Title = "Test";
        //    dialog.CloseButtonText = "OK";
        //    dialog.Content = "OK";

        //      dialog.ShowAsync();
        //}

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            var item = (NavigationViewItem)args.SelectedItem;

            switch (item.Tag)
            {
                case "Creation":
                    mainFrame.Navigate(typeof(PageCreationCompagnie));
                    break;
                case "gissement":
                    mainFrame.Navigate(typeof(PageCreationGissement));
                    break;

                default:
                    break;

            }
            try
            {
                tblHeader.Text = item.Content.ToString();
            }
            catch (Exception)
            {
                tblHeader.Text = "vide";

            };
        }



    }
}
