using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campeonato_App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Campeonato.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlagPage : ContentPage
    {
        FlagViewModel vm = new FlagViewModel();
        public FlagPage()
        {
            InitializeComponent();
            this.BindingContext = vm;
        }
    }
}