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
    public partial class MainForm : Form
    {
        private TextView textView;
        private GraphicView graphicView;
        private ReadonlyView readonlyView;
        private ViewController viewController;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            viewController = ViewController.GetInstance();                                 
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            viewController.loadList();
        }

        private void btnTextView_Click(object sender, EventArgs e)
        {
            if (textView == null)
            {
                textView = TextView.GetInstance();
            }
            textView.Show();
        }

        private void btnGraphicView_Click(object sender, EventArgs e)
        {
            if (graphicView == null)
            {                
                graphicView = GraphicView.GetInstance();
            }
            graphicView.Show();
        }

        private void btnReadonlyView_Click(object sender, EventArgs e)
        {
            if (readonlyView == null)
            {
                readonlyView = ReadonlyView.GetInstance();
            }
            readonlyView.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {            
            // Check that the click on this button is intentional
            if (MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close(); // Exit the application
            }
        }

        
    }
}
