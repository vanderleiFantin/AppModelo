namespace AplicacaoPoo.Windows
{
    partial class frmCliente
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblClienteCpf = new System.Windows.Forms.Label();
            this.lblDebito = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.txtClienteNome = new System.Windows.Forms.TextBox();
            this.txtClienteCpf = new System.Windows.Forms.TextBox();
            this.txtDebito = new System.Windows.Forms.TextBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaldoInicialValor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(35, 18);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(40, 15);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Nome";
            // 
            // lblClienteCpf
            // 
            this.lblClienteCpf.AutoSize = true;
            this.lblClienteCpf.Location = new System.Drawing.Point(163, 23);
            this.lblClienteCpf.Name = "lblClienteCpf";
            this.lblClienteCpf.Size = new System.Drawing.Size(28, 15);
            this.lblClienteCpf.TabIndex = 1;
            this.lblClienteCpf.Text = "CPF";
            // 
            // lblDebito
            // 
            this.lblDebito.AutoSize = true;
            this.lblDebito.Location = new System.Drawing.Point(35, 78);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(42, 15);
            this.lblDebito.TabIndex = 2;
            this.lblDebito.Text = "Debito";
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(163, 78);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(46, 15);
            this.lblCredito.TabIndex = 3;
            this.lblCredito.Text = "Credito";
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.Location = new System.Drawing.Point(37, 41);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(100, 23);
            this.txtClienteNome.TabIndex = 4;
            // 
            // txtClienteCpf
            // 
            this.txtClienteCpf.Location = new System.Drawing.Point(163, 41);
            this.txtClienteCpf.Name = "txtClienteCpf";
            this.txtClienteCpf.Size = new System.Drawing.Size(100, 23);
            this.txtClienteCpf.TabIndex = 5;
            // 
            // txtDebito
            // 
            this.txtDebito.Location = new System.Drawing.Point(35, 96);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.Size = new System.Drawing.Size(100, 23);
            this.txtDebito.TabIndex = 6;
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(163, 96);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(100, 23);
            this.txtCredito.TabIndex = 7;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(332, 78);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 15);
            this.lblSaldo.TabIndex = 8;
            this.lblSaldo.Text = "SALDO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "SALDO INICIAL";
            // 
            // lblSaldoInicialValor
            // 
            this.lblSaldoInicialValor.AutoSize = true;
            this.lblSaldoInicialValor.Location = new System.Drawing.Point(347, 49);
            this.lblSaldoInicialValor.Name = "lblSaldoInicialValor";
            this.lblSaldoInicialValor.Size = new System.Drawing.Size(13, 15);
            this.lblSaldoInicialValor.TabIndex = 10;
            this.lblSaldoInicialValor.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(35, 130);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 190);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSaldoInicialValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtCredito);
            this.Controls.Add(this.txtDebito);
            this.Controls.Add(this.txtClienteCpf);
            this.Controls.Add(this.txtClienteNome);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.lblDebito);
            this.Controls.Add(this.lblClienteCpf);
            this.Controls.Add(this.lblCliente);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCliente;
        private Label lblClienteCpf;
        private Label lblDebito;
        private Label lblCredito;
        private TextBox txtClienteNome;
        private TextBox txtClienteCpf;
        private TextBox txtDebito;
        private TextBox txtCredito;
        private Label lblSaldo;
        private Label label1;
        private Label lblSaldoInicialValor;
        private Label label3;
        private Button btnCalcular;
    }
}