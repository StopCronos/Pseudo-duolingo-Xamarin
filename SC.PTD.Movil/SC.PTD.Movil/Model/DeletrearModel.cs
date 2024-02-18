using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.PTD.Movil.Model
{
    public class DeletrearModel : ObservableObject
    {
        private int id;
        public int Id { get => id; set => Set(ref id, value); }

        private string palabraTojolabal;
        public string PalabraTojolabal { get => palabraTojolabal; set => Set(ref palabraTojolabal, value); }

        private string palabraEspañol;
        public string PalabraEspañol { get => palabraEspañol; set => Set(ref palabraEspañol, value); }

        private char[] palabraDeletreada;
        public char[] PalabraDeletreada { get => palabraDeletreada; set => Set(ref palabraDeletreada, value); }

        private int cuantasLetrasEsconder;
        public int CuantasLetrasEsconder { get => cuantasLetrasEsconder; set => Set(ref cuantasLetrasEsconder, value); }

        private char[] letrasEscondidas;
        public char[] LetrasEscondidas { get => letrasEscondidas; set => Set(ref letrasEscondidas, value); }

        private string felicitacion;
        public string Felicitacion { get => felicitacion; set => Set(ref felicitacion, value); }

    }
}
