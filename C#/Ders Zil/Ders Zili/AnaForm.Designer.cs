namespace Ders_Zili
{
	partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.zamangb = new System.Windows.Forms.GroupBox();
            this.süre = new System.Windows.Forms.Label();
            this.araSüresi = new System.Windows.Forms.NumericUpDown();
            this.dersSüresi = new System.Windows.Forms.NumericUpDown();
            this.yazı2 = new System.Windows.Forms.Label();
            this.yazı1 = new System.Windows.Forms.Label();
            this.bdbox = new System.Windows.Forms.GroupBox();
            this.başla = new System.Windows.Forms.Button();
            this.saatekle = new System.Windows.Forms.Button();
            this.sıfırla = new System.Windows.Forms.Button();
            this.zamanlayıcı = new System.Windows.Forms.Timer(this.components);
            this.simge = new System.Windows.Forms.NotifyIcon(this.components);
            this.menü = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menü_göster = new System.Windows.Forms.ToolStripMenuItem();
            this.menü_çıkış = new System.Windows.Forms.ToolStripMenuItem();
            this.eklemeGroup = new System.Windows.Forms.GroupBox();
            this.saatlerGroup = new System.Windows.Forms.GroupBox();
            this.saatler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.zamangb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.araSüresi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersSüresi)).BeginInit();
            this.bdbox.SuspendLayout();
            this.menü.SuspendLayout();
            this.eklemeGroup.SuspendLayout();
            this.saatlerGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // zamangb
            // 
            this.zamangb.BackColor = System.Drawing.Color.Transparent;
            this.zamangb.Controls.Add(this.süre);
            this.zamangb.ForeColor = System.Drawing.Color.White;
            this.zamangb.Location = new System.Drawing.Point(12, 12);
            this.zamangb.Name = "zamangb";
            this.zamangb.Size = new System.Drawing.Size(370, 90);
            this.zamangb.TabIndex = 0;
            this.zamangb.TabStop = false;
            this.zamangb.Text = "Zamanlar";
            this.zamangb.Enter += new System.EventHandler(this.kutu1_Enter);
            // 
            // süre
            // 
            this.süre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.süre.Font = new System.Drawing.Font("Microsoft Sans Serif", 44.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.süre.ForeColor = System.Drawing.Color.White;
            this.süre.Location = new System.Drawing.Point(3, 12);
            this.süre.Name = "süre";
            this.süre.Size = new System.Drawing.Size(364, 75);
            this.süre.TabIndex = 2;
            this.süre.Text = "00:00:00";
            this.süre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.süre.Click += new System.EventHandler(this.süre_Click);
            // 
            // araSüresi
            // 
            this.araSüresi.Location = new System.Drawing.Point(100, 57);
            this.araSüresi.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.araSüresi.Name = "araSüresi";
            this.araSüresi.Size = new System.Drawing.Size(78, 20);
            this.araSüresi.TabIndex = 1;
            this.araSüresi.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.araSüresi.ValueChanged += new System.EventHandler(this.araSüresi_ValueChanged);
            // 
            // dersSüresi
            // 
            this.dersSüresi.Location = new System.Drawing.Point(100, 20);
            this.dersSüresi.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.dersSüresi.Name = "dersSüresi";
            this.dersSüresi.Size = new System.Drawing.Size(78, 20);
            this.dersSüresi.TabIndex = 1;
            this.dersSüresi.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.dersSüresi.ValueChanged += new System.EventHandler(this.dersSüresi_ValueChanged);
            // 
            // yazı2
            // 
            this.yazı2.AutoSize = true;
            this.yazı2.ForeColor = System.Drawing.Color.White;
            this.yazı2.Location = new System.Drawing.Point(12, 59);
            this.yazı2.Name = "yazı2";
            this.yazı2.Size = new System.Drawing.Size(76, 13);
            this.yazı2.TabIndex = 0;
            this.yazı2.Text = "Ara Süresi (dk)";
            this.yazı2.Click += new System.EventHandler(this.yazı2_Click);
            // 
            // yazı1
            // 
            this.yazı1.AutoSize = true;
            this.yazı1.ForeColor = System.Drawing.Color.White;
            this.yazı1.Location = new System.Drawing.Point(12, 22);
            this.yazı1.Name = "yazı1";
            this.yazı1.Size = new System.Drawing.Size(82, 13);
            this.yazı1.TabIndex = 0;
            this.yazı1.Text = "Ders Süresi (dk)";
            this.yazı1.Click += new System.EventHandler(this.yazı1_Click);
            // 
            // bdbox
            // 
            this.bdbox.BackColor = System.Drawing.Color.Transparent;
            this.bdbox.Controls.Add(this.başla);
            this.bdbox.Controls.Add(this.saatekle);
            this.bdbox.Controls.Add(this.sıfırla);
            this.bdbox.ForeColor = System.Drawing.Color.White;
            this.bdbox.Location = new System.Drawing.Point(300, 111);
            this.bdbox.Name = "bdbox";
            this.bdbox.Size = new System.Drawing.Size(157, 81);
            this.bdbox.TabIndex = 1;
            this.bdbox.TabStop = false;
            this.bdbox.Text = "Seçenekler";
            // 
            // başla
            // 
            this.başla.BackColor = System.Drawing.Color.Transparent;
            this.başla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.başla.ForeColor = System.Drawing.Color.Lime;
            this.başla.Image = global::Ders_Zili.Properties.Resources.icons8_play_50;
            this.başla.Location = new System.Drawing.Point(156, 19);
            this.başla.Name = "başla";
            this.başla.Size = new System.Drawing.Size(69, 55);
            this.başla.TabIndex = 0;
            this.başla.UseVisualStyleBackColor = false;
            this.başla.Visible = false;
            this.başla.Click += new System.EventHandler(this.başla_Click);
            // 
            // saatekle
            // 
            this.saatekle.BackColor = System.Drawing.Color.Transparent;
            this.saatekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saatekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.saatekle.Image = global::Ders_Zili.Properties.Resources.icons8_add_new_50;
            this.saatekle.Location = new System.Drawing.Point(6, 19);
            this.saatekle.Name = "saatekle";
            this.saatekle.Size = new System.Drawing.Size(69, 55);
            this.saatekle.TabIndex = 1;
            this.saatekle.UseVisualStyleBackColor = false;
            this.saatekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // sıfırla
            // 
            this.sıfırla.BackColor = System.Drawing.Color.Transparent;
            this.sıfırla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sıfırla.ForeColor = System.Drawing.Color.Red;
            this.sıfırla.Image = global::Ders_Zili.Properties.Resources.icons8_shutdown_30;
            this.sıfırla.Location = new System.Drawing.Point(81, 19);
            this.sıfırla.Name = "sıfırla";
            this.sıfırla.Size = new System.Drawing.Size(69, 55);
            this.sıfırla.TabIndex = 0;
            this.sıfırla.UseVisualStyleBackColor = false;
            this.sıfırla.Click += new System.EventHandler(this.sıfırla_Click);
            // 
            // zamanlayıcı
            // 
            this.zamanlayıcı.Interval = 1000;
            this.zamanlayıcı.Tick += new System.EventHandler(this.zamanlayıcı_Tick);
            // 
            // simge
            // 
            this.simge.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.simge.BalloonTipTitle = "Ders Zili";
            this.simge.ContextMenuStrip = this.menü;
            this.simge.Icon = ((System.Drawing.Icon)(resources.GetObject("simge.Icon")));
            this.simge.Text = "Ders Zili";
            this.simge.Visible = true;
            this.simge.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.simge_MouseDoubleClick);
            // 
            // menü
            // 
            this.menü.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menü_göster,
            this.menü_çıkış});
            this.menü.Name = "menü";
            this.menü.Size = new System.Drawing.Size(142, 48);
            // 
            // menü_göster
            // 
            this.menü_göster.Name = "menü_göster";
            this.menü_göster.Size = new System.Drawing.Size(141, 22);
            this.menü_göster.Text = "&Göster";
            this.menü_göster.Click += new System.EventHandler(this.menü_göster_Click);
            // 
            // menü_çıkış
            // 
            this.menü_çıkış.Name = "menü_çıkış";
            this.menü_çıkış.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menü_çıkış.Size = new System.Drawing.Size(141, 22);
            this.menü_çıkış.Text = "&Çıkış";
            this.menü_çıkış.Click += new System.EventHandler(this.menü_çıkış_Click);
            // 
            // eklemeGroup
            // 
            this.eklemeGroup.BackColor = System.Drawing.Color.Transparent;
            this.eklemeGroup.Controls.Add(this.dersSüresi);
            this.eklemeGroup.Controls.Add(this.araSüresi);
            this.eklemeGroup.Controls.Add(this.yazı1);
            this.eklemeGroup.Controls.Add(this.yazı2);
            this.eklemeGroup.ForeColor = System.Drawing.Color.White;
            this.eklemeGroup.Location = new System.Drawing.Point(401, 12);
            this.eklemeGroup.Name = "eklemeGroup";
            this.eklemeGroup.Size = new System.Drawing.Size(194, 90);
            this.eklemeGroup.TabIndex = 2;
            this.eklemeGroup.TabStop = false;
            this.eklemeGroup.Text = "Ekleme";
            // 
            // saatlerGroup
            // 
            this.saatlerGroup.BackColor = System.Drawing.Color.Transparent;
            this.saatlerGroup.Controls.Add(this.saatler);
            this.saatlerGroup.ForeColor = System.Drawing.Color.White;
            this.saatlerGroup.Location = new System.Drawing.Point(601, 12);
            this.saatlerGroup.Name = "saatlerGroup";
            this.saatlerGroup.Size = new System.Drawing.Size(214, 177);
            this.saatlerGroup.TabIndex = 3;
            this.saatlerGroup.TabStop = false;
            this.saatlerGroup.Text = "Saatler";
            // 
            // saatler
            // 
            this.saatler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saatler.FormattingEnabled = true;
            this.saatler.ItemHeight = 25;
            this.saatler.Location = new System.Drawing.Point(27, 14);
            this.saatler.Name = "saatler";
            this.saatler.Size = new System.Drawing.Size(161, 154);
            this.saatler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(24, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "zaman";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(24, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zil Durumu : Ders";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = global::Ders_Zili.Properties.Resources.icons8_turkey_401;
            this.button1.Location = new System.Drawing.Point(12, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 42);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Image = global::Ders_Zili.Properties.Resources.icons8_notification_48;
            this.button2.Location = new System.Drawing.Point(87, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 42);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ders_Zili.Properties.Resources.Dark_Pink_Gradient_Party_Word_Definition_Animated_Your_Story;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 204);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saatlerGroup);
            this.Controls.Add(this.eklemeGroup);
            this.Controls.Add(this.bdbox);
            this.Controls.Add(this.zamangb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Zili";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.zamangb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.araSüresi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersSüresi)).EndInit();
            this.bdbox.ResumeLayout(false);
            this.menü.ResumeLayout(false);
            this.eklemeGroup.ResumeLayout(false);
            this.eklemeGroup.PerformLayout();
            this.saatlerGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox zamangb;
		private System.Windows.Forms.Label süre;
		private System.Windows.Forms.NumericUpDown araSüresi;
		private System.Windows.Forms.NumericUpDown dersSüresi;
		private System.Windows.Forms.Label yazı2;
		private System.Windows.Forms.Label yazı1;
		private System.Windows.Forms.GroupBox bdbox;
		private System.Windows.Forms.Button sıfırla;
		private System.Windows.Forms.Button başla;
		private System.Windows.Forms.Timer zamanlayıcı;
		private System.Windows.Forms.NotifyIcon simge;
		private System.Windows.Forms.ContextMenuStrip menü;
		private System.Windows.Forms.ToolStripMenuItem menü_çıkış;
        private System.Windows.Forms.ToolStripMenuItem menü_göster;
        private System.Windows.Forms.GroupBox eklemeGroup;
        private System.Windows.Forms.GroupBox saatlerGroup;
        private System.Windows.Forms.ListBox saatler;
        private System.Windows.Forms.Button saatekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

