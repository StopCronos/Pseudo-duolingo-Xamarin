using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SC.PTD.Movil.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.PTD.Movil.ViewModel
{
    public class CompletarFraseViewModel : ViewModelBase
    {
        #region Constructor
        public CompletarFraseViewModel()
        {
            LlenarListasCommand.Execute(null);
            RifarOracionCommand.Execute(null);
        }
        #endregion
        #region Propiedades

        private bool flag;
        public bool Flag { get => flag; set => Set(ref flag, value); }

        private List<CompletarFraseModel> frasesIncompletasList;
        public List<CompletarFraseModel> FrasesIncompletasList { get => frasesIncompletasList; set => Set(ref frasesIncompletasList, value); }

        private List<PalabraFaltante> palabrasFaltantesList;
        public List<PalabraFaltante> PalabrasFaltantesList { get => palabrasFaltantesList; set => Set(ref palabrasFaltantesList, value); }

        private CompletarFraseModel oracionSeleccionada;
        public CompletarFraseModel OracionSeleccionada { get => oracionSeleccionada; set => Set(ref oracionSeleccionada, value); }

        private PalabraFaltante palabraFaltanteSeleccionada;
        public PalabraFaltante PalabraFaltanteSeleccionada { get => palabraFaltanteSeleccionada; set => Set(ref palabraFaltanteSeleccionada, value); }

        private string palabraUno;
        public string PalabraUno { get => palabraUno; set => Set(ref palabraUno, value); }

        private string palabraDos;
        public string PalabraDos { get => palabraDos; set => Set(ref palabraDos, value); }

        private string palabraTres;
        public string PalabraTres { get => palabraTres; set => Set(ref palabraTres, value); }


        private int idUno;
        public int IdUno { get => idUno; set => Set(ref idUno, value); }

        private int idDos;
        public int IdDos { get => idDos; set => Set(ref idDos, value); }

        private int idTres;
        public int IdTres { get => idTres; set => Set(ref idTres, value); }



        #endregion
        #region Comandos


        RelayCommand rifarOracionCommand = null;
        public RelayCommand RifarOracionCommand
        {
            get => rifarOracionCommand ?? (rifarOracionCommand = new RelayCommand(() =>
            {
                Random randomN = new Random();

                int n = randomN.Next(1, 11);
                if(OracionSeleccionada != null)
                    while (n == OracionSeleccionada.Id)
                    {
                        n = randomN.Next(1, 11);
                    }

                OracionSeleccionada = FrasesIncompletasList.Find(x => x.Id.Equals(n));

                PalabraFaltanteSeleccionada = PalabrasFaltantesList.Find(x => x.Id.Equals(n));
                int ndos = n;
                int ntres = n;

                while (ndos == n || ntres == n || ntres == ndos)
                {
                    ndos = randomN.Next(1, 11);
                    ntres = randomN.Next(1, 11);
                }

                n = randomN.Next(1, 4);

                if (n == 1)
                {
                    IdUno = PalabraFaltanteSeleccionada.Id;
                    IdDos = ndos;
                    IdTres = ntres;

                    PalabraUno = PalabraFaltanteSeleccionada.PalabraEscondida;
                    PalabraDos = PalabrasFaltantesList.Find(x => x.Id.Equals(ndos)).PalabraEscondida;
                    PalabraTres = PalabrasFaltantesList.Find(x => x.Id.Equals(ntres)).PalabraEscondida;
                }
                if (n == 2)
                {
                    IdUno = ndos;
                    IdDos = PalabraFaltanteSeleccionada.Id;
                    IdTres = ntres;

                    PalabraUno = PalabrasFaltantesList.Find(x => x.Id.Equals(ndos)).PalabraEscondida;
                    PalabraDos = PalabraFaltanteSeleccionada.PalabraEscondida;
                    PalabraTres = PalabrasFaltantesList.Find(x => x.Id.Equals(ntres)).PalabraEscondida;
                }
                if (n == 3)
                {
                    IdUno = ntres;
                    IdDos = ndos;
                    IdTres = PalabraFaltanteSeleccionada.Id;

                    PalabraUno = PalabrasFaltantesList.Find(x => x.Id.Equals(ntres)).PalabraEscondida;
                    PalabraDos = PalabrasFaltantesList.Find(x => x.Id.Equals(ndos)).PalabraEscondida;
                    PalabraTres = PalabraFaltanteSeleccionada.PalabraEscondida;
                }
                Flag = Flag == true ? false : true;
            }, () => { return true; }));
        }

        RelayCommand llenarListasCommand = null;
        public RelayCommand LlenarListasCommand
        {
            get => llenarListasCommand ?? (llenarListasCommand = new RelayCommand(() =>
            {
                FrasesIncompletasList = new List<CompletarFraseModel>();

                FrasesIncompletasList.Add(new CompletarFraseModel
                {
                    Id = 1,
                    OracionIncompleta = "Wan ts´eb´anel ja jnani´",
                    OracionPrePalabraFaltante = "Wan ",
                    OracionPostPalabraFaltante = " ja jnani´",
                    PalabraFaltaEnmedioFinal = 1

                });
                FrasesIncompletasList.Add(new CompletarFraseModel
                {
                    Id = 2,
                    OracionIncompleta = "Wan wayel ja jtati´",
                    OracionPrePalabraFaltante = "Wan wayel ja ",
                    OracionPostPalabraFaltante = "",
                    PalabraFaltaEnmedioFinal = 2
                });
                FrasesIncompletasList.Add(new CompletarFraseModel
                {
                    Id = 3,
                    OracionIncompleta = "Wan wa´el ja jme´xepi´",
                    OracionPrePalabraFaltante = "Wan ",
                    OracionPostPalabraFaltante = " ja jme´xepi´",
                    PalabraFaltaEnmedioFinal = 1
                });
                FrasesIncompletasList.Add(new CompletarFraseModel
                {
                    Id = 4,
                    OracionIncompleta = "Wan ajnel ja jpagrino´",
                    OracionPrePalabraFaltante = "Wan ajnel ja ",
                    OracionPostPalabraFaltante = "",
                    PalabraFaltaEnmedioFinal = 2
                });
                FrasesIncompletasList.Add(new CompletarFraseModel
                {
                    Id = 5,
                    OracionIncompleta = "Wan ok´el ja kijts´ini´",
                    OracionPrePalabraFaltante = "Wan ",
                    OracionPostPalabraFaltante = " ja kijts´ini´",
                    PalabraFaltaEnmedioFinal = 1
                });
                FrasesIncompletasList.Add(new CompletarFraseModel
                {
                    Id = 6,
                    OracionIncompleta = "Wan b'ejyel ja jlaki´",
                    OracionPrePalabraFaltante = "Wan b'ejyel ja ",
                    OracionPostPalabraFaltante = "",
                    PalabraFaltaEnmedioFinal = 2
                });
                FrasesIncompletasList.Add(new CompletarFraseModel
                {
                    Id = 7,
                    OracionIncompleta = "Wan cha´nel ja jtatawelo",
                    OracionPrePalabraFaltante = "Wan ",
                    OracionPostPalabraFaltante = " ja jtatawelo",
                    PalabraFaltaEnmedioFinal = 1
                });
                FrasesIncompletasList.Add(new CompletarFraseModel
                {
                    Id = 8,
                    OracionIncompleta = "Wan b'ajtel ja jb´aluchi´",
                    OracionPrePalabraFaltante = "Wan b'ajtel ja ",
                    OracionPostPalabraFaltante = "",
                    PalabraFaltaEnmedioFinal = 2
                });
                FrasesIncompletasList.Add(new CompletarFraseModel
                {
                    Id = 9,
                    OracionIncompleta = "Wan tse´ej ja jmagrina´",
                    OracionPrePalabraFaltante = "Wan tse´ej ja ",
                    OracionPostPalabraFaltante = "",
                    PalabraFaltaEnmedioFinal = 2
                });
                FrasesIncompletasList.Add(new CompletarFraseModel
                {
                    Id = 10,
                    OracionIncompleta = "Wan awanel ja jmoji´",
                    OracionPrePalabraFaltante = "Wan awanel ja ",
                    OracionPostPalabraFaltante = "",
                    PalabraFaltaEnmedioFinal = 2
                });

                PalabrasFaltantesList = new List<PalabraFaltante>();
                PalabrasFaltantesList.Add(new PalabraFaltante
                {
                    Id = 1,
                    PalabraEscondida = "ts´eb´anel"
                });
                PalabrasFaltantesList.Add(new PalabraFaltante
                {
                    Id = 2,
                    PalabraEscondida = "jtati´"
                });
                PalabrasFaltantesList.Add(new PalabraFaltante
                {
                    Id = 3,
                    PalabraEscondida = "wa´el"
                });
                PalabrasFaltantesList.Add(new PalabraFaltante
                {
                    Id = 4,
                    PalabraEscondida = "jpagrino´"
                });
                PalabrasFaltantesList.Add(new PalabraFaltante
                {
                    Id = 5,
                    PalabraEscondida = "ok´el"
                });
                PalabrasFaltantesList.Add(new PalabraFaltante
                {
                    Id = 6,
                    PalabraEscondida = "jlaki´"
                });
                PalabrasFaltantesList.Add(new PalabraFaltante
                {
                    Id = 7,
                    PalabraEscondida = "cha´nel"
                });
                PalabrasFaltantesList.Add(new PalabraFaltante
                {
                    Id = 8,
                    PalabraEscondida = "jb´aluchi´"
                });
                PalabrasFaltantesList.Add(new PalabraFaltante
                {
                    Id = 9,
                    PalabraEscondida = "jmagrina´"
                });
                PalabrasFaltantesList.Add(new PalabraFaltante
                {
                    Id = 10,
                    PalabraEscondida = "jmoji´"
                });

            }, () => { return true; }));
        }
        #endregion
        #region Metodos

        #endregion
    }
}
