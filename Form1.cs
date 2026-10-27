
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AULA_1_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClicar_Click(object sender, EventArgs e)
        {
            using (Form janela = new Form())
            {
                janela.Text = "Mensagem";
                janela.Size = new Size(450, 250);
                janela.StartPosition = FormStartPosition.CenterScreen;
                janela.BackColor = Color.LightYellow;
                janela.FormBorderStyle = FormBorderStyle.FixedDialog;
                janela.MaximizeBox = false;
                janela.MinimizeBox = false;

                Label mensagem = new Label();
                mensagem.Text = "Olá, Mundo!";
                mensagem.Dock = DockStyle.Fill;
                mensagem.TextAlign = ContentAlignment.MiddleCenter;
                mensagem.Font = new Font("Arial", 24, FontStyle.Bold);
                mensagem.ForeColor = Color.DarkGreen;

                janela.Controls.Add(mensagem);
                janela.ShowDialog();
            }
        }
    }
}
