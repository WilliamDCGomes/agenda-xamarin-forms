using AppTarefas.Banco;
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
    public partial class Cadastrar : ContentPage
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void FecharModal(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private async void SalvarTarefa(object sender, EventArgs e)
        {
            Tarefa tarefa = new Tarefa();
            tarefa.Nome = Nome.Text;
            tarefa.Nota = Nota.Text;
            tarefa.Data = Data.Date;
            tarefa.HorarioInicial = HorarioInicial.Time;
            tarefa.HorarioFinal = HorarioFinal.Time;
            tarefa.Finalizada = false;
            await new TarefaDB().CadastrarAsync(tarefa);
        }
    }
}