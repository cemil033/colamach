using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colamachin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        database database = new database();
        List<alinan> tempalinan=new List<alinan>();
        stock stock = new stock()
        {
            albeni = 100,
            bounty = 100,
            snickers = 100,
            cola = 100,
            fanta = 100,
            icetea = 100,
            mars = 100,
            pepsi = 100,
            tutku = 100
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            uc_cola.label1.Text = "Cola";
            uc_albeni.label1.Text = "Albeni";
            uc_bounty.label1.Text = "Bounty";
            uc_fanta.label1.Text = "Fanta";
            uc_icetea.label1.Text = "ICE Tea";
            uc_pepsi.label1.Text = "Pepsi";
            uc_snick.label1.Text = "Snickers";
            uc_tutku.label1.Text = "Tutku";
            uc_mars.label1.Text = "Mars";
            uc_cola.label4.Text = "1.00";
            uc_fanta.label4.Text = "1.00";
            uc_icetea.label4.Text = "1.50";
            uc_pepsi.label4.Text = "1.00";
            uc_snick.label4.Text = "0.80";
            uc_mars.label4.Text = "0.80";
            uc_tutku.label4.Text = "0.50";
            uc_albeni.label4.Text = "0.50";
            uc_bounty.label4.Text = "0.80";
            if (File.Exists("users.json"))
            {
                var jsonStr = File.ReadAllText("users.json");
                database = JsonConvert.DeserializeObject<database>(jsonStr);
            }
            if (File.Exists("colamach.json"))
            {                
                var jsonStr = File.ReadAllText("colamach.json");
                stock= JsonConvert.DeserializeObject<stock>(jsonStr);
                uc_cola.label3.Text = stock.cola.ToString();
                uc_mars.label3.Text=  stock.mars.ToString();
                uc_bounty.label3.Text=stock.bounty.ToString();
                uc_albeni.label3.Text=stock.albeni.ToString();
                uc_snick.label3.Text =stock.snickers.ToString();
                uc_tutku.label3.Text= stock.tutku.ToString();
                uc_pepsi.label3.Text= stock.pepsi.ToString();
                uc_fanta.label3.Text= stock.fanta.ToString();
                uc_icetea.label3.Text=stock.icetea.ToString();
                uc_cola.progressBar1.Value  = stock.cola;
                uc_fanta.progressBar1.Value = stock.fanta;
                uc_pepsi.progressBar1.Value = stock.pepsi;
                uc_icetea.progressBar1.Value= stock.icetea;
                uc_mars.progressBar1.Value  = stock.mars;
                uc_bounty.progressBar1.Value= stock.bounty;
                uc_albeni.progressBar1.Value= stock.albeni;
                uc_snick.progressBar1.Value = stock.snickers;
                uc_tutku.progressBar1.Value = stock.tutku;


            }
            else
            {
                
                uc_cola.label3.Text = stock.cola.ToString();
                uc_mars.label3.Text = stock.mars.ToString();
                uc_bounty.label3.Text = stock.bounty.ToString();
                uc_albeni.label3.Text = stock.albeni.ToString();
                uc_snick.label3.Text = stock.snickers.ToString();
                uc_tutku.label3.Text = stock.tutku.ToString();
                uc_pepsi.label3.Text = stock.pepsi.ToString();
                uc_fanta.label3.Text = stock.fanta.ToString();
                uc_icetea.label3.Text = stock.icetea.ToString();
                uc_cola.progressBar1.Value = stock.cola;
                uc_fanta.progressBar1.Value = stock.fanta;
                uc_pepsi.progressBar1.Value = stock.pepsi;
                uc_icetea.progressBar1.Value = stock.icetea;
                uc_mars.progressBar1.Value = stock.mars;
                uc_bounty.progressBar1.Value = stock.bounty;
                uc_albeni.progressBar1.Value = stock.albeni;
                uc_snick.progressBar1.Value = stock.snickers;
                uc_tutku.progressBar1.Value = stock.tutku;

            }
        }
        double tutm = 0;
        public void Gotur_click(object sender,EventArgs e)
        {
            
            if (sender ==btn_cola)
            {
                if (double.Parse(label3.Text) >= 1)
                {
                    tempalinan.Add(new alinan() { name = "Coca Cola", price = 1 });
                    tutm += 1;
                    label6.Text = tutm.ToString();
                    label4.Text = (double.Parse(label3.Text) - tutm).ToString();
                    stock.cola--;
                    uc_cola.progressBar1.Value -= 1;
                    uc_cola.label3.Text= uc_cola.progressBar1.Value.ToString();
                }
            }
            else if (sender ==btn_fanta)
            {
                if (double.Parse(label3.Text) >= 1)
                {
                    tempalinan.Add(new alinan() { name = "Fanta", price = 1 });
                    tutm += 1;
                    label6.Text = tutm.ToString();
                    label4.Text = (double.Parse(label3.Text) - tutm).ToString();
                    stock.fanta--;
                    uc_fanta.progressBar1.Value -= 1;
                    uc_fanta.label3.Text = uc_fanta.progressBar1.Value.ToString();
                }
            }
            else if (sender ==btn_pepsi)
            {
                if (double.Parse(label3.Text) >= 1)
                {
                    tempalinan.Add(new alinan() { name = "Pepsi", price = 1 });
                    tutm += 1;
                    label6.Text = tutm.ToString();
                    label4.Text = (double.Parse(label3.Text) - tutm).ToString();
                    stock.pepsi--;
                    uc_pepsi.progressBar1.Value -= 1;
                    uc_pepsi.label3.Text = uc_pepsi.progressBar1.Value.ToString();
                }
            }
            else if (sender ==btn_icet)
            {
                if (double.Parse(label3.Text) >= 1.5)
                {
                    tempalinan.Add(new alinan() { name = "Ice Tea", price = 1.5 });
                    tutm += 1.5;
                    label6.Text = tutm.ToString();
                    label4.Text = (double.Parse(label3.Text) - tutm).ToString();
                    stock.icetea--;
                    uc_icetea.progressBar1.Value -= 1;
                    uc_icetea.label3.Text = uc_icetea.progressBar1.Value.ToString();
                }

            }
            else if (sender ==btn_bounty)
            {
                if (double.Parse(label3.Text) >= 0.8)
                {
                    tempalinan.Add(new alinan() { price = 0.8, name = "Bounty" });
                    tutm += 0.8;
                    label6.Text = tutm.ToString();
                    label4.Text = (double.Parse(label3.Text) - tutm).ToString();
                    stock.bounty--;
                    uc_bounty.progressBar1.Value -= 1;
                    uc_bounty.label3.Text = uc_bounty.progressBar1.Value.ToString();
                }

            }
            else if (sender ==btn_mars)
            {
                if (double.Parse(label3.Text) >= 0.8)
                {
                    tempalinan.Add(new alinan() { price = 0.8, name = "Mars" });
                    tutm += 0.8;
                    label6.Text = tutm.ToString();
                    label4.Text = (double.Parse(label3.Text) - tutm).ToString();
                    stock.mars--;
                    uc_mars.progressBar1.Value -= 1;
                    uc_mars.label3.Text = uc_mars.progressBar1.Value.ToString();
                }

            }
            else if (sender ==btn_snic)
            {
                if (double.Parse(label3.Text) >= 0.8)
                {
                    tempalinan.Add(new alinan() { name = "Snicker", price = 0.8 });
                    tutm += 0.8;
                    label6.Text = tutm.ToString();
                    label4.Text = (double.Parse(label3.Text) - tutm).ToString();
                    stock.snickers--;
                    uc_snick.progressBar1.Value -= 1;
                    uc_snick.label3.Text = uc_snick.progressBar1.Value.ToString();
                }

            }
            else if (sender ==btn_tutku)
            {
                if (double.Parse(label3.Text) >= 0.5)
                {
                    tempalinan.Add(new alinan() { name = "Tutku", price = 0.5 });
                    tutm += 0.5;
                    label6.Text = tutm.ToString();
                    label4.Text = (double.Parse(label3.Text) - tutm).ToString();
                    stock.tutku--;
                    uc_tutku.progressBar1.Value -= 1;
                    uc_tutku.label3.Text = uc_tutku.progressBar1.Value.ToString();
                }

            }
            else if (sender ==btn_albeni)
            {
                if (double.Parse(label3.Text) >= 1)
                {
                    tempalinan.Add(new alinan() { price = 0.5, name = "Albeni" });
                    tutm += 0.5;
                    label6.Text = tutm.ToString();
                    label4.Text = (double.Parse(label3.Text) - tutm).ToString();
                    stock.albeni--;
                    uc_albeni.progressBar1.Value -= 1;
                    uc_albeni.label3.Text = uc_albeni.progressBar1.Value.ToString();
                }

            }
        }

        private void btn_10q_Click(object sender, EventArgs e)
        {
            label3.Text=(double.Parse(label3.Text)+0.1).ToString();
        }

        private void btn_20q_Click(object sender, EventArgs e)
        {
            label3.Text = (double.Parse(label3.Text) + 0.2).ToString();
        }

        private void btn_50q_Click(object sender, EventArgs e)
        {
            label3.Text = (double.Parse(label3.Text) + 0.5).ToString();
        }

        private void btn_1azn_Click(object sender, EventArgs e)
        {
            label3.Text = (double.Parse(label3.Text) + 1).ToString();
        }

        private void btn_5azn_Click(object sender, EventArgs e)
        {
            label3.Text = (double.Parse(label3.Text) + 5).ToString();
        }

        private void btn_10azn_Click(object sender, EventArgs e)
        {
            label3.Text = (double.Parse(label3.Text) + 10).ToString();
        }

        private void btn_almaq_Click(object sender, EventArgs e)
        {
            database.users.Add(new user()
            {
                alinanlar = tempalinan,
                odenmis=double.Parse(label3.Text),
                qaliq=double.Parse(label4.Text),
                yekun_mebleg=double.Parse(label6.Text),
            });
            var str = JsonConvert.SerializeObject(stock, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("colamach.json", str);
            var str1 = JsonConvert.SerializeObject(database, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("users.json", str1);
            label3.Text = "0";
            label4.Text = "0";
            label6.Text = "0";
            tempalinan = new List<alinan>();
        }
    }
}
