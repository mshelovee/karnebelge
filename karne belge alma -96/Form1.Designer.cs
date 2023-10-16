namespace karne_belge_alma__96
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtZayif = new System.Windows.Forms.TextBox();
            this.txtDevamsizlik = new System.Windows.Forms.TextBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not Ortalaması:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(71, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zayıf Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Devamsızlık Sayısı:";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOrtalama.Location = new System.Drawing.Point(184, 57);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(136, 22);
            this.txtOrtalama.TabIndex = 3;
            // 
            // txtZayif
            // 
            this.txtZayif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtZayif.Location = new System.Drawing.Point(184, 138);
            this.txtZayif.Name = "txtZayif";
            this.txtZayif.Size = new System.Drawing.Size(136, 22);
            this.txtZayif.TabIndex = 4;
            // 
            // txtDevamsizlik
            // 
            this.txtDevamsizlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDevamsizlik.Location = new System.Drawing.Point(184, 204);
            this.txtDevamsizlik.Name = "txtDevamsizlik";
            this.txtDevamsizlik.Size = new System.Drawing.Size(136, 22);
            this.txtDevamsizlik.TabIndex = 5;
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoster.Location = new System.Drawing.Point(184, 331);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(136, 49);
            this.btnGoster.TabIndex = 6;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.Color.Red;
            this.lblDurum.Location = new System.Drawing.Point(12, 288);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(62, 20);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.Text = "Durum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.txtDevamsizlik);
            this.Controls.Add(this.txtZayif);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtZayif;
        private System.Windows.Forms.TextBox txtDevamsizlik;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Label lblDurum;
    }
}

