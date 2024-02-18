using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.PTD.Movil.Model
{
    public class TraducirOracionModel: ObservableObject
    {

        private int id;
        public int Id { get => id; set => Set(ref id, value); }

        private string oracionTojolabal;
        public string OracionTojolabal { get => oracionTojolabal; set => Set(ref oracionTojolabal, value); }

        private string oracionEspañol;
        public string OracionEspañol { get => oracionEspañol; set => Set(ref oracionEspañol, value); }

        private string imgSC;
        public string ImgSC { get => imgSC; set => Set(ref imgSC, value); }

        private string imgCC;
        public string ImgCC { get => imgCC; set => Set(ref imgCC, value); }

        private string felicitacion;
        public string Felicitacion { get => felicitacion; set => Set(ref felicitacion, value); }
    }
}
