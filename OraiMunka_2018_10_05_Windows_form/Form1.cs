using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OraiMunka_2018_10_05_Windows_form
{
    public partial class Form_adadt_bevitel : Form
    {
        public Form_adadt_bevitel()
        {
            InitializeComponent();
        }

        List<TextBox> Nevek = new List<TextBox>();
        List<DateTimePicker> Szuletesi_datum = new List<DateTimePicker>();
        public int darab = 1;
        public string szoveg = "";

        private void Button_Sor_hozzaadas_Click(object sender, EventArgs e)
        {
            // if (darab == 1)
            {
                darab++;
                TextBox Textbox_nevbevitel = new TextBox();
                Textbox_nevbevitel.SetBounds(9, 14 + darab * 32, 125, Textbox_nevbevitel.Height);
                // Első érték:      Kezdeti érték, hogy honnan kezdje létrehozni az adott panelt
                // Második érték:   2 panel közötti távolság
                // Harmadik érték:  
                // Negyedik érték:  Panel végét jelölő érték -> milyen hosszú legyen
                this.Controls.Add(Textbox_nevbevitel);
                Nevek.Add(Textbox_nevbevitel);

                DateTimePicker Naptar = new DateTimePicker();
                Naptar.SetBounds(147, 14 + darab * 32, 175, Naptar.Height);
                this.Controls.Add(Naptar);
                Szuletesi_datum.Add(Naptar);
            }
            /*else if ((Nevek[darab - 1].Text != null) && (Nevek[darab - 1].Text != null))
            {
                darab++;
                TextBox Textbox_nevbevitel = new TextBox();
                Textbox_nevbevitel.SetBounds(9, 14 + darab * 32, 125, Textbox_nevbevitel.Height);
                this.Controls.Add(Textbox_nevbevitel);
                Nevek.Add(Textbox_nevbevitel);

                DateTimePicker Naptar = new DateTimePicker();
                Naptar.SetBounds(147, 14 + darab * 32, 175, Naptar.Height);
                this.Controls.Add(Naptar);
                Szuletesi_datum.Add(Naptar); 
            }*/
        }

        private void Button_kiiratas_Click(object sender, EventArgs e)
        {
            szoveg = "";
            for (int i = 0; i < Nevek.Count; i++)
            {
                if ((Nevek[i].Text != null) && (Nevek[i].Text != ""))
                {
                    szoveg += Nevek[i].Text + " - " + Szuletesi_datum[i].Text;
                }
                MessageBox.Show(TextBox_nev.Text + " - " + DateTimePicker_szul_ido.Value + "\n" + szoveg + "\n");
                /*
                 * MessageBox.Show(TextBox_nev.Text + " - " + DateTimePicker_szul_ido.Value +
                                "\n" + Convert.ToString(Nevek[i].Text) + " - " + Szuletesi_datum[i].Value);
                                */
            }
        }
    }
}