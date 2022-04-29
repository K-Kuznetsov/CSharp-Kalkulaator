namespace Kalkulaator
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblVastus = new System.Windows.Forms.Label();
            this.chkLiida = new System.Windows.Forms.RadioButton();
            this.chkLahuta = new System.Windows.Forms.RadioButton();
            this.chkKorruta = new System.Windows.Forms.RadioButton();
            this.chkJaga = new System.Windows.Forms.RadioButton();
            this.btnArvuta = new System.Windows.Forms.Button();
            this.txtArv1 = new System.Windows.Forms.TextBox();
            this.txtArv2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Esimene arv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(436, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teine arv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(43, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vastus";
            // 
            // lblVastus
            // 
            this.lblVastus.BackColor = System.Drawing.Color.Transparent;
            this.lblVastus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVastus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblVastus.Location = new System.Drawing.Point(130, 195);
            this.lblVastus.Name = "lblVastus";
            this.lblVastus.Size = new System.Drawing.Size(400, 50);
            this.lblVastus.TabIndex = 5;
            // 
            // chkLiida
            // 
            this.chkLiida.AutoSize = true;
            this.chkLiida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chkLiida.Location = new System.Drawing.Point(48, 271);
            this.chkLiida.Name = "chkLiida";
            this.chkLiida.Size = new System.Drawing.Size(71, 29);
            this.chkLiida.TabIndex = 6;
            this.chkLiida.Text = "Liida";
            this.chkLiida.UseVisualStyleBackColor = true;
            // 
            // chkLahuta
            // 
            this.chkLahuta.AutoSize = true;
            this.chkLahuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chkLahuta.Location = new System.Drawing.Point(48, 324);
            this.chkLahuta.Name = "chkLahuta";
            this.chkLahuta.Size = new System.Drawing.Size(90, 29);
            this.chkLahuta.TabIndex = 7;
            this.chkLahuta.Text = "Lahuta";
            this.chkLahuta.UseVisualStyleBackColor = true;
            // 
            // chkKorruta
            // 
            this.chkKorruta.AutoSize = true;
            this.chkKorruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chkKorruta.Location = new System.Drawing.Point(436, 271);
            this.chkKorruta.Name = "chkKorruta";
            this.chkKorruta.Size = new System.Drawing.Size(94, 29);
            this.chkKorruta.TabIndex = 8;
            this.chkKorruta.Text = "Korruta";
            this.chkKorruta.UseVisualStyleBackColor = true;
            // 
            // chkJaga
            // 
            this.chkJaga.AutoSize = true;
            this.chkJaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chkJaga.Location = new System.Drawing.Point(436, 324);
            this.chkJaga.Name = "chkJaga";
            this.chkJaga.Size = new System.Drawing.Size(74, 29);
            this.chkJaga.TabIndex = 9;
            this.chkJaga.Text = "Jaga";
            this.chkJaga.UseVisualStyleBackColor = true;
            // 
            // btnArvuta
            // 
            this.btnArvuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnArvuta.Location = new System.Drawing.Point(210, 361);
            this.btnArvuta.Name = "btnArvuta";
            this.btnArvuta.Size = new System.Drawing.Size(142, 50);
            this.btnArvuta.TabIndex = 10;
            this.btnArvuta.Text = "Arvuta";
            this.btnArvuta.UseVisualStyleBackColor = true;
            this.btnArvuta.Click += new System.EventHandler(this.btnArvuta_Click);
            // 
            // txtArv1
            // 
            this.txtArv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtArv1.Location = new System.Drawing.Point(46, 93);
            this.txtArv1.Name = "txtArv1";
            this.txtArv1.Size = new System.Drawing.Size(200, 30);
            this.txtArv1.TabIndex = 11;
            // 
            // txtArv2
            // 
            this.txtArv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtArv2.Location = new System.Drawing.Point(330, 93);
            this.txtArv2.Name = "txtArv2";
            this.txtArv2.Size = new System.Drawing.Size(200, 30);
            this.txtArv2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.txtArv2);
            this.Controls.Add(this.txtArv1);
            this.Controls.Add(this.btnArvuta);
            this.Controls.Add(this.chkJaga);
            this.Controls.Add(this.chkKorruta);
            this.Controls.Add(this.chkLahuta);
            this.Controls.Add(this.chkLiida);
            this.Controls.Add(this.lblVastus);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVastus;
        private System.Windows.Forms.RadioButton chkLiida;
        private System.Windows.Forms.RadioButton chkLahuta;
        private System.Windows.Forms.RadioButton chkKorruta;
        private System.Windows.Forms.RadioButton chkJaga;
        private System.Windows.Forms.Button btnArvuta;
        private System.Windows.Forms.TextBox txtArv1;
        private System.Windows.Forms.TextBox txtArv2;
    }
}

