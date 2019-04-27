using System;
using System.Windows.Forms;

namespace senac_sd_desktop
{
    public partial class UC_Pedidos : UserControl
    {
        public UC_Pedidos()
        {
            InitializeComponent();

            dataGridView.Rows.Add("1", "10:00", "Miguel", "981474090", "Finalizar Pedido");
            dataGridView.Rows.Add("2", "10:00", "Miguel", "981474090", "Finalizar Pedido");
            dataGridView.Rows.Add("3", "10:00", "Miguel", "981474090", "Finalizar Pedido");
        }
    }
}