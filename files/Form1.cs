using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Concept_Conceito_Emp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Código associado ao clique na pictureBox1
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Substitua "https://www.example.com" pelo URL do site que você deseja abrir
            string urlDoSite = "https://www.grupoconceitotecnologia.com.br/home";

            // Abre o navegador padrão com o site especificado
            Process.Start(urlDoSite);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem de confirmação antes de fechar o formulário
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja fechar o sistema?", "Fechar o Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Fecha o formulário se o usuário clicar em "Sim"
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Substitua "https://www.example.com" pelo URL do site que você deseja abrir
            string urlDoSite = "https://site.conceitoerp.com.br";

            // Abre o navegador padrão com o site especificado
            Process.Start(urlDoSite);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Substitua "https://www.example.com" pelo URL do site que você deseja abrir
            string urlDoSite = "https://conceitofood.com.br";

            // Abre o navegador padrão com o site especificado
            Process.Start(urlDoSite);
        }

        private void sobreOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void serviçosDaConceitoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void áreaDoSuporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void fecharOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem de confirmação antes de fechar o formulário
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja fechar o sistema?", "Fechar o Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Fecha o formulário se o usuário clicar em "Sim"
                this.Close();
            }
        }

        private void nossoSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Substitua "https://www.example.com" pelo URL do site que você deseja abrir
            string urlDoSite = "https://www.grupoconceitotecnologia.com.br/home";

            // Abre o navegador padrão com o site especificado
            Process.Start(urlDoSite);
        }

        private void conceitoERPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Substitua "https://www.example.com" pelo URL do site que você deseja abrir
            string urlDoSite = "https://site.conceitoerp.com.br";

            // Abre o navegador padrão com o site especificado
            Process.Start(urlDoSite);
        }

        private void conceitoFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Substitua "https://www.example.com" pelo URL do site que você deseja abrir
            string urlDoSite = "https://conceitofood.com.br";

            // Abre o navegador padrão com o site especificado
            Process.Start(urlDoSite);
        }

        private void certificadoDigitalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Substitua "https://www.example.com" pelo URL do site que você deseja abrir
            string urlDoSite = "https://conceitocertificadora.com.br/home";

            // Abre o navegador padrão com o site especificado
            Process.Start(urlDoSite);
        }

        private void energiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Substitua "https://www.example.com" pelo URL do site que você deseja abrir
            string urlDoSite = "https://www.facebook.com/ConceitoEnergiaSolarOficial/";

            // Abre o navegador padrão com o site especificado
            Process.Start(urlDoSite);
        }

        private void conceitoLabSchoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Substitua "https://www.example.com" pelo URL do site que você deseja abrir
            string urlDoSite = "https://conceitolab.com.br/home";

            // Abre o navegador padrão com o site especificado
            Process.Start(urlDoSite);
        }

        private void abraOConceitoEmpresarialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caminhoDoExecutavel = @"C:\Program Files (x86)\AnyDesk\AnyDesk.exe";
        }
    }
}
