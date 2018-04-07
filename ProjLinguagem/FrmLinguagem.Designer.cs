namespace ProjLinguagem
{
    partial class FrmLinguagem
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
            this.lbId = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbPontuacao = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPontuacao = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.dgLinguagem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgLinguagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(12, 47);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "ID";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 90);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // lbPontuacao
            // 
            this.lbPontuacao.AutoSize = true;
            this.lbPontuacao.Location = new System.Drawing.Point(12, 129);
            this.lbPontuacao.Name = "lbPontuacao";
            this.lbPontuacao.Size = new System.Drawing.Size(59, 13);
            this.lbPontuacao.TabIndex = 2;
            this.lbPontuacao.Text = "Pontuacao";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(77, 47);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 90);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtPontuacao
            // 
            this.txtPontuacao.Location = new System.Drawing.Point(77, 126);
            this.txtPontuacao.Name = "txtPontuacao";
            this.txtPontuacao.Size = new System.Drawing.Size(100, 20);
            this.txtPontuacao.TabIndex = 5;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(247, 90);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // dgLinguagem
            // 
            this.dgLinguagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLinguagem.Location = new System.Drawing.Point(15, 178);
            this.dgLinguagem.Name = "dgLinguagem";
            this.dgLinguagem.Size = new System.Drawing.Size(362, 201);
            this.dgLinguagem.TabIndex = 7;
            this.dgLinguagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmLinguagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 391);
            this.Controls.Add(this.dgLinguagem);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtPontuacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lbPontuacao);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbId);
            this.Name = "FrmLinguagem";
            this.Text = "FrmLinguagem";
            this.Load += new System.EventHandler(this.FrmLinguagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLinguagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbPontuacao;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPontuacao;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.DataGridView dgLinguagem;
    }
}