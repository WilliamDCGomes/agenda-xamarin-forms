using AppTarefas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTarefas.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Visualizar : ContentPage
    {
        public Visualizar()
        {
            InitializeComponent();
            SetCorPrioridade();
        }
        public Visualizar(Tarefa tarefa)
        {
            InitializeComponent();
            BindingContext = tarefa;
            if(tarefa.Nota == null || tarefa.Nota != null && tarefa.Nota.Length == 0)
            {
                LblTituloNota.IsVisible = false;
            }
            SetCorPrioridade();
        }

        private void Voltar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void SetCorPrioridade()
        {
            if(PrioridadeSet.Text == "Baixa")
            {
                PrioridadeCor.Fill = Brush.DarkGreen;
            }
            else if (PrioridadeSet.Text == "Normal")
            {
                PrioridadeCor.Fill = Brush.DarkOrange;
            }
            else if (PrioridadeSet.Text == "Alta")
            {
                PrioridadeCor.Fill = Brush.DarkRed;
            }
        }
    }
}