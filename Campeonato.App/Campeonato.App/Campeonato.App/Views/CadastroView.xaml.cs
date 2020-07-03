using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Campeonato.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroView : ContentPage
    {
        public CadastroView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.RemovePage(this);
        }

        private void BtnCadastro_Clicked(object sender, EventArgs e)
        {
           
        }
    }
}