namespace senac_sd_desktop
{
    partial class UC_Pedidos
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textPedido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textFormaP = new System.Windows.Forms.TextBox();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFim = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OldLace;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnHora,
            this.ColumnNome,
            this.ColumnTel,
            this.ColumnFim});
            this.dataGridView.Location = new System.Drawing.Point(24, 24);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(627, 189);
            this.dataGridView.TabIndex = 6;
            // 
            // textPedido
            // 
            this.textPedido.Location = new System.Drawing.Point(407, 251);
            this.textPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPedido.Multiline = true;
            this.textPedido.Name = "textPedido";
            this.textPedido.ReadOnly = true;
            this.textPedido.Size = new System.Drawing.Size(244, 58);
            this.textPedido.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pedido:";
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(24, 313);
            this.textEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEndereco.Multiline = true;
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.ReadOnly = true;
            this.textEndereco.Size = new System.Drawing.Size(271, 61);
            this.textEndereco.TabIndex = 10;
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(564, 353);
            this.textTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(87, 21);
            this.textTotal.TabIndex = 11;
            this.textTotal.Text = "R$ 00,00";
            // 
            // textCliente
            // 
            this.textCliente.Location = new System.Drawing.Point(24, 251);
            this.textCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCliente.Name = "textCliente";
            this.textCliente.ReadOnly = true;
            this.textCliente.Size = new System.Drawing.Size(271, 21);
            this.textCliente.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Forma de Pagamento:";
            // 
            // textFormaP
            // 
            this.textFormaP.Location = new System.Drawing.Point(407, 353);
            this.textFormaP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textFormaP.Name = "textFormaP";
            this.textFormaP.ReadOnly = true;
            this.textFormaP.Size = new System.Drawing.Size(127, 21);
            this.textFormaP.TabIndex = 11;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "#";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Width = 40;
            // 
            // ColumnHora
            // 
            this.ColumnHora.HeaderText = "Hora";
            this.ColumnHora.Name = "ColumnHora";
            this.ColumnHora.ReadOnly = true;
            this.ColumnHora.Width = 80;
            // 
            // ColumnNome
            // 
            this.ColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNome.HeaderText = "Nome Cliente";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnTel
            // 
            this.ColumnTel.HeaderText = "Telefone Cliente";
            this.ColumnTel.Name = "ColumnTel";
            this.ColumnTel.ReadOnly = true;
            this.ColumnTel.Width = 150;
            // 
            // ColumnFim
            // 
            this.ColumnFim.HeaderText = "";
            this.ColumnFim.Name = "ColumnFim";
            this.ColumnFim.ReadOnly = true;
            // 
            // UC_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textFormaP);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Pedidos";
            this.Size = new System.Drawing.Size(674, 415);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFormaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTel;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnFim;
    }
}
