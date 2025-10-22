using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_3
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void capacityBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void actBut_Click(object sender, EventArgs e)
        {
            string capacityText = capacityBox.Text;
            string concetText = concentrationBox.Text;

            double capacity = double.Parse(capacityText);
            double concen = double.Parse(concetText);


            //Walidacja programu
            if (capacity < 0 || concen < 0 || concen > 100)
            {
                solutionBox.Text = "Poza zakresem";
                MessageBox.Show("Pojemność nie może być ujemne, a stężnie musi być w zakrsie 0-100%!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Zmienna przechowująca stężenie jako procent 
            double concenU = concen / 100;

            //Obliczenie
            double wynik = capacity * concenU;

            //Wyświetlenie wyniku
            solutionBox.Text = wynik.ToString("F2") + "L";
        }

        private void solutionBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}