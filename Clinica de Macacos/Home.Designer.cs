
namespace Clinica_de_Macacos
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelEsq = new System.Windows.Forms.Panel();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.BtnPClientes = new System.Windows.Forms.Button();
            this.BtnCadPet = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.PanelEsq.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelEsq
            // 
            this.PanelEsq.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PanelEsq.Controls.Add(this.BtnInicio);
            this.PanelEsq.Controls.Add(this.BtnPClientes);
            this.PanelEsq.Controls.Add(this.BtnCadPet);
            this.PanelEsq.Controls.Add(this.BtnCliente);
            this.PanelEsq.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelEsq.Location = new System.Drawing.Point(0, 0);
            this.PanelEsq.Name = "PanelEsq";
            this.PanelEsq.Size = new System.Drawing.Size(244, 559);
            this.PanelEsq.TabIndex = 0;
            // 
            // BtnInicio
            // 
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnInicio.Location = new System.Drawing.Point(21, 124);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(202, 61);
            this.BtnInicio.TabIndex = 5;
            this.BtnInicio.Text = "Home";
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // BtnPClientes
            // 
            this.BtnPClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPClientes.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPClientes.Location = new System.Drawing.Point(21, 409);
            this.BtnPClientes.Name = "BtnPClientes";
            this.BtnPClientes.Size = new System.Drawing.Size(202, 61);
            this.BtnPClientes.TabIndex = 4;
            this.BtnPClientes.Text = "Principais Clientes";
            this.BtnPClientes.UseVisualStyleBackColor = true;
            this.BtnPClientes.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnCadPet
            // 
            this.BtnCadPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadPet.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadPet.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCadPet.Location = new System.Drawing.Point(21, 314);
            this.BtnCadPet.Name = "BtnCadPet";
            this.BtnCadPet.Size = new System.Drawing.Size(202, 61);
            this.BtnCadPet.TabIndex = 2;
            this.BtnCadPet.Text = "Cadastrar meu Pet";
            this.BtnCadPet.UseVisualStyleBackColor = true;
            this.BtnCadPet.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCliente.Location = new System.Drawing.Point(21, 218);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(202, 61);
            this.BtnCliente.TabIndex = 0;
            this.BtnCliente.Text = "Me Cadastrar";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Controls.Add(this.BtnMin);
            this.PanelTop.Controls.Add(this.BtnSair);
            this.PanelTop.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1061, 54);
            this.PanelTop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clinica Veterinaria Macacos Lindos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.BackgroundImage = global::Clinica_de_Macacos.Properties.Resources._1492790945_39minimize_84242;
            this.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Location = new System.Drawing.Point(954, 3);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(44, 48);
            this.BtnMin.TabIndex = 2;
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackgroundImage = global::Clinica_de_Macacos.Properties.Resources.logout;
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Location = new System.Drawing.Point(901, 6);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(33, 42);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PanelCenter
            // 
            this.PanelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PanelCenter.BackgroundImage = global::Clinica_de_Macacos.Properties.Resources.R;
            this.PanelCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCenter.Location = new System.Drawing.Point(244, 0);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(817, 559);
            this.PanelCenter.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 559);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelCenter);
            this.Controls.Add(this.PanelEsq);
            this.Font = new System.Drawing.Font("MT Extra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelEsq.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelEsq;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnCadPet;
        private System.Windows.Forms.Button BtnPClientes;
        private System.Windows.Forms.Panel PanelCenter;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Label label1;
    }
}

