using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SC.PTD.Movil.Model;
using System;
using System.Collections.Generic;

namespace SC.PTD.Movil.ViewModel
{
    public class TraducirOracionViewModel : ViewModelBase
    {
        #region Constructor
        public TraducirOracionViewModel()
        {
            LlenarListasCommand.Execute(null);
            SeleccionarOracionCommand.Execute(null);
        }
        #endregion
        #region Propiedades

        private List<TraducirOracionModel> oracionesLista;
        public List<TraducirOracionModel> OracionseLista { get => oracionesLista; set => Set(ref oracionesLista, value); }

        private TraducirOracionModel oracionSeleccionada;
        public TraducirOracionModel OracionSeleccionada { get => oracionSeleccionada; set => Set(ref oracionSeleccionada, value); }

        private bool flag;
        public bool Flag { get => flag; set => Set(ref flag, value); }
        #endregion
        #region Comandos

        RelayCommand seleccionarOracionCommand = null;
        public RelayCommand SeleccionarOracionCommand
        {
            get => seleccionarOracionCommand ?? (seleccionarOracionCommand = new RelayCommand(() =>
            {
                Random randomN = new Random();
                int n = randomN.Next(1, 10);

                if (OracionSeleccionada != null)
                    while (n == OracionSeleccionada.Id)
                    {
                        n = randomN.Next(1, 11);
                    }

                OracionSeleccionada = OracionseLista.Find(x => x.Id.Equals(n));
                Flag = Flag == true ? false : true;
            }, () => { return true; }));
        }

        RelayCommand llenarListasCommand = null;
        public RelayCommand LlenarListasCommand
        {
            get => llenarListasCommand ?? (llenarListasCommand = new RelayCommand(() =>
            {
                OracionseLista = new List<TraducirOracionModel>();
                OracionseLista.Add(new TraducirOracionModel
                {
                    Id = 1,
                    OracionEspañol = "PAPÁ",
                    OracionTojolabal = "TATEY",
                    ImgSC = "fatherSC64.png",
                    ImgCC = "fatherCC64.png",
                    Felicitacion = "¡Muy bien!"
                });
                OracionseLista.Add(new TraducirOracionModel
                {
                    Id = 2,
                    OracionEspañol = "MAMÁ",
                    OracionTojolabal = "NANEY",
                    ImgSC = "momSC64.png",
                    ImgCC = "momCC64.png",
                    Felicitacion = "¡Excelente!"
                });
                OracionseLista.Add(new TraducirOracionModel
                {
                    Id = 3,
                    OracionEspañol = "ABUELO",
                    OracionTojolabal = "TATAWELO",
                    ImgSC = "grandpaSC64.png",
                    ImgCC = "grandpaCC64.png",
                    Felicitacion = "¡Perfecto!"
                });
                OracionseLista.Add(new TraducirOracionModel
                {
                    Id = 4,
                    OracionEspañol = "ABUELA",
                    OracionTojolabal = "MEXEP",
                    ImgSC = "grandmaSC64.png",
                    ImgCC = "grandmaCC64.png",
                    Felicitacion = "¡Buen trabajo!"
                });
                OracionseLista.Add(new TraducirOracionModel
                {
                    Id = 5,
                    OracionEspañol = "Perro",
                    OracionTojolabal = "Ts'i",
                    ImgSC = "dogSC64.png",
                    ImgCC = "dogCC64.png",
                    Felicitacion = "¡Bien hecho!"
                });
                OracionseLista.Add(new TraducirOracionModel
                {
                    Id = 6,
                    OracionEspañol = "Vaca",
                    OracionTojolabal = "Wakax",
                    ImgSC = "vacaSC64.png",
                    ImgCC = "vacaCC64.png",
                    Felicitacion = "¡Excelente!"
                });
                OracionseLista.Add(new TraducirOracionModel
                {
                    Id = 7,
                    OracionEspañol = "Burro",
                    OracionTojolabal = "buruj",
                    ImgSC = "burroSC64.png",
                    ImgCC = "burroCC64.png",
                    Felicitacion = "¡Muy bien!"
                });
                OracionseLista.Add(new TraducirOracionModel
                {
                    Id = 8,
                    OracionEspañol = "Gallina",
                    OracionTojolabal = "mut",
                    ImgSC = "gallinaSC64.png",
                    ImgCC = "gallinaCC64.png",
                    Felicitacion = "¡Buen trabajo!"
                });
                OracionseLista.Add(new TraducirOracionModel
                {
                    Id = 9,
                    OracionEspañol = "Oveja",
                    OracionTojolabal = "chej",
                    ImgSC = "ovejaSC64.png",
                    ImgCC = "ovejaCC64.png",
                    Felicitacion = "¡Bien hecho!"
                });

            }, () => { return true; }));
        }

        #endregion
        #region Metodos

        #endregion
    }
}
