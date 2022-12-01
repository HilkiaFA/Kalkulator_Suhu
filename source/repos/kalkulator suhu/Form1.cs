using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace suhu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click_1(object sender, EventArgs e)
        {
            txt_suhu.Text = string.Empty;
            txt_konversi.Text = string.Empty;
            box_suhu.Text = string.Empty;
            box_konversi.Text = string.Empty;
            lbl_input2.Visible = false;
            lbl_input.Visible = false;
            lbl_suhu.Visible = false;
            lbl_derajat.Visible = false;
            lbl_suhuderajat.Visible = false;
        }

        private void btn_konversi_Click(object sender, EventArgs e)
        {
            {
                


                try
                 {
                    double suhu;
                    double hasil = 0;
                    string compare = txt_suhu.Text;
                    Regex regex = new Regex("[1-9]");

                    if (!regex.IsMatch(compare))
                    {
                        MessageBox.Show("Silahkan Masukkan Angka");
                        txt_suhu.Text = "";
                    }
                    else if (string.IsNullOrEmpty(box_suhu.Text) || string.IsNullOrEmpty(box_konversi.Text))
                    {
                        if (string.IsNullOrEmpty(box_suhu.Text))
                        {
                            lbl_input.Text = "Masukkan Satuan Suhu Pertama*";
                            lbl_input.Visible = true;
                        }
                        if (string.IsNullOrEmpty(box_konversi.Text))
                        {
                            lbl_input2.Text = "Masukkan Satuan Suhu Kedua*";
                            lbl_input2.Visible = true;
                        }

                    }
                    else
                    {
                        suhu = double.Parse(txt_suhu.Text);
                        lbl_input2.Visible = false;
                        lbl_input.Visible = false;
                        lbl_suhu.Visible = false;
                        {
                            /*Rumus calcius*/

                            if (box_suhu.Text == "Celcius" && box_konversi.Text == "Celcius")
                            {
                                hasil = suhu;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Celcius" && box_konversi.Text == "Fahrenheit")
                            {
                                hasil = (1.8 * suhu) + 32;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Celcius" && box_konversi.Text == "Kelvin")
                            {
                                hasil = (suhu + 273.15);
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Celcius" && box_konversi.Text == "Rankine")
                            {
                                hasil = (suhu + 273.15) * 9 / 5;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Celcius" && box_konversi.Text == "Reamur")
                            {
                                hasil = 0.8 * suhu;
                                txt_konversi.Text = hasil.ToString();
                            }
                            /*rumus fahrenheit*/
                            else if (box_suhu.Text == "Fahrenheit" && box_konversi.Text == "Celcius")
                            {
                                hasil = (suhu - 32) * 5 / 9;
                                txt_konversi.Text = hasil.ToString();
                            }

                            else if (box_suhu.Text == "Fahrenheit" && box_konversi.Text == "Fahrenheit")
                            {
                                hasil = suhu;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Fahrenheit" && box_konversi.Text == "Kelvin")
                            {
                                hasil = (suhu - 32) * 5 / 9 + 273.15;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Fahrenheit" && box_konversi.Text == "Rankine")
                            {
                                hasil = suhu + 459.67;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Fahrenheit" && box_konversi.Text == "Reamur")
                            {
                                hasil = (suhu - 32) * 4 / 9;
                                txt_konversi.Text = hasil.ToString();
                            }
                            /*rumus kelvin*/
                            else if (box_suhu.Text == "Kelvin" && box_konversi.Text == "Celcius")
                            {
                                hasil = suhu - 273.15;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Kelvin" && box_konversi.Text == "Kelvin")
                            {
                                hasil = suhu;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Kelvin" && box_konversi.Text == "Fahrenheit")
                            {
                                hasil = (suhu * 9 / 5) - 459.67;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Kelvin" && box_konversi.Text == "Rankine")
                            {
                                hasil = suhu * 9 / 5;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Kelvin" && box_konversi.Text == "Reamur")
                            {
                                hasil = (suhu - 273.15) * 4 / 5;
                                txt_konversi.Text = hasil.ToString();
                            }
                            /*rumus rankine*/
                            else if (box_suhu.Text == "Rankine" && box_konversi.Text == "Celcius")
                            {
                                hasil = (suhu - 491.67) * 5 / 9;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Rankine" && box_konversi.Text == "Fahrenheit")
                            {
                                hasil = suhu - 459.67;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Rankine" && box_konversi.Text == "Rankine")
                            {
                                hasil = suhu;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Rankine" && box_konversi.Text == "Kelvin")
                            {
                                hasil = suhu * 5 / 9;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Rankine" && box_konversi.Text == "Reamur")
                            {
                                hasil = (suhu - 491.67) * 4 / 9;
                                txt_konversi.Text = hasil.ToString();
                            }
                            /*rumus reamur*/
                            else if (box_suhu.Text == "Reamur" && box_konversi.Text == "Celcius")
                            {
                                hasil = suhu / 0.8;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Reamur" && box_konversi.Text == "Fahrenheit")
                            {
                                hasil = (2.25 * suhu) + 32;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Reamur" && box_konversi.Text == "Kelvin")
                            {
                                hasil = (suhu * 5 / 4) + 273.15;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Reamur" && box_konversi.Text == "Rankine")
                            {
                                hasil = (suhu * 9 / 4) + 491.67;
                                txt_konversi.Text = hasil.ToString();
                            }
                            else if (box_suhu.Text == "Reamur" && box_konversi.Text == "Reamur")
                            {
                                hasil = suhu;
                                txt_konversi.Text = hasil.ToString();
                            }
                        }
                    }
                }
                 catch (Exception)
                 {
                     txt_suhu.Text = "";
                     MessageBox.Show("Masukkan angka yang tidak mengandung huruf");
                 }

            }
        }

        private void box_suhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (box_suhu.SelectedIndex == 0)
            {
                lbl_suhuderajat.Text = "°C";
                lbl_suhuderajat.Visible = true;
            }
            else if (box_suhu.SelectedIndex == 1)
            {
                lbl_suhuderajat.Text = "°F";
                lbl_suhuderajat.Visible = true;
            }
            else if (box_suhu.SelectedIndex == 2)
            {
                lbl_suhuderajat.Text = "K";
                lbl_suhuderajat.Visible = true;
            }
            else if (box_suhu.SelectedIndex == 3)
            {
                lbl_suhuderajat.Text = "°R";
                lbl_suhuderajat.Visible = true;
            }
            else if (box_suhu.SelectedIndex == 4)
            {
                lbl_suhuderajat.Text = "°Re";
                lbl_suhuderajat.Visible = true;
            }  
        }

        private void box_konversi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (box_konversi.SelectedIndex == 0)
            {
                lbl_derajat.Text = "°C";
                lbl_derajat.Visible = true;
            }
            else if (box_konversi.SelectedIndex == 1)
            {
                lbl_derajat.Text = "°F";
                lbl_derajat.Visible = true;
            }
            else if (box_konversi.SelectedIndex == 2)
            {
                lbl_derajat.Text = "K";
                lbl_derajat.Visible = true;
            }
            else if (box_konversi.SelectedIndex == 3)
            {
                lbl_derajat.Text = "°R";
                lbl_derajat.Visible = true;
            }
            else if (box_konversi.SelectedIndex == 4)
            {
                lbl_derajat.Text = "°Re";
                lbl_derajat.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (box_suhu.Text == "Celcius")
            {
                SpeechSynthesizer speechObj = new SpeechSynthesizer();
                speechObj.SpeakAsync(txt_suhu.Text + "°Celcius");
            }
            else if (box_suhu.Text == "Fahrenheit")
            {
                SpeechSynthesizer speechObj = new SpeechSynthesizer();
                speechObj.SpeakAsync(txt_suhu.Text + "°Fahrenheit");
            }
            else if (box_suhu.Text == "Kelvin")
            {
                SpeechSynthesizer speechObj = new SpeechSynthesizer();
                speechObj.SpeakAsync(txt_suhu.Text + "°Kelvin");
            }
            else if (box_suhu.Text == "Rankine")
            {
                SpeechSynthesizer speechObj = new SpeechSynthesizer();
                speechObj.SpeakAsync(txt_suhu.Text + "°Rankine");
            }
            else if (box_suhu.Text == "Reamur")
            {
                SpeechSynthesizer speechObj = new SpeechSynthesizer();
                speechObj.SpeakAsync(txt_suhu.Text + "°Reamur");
            }
            else if (string.IsNullOrEmpty(box_suhu.Text))
            {
                SpeechSynthesizer speechObj = new SpeechSynthesizer();
                speechObj.SpeakAsync(txt_suhu.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (box_konversi.Text == "Celcius")
            {
                SpeechSynthesizer speechObj = new SpeechSynthesizer();
                speechObj.SpeakAsync(txt_konversi.Text + "°Celcius");
            }
            else if (box_konversi.Text == "Fahrenheit")
            {
                SpeechSynthesizer speechObj = new SpeechSynthesizer();
                speechObj.SpeakAsync(txt_konversi.Text + "°Fahrenheit");
            }
            else if (box_konversi.Text == "Kelvin")
            {
                SpeechSynthesizer speechObj = new SpeechSynthesizer();
                speechObj.SpeakAsync(txt_konversi.Text + "°Kelvin");
            }
            else if (box_konversi.Text == "Rankine")
            {
                SpeechSynthesizer speechObj = new SpeechSynthesizer();
                speechObj.SpeakAsync(txt_konversi.Text + "°Rankine");
            }
            else if (box_konversi.Text == "Reamur")
            {
                SpeechSynthesizer speechObj = new SpeechSynthesizer();
                speechObj.SpeakAsync(txt_konversi.Text + "°Reamur");
            }
            else if (string.IsNullOrEmpty(box_konversi.Text))
            {
                SpeechSynthesizer speechObj = new SpeechSynthesizer();
                speechObj.SpeakAsync(txt_konversi.Text);
            }
        }
    }
 }


