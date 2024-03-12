namespace Contador_de_interrupcao
{
    partial class CadastrarInterruptor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.setorTxt = new System.Windows.Forms.TextBox();
            this.alerta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.Color.Purple;
            this.Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cadastrar.Font = new System.Drawing.Font("Yu Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cadastrar.Location = new System.Drawing.Point(405, 12);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(95, 46);
            this.Cadastrar.TabIndex = 0;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.Color.Purple;
            this.Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Voltar.Font = new System.Drawing.Font("Yu Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Voltar.Location = new System.Drawing.Point(11, 79);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(69, 27);
            this.Voltar.TabIndex = 1;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Setor";
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(58, 12);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(341, 20);
            this.nomeTxt.TabIndex = 4;
            this.nomeTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // setorTxt
            // 
            this.setorTxt.Location = new System.Drawing.Point(58, 38);
            this.setorTxt.Name = "setorTxt";
            this.setorTxt.Size = new System.Drawing.Size(341, 20);
            this.setorTxt.TabIndex = 5;
            // 
            // alerta
            // 
            this.alerta.AutoSize = true;
            this.alerta.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alerta.ForeColor = System.Drawing.Color.Red;
            this.alerta.Location = new System.Drawing.Point(99, 85);
            this.alerta.Name = "alerta";
            this.alerta.Size = new System.Drawing.Size(0, 17);
            this.alerta.TabIndex = 6;
            // 
            // CadastrarInterruptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(512, 117);
            this.Controls.Add(this.alerta);
            this.Controls.Add(this.setorTxt);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Cadastrar);
            this.Name = "CadastrarInterruptor";
            this.Text = "Cadastrar Não entendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.TextBox setorTxt;
        private System.Windows.Forms.Label alerta;
    }
}