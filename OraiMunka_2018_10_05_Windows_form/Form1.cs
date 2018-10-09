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

        public int darab = 1;

        private void Button_Sor_hozzaadas_Click(object sender, EventArgs e)
        {
            if (TextBox_nev.Text != " ")
            {
                darab++;
                TextBox Textbox_nevbevitel = new TextBox();
                Textbox_nevbevitel.SetBounds(9, 14 + darab * 32, 125, Textbox_nevbevitel.Height);
                // Első érték:      Kezdeti érték, hogy honnan kezdje létrehozni az adott panelt
                // Második érték:   2 panel közötti távolság
                // Harmadik érték:  
                // Negyedik érték:  Panel végét jelölő érték -> milyen hosszú legyen
                this.Controls.Add(Textbox_nevbevitel);

                DateTimePicker Naptar = new DateTimePicker();
                Naptar.SetBounds(147, 14 + darab * 32, 175, Naptar.Height);
                this.Controls.Add(Naptar);
            }
        }
    }
}
