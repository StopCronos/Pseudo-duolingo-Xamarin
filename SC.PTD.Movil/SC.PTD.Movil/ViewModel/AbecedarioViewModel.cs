using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using SC.PTD.Movil.Model;
using SC.PTD.Movil.View;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SC.PTD.Movil.ViewModel
{
    public class AbecedarioViewModel : ViewModelBase
    {
        #region Constructor
        public AbecedarioViewModel()
        {
            LlenarListaCommand.Execute(null);

        }
        #endregion

        #region Propiedades
        public static Xamarin.Forms.Page CurrentPage { get; set; }

        public static string TestStr = "My test string";

        private List<AbecedarioModel> abecedarioList;
        public List<AbecedarioModel> AbecedarioList { get => abecedarioList; set => Set(ref abecedarioList, value); }


        #endregion

        #region Comandos


        RelayCommand llenarListaCommand = null;
        public RelayCommand LlenarListaCommand
        {
            get => llenarListaCommand ?? (llenarListaCommand = new RelayCommand(() =>
            {
                AbecedarioList = new List<AbecedarioModel>();
                AbecedarioList.Add(new AbecedarioModel { Letra = "A", TojolabalLetra = "A" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "B", TojolabalLetra = "B" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "C", TojolabalLetra = "B'" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "D", TojolabalLetra = "CH" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "E", TojolabalLetra = "CH'" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "F", TojolabalLetra = "D" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "G", TojolabalLetra = "E" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "H", TojolabalLetra = "G" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "I", TojolabalLetra = "I" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "J", TojolabalLetra = "J" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "K", TojolabalLetra = "K" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "L", TojolabalLetra = "K'" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "M", TojolabalLetra = "L" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "N", TojolabalLetra = "M" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "Ñ", TojolabalLetra = "N" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "O", TojolabalLetra = "O" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "P", TojolabalLetra = "P" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "Q", TojolabalLetra = "R" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "R", TojolabalLetra = "S" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "S", TojolabalLetra = "T" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "T", TojolabalLetra = "T'" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "U", TojolabalLetra = "Ts" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "V", TojolabalLetra = "Ts'" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "W", TojolabalLetra = "U" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "X", TojolabalLetra = "W" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "Y", TojolabalLetra = "X" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "Z", TojolabalLetra = "Y" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "GLOTAL", TojolabalLetra = "'" });
                AbecedarioList.Add(new AbecedarioModel { Letra = "GUIÓN", TojolabalLetra = "-" });
            }, () => { return true; }));
        }


        
        #endregion




    }
}
