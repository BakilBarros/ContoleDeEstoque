namespace ProjetoFabricaCosmeticos
{
    partial class FormCadastroItemFormula
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
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.comboBoxMateriaPrima = new System.Windows.Forms.ComboBox();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(232, 119);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 2;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // comboBoxMateriaPrima
            // 
            this.comboBoxMateriaPrima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMateriaPrima.FormattingEnabled = true;
            this.comboBoxMateriaPrima.Location = new System.Drawing.Point(89, 64);
            this.comboBoxMateriaPrima.Name = "comboBoxMateriaPrima";
            this.comboBoxMateriaPrima.Size = new System.Drawing.Size(354, 21);
            this.comboBoxMateriaPrima.TabIndex = 1;
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(89, 23);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(354, 21);
            this.comboBoxProduto.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matéria Prima";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produto";
            // 
            // FormCadastroItemFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 192);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.comboBoxMateriaPrima);
            this.Controls.Add(this.comboBoxProduto);
            this.Name = "FormCadastroItemFormula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Item da Formula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.ComboBox comboBoxMateriaPrima;
        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}