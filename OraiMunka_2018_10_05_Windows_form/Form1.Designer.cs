namespace OraiMunka_2018_10_05_Windows_form
{
    partial class Form_adadt_bevitel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_nev = new System.Windows.Forms.TextBox();
            this.Button_Sor_hozzaadas = new System.Windows.Forms.Button();
            this.Button_kiiratas = new System.Windows.Forms.Button();
            this.DateTimePicker_szul_ido = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TextBox_nev
            // 
            this.TextBox_nev.Location = new System.Drawing.Point(12, 55);
            this.TextBox_nev.Name = "TextBox_nev";
            this.TextBox_nev.Size = new System.Drawing.Size(165, 22);
            this.TextBox_nev.TabIndex = 0;
            // 
            // Button_Sor_hozzaadas
            // 
            this.Button_Sor_hozzaadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Sor_hozzaadas.Location = new System.Drawing.Point(39, 12);
            this.Button_Sor_hozzaadas.Name = "Button_Sor_hozzaadas";
            this.Button_Sor_hozzaadas.Size = new System.Drawing.Size(155, 23);
            this.Button_Sor_hozzaadas.TabIndex = 1;
            this.Button_Sor_hozzaadas.Text = "Sor hozzáadása";
            this.Button_Sor_hozzaadas.UseVisualStyleBackColor = true;
            this.Button_Sor_hozzaadas.Click += new System.EventHandler(this.Button_Sor_hozzaadas_Click);
            // 
            // Button_kiiratas
            // 
            this.Button_kiiratas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_kiiratas.Location = new System.Drawing.Point(252, 12);
            this.Button_kiiratas.Name = "Button_kiiratas";
            this.Button_kiiratas.Size = new System.Drawing.Size(87, 23);
            this.Button_kiiratas.TabIndex = 2;
            this.Button_kiiratas.Text = "Kiíratás";
            this.Button_kiiratas.UseVisualStyleBackColor = true;
            this.Button_kiiratas.Click += new System.EventHandler(this.Button_kiiratas_Click);
            // 
            // DateTimePicker_szul_ido
            // 
            this.DateTimePicker_szul_ido.Location = new System.Drawing.Point(196, 55);
            this.DateTimePicker_szul_ido.Name = "DateTimePicker_szul_ido";
            this.DateTimePicker_szul_ido.Size = new System.Drawing.Size(232, 22);
            this.DateTimePicker_szul_ido.TabIndex = 3;
            // 
            // Form_adadt_bevitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(438, 124);
            this.Controls.Add(this.DateTimePicker_szul_ido);
            this.Controls.Add(this.Button_kiiratas);
            this.Controls.Add(this.Button_Sor_hozzaadas);
            this.Controls.Add(this.TextBox_nev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form_adadt_bevitel";
            this.Text = "Adatbevitel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_nev;
        private System.Windows.Forms.Button Button_Sor_hozzaadas;
        private System.Windows.Forms.Button Button_kiiratas;
        private System.Windows.Forms.DateTimePicker DateTimePicker_szul_ido;
    }
}

