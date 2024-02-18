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
    public partial class TraducirPage : ContentPage
    {
        public TraducirOracionViewModel ViewModel { get { return this.BindingContext as TraducirOracionViewModel; } }
        public TraducirPage()
        {
            InitializeComponent();

            this.lblPalabra.Text = ViewModel.OracionSeleccionada.OracionEspañol.ToUpper();
            this.imgSC.Source = ViewModel.OracionSeleccionada.ImgSC;
            this.imgCC.Source = ViewModel.OracionSeleccionada.ImgCC;

            ViewModel.PropertyChanged += (send, arg) =>
            {

                switch (arg.PropertyName)
                {
                    case "Flag":
                        this.frameMensaje.IsVisible = false;
                        this.btnAmarilloDos.IsVisible = false;
                        this.btnAmarillo.IsVisible = false;
                        this.btnGris.IsVisible = true;
                        this.entryPalabra.Text = string.Empty;
                        this.lblPalabra.Text = ViewModel.OracionSeleccionada.OracionEspañol.ToUpper();
                        this.imgSC.Source = ViewModel.OracionSeleccionada.ImgSC;
                        this.imgCC.Source = ViewModel.OracionSeleccionada.ImgCC;
                        this.imgCC.IsVisible = false;
                        this.imgSC.IsVisible = true;
                        break;
                }

            };
        }

        private void btnAmarillo_Clicked(object sender, EventArgs e)
        {
            this.frameMensaje.IsVisible = true;
            if (this.entryPalabra.Text.ToUpper().Trim() == ViewModel.OracionSeleccionada.OracionTojolabal.ToUpper())
            {                
                this.frameMensaje.BackgroundColor = Color.FromHex("#2185D0");
                this.imgTache.IsVisible = false;
                this.imgCheck.IsVisible = true;
                this.textFelicitacion.Text = ViewModel.OracionSeleccionada.Felicitacion;
                this.imgSC.IsVisible = false;
                this.imgCC.IsVisible = true;
            }
            else
            {
                this.frameMensaje.BackgroundColor = Color.FromHex("#FF4040");
                this.imgTache.IsVisible = true;
                this.imgCheck.IsVisible = false;
                this.textFelicitacion.Text = "La respuesta correcta es: " + ViewModel.OracionSeleccionada.OracionTojolabal.ToUpper();
            }
            this.btnAmarilloDos.IsVisible = true;
        }

        private void btnAmarilloDos_Clicked(object sender, EventArgs e)
        {
            ViewModel.SeleccionarOracionCommand.Execute(null);
        }

        private void entryPalabra_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!e.NewTextValue.Equals(string.Empty))
            {
                this.btnAmarillo.IsVisible = true;
                this.btnGris.IsVisible = false;
            }
            else
            {
                this.btnAmarillo.IsVisible = false;
                this.btnGris.IsVisible = true;
            }
        }
    }
}