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
    public partial class DeletrearPage : ContentPage
    {
        public DeletrearViewModel ViewModel { get { return this.BindingContext as DeletrearViewModel; } }
        public DeletrearPage()
        {
            InitializeComponent();

            llenarInputs();

            ViewModel.PropertyChanged += (send, arg) =>
            {

                switch (arg.PropertyName)
                {
                    case "Flag":
                        this.frameMensaje.IsVisible = false;
                        this.btnAmarilloDos.IsVisible = false;
                        this.btnAmarillo.IsVisible = false;
                        this.btnGris.IsVisible = true;
                        llenarInputs();
                        break;
                }

            };

        }
        private void llenarInputs()
        {
            this.slEntries.Children.Clear();
            lblPalabra.Text = ViewModel.PalabraSeleccionada.PalabraEspañol;
            lblPalabra.FontSize = ViewModel.PalabraSeleccionada.PalabraEspañol.Length > 6 ? 85 : 90;
            if (ViewModel.PalabraSeleccionada.PalabraDeletreada.Length > 8)
            {
                this.slEntries.Spacing = 1;
            }
            else
            {
                this.slEntries.Spacing = 3;
            }

            for (int i = 0; i < ViewModel.PalabraSeleccionada.PalabraDeletreada.Length; i++)
            {
                Entry Content = new Entry();
                Content.MaxLength = 1;
                Content.Text = ViewModel.PalabraSeleccionada.LetrasEscondidas[i].Equals('\0') ? ViewModel.PalabraSeleccionada.PalabraDeletreada[i].ToString() : string.Empty;
                Content.FontSize = 30;
                Content.FontAttributes = FontAttributes.Bold;
                Content.Keyboard = Keyboard.Plain;
                Content.MaxLength = 1;
                Content.Margin = new Thickness(5, 5);
                Content.TextChanged += entryPalabra_TextChanged;


                Frame frame = new Frame();
                frame.BackgroundColor = Color.Transparent;
                frame.BorderColor = Color.FromHex("#707070");
                frame.Padding = ViewModel.PalabraSeleccionada.PalabraDeletreada.Length > 7 ? new Thickness(0, 0) : new Thickness(5, 0);
                frame.Content = Content;

                this.slEntries.Children.Add(frame);
            }
        }

        private void btnAmarilloDos_Clicked(object sender, EventArgs e)
        {
            ViewModel.SeleccionarPalabraCommand.Execute(null);
        }

        private void btnAmarillo_Clicked(object sender, EventArgs e)
        {
            List<Frame> inputs = this.slEntries.Children.Cast<Frame>().Where(x => x is Frame).ToList();
            var count = 0;
            bool flag = true;
            foreach (var item in inputs)
            {
                if ((item.Content as Entry).Text.ToUpper() != ViewModel.PalabraSeleccionada.PalabraDeletreada[count].ToString().ToUpper())
                {
                    flag = false;
                    break;
                }
                count++;
            }
            this.frameMensaje.IsVisible = true;
            if (flag)
            {
                this.frameMensaje.BackgroundColor = Color.FromHex("#2185D0");
                this.imgTache.IsVisible = false;
                this.imgCheck.IsVisible = true;
                this.textFelicitacion.Text = ViewModel.PalabraSeleccionada.Felicitacion;
            }
            else
            {
                this.frameMensaje.BackgroundColor = Color.FromHex("#FF4040");
                this.imgTache.IsVisible = true;
                this.imgCheck.IsVisible = false;
                this.textFelicitacion.Text = "La respuesta correcta es: " + ViewModel.PalabraSeleccionada.PalabraTojolabal.ToUpper();
            }
            this.btnAmarilloDos.IsVisible = true;

        }

        private void entryPalabra_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Frame> inputs = this.slEntries.Children.Cast<Frame>().Where(x => x is Frame).ToList();

            //List<Entry> entry = inputs.Where(x => x.Content is Entry).ToList().Cast<Entry>().ToList();
            //var count = 0;
            //string[] a = new string[inputs.LongCount()];
            //a[count] =
            //count++;
            bool flag = false;
            foreach (var item in inputs)
            {                
                if ((item.Content as Entry).Text == string.Empty)
                {
                    flag = true;
                    break;
                }
            }

            if (flag == false)
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