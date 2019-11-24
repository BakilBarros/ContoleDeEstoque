namespace ProjetoFabricaCosmeticos
{
    partial class FormConsultaFormula
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
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewFormula = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonListar = new System.Windows.Forms.Button();
            this.buttonRemoverFormula = new System.Windows.Forms.Button();
            this.buttonRemoverItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(75, 42);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(398, 21);
            this.comboBoxProduto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Produto";
            // 
            // listViewFormula
            // 
            this.listViewFormula.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewFormula.FullRowSelect = true;
            this.listViewFormula.Location = new System.Drawing.Point(75, 108);
            this.listViewFormula.Name = "listViewFormula";
            this.listViewFormula.Size = new System.Drawing.Size(398, 125);
            this.listViewFormula.TabIndex = 1;
            this.listViewFormula.UseCompatibleStateImageBehavior = false;
            this.listViewFormula.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Materia Prima";
            this.columnHeader1.Width = 353;
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(75, 259);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(75, 34);
            this.buttonListar.TabIndex = 2;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // buttonRemoverFormula
            // 
            this.buttonRemoverFormula.Location = new System.Drawing.Point(398, 259);
            this.buttonRemoverFormula.Name = "buttonRemoverFormula";
            this.buttonRemoverFormula.Size = new System.Drawing.Size(75, 34);
            this.buttonRemoverFormula.TabIndex = 4;
            this.buttonRemoverFormula.Text = "Remover Formula";
            this.buttonRemoverFormula.UseVisualStyleBackColor = true;
            this.buttonRemoverFormula.Click += new System.EventHandler(this.buttonRemoverFormula_Click);
            // 
            // buttonRemoverItem
            // 
            this.buttonRemoverItem.Location = new System.Drawing.Point(237, 259);
            this.buttonRemoverItem.Name = "buttonRemoverItem";
            this.buttonRemoverItem.Size = new System.Drawing.Size(75, 34);
            this.buttonRemoverItem.TabIndex = 3;
            this.buttonRemoverItem.Text = "Remover Item";
            this.buttonRemoverItem.UseVisualStyleBackColor = true;
            this.buttonRemoverItem.Click += new System.EventHandler(this.buttonRemoverItem_Click);
            // 
            // FormConsultaFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 320);
            this.Controls.Add(this.buttonRemoverItem);
            this.Controls.Add(this.buttonRemoverFormula);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.listViewFormula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProduto);
            this.Name = "FormConsultaFormula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewFormula;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.Button buttonRemoverFormula;
        private System.Windows.Forms.Button buttonRemoverItem;
    }
}