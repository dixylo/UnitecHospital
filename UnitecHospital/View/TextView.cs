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
    public partial class TextView : Form
    {
        private ViewController viewController;
        private PersonType personType;
        private TextTreatView textTreatView;
        private GraphicView graphicView;
        private ReadonlyView readonlyView;

        private static TextView _instance;
        public static TextView GetInstance()
        {
            if (_instance == null)
                _instance = new TextView();
            return _instance;
        }

        public TextView()
        {
            InitializeComponent();
            viewController = ViewController.GetInstance();
            
            cmbStaffType.Visible = false;
            lblStaffType.Visible = false;
            cmbPersonType.DataSource = Enum.GetValues(typeof(PersonType));
            
            // Complete necessary settings for a list view that display the person list
            // Set the view to show details.
            lstTextView.View = View.Details;
            // Select the person when selection is made.
            lstTextView.FullRowSelect = true;
            // Multiselection not allowed.
            lstTextView.MultiSelect = false;
            // Display grid lines.
            lstTextView.GridLines = true;
            // Let the person remain highlighted when the control loses focus.
            lstTextView.HideSelection = false;

            // Create columns for the persons.
            // Width of -2 indicates auto-size.
            lstTextView.Columns.Add("ID", 27, HorizontalAlignment.Left);
            lstTextView.Columns.Add("Type", 45, HorizontalAlignment.Left);
            lstTextView.Columns.Add("Name", 90, HorizontalAlignment.Left);
            lstTextView.Columns.Add("Note", 90, HorizontalAlignment.Left);
            lstTextView.Columns.Add("Doctor", 90, HorizontalAlignment.Left);
            lstTextView.Columns.Add("Nurse", -2, HorizontalAlignment.Left);            
        }

        private void TextView_Activated(object sender, EventArgs e)
        {
            graphicView = GraphicView.GetInstance();
            readonlyView = ReadonlyView.GetInstance();
            loadComboboxes(personType);
            showList();
        }

        public void showList()
        {
            lstTextView.Items.Clear(); // clear before load, to prevent duplication
            string[,] table = viewController.getList();
            int count = viewController.getCount();
            for (int i = 0; i < count; i++)
            {
                ListViewItem item = new ListViewItem(table[i, 0]); // creates a person starting with the ID
                // gets the rest of the detail of a person
                for (int j = 1; j < lstTextView.Columns.Count; j++)
                {
                    item.SubItems.Add(table[i, j]); // fills the rest of the detail line
                }
                lstTextView.Items.Add(item); // adds the person to the list view
            }
        }

        private void loadComboboxes(PersonType personType)
        {
            switch (personType)
            {
                case PersonType.Patient:

                    cmbStaffType.Visible = false;
                    lblStaffType.Visible = false;
                    cmbDoctor.Visible = true;
                    lblDoctor.Visible = true;
                    cmbNurse.Visible = true;
                    lblNurse.Visible = true;
                    if (cmbDoctor.Items.Count > 0)
                    {
                        cmbDoctor.Items.Clear();
                    }
                    foreach (string name in viewController.getDoctorNames())
                    {
                        cmbDoctor.Items.Add(name);
                    }
                    if (cmbNurse.Items.Count > 0)
                    {
                        cmbNurse.Items.Clear();
                    }
                    foreach (string name in viewController.getNurseNames())
                    {
                        cmbNurse.Items.Add(name);
                    }

                    break;

                case PersonType.Doctor:

                    cmbDoctor.Visible = false;
                    lblDoctor.Visible = false;
                    cmbNurse.Visible = false;
                    lblNurse.Visible = false;
                    cmbStaffType.Visible = true;
                    lblStaffType.Visible = true;
                    if (cmbStaffType.Items.Count > 0)
                    {
                        cmbStaffType.Items.Clear();
                    }
                    foreach (Specialty specialty in Enum.GetValues(typeof(Specialty)))
                    {
                        cmbStaffType.Items.Add(specialty.ToString());
                    }
                    break;

                case PersonType.Nurse:

                    cmbDoctor.Visible = false;
                    lblDoctor.Visible = false;
                    cmbNurse.Visible = false;
                    lblNurse.Visible = false;
                    cmbStaffType.Visible = true;
                    lblStaffType.Visible = true;
                    if (cmbStaffType.Items.Count > 0)
                    {
                        cmbStaffType.Items.Clear();
                    }
                    foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                    {
                        cmbStaffType.Items.Add(rank.ToString());
                    }
                    break;

                default:
                    MessageBox.Show("Error!");
                    break;
            }           
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            switch (personType)
            {
                case PersonType.Patient:

                    string doctorName = cmbDoctor.Text;
                    string nurseName = cmbNurse.Text;

                    if (firstName == "" || lastName == "" || doctorName == "" || nurseName == "")
                    {
                        MessageBox.Show("You must specify all the fields! You may need to add a doctor and a nurse first.");
                    }
                    else
                    {
                        // if not duplicate, add to list
                        if (viewController.isDuplicate(firstName, lastName, personType))
                        {
                            MessageBox.Show("This patient is already registered!");
                        }
                        else
                        {
                            viewController.addPatient(firstName, lastName, doctorName, nurseName);
                            MessageBox.Show("New Patient Added Successfully!");
                        }
                        
                    }
                    break;

                case PersonType.Doctor:

                    string strSpecialty = cmbStaffType.Text;
                    Enum.TryParse(strSpecialty, out Specialty specialty);

                    if (firstName == "" || lastName == "" || strSpecialty == "")
                    {
                        MessageBox.Show("You must specify all the fields for a doctor!");
                    }
                    else
                    {
                        // if not duplicate, add to list
                        if (viewController.isDuplicate(firstName, lastName, personType))
                        {
                            MessageBox.Show("This doctor is already registered!");
                        }
                        else
                        {
                            viewController.addDoctor(firstName, lastName, specialty);
                            MessageBox.Show("New Doctor Added Successfully!");
                        }
                        
                    }
                    break;

                case PersonType.Nurse:

                    string strRank = cmbStaffType.Text;
                    Enum.TryParse(strRank, out Rank rank);

                    if (firstName == "" || lastName == "" || strRank == "")
                    {
                        MessageBox.Show("You must specify all the fields for a nurse!");
                    }
                    else
                    {
                        // if not duplicate, add to list
                        if (viewController.isDuplicate(firstName, lastName, personType))
                        {
                            MessageBox.Show("This nurse is already registered!");
                        }
                        else
                        {
                            viewController.addNurse(firstName, lastName, rank);
                            MessageBox.Show("New Nurse Added Successfully!");
                        }
                        
                    }
                    break;

                default:
                    MessageBox.Show("You must specify the type of person first!");
                    break;
            }

            txtFirstName.Text = "";
            txtLastName.Text = "";
            this.showList();
            graphicView.showList();
            readonlyView.showList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {            
            if (lstTextView.SelectedIndices.Count == 0) // ensures that at least one person is selected
            {
                MessageBox.Show("You must select an person to update!");
            }
            else if (personType.ToString() != lstTextView.SelectedItems[0].SubItems[1].Text)
            {
                MessageBox.Show("You may not change the person type! You can add a new person instead.");
            }
            else
            {
                int selectedIndex = lstTextView.SelectedIndices[0];

                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;

                switch (personType)
                {
                    case PersonType.Patient:

                        string doctorName = cmbDoctor.Text;
                        string nurseName = cmbNurse.Text;

                        if (firstName == "" || lastName == "" || doctorName == "" || nurseName == "")
                        {
                            MessageBox.Show("You must specify all the fields!");
                        }
                        else
                        {
                            viewController.modifyPatient(selectedIndex, firstName, lastName, doctorName, nurseName);
                            MessageBox.Show("Patient modified Successfully!");
                        }
                        break;

                    case PersonType.Doctor:

                        string strSpecialty = cmbStaffType.Text;
                        Enum.TryParse(strSpecialty, out Specialty specialty);

                        if (firstName == "" || lastName == "" || strSpecialty == "")
                        {
                            MessageBox.Show("You must specify all the fields for a doctor!");
                        }
                        else
                        {
                            viewController.modifyDoctor(selectedIndex, firstName, lastName, specialty);
                            MessageBox.Show("Doctor modified Successfully!");
                        }
                        break;

                    case PersonType.Nurse:

                        string strRank = cmbStaffType.Text;
                        Enum.TryParse(strRank, out Rank rank);

                        if (firstName == "" || lastName == "" || strRank == "")
                        {
                            MessageBox.Show("You must specify all the fields for a nurse!");
                        }
                        else
                        {
                            viewController.modifyNurse(selectedIndex, firstName, lastName, rank);
                            MessageBox.Show("Nurse modified Successfully!");
                        }
                        break;

                    default:
                        MessageBox.Show("You must specify the type of person first!");
                        break;
                }

                this.showList();
                graphicView.showList();
                readonlyView.showList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            viewController.saveList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTextView.SelectedIndices.Count == 0) // warns if no person is selected
            {
                MessageBox.Show("You must select an person to delete!", "Error");
            }
            else
            {
                int selectedIndex = lstTextView.SelectedIndices[0];
                if (MessageBox.Show("Are you sure you want to delete this person?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (viewController.removePerson(selectedIndex))
                    {
                        this.showList(); // updates the list view
                        graphicView.showList();
                        readonlyView.showList();
                    }
                    else
                    {
                        MessageBox.Show("You cannot delete a doctor or a nurse who has a patient!", "Error");
                    }                   
                }
            }
        }

        private void btnTreat_Click(object sender, EventArgs e)
        {
            if (lstTextView.SelectedIndices.Count == 0 || lstTextView.SelectedItems[0].SubItems[1].Text != "Patient") // warns if no patient is selected
            {
                MessageBox.Show("You must select a patient to treat!", "Error");
            }
            else if (lstTextView.SelectedItems[0].SubItems[3].Text == "Recovered")
            {
                MessageBox.Show("This patient has recovered!", "Error");
            }
            else
            {
                textTreatView = new TextTreatView(this, graphicView, lstTextView.SelectedIndices[0]);
                textTreatView.ShowDialog();
            }           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbPersonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(cmbPersonType.Text, out personType);
            loadComboboxes(personType);
        }

        private void lstTextView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTextView.SelectedIndices.Count != 0) // ensures that at least one person is selected
            {
                int selectedIndex = lstTextView.SelectedIndices[0];
                string[,] table = viewController.getList();
                cmbPersonType.Text = table[selectedIndex, 1];
                string[] names = table[selectedIndex, 2].Split(' ');
                txtFirstName.Text = names[0];
                txtLastName.Text = names[1];

                Enum.TryParse(table[selectedIndex, 1], out personType);
                if (personType == PersonType.Patient)
                {
                    cmbDoctor.Text = table[selectedIndex, 4];
                    cmbNurse.Text = table[selectedIndex, 5];
                }
                else
                {
                    cmbStaffType.Text = table[selectedIndex, 3];
                }
            }
        }

        private void TextView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
