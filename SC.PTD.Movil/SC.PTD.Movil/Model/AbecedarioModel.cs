using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace SC.PTD.Movil.Model
{
    public class AbecedarioModel: ObservableObject
    {


        private string letra;
        public string Letra { get => letra; set => Set(ref letra, value); }


        private string tojolabalLetra;
        public string TojolabalLetra { get => tojolabalLetra; set => Set(ref tojolabalLetra, value); }
    }
}
