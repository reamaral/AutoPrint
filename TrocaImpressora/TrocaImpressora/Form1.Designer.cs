namespace TrocaImpressora
{
    partial class Form1
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
            this.rdb_zebra1 = new System.Windows.Forms.RadioButton();
            this.rdb_zebra2 = new System.Windows.Forms.RadioButton();
            this.btn_atualiza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione qual impressora deseja utilizar para imprimir:";
            // 
            // rdb_zebra1
            // 
            this.rdb_zebra1.AutoSize = true;
            this.rdb_zebra1.Location = new System.Drawing.Point(17, 95);
            this.rdb_zebra1.Name = "rdb_zebra1";
            this.rdb_zebra1.Size = new System.Drawing.Size(118, 29);
            this.rdb_zebra1.TabIndex = 1;
            this.rdb_zebra1.TabStop = true;
            this.rdb_zebra1.Text = "Printer1";
            this.rdb_zebra1.UseVisualStyleBackColor = true;
            // 
            // rdb_zebra2
            // 
            this.rdb_zebra2.AutoSize = true;
            this.rdb_zebra2.Location = new System.Drawing.Point(283, 95);
            this.rdb_zebra2.Name = "rdb_zebra2";
            this.rdb_zebra2.Size = new System.Drawing.Size(118, 29);
            this.rdb_zebra2.TabIndex = 2;
            this.rdb_zebra2.TabStop = true;
            this.rdb_zebra2.Text = "Printer2";
            this.rdb_zebra2.UseVisualStyleBackColor = true;
            // 
            // btn_atualiza
            // 
            this.btn_atualiza.Location = new System.Drawing.Point(419, 180);
            this.btn_atualiza.Name = "btn_atualiza";
            this.btn_atualiza.Size = new System.Drawing.Size(134, 41);
            this.btn_atualiza.TabIndex = 3;
            this.btn_atualiza.Text = "Atualizar";
            this.btn_atualiza.UseVisualStyleBackColor = true;
            this.btn_atualiza.Click += new System.EventHandler(this.btn_atualiza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 248);
            this.Controls.Add(this.btn_atualiza);
            this.Controls.Add(this.rdb_zebra2);
            this.Controls.Add(this.rdb_zebra1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TrocaImpressora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_zebra1;
        private System.Windows.Forms.RadioButton rdb_zebra2;
        private System.Windows.Forms.Button btn_atualiza;
    }
}

