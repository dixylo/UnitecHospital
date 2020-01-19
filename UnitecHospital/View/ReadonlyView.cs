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
    public partial class ReadonlyView : Form
    {
        private ViewController viewController;
        private PersonType personType;
        List<string> subtable;

        private static ReadonlyView _instance;
        public static ReadonlyView GetInstance()
        {
            if (_instance == null)
                _instance = new ReadonlyView();
            return _instance;
        }

        public ReadonlyView()
        {
            InitializeComponent();
            viewController = ViewController.GetInstance();

            cmbPersonType.DataSource = Enum.GetValues(typeof(PersonType));
            subtable = new List<string>();

            // Complete necessary settings for a list view that display the person list
            // Set the view to show details.
            lstGraphicView.View = View.Details;
            // Select the person when selection is made.
            lstGraphicView.FullRowSelect = true;
            // Multiselection not allowed.
            lstGraphicView.MultiSelect = false;
            // Let the person remain highlighted when the control loses focus.
            lstGraphicView.HideSelection = false;

            lstGraphicView.View = View.LargeIcon;
            imageList.ImageSize = new Size(48, 48);
            lstGraphicView.LargeImageList = imageList;

            ttpReturn.SetToolTip(btnReturn, "Back to the main form");           
        }

        private void ReadonlyView_Activated(object sender, EventArgs e)
        {
            // Update the list view
            showList();
        }

        public void showList()
        {
            lstGraphicView.Items.Clear();
            imageList.Images.Clear();
            if (subtable != null)
            {
                subtable.Clear();
            }

            string[,] table;
            switch (personType)
            {
                case PersonType.Patient:
                    table = viewController.getPatientList();
                    break;
                case PersonType.Doctor:
                    table = viewController.getDoctorList();
                    break;
                case PersonType.Nurse:
                    table = viewController.getNurseList();
                    break;
                default:
                    table = viewController.getList();
                    break;
            }
  
            int count = table.GetLength(0);
            for (int i = 0; i < count; i++)
            {
                imageList.Images.Add(Image.FromFile(table[i, 6]));
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Name = table[i, 1];
                item.Text = "ID: " + table[i, 0] + "\n" + table[i, 2] + "\n" + table[i, 3];
                lstGraphicView.Items.Add(item);
                string subtableItem = "";
                for (int j = 0; j < 6; j++)
                {
                    subtableItem += table[i, j] + " ";
                }
                if (subtable != null)
                {
                    subtable.Add(subtableItem);
                }               
            }
        }        

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbPersonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(cmbPersonType.Text, out personType);
            if (personType != PersonType.Patient)
            {
                txtDoctor.Text = "";
                txtNurse.Text = "";
            }
            showList();
        }

        private void lstGraphicView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGraphicView.SelectedIndices.Count != 0) // ensures that at least one person is selected
            {
                int selectedIndex = lstGraphicView.SelectedIndices[0];
                string[] fields = subtable[selectedIndex].Split(' ');
                cmbPersonType.Text = fields[1];
                txtFirstName.Text = fields[2];
                txtLastName.Text = fields[3];

                if (personType == PersonType.Patient)
                {
                    txtDoctor.Text = fields[5];
                    txtNurse.Text = fields[6];
                }
                else
                {
                    txtStaffType.Text = fields[4];
                }
            }
        }

        private void ReadonlyView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
