namespace Princinpal
{
    partial class frmPrincipalMdi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNacionalidade = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNaturalidade = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastraFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 90);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem,
            this.btnFuncionario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNacionalidade,
            this.btnNaturalidade});
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.funcionariosToolStripMenuItem.Text = "Cadastros";
            // 
            // btnNacionalidade
            // 
            this.btnNacionalidade.Name = "btnNacionalidade";
            this.btnNacionalidade.Size = new System.Drawing.Size(180, 22);
            this.btnNacionalidade.Text = "Nacionalidade";
            this.btnNacionalidade.Click += new System.EventHandler(this.btnNacionalidade_Click);
            // 
            // btnNaturalidade
            // 
            this.btnNaturalidade.Name = "btnNaturalidade";
            this.btnNaturalidade.Size = new System.Drawing.Size(180, 22);
            this.btnNaturalidade.Text = "Naturalidade";
            this.btnNaturalidade.Click += new System.EventHandler(this.btnNaturalidade_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastraFuncionario});
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(87, 20);
            this.btnFuncionario.Text = "Funcionarios";
            // 
            // btnCadastraFuncionario
            // 
            this.btnCadastraFuncionario.Name = "btnCadastraFuncionario";
            this.btnCadastraFuncionario.Size = new System.Drawing.Size(186, 22);
            this.btnCadastraFuncionario.Text = "Cadastra Funcionario";
            this.btnCadastraFuncionario.Click += new System.EventHandler(this.btnCadastraFuncionario_Click);
            // 
            // frmPrincipalMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipalMdi";
            this.Text = "Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNacionalidade;
        private System.Windows.Forms.ToolStripMenuItem btnNaturalidade;
        private System.Windows.Forms.ToolStripMenuItem btnFuncionario;
        private System.Windows.Forms.ToolStripMenuItem btnCadastraFuncionario;
    }
}

