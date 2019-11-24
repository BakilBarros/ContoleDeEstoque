using ProjetoFabricaCosmeticos.localhost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFabricaCosmeticos
{
    public partial class FormCadastroMateriaPrima : Form
    {
        int operacao;
        int filtro;
        public FormCadastroMateriaPrima()
        {
            InitializeComponent();
            this.operacao = 0;
            buttonCadastrarMateriaPrima.Text = "Cadastrar";
            this.Text = "Cadastro de materia prima";
        }       
        public FormCadastroMateriaPrima(MateriaPrima m)
        {
            InitializeComponent();
            textBoxNome.Text = m.nome;
            textBoxDescricao.Text = m.descricao;
            textBoxLote.Text = m.lote;
            dateTimePickerValidade.Value = m.validade;
            textBoxEstoqueAtual.Text = Convert.ToString(m.estoqueAtual);
            this.filtro = m.id;
            this.operacao = 1;
            buttonCadastrarMateriaPrima.Text = "Atualizar";
            this.Text = "Atualização da materia prima";
         }

        private void buttonCadastrarMateriaPrima_Click(object sender, EventArgs e)
        {
            try
            {
                MateriaPrima m = new MateriaPrima();
                m.nome = textBoxNome.Text;
                m.descricao = textBoxDescricao.Text;
                m.lote = textBoxLote.Text;
                m.validade = dateTimePickerValidade.Value;
                m.estoqueAtual = Convert.ToInt32(textBoxEstoqueAtual.Text);


                Service1 dados = new Service1();
                if (this.operacao == 0)
                {
                    dados.InsertMateriaPrima(m);
                    MessageBox.Show("Materia prima cadastrada com sucesso");
                }
                else
                {
                    m.id = this.filtro;
                    dados.UpdateMateriaPrima(m);
                    MessageBox.Show("Materia Prima atualizada com sucesso");
                }

                textBoxNome.Clear();
                textBoxDescricao.Clear();
                textBoxLote.Clear();
                textBoxEstoqueAtual.Clear();
                dateTimePickerValidade.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
