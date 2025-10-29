using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Zadanie_3
{
    public partial class Form : System.Windows.Forms.Form
    {
        private List<Vessels> typeVessel;
        private List<Concentration> typeConcen;

        // pola pomocnicze dla efektów
        private Timer fadeTimer;
        private Color actButOriginalBack;
        private Color buttclearOriginalBack;

        public Form()
        {
            InitializeComponent();

            // ustawienie początkowej przezroczystości dla fade-in
            Opacity = 0.0;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            typeData();
            ComboBoxs();

            // start fade-in
            StartFadeIn();


            headerPanel.Paint += HeaderPanel_Paint;


            actButOriginalBack = actBut.BackColor;
            buttclearOriginalBack = buttclear.BackColor;

            actBut.MouseEnter += Button_MouseEnter;
            actBut.MouseLeave += Button_MouseLeave;
            buttclear.MouseEnter += Button_MouseEnter;
            buttclear.MouseLeave += Button_MouseLeave;

        }

        private void typeData()
        {
            typeVessel = new List<Vessels>
            {
                new Vessels { Name = "Kieliszek", Capacity = 0.050 },
                new Vessels { Name = "Szklanka", Capacity = 0.250 },
                new Vessels { Name = "Butelka 0.5L", Capacity = 0.500 },
                new Vessels { Name = "Butelka 1L", Capacity = 1.000 },
                new Vessels { Name = "Kanister", Capacity = 5.000 }
            };

            typeConcen = new List<Concentration>
            {
                new Concentration { Name = "Woda utleniona", ConcentrationPercent = 3.0 },
                new Concentration { Name = "Ocet spirytusowy", ConcentrationPercent = 10.0 },
                new Concentration { Name = "Napój owocowy", ConcentrationPercent = 20.0 },
                new Concentration { Name = "Płyn do spryskiwaczy", ConcentrationPercent = 30.0 },
                new Concentration { Name = "Wódka", ConcentrationPercent = 40.0 },
                new Concentration { Name = "Spirytus salicylowy", ConcentrationPercent = 70.0  }
            };
        }

        private void capacityBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void actBut_Click(object sender, EventArgs e)
        {
            Operation();
        }

        private void solutionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VassalCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var now = VassalCB.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(now) || now == "Wybierz") return;

            Vessels selectvessal = typeVessel.Find(n => n.Name == now);
            if (selectvessal != null)
            {
                capacityBox.Text = selectvessal.Capacity.ToString();
            }
        }

        private void ComboBoxs()
        {
            VassalCB.Items.Clear();
            cocenCB.Items.Clear();

            VassalCB.Items.Add("Wybierz");
            cocenCB.Items.Add("Wybierz");

            foreach (var vassals in typeVessel)
            {
                VassalCB.Items.Add(vassals.Name);
            }
            foreach (var cocen in typeConcen)
            {
                cocenCB.Items.Add(cocen.Name);
            }

            VassalCB.SelectedIndex = 0;
            cocenCB.SelectedIndex = 0;
        }

        private void cocenCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var now = cocenCB.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(now) || now == "Wybierz") return;

            Concentration selectconcen = typeConcen.Find(r => r.Name == now);
            if (selectconcen != null)
            {
                concentrationBox.Text = selectconcen.ConcentrationPercent.ToString();
            }
        }

        private void concentrationBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stacksBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void solutionBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            capacityBox.Text = "";
            concentrationBox.Text = "";
            stacksBox.Text = "1";
            VassalCB.SelectedIndex = 0;
            cocenCB.SelectedIndex = 0;
            solutionBox.Text = "0.00 L";
            solutionBox2.Text = "0.00 L";
        }

        public void Operation()
        {
            double capacity, concen;
            int stacks;

            bool capacityWal = double.TryParse(capacityBox.Text, out capacity);
            bool concenWal = double.TryParse(concentrationBox.Text, out concen);
            bool stacksWal = int.TryParse(stacksBox.Text, out stacks);

            //Waliddacja w razie podania złych pól
            if (!capacityWal || !concenWal || !stacksWal)
            {
                MessageBox.Show("Proszę podać prawidłowe wartości liczbowe w okienkach!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Walidacja programu
            if (capacity < 0 || concen < 0 || concen > 100 || stacks <= 0)
            {
                solutionBox.Text = "Poza zakresem";
                MessageBox.Show("Dane poza podanym zakresem!\nPojemność nie może być ujemne, a stężnie musi być w zakrsie 0-100%!\nLiczba naczyń musi być dodatnia!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //obliczanie lacznej objetosci plynow w naczyniach
            double suma2 = stacks * capacity;

            //Zmienna przechowująca stężenie jako procent 
            double concenU = concen / 100;

            //Obliczenie
            double wynik = suma2 * concenU;

            //Wyświetlenie wyniku
            //Dla łacznej objetosci plynu
            solutionBox2.Text = suma2.ToString("F2") + " L";
            //Dla czystej substancji
            solutionBox.Text = wynik.ToString("F2") + " L";
        }

        // ==========================
        // Efekty UI - implementacja
        // ==========================

        private void StartFadeIn()
        {
            if (fadeTimer != null) return;
            fadeTimer = new Timer();
            fadeTimer.Interval = 20;
            fadeTimer.Tick += FadeTimer_Tick;
            fadeTimer.Start();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            Opacity += 0.04;
            if (Opacity >= 1.0)
            {
                Opacity = 1.0;
                fadeTimer.Stop();
                fadeTimer.Tick -= FadeTimer_Tick;
                fadeTimer = null;
            }
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {
           
            var panel = sender as Panel;
            if (panel == null) return;

            using (var lg = new LinearGradientBrush(panel.ClientRectangle,
                                                     Color.FromArgb(45, 120, 230),
                                                     Color.FromArgb(70, 150, 250),
                                                     LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(lg, panel.ClientRectangle);
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            
            btn.BackColor = ControlPaint.Light(btn.BackColor, 0.15f);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            
            if (btn == actBut) btn.BackColor = actButOriginalBack;
            else if (btn == buttclear) btn.BackColor = buttclearOriginalBack;
            else btn.BackColor = SystemColors.Control;
        }


    }

}
