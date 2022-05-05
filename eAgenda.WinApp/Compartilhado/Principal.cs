using eAgenda.Dominio;
using eAgenda.Dominio.Compartilhado;
using eAgenda.WinApp.ModuloContato;
using eAgenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp
{
    public partial class Principal : Form
    {
        Repositorio<Contato> repositorioContato;
        TelaContato? telaContato;
        Repositorio<Tarefa> repositorioTarefa;
        TelaTarefa? telaTarefa;

        //////////////////////////////////////////////////////////////////////////////
        
        private readonly JsonSerializador<Tarefa> _jsonTarefa;
        private readonly JsonSerializador<Contato> _jsonContato;
        public Principal()
        {
            _jsonContato = new(@"C:\Temp\Contatos");
            _jsonTarefa = new(@"C:\Temp\Tarefas");
            repositorioContato = new Repositorio<Contato>(_jsonContato);
            repositorioTarefa = new Repositorio<Tarefa>(_jsonTarefa);
            InitializeComponent();
        }

        private void buttonContato_Click(object sender, EventArgs e)
        {
            telaContato = new(repositorioContato);
            telaContato.Show();
        }

        private void buttonTarefa_Click(object sender, EventArgs e)
        {
            telaTarefa = new(repositorioTarefa, _jsonTarefa);
            telaTarefa.Show();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}