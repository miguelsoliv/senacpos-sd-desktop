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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBtFinalizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFormaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.textPedido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textFormaP = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelInfo.SuspendLayout();
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
            this.ColumnId,
            this.ColumnCodigo,
            this.ColumnHora,
            this.ColumnNome,
            this.ColumnTel,
            this.ColumnBtFinalizar,
            this.ColumnDesc,
            this.ColumnEnder,
            this.ColumnFormaP,
            this.ColumnTotal});
            this.dataGridView.Location = new System.Drawing.Point(24, 24);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(627, 189);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
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
            // ColumnBtFinalizar
            // 
            this.ColumnBtFinalizar.HeaderText = "";
            this.ColumnBtFinalizar.Name = "ColumnBtFinalizar";
            this.ColumnBtFinalizar.ReadOnly = true;
            // 
            // ColumnDesc
            // 
            this.ColumnDesc.HeaderText = "Descrição";
            this.ColumnDesc.Name = "ColumnDesc";
            this.ColumnDesc.ReadOnly = true;
            this.ColumnDesc.Visible = false;
            // 
            // ColumnEnder
            // 
            this.ColumnEnder.HeaderText = "Endereço";
            this.ColumnEnder.Name = "ColumnEnder";
            this.ColumnEnder.ReadOnly = true;
            this.ColumnEnder.Visible = false;
            // 
            // ColumnFormaP
            // 
            this.ColumnFormaP.HeaderText = "FormaPag";
            this.ColumnFormaP.Name = "ColumnFormaP";
            this.ColumnFormaP.ReadOnly = true;
            this.ColumnFormaP.Visible = false;
            // 
            // ColumnTotal
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.ColumnTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnTotal.HeaderText = "Total R$";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            this.ColumnTotal.Visible = false;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.textPedido);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.textEndereco);
            this.panelInfo.Controls.Add(this.textFormaP);
            this.panelInfo.Controls.Add(this.textTotal);
            this.panelInfo.Controls.Add(this.textCliente);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.label5);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Location = new System.Drawing.Point(3, 219);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(668, 193);
            this.panelInfo.TabIndex = 16;
            // 
            // textPedido
            // 
            this.textPedido.Location = new System.Drawing.Point(404, 45);
            this.textPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPedido.Multiline = true;
            this.textPedido.Name = "textPedido";
            this.textPedido.ReadOnly = true;
            this.textPedido.Size = new System.Drawing.Size(244, 58);
            this.textPedido.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Pedido:";
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(21, 107);
            this.textEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEndereco.Multiline = true;
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.ReadOnly = true;
            this.textEndereco.Size = new System.Drawing.Size(287, 61);
            this.textEndereco.TabIndex = 19;
            // 
            // textFormaP
            // 
            this.textFormaP.Location = new System.Drawing.Point(404, 147);
            this.textFormaP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textFormaP.Name = "textFormaP";
            this.textFormaP.ReadOnly = true;
            this.textFormaP.Size = new System.Drawing.Size(127, 21);
            this.textFormaP.TabIndex = 20;
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(561, 147);
            this.textTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(87, 21);
            this.textTotal.TabIndex = 21;
            // 
            // textCliente
            // 
            this.textCliente.Location = new System.Drawing.Point(21, 45);
            this.textCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCliente.Name = "textCliente";
            this.textCliente.ReadOnly = true;
            this.textCliente.Size = new System.Drawing.Size(287, 21);
            this.textCliente.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Forma de Pagamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cliente:";
            // 
            // UC_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Pedidos";
            this.Size = new System.Drawing.Size(674, 415);
            this.Load += new System.EventHandler(this.UC_Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTel;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnBtFinalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFormaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox textPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textFormaP;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
