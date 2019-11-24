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
    public partial class FormCadastroCompra : Form
    {
        List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        List<MateriaPrima> listaMateriaPrima = new List<MateriaPrima>();
        List<MateriaPrima> listaComboMateriaPrima = new List<MateriaPrima>();

        int operacao;
        int filtro;

        public FormCadastroCompra()
        {
            InitializeComponent();
            ListarFornecedorCombo();
            ListarMateriaCombo();
            this.operacao = 0;
            buttonCadastrar.Text = "cadastrar";
            this.Text = "cadastar compra";
        }

        public FormCadastroCompra(Compra c)
        {
            InitializeComponent();
            ListarFornecedorCombo();
            ListarMateriaCombo();
            comboBoxFornecedor.Text = c.fornecedor.razaoSocial;
            comboBoxMateriaPrima.Text = c.materiaPrima.nome;
            textBoxPreco.Text = Convert.ToString(c.preco);
            textBoxQuantidade.Text = Convert.ToString(c.quantidade);
            this.operacao = 1;
            buttonCadastrar.Text = "Atualizar";
            this.Text = " Atualização da compra";
        }

        private void ListarFornecedorCombo()
        {
            try
            {
                Service1 dados = new Service1();
                Fornecedor filtro = new Fornecedor();
                listaFornecedor = dados.SelectFornecedor(filtro).ToList();
                comboBoxFornecedor.Items.Clear();
                foreach (Fornecedor f in listaFornecedor)
                {
                    comboBoxFornecedor.Items.Add(f.razaoSocial);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarMateriaCombo()
        {
            try
            {
                Service1 dados = new Service1();
                MateriaPrima filtro = new MateriaPrima();
                listaMateriaPrima = dados.SelectMateriaPrima(filtro).ToList();
                comboBoxMateriaPrima.Items.Clear();
                foreach (MateriaPrima m in listaMateriaPrima)
                {
                    comboBoxMateriaPrima.Items.Add(m.nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            

            int indexFornecedor = comboBoxFornecedor.SelectedIndex;
            if (indexFornecedor < 0)
            {
                MessageBox.Show("Selecionar o produto");
                comboBoxFornecedor.Focus();
                return;
            }

            int indexMateriaPrima = comboBoxMateriaPrima.SelectedIndex;
            if (indexMateriaPrima < 0)
            {
                MessageBox.Show("Selecionar a matéria prima");
                comboBoxMateriaPrima.Focus();
                return;
            }
            Compra compra = new Compra();
            compra.fornecedor = new Fornecedor();
            compra.materiaPrima = new MateriaPrima();
            compra.fornecedor = listaFornecedor.ElementAt(indexFornecedor);
            compra.materiaPrima = listaMateriaPrima.ElementAt(indexMateriaPrima);
            compra.preco = Convert.ToDouble(textBoxPreco.Text);
            compra.quantidade = Convert.ToInt32(textBoxQuantidade.Text);

            Service1 dados = new Service1();
            if (this.operacao == 0)
            {
                dados.InsertCompra(compra);
                MessageBox.Show("Compra cadastrada com sucesso");
            }
            else
            {
               dados.UpdateCompra(compra);
                MessageBox.Show("Compra alterado com sucesso");
            }

            
            comboBoxFornecedor.SelectedIndex = -1;
            comboBoxMateriaPrima.SelectedIndex = -1;
            textBoxPreco.Clear();
            textBoxQuantidade.Clear();
        }
    }
}
