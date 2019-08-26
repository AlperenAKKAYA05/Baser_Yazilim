using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace byTR_Yama_App
{
	// Token: 0x02000002 RID: 2
	public partial class Tr_Yama : MetroForm
    {
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Tr_Yama()
        {
            this.InitializeComponent();
		}
		// Token: 0x06000002 RID: 2 RVA: 0x00002064 File Offset: 0x00000264
		private void KurulumuBaslat_button_Click(object sender, EventArgs e)
		{
			bool flag = this.yama_select_combobox.Text == "Tropico 6 Türkçe Yama";
			if (flag)
			{
				this.kurulumAsamasi_Deger.Text = "Seçilen Yama Tropico 6";
				bool flag2 = this.oyun_dizin_textbox.Text == "";
				if (flag2)
				{
					MessageBox.Show("Lütfen Oyunun Yolunu Seçiniz...");
				}
				else
				{
					this.yuzde_text.Visible = true;
					bool flag3 = File.Exists(this.oyun_dizin_textbox.Text + "\\Tropico6\\Content\\Paks\\pakchunkEN_TXT-WindowsNoEditor.pak");
					if (flag3)
					{
						this.kurulumAsamasi_Deger.Text = "Orijinal Dil Siliniyor...";
						this.progressBar1.Value = 20;
						this.yuzde_text.Text = "%" + 20;
						File.Delete(this.oyun_dizin_textbox.Text + "\\Tropico6\\Content\\Paks\\pakchunkEN_TXT-WindowsNoEditor.pak");
					}
					else
					{
						this.kurulumAsamasi_Deger.Text = "Orijinal Dil Bulunamadı.Silme Aşaması Atlanıyor...";
						this.progressBar1.Value = 40;
						this.yuzde_text.Text = "%" + 40;
						Directory.CreateDirectory(this.oyun_dizin_textbox.Text + "\\Tropico6\\Content\\Localization\\Game\\en\\");
						bool flag4 = File.Exists(this.oyun_dizin_textbox.Text + "\\Tropico6\\Content\\Localization\\Game\\en\\Game.locres");
						if (flag4)
						{
							this.kurulumAsamasi_Deger.Text = "Eski Sürüm Türkçe Yama Siliniyor...";
							this.progressBar1.Value = 60;
							this.yuzde_text.Text = "%" + 60;
							File.Delete(this.oyun_dizin_textbox.Text + "\\Tropico6\\Content\\Localization\\Game\\en\\Game.locres");
						}
						this.kurulumAsamasi_Deger.Text = "Yeni Sürüm Türkçe Yama Kopyalanıyor...";
						this.progressBar1.Value = 80;
						this.yuzde_text.Text = "%" + 80;
						File.Copy(Application.StartupPath + "\\Game.locres", this.oyun_dizin_textbox.Text + "\\Tropico6\\Content\\Localization\\Game\\en\\Game.locres");
						this.kurulumAsamasi_Deger.Text = "Türkçe Yama Kuruldu.İyi Oyunlar";
						this.progressBar1.Value = 100;
						this.yuzde_text.Text = "%" + 100;
						MessageBox.Show("İşlem Bitti :D");
					}
				}
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000022D0 File Offset: 0x000004D0
		private void gözat_button_Click(object sender, EventArgs e)
		{
			this.folderBrowserDialog1.ShowDialog();
			string selectedPath = this.folderBrowserDialog1.SelectedPath;
			this.folderBrowserDialog1.ShowNewFolderButton = false;
			this.oyun_dizin_textbox.Text = selectedPath;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002310 File Offset: 0x00000510
		private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "";
            this.version_text.Text = "v" + Application.ProductVersion;

        }

        private void KurulumuBaslat_button_Click_1(object sender, EventArgs e)
        {
            bool flag = this.yama_select_combobox.Text == "Tropico 6 Türkçe Yama";
            if (flag)
            {
                this.kurulumAsamasi_Deger.Text = "Seçilen Yama Tropico 6";
                bool flag2 = this.oyun_dizin_textbox.Text == "";
                if (flag2)
                {
                    MessageBox.Show("Lütfen Oyunun Yolunu Seçiniz...");
                }
                else
                {
                    this.yuzde_text.Visible = true;
                    bool flag3 = File.Exists(this.oyun_dizin_textbox.Text + "\\Tropico6\\Content\\Paks\\pakchunkEN_TXT-WindowsNoEditor.pak");
                    if (flag3)
                    {
                        this.kurulumAsamasi_Deger.Text = "Orijinal Dil Siliniyor...";
                        this.progressBar1.Value = 20;
                        this.yuzde_text.Text = "%" + 20;
                        File.Delete(this.oyun_dizin_textbox.Text + "\\Tropico6\\Content\\Paks\\pakchunkEN_TXT-WindowsNoEditor.pak");
                    }
                    else
                    {
                        this.kurulumAsamasi_Deger.Text = "Orijinal Dil Bulunamadı.Silme Aşaması Atlanıyor...";
                        this.progressBar1.Value = 40;
                        this.yuzde_text.Text = "%" + 40;
                        Directory.CreateDirectory(this.oyun_dizin_textbox.Text + "\\Tropico6\\Content\\Localization\\Game\\en\\");
                        bool flag4 = File.Exists(this.oyun_dizin_textbox.Text + "\\Tropico6\\Content\\Localization\\Game\\en\\Game.locres");
                        if (flag4)
                        {
                            this.kurulumAsamasi_Deger.Text = "Eski Sürüm Türkçe Yama Siliniyor...";
                            this.progressBar1.Value = 60;
                            this.yuzde_text.Text = "%" + 60;
                            File.Delete(this.oyun_dizin_textbox.Text + "\\Tropico6\\Content\\Localization\\Game\\en\\Game.locres");
                        }
                        this.kurulumAsamasi_Deger.Text = "Yeni Sürüm Türkçe Yama Kopyalanıyor...";
                        this.progressBar1.Value = 80;
                        this.yuzde_text.Text = "%" + 80;
                        File.Copy(Application.StartupPath + "\\Game.locres", this.oyun_dizin_textbox.Text + "\\Tropico6\\Content\\Localization\\Game\\en\\Game.locres");
                        this.kurulumAsamasi_Deger.Text = "Türkçe Yama Kuruldu.İyi Oyunlar";
                        this.progressBar1.Value = 100;
                        this.yuzde_text.Text = "%" + 100;
                        MessageBox.Show("İşlem Bitti :D");
                    }
                }
            }
    }

        private void Gözat_button_Click_1(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            string selectedPath = this.folderBrowserDialog1.SelectedPath;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            this.oyun_dizin_textbox.Text = selectedPath;
        }
    }
}
