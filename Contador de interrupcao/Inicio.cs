using Contador_de_interrupcao.Model;
using Contador_de_interrupcao.Model.csharp_Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador_de_interrupcao
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            DatabaseConnection.CriarBancoSQLite();
            interruptorDao.CriarTabelaSQlite();
            InterrupcaoDao.CriarTabelaSQlite();

            this.Interruptores.DataSource = interruptorDao.GetRelatorio();
        }

        private void CadastrarInterruptores_Click(object sender, EventArgs e)
        {
            var cadastro = new CadastrarInterruptor(this);
            cadastro.Show();
        }

        public void AtualizaGrid()
        {
            this.Interruptores.DataSource = interruptorDao.GetRelatorio();
        }

        private void Interruptores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(senderGrid.Rows[senderGrid.CurrentRow.Index].Cells[0].Value);
                Interrupcao interrupcao = new Interrupcao(id,DateTime.Now);
                InterrupcaoDao.Add(interrupcao);
                this.Interruptores.DataSource = interruptorDao.GetRelatorio();
            }
        }

        private void DeletarInterruptores_Click(object sender, EventArgs e)
        {
            var delete = new inter(this);
            delete.Show();
        }

        private void ListarInterrupcoes_Click(object sender, EventArgs e)
        {
            var lista = new FormInterrupcoes(this);
            lista.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
