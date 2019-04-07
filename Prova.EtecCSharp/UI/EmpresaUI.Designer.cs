namespace Prova.EtecCSharp.UI
{
    partial class EmpresaUI
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
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblPorte = new System.Windows.Forms.Label();
            this.lblNomeLoja = new System.Windows.Forms.Label();
            this.cmbPorte = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtConsulta.Location = new System.Drawing.Point(519, 32);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(292, 25);
            this.txtConsulta.TabIndex = 26;
            this.txtConsulta.Text = "Digite o ID da Loja";
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(433, 36);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(80, 21);
            this.lblConsulta.TabIndex = 25;
            this.lblConsulta.Text = "Consultar:";
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Location = new System.Drawing.Point(437, 74);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.Size = new System.Drawing.Size(374, 275);
            this.dgvEmpresa.TabIndex = 24;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(183, 186);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 33);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.Location = new System.Drawing.Point(151, 98);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(182, 25);
            this.txtEnd.TabIndex = 22;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(151, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(182, 25);
            this.txtNome.TabIndex = 21;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCNPJ.Location = new System.Drawing.Point(151, 32);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(182, 25);
            this.txtCNPJ.TabIndex = 20;
            this.txtCNPJ.Text = "Sem pontos ou traços";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(23, 102);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(77, 21);
            this.lblEndereco.TabIndex = 19;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblPorte
            // 
            this.lblPorte.AutoSize = true;
            this.lblPorte.Location = new System.Drawing.Point(23, 132);
            this.lblPorte.Name = "lblPorte";
            this.lblPorte.Size = new System.Drawing.Size(49, 21);
            this.lblPorte.TabIndex = 18;
            this.lblPorte.Text = "Porte:";
            // 
            // lblNomeLoja
            // 
            this.lblNomeLoja.AutoSize = true;
            this.lblNomeLoja.Location = new System.Drawing.Point(23, 72);
            this.lblNomeLoja.Name = "lblNomeLoja";
            this.lblNomeLoja.Size = new System.Drawing.Size(110, 21);
            this.lblNomeLoja.TabIndex = 17;
            this.lblNomeLoja.Text = "Nome da Loja:";
            // 
            // cmbPorte
            // 
            this.cmbPorte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPorte.FormattingEnabled = true;
            this.cmbPorte.Items.AddRange(new object[] {
            "Pequeno",
            "Medio",
            "Grande"});
            this.cmbPorte.Location = new System.Drawing.Point(151, 128);
            this.cmbPorte.Name = "cmbPorte";
            this.cmbPorte.Size = new System.Drawing.Size(121, 25);
            this.cmbPorte.TabIndex = 16;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(83, 186);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 33);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(23, 36);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(49, 21);
            this.lblCnpj.TabIndex = 14;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.ForeColor = System.Drawing.Color.White;
            this.btnBusca.Location = new System.Drawing.Point(813, 27);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(67, 30);
            this.btnBusca.TabIndex = 27;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // EmpresaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.dgvEmpresa);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblPorte);
            this.Controls.Add(this.lblNomeLoja);
            this.Controls.Add(this.cmbPorte);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblCnpj);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmpresaUI";
            this.Size = new System.Drawing.Size(910, 468);
            this.Load += new System.EventHandler(this.EmpresaUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblPorte;
        private System.Windows.Forms.Label lblNomeLoja;
        private System.Windows.Forms.ComboBox cmbPorte;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Button btnBusca;
    }
}
