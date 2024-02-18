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
    public partial class CompletarFrasePage : ContentPage
    {
        public CompletarFraseViewModel ViewModel { get { return this.BindingContext as CompletarFraseViewModel; } }
        public AbecedarioViewModel AbecedarioViewModel { get { return this.BindingContext as AbecedarioViewModel; } }
        public CompletarFrasePage()
        {
            InitializeComponent();
            
            this.labelPreEscondida.Text = ViewModel.OracionSeleccionada.OracionPrePalabraFaltante;
            this.labelPosEscondida.Text = ViewModel.OracionSeleccionada.OracionPostPalabraFaltante;
            this.btnGris.IsVisible = true;
            this.btnAmarillo.IsVisible = false;
            this.btnAmarilloDos.IsVisible = false;

            if (ViewModel.OracionSeleccionada.PalabraFaltaEnmedioFinal == 1)
            {
                this.labelPreEscondida.IsVisible = true;
                this.labelPosEscondida.IsVisible = true;
                this.labelLineaMedio.IsVisible = true;

            }
            else
            {
                this.labelPreEscondida.IsVisible = true;
                this.labelLineaFinal.IsVisible = true;
            }

            this.radioUno.Content = ViewModel.PalabraUno;
            this.radioDos.Content = ViewModel.PalabraDos;
            this.radioTres.Content = ViewModel.PalabraTres;

            this.radioUno.Value = ViewModel.IdUno;
            this.radioDos.Value = ViewModel.IdDos;
            this.radioTres.Value = ViewModel.IdTres;

            ViewModel.PropertyChanged += (send, arg) =>
            {

                switch (arg.PropertyName)
                {
                    case "Flag":
                        this.labelPreEscondida.Text = ViewModel.OracionSeleccionada.OracionPrePalabraFaltante;
                        this.labelPosEscondida.Text = ViewModel.OracionSeleccionada.OracionPostPalabraFaltante;

                        
                        this.btnAmarillo.IsVisible = false;
                        this.btnAmarilloDos.IsVisible = false;

                        this.labelPreEscondida.IsVisible = false;
                        this.labelPosEscondida.IsVisible = false;
                        this.labelLineaMedio.IsVisible = false;
                        this.labelLineaFinal.IsVisible = false;

                        if (ViewModel.OracionSeleccionada.PalabraFaltaEnmedioFinal == 1)
                        {
                            this.labelPreEscondida.IsVisible = true;
                            this.labelPosEscondida.IsVisible = true;
                            this.labelLineaMedio.IsVisible = true;

                        }
                        else
                        {
                            this.labelPreEscondida.IsVisible = true;
                            this.labelLineaFinal.IsVisible = true;
                        }

                        this.radioUno.Content = ViewModel.PalabraUno;
                        this.radioDos.Content = ViewModel.PalabraDos;
                        this.radioTres.Content = ViewModel.PalabraTres;

                        this.radioUno.Value = ViewModel.IdUno;
                        this.radioDos.Value = ViewModel.IdDos;
                        this.radioTres.Value = ViewModel.IdTres;

                        
                        break;
                }
            };
        }

        private void radioUno_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (this.radioUno.IsChecked == true || this.radioDos.IsChecked == true || this.radioTres.IsChecked == true)
            {
                this.btnGris.IsVisible = false;
                this.btnAmarillo.IsVisible = true;
            }
        }

        private void btnAmarillo_Clicked(object sender, EventArgs e)
        {
            this.frameMensaje.IsVisible = true;
            if (this.radioUno.IsChecked == true && this.radioUno.Value.Equals(ViewModel.OracionSeleccionada.Id))
            {
                this.radioUno.IsEnabled = true;
                this.radioDos.IsEnabled = false;
                this.radioTres.IsEnabled = false;
                this.textFelicitacion.Text = "¡Muy bien!";
            }
            else if (this.radioDos.IsChecked == true && this.radioDos.Value.Equals(ViewModel.OracionSeleccionada.Id))
            {
                this.radioUno.IsEnabled = false;
                this.radioDos.IsEnabled = true;
                this.radioTres.IsEnabled = false;
                this.textFelicitacion.Text = "¡Buen trabajo!";
            }
            else if (this.radioTres.IsChecked == true && this.radioTres.Value.Equals(ViewModel.OracionSeleccionada.Id))
            {
                this.radioUno.IsEnabled = false;
                this.radioDos.IsEnabled = false;
                this.radioTres.IsEnabled = true;
                this.textFelicitacion.Text = "¡Correcto!";
            }
            else
            {
                if (this.radioUno.IsChecked == true)
                {
                    this.radioUno.IsEnabled = true;
                    this.radioDos.IsEnabled = false;
                    this.radioTres.IsEnabled = false;
                }
                if (this.radioDos.IsChecked == true)
                {
                    this.radioUno.IsEnabled = false;
                    this.radioDos.IsEnabled = true;
                    this.radioTres.IsEnabled = false;
                }
                if (this.radioTres.IsChecked == true)
                {
                    this.radioUno.IsEnabled = false;
                    this.radioDos.IsEnabled = false;
                    this.radioTres.IsEnabled = true;
                }

                this.imgCheck.IsVisible = false;
                this.imgTache.IsVisible = true;
                this.textFelicitacion.Text = "La respuesta correcta es: " + ViewModel.PalabraFaltanteSeleccionada.PalabraEscondida;
                this.frameMensaje.BackgroundColor = Color.FromHex("#FF4040");
            }

            this.btnAmarilloDos.IsVisible = true;
            this.btnAmarillo.IsVisible = false;
        }

        private void btnAmarilloDos_Clicked(object sender, EventArgs e)
        {
            ViewModel.RifarOracionCommand.Execute(null);

            this.radioUno.IsChecked = false;
            this.radioDos.IsChecked = false;
            this.radioTres.IsChecked = false;

            this.radioUno.IsEnabled = true;
            this.radioDos.IsEnabled = true;
            this.radioTres.IsEnabled = true;

            this.frameMensaje.IsVisible = false;
            this.frameMensaje.BackgroundColor = Color.FromHex("#2185D0");
            this.imgCheck.IsVisible = true;
            this.imgTache.IsVisible = false;
            this.btnAmarillo.IsVisible = false;
            this.btnAmarilloDos.IsVisible = false;
            this.btnGris.IsVisible = true;
        }
    }
}