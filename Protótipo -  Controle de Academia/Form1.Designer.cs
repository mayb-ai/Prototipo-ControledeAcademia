namespace Protótipo____Controle_de_Academia
{
    partial class frmInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicial));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecep = new System.Windows.Forms.Button();
            this.btnAdm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMan = new System.Windows.Forms.Button();
            this.btnAdmissao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Name = "label1";
            // 
            // btnRecep
            // 
            resources.ApplyResources(this.btnRecep, "btnRecep");
            this.btnRecep.BackColor = System.Drawing.Color.SandyBrown;
            this.btnRecep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRecep.Name = "btnRecep";
            this.btnRecep.UseVisualStyleBackColor = false;
            this.btnRecep.Click += new System.EventHandler(this.btnRecep_Click);
            // 
            // btnAdm
            // 
            resources.ApplyResources(this.btnAdm, "btnAdm");
            this.btnAdm.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.UseVisualStyleBackColor = false;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnMan
            // 
            resources.ApplyResources(this.btnMan, "btnMan");
            this.btnMan.BackColor = System.Drawing.Color.SandyBrown;
            this.btnMan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMan.Name = "btnMan";
            this.btnMan.UseVisualStyleBackColor = false;
            this.btnMan.Click += new System.EventHandler(this.btnMan_Click);
            // 
            // btnAdmissao
            // 
            resources.ApplyResources(this.btnAdmissao, "btnAdmissao");
            this.btnAdmissao.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAdmissao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdmissao.Name = "btnAdmissao";
            this.btnAdmissao.UseVisualStyleBackColor = false;
            this.btnAdmissao.Click += new System.EventHandler(this.btnAdmissao_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Linen;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmInicial
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdmissao);
            this.Controls.Add(this.btnMan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdm);
            this.Controls.Add(this.btnRecep);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmInicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecep;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMan;
        private System.Windows.Forms.Button btnAdmissao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

