﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AppTarefas.Conversor
{
    public class PrioridadeConversor : IValueConverter
    {
        public object Convert(object value, Type targettype, object parameter, CultureInfo culture)
        {

            string prioridade = value as string;
            if (prioridade == "Baixa")
            {
                return App.Current.Resources["PrioridadeBaixa"];
            }
            if (prioridade == "Normal")
            {
                return App.Current.Resources["PrioridadeNormal"];
            }
            if (prioridade == "Alta")
            {
                return App.Current.Resources["PrioridadeAlta"];
            }
            return App.Current.Resources["PrioridadeNormal"];

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
