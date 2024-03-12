using Contador_de_interrupcao.Model.csharp_Sqlite;
using Contador_de_interrupcao.Model;
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
    public partial class inter : Form
    {
        Inicio inicio { get; set; }
        public inter(Inicio inicio)
        {
            this.inicio = inicio;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inter_Load(object sender, EventArgs e)
        {
            this.Interruptores.DataSource = interruptorDao.Get();
        }

        private void Interruptores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(senderGrid.Rows[senderGrid.CurrentRow.Index].Cells[0].Value);
                interruptorDao.Delete(id);
                InterrupcaoDao.DeleteByInterruptor(id);
                inicio.AtualizaGrid();
                this.Interruptores.DataSource = interruptorDao.Get();
            }
        }
    }
}
