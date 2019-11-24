namespace ProjetoFabricaCosmeticos
{
    partial class FormCadastroFormula
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
            this.comboBoxMateriaPrima = new System.Windows.Forms.ComboBox();
            this.listViewMateriaPrima = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdicionarMateriaPrima = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(118, 31);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(354, 21);
            this.comboBoxProduto.TabIndex = 0;
            // 
            // comboBoxMateriaPrima
            // 
            this.comboBoxMateriaPrima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMateriaPrima.FormattingEnabled = true;
            this.comboBoxMateriaPrima.Location = new System.Drawing.Point(118, 72);
            this.comboBoxMateriaPrima.Name = "comboBoxMateriaPrima";
            this.comboBoxMateriaPrima.Size = new System.Drawing.Size(305, 21);
            this.comboBoxMateriaPrima.TabIndex = 1;
            // 
            // listViewMateriaPrima
            // 
            this.listViewMateriaPrima.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewMateriaPrima.FullRowSelect = true;
            this.listViewMateriaPrima.Location = new System.Drawing.Point(118, 115);
            this.listViewMateriaPrima.Name = "listViewMateriaPrima";
            this.listViewMateriaPrima.Size = new System.Drawing.Size(354, 141);
            this.listViewMateriaPrima.TabIndex = 5;
            this.listViewMateriaPrima.UseCompatibleStateImageBehavior = false;
            this.listViewMateriaPrima.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Matéria Prima";
            this.columnHeader1.Width = 303;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Matéria Prima";
            // 
            // buttonAdicionarMateriaPrima
            // 
            this.buttonAdicionarMateriaPrima.Location = new System.Drawing.Point(429, 70);
            this.buttonAdicionarMateriaPrima.Name = "buttonAdicionarMateriaPrima";
            this.buttonAdicionarMateriaPrima.Size = new System.Drawing.Size(43, 23);
            this.buttonAdicionarMateriaPrima.TabIndex = 2;
            this.buttonAdicionarMateriaPrima.Text = "Add";
            this.buttonAdicionarMateriaPrima.UseVisualStyleBackColor = true;
            this.buttonAdicionarMateriaPrima.Click += new System.EventHandler(this.buttonAdicionarMateriaPrima_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(230, 310);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 4;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // FormCadastroFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 345);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdicionarMateriaPrima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewMateriaPrima);
            this.Controls.Add(this.comboBoxMateriaPrima);
            this.Controls.Add(this.comboBoxProduto);
            this.Name = "FormCadastroFormula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Formula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.ComboBox comboBoxMateriaPrima;
        private System.Windows.Forms.ListView listViewMateriaPrima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonAdicionarMateriaPrima;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCadastrar;
    }
}