using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maku_CherryWave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tc1 = 0;
        int tc2 = 0;
        int tc3 = 0;
        int tc4 = 0;
        int tc5 = 0;
        int tc6 = 0;
        int tc7 = 0;
        int tc8 = 0;
        int tc9 = 0;
        int tc10 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            //region checking for first startup language
            if (Properties.Settings.Default.customlang == false)
            {
                CultureInfo currentCulture = CultureInfo.CurrentCulture;

                if (currentCulture.Name.StartsWith("en"))
                {
                    Properties.Settings.Default.lang = 2;
                    Properties.Settings.Default.Save();
                }
                else if (currentCulture.Name.StartsWith("ru"))
                {
                    Properties.Settings.Default.lang = 0;
                    Properties.Settings.Default.Save();
                }
                else if (currentCulture.Name.StartsWith("uz"))
                {
                    Properties.Settings.Default.lang = 0;
                    Properties.Settings.Default.Save();
                }
                else if (currentCulture.Name.StartsWith("kk"))
                {
                    Properties.Settings.Default.lang = 0;
                    Properties.Settings.Default.Save();
                }
                else if (currentCulture.Name.StartsWith("be"))
                {
                    Properties.Settings.Default.lang = 0;
                    Properties.Settings.Default.Save();
                }
                else if (currentCulture.Name.StartsWith("lv"))
                {
                    Properties.Settings.Default.lang = 0;
                    Properties.Settings.Default.Save();
                }
                else if (currentCulture.Name.StartsWith("uk"))
                {
                    Properties.Settings.Default.lang = 1;
                    Properties.Settings.Default.Save();
                }
                else if (currentCulture.Name.StartsWith("ja"))
                {
                    Properties.Settings.Default.lang = 3;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.lang = 2;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {

            }
            lang.SelectedIndex = Properties.Settings.Default.lang;
            z1.BackColor = Properties.Settings.Default.cz1;
            z2.BackColor = Properties.Settings.Default.cz2;
            z3.BackColor = Properties.Settings.Default.cz3;
            z4.BackColor = Properties.Settings.Default.cz4;
            z5.BackColor = Properties.Settings.Default.cz5;
            z6.BackColor = Properties.Settings.Default.cz6;
            z7.BackColor = Properties.Settings.Default.cz7;
            z8.BackColor = Properties.Settings.Default.cz8;
            z9.BackColor = Properties.Settings.Default.cz9;
            z10.BackColor = Properties.Settings.Default.cz10;

            t1.BackColor = Properties.Settings.Default.ct1;
            t2.BackColor = Properties.Settings.Default.ct2;
            t3.BackColor = Properties.Settings.Default.ct3;
            t4.BackColor = Properties.Settings.Default.ct4;
            t5.BackColor = Properties.Settings.Default.ct5;
            t6.BackColor = Properties.Settings.Default.ct6;
            t7.BackColor = Properties.Settings.Default.ct7;
            t8.BackColor = Properties.Settings.Default.ct8;
            t9.BackColor = Properties.Settings.Default.ct9;
            t10.BackColor = Properties.Settings.Default.ct10;

            z1.Text = Properties.Settings.Default.z1;
            z2.Text = Properties.Settings.Default.z2;
            z3.Text = Properties.Settings.Default.z3;
            z4.Text = Properties.Settings.Default.z4;
            z5.Text = Properties.Settings.Default.z5;
            z6.Text = Properties.Settings.Default.z6;
            z7.Text = Properties.Settings.Default.z7;
            z8.Text = Properties.Settings.Default.z8;
            z9.Text = Properties.Settings.Default.z9;
            z10.Text = Properties.Settings.Default.z10;

            t1.Text = Properties.Settings.Default.t1;
            t2.Text = Properties.Settings.Default.t2;
            t3.Text = Properties.Settings.Default.t3;
            t4.Text = Properties.Settings.Default.t4;
            t5.Text = Properties.Settings.Default.t5;
            t6.Text = Properties.Settings.Default.t6;
            t7.Text = Properties.Settings.Default.t7;
            t8.Text = Properties.Settings.Default.t8;
            t9.Text = Properties.Settings.Default.t9;
            t10.Text = Properties.Settings.Default.t10;
            единыйРежимToolStripMenuItem.Checked = Properties.Settings.Default.edi;
            if (единыйРежимToolStripMenuItem.Checked == true)
            {
                label1.Visible = false;
                label4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                z1.Visible = false;
                z2.Visible = false;
                z3.Visible = false;
                z4.Visible = false;
                z5.Visible = false;
                z6.Visible = false;
                z7.Visible = false;
                z8.Visible = false;
                z9.Visible = false;
                z10.Visible = false;
                t2.Visible = false;
                t3.Visible = false;
                t4.Visible = false;
                t5.Visible = false;
                t6.Visible = false;
                t7.Visible = false;
                t8.Visible = false;
                t9.Visible = false;
                t10.Visible = false;

                t1.Dock = DockStyle.Fill;
            }
            if (единыйРежимToolStripMenuItem.Checked == false)
            {
                label1.Visible = true;
                label4.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                z1.Visible = true;
                z2.Visible = true;
                z3.Visible = true;
                z4.Visible = true;
                z5.Visible = true;
                z6.Visible = true;
                z7.Visible = true;
                z8.Visible = true;
                z9.Visible = true;
                z10.Visible = true;
                t2.Visible = true;
                t3.Visible = true;
                t4.Visible = true;
                t5.Visible = true;
                t6.Visible = true;
                t7.Visible = true;
                t8.Visible = true;
                t9.Visible = true;
                t10.Visible = true;

                t1.Dock = DockStyle.None;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.z1 = z1.Text;
            Properties.Settings.Default.z2 = z2.Text;
            Properties.Settings.Default.z3 = z3.Text;
            Properties.Settings.Default.z4 = z4.Text;
            Properties.Settings.Default.z5 = z5.Text;
            Properties.Settings.Default.z6 = z6.Text;
            Properties.Settings.Default.z7 = z7.Text;
            Properties.Settings.Default.z8 = z8.Text;
            Properties.Settings.Default.z9 = z9.Text;
            Properties.Settings.Default.z10 = z10.Text;

            Properties.Settings.Default.t1 = t1.Text;
            Properties.Settings.Default.t2 = t2.Text;
            Properties.Settings.Default.t3 = t3.Text;
            Properties.Settings.Default.t4 = t4.Text;
            Properties.Settings.Default.t5 = t5.Text;
            Properties.Settings.Default.t6 = t6.Text;
            Properties.Settings.Default.t7 = t7.Text;
            Properties.Settings.Default.t8 = t8.Text;
            Properties.Settings.Default.t9 = t9.Text;
            Properties.Settings.Default.t10 = t10.Text;
            Properties.Settings.Default.edi = единыйРежимToolStripMenuItem.Checked;

            Properties.Settings.Default.Save();
        }

        private void lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lang.SelectedIndex == 0)
            {
                label1.Text = "Запись 1";
                label2.Text = "Запись 2";
                label3.Text = "Запись 4";
                label4.Text = "Запись 3";
                label5.Text = "Запись 7";
                label6.Text = "Запись 6";
                label7.Text = "Запись 5";
                label8.Text = "Запись 10";
                label9.Text = "Запись 9";
                label10.Text = "Запись 8";
                заголовкиToolStripMenuItem.Text = "Заголовки";
                записиToolStripMenuItem.Text = "Записи";
                языкToolStripMenuItem.Text = "Язык";
                оПрограммеToolStripMenuItem.Text = "О программе";
                цветЗаголовка1ToolStripMenuItem.Text = "Цвет заголовка 1";
                цветЗаголовка2ToolStripMenuItem.Text = "Цвет заголовка 2";
                цветЗаголовка3ToolStripMenuItem.Text = "Цвет заголовка 3";
                цветЗаголовка4ToolStripMenuItem.Text = "Цвет заголовка 4";
                цветЗаголовка5ToolStripMenuItem.Text = "Цвет заголовка 5";
                цветЗаголовка6ToolStripMenuItem.Text = "Цвет заголовка 6";
                цветЗаголовка7ToolStripMenuItem.Text = "Цвет заголовка 7";
                цветЗаголовка8ToolStripMenuItem.Text = "Цвет заголовка 8";
                цветЗаголовка9ToolStripMenuItem.Text = "Цвет заголовка 9";
                цветЗаголовка10ToolStripMenuItem.Text = "Цвет заголовка 10";

                цветЗаписей1ToolStripMenuItem.Text = "Цвет записей 1";
                цветЗаписей2ToolStripMenuItem.Text = "Цвет записей 2";
                цветЗаписей3ToolStripMenuItem.Text = "Цвет записей 3";
                цветЗаписей4ToolStripMenuItem.Text = "Цвет записей 4";
                цветЗаписей5ToolStripMenuItem.Text = "Цвет записей 5";
                цветЗаписей6ToolStripMenuItem.Text = "Цвет записей 6";
                цветЗаписей7ToolStripMenuItem.Text = "Цвет записей 7";
                цветЗаписей8ToolStripMenuItem.Text = "Цвет записей 8";
                цветЗаписей9ToolStripMenuItem.Text = "Цвет записей 9";
                цветЗаписей10ToolStripMenuItem.Text = "Цвет записей 10";

                сбросToolStripMenuItem.Text = "Сброс";
                сброситьПервыеПятьЗаголовковToolStripMenuItem.Text = "Сбросить первые пять заголовков";
                сброситьПоследниеПятьЗаголовковToolStripMenuItem.Text = "Сбросить последние пять заголовков";
                сброситьПервыеПятьЗаписейToolStripMenuItem.Text = "Сбросить первые пять записей";
                сброситьПоследниеПятьЗаписейToolStripMenuItem.Text = "Сбросить последние пять записей";

                видToolStripMenuItem.Text = "Вид";
                поверхВсехОконToolStripMenuItem.Text = "Поверх всех окон";
                единыйРежимToolStripMenuItem.Text = "Единый режим";
            }
            if (lang.SelectedIndex == 1)
            {
                label1.Text = "Запис 1";
                label2.Text = "Запис 2";
                label3.Text = "Запис 4";
                label4.Text = "Запис 3";
                label5.Text = "Запис 7";
                label6.Text = "Запис 6";
                label7.Text = "Запис 5";
                label8.Text = "Запис 10";
                label9.Text = "Запис 9";
                label10.Text = "Запис 8";
                заголовкиToolStripMenuItem.Text = "Заголовки";
                записиToolStripMenuItem.Text = "Записи";
                языкToolStripMenuItem.Text = "Мова";
                оПрограммеToolStripMenuItem.Text = "Про програму";
                цветЗаголовка1ToolStripMenuItem.Text = "Колiр заголовка 1";
                цветЗаголовка2ToolStripMenuItem.Text = "Колiр заголовка 2";
                цветЗаголовка3ToolStripMenuItem.Text = "Колiр заголовка 3";
                цветЗаголовка4ToolStripMenuItem.Text = "Колiр заголовка 4";
                цветЗаголовка5ToolStripMenuItem.Text = "Колiр заголовка 5";
                цветЗаголовка6ToolStripMenuItem.Text = "Колiр заголовка 6";
                цветЗаголовка7ToolStripMenuItem.Text = "Колiр заголовка 7";
                цветЗаголовка8ToolStripMenuItem.Text = "Колiр заголовка 8";
                цветЗаголовка9ToolStripMenuItem.Text = "Колiр заголовка 9";
                цветЗаголовка10ToolStripMenuItem.Text = "Колiр заголовка 10";

                цветЗаписей1ToolStripMenuItem.Text = "Колiр записiв 1";
                цветЗаписей2ToolStripMenuItem.Text = "Колiр записiв 2";
                цветЗаписей3ToolStripMenuItem.Text = "Колiр записiв 3";
                цветЗаписей4ToolStripMenuItem.Text = "Колiр записiв 4";
                цветЗаписей5ToolStripMenuItem.Text = "Колiр записiв 5";
                цветЗаписей6ToolStripMenuItem.Text = "Колiр записiв 6";
                цветЗаписей7ToolStripMenuItem.Text = "Колiр записiв 7";
                цветЗаписей8ToolStripMenuItem.Text = "Колiр записiв 8";
                цветЗаписей9ToolStripMenuItem.Text = "Колiр записiв 9";
                цветЗаписей10ToolStripMenuItem.Text = "Колiр записiв 10";

                сбросToolStripMenuItem.Text = "Скидання";
                сброситьПервыеПятьЗаголовковToolStripMenuItem.Text = "Скинути перші п'ять заголовків";
                сброситьПоследниеПятьЗаголовковToolStripMenuItem.Text = "Скинути останні п'ять заголовків";
                сброситьПервыеПятьЗаписейToolStripMenuItem.Text = "Скинути перші п'ять записів";
                сброситьПоследниеПятьЗаписейToolStripMenuItem.Text = "Скинути останні п'ять записів";

                видToolStripMenuItem.Text = "Вигляд";
                поверхВсехОконToolStripMenuItem.Text = "Поверх всіх вікон";
                единыйРежимToolStripMenuItem.Text = "Єдиний режим";
            }
            if (lang.SelectedIndex == 2)
            {
                label1.Text = "Note 1";
                label2.Text = "Note 2";
                label3.Text = "Note 4";
                label4.Text = "Note 3";
                label5.Text = "Note 7";
                label6.Text = "Note 6";
                label7.Text = "Note 5";
                label8.Text = "Note 10";
                label9.Text = "Note 9";
                label10.Text = "Note 8";

                заголовкиToolStripMenuItem.Text = "Headers";
                записиToolStripMenuItem.Text = "Notes";
                языкToolStripMenuItem.Text = "Language";
                оПрограммеToolStripMenuItem.Text = "About";
                цветЗаголовка1ToolStripMenuItem.Text = "Header Color 1";
                цветЗаголовка2ToolStripMenuItem.Text = "Header Color 2";
                цветЗаголовка3ToolStripMenuItem.Text = "Header Color 3";
                цветЗаголовка4ToolStripMenuItem.Text = "Header Color 4";
                цветЗаголовка5ToolStripMenuItem.Text = "Header Color 5";
                цветЗаголовка6ToolStripMenuItem.Text = "Header Color 6";
                цветЗаголовка7ToolStripMenuItem.Text = "Header Color 7";
                цветЗаголовка8ToolStripMenuItem.Text = "Header Color 8";
                цветЗаголовка9ToolStripMenuItem.Text = "Header Color 9";
                цветЗаголовка10ToolStripMenuItem.Text = "Header Color 10";

                цветЗаписей1ToolStripMenuItem.Text = "Note Color 1";
                цветЗаписей2ToolStripMenuItem.Text = "Note Color 2";
                цветЗаписей3ToolStripMenuItem.Text = "Note Color 3";
                цветЗаписей4ToolStripMenuItem.Text = "Note Color 4";
                цветЗаписей5ToolStripMenuItem.Text = "Note Color 5";
                цветЗаписей6ToolStripMenuItem.Text = "Note Color 6";
                цветЗаписей7ToolStripMenuItem.Text = "Note Color 7";
                цветЗаписей8ToolStripMenuItem.Text = "Note Color 8";
                цветЗаписей9ToolStripMenuItem.Text = "Note Color 9";
                цветЗаписей10ToolStripMenuItem.Text = "Note Color 10";

                сбросToolStripMenuItem.Text = "Reset";
                сброситьПервыеПятьЗаголовковToolStripMenuItem.Text = "Reset First Five Headers";
                сброситьПоследниеПятьЗаголовковToolStripMenuItem.Text = "Reset Last Five Headers";
                сброситьПервыеПятьЗаписейToolStripMenuItem.Text = "Reset First Five Notes";
                сброситьПоследниеПятьЗаписейToolStripMenuItem.Text = "Reset Last Five Notes";

                видToolStripMenuItem.Text = "View";
                поверхВсехОконToolStripMenuItem.Text = "On Top of All Windows";
                единыйРежимToolStripMenuItem.Text = "Single Mode";
            }
            if (lang.SelectedIndex == 3)
            {
                label1.Text = "メモ 1";
                label2.Text = "メモ 2";
                label3.Text = "メモ 4";
                label4.Text = "メモ 3";
                label5.Text = "メモ 7";
                label6.Text = "メモ 6";
                label7.Text = "メモ 5";
                label8.Text = "メモ 10";
                label9.Text = "メモ 9";
                label10.Text = "メモ 8";

                заголовкиToolStripMenuItem.Text = "ヘッダー";
                записиToolStripMenuItem.Text = "メモ";
                языкToolStripMenuItem.Text = "言語";
                оПрограммеToolStripMenuItem.Text = "概要";
                цветЗаголовка1ToolStripMenuItem.Text = "ヘッダーの色 1";
                цветЗаголовка2ToolStripMenuItem.Text = "ヘッダーの色 2";
                цветЗаголовка3ToolStripMenuItem.Text = "ヘッダーの色 3";
                цветЗаголовка4ToolStripMenuItem.Text = "ヘッダーの色 4";
                цветЗаголовка5ToolStripMenuItem.Text = "ヘッダーの色 5";
                цветЗаголовка6ToolStripMenuItem.Text = "ヘッダーの色 6";
                цветЗаголовка7ToolStripMenuItem.Text = "ヘッダーの色 7";
                цветЗаголовка8ToolStripMenuItem.Text = "ヘッダーの色 8";
                цветЗаголовка9ToolStripMenuItem.Text = "ヘッダーの色 9";
                цветЗаголовка10ToolStripMenuItem.Text = "ヘッダーの色 10";

                цветЗаписей1ToolStripMenuItem.Text = "音符の色 1";
                цветЗаписей2ToolStripMenuItem.Text = "音符の色 2";
                цветЗаписей3ToolStripMenuItem.Text = "音符の色 3";
                цветЗаписей4ToolStripMenuItem.Text = "音符の色 4";
                цветЗаписей5ToolStripMenuItem.Text = "音符の色 5";
                цветЗаписей6ToolStripMenuItem.Text = "音符の色 6";
                цветЗаписей7ToolStripMenuItem.Text = "音符の色 7";
                цветЗаписей8ToolStripMenuItem.Text = "音符の色 8";
                цветЗаписей9ToolStripMenuItem.Text = "音符の色 9";
                цветЗаписей10ToolStripMenuItem.Text = "音符の色 10";

                сбросToolStripMenuItem.Text = "リセット";
                сброситьПервыеПятьЗаголовковToolStripMenuItem.Text = "最初の 5 つのヘッダーをリセット";
                сброситьПоследниеПятьЗаголовковToolStripMenuItem.Text = "最後の 5 つのヘッダーをリセット";
                сброситьПервыеПятьЗаписейToolStripMenuItem.Text = "最初の 5 つの音符をリセット";
                сброситьПоследниеПятьЗаписейToolStripMenuItem.Text = "最後の 5 つのノートをリセット";

                видToolStripMenuItem.Text = "表示";
                поверхВсехОконToolStripMenuItem.Text = "すべての窓の上に";
                единыйРежимToolStripMenuItem.Text = "シングルモード";
            }
            Properties.Settings.Default.lang = lang.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void русскийRUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.customlang = true;
            Properties.Settings.Default.lang = 0;
            Properties.Settings.Default.Save();
            lang.SelectedIndex = 0;
        }

        private void українськаUAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.customlang = true;
            Properties.Settings.Default.lang = 1;
            Properties.Settings.Default.Save();
            lang.SelectedIndex = 1;
        }

        private void englishENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.customlang = true;
            Properties.Settings.Default.lang = 2;
            Properties.Settings.Default.Save();
            lang.SelectedIndex = 2;
        }

        private void 日本語JPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.customlang = true;
            Properties.Settings.Default.lang = 3;
            Properties.Settings.Default.Save();
            lang.SelectedIndex = 3;
        }

        private void цветЗаголовка1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                z1.BackColor = cb.Color;
                Properties.Settings.Default.cz1 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаголовка2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                z2.BackColor = cb.Color;
                Properties.Settings.Default.cz2 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаголовка3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                z3.BackColor = cb.Color;
                Properties.Settings.Default.cz3 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаголовка4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                z4.BackColor = cb.Color;
                Properties.Settings.Default.cz4 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаголовка5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                z5.BackColor = cb.Color;
                Properties.Settings.Default.cz5 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаголовка6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                z6.BackColor = cb.Color;
                Properties.Settings.Default.cz6 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаголовка7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                z7.BackColor = cb.Color;
                Properties.Settings.Default.cz7 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаголовка8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                z8.BackColor = cb.Color;
                Properties.Settings.Default.cz8 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаголовка9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                z9.BackColor = cb.Color;
                Properties.Settings.Default.cz9 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаголовка10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                z10.BackColor = cb.Color;
                Properties.Settings.Default.cz10 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаписей1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                t1.BackColor = cb.Color;
                Properties.Settings.Default.ct1 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаписей2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                t2.BackColor = cb.Color;
                Properties.Settings.Default.ct2 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаписей3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                t3.BackColor = cb.Color;
                Properties.Settings.Default.ct3 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаписей4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                t4.BackColor = cb.Color;
                Properties.Settings.Default.ct4 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаписей5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                t5.BackColor = cb.Color;
                Properties.Settings.Default.ct5 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаписей6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                t6.BackColor = cb.Color;
                Properties.Settings.Default.ct6 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаписей7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                t7.BackColor = cb.Color;
                Properties.Settings.Default.ct7 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаписей8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                t8.BackColor = cb.Color;
                Properties.Settings.Default.ct8 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаписей9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                t9.BackColor = cb.Color;
                Properties.Settings.Default.ct9 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void цветЗаписей10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cb = new ColorDialog();
            cb.AllowFullOpen = true;
            cb.FullOpen = true;
            cb.AnyColor = true;
            if (cb.ShowDialog() == DialogResult.OK)
            {
                t10.BackColor = cb.Color;
                Properties.Settings.Default.ct10 = cb.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сброситьЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сброситьПервыеПятьЗаписейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lang.SelectedIndex == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите сбросить весь текст и цвета в 1, 2, 3, 4, 5 записях?\nЭто действие нельзя отменить, и текст нельзя восстановить.","Maku CherryWave",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    t1.BackColor = Color.FromArgb(25, 25, 25);
                    t2.BackColor = Color.FromArgb(25, 25, 25);
                    t3.BackColor = Color.FromArgb(25, 25, 25);
                    t4.BackColor = Color.FromArgb(25, 25, 25);
                    t5.BackColor = Color.FromArgb(25, 25, 25);
                    t1.Text = "";
                    t2.Text = "";
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";
                    Properties.Settings.Default.ct1 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct2 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct3 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct4 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct5 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.t1 = "";
                    Properties.Settings.Default.t2 = "";
                    Properties.Settings.Default.t3 = "";
                    Properties.Settings.Default.t4 = "";
                    Properties.Settings.Default.t5 = "";
                    Properties.Settings.Default.Save();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            if (lang.SelectedIndex == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Ви дійсно хочете скинути весь текст і кольори в 1, 2, 3, 4, 5 записах?\nЦю дію не можна скасувати, а текст не можна відновити.", "Maku CherryWave", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    t1.BackColor = Color.FromArgb(25, 25, 25);
                    t2.BackColor = Color.FromArgb(25, 25, 25);
                    t3.BackColor = Color.FromArgb(25, 25, 25);
                    t4.BackColor = Color.FromArgb(25, 25, 25);
                    t5.BackColor = Color.FromArgb(25, 25, 25);
                    t1.Text = "";
                    t2.Text = "";
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";
                    Properties.Settings.Default.ct1 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct2 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct3 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct4 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct5 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.t1 = "";
                    Properties.Settings.Default.t2 = "";
                    Properties.Settings.Default.t3 = "";
                    Properties.Settings.Default.t4 = "";
                    Properties.Settings.Default.t5 = "";
                    Properties.Settings.Default.Save();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            if (lang.SelectedIndex == 2)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset all text and colors in 1, 2, 3, 4, 5 notes?\nThis action cannot be undone and the text cannot be restored.", "Maku CherryWave", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    t1.BackColor = Color.FromArgb(25, 25, 25);
                    t2.BackColor = Color.FromArgb(25, 25, 25);
                    t3.BackColor = Color.FromArgb(25, 25, 25);
                    t4.BackColor = Color.FromArgb(25, 25, 25);
                    t5.BackColor = Color.FromArgb(25, 25, 25);
                    t1.Text = "";
                    t2.Text = "";
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";
                    Properties.Settings.Default.ct1 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct2 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct3 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct4 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct5 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.t1 = "";
                    Properties.Settings.Default.t2 = "";
                    Properties.Settings.Default.t3 = "";
                    Properties.Settings.Default.t4 = "";
                    Properties.Settings.Default.t5 = "";
                    Properties.Settings.Default.Save();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            if (lang.SelectedIndex == 3)
            {
                DialogResult dialogResult = MessageBox.Show("1、2、3、4、5 のエントリのすべてのテキストと色をリセットしてもよろしいですか?\nこの操作を元に戻すことはできず、テキストを復元することもできません。","Maku CherryWave",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    t1.BackColor = Color.FromArgb(25, 25, 25);
                    t2.BackColor = Color.FromArgb(25, 25, 25);
                    t3.BackColor = Color.FromArgb(25, 25, 25);
                    t4.BackColor = Color.FromArgb(25, 25, 25);
                    t5.BackColor = Color.FromArgb(25, 25, 25);
                    t1.Text = "";
                    t2.Text = "";
                    t3.Text = "";
                    t4.Text = "";
                    t5.Text = "";
                    Properties.Settings.Default.ct1 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct2 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct3 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct4 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct5 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.t1 = "";
                    Properties.Settings.Default.t2 = "";
                    Properties.Settings.Default.t3 = "";
                    Properties.Settings.Default.t4 = "";
                    Properties.Settings.Default.t5 = "";
                    Properties.Settings.Default.Save();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void сброситьПоследниеПятьЗаписейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lang.SelectedIndex == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите сбросить весь текст и цвета в 6, 7, 8, 9, 10 записях?\nЭто действие нельзя отменить, и текст нельзя восстановить.", "Maku CherryWave", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    t6.BackColor = Color.FromArgb(25, 25, 25);
                    t7.BackColor = Color.FromArgb(25, 25, 25);
                    t8.BackColor = Color.FromArgb(25, 25, 25);
                    t9.BackColor = Color.FromArgb(25, 25, 25);
                    t10.BackColor = Color.FromArgb(25, 25, 25);
                    t6.Text = "";
                    t7.Text = "";
                    t8.Text = "";
                    t9.Text = "";
                    t10.Text = "";
                    Properties.Settings.Default.ct6 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct7 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct8 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct9 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct10 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.t6 = "";
                    Properties.Settings.Default.t7 = "";
                    Properties.Settings.Default.t8 = "";
                    Properties.Settings.Default.t9 = "";
                    Properties.Settings.Default.t10 = "";
                    Properties.Settings.Default.Save();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            if (lang.SelectedIndex == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Ви дійсно хочете скинути весь текст і кольори в 6, 7, 8, 9, 10 записах?\nЦю дію не можна скасувати, а текст не можна відновити.", "Maku CherryWave", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    t6.BackColor = Color.FromArgb(25, 25, 25);
                    t7.BackColor = Color.FromArgb(25, 25, 25);
                    t8.BackColor = Color.FromArgb(25, 25, 25);
                    t9.BackColor = Color.FromArgb(25, 25, 25);
                    t10.BackColor = Color.FromArgb(25, 25, 25);
                    t6.Text = "";
                    t7.Text = "";
                    t8.Text = "";
                    t9.Text = "";
                    t10.Text = "";
                    Properties.Settings.Default.ct6 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct7 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct8 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct9 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct10 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.t6 = "";
                    Properties.Settings.Default.t7 = "";
                    Properties.Settings.Default.t8 = "";
                    Properties.Settings.Default.t9 = "";
                    Properties.Settings.Default.t10 = "";
                    Properties.Settings.Default.Save();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            if (lang.SelectedIndex == 2)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset all text and colors in 6, 7, 8, 9, 10 notes?\nThis action cannot be undone and the text cannot be restored.", "Maku CherryWave", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    t6.BackColor = Color.FromArgb(25, 25, 25);
                    t7.BackColor = Color.FromArgb(25, 25, 25);
                    t8.BackColor = Color.FromArgb(25, 25, 25);
                    t9.BackColor = Color.FromArgb(25, 25, 25);
                    t10.BackColor = Color.FromArgb(25, 25, 25);
                    t6.Text = "";
                    t7.Text = "";
                    t8.Text = "";
                    t9.Text = "";
                    t10.Text = "";
                    Properties.Settings.Default.ct6 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct7 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct8 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct9 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct10 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.t6 = "";
                    Properties.Settings.Default.t7 = "";
                    Properties.Settings.Default.t8 = "";
                    Properties.Settings.Default.t9 = "";
                    Properties.Settings.Default.t10 = "";
                    Properties.Settings.Default.Save();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            if (lang.SelectedIndex == 3)
            {
                DialogResult dialogResult = MessageBox.Show("6、7、8、9、10 のエントリのすべてのテキストと色をリセットしてもよろしいですか?\nこの操作を元に戻すことはできず、テキストを復元することもできません。", "Maku CherryWave", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    t6.BackColor = Color.FromArgb(25, 25, 25);
                    t7.BackColor = Color.FromArgb(25, 25, 25);
                    t8.BackColor = Color.FromArgb(25, 25, 25);
                    t9.BackColor = Color.FromArgb(25, 25, 25);
                    t10.BackColor = Color.FromArgb(25, 25, 25);
                    t6.Text = "";
                    t7.Text = "";
                    t8.Text = "";
                    t9.Text = "";
                    t10.Text = "";
                    Properties.Settings.Default.ct6 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct7 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct8 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct9 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.ct10 = Color.FromArgb(25, 25, 25);
                    Properties.Settings.Default.t6 = "";
                    Properties.Settings.Default.t7 = "";
                    Properties.Settings.Default.t8 = "";
                    Properties.Settings.Default.t9 = "";
                    Properties.Settings.Default.t10 = "";
                    Properties.Settings.Default.Save();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void сброситьПервыеПятьЗаголовковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            z1.BackColor = Color.FromArgb(21, 21, 21);
            z2.BackColor = Color.FromArgb(21, 21, 21);
            z3.BackColor = Color.FromArgb(21, 21, 21);
            z4.BackColor = Color.FromArgb(21, 21, 21);
            z5.BackColor = Color.FromArgb(21, 21, 21);
            z1.Text = "";
            z2.Text = "";
            z3.Text = "";
            z4.Text = "";
            z5.Text = "";
            Properties.Settings.Default.cz1 = Color.FromArgb(21, 21, 21);
            Properties.Settings.Default.cz2 = Color.FromArgb(21, 21, 21);
            Properties.Settings.Default.cz3 = Color.FromArgb(21, 21, 21);
            Properties.Settings.Default.cz4 = Color.FromArgb(21, 21, 21);
            Properties.Settings.Default.cz5 = Color.FromArgb(21, 21, 21);
            Properties.Settings.Default.z1 = "";
            Properties.Settings.Default.z2 = "";
            Properties.Settings.Default.z3 = "";
            Properties.Settings.Default.z4 = "";
            Properties.Settings.Default.z5 = "";
            Properties.Settings.Default.Save();
        }

        private void сброситьПоследниеПятьЗаголовковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            z6.BackColor = Color.FromArgb(21, 21, 21);
            z7.BackColor = Color.FromArgb(21, 21, 21);
            z8.BackColor = Color.FromArgb(21, 21, 21);
            z9.BackColor = Color.FromArgb(21, 21, 21);
            z10.BackColor = Color.FromArgb(21, 21, 21);
            z6.Text = "";
            z7.Text = "";
            z8.Text = "";
            z9.Text = "";
            z10.Text = "";
            Properties.Settings.Default.cz6 = Color.FromArgb(21, 21, 21);
            Properties.Settings.Default.cz7 = Color.FromArgb(21, 21, 21);
            Properties.Settings.Default.cz8 = Color.FromArgb(21, 21, 21);
            Properties.Settings.Default.cz9 = Color.FromArgb(21, 21, 21);
            Properties.Settings.Default.cz10 = Color.FromArgb(21, 21, 21);
            Properties.Settings.Default.z6 = "";
            Properties.Settings.Default.z7 = "";
            Properties.Settings.Default.z8 = "";
            Properties.Settings.Default.z9 = "";
            Properties.Settings.Default.z10 = "";
            Properties.Settings.Default.Save();
        }

        private void поверхВсехОконToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (поверхВсехОконToolStripMenuItem.Checked == true)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void единыйРежимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(единыйРежимToolStripMenuItem.Checked == true)
            {
                label1.Visible = false;
                label4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                z1.Visible = false;
                z2.Visible = false;
                z3.Visible = false;
                z4.Visible = false;
                z5.Visible = false;
                z6.Visible = false;
                z7.Visible = false;
                z8.Visible = false;
                z9.Visible = false;
                z10.Visible = false;
                t2.Visible = false;
                t3.Visible = false;
                t4.Visible = false;
                t5.Visible = false;
                t6.Visible = false;
                t7.Visible = false;
                t8.Visible = false;
                t9.Visible = false;
                t10.Visible = false;

                t1.Dock = DockStyle.Fill;
            }
            else
            {
                label1.Visible = true;
                label4.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                z1.Visible = true;
                z2.Visible = true;
                z3.Visible = true;
                z4.Visible = true;
                z5.Visible = true;
                z6.Visible = true;
                z7.Visible = true;
                z8.Visible = true;
                z9.Visible = true;
                z10.Visible = true;
                t2.Visible = true;
                t3.Visible = true;
                t4.Visible = true;
                t5.Visible = true;
                t6.Visible = true;
                t7.Visible = true;
                t8.Visible = true;
                t9.Visible = true;
                t10.Visible = true;

                t1.Dock = DockStyle.None;
                if(t1.Height < 601)
                {
                    if(lang.SelectedIndex == 0)
                    {
                        MessageBox.Show("Перезапустите программу, чтобы применить изменения.", "Maku CherryWave",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                    if (lang.SelectedIndex == 1)
                    {
                        MessageBox.Show("Перезапустіть програму, щоб застосувати зміни.", "Maku CherryWave", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (lang.SelectedIndex == 2)
                    {
                        MessageBox.Show("Restart the program to apply the changes.", "Maku CherryWave", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (lang.SelectedIndex == 3)
                    {
                        MessageBox.Show("プログラムを再起動して変更を適用します。", "Maku CherryWave", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.ShowDialog();
        }
        private void t1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void t1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                switch (tc1)
                {
                    case 0:
                        tc1 = 1;
                        t1.ScrollBars = ScrollBars.Vertical;
                        break;
                    case 1:
                        tc1 = 0;
                        t1.ScrollBars = ScrollBars.None;
                        break;
                }
            }
        }

        private void t2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                switch (tc2)
                {
                    case 0:
                        tc2 = 1;
                        t2.ScrollBars = ScrollBars.Vertical;
                        break;
                    case 1:
                        tc2 = 0;
                        t2.ScrollBars = ScrollBars.None;
                        break;
                }
            }
        }

        private void t3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                switch (tc3)
                {
                    case 0:
                        tc3 = 1;
                        t3.ScrollBars = ScrollBars.Vertical;
                        break;
                    case 1:
                        tc3 = 0;
                        t3.ScrollBars = ScrollBars.None;
                        break;
                }
            }
        }

        private void t4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                switch (tc4)
                {
                    case 0:
                        tc4 = 1;
                        t4.ScrollBars = ScrollBars.Vertical;
                        break;
                    case 1:
                        tc4 = 0;
                        t4.ScrollBars = ScrollBars.None;
                        break;
                }
            }
        }

        private void t5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                switch (tc5)
                {
                    case 0:
                        tc5 = 1;
                        t5.ScrollBars = ScrollBars.Vertical;
                        break;
                    case 1:
                        tc5 = 0;
                        t5.ScrollBars = ScrollBars.None;
                        break;
                }
            }
        }

        private void t6_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                switch (tc6)
                {
                    case 0:
                        tc6 = 1;
                        t6.ScrollBars = ScrollBars.Vertical;
                        break;
                    case 1:
                        tc6 = 0;
                        t6.ScrollBars = ScrollBars.None;
                        break;
                }
            }
        }

        private void t7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                switch (tc7)
                {
                    case 0:
                        tc7 = 1;
                        t7.ScrollBars = ScrollBars.Vertical;
                        break;
                    case 1:
                        tc7 = 0;
                        t7.ScrollBars = ScrollBars.None;
                        break;
                }
            }
        }

        private void t8_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                switch (tc8)
                {
                    case 0:
                        tc8 = 1;
                        t8.ScrollBars = ScrollBars.Vertical;
                        break;
                    case 1:
                        tc8 = 0;
                        t8.ScrollBars = ScrollBars.None;
                        break;
                }
            }
        }

        private void t9_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                switch (tc9)
                {
                    case 0:
                        tc9 = 1;
                        t9.ScrollBars = ScrollBars.Vertical;
                        break;
                    case 1:
                        tc9 = 0;
                        t9.ScrollBars = ScrollBars.None;
                        break;
                }
            }
        }

        private void t10_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                switch (tc10)
                {
                    case 0:
                        tc10 = 1;
                        t10.ScrollBars = ScrollBars.Vertical;
                        break;
                    case 1:
                        tc10 = 0;
                        t10.ScrollBars = ScrollBars.None;
                        break;
                }
            }
        }
    }
}
