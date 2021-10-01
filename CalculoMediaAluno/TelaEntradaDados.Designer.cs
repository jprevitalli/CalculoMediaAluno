
namespace CalculoMediaAluno
{
    partial class TelaEntradaDados
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.nAtiv01 = new System.Windows.Forms.NumericUpDown();
            this.nAtiv02 = new System.Windows.Forms.NumericUpDown();
            this.nAtiv03 = new System.Windows.Forms.NumericUpDown();
            this.nAtiv04 = new System.Windows.Forms.NumericUpDown();
            this.nMedia = new System.Windows.Forms.NumericUpDown();
            this.btnMedia = new System.Windows.Forms.Button();
            this.lstBoxResul = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nAtiv01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAtiv02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAtiv03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAtiv04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LEMON MILK", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculando a Média dos Alunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Insira as Notas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Atividade 01:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Atividade 02:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Atividade 03:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Atividade 04:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Média:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(45, 128);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(272, 22);
            this.txtNome.TabIndex = 9;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(340, 128);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(168, 22);
            this.dtpNascimento.TabIndex = 10;
            // 
            // nAtiv01
            // 
            this.nAtiv01.Location = new System.Drawing.Point(153, 218);
            this.nAtiv01.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nAtiv01.Name = "nAtiv01";
            this.nAtiv01.Size = new System.Drawing.Size(57, 22);
            this.nAtiv01.TabIndex = 11;
            this.nAtiv01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nAtiv02
            // 
            this.nAtiv02.Location = new System.Drawing.Point(153, 246);
            this.nAtiv02.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nAtiv02.Name = "nAtiv02";
            this.nAtiv02.Size = new System.Drawing.Size(57, 22);
            this.nAtiv02.TabIndex = 12;
            this.nAtiv02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nAtiv03
            // 
            this.nAtiv03.Location = new System.Drawing.Point(153, 274);
            this.nAtiv03.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nAtiv03.Name = "nAtiv03";
            this.nAtiv03.Size = new System.Drawing.Size(57, 22);
            this.nAtiv03.TabIndex = 13;
            this.nAtiv03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nAtiv04
            // 
            this.nAtiv04.Location = new System.Drawing.Point(153, 302);
            this.nAtiv04.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nAtiv04.Name = "nAtiv04";
            this.nAtiv04.Size = new System.Drawing.Size(57, 22);
            this.nAtiv04.TabIndex = 14;
            this.nAtiv04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nMedia
            // 
            this.nMedia.Location = new System.Drawing.Point(446, 218);
            this.nMedia.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nMedia.Name = "nMedia";
            this.nMedia.Size = new System.Drawing.Size(57, 22);
            this.nMedia.TabIndex = 15;
            this.nMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(335, 279);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(168, 45);
            this.btnMedia.TabIndex = 16;
            this.btnMedia.Text = "Média";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // lstBoxResul
            // 
            this.lstBoxResul.FormattingEnabled = true;
            this.lstBoxResul.ItemHeight = 16;
            this.lstBoxResul.Location = new System.Drawing.Point(45, 350);
            this.lstBoxResul.Name = "lstBoxResul";
            this.lstBoxResul.Size = new System.Drawing.Size(458, 196);
            this.lstBoxResul.TabIndex = 17;
            // 
            // TelaEntradaDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 558);
            this.Controls.Add(this.lstBoxResul);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.nMedia);
            this.Controls.Add(this.nAtiv04);
            this.Controls.Add(this.nAtiv03);
            this.Controls.Add(this.nAtiv02);
            this.Controls.Add(this.nAtiv01);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TelaEntradaDados";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Média dos Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.nAtiv01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAtiv02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAtiv03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAtiv04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.NumericUpDown nAtiv01;
        private System.Windows.Forms.NumericUpDown nAtiv02;
        private System.Windows.Forms.NumericUpDown nAtiv03;
        private System.Windows.Forms.NumericUpDown nAtiv04;
        private System.Windows.Forms.NumericUpDown nMedia;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.ListBox lstBoxResul;
    }
}

