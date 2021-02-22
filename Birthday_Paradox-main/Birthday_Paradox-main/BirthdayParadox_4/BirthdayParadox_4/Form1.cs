using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;



namespace BirthdayParadox_4
{
    public partial class Form1 : Form
    {
        //Hangi textBox'ta olduğumuzu bilmek için kullandık.
        private static int kacinciBox = 0;

        private static List<int> kesisimler = new List<int>();


        public Form1()
        {
            InitializeComponent();
         
        }

        /*Bu metot 1 ile 7 arasında rastgele sayılar üretip onları haftanın günleri ile ilişkilendiriyor. Her farklı 
         insan sayısı için gün atamaları yapıldıktan sonra çıkan güne göre o güne ait richTextbox'a "X" harfi ekliyor 
         ve kesişim sayılarını altta bulunan textBox'lara yazdırıyor ve 15 deneyden sonra ise en altta bulunan textBox'a
         deneylerin ortalamasını yazdırıyor.
         */

        public void randomYazdir(int sayi)
        {

            TextBox[] textBoxes = new TextBox[] { textBox1,textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8,
            textBox9,textBox10,textBox11,textBox12,textBox13,textBox14,textBox15,textBox17,textBox18,textBox19,textBox20,
            textBox21,textBox22,textBox23,textBox24,textBox25,textBox26,textBox27,textBox28,textBox29,textBox30,textBox31,
            textBox33,textBox34,textBox35,textBox36,textBox37,textBox38,textBox39,textBox40,textBox41,textBox42,textBox43,textBox44,
            textBox45,textBox46,textBox47,textBox49,textBox50,textBox51,textBox52,textBox53,textBox54,textBox55,textBox56,
            textBox57,textBox58,textBox59,textBox60,textBox61,textBox62,textBox63,textBox65,textBox66,textBox67,textBox68,
            textBox69, textBox70, textBox71, textBox72, textBox73, textBox74, textBox75, textBox76, textBox77, textBox78, textBox79
            };

            RichTextBox[] richTextBoxes = new RichTextBox[] { richTextBox1, richTextBox2, richTextBox3, richTextBox4, richTextBox5,
            richTextBox6,richTextBox7};
            Random random = new Random();

            int[] sayaclar = new int[7];
            
            
            for(int i =0;i<7;++i)
            {
                sayaclar[i] = 0;
            }

            
            

            for (int i = 0; i < sayi; ++i)
            {
                int k = random.Next(1, 7);
                
                if(k==1)
                {
                    richTextBox1.AppendText("X");
                    sayaclar[0] += 1;
                }
                else if(k==2)
                {
                    richTextBox2.AppendText("X");
                    sayaclar[1] += 1;
                }
                else if (k == 3)
                {
                    richTextBox3.AppendText("X");
                    sayaclar[2] += 1;
                }
                else if (k == 4)
                {
                    richTextBox4.AppendText("X");
                    sayaclar[3] += 1;
                }
                else if (k == 5)
                {
                    richTextBox5.AppendText("X");
                    sayaclar[4] += 1;
                }
                else if (k == 6)
                {
                    richTextBox6.AppendText("X");
                    sayaclar[5] += 1;
                }
                else
                {
                    richTextBox7.AppendText("X");
                    sayaclar[6] += 1;
                }
            }
            

            int kesisimsayisi = 0;

            for(int i = 0; i<7;++i)
            {
                if(sayaclar[i]!=0)
                {
                    int kesisim = sayaclar[i] - 1;
                    kesisimsayisi += kesisim;
                }
            }

            kesisimler.Add(kesisimsayisi);

            if (kacinciBox==15)
            {
                int sütunOrt = 0;
                for(int i =0;i<15;++i)
                {
                    sütunOrt +=(int) kesisimler[i];        
                }
                textBox16.Text =((double) (sütunOrt / 15.0)).ToString();
            }

            else if(kacinciBox==29)
            {
                int sütunOrt = 0;
                for (int i = 14; i < 29; ++i)
                {
                    sütunOrt += (int) kesisimler[i];
                }
                textBox32.Text =((double) (sütunOrt / 15.0)).ToString();
            }

            else if (kacinciBox == 44)
            {
                int sütunOrt = 0;
                for (int i = 28; i < 44; ++i)
                {
                    sütunOrt += (int) kesisimler[i];
                }
                textBox48.Text =((double) (sütunOrt /15.0)).ToString();
            }

            else if (kacinciBox == 59)
            {
                int sütunOrt = 0;
                for (int i = 43; i < 59; ++i)
                {
                    sütunOrt += (int) kesisimler[i];
                }
                textBox64.Text = ((double) (sütunOrt / 15.0)).ToString();
            }

            else if (kacinciBox == 74)
            {
                int sütunOrt = 0;
                for (int i = 58; i < 74; ++i)
                {
                    sütunOrt += (int) kesisimler[i];
                }
                textBox80.Text =((double) (sütunOrt /15.0)).ToString();
            }
            else
            {
                //
            }

            

            String matris = "[";
            int sayac = 0;
            foreach (object o in sayaclar)
            {
                matris += o;
                if (sayac!=6)
                {
                    matris += ",";
                }
                else
                {
                    //
                }
                sayac += 1;
            }

            matris += "]";
            textBoxes[kacinciBox].Text =matris+" Kesişim sayisi: " + kesisimsayisi.ToString();
            kacinciBox += 1;
        }

        /*Bu metot her deney sonrası richTextBox'ları temizleyip bir soraki deney için hazırlamaktadır.*/
        
        public void temizle()
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";
            richTextBox5.Text = "";
            richTextBox6.Text = "";
            richTextBox7.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        /*Deneyi başlatıp diğer elemanları görünür hale getiriyor ve kendini görünmez hale getiriyor.*/
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            richTextBox1.Visible = true;
            richTextBox2.Visible = true;
            richTextBox3.Visible = true;
            richTextBox4.Visible = true;
            richTextBox5.Visible = true;
            richTextBox6.Visible = true;
            richTextBox7.Visible = true;
            tableLayoutPanel1.Visible = true;
            tableLayoutPanel2.Visible = true;
            WelcomeLabel.Text = "Olasılık hesaplatmak için 'Devam Et!' butonuna basınız";
            button1.Visible = false;
            button3.Visible = true;



        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

      

        private void textBox97_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox81_TextChanged(object sender, EventArgs e)
        {

        }

        /*Bu butona her tıklandığında deney tekrarlanıyor ve deneyin sonuna kadar tıklamaya devam edilmesi gerekiyor.
         Deney bittiğinde "Hesaplama Tamamlandı mesajını ekrana yazdırıyor."*/
        private void button3_Click(object sender, EventArgs e)
        {
            temizle();

            if (kacinciBox<=14)
            {
                randomYazdir(2);
                

            }
            else if(kacinciBox<=29)
            {
                randomYazdir(3);
                
            }

            else if(kacinciBox<=44)
            {
                randomYazdir(5);
                
            }
            else if(kacinciBox<=59)
            {
                randomYazdir(10);
                
            }
            else if(kacinciBox<=74)
            {
                randomYazdir(20);
                
            }

            else if(textBox80.Text!=null)
            {
                MessageBox.Show("Hesaplama Tamamlandı.");
            }
            else
            {
                //
            }
        }
    }
}
