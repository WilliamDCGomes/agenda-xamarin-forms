using AppTarefas.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTarefas.Banco
{
    public class TarefaDB
    {
        private BancoContext Banco { get; set; }

        public TarefaDB()
        {
            Banco = new BancoContext();
        }

        public async Task<List<Tarefa>> PesquisarAsync(DateTime data)
        {
            return await Banco.Tarefas.Where(
                    a=>!a.Data.ToString().Equals(null) &&
                    a.Data.Year == data.Year &&
                    a.Data.Month == data.Month &&
                    a.Data.Day == data.Day
                ).ToListAsync();
        }
        public async Task<bool> Cadastrar(Tarefa tarefa)
        {
            Banco.Tarefas.Add(tarefa);
            int linhas = await Banco.SaveChangesAsync();
            return (linhas > 0) ? true : false;
        }
        public async Task<bool> Atualizar(Tarefa tarefa)
        {
            Banco.Tarefas.Update(tarefa);
            int linhas = await Banco.SaveChangesAsync();
            return (linhas > 0) ? true : false;
        }
        public async Task<bool> Excluir(int id)
        {
            Tarefa tarefa = await Consultar(id);
            Banco.Tarefas.Remove(tarefa);
            int linhas = await Banco.SaveChangesAsync();
            return (linhas > 0) ? true : false;
        }
        public async Task<Tarefa> Consultar(int id)
        {
            return await Banco.Tarefas.FindAsync(id);
        }
        
    }
}
