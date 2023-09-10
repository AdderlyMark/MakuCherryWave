using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maku_CherryWave
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.lang == 0)
            {
                MessageBox.Show("Спасибо Mycu4 за иконку для приложения", "Maku CherryWave", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Properties.Settings.Default.lang == 1)
            {
                MessageBox.Show("Подяка Mycu4 за іконку для програми", "Maku CherryWave", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Properties.Settings.Default.lang == 2)
            {
                MessageBox.Show("Thanks to Mycu4 for the app icon", "Maku CherryWave", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://adderly.fun");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.lang == 0)
            {
                Process.Start("https://youtube.com/@MakuAdarii");
            }
            if (Properties.Settings.Default.lang == 1)
            {
                Process.Start("https://youtube.com/@MakuAdarii");
            }
            if (Properties.Settings.Default.lang == 2)
            {
                Process.Start("https://youtube.com/@MarkAdderlyLive");
            }
            if (Properties.Settings.Default.lang == 3)
            {
                Process.Start("https://youtube.com/@MarkAdderlyLive");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtube.com/@omoshiroim");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/adderly324");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("https://donatello.to/adderly");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("https://new.donatepay.ru/@madderly");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.lang == 0)
            {
                label3.Text = "Простая программа для\nзаписи и сохранения текста.";
                Text = "О программе Maku CherryWave";
                pictureBox2.Left = 15;
                pictureBox3.Left = 84;
                pictureBox4.Left = 153;
                pictureBox5.Left = 222;
                pictureBox6.Left = 291;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                button2.Left = 188;
                pictureBox6.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button1.Text = "Сайт Adderly.Fun";
                button2.Text = "Благодарности";
                label2.Top = 293;
                pictureBox2.Top = 223;
                pictureBox3.Top = 223;
                pictureBox4.Top = 223;
                pictureBox5.Top = 223;
                pictureBox6.Top = 223;
                label2.Text = "Марк Аддерли / 2022 - 2023";
            }
            if (Properties.Settings.Default.lang == 1)
            {
                label3.Text = "Проста програма для\nзапису та збереження тексту.";
                Text = "Про программу Maku CherryWave";
                pictureBox2.Left = 50;
                pictureBox3.Left = 119;
                pictureBox4.Left = 188;
                pictureBox5.Left = 222;
                pictureBox6.Left = 257;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button1.Text = "Сайт Adderly.Fun";
                button2.Text = "Подяки";
                label2.Top = 293;
                button2.Left = 188;
                pictureBox2.Top = 223;
                pictureBox3.Top = 223;
                pictureBox4.Top = 223;
                pictureBox5.Top = 223;
                pictureBox6.Top = 223;
                label2.Text = "Марк Аддерлi / 2022 - 2023";
            }
            if (Properties.Settings.Default.lang == 2)
            {
                label3.Text = "A simple program for\rtyping and saving text.";
                Text = "About Maku CherryWave";
                pictureBox2.Left = 119;
                pictureBox3.Left = 84;
                pictureBox4.Left = 153;
                pictureBox5.Left = 222;
                pictureBox6.Left = 188;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                button1.Visible = false;
                button2.Visible = true;
                button2.Text = "Acknowledgments";
                button2.Left = 153;
                button2.Top = 86;
                label2.Top = 324;
                pictureBox2.Top = 254;
                pictureBox3.Top = 254;
                pictureBox4.Top = 254;
                pictureBox5.Top = 254;
                pictureBox6.Top = 254;
                label2.Text = "Mark Adderly / 2022 - 2023";

            }
            if (Properties.Settings.Default.lang == 3)
            {
                label3.Text = "テキストを入力して保\n存するための単純なプログラム。";
                Text = "プログラムについて Maku CherryWave";
                pictureBox2.Left = 153;
                pictureBox3.Left = 84;
                pictureBox4.Left = 153;
                pictureBox5.Left = 222;
                pictureBox6.Left = 291;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                label2.Top = 324;
                pictureBox2.Top = 254;
                pictureBox3.Top = 254;
                pictureBox4.Top = 254;
                pictureBox5.Top = 254;
                pictureBox6.Top = 254;
                label2.Text = "Maku Adarii / 2022 - 2023";
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.lang == 0)
            {
                label2.Text = "Основной YouTube канал";
            }
            if (Properties.Settings.Default.lang == 1)
            {
                label2.Text = "Основний YouTube канал";
            }
            if (Properties.Settings.Default.lang == 2)
            {
                label2.Text = "AdderlySounds YouTube Channel";
            }
            if (Properties.Settings.Default.lang == 3)
            {
                label2.Text = "AdderlySounds YouTube Channel";
            }
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.lang == 0)
            {
                label2.Text = "Второй YouTube канал";
            }
            if (Properties.Settings.Default.lang == 1)
            {
                label2.Text = "Другий YouTube канал";
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "Telegram канал";
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "Поддержать автора в рублях";
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.lang == 0)
            {
                label2.Text = "Поддержать в гривнах, евро, долларах";
            }
            if (Properties.Settings.Default.lang == 1)
            {
                label2.Text = "Підтримати у гривнях, євро, доларах";
            }
            if (Properties.Settings.Default.lang == 2)
            {
                label2.Text = "Support in dollars, euros, hryvnias";
            }
            if (Properties.Settings.Default.lang == 3)
            {
                label2.Text = "Support in dollars, hryvnias, euros";
            }
        }
    }
}
