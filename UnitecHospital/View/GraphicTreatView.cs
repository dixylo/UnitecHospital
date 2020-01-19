using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitecHospital
{
    public partial class GraphicTreatView : Form
    {
        private TextView textView;
        private GraphicView graphicView;
        private ReadonlyView readonlyView;
        private ViewController viewController;
        private int selectedIndex;

        public GraphicTreatView(GraphicView graphicView, int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
            viewController = ViewController.GetInstance();
            textView = TextView.GetInstance();
            this.graphicView = graphicView;
            readonlyView = ReadonlyView.GetInstance();
        }

        private void GraphicTreatView_Load(object sender, EventArgs e)
        {
            string[,] table = viewController.getList();
            lblDoctor.Text = table[selectedIndex, 4];
            lblNurse.Text = table[selectedIndex, 5];
            lblPatient.Text = table[selectedIndex, 2];

            State state = viewController.getPatientState(selectedIndex);

            switch (state)
            {
                case State.Undiagosed:
                    pbxDoctor.Image = Image.FromFile(@"..\..\assets\doctor.png");
                    pbxNurse.Image = Image.FromFile(@"..\..\assets\nurse.png");
                    pbxPatient.Image = Image.FromFile(@"..\..\assets\patient.png");
                    break;
                case State.Diagosed:
                    pbxDoctor.Image = Image.FromFile(@"..\..\assets\diagnosing.png");
                    pbxNurse.Image = Image.FromFile(@"..\..\assets\nurse.png");
                    pbxPatient.Image = Image.FromFile(@"..\..\assets\diagnosed.png");
                    break;
                case State.Cared:
                    pbxDoctor.Image = Image.FromFile(@"..\..\assets\diagnosing.png");
                    pbxNurse.Image = Image.FromFile(@"..\..\assets\nursing.png");
                    pbxPatient.Image = Image.FromFile(@"..\..\assets\cared.png");
                    break;
                default:
                    pbxDoctor.Image = Image.FromFile(@"..\..\assets\diagnosing.png");
                    pbxNurse.Image = Image.FromFile(@"..\..\assets\nursing.png");
                    pbxPatient.Image = Image.FromFile(@"..\..\assets\recovered.png");
                    break;
            }
        }

        private void diagnoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewController.getPatientState(selectedIndex) == State.Undiagosed)
            {
                viewController.updatePatientState(selectedIndex, State.Diagosed);
                textView.showList();
                graphicView.showList();
                readonlyView.showList();
                pbxDoctor.Image = Image.FromFile(@"..\..\assets\diagnosing.png");
                pbxPatient.Image = Image.FromFile(@"..\..\assets\diagnosed.png");
            }
            else
            {
                MessageBox.Show("This patient has already been diagnosed!");
            }           
        }       

        private void careToolStripMenuItem_Click(object sender, EventArgs e)
        {
            State state = viewController.getPatientState(selectedIndex);

            if (state == State.Undiagosed)
            {
                MessageBox.Show("This patient needs to be diagnosed first before being cared!");
            }
            else if (state == State.Diagosed)
            {
                viewController.updatePatientState(selectedIndex, State.Cared);
                textView.showList();
                graphicView.showList();
                readonlyView.showList();
                pbxNurse.Image = Image.FromFile(@"..\..\assets\nursing.png");
                pbxPatient.Image = Image.FromFile(@"..\..\assets\cared.png");
            }
            else
            {
                MessageBox.Show("This patient has already been cared!");
            }            
        }

        private void recoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            State state = viewController.getPatientState(selectedIndex);

            if (state == State.Undiagosed)
            {
                MessageBox.Show("This patient needs to be diagnosed!");
            }
            else if (state == State.Diagosed)
            {
                MessageBox.Show("This patient needs to be cared!");
            }
            else if (state == State.Cared)
            {
                viewController.updatePatientState(selectedIndex, State.Recovered);
                textView.showList();
                graphicView.showList();
                readonlyView.showList();
                pbxPatient.Image = Image.FromFile(@"..\..\assets\recovered.png");
            }
            else
            {
                MessageBox.Show("This patient has already recovered!");
            }           
        }

        private void exitTreatmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
