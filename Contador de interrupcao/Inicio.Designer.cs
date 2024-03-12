namespace Contador_de_interrupcao
{
    partial class Inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CadastrarInterruptores = new System.Windows.Forms.Button();
            this.DeletarInterruptores = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListarInterrupcoes = new System.Windows.Forms.Button();
            this.Interruptores = new System.Windows.Forms.DataGridView();
            this.resumoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interruptorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.interruptorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interrupções = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaoEntendeu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Interruptores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interruptorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interruptorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CadastrarInterruptores
            // 
            this.CadastrarInterruptores.BackColor = System.Drawing.Color.Purple;
            this.CadastrarInterruptores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CadastrarInterruptores.Font = new System.Drawing.Font("Yu Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarInterruptores.ForeColor = System.Drawing.SystemColors.Control;
            this.CadastrarInterruptores.Location = new System.Drawing.Point(11, 50);
            this.CadastrarInterruptores.Name = "CadastrarInterruptores";
            this.CadastrarInterruptores.Size = new System.Drawing.Size(98, 42);
            this.CadastrarInterruptores.TabIndex = 0;
            this.CadastrarInterruptores.Text = "Cadastrar";
            this.CadastrarInterruptores.UseVisualStyleBackColor = false;
            this.CadastrarInterruptores.Click += new System.EventHandler(this.CadastrarInterruptores_Click);
            // 
            // DeletarInterruptores
            // 
            this.DeletarInterruptores.BackColor = System.Drawing.Color.Purple;
            this.DeletarInterruptores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeletarInterruptores.Font = new System.Drawing.Font("Yu Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletarInterruptores.ForeColor = System.Drawing.SystemColors.Control;
            this.DeletarInterruptores.Location = new System.Drawing.Point(11, 98);
            this.DeletarInterruptores.Name = "DeletarInterruptores";
            this.DeletarInterruptores.Size = new System.Drawing.Size(98, 42);
            this.DeletarInterruptores.TabIndex = 1;
            this.DeletarInterruptores.Text = "Deletar";
            this.DeletarInterruptores.UseVisualStyleBackColor = false;
            this.DeletarInterruptores.Click += new System.EventHandler(this.DeletarInterruptores_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ListarInterrupcoes);
            this.panel1.Controls.Add(this.DeletarInterruptores);
            this.panel1.Controls.Add(this.CadastrarInterruptores);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 450);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(11, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Não entendidas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Não entendedores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListarInterrupcoes
            // 
            this.ListarInterrupcoes.BackColor = System.Drawing.Color.Purple;
            this.ListarInterrupcoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListarInterrupcoes.Font = new System.Drawing.Font("Yu Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarInterrupcoes.ForeColor = System.Drawing.SystemColors.Control;
            this.ListarInterrupcoes.Location = new System.Drawing.Point(11, 397);
            this.ListarInterrupcoes.Name = "ListarInterrupcoes";
            this.ListarInterrupcoes.Size = new System.Drawing.Size(98, 42);
            this.ListarInterrupcoes.TabIndex = 2;
            this.ListarInterrupcoes.Text = "Listar";
            this.ListarInterrupcoes.UseVisualStyleBackColor = false;
            this.ListarInterrupcoes.Click += new System.EventHandler(this.ListarInterrupcoes_Click);
            // 
            // Interruptores
            // 
            this.Interruptores.AllowUserToAddRows = false;
            this.Interruptores.AllowUserToDeleteRows = false;
            this.Interruptores.AllowUserToResizeColumns = false;
            this.Interruptores.AutoGenerateColumns = false;
            this.Interruptores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Interruptores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Interruptores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Interruptores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Interruptores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Interruptores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nome,
            this.setor,
            this.interrupções,
            this.NaoEntendeu});
            this.Interruptores.DataSource = this.resumoBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Interruptores.DefaultCellStyle = dataGridViewCellStyle3;
            this.Interruptores.EnableHeadersVisualStyles = false;
            this.Interruptores.GridColor = System.Drawing.Color.White;
            this.Interruptores.Location = new System.Drawing.Point(128, 12);
            this.Interruptores.Name = "Interruptores";
            this.Interruptores.ReadOnly = true;
            this.Interruptores.Size = new System.Drawing.Size(660, 426);
            this.Interruptores.TabIndex = 3;
            this.Interruptores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Interruptores_CellContentClick);
            // 
            // resumoBindingSource1
            // 
            this.resumoBindingSource1.DataSource = typeof(Contador_de_interrupcao.Model.Resumo);
            // 
            // resumoBindingSource
            // 
            this.resumoBindingSource.DataSource = typeof(Contador_de_interrupcao.Model.Resumo);
            // 
            // interruptorBindingSource1
            // 
            this.interruptorBindingSource1.DataSource = typeof(Contador_de_interrupcao.Model.Interruptor);
            // 
            // interruptorBindingSource
            // 
            this.interruptorBindingSource.DataSource = typeof(Contador_de_interrupcao.Model.Interruptor);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // setor
            // 
            this.setor.DataPropertyName = "setor";
            this.setor.HeaderText = "setor";
            this.setor.Name = "setor";
            this.setor.ReadOnly = true;
            // 
            // interrupções
            // 
            this.interrupções.DataPropertyName = "interrupcoes";
            this.interrupções.HeaderText = "não entendidas";
            this.interrupções.Name = "interrupções";
            this.interrupções.ReadOnly = true;
            // 
            // NaoEntendeu
            // 
            this.NaoEntendeu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "Não entendeu";
            this.NaoEntendeu.DefaultCellStyle = dataGridViewCellStyle2;
            this.NaoEntendeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NaoEntendeu.HeaderText = "NÃO ETENDI?";
            this.NaoEntendeu.Name = "NaoEntendeu";
            this.NaoEntendeu.ReadOnly = true;
            this.NaoEntendeu.Text = "";
            this.NaoEntendeu.Width = 87;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Interruptores);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Não entendi";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Interruptores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interruptorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interruptorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CadastrarInterruptores;
        private System.Windows.Forms.Button DeletarInterruptores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ListarInterrupcoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Interruptores;
        private System.Windows.Forms.BindingSource interruptorBindingSource;
        private System.Windows.Forms.BindingSource interruptorBindingSource1;
        private System.Windows.Forms.BindingSource resumoBindingSource;
        private System.Windows.Forms.BindingSource resumoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn setor;
        private System.Windows.Forms.DataGridViewTextBoxColumn interrupções;
        private System.Windows.Forms.DataGridViewButtonColumn NaoEntendeu;
    }
}

