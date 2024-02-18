using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SC.PTD.Movil.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;

namespace SC.PTD.Movil.ViewModel
{
    public class RepetirOracionViewModel: ViewModelBase
    {
        #region Contructor
        public RepetirOracionViewModel()
        {
            LlenarListasCommand.Execute(null);
        }

        #endregion

        #region Propiedades


        private ObservableCollection<RepetirOracionModel> oracionesList;
        public ObservableCollection<RepetirOracionModel> OracionesList { get => oracionesList; set => Set(ref oracionesList, value); }


        private RepetirOracionModel oracionSeleccionada = new RepetirOracionModel();
        public RepetirOracionModel OracionSeleccionada { get => oracionSeleccionada; set => Set(ref oracionSeleccionada, value); }

        private string oracionTojo;
        public string OracionTojo { get => oracionTojo; set => Set(ref oracionTojo, value); }

        private string oracionEsp;
        public string OracionEsp { get => oracionEsp; set => Set(ref oracionEsp, value); }


        private bool seleccionado;
        public bool Seleccionado { get => seleccionado; set => Set(ref seleccionado, value); }

        private string property;
        public string Property { get => property; set => Set(ref property, value); }

        private bool isPlaying;
        public bool IsPlaying { get => isPlaying; set => Set(ref isPlaying, value); }


        #endregion

        #region Comandos


        RelayCommand reproducirCommand = null;
        public RelayCommand ReproducirCommand
        {
            get => reproducirCommand ?? (reproducirCommand = new RelayCommand(() =>
            {
                var assembly = typeof(App).GetTypeInfo().Assembly;

                Stream audioStream = assembly.GetManifestResourceStream("SC.PTD.Movil." + "file_example_WAV_1MG.wav");

                var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                player.Load(audioStream);
                player.Play();
            }, () => { return true; }));
        }


        RelayCommand llenarListasCommand = null;
        public RelayCommand LlenarListasCommand
        {
            get => llenarListasCommand ?? (llenarListasCommand = new RelayCommand(() =>
            {
                OracionesList = new ObservableCollection<RepetirOracionModel>();
                OracionesList.Add(new RepetirOracionModel
                {
                    Id = 1,
                    OracionTojolabal = "Ja Jbi'il ja keni'",
                    OracionEspañol = "(Mi nombre es)",
                    Url = "JaJbiIlJaKen.aac"
                });
                OracionesList.Add(new RepetirOracionModel
                {
                    Id = 2,
                    OracionTojolabal = "Jastal aya?",
                    OracionEspañol = "(¿Cómo estás?)",
                    Url = "JastalAya.aac"
                });
                OracionesList.Add(new RepetirOracionModel
                {
                    Id = 3,
                    OracionTojolabal = "Sa'n apetsanilex",
                    OracionEspañol = "(Buenos días a todos y a todas)",
                    Url = "SaNApetsanilex.mp3"
                });
                OracionesList.Add(new RepetirOracionModel
                {
                    Id = 4,
                    OracionTojolabal = "Ojma wa'anik?",
                    OracionEspañol = "(¿Van a comer?)",
                    Url = "OjmaWaAnik.aac"
                });
                OracionesList.Add(new RepetirOracionModel
                {
                    Id = 5,
                    OracionTojolabal = "Jna' jbajtik",
                    OracionEspañol = "(Vamos a conocernos)",
                    Url = "JnaBajtik.aac"
                });
                OracionesList.Add(new RepetirOracionModel
                {
                    Id = 6,
                    OracionTojolabal = "B'a wajuma'a?",
                    OracionEspañol = "(¿A dónde vas?)",
                    Url = "BaWalaWaaa.aac"
                });
                OracionesList.Add(new RepetirOracionModel
                {
                    Id = 7,
                    OracionTojolabal = "Ojma b'ob' ochkon?",
                    OracionEspañol = "(¿Puedo pasar?)",
                    Url = "OjmaBobOchkon.aac"
                });
                OracionesList.Add(new RepetirOracionModel
                {
                    Id = 8,
                    OracionTojolabal = "Waj b'a yatel ja tati'",
                    OracionEspañol = "(Mi papá se fue al trabajo)",
                    Url = "WajbaYatelJaTati.aac"
                });
                OracionesList.Add(new RepetirOracionModel
                {
                    Id = 9,
                    OracionTojolabal = "Ojkankon",
                    OracionEspañol = "(Voy a quedarme)",
                    Url = "OjKankon.aac"
                });
                OracionesList.Add(new RepetirOracionModel
                {
                    Id = 10,
                    OracionTojolabal = "Jayexa wajab'ili'?",
                    OracionEspañol = "(¿Cuántos años tienes?)",
                    Url = "JayeXaWaJabili.aac"
                });

                Random randomN = new Random();

                int n = randomN.Next(1, 11);
                OracionSeleccionada = new RepetirOracionModel();

                OracionSeleccionada = (RepetirOracionModel)OracionesList.Where(x => x.Id.Equals(n)).FirstOrDefault();
            }, () => { return true; }));
        }

        #endregion
    }
}
