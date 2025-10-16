namespace AdisyonSistemi
{
    partial class işlemler
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
            this.components = new System.ComponentModel.Container();
            this.isimlabel = new System.Windows.Forms.Label();
            this.labelmerhaba = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tarihsaat = new System.Windows.Forms.Timer(this.components);
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isimlabel
            // 
            this.isimlabel.AutoSize = true;
            this.isimlabel.Font = new System.Drawing.Font("Adobe Hebrew", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isimlabel.ForeColor = System.Drawing.Color.White;
            this.isimlabel.Location = new System.Drawing.Point(180, 18);
            this.isimlabel.Name = "isimlabel";
            this.isimlabel.Size = new System.Drawing.Size(50, 26);
            this.isimlabel.TabIndex = 3;
            this.isimlabel.Text = "isim";
            this.isimlabel.Click += new System.EventHandler(this.isimlabel_Click);
            // 
            // labelmerhaba
            // 
            this.labelmerhaba.AutoSize = true;
            this.labelmerhaba.Font = new System.Drawing.Font("Adobe Hebrew", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmerhaba.Location = new System.Drawing.Point(84, 18);
            this.labelmerhaba.Name = "labelmerhaba";
            this.labelmerhaba.Size = new System.Drawing.Size(90, 26);
            this.labelmerhaba.TabIndex = 2;
            this.labelmerhaba.Text = "Merhaba";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AntennaExtraCond Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(622, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tarih";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AntennaExtraCond Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(633, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "saat";
            // 
            // tarihsaat
            // 
            this.tarihsaat.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Image = global::AdisyonSistemi.Properties.Resources.icons8_export_50;
            this.button10.Location = new System.Drawing.Point(787, 265);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(59, 59);
            this.button10.TabIndex = 16;
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Image = global::AdisyonSistemi.Properties.Resources.icons8_reservation_50;
            this.button8.Location = new System.Drawing.Point(572, 227);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(188, 145);
            this.button8.TabIndex = 11;
            this.button8.Text = " Rezervasyon";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Image = global::AdisyonSistemi.Properties.Resources.icons8_depot_50;
            this.button7.Location = new System.Drawing.Point(374, 227);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(188, 145);
            this.button7.TabIndex = 10;
            this.button7.Text = " Depo";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = global::AdisyonSistemi.Properties.Resources.icons8_restaurant_menu_50;
            this.button6.Location = new System.Drawing.Point(176, 227);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 145);
            this.button6.TabIndex = 9;
            this.button6.Text = "Menü";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = global::AdisyonSistemi.Properties.Resources.icons8_person_50;
            this.button5.Location = new System.Drawing.Point(679, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 145);
            this.button5.TabIndex = 8;
            this.button5.Text = "   Aktif Elemanlar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = global::AdisyonSistemi.Properties.Resources.icons8_table_50;
            this.button4.Location = new System.Drawing.Point(481, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 145);
            this.button4.TabIndex = 7;
            this.button4.Text = "  Masa Yönetimi";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::AdisyonSistemi.Properties.Resources.icons8_paid_bill_50;
            this.button3.Location = new System.Drawing.Point(283, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 145);
            this.button3.TabIndex = 6;
            this.button3.Text = "  Sıpariş Geçmişi";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::AdisyonSistemi.Properties.Resources.icons8_pos_terminal_50;
            this.button2.Location = new System.Drawing.Point(85, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 145);
            this.button2.TabIndex = 5;
            this.button2.Text = " Ödeme";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // işlemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(935, 429);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.isimlabel);
            this.Controls.Add(this.labelmerhaba);
            this.Name = "işlemler";
            this.Text = "İşlem Menüsü";
            this.Load += new System.EventHandler(this.menü_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label isimlabel;
        private System.Windows.Forms.Label labelmerhaba;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tarihsaat;
        private System.Windows.Forms.Button button10;
    }
}