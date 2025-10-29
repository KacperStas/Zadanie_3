namespace Zadanie_3
{
    partial class Form
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.hellnuh = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.capacityBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.concentrationBox = new System.Windows.Forms.TextBox();
            this.percLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.solutionBox = new System.Windows.Forms.TextBox();
            this.actBut = new System.Windows.Forms.Button();
            this.footerLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.VassalCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cocenCB = new System.Windows.Forms.ComboBox();
            this.stacksBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.solutionBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttclear = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(120)))), ((int)(((byte)(230)))));
            this.headerPanel.Controls.Add(this.hellnuh);
            this.headerPanel.Controls.Add(this.subtitleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 90);
            this.headerPanel.TabIndex = 0;
            // 
            // hellnuh
            // 
            this.hellnuh.AutoSize = true;
            this.hellnuh.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.hellnuh.ForeColor = System.Drawing.Color.White;
            this.hellnuh.Location = new System.Drawing.Point(18, 9);
            this.hellnuh.Name = "hellnuh";
            this.hellnuh.Size = new System.Drawing.Size(301, 41);
            this.hellnuh.TabIndex = 0;
            this.hellnuh.Text = "Kalkulator Procentowy";
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.subtitleLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.subtitleLabel.Location = new System.Drawing.Point(20, 50);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(318, 20);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.Text = "Oblicz ilość substancji (w litrach) dla zadanego %";
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.mainLayout.Controls.Add(this.leftPanel, 0, 0);
            this.mainLayout.Controls.Add(this.rightPanel, 1, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 90);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Padding = new System.Windows.Forms.Padding(20);
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(800, 360);
            this.mainLayout.TabIndex = 1;

            // podstawowe pola (pojemność, stężenie)
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.capacityBox);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.concentrationBox);
            this.leftPanel.Controls.Add(this.percLabel);
            // pola wyboru (typ naczynia, typ roztworu, liczba sztuk)
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.VassalCB);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.cocenCB);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.stacksBox);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(23, 23);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(367, 314);
            this.leftPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pojemność naczynia (w litrach)";
            // 
            // capacityBox
            // 
            this.capacityBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.capacityBox.Location = new System.Drawing.Point(16, 44);
            this.capacityBox.Name = "capacityBox";
            this.capacityBox.Size = new System.Drawing.Size(160, 30);
            this.capacityBox.TabIndex = 1;
            this.capacityBox.TextChanged += new System.EventHandler(this.capacityBox_TextChanged);
            this.toolTip.SetToolTip(this.capacityBox, "Wprowadź pojemność w litrach, np. 2.5");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stężenie substancji (%)";
            // 
            // concentrationBox
            // 
            this.concentrationBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.concentrationBox.Location = new System.Drawing.Point(16, 125);
            this.concentrationBox.Name = "concentrationBox";
            this.concentrationBox.Size = new System.Drawing.Size(120, 30);
            this.concentrationBox.TabIndex = 3;
            this.toolTip.SetToolTip(this.concentrationBox, "Wprowadź procentowy udział, np. 12.5");
            // 
            // percLabel
            // 
            this.percLabel.AutoSize = true;
            this.percLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.percLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(120)))), ((int)(((byte)(230)))));
            this.percLabel.Location = new System.Drawing.Point(142, 128);
            this.percLabel.Name = "percLabel";
            this.percLabel.Size = new System.Drawing.Size(26, 23);
            this.percLabel.TabIndex = 8;
            this.percLabel.Text = "%";
            // 
            // label4 (Typ naczynia)
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Typ naczynia";
            // 
            // VassalCB
            // 
            this.VassalCB.FormattingEnabled = true;
            this.VassalCB.Location = new System.Drawing.Point(16, 200);
            this.VassalCB.Name = "VassalCB";
            this.VassalCB.Size = new System.Drawing.Size(160, 24);
            this.VassalCB.TabIndex = 8;
            this.VassalCB.SelectedIndexChanged += new System.EventHandler(this.VassalCB_SelectedIndexChanged);
            // 
            // label5 (Typ roztworu)
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(200, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Typ roztworu";
            // 
            // cocenCB
            // 
            this.cocenCB.FormattingEnabled = true;
            this.cocenCB.Location = new System.Drawing.Point(200, 200);
            this.cocenCB.Name = "cocenCB";
            this.cocenCB.Size = new System.Drawing.Size(150, 24);
            this.cocenCB.TabIndex = 10;
            this.cocenCB.SelectedIndexChanged += new System.EventHandler(this.cocenCB_SelectedIndexChanged);
            // 
            // label6 (Liczba sztuk)
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(12, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Liczba Sztuk";
            // 
            // stacksBox
            // 
            this.stacksBox.Location = new System.Drawing.Point(16, 270);
            this.stacksBox.Name = "stacksBox";
            this.stacksBox.Size = new System.Drawing.Size(100, 22);
            this.stacksBox.TabIndex = 12;
            this.stacksBox.Text = "1";
            this.stacksBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.stacksBox.TextChanged += new System.EventHandler(this.stacksBox_TextChanged);
            // 
            // rightPanel
            // 
            // Wyniki i przyciski akcji
            this.rightPanel.Controls.Add(this.label3);
            this.rightPanel.Controls.Add(this.solutionBox2);
            this.rightPanel.Controls.Add(this.label7);
            this.rightPanel.Controls.Add(this.solutionBox);
            this.rightPanel.Controls.Add(this.actBut);
            this.rightPanel.Controls.Add(this.buttclear);
            this.rightPanel.Controls.Add(this.footerLabel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(405, 23);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(372, 314);
            this.rightPanel.TabIndex = 1;
            // 
            // label3 (Wynik: objętość w naczyniach)
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wynik (Objętość w naczyniach)";
            // 
            // solutionBox2 (łączna objętość płynów)
            // 
            this.solutionBox2.Location = new System.Drawing.Point(16, 44);
            this.solutionBox2.Name = "solutionBox2";
            this.solutionBox2.ReadOnly = true;
            this.solutionBox2.Size = new System.Drawing.Size(120, 22);
            this.solutionBox2.TabIndex = 14;
            // 
            // label7 (Wynik: czysta substancja)
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(12, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Wynik (Czysta substancja)";
            // 
            // solutionBox (czysta substancja)
            // 
            this.solutionBox.Location = new System.Drawing.Point(16, 114);
            this.solutionBox.Name = "solutionBox";
            this.solutionBox.ReadOnly = true;
            this.solutionBox.Size = new System.Drawing.Size(120, 22);
            this.solutionBox.TabIndex = 5;
            this.solutionBox.TextChanged += new System.EventHandler(this.solutionBox_TextChanged);
            // 
            // actBut
            // 
            this.actBut.Location = new System.Drawing.Point(16, 160);
            this.actBut.Name = "actBut";
            this.actBut.Size = new System.Drawing.Size(106, 42);
            this.actBut.TabIndex = 7;
            this.actBut.Text = "Oblicz";
            this.actBut.UseVisualStyleBackColor = true;
            this.actBut.Click += new System.EventHandler(this.actBut_Click);
            // 
            // buttclear
            // 
            this.buttclear.Location = new System.Drawing.Point(140, 160);
            this.buttclear.Name = "buttclear";
            this.buttclear.Size = new System.Drawing.Size(106, 42);
            this.buttclear.TabIndex = 16;
            this.buttclear.Text = "Clear";
            this.buttclear.UseVisualStyleBackColor = true;
            this.buttclear.Click += new System.EventHandler(this.button1_Click);
            // 
            // footerLabel (miejsce na ewentualne informacje)
            // 
            this.footerLabel.AutoSize = true;
            this.footerLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.footerLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.footerLabel.Location = new System.Drawing.Point(12, 230);
            this.footerLabel.Name = "footerLabel";
            this.footerLabel.Size = new System.Drawing.Size(0, 19);
            this.footerLabel.TabIndex = 17;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            //headerPanel i mainLayout.
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.headerPanel);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label hellnuh;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox capacityBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox concentrationBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox solutionBox;
        private System.Windows.Forms.Button actBut;
        private System.Windows.Forms.Label percLabel;
        private System.Windows.Forms.Label footerLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox VassalCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cocenCB;
        private System.Windows.Forms.TextBox stacksBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox solutionBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttclear;
    }
}
