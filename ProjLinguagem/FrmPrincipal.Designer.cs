﻿namespace ProjLinguagem
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.linguagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLinguagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linguagemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // linguagemToolStripMenuItem
            // 
            this.linguagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarLinguagemToolStripMenuItem});
            this.linguagemToolStripMenuItem.Name = "linguagemToolStripMenuItem";
            this.linguagemToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.linguagemToolStripMenuItem.Text = "Linguagem";
            // 
            // cadastrarLinguagemToolStripMenuItem
            // 
            this.cadastrarLinguagemToolStripMenuItem.Name = "cadastrarLinguagemToolStripMenuItem";
            this.cadastrarLinguagemToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cadastrarLinguagemToolStripMenuItem.Text = "Cadastrar Linguagem";
            this.cadastrarLinguagemToolStripMenuItem.Click += new System.EventHandler(this.cadastrarLinguagemToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem linguagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLinguagemToolStripMenuItem;
    }
}