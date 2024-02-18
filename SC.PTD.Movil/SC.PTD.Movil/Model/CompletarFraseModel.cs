using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.PTD.Movil.Model
{
    public class CompletarFraseModel : ObservableObject
    {

        private int id;
        public int Id { get => id; set => Set(ref id, value); }

        private string oracionIncompleta;
        public string OracionIncompleta { get => oracionIncompleta; set => Set(ref oracionIncompleta, value); }

        private string oracionPrePalabraFaltante;
        public string OracionPrePalabraFaltante { get => oracionPrePalabraFaltante; set => Set(ref oracionPrePalabraFaltante, value); }

        private string oracionPostPalabraFaltante;
        public string OracionPostPalabraFaltante { get => oracionPostPalabraFaltante; set => Set(ref oracionPostPalabraFaltante, value); }

        private int palabraFaltaEnmedioFinal; //indica si la palabra faltante va 1 enmedio de la oracion o 2 al final de la oracion
        public int PalabraFaltaEnmedioFinal { get => palabraFaltaEnmedioFinal; set => Set(ref palabraFaltaEnmedioFinal, value); }
    }

    public class PalabraFaltante : ObservableObject
    {

        private int id;
        public int Id { get => id; set => Set(ref id, value); }

        private string palabraEscondida;
        public string PalabraEscondida { get => palabraEscondida; set => Set(ref palabraEscondida, value); }

    }

    public class PalabrasErroneas : ObservableObject
    {

        private int id;
        public int Id { get => id; set => Set(ref id, value); }

        private string palabraErronea;
        public string PalabraErronea { get => palabraErronea; set => Set(ref palabraErronea, value); }

    }
}
