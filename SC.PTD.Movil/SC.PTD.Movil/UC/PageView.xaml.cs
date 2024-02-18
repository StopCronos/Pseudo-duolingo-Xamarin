using SC.PTD.Movil.View;
using SC.PTD.Movil.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SC.PTD.Movil.UC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class PageView : ContentView
    {
        public AbecedarioViewModel AbecedarioViewModel { get { return this.BindingContext as AbecedarioViewModel; } }
        public PageView()
        {
            InitializeComponent();
            enfocarIconoActual();
        }

        public void enfocarIconoActual()
        {
            this.frameAbecedario.BackgroundColor = Color.Transparent;
            if (((App)App.Current).MyProperty == "AbecedarioPage")
            {
                this.frameAbecedario.BackgroundColor = Color.FromHex("#80ffffff");
            }else if (((App)App.Current).MyProperty == "TraducirPage")
            {
                this.frameTraducr.BackgroundColor = Color.FromHex("#80ffffff");
                
            }else if (((App)App.Current).MyProperty == "RepetirOracionPage")
            {
                this.frameRepetir.BackgroundColor = Color.FromHex("#80ffffff");
                this.frameAbecedario.BackgroundColor = Color.Transparent;
            }else if (((App)App.Current).MyProperty == "CompletarPage")
            {
                this.frameCompletar.BackgroundColor = Color.FromHex("#80ffffff");
                this.frameAbecedario.BackgroundColor = Color.Transparent;
            }else if (((App)App.Current).MyProperty == "DeletrearPage")
            {
                this.frameDeletrear.BackgroundColor = Color.FromHex("#80ffffff");
                this.frameAbecedario.BackgroundColor = Color.Transparent;
            }
        }

        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set
            {
                SetValue(TituloProperty, value);
            }
        }
        public static readonly BindableProperty TituloProperty = BindableProperty.Create(nameof(Titulo), typeof(string), typeof(PageView), default(string),
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var me = (PageView)bindable;
            me.Titulo = (string)newValue;
            me.TituloLabel.Text = me.Titulo;
        });

        public Xamarin.Forms.View Contenido
        {
            get
            {
                return ContenidoFrame.Content;
            }
            set
            {
                ContenidoFrame.Content = value;
            }
        }
        public Xamarin.Forms.View ContenidoPie
        {
            get
            {
                return ContenidoPieFrame.Content;
            }
            set
            {
                ContenidoPieFrame.Content = value;
            }
        }
        private void TapGestureRecognizer_Tapped0(object sender, EventArgs e)
        {
            if (((App)App.Current).MyProperty != "AbecedarioPage")
            {
                ((App)App.Current).MyProperty = "AbecedarioPage";
                Navigation.PushAsync(new AbecedarioPage());

                
                //enfocarIconoActual();
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (((App)App.Current).MyProperty != "TraducirPage")
            {
                ((App)App.Current).MyProperty = "TraducirPage";
                Navigation.PushAsync(new TraducirPage());

                
                //enfocarIconoActual();
            }
        }

        private void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
            if (((App)App.Current).MyProperty != "RepetirOracionPage")
            {
                ((App)App.Current).MyProperty = "RepetirOracionPage";
                Navigation.PushAsync(new RepetirOracionPage());

                
                //enfocarIconoActual();
            }
        }

        private void TapGestureRecognizer_Tapped2(object sender, EventArgs e)
        {
            if (((App)App.Current).MyProperty != "CompletarPage")
            {
                ((App)App.Current).MyProperty = "CompletarPage";
                Navigation.PushAsync(new CompletarFrasePage());

                
                //enfocarIconoActual();
            }
        }

        private void TapGestureRecognizer_Tapped3(object sender, EventArgs e)
        {
            if (((App)App.Current).MyProperty != "DeletrearPage")
            {
                ((App)App.Current).MyProperty = "DeletrearPage";
                Navigation.PushAsync(new DeletrearPage());

                
                //enfocarIconoActual();
            }
        }
    }
}