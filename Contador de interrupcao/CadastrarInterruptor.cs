using Contador_de_interrupcao.Model;
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
    public partial class CadastrarInterruptor : Form
    {
        Inicio inicio { get; set; }
        public CadastrarInterruptor(Inicio inicio)
        {
            this.inicio = inicio;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            string nome, setor;

            nome= this.nomeTxt.Text;
            setor= this.setorTxt.Text;

            if (nome.Equals(""))
            {
                this.alerta.ForeColor = Color.Red;
                this.alerta.Text = $"Nome inválido";
                return;
            }
            else
                if (setor.Equals(""))
            {
                this.alerta.ForeColor = Color.Red;
                this.alerta.Text = $"Setor inválido";
                return;
            }

            Interruptor interruptor = new Interruptor(nome,setor);
            interruptorDao.Add(interruptor);
            this.alerta.ForeColor = Color.Green;
            this.alerta.Text = $"Interruptor {interruptor.nome} cadastrado!";
            inicio.AtualizaGrid();
        }
    }
}
