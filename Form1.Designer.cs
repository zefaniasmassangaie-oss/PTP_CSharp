
using System.Drawing;
using System.Windows.Forms;

namespace AULA_1_CSharp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnClicar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnClicar = new Button();

            SuspendLayout();

            btnClicar.Name = "btnClicar";
            btnClicar.Text = "Clica em mim";
            btnClicar.Size = new Size(180, 50);
            btnClicar.Location = new Point(200, 120);
            btnClicar.Font = new Font("Arial", 12, FontStyle.Bold);
            btnClicar.BackColor = Color.DarkGreen;
            btnClicar.ForeColor = Color.White;
            btnClicar.FlatStyle = FlatStyle.Flat;
            btnClicar.Cursor = Cursors.Hand;
            btnClicar.Click += btnClicar_Click;

            Controls.Add(btnClicar);

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 350);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.LightCyan;
            Text = "Aula 1 - CSharp";

            ResumeLayout(false);
        }
    }
}
