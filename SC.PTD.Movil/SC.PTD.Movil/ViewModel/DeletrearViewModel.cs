using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SC.PTD.Movil.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.PTD.Movil.ViewModel
{
    public class DeletrearViewModel: ViewModelBase
    {
        #region Constructor
        public DeletrearViewModel()
        {
            LlenarListasCommand.Execute(null);
            SeleccionarPalabraCommand.Execute(null);
        }
        #endregion
        #region Propiedades

        private bool flag;
        public bool Flag { get => flag; set => Set(ref flag, value); }

        private List<DeletrearModel> palabrasTojolabalLista;
        public List<DeletrearModel> PalabrasTojolabalLista { get => palabrasTojolabalLista; set => Set(ref palabrasTojolabalLista, value); }

        private DeletrearModel palabraSeleccionada;
        public DeletrearModel PalabraSeleccionada { get => palabraSeleccionada; set => Set(ref palabraSeleccionada, value); }
        #endregion
        #region Comandos

        RelayCommand llenarListasCommand = null;
        public RelayCommand LlenarListasCommand
        {
            get => llenarListasCommand ?? (llenarListasCommand = new RelayCommand(() =>
            {
                PalabrasTojolabalLista = new List<DeletrearModel>();
                Random random = new Random();

                PalabrasTojolabalLista.Add(new DeletrearModel
                {
                    Id = 1,
                    PalabraTojolabal = "TATEY",
                    CuantasLetrasEsconder = random.Next(1, 3),
                    Felicitacion = "¡Muy bien!",
                    PalabraEspañol = "PAPÁ"
                });
                PalabrasTojolabalLista.Add(new DeletrearModel
                {
                    Id = 2,
                    PalabraTojolabal = "NANEY",
                    CuantasLetrasEsconder = random.Next(1, 3),
                    Felicitacion = "¡Perfecto!",
                    PalabraEspañol = "MAMÁ"
                });
                PalabrasTojolabalLista.Add(new DeletrearModel
                {
                    Id = 3,
                    PalabraTojolabal = "ME'XEP",
                    CuantasLetrasEsconder = random.Next(1, 3),
                    Felicitacion = "¡Excelente!",
                    PalabraEspañol = "ABUELA"
                });
                PalabrasTojolabalLista.Add(new DeletrearModel
                {
                    Id = 4,
                    PalabraTojolabal = "TATAWELO",
                    CuantasLetrasEsconder = random.Next(3, 5),
                    Felicitacion = "¡Bien!",
                    PalabraEspañol = "ABUELO"
                });
                PalabrasTojolabalLista.Add(new DeletrearModel
                {
                    Id = 5,
                    PalabraTojolabal = "LAK´",
                    CuantasLetrasEsconder = random.Next(3, 5),
                    Felicitacion = "¡Buen trabajo!",
                    PalabraEspañol = "AMIGO"
                });
                PalabrasTojolabalLista.Add(new DeletrearModel
                {
                    Id = 6,
                    PalabraTojolabal = "B'AJTEL",
                    CuantasLetrasEsconder = random.Next(2, 4),
                    Felicitacion = "¡Sigue así!",
                    PalabraEspañol = "BRINCAR"
                });
                PalabrasTojolabalLista.Add(new DeletrearModel
                {
                    Id = 7,
                    PalabraTojolabal = "LUJT'EL",
                    CuantasLetrasEsconder = random.Next(2, 4),
                    Felicitacion = "¡Vay muy bien!",
                    PalabraEspañol = "SALTAR"
                });
                PalabrasTojolabalLista.Add(new DeletrearModel
                {
                    Id = 8,
                    PalabraTojolabal = "CHA'NEL",
                    CuantasLetrasEsconder = random.Next(2, 4),
                    Felicitacion = "¡Perfecto!",
                    PalabraEspañol = "BAILAR"
                });
                PalabrasTojolabalLista.Add(new DeletrearModel
                {
                    Id = 9,
                    PalabraTojolabal = "AJNEL",
                    CuantasLetrasEsconder = random.Next(1, 2),
                    Felicitacion = "¡Excelente!",
                    PalabraEspañol = "CORRER"
                });
                PalabrasTojolabalLista.Add(new DeletrearModel
                {
                    Id = 10,
                    PalabraTojolabal = "AWANEL",
                    CuantasLetrasEsconder = random.Next(1, 3),
                    Felicitacion = "¡Bien!",
                    PalabraEspañol = "GRITAR"
                });
            }, () => { return true; }));
        }


        RelayCommand seleccionarPalabraCommand = null;
        public RelayCommand SeleccionarPalabraCommand
        {
            get => seleccionarPalabraCommand ?? (seleccionarPalabraCommand = new RelayCommand(() =>
            {
                Random random = new Random();
                var n = random.Next(1, 10);
                var index = n;
                PalabraSeleccionada = new DeletrearModel();
                PalabraSeleccionada = palabrasTojolabalLista.Find(x => x.Id.Equals(n));                    

                PalabraSeleccionada.PalabraDeletreada = PalabraSeleccionada.PalabraTojolabal.ToCharArray();
                PalabraSeleccionada.LetrasEscondidas = new char[PalabraSeleccionada.PalabraDeletreada.Length];
                for (int i = 0; i < PalabraSeleccionada.CuantasLetrasEsconder ; i++)
                {
                    while (index == n)
                    {
                        index = random.Next(0, PalabraSeleccionada.PalabraDeletreada.Length);
                    }

                    
                    PalabraSeleccionada.LetrasEscondidas[index] = PalabraSeleccionada.PalabraDeletreada[index];
                    n = index;
                }

                Flag = Flag == true ? false : true;
            }, () => { return true; }));
        }
        #endregion
        #region Metodos

        #endregion
    }
}
