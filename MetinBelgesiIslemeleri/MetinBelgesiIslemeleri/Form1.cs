using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MetinBelgesiIslemeleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StreamWriter sw;
        //Dosya yoluyla dosya adını birleştirmeyi sağladı
        string belgeAdi, belgeYolu;

        private void btnYolSec_Click(object sender, EventArgs e)
        {
            //DialogResult bir yerin seçilip seçilmediğini gösteriyor. Ok ise seçilmiştir
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                belgeYolu = folderBrowserDialog1.SelectedPath.ToString();
                //selectedPath --> seçtiğimiz yol
                tbBelgeYolu.Text = belgeYolu.ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                belgeAdi = tbbelgeAdi.Text;
                //belgeAdının yazılacağı yerdeki tbx'tan ismi aldık
                sw = File.CreateText(belgeYolu + "\\" + belgeAdi + ".txt");
                //dosyayı oluşturduk
                sw.Close();
                //sw'yi kapattık
                MessageBox.Show("Dosya Oluşturuldu!");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata! Dosya Yeri Seçilmedi");
                
            }
        }

        

        

        private void btnListeAktar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {//eğer openFileDialog' dan 
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                String satir = streamReader.ReadLine();
                while (satir != null)
                {
                    LBDialog.Items.Add(satir);
                    satir = streamReader.ReadLine();
                }

            }
        }

        private void btnVerileriKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                saveFileDialog1.Title = "Kayıt Yerini Seç";
                saveFileDialog1.Filter = "Metin Dosyası(*.txt) | *.txt";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.InitialDirectory = "C:\\";
                saveFileDialog1.ShowDialog();
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
                streamWriter.WriteLine(rtbKaydedilecekVeriler.Text);
                streamWriter.Close();
                MessageBox.Show("Kaydedildi");

            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        private void btnRichTextBoxAktar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog();
            ac.Filter = "Metin Dosyası(*.txt) | *.txt";
            ac.Multiselect = false;

            if(ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbAcDosyaAdi.Text = ac.SafeFileName;
                try
                {
                    StreamReader streamReader = new StreamReader(ac.FileName);
                    rTBAktar.Text = streamReader.ReadToEnd();
                    streamReader.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Dosya Okunurken Hata Oluştu");
                }
                
            }       
        }
    }
}
