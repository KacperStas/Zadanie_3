namespace Zadanie_3
{
    partial class Form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.hellnuh = new System.Windows.Forms.Label();
            this.capacityBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.concentrationBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.solutionBox = new System.Windows.Forms.TextBox();
            this.actBut = new System.Windows.Forms.Button();
            this.VassalCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cocenCB = new System.Windows.Forms.ComboBox();
            this.stacksBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hellnuh
            // 
            this.hellnuh.AutoSize = true;
            this.hellnuh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hellnuh.Location = new System.Drawing.Point(250, 67);
            this.hellnuh.Name = "hellnuh";
            this.hellnuh.Size = new System.Drawing.Size(265, 29);
            this.hellnuh.TabIndex = 0;
            this.hellnuh.Text = "Kalkulator Procentowy";
            this.hellnuh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // capacityBox
            // 
            this.capacityBox.Location = new System.Drawing.Point(88, 280);
            this.capacityBox.Name = "capacityBox";
            this.capacityBox.Size = new System.Drawing.Size(100, 22);
            this.capacityBox.TabIndex = 1;
            this.capacityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.capacityBox.TextChanged += new System.EventHandler(this.capacityBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(61, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pojemność naczynia";
            // 
            // concentrationBox
            // 
            this.concentrationBox.Location = new System.Drawing.Point(264, 280);
            this.concentrationBox.Name = "concentrationBox";
            this.concentrationBox.Size = new System.Drawing.Size(100, 22);
            this.concentrationBox.TabIndex = 3;
            this.concentrationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.concentrationBox.TextChanged += new System.EventHandler(this.concentrationBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(234, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stężenie Substancji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(611, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wynik";
            // 
            // solutionBox
            // 
            this.solutionBox.Location = new System.Drawing.Point(586, 187);
            this.solutionBox.Name = "solutionBox";
            this.solutionBox.Size = new System.Drawing.Size(100, 22);
            this.solutionBox.TabIndex = 5;
            this.solutionBox.TextChanged += new System.EventHandler(this.solutionBox_TextChanged);
            // 
            // actBut
            // 
            this.actBut.Location = new System.Drawing.Point(430, 231);
            this.actBut.Name = "actBut";
            this.actBut.Size = new System.Drawing.Size(106, 42);
            this.actBut.TabIndex = 7;
            this.actBut.Text = "Oblicz";
            this.actBut.UseVisualStyleBackColor = true;
            this.actBut.Click += new System.EventHandler(this.actBut_Click);
            // 
            // VassalCB
            // 
            this.VassalCB.FormattingEnabled = true;
            this.VassalCB.Location = new System.Drawing.Point(76, 182);
            this.VassalCB.Name = "VassalCB";
            this.VassalCB.Size = new System.Drawing.Size(121, 24);
            this.VassalCB.TabIndex = 8;
            this.VassalCB.SelectedIndexChanged += new System.EventHandler(this.VassalCB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(81, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Typ naczynia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(260, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Typ roztworu";
            // 
            // cocenCB
            // 
            this.cocenCB.FormattingEnabled = true;
            this.cocenCB.Location = new System.Drawing.Point(255, 182);
            this.cocenCB.Name = "cocenCB";
            this.cocenCB.Size = new System.Drawing.Size(121, 24);
            this.cocenCB.TabIndex = 10;
            this.cocenCB.SelectedIndexChanged += new System.EventHandler(this.cocenCB_SelectedIndexChanged);
            // 
            // stacksBox
            // 
            this.stacksBox.Location = new System.Drawing.Point(433, 184);
            this.stacksBox.Name = "stacksBox";
            this.stacksBox.Size = new System.Drawing.Size(100, 22);
            this.stacksBox.TabIndex = 12;
            this.stacksBox.Text = "1";
            this.stacksBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.stacksBox.TextChanged += new System.EventHandler(this.stacksBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(430, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Liczba Sztuk";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stacksBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cocenCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VassalCB);
            this.Controls.Add(this.actBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.solutionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.concentrationBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.capacityBox);
            this.Controls.Add(this.hellnuh);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hellnuh;
        private System.Windows.Forms.TextBox capacityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox concentrationBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox solutionBox;
        private System.Windows.Forms.Button actBut;
        private System.Windows.Forms.ComboBox VassalCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cocenCB;
        private System.Windows.Forms.TextBox stacksBox;
        private System.Windows.Forms.Label label6;
    }
}

