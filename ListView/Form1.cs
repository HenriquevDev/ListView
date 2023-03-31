using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            textBoxId.Clear();
            textBoxPreco.Clear();
            textBoxProduto.Clear();
            textBoxQuant.Clear();
            textBoxId.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
            {
                MessageBox.Show("ID Não pode ser vazio, por favor preencha o ID");
                textBoxId.Focus();
                return;
            }
            if (textBoxProduto.Text == "")
            {
                MessageBox.Show("Produto não pode ser vazio, por favor preencha o Produto");
                textBoxProduto.Focus();
                return;
            }
            if (textBoxQuant.Text == "")
            {
                MessageBox.Show("Quantidade não pode ser um vazio, por favor preencha a Quantidade");
                textBoxQuant.Focus();
                return;
            }
            if (textBoxPreco.Text == "")
            {
                MessageBox.Show("Preço não pode ser vazio, por favor preencha o Preço");
                textBoxPreco.Focus();
                return;
            }
            String[] produtos = new string[4];
            produtos[0] = textBoxId.Text;
            produtos[1] = textBoxProduto.Text;
            produtos[2] = textBoxQuant.Text;
            produtos[3] = textBoxPreco.Text;

            ListViewItem L = new ListViewItem(produtos);
            listView1.Items.Add(L);
            limpar();

           
        }
         
        private void buttonRmv_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
        }
    }
}
