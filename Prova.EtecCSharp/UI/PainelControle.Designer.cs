namespace Prova.EtecCSharp.UI
{
    partial class PainelControle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.empresaUI1 = new Prova.EtecCSharp.UI.EmpresaUI();
            this.funcionarioUI1 = new Prova.EtecCSharp.UI.FuncionarioUI();
            this.clienteUI1 = new Prova.EtecCSharp.UI.ClienteUI();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnFunc);
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Controls.Add(this.btnEmpresa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 78);
            this.panel1.TabIndex = 0;
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.BackColor = System.Drawing.Color.Gold;
            this.btnEmpresa.Location = new System.Drawing.Point(38, 42);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(101, 33);
            this.btnEmpresa.TabIndex = 4;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = false;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Gold;
            this.btnCliente.Location = new System.Drawing.Point(191, 42);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(101, 33);
            this.btnCliente.TabIndex = 4;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.BackColor = System.Drawing.Color.Gold;
            this.btnFunc.Location = new System.Drawing.Point(346, 42);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(101, 33);
            this.btnFunc.TabIndex = 4;
            this.btnFunc.Text = "Funcionario";
            this.btnFunc.UseVisualStyleBackColor = false;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(864, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(41, 42);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "X";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // empresaUI1
            // 
            this.empresaUI1.BackColor = System.Drawing.Color.White;
            this.empresaUI1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaUI1.Location = new System.Drawing.Point(3, 78);
            this.empresaUI1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.empresaUI1.Name = "empresaUI1";
            this.empresaUI1.Size = new System.Drawing.Size(910, 468);
            this.empresaUI1.TabIndex = 2;
            // 
            // funcionarioUI1
            // 
            this.funcionarioUI1.BackColor = System.Drawing.Color.White;
            this.funcionarioUI1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionarioUI1.Location = new System.Drawing.Point(3, 83);
            this.funcionarioUI1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.funcionarioUI1.Name = "funcionarioUI1";
            this.funcionarioUI1.Size = new System.Drawing.Size(910, 463);
            this.funcionarioUI1.TabIndex = 1;
            // 
            // clienteUI1
            // 
            this.clienteUI1.BackColor = System.Drawing.Color.White;
            this.clienteUI1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteUI1.Location = new System.Drawing.Point(0, 78);
            this.clienteUI1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clienteUI1.Name = "clienteUI1";
            this.clienteUI1.Size = new System.Drawing.Size(910, 417);
            this.clienteUI1.TabIndex = 3;
            // 
            // PainelControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.empresaUI1);
            this.Controls.Add(this.funcionarioUI1);
            this.Controls.Add(this.clienteUI1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PainelControle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PainelControle";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnEmpresa;
        private FuncionarioUI funcionarioUI1;
        private EmpresaUI empresaUI1;
        private ClienteUI clienteUI1;
    }
}