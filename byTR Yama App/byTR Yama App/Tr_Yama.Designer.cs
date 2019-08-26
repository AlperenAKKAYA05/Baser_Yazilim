namespace byTR_Yama_App
{
	// Token: 0x02000002 RID: 2
	public partial class Tr_Yama : MetroFramework.Forms.MetroForm
    {
		// Token: 0x06000005 RID: 5 RVA: 0x00002330 File Offset: 0x00000530
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002368 File Offset: 0x00000568
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tr_Yama));
            this.label3 = new System.Windows.Forms.Label();
            this.kurulumAsamasi_Deger = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Baslik = new MetroFramework.Controls.MetroLabel();
            this.KurulumuBaslat_button = new MetroFramework.Controls.MetroButton();
            this.version_text = new MetroFramework.Controls.MetroLabel();
            this.yuzde_text = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tryama_version_text = new MetroFramework.Controls.MetroLabel();
            this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.oyun_dizin_textbox = new MetroFramework.Controls.MetroTextBox();
            this.gözat_button = new MetroFramework.Controls.MetroButton();
            this.yama_select_combobox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-45, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(878, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-------------\r\n";
            // 
            // kurulumAsamasi_Deger
            // 
            this.kurulumAsamasi_Deger.AutoSize = true;
            this.kurulumAsamasi_Deger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kurulumAsamasi_Deger.Location = new System.Drawing.Point(274, 270);
            this.kurulumAsamasi_Deger.Name = "kurulumAsamasi_Deger";
            this.kurulumAsamasi_Deger.Size = new System.Drawing.Size(0, 20);
            this.kurulumAsamasi_Deger.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-129, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(878, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-------------\r\n";
            // 
            // Baslik
            // 
            this.Baslik.AutoSize = true;
            this.Baslik.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Baslik.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Baslik.Location = new System.Drawing.Point(7, 8);
            this.Baslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Baslik.Name = "Baslik";
            this.Baslik.Size = new System.Drawing.Size(116, 19);
            this.Baslik.Style = MetroFramework.MetroColorStyle.White;
            this.Baslik.TabIndex = 24;
            this.Baslik.Text = "ByTR Yama APP";
            this.Baslik.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Baslik.UseStyleColors = true;
            // 
            // KurulumuBaslat_button
            // 
            this.KurulumuBaslat_button.Location = new System.Drawing.Point(486, 174);
            this.KurulumuBaslat_button.Margin = new System.Windows.Forms.Padding(2);
            this.KurulumuBaslat_button.Name = "KurulumuBaslat_button";
            this.KurulumuBaslat_button.Size = new System.Drawing.Size(127, 39);
            this.KurulumuBaslat_button.Style = MetroFramework.MetroColorStyle.White;
            this.KurulumuBaslat_button.TabIndex = 25;
            this.KurulumuBaslat_button.Text = "Kurulumu Başlat";
            this.KurulumuBaslat_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.KurulumuBaslat_button.UseSelectable = true;
            this.KurulumuBaslat_button.UseStyleColors = true;
            this.KurulumuBaslat_button.Click += new System.EventHandler(this.KurulumuBaslat_button_Click_1);
            // 
            // version_text
            // 
            this.version_text.AutoSize = true;
            this.version_text.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.version_text.Location = new System.Drawing.Point(7, 194);
            this.version_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.version_text.Name = "version_text";
            this.version_text.Size = new System.Drawing.Size(61, 19);
            this.version_text.Style = MetroFramework.MetroColorStyle.White;
            this.version_text.TabIndex = 26;
            this.version_text.Text = "v0.0.0.0";
            this.version_text.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.version_text.UseStyleColors = true;
            // 
            // yuzde_text
            // 
            this.yuzde_text.AutoSize = true;
            this.yuzde_text.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.yuzde_text.Location = new System.Drawing.Point(7, 172);
            this.yuzde_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yuzde_text.Name = "yuzde_text";
            this.yuzde_text.Size = new System.Drawing.Size(45, 19);
            this.yuzde_text.Style = MetroFramework.MetroColorStyle.White;
            this.yuzde_text.TabIndex = 27;
            this.yuzde_text.Text = "%100";
            this.yuzde_text.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.yuzde_text.UseStyleColors = true;
            this.yuzde_text.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(7, 124);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(157, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Türkçe Yama Sürümü :";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // tryama_version_text
            // 
            this.tryama_version_text.AutoSize = true;
            this.tryama_version_text.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.tryama_version_text.Location = new System.Drawing.Point(159, 124);
            this.tryama_version_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tryama_version_text.Name = "tryama_version_text";
            this.tryama_version_text.Size = new System.Drawing.Size(37, 19);
            this.tryama_version_text.Style = MetroFramework.MetroColorStyle.White;
            this.tryama_version_text.TabIndex = 29;
            this.tryama_version_text.Text = "v1.7";
            this.tryama_version_text.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tryama_version_text.UseStyleColors = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 146);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(606, 23);
            this.progressBar1.TabIndex = 30;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(7, 86);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = "Oyun Klasörü:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // oyun_dizin_textbox
            // 
            // 
            // 
            // 
            this.oyun_dizin_textbox.CustomButton.Image = null;
            this.oyun_dizin_textbox.CustomButton.Location = new System.Drawing.Point(429, 1);
            this.oyun_dizin_textbox.CustomButton.Name = "";
            this.oyun_dizin_textbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.oyun_dizin_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.oyun_dizin_textbox.CustomButton.TabIndex = 1;
            this.oyun_dizin_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.oyun_dizin_textbox.CustomButton.UseSelectable = true;
            this.oyun_dizin_textbox.CustomButton.Visible = false;
            this.oyun_dizin_textbox.Lines = new string[0];
            this.oyun_dizin_textbox.Location = new System.Drawing.Point(114, 84);
            this.oyun_dizin_textbox.MaxLength = 32767;
            this.oyun_dizin_textbox.Name = "oyun_dizin_textbox";
            this.oyun_dizin_textbox.PasswordChar = '\0';
            this.oyun_dizin_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.oyun_dizin_textbox.SelectedText = "";
            this.oyun_dizin_textbox.SelectionLength = 0;
            this.oyun_dizin_textbox.SelectionStart = 0;
            this.oyun_dizin_textbox.ShortcutsEnabled = true;
            this.oyun_dizin_textbox.Size = new System.Drawing.Size(451, 23);
            this.oyun_dizin_textbox.TabIndex = 32;
            this.oyun_dizin_textbox.UseSelectable = true;
            this.oyun_dizin_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.oyun_dizin_textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gözat_button
            // 
            this.gözat_button.Location = new System.Drawing.Point(570, 84);
            this.gözat_button.Margin = new System.Windows.Forms.Padding(2);
            this.gözat_button.Name = "gözat_button";
            this.gözat_button.Size = new System.Drawing.Size(43, 23);
            this.gözat_button.Style = MetroFramework.MetroColorStyle.White;
            this.gözat_button.TabIndex = 33;
            this.gözat_button.Text = "...";
            this.gözat_button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gözat_button.UseSelectable = true;
            this.gözat_button.UseStyleColors = true;
            this.gözat_button.Click += new System.EventHandler(this.Gözat_button_Click_1);
            // 
            // yama_select_combobox
            // 
            this.yama_select_combobox.BackColor = System.Drawing.Color.Black;
            this.yama_select_combobox.FormattingEnabled = true;
            this.yama_select_combobox.ItemHeight = 23;
            this.yama_select_combobox.Items.AddRange(new object[] {
            "Tropico 6 Türkçe Yama"});
            this.yama_select_combobox.Location = new System.Drawing.Point(271, 38);
            this.yama_select_combobox.Name = "yama_select_combobox";
            this.yama_select_combobox.Size = new System.Drawing.Size(342, 29);
            this.yama_select_combobox.Style = MetroFramework.MetroColorStyle.Green;
            this.yama_select_combobox.TabIndex = 34;
            this.yama_select_combobox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.yama_select_combobox.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(7, 43);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(252, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel3.TabIndex = 35;
            this.metroLabel3.Text = "Türkçeye Çevirmek İstediğiniz Oyun:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "----------------------";
            // 
            // Tr_Yama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 216);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.yama_select_combobox);
            this.Controls.Add(this.gözat_button);
            this.Controls.Add(this.oyun_dizin_textbox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tryama_version_text);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.yuzde_text);
            this.Controls.Add(this.version_text);
            this.Controls.Add(this.KurulumuBaslat_button);
            this.Controls.Add(this.Baslik);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kurulumAsamasi_Deger);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(630, 216);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(630, 216);
            this.Name = "Tr_Yama";
            this.Opacity = 0.9D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "byTR Yama App";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label kurulumAsamasi_Deger;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label label6;
        internal MetroFramework.Controls.MetroLabel Baslik;
        internal MetroFramework.Controls.MetroButton KurulumuBaslat_button;
        internal MetroFramework.Controls.MetroLabel version_text;
        internal MetroFramework.Controls.MetroLabel yuzde_text;
        internal MetroFramework.Controls.MetroLabel metroLabel1;
        internal MetroFramework.Controls.MetroLabel tryama_version_text;
        private MetroFramework.Controls.MetroProgressBar progressBar1;
        internal MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox oyun_dizin_textbox;
        internal MetroFramework.Controls.MetroButton gözat_button;
        private MetroFramework.Controls.MetroComboBox yama_select_combobox;
        internal MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
