namespace ProjetoFabricaCosmeticos
{
    partial class FormCadastroMateriaPrima
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
            this.buttonCadastrarMateriaPrima = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxLote = new System.Windows.Forms.TextBox();
            this.textBoxEstoqueAtual = new System.Windows.Forms.TextBox();
            this.dateTimePickerValidade = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonCadastrarMateriaPrima
            // 
            this.buttonCadastrarMateriaPrima.Location = new System.Drawing.Point(27, 197);
            this.buttonCadastrarMateriaPrima.Name = "buttonCadastrarMateriaPrima";
            this.buttonCadastrarMateriaPrima.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrarMateriaPrima.TabIndex = 5;
            this.buttonCadastrarMateriaPrima.Text = "Cadastrar";
            this.buttonCadastrarMateriaPrima.UseVisualStyleBackColor = true;
            this.buttonCadastrarMateriaPrima.Click += new System.EventHandler(this.buttonCadastrarMateriaPrima_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lote";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Validade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estoque atual";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(152, 11);
            this.textBoxNome.MaxLength = 30;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(288, 20);
            this.textBoxNome.TabIndex = 0;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(152, 47);
            this.textBoxDescricao.MaxLength = 50;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(288, 20);
            this.textBoxDescricao.TabIndex = 1;
            // 
            // textBoxLote
            // 
            this.textBoxLote.Location = new System.Drawing.Point(152, 82);
            this.textBoxLote.MaxLength = 10;
            this.textBoxLote.Name = "textBoxLote";
            this.textBoxLote.Size = new System.Drawing.Size(100, 20);
            this.textBoxLote.TabIndex = 2;
            // 
            // textBoxEstoqueAtual
            // 
            this.textBoxEstoqueAtual.Location = new System.Drawing.Point(152, 151);
            this.textBoxEstoqueAtual.Name = "textBoxEstoqueAtual";
            this.textBoxEstoqueAtual.Size = new System.Drawing.Size(100, 20);
            this.textBoxEstoqueAtual.TabIndex = 4;
            // 
            // dateTimePickerValidade
            // 
            this.dateTimePickerValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerValidade.Location = new System.Drawing.Point(152, 112);
            this.dateTimePickerValidade.Name = "dateTimePickerValidade";
            this.dateTimePickerValidade.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerValidade.TabIndex = 3;
            // 
            // FormCadastroMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 261);
            this.Controls.Add(this.dateTimePickerValidade);
            this.Controls.Add(this.textBoxEstoqueAtual);
            this.Controls.Add(this.textBoxLote);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCadastrarMateriaPrima);
            this.Name = "FormCadastroMateriaPrima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroMateriaPrima";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCadastrarMateriaPrima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxLote;
        private System.Windows.Forms.TextBox textBoxEstoqueAtual;
        private System.Windows.Forms.DateTimePicker dateTimePickerValidade;
    }
}