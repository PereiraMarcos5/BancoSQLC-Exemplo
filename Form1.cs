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

    public partial class Form1 : Form
    {
        pro_chefeEntities bd = new pro_chefeEntities();
        Usuário logado = new Usuário();
        public Form1()
        {
            InitializeComponent();
            button1.Click += logar;
        }
        private void logar(object sender, EventArgs e)
        {
            //equivalente a SELECT * FROM usuario
            /*bd.Usuário.ToList().ForEach(u => {
                MessageBox.Show(u.nome);*/
            logado = bd.Usuário.Where(u => u.login.Equals(textBox1.Text)
            && u.senha.Equals(textBox2.Text)).FirstOrDefault();
            if (logado != null)
            {
                MessageBox.Show($"usuario {logado.nome} logado com sucesso!");
            }
            else
            {
                MessageBox.Show("Login inválido");
            }
        }
        /*private void cadastrar(object sender, EventArgs e)
        {
            new Form2().Show();
        }*/

        private void Button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
