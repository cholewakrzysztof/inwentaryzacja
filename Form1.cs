using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Diagnostics;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            wczytajDane();
        }

        FormAdd form_add;
        FormAddSprzet form_add_sprzet;

        List<Sala> lista_sal = new List<Sala>();
        List<Sprzet> lista_sprzet = new List<Sprzet>();

        public void wczytajDane() 
        {
            string dane = File.ReadAllText("plikt.txt");

            string[] sale = dane.Split("/");

            for (int i = 0; i < sale.Length-1; i++) 
            {
                string[] salaDane = sale[i].Split(";");
                Sala sala = new Sala(salaDane[0].Substring(1));
                string[] sprzetDane = salaDane[1].Split(",");
                for (int j = 0; j < sprzetDane.Length-1; j++) 
                {
                    string[] sprzetStr = sprzetDane[j].Split(":");
                    string name = sprzetStr[0].Substring(2);
                    int count = Convert.ToInt32(sprzetStr[1].Replace("}",""));
                    Console.WriteLine(sprzetStr[1]);

                    Sprzet sprzet = new Sprzet(name, 1);
                    sala.sprzet.Add(sprzet);
                }
                lista_sal.Add(sala);
            }

            string[] daneSale = File.ReadAllText("plik_sale.txt").Split("");
            string[] daneSprzet = File.ReadAllText("plik_sprzet.txt").Split("");


        }

        private void button_sale_add_Click(object sender, EventArgs e)
        {
            form_add = new FormAdd();
            if (form_add.ShowDialog() == DialogResult.OK) 
            {
                string name = form_add.textBox_name.Text;
                if (name.Length > 0) 
                {
                    Sala sala = new Sala(name);
                    listBox_sale.Items.Add(sala.name);
                    lista_sal.Add(sala);
                }
            }
        }

        private void button_sale_del_Click(object sender, EventArgs e)
        {
            int idx = listBox_sale.SelectedIndex;
            listBox_sale.Items.RemoveAt(idx);
            lista_sal.RemoveAt(idx);
            button_sale_edit.Enabled = false;
        }

        private void button_sprzet_add_Click(object sender, EventArgs e)
        {
            form_add = new FormAdd();
            if (form_add.ShowDialog() == DialogResult.OK)
            {
                string name = form_add.textBox_name.Text;
                if (name.Length > 0)
                {
                    Sprzet sprzet = new Sprzet(name);
                    listBox_sprzet.Items.Add(sprzet.name);
                    lista_sprzet.Add(sprzet);
                }
            }
        }

        private void button_sprzet_del_Click(object sender, EventArgs e)
        {
            int idx = listBox_sprzet.SelectedIndex;
            listBox_sprzet.Items.RemoveAt(idx);
            lista_sprzet.RemoveAt(idx);
            button_sale_edit.Enabled = false;
        }

        private void listBox_sale_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_sale_edit.Enabled = true;
        }

        private void button_sale_edit_Click(object sender, EventArgs e)
        {
            int idx = listBox_sale.SelectedIndex;
            listBox_stan.Items.Clear();

            foreach  (Sprzet sprzet in lista_sal[idx].sprzet)
            {
                listBox_stan.Items.Add(sprzet.name +": "+ sprzet.count.ToString());
            }

            groupBox_sale.Visible = false;
            groupBox_stan.Visible = true;
            groupBox_sprzet.Visible = false;
        }

        private void button_stan_add_Click(object sender, EventArgs e)
        {
            form_add_sprzet = new FormAddSprzet();

            foreach (var item in listBox_sprzet.Items)
            {
                form_add_sprzet.listBox1.Items.Add(item);
            }

            if (form_add_sprzet.ShowDialog() == DialogResult.OK) 
            {
                if (form_add_sprzet.textBox_count.Text != "") 
                {
                    try
                    {
                        int count = Convert.ToInt32(form_add_sprzet.textBox_count.Text);
                        string name = form_add_sprzet.listBox1.SelectedItem.ToString();

                        Sprzet sprzet = new Sprzet(name, count);
                        int idx = listBox_sale.SelectedIndex;

                        lista_sal[idx].sprzet.Add(sprzet);
                        listBox_stan.Items.Add(sprzet.name+": "+sprzet.count.ToString());
                    }
                    catch (Exception err) 
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }

        private void button_stan_del_Click(object sender, EventArgs e)
        {
            int idx = listBox_stan.SelectedIndex;
            int idxSala = listBox_sale.SelectedIndex;
            listBox_stan.Items.RemoveAt(idx);
            lista_sal[idxSala].sprzet.RemoveAt(idx);
            button_sale_edit.Enabled = false;
        }

        private void button_sale_show_Click(object sender, EventArgs e)
        {
            groupBox_sale.Visible = true;
            groupBox_stan.Visible = false;
            groupBox_sprzet.Visible = false;
        }

        private void button_sprzet_show_Click(object sender, EventArgs e)
        {
            groupBox_sale.Visible = false;
            groupBox_stan.Visible = false;
            groupBox_sprzet.Visible = true;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string resultSale = "";
            foreach (Sala sala in lista_sal)
            {
                resultSale += sala.toString();
            }
            File.WriteAllText("plikt.txt",resultSale);

            string result = "";
            foreach (var item in listBox_sale.Items)
            {
                result += item.ToString() + ";";
            }
            File.WriteAllText("plik_sale.txt", resultSale);

            result = "";
            foreach (var item in listBox_sprzet.Items)
            {
                result += item.ToString() + ";";
            }
            File.WriteAllText("plik_sprzet.txt", resultSale);

        }
    }

    public class Sala 
    {
        public string name;
        public List<Sprzet> sprzet;

        public Sala(string name) 
        {
            this.name = name;
            this.sprzet = new List<Sprzet>();
        }

        public string toString() 
        {
            string result = "{";

            result += this.name+";[";

            foreach (Sprzet sprzet in sprzet)
            {
                result += sprzet.toString()+",";
            }
            return result+"]}/";
        }
    }

    public class Sprzet
    {
        public string name;
        public int count;

        public Sprzet(string name,int count) 
        {
            this.name = name;
            this.count = count;
        }
        public Sprzet(string name)
        {
            this.name = name;
        }

        public string toString() 
        {
            string result = "{"+this.name+":"+this.count.ToString()+"}";
            return result;
        }
    }
}
