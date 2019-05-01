namespace senac_sd_desktop
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btMinim = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btSobre = new System.Windows.Forms.Button();
            this.btPedidos = new System.Windows.Forms.Button();
            this.btListar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dragControl = new senac_sd_desktop.DragControl();
            this.dragControl2 = new senac_sd_desktop.DragControl();
            this.panelHeader.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.btMinim);
            this.panelHeader.Controls.Add(this.btFechar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 35);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(342, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trabalho - SWD";
            // 
            // btMinim
            // 
            this.btMinim.FlatAppearance.BorderSize = 0;
            this.btMinim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinim.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btMinim.ForeColor = System.Drawing.Color.White;
            this.btMinim.Location = new System.Drawing.Point(736, 1);
            this.btMinim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btMinim.Name = "btMinim";
            this.btMinim.Size = new System.Drawing.Size(31, 28);
            this.btMinim.TabIndex = 0;
            this.btMinim.Text = "_";
            this.btMinim.UseVisualStyleBackColor = true;
            this.btMinim.Click += new System.EventHandler(this.btMinim_Click);
            // 
            // btFechar
            // 
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btFechar.ForeColor = System.Drawing.Color.White;
            this.btFechar.Location = new System.Drawing.Point(769, 2);
            this.btFechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(31, 28);
            this.btFechar.TabIndex = 0;
            this.btFechar.Text = "X";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(146)))), ((int)(((byte)(243)))));
            this.panelLeft.Controls.Add(this.btSobre);
            this.panelLeft.Controls.Add(this.btPedidos);
            this.panelLeft.Controls.Add(this.btListar);
            this.panelLeft.Controls.Add(this.btCadastrar);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 35);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(126, 415);
            this.panelLeft.TabIndex = 1;
            // 
            // btSobre
            // 
            this.btSobre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(146)))), ((int)(((byte)(243)))));
            this.btSobre.FlatAppearance.BorderSize = 0;
            this.btSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSobre.Location = new System.Drawing.Point(0, 273);
            this.btSobre.Name = "btSobre";
            this.btSobre.Size = new System.Drawing.Size(126, 51);
            this.btSobre.TabIndex = 0;
            this.btSobre.Text = "Sobre";
            this.btSobre.UseVisualStyleBackColor = false;
            this.btSobre.Click += new System.EventHandler(this.button_Click);
            // 
            // btPedidos
            // 
            this.btPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(146)))), ((int)(((byte)(243)))));
            this.btPedidos.FlatAppearance.BorderSize = 0;
            this.btPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPedidos.Location = new System.Drawing.Point(0, 201);
            this.btPedidos.Name = "btPedidos";
            this.btPedidos.Size = new System.Drawing.Size(126, 51);
            this.btPedidos.TabIndex = 0;
            this.btPedidos.Text = "Pedidos";
            this.btPedidos.UseVisualStyleBackColor = false;
            this.btPedidos.Click += new System.EventHandler(this.button_Click);
            // 
            // btListar
            // 
            this.btListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(146)))), ((int)(((byte)(243)))));
            this.btListar.FlatAppearance.BorderSize = 0;
            this.btListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btListar.Location = new System.Drawing.Point(0, 129);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(126, 51);
            this.btListar.TabIndex = 0;
            this.btListar.Text = "Listar Produtos";
            this.btListar.UseVisualStyleBackColor = false;
            this.btListar.Click += new System.EventHandler(this.button_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(146)))), ((int)(((byte)(243)))));
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCadastrar.Location = new System.Drawing.Point(0, 57);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(126, 51);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "Cadastrar Produto";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.button_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(126, 35);
            this.panelContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(674, 415);
            this.panelContent.TabIndex = 2;
            // 
            // dragControl
            // 
            this.dragControl.SelectControl = this.panelHeader;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.label1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btMinim;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btPedidos;
        private System.Windows.Forms.Button btSobre;
        private System.Windows.Forms.Label label1;
        private DragControl dragControl;
        private DragControl dragControl2;
    }
}