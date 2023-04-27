using Microsoft.UI.Xaml;
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

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ProjetBD
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageCreationGissement : Page
    {
        public PageCreationGissement()
        {
            this.InitializeComponent();
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            int valide = 0;

            if (tbxcapacite.Text.Trim() == "")
            {


                E1.Visibility = Visibility.Visible;
                valide += 1;

            }

            if (tbxCapaciteConf.Text.Trim() == "")
            {
                E2.Visibility = Visibility.Visible;
                valide += 1;

            }

            if (tbxlocal.Text.Trim() == "")
            {
                E3.Visibility = Visibility.Visible;
                valide += 1;

            }

            if (valide == 0)
            {

            }
        }
    }
}
