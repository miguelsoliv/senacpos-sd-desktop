using System;
using System.Drawing;
using System.Windows.Forms;

namespace senac_sd_desktop
{
    public partial class Form1 : Form
    {
        private Button buttonSelected;
        private Color selectedButtonColor = Color.FromArgb(21, 101, 192), normalButtonColor = Color.FromArgb(94, 146, 243);

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;

            if (bt.BackColor == selectedButtonColor)
            {
                return;
            }

            Control c = null;

            switch (bt.Name)
            {
                case "btCadastrar":
                    c = new UC_Cadastrar();
                    break;
                case "btListar":
                    c = new UC_Listar();
                    break;
                case "btPedidos":
                    c = new UC_Pedidos();
                    break;
                case "btSobre":
                    break;
            }

            if (buttonSelected != null)
            {
                buttonSelected.BackColor = normalButtonColor;
            }

            buttonSelected = bt;
            bt.BackColor = selectedButtonColor;

            if (c != null)
            {
                c.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(c);
            }
        }

        private void btMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}