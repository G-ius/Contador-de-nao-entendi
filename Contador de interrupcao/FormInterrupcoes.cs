using Contador_de_interrupcao.Model.csharp_Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador_de_interrupcao
{
    public partial class FormInterrupcoes : Form
    {   
        Inicio inicio { get; set; }
        public FormInterrupcoes(Inicio inicio)
        {
            InitializeComponent();
            this.inicio = inicio;
        }

        private void FormInterrupcoes_Load(object sender, EventArgs e)
        {
            this.Interruptores.DataSource = InterrupcaoDao.GetList();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Interruptores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(senderGrid.Rows[senderGrid.CurrentRow.Index].Cells[0].Value);
                InterrupcaoDao.Delete(id);
                inicio.AtualizaGrid();
                this.Interruptores.DataSource = InterrupcaoDao.GetList();
            }
        }
    }
}
