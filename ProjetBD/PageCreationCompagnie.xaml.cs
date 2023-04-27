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
    public sealed partial class PageCreationCompagnie : Page
    {
        public PageCreationCompagnie()
        {
            this.InitializeComponent();
        }

    

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            int valide = 0;
            double cap_prod = 0;
            double prod_reelle = 0;
            double revenu_annuelle=0;
            double prix_baril = 0;

            if (tbxNomCompagnie.Text.Trim() == "")
            {


                E1.Visibility = Visibility.Visible;
                valide += 1;

            }

            if (tbxCapaciteProd.Text.Trim() == "")
            {
                E2.Visibility = Visibility.Visible;
                valide += 1;

            }

            if (tbxProdReel.Text.Trim() == "")
            {
                E3.Visibility = Visibility.Visible;
                valide += 1;

            }

            if (tbxRevenueAnnuel.Text.Trim() == "")
            {
                E4.Visibility = Visibility.Visible;
                valide += 1;
            }
            if (tbxPrixBaril.Text.Trim() == "")
            {
                E5.Visibility = Visibility.Visible;
                valide += 1;
            }
            if(valide == 0)
            {
                cap_prod = Convert.ToDouble(tbxCapaciteProd.Text);
                prod_reelle =Convert.ToDouble(tbxProdReel.Text);
                revenu_annuelle = Convert.ToDouble(tbxRevenueAnnuel.Text);
                prix_baril = Convert.ToDouble(tbxPrixBaril.Text);
                Singleton.getInstance().AjouterCompagnie(tbxNomCompagnie.Text, cap_prod, prod_reelle, revenu_annuelle,prix_baril);
                ajoutcom.Visibility= Visibility.Visible;
            }

        }
    }
}
