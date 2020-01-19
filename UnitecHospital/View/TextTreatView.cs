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
    public partial class TextTreatView : Form
    {
        private TextView textView;
        private GraphicView graphicView;
        private ReadonlyView readonlyView;
        private ViewController viewController;
        private int selectedIndex;

        public TextTreatView(TextView textView, GraphicView graphicView, int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
            viewController = ViewController.GetInstance();
            this.textView = textView;
            this.graphicView = graphicView;
            readonlyView = ReadonlyView.GetInstance();
        }

        private void TreatView_Load(object sender, EventArgs e)
        {
            string[,] table = viewController.getList();
            lblDoctor.Text = "Doctor: " + table[selectedIndex, 4];
            lblNurse.Text = "Nurse: " + table[selectedIndex, 5];
            lblPatient.Text = "Patient: " + table[selectedIndex, 2];

            State state = viewController.getPatientState(selectedIndex);

            switch (state)
            {
                case State.Undiagosed:
                    btnDiagnose.Enabled = true;
                    btnCare.Enabled = false;
                    btnRecover.Enabled = false;
                    break;
                case State.Diagosed:
                    btnDiagnose.Enabled = false;
                    btnCare.Enabled = true;
                    btnRecover.Enabled = false;
                    break;
                case State.Cared:
                    btnDiagnose.Enabled = false;
                    btnCare.Enabled = false;
                    btnRecover.Enabled = true;
                    break;
                default:
                    btnDiagnose.Enabled = false;
                    btnCare.Enabled = false;
                    btnRecover.Enabled = false;
                    break;
            }
        }

        private void btnDiagnose_Click(object sender, EventArgs e)
        {
            viewController.updatePatientState(selectedIndex, State.Diagosed);
            textView.showList();
            graphicView.showList();
            readonlyView.showList();
            btnDiagnose.Enabled = false;
            btnCare.Enabled = true;
        }

        private void btnCare_Click(object sender, EventArgs e)
        {
            viewController.updatePatientState(selectedIndex, State.Cared);
            textView.showList();
            graphicView.showList();
            readonlyView.showList();
            btnCare.Enabled = false;
            btnRecover.Enabled = true;
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            viewController.updatePatientState(selectedIndex, State.Recovered);
            textView.showList();
            graphicView.showList();
            readonlyView.showList();
            Close();
        }       
    }
}
