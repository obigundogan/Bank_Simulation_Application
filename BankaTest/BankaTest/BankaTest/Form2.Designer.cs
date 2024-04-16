
namespace BankaTest
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lblhesap = new System.Windows.Forms.Label();
            this.lbltelefon = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btngonder = new System.Windows.Forms.Button();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.mskhesapno = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefon:";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(174, 79);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(59, 29);
            this.lbladsoyad.TabIndex = 4;
            this.lbladsoyad.Text = "Null";
            // 
            // lblhesap
            // 
            this.lblhesap.AutoSize = true;
            this.lblhesap.Location = new System.Drawing.Point(174, 128);
            this.lblhesap.Name = "lblhesap";
            this.lblhesap.Size = new System.Drawing.Size(59, 29);
            this.lblhesap.TabIndex = 5;
            this.lblhesap.Text = "Null";
            // 
            // lbltelefon
            // 
            this.lbltelefon.AutoSize = true;
            this.lbltelefon.Location = new System.Drawing.Point(174, 180);
            this.lbltelefon.Name = "lbltelefon";
            this.lbltelefon.Size = new System.Drawing.Size(59, 29);
            this.lbltelefon.TabIndex = 6;
            this.lbltelefon.Text = "Null";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(174, 233);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(59, 29);
            this.lbltc.TabIndex = 7;
            this.lbltc.Text = "Null";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btngonder);
            this.groupBox1.Controls.Add(this.txttutar);
            this.groupBox1.Controls.Add(this.mskhesapno);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(2, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 242);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Havale";
            // 
            // btngonder
            // 
            this.btngonder.Location = new System.Drawing.Point(177, 161);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(167, 40);
            this.btngonder.TabIndex = 4;
            this.btngonder.Text = "Gönder";
            this.btngonder.UseVisualStyleBackColor = true;
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // txttutar
            // 
            this.txttutar.Location = new System.Drawing.Point(177, 109);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(167, 35);
            this.txttutar.TabIndex = 3;
            // 
            // mskhesapno
            // 
            this.mskhesapno.Location = new System.Drawing.Point(177, 55);
            this.mskhesapno.Mask = "000000";
            this.mskhesapno.Name = "mskhesapno";
            this.mskhesapno.Size = new System.Drawing.Size(167, 35);
            this.mskhesapno.TabIndex = 2;
            this.mskhesapno.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tutar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Hesap No:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(596, 599);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.lbltelefon);
            this.Controls.Add(this.lblhesap);
            this.Controls.Add(this.lbladsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lblhesap;
        private System.Windows.Forms.Label lbltelefon;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btngonder;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.MaskedTextBox mskhesapno;
    }
}