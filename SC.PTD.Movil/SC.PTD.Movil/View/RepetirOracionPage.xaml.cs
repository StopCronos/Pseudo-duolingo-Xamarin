using MediaManager;
using Plugin.SimpleAudioPlayer;
using MediaManager.Player;
using SC.PTD.Movil.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace SC.PTD.Movil.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RepetirOracionPage : ContentPage
    {
        public RepetirOracionViewModel ViewModel { get { return this.BindingContext as RepetirOracionViewModel; } }
        public RepetirOracionPage()
        {
            
            InitializeComponent();
            this.labeltojolabal.Text = ViewModel.OracionSeleccionada.OracionTojolabal;
            this.labelEspañol.Text = ViewModel.OracionSeleccionada.OracionEspañol;
        }

        private  void  TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            try
            {
                if (!ViewModel.IsPlaying)
                {

                    ISimpleAudioPlayer player = CrossSimpleAudioPlayer.Current;
                    var asembly = typeof(App).GetTypeInfo().Assembly;
                    Stream audiostream = asembly.GetManifestResourceStream("SC.PTD.Movil."+ ViewModel.OracionSeleccionada.Url);
                    player.Load(audiostream);
                    player.Play();

                    ViewModel.IsPlaying = true;
                    this.btnGris.IsVisible = false;
                    this.imgSC.IsVisible = false;
                    this.btnAzul.IsVisible = true;
                    this.imgCC.IsVisible = true;

                    player.PlaybackEnded += (obj, args) =>
                    {

                    //DisplayAlert("Audio Terminado", "La reproducción del audio ha finalizado.", "Aceptar");
                    ViewModel.IsPlaying = false;
                    this.btnGris.IsVisible = true;
                    this.imgSC.IsVisible = true;
                    this.btnAzul.IsVisible = false;
                    this.imgCC.IsVisible = false;
                    };

                //await CrossMediaManager.Current.Play("resources/raw:///beep.wav");
                //var mediaInfo = CrossMediaManager.Current;
                //var mediaItem = mediaInfo.Play("https://ia800806.us.archive.org/15/items/Mp3Playlist_555/AaronNeville-CrazyLove.mp3");
                //await mediaInfo.PlayFromAssembly(ViewModel.OracionSeleccionada.Url, typeof(App).GetTypeInfo().Assembly);

                

                //mediaInfo.MediaItemFinished += (obj, args) =>
                //{
                //    ViewModel.IsPlaying = false;
                //    this.btnGris.IsVisible = true;
                //    this.imgSC.IsVisible = true;
                //    this.btnAzul.IsVisible = false;
                //    this.imgCC.IsVisible = false;
                //};


                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            //else
            //{
            //    await CrossMediaManager.Current.Pause();
            //    ViewModel.IsPlaying = false;
            //    this.btnGris.IsVisible = true;
            //    this.imgSC.IsVisible = true;
            //    this.btnAzul.IsVisible = false;
            //    this.imgCC.IsVisible = false;
            //}

        }

    }
}