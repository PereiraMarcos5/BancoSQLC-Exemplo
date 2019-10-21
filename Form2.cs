using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        pro_chefeEntities bd = new pro_chefeEntities();
        public Form2()
        {
            InitializeComponent();
            button1.Click += salvar;
            montarTabela();
        }

        private void montarTabela()
        {
            dataGridView1.DataSource = bd.Usuário.ToList();
        }

        private void salvar(object sender, EventArgs e)
        {
            Usuário novo = new Usuário()
            {
                nome = textBox1.Text,
                login = textBox2.Text,
                senha = textBox3.Text
            };
            //equivalente ao comando INSERT
            bd.Usuário.Add(novo);
            bd.SaveChanges();
            MessageBox.Show("Salvo com Sucesso");
            montarTabela();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
