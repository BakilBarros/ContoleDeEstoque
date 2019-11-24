namespace ProjetoFabricaCosmeticos
{
    partial class FormConsultaCompra
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMateriaPrima = new System.Windows.Forms.ComboBox();
            this.listViewCompra = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.comboBoxFornecedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Materia Prima";
            // 
            // comboBoxMateriaPrima
            // 
            this.comboBoxMateriaPrima.FormattingEnabled = true;
            this.comboBoxMateriaPrima.Location = new System.Drawing.Point(114, 40);
            this.comboBoxMateriaPrima.Name = "comboBoxMateriaPrima";
            this.comboBoxMateriaPrima.Size = new System.Drawing.Size(300, 21);
            this.comboBoxMateriaPrima.TabIndex = 1;
            // 
            // listViewCompra
            // 
            this.listViewCompra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewCompra.FullRowSelect = true;
            this.listViewCompra.Location = new System.Drawing.Point(27, 81);
            this.listViewCompra.Name = "listViewCompra";
            this.listViewCompra.Size = new System.Drawing.Size(387, 112);
            this.listViewCompra.TabIndex = 2;
            this.listViewCompra.UseCompatibleStateImageBehavior = false;
            this.listViewCompra.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fornecedor";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Materia Prima";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Preço";
            this.columnHeader3.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantidade";
            this.columnHeader4.Width = 77;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(27, 214);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 3;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(184, 214);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 4;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(339, 214);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 5;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // comboBoxFornecedor
            // 
            this.comboBoxFornecedor.FormattingEnabled = true;
            this.comboBoxFornecedor.Location = new System.Drawing.Point(114, 12);
            this.comboBoxFornecedor.Name = "comboBoxFornecedor";
            this.comboBoxFornecedor.Size = new System.Drawing.Size(300, 21);
            this.comboBoxFornecedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fornecedor";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // FormConsultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 261);
            this.Controls.Add(this.comboBoxFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.listViewCompra);
            this.Controls.Add(this.comboBoxMateriaPrima);
            this.Controls.Add(this.label2);
            this.Name = "FormConsultaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultaCompra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMateriaPrima;
        private System.Windows.Forms.ListView listViewCompra;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.ComboBox comboBoxFornecedor;
        private System.Windows.Forms.Label label1;
    }
}