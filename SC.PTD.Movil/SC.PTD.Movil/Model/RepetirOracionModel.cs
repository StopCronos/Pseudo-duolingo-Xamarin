using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.PTD.Movil.Model
{
    public class RepetirOracionModel: ObservableObject
    {

        private int id;
        public int Id { get => id; set => Set(ref id, value); }

        private string oracionTojolabal;
        public string OracionTojolabal { get => oracionTojolabal; set => Set(ref oracionTojolabal, value); }

        private string oracionEspañol;
        public string OracionEspañol { get => oracionEspañol; set => Set(ref oracionEspañol, value); }

        private string url;
        public string Url { get => url; set => Set(ref url, value); }

    }

}
