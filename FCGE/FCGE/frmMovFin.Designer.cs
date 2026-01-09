namespace FCGE
{
    partial class frmMovFin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTransacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAtual = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbRemover = new System.Windows.Forms.RadioButton();
            this.rbAdicionar = new System.Windows.Forms.RadioButton();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEfetuar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTransacao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAtual);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SALDO";
            // 
            // txtTransacao
            // 
            this.txtTransacao.Location = new System.Drawing.Point(88, 77);
            this.txtTransacao.Name = "txtTransacao";
            this.txtTransacao.Size = new System.Drawing.Size(59, 20);
            this.txtTransacao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TRANSAÇÃO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATUAL:";
            // 
            // txtAtual
            // 
            this.txtAtual.Enabled = false;
            this.txtAtual.Location = new System.Drawing.Point(57, 38);
            this.txtAtual.Name = "txtAtual";
            this.txtAtual.Size = new System.Drawing.Size(90, 20);
            this.txtAtual.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbRemover);
            this.groupBox2.Controls.Add(this.rbAdicionar);
            this.groupBox2.Location = new System.Drawing.Point(181, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OPERAÇÃO";
            // 
            // rbRemover
            // 
            this.rbRemover.AutoSize = true;
            this.rbRemover.Location = new System.Drawing.Point(17, 76);
            this.rbRemover.Name = "rbRemover";
            this.rbRemover.Size = new System.Drawing.Size(79, 17);
            this.rbRemover.TabIndex = 1;
            this.rbRemover.TabStop = true;
            this.rbRemover.Text = "REMOVER";
            this.rbRemover.UseVisualStyleBackColor = true;
            // 
            // rbAdicionar
            // 
            this.rbAdicionar.AutoSize = true;
            this.rbAdicionar.Location = new System.Drawing.Point(17, 38);
            this.rbAdicionar.Name = "rbAdicionar";
            this.rbAdicionar.Size = new System.Drawing.Size(84, 17);
            this.rbAdicionar.TabIndex = 0;
            this.rbAdicionar.TabStop = true;
            this.rbAdicionar.Text = "ADICIONAR";
            this.rbAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 146);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(163, 38);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnEfetuar
            // 
            this.btnEfetuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfetuar.Location = new System.Drawing.Point(181, 146);
            this.btnEfetuar.Name = "btnEfetuar";
            this.btnEfetuar.Size = new System.Drawing.Size(163, 38);
            this.btnEfetuar.TabIndex = 15;
            this.btnEfetuar.TabStop = false;
            this.btnEfetuar.Text = "EFETUAR";
            this.btnEfetuar.UseVisualStyleBackColor = true;
            this.btnEfetuar.Click += new System.EventHandler(this.btnEfetuar_Click);
            // 
            // frmMovFin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 192);
            this.Controls.Add(this.btnEfetuar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMovFin";
            this.Text = "MOVIMENTAÇÕES FINANCEIRAS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAdicionar;
        private System.Windows.Forms.RadioButton rbRemover;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAtual;
        private System.Windows.Forms.TextBox txtTransacao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnEfetuar;
    }
}