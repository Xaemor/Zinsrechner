namespace Zinsrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Anfangskapital = new System.Windows.Forms.Label();
            this.lbl_Zinssatz = new System.Windows.Forms.Label();
            this.lbl_Laufzeit = new System.Windows.Forms.Label();
            this.lbl_Endkapital = new System.Windows.Forms.Label();
            this.txt_Anfangskapital = new System.Windows.Forms.TextBox();
            this.txt_Zinssatz = new System.Windows.Forms.TextBox();
            this.txt_Laufzeit = new System.Windows.Forms.TextBox();
            this.txt_Endkapital = new System.Windows.Forms.TextBox();
            this.bt_Anfangskapitalberechnen = new System.Windows.Forms.RadioButton();
            this.lbl_Wassollberechnetwerden = new System.Windows.Forms.Label();
            this.bt_Zinssatz = new System.Windows.Forms.RadioButton();
            this.bt_Laufzeit = new System.Windows.Forms.RadioButton();
            this.bt_Endkapital = new System.Windows.Forms.RadioButton();
            this.bt_Berechnen = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Anfangskapital
            // 
            this.lbl_Anfangskapital.AutoSize = true;
            this.lbl_Anfangskapital.Location = new System.Drawing.Point(20, 57);
            this.lbl_Anfangskapital.Name = "lbl_Anfangskapital";
            this.lbl_Anfangskapital.Size = new System.Drawing.Size(77, 13);
            this.lbl_Anfangskapital.TabIndex = 0;
            this.lbl_Anfangskapital.Text = "Anfangskapital";
            // 
            // lbl_Zinssatz
            // 
            this.lbl_Zinssatz.AutoSize = true;
            this.lbl_Zinssatz.Location = new System.Drawing.Point(20, 83);
            this.lbl_Zinssatz.Name = "lbl_Zinssatz";
            this.lbl_Zinssatz.Size = new System.Drawing.Size(46, 13);
            this.lbl_Zinssatz.TabIndex = 1;
            this.lbl_Zinssatz.Text = "Zinssatz";
            // 
            // lbl_Laufzeit
            // 
            this.lbl_Laufzeit.AutoSize = true;
            this.lbl_Laufzeit.Location = new System.Drawing.Point(22, 110);
            this.lbl_Laufzeit.Name = "lbl_Laufzeit";
            this.lbl_Laufzeit.Size = new System.Drawing.Size(44, 13);
            this.lbl_Laufzeit.TabIndex = 2;
            this.lbl_Laufzeit.Text = "Laufzeit";
            // 
            // lbl_Endkapital
            // 
            this.lbl_Endkapital.AutoSize = true;
            this.lbl_Endkapital.Location = new System.Drawing.Point(22, 136);
            this.lbl_Endkapital.Name = "lbl_Endkapital";
            this.lbl_Endkapital.Size = new System.Drawing.Size(57, 13);
            this.lbl_Endkapital.TabIndex = 3;
            this.lbl_Endkapital.Text = "Endkapital";
            // 
            // txt_Anfangskapital
            // 
            this.txt_Anfangskapital.Location = new System.Drawing.Point(103, 54);
            this.txt_Anfangskapital.Name = "txt_Anfangskapital";
            this.txt_Anfangskapital.Size = new System.Drawing.Size(100, 20);
            this.txt_Anfangskapital.TabIndex = 4;
            // 
            // txt_Zinssatz
            // 
            this.txt_Zinssatz.Location = new System.Drawing.Point(103, 80);
            this.txt_Zinssatz.Name = "txt_Zinssatz";
            this.txt_Zinssatz.Size = new System.Drawing.Size(100, 20);
            this.txt_Zinssatz.TabIndex = 5;
            // 
            // txt_Laufzeit
            // 
            this.txt_Laufzeit.Location = new System.Drawing.Point(103, 107);
            this.txt_Laufzeit.Name = "txt_Laufzeit";
            this.txt_Laufzeit.Size = new System.Drawing.Size(100, 20);
            this.txt_Laufzeit.TabIndex = 6;
            // 
            // txt_Endkapital
            // 
            this.txt_Endkapital.Location = new System.Drawing.Point(103, 133);
            this.txt_Endkapital.Name = "txt_Endkapital";
            this.txt_Endkapital.Size = new System.Drawing.Size(100, 20);
            this.txt_Endkapital.TabIndex = 7;
            // 
            // bt_Anfangskapitalberechnen
            // 
            this.bt_Anfangskapitalberechnen.AutoSize = true;
            this.bt_Anfangskapitalberechnen.Location = new System.Drawing.Point(351, 55);
            this.bt_Anfangskapitalberechnen.Name = "bt_Anfangskapitalberechnen";
            this.bt_Anfangskapitalberechnen.Size = new System.Drawing.Size(149, 17);
            this.bt_Anfangskapitalberechnen.TabIndex = 8;
            this.bt_Anfangskapitalberechnen.TabStop = true;
            this.bt_Anfangskapitalberechnen.Text = "Anfangskapital berechnen";
            this.bt_Anfangskapitalberechnen.UseVisualStyleBackColor = true;
            this.bt_Anfangskapitalberechnen.CheckedChanged += new System.EventHandler(this.bt_Anfangskapitalberechnen_CheckedChanged);
            // 
            // lbl_Wassollberechnetwerden
            // 
            this.lbl_Wassollberechnetwerden.AutoSize = true;
            this.lbl_Wassollberechnetwerden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Wassollberechnetwerden.Location = new System.Drawing.Point(347, 9);
            this.lbl_Wassollberechnetwerden.Name = "lbl_Wassollberechnetwerden";
            this.lbl_Wassollberechnetwerden.Size = new System.Drawing.Size(276, 24);
            this.lbl_Wassollberechnetwerden.TabIndex = 9;
            this.lbl_Wassollberechnetwerden.Text = "Was soll berechnet werden?";
            // 
            // bt_Zinssatz
            // 
            this.bt_Zinssatz.AutoSize = true;
            this.bt_Zinssatz.Location = new System.Drawing.Point(351, 80);
            this.bt_Zinssatz.Name = "bt_Zinssatz";
            this.bt_Zinssatz.Size = new System.Drawing.Size(118, 17);
            this.bt_Zinssatz.TabIndex = 10;
            this.bt_Zinssatz.TabStop = true;
            this.bt_Zinssatz.Text = "Zinssatz berechnen";
            this.bt_Zinssatz.UseVisualStyleBackColor = true;
            this.bt_Zinssatz.CheckedChanged += new System.EventHandler(this.bt_Zinssatz_CheckedChanged);
            // 
            // bt_Laufzeit
            // 
            this.bt_Laufzeit.AutoSize = true;
            this.bt_Laufzeit.Location = new System.Drawing.Point(351, 107);
            this.bt_Laufzeit.Name = "bt_Laufzeit";
            this.bt_Laufzeit.Size = new System.Drawing.Size(116, 17);
            this.bt_Laufzeit.TabIndex = 11;
            this.bt_Laufzeit.TabStop = true;
            this.bt_Laufzeit.Text = "Laufzeit berechnen";
            this.bt_Laufzeit.UseVisualStyleBackColor = true;
            this.bt_Laufzeit.CheckedChanged += new System.EventHandler(this.bt_Laufzeit_CheckedChanged);
            // 
            // bt_Endkapital
            // 
            this.bt_Endkapital.AutoSize = true;
            this.bt_Endkapital.Location = new System.Drawing.Point(351, 133);
            this.bt_Endkapital.Name = "bt_Endkapital";
            this.bt_Endkapital.Size = new System.Drawing.Size(129, 17);
            this.bt_Endkapital.TabIndex = 12;
            this.bt_Endkapital.TabStop = true;
            this.bt_Endkapital.Text = "Endkapital berechnen";
            this.bt_Endkapital.UseVisualStyleBackColor = true;
            this.bt_Endkapital.CheckedChanged += new System.EventHandler(this.bt_Endkapital_CheckedChanged);
            // 
            // bt_Berechnen
            // 
            this.bt_Berechnen.Location = new System.Drawing.Point(25, 219);
            this.bt_Berechnen.Name = "bt_Berechnen";
            this.bt_Berechnen.Size = new System.Drawing.Size(75, 23);
            this.bt_Berechnen.TabIndex = 13;
            this.bt_Berechnen.Text = "Berechnen";
            this.bt_Berechnen.UseVisualStyleBackColor = true;
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(119, 219);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(75, 23);
            this.bt_reset.TabIndex = 14;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_Berechnen);
            this.Controls.Add(this.bt_Endkapital);
            this.Controls.Add(this.bt_Laufzeit);
            this.Controls.Add(this.bt_Zinssatz);
            this.Controls.Add(this.lbl_Wassollberechnetwerden);
            this.Controls.Add(this.bt_Anfangskapitalberechnen);
            this.Controls.Add(this.txt_Endkapital);
            this.Controls.Add(this.txt_Laufzeit);
            this.Controls.Add(this.txt_Zinssatz);
            this.Controls.Add(this.txt_Anfangskapital);
            this.Controls.Add(this.lbl_Endkapital);
            this.Controls.Add(this.lbl_Laufzeit);
            this.Controls.Add(this.lbl_Zinssatz);
            this.Controls.Add(this.lbl_Anfangskapital);
            this.Name = "Form1";
            this.Text = "Zinsrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Anfangskapital;
        private System.Windows.Forms.Label lbl_Zinssatz;
        private System.Windows.Forms.Label lbl_Laufzeit;
        private System.Windows.Forms.Label lbl_Endkapital;
        private System.Windows.Forms.TextBox txt_Anfangskapital;
        private System.Windows.Forms.TextBox txt_Zinssatz;
        private System.Windows.Forms.TextBox txt_Laufzeit;
        private System.Windows.Forms.TextBox txt_Endkapital;
        private System.Windows.Forms.RadioButton bt_Anfangskapitalberechnen;
        private System.Windows.Forms.Label lbl_Wassollberechnetwerden;
        private System.Windows.Forms.RadioButton bt_Zinssatz;
        private System.Windows.Forms.RadioButton bt_Laufzeit;
        private System.Windows.Forms.RadioButton bt_Endkapital;
        private System.Windows.Forms.Button bt_Berechnen;
        private System.Windows.Forms.Button bt_reset;
    }
}

