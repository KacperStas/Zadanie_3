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
        private List<Vessels> typeVessel;
        private List<Concentration> typeConcen;
        public Form()
        {
            InitializeComponent();
        }

      
       
        private void Form_Load(object sender, EventArgs e)
        {
            typeData();
            ComboBoxs();
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
            double capacity, concen;
            int stacks;

            bool capacityWal = double.TryParse(capacityBox.Text, out capacity);
            bool concenWal = double.TryParse(concentrationBox.Text, out concen);
            bool stacksWal = int.TryParse(stacksBox.Text, out stacks);

            //Walidacja programu
            if (capacity < 0 || concen < 0 || concen > 100)
            {
                solutionBox.Text = "Poza zakresem";
                MessageBox.Show("Pojemność nie może być ujemne, a stężnie musi być w zakrsie 0-100%!", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void VassalCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string now = VassalCB.SelectedItem.ToString();
            Vessels selectvessal = typeVessel.Find(n => n.Name == now);
            if (selectvessal != null)
            {
                capacityBox.Text = selectvessal.Capacity.ToString();
            }
        }

        private void ComboBoxs()
        {
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
            string now = cocenCB.SelectedItem.ToString();
            Concentration selectconcen = typeConcen.Find(r => r.Name == now);
            if (selectconcen != null)
            {
                capacityBox.Text = selectconcen.ConcentrationPercent.ToString();
            }
        }

        private void concentrationBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stacksBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Vessels
    {
        public string Name { get; set; }
        public double Capacity { get; set; }
    }

    public class Concentration
    {
        public string Name { get; set; }
        public double ConcentrationPercent { get; set; }
    }
}
