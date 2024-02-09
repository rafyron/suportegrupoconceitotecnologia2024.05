using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concept_Conceito_Emp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Fecha o Form2
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria uma instância do Form3
            Form3 form3 = new Form3();

            // Exibe o Form3 como uma janela de diálogo
            form3.ShowDialog();

            // Fecha o Form2 e o Form1 após abrir o Form3
            this.Close(); // Fecha o Form2 (assumindo que está no contexto do Form2)
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string urlDoSite = "https://api.whatsapp.com/send/?phone=%2B551836538088&text&type=phone_number&app_absent=0";

            // Abre o navegador padrão com o site especificado
            Process.Start(urlDoSite);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string caminhoDoExecutavel = @"C:\Program Files (x86)\AnyDesk\AnyDesk.exe";

            // Verifica se o arquivo existe no caminho especificado
            if (System.IO.File.Exists(caminhoDoExecutavel))
            {
                // Abre o executável
                Process.Start(caminhoDoExecutavel);
            }
            else
            {
                // Exibe uma mensagem informando que o executável não foi encontrado, junto com o link para baixá-lo
                string mensagem = "O AnyDesk não foi encontrado no seu PC. Você pode baixá-lo neste site: https://anydesk.com/pt/downloads/thank-you?dv=win_exe";
                MessageBox.Show(mensagem, "Executável não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string urlDoSite = "https://backup.grupoconceitotecnologia.com.br/login";

            // Abre o navegador padrão com o site especificado
            Process.Start(urlDoSite);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void voltarParaATelaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
