using SC.PTD.Movil.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SC.PTD.Movil.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class AbecedarioPage : ContentPage
    {

        AbecedarioViewModel ViewModel { get { return this.BindingContext as AbecedarioViewModel; } }
        public AbecedarioPage()
        {
            InitializeComponent();
        }
    }
}