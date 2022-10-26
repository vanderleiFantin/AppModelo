namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmPrincipal
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
            this.btnAbrirFormConversorMoedas = new System.Windows.Forms.Button();
            this.btnAbrirFormComissionamento = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conversosDeMoedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comissionamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrirFormConversorMoedas
            // 
            this.btnAbrirFormConversorMoedas.Location = new System.Drawing.Point(12, 41);
            this.btnAbrirFormConversorMoedas.Name = "btnAbrirFormConversorMoedas";
            this.btnAbrirFormConversorMoedas.Size = new System.Drawing.Size(158, 64);
            this.btnAbrirFormConversorMoedas.TabIndex = 0;
            this.btnAbrirFormConversorMoedas.Text = "CONVERSOR DE MOEDAS";
            this.btnAbrirFormConversorMoedas.UseVisualStyleBackColor = true;
            this.btnAbrirFormConversorMoedas.Click += new System.EventHandler(this.btnAbrirFormConversorMoedas_Click);
            // 
            // btnAbrirFormComissionamento
            // 
            this.btnAbrirFormComissionamento.Location = new System.Drawing.Point(195, 41);
            this.btnAbrirFormComissionamento.Name = "btnAbrirFormComissionamento";
            this.btnAbrirFormComissionamento.Size = new System.Drawing.Size(149, 64);
            this.btnAbrirFormComissionamento.TabIndex = 1;
            this.btnAbrirFormComissionamento.Text = "COMISSIONAMENTO";
            this.btnAbrirFormComissionamento.UseVisualStyleBackColor = true;
            this.btnAbrirFormComissionamento.Click += new System.EventHandler(this.btnAbrirFormComissionamento_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conversosDeMoedasToolStripMenuItem,
            this.comissionamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conversosDeMoedasToolStripMenuItem
            // 
            this.conversosDeMoedasToolStripMenuItem.Name = "conversosDeMoedasToolStripMenuItem";
            this.conversosDeMoedasToolStripMenuItem.Size = new System.Drawing.Size(209, 29);
            this.conversosDeMoedasToolStripMenuItem.Text = "Conversos de Moedas";
            this.conversosDeMoedasToolStripMenuItem.Click += new System.EventHandler(this.conversosDeMoedasToolStripMenuItem_Click);
            // 
            // comissionamentoToolStripMenuItem
            // 
            this.comissionamentoToolStripMenuItem.Name = "comissionamentoToolStripMenuItem";
            this.comissionamentoToolStripMenuItem.Size = new System.Drawing.Size(175, 29);
            this.comissionamentoToolStripMenuItem.Text = "Comissionamento";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 332);
            this.Controls.Add(this.btnAbrirFormComissionamento);
            this.Controls.Add(this.btnAbrirFormConversorMoedas);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAbrirFormConversorMoedas;
        private Button btnAbrirFormComissionamento;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem conversosDeMoedasToolStripMenuItem;
        private ToolStripMenuItem comissionamentoToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}