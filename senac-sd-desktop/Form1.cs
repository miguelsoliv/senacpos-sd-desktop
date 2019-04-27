using Firebase.Database;
using senac_sd_desktop.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace senac_sd_desktop
{
    public partial class Form1 : Form
    {
        private Button buttonSelected;
        private Color selectedButtonColor = Color.FromArgb(21, 101, 192);
        private Color normalButtonColor = Color.FromArgb(94, 146, 243);
        private WMPLib.WindowsMediaPlayer wplayer;

        public Form1()
        {
            InitializeComponent();

            var firebaseClient = new FirebaseClient("https://senacpos-sd.firebaseio.com/");

            wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = AppDomain.CurrentDomain.BaseDirectory + "alert_sound.mp3";
            wplayer.controls.stop();

            firebaseClient.Child("pedidos").AsObservable<Pedido>().Subscribe(p =>
            {
                if (p.Key == null)
                {
                    wplayer.controls.play();
                }
            });
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
                buttonSelected.ForeColor = Color.Black;
            }

            buttonSelected = bt;
            bt.BackColor = selectedButtonColor;
            bt.ForeColor = Color.White;

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