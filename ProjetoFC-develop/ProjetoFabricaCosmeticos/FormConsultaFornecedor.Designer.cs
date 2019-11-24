namespace ProjetoFabricaCosmeticos
{
    partial class FormConsultaFornecedor
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
            this.textBoxCnpj = new System.Windows.Forms.TextBox();
            this.textBoxRazaoSocial = new System.Windows.Forms.TextBox();
            this.listViewFornecedor = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonListar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCnpj
            // 
            this.textBoxCnpj.Location = new System.Drawing.Point(103, 28);
            this.textBoxCnpj.MaxLength = 14;
            this.textBoxCnpj.Name = "textBoxCnpj";
            this.textBoxCnpj.Size = new System.Drawing.Size(100, 20);
            this.textBoxCnpj.TabIndex = 0;
            // 
            // textBoxRazaoSocial
            // 
            this.textBoxRazaoSocial.Location = new System.Drawing.Point(103, 68);
            this.textBoxRazaoSocial.MaxLength = 100;
            this.textBoxRazaoSocial.Name = "textBoxRazaoSocial";
            this.textBoxRazaoSocial.Size = new System.Drawing.Size(100, 20);
            this.textBoxRazaoSocial.TabIndex = 1;
            // 
            // listViewFornecedor
            // 
            this.listViewFornecedor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewFornecedor.FullRowSelect = true;
            this.listViewFornecedor.Location = new System.Drawing.Point(51, 107);
            this.listViewFornecedor.Name = "listViewFornecedor";
            this.listViewFornecedor.Size = new System.Drawing.Size(718, 97);
            this.listViewFornecedor.TabIndex = 2;
            this.listViewFornecedor.UseCompatibleStateImageBehavior = false;
            this.listViewFornecedor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CNPJ";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Razão Social";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Logradouro";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Complemento";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Bairro";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cidade";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Estado";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "CEP";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "E-mail";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Razão Social";
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(15, 269);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(75, 23);
            this.buttonListar.TabIndex = 3;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(164, 268);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 4;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(320, 267);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 5;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // FormConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 437);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewFornecedor);
            this.Controls.Add(this.textBoxRazaoSocial);
            this.Controls.Add(this.textBoxCnpj);
            this.Name = "FormConsultaFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Fornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCnpj;
        private System.Windows.Forms.TextBox textBoxRazaoSocial;
        private System.Windows.Forms.ListView listViewFornecedor;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonRemover;
    }
}