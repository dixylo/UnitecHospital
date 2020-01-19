using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitecHospital
{
    public partial class GraphicView : Form
    {
        private ViewController viewController;
        private PersonType personType;
        private GraphicTreatView graphicTreatView;
        private TextView textView;
        private ReadonlyView readonlyView;

        private static GraphicView _instance;
        public static GraphicView GetInstance()
        {
            if (_instance == null)
                _instance = new GraphicView();
            return _instance;
        }

        public GraphicView()
        {
            InitializeComponent();
            viewController = ViewController.GetInstance();
                        
            cmbStaffType.Visible = false;
            lblStaffType.Visible = false;
            cmbPersonType.DataSource = Enum.GetValues(typeof(PersonType));

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

            ttpCreate.SetToolTip(btnCreate, "Add a new person");
            ttpUpdate.SetToolTip(btnUpdate, "Modify a person");
            ttpSave.SetToolTip(btnSave, "Save the present list");
            ttpTreat.SetToolTip(btnTreat, "Start treating a patient");
            ttpDelete.SetToolTip(btnDelete, "Remove a person");
            ttpReturn.SetToolTip(btnReturn, "Back to the main form");            
        }

        private void GraphicView_Activated(object sender, EventArgs e)
        {
            textView = TextView.GetInstance();
            readonlyView = ReadonlyView.GetInstance();
            loadComboboxes(personType);
            showList();
        }

        public void showList()
        {
            lstGraphicView.Items.Clear();
            imageList.Images.Clear();

            string[,] table = viewController.getList();
            int count = viewController.getCount();
            for (int i = 0; i < count; i++)
            {
                imageList.Images.Add(Image.FromFile(table[i, 6]));
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Name = table[i, 1];
                item.Text = "ID: " + table[i, 0] + "\n" + table[i, 2] + "\n" + table[i, 3];
                lstGraphicView.Items.Add(item);
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
            textView.showList();
            readonlyView.showList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstGraphicView.SelectedIndices.Count == 0) // ensures that at least one person is selected
            {
                MessageBox.Show("You must select an person to update!");
            }
            else if (personType.ToString() != lstGraphicView.SelectedItems[0].Name)
            {
                MessageBox.Show("You may not change the person type! You can add a new person instead.");
            }
            else
            {
                int selectedIndex = lstGraphicView.SelectedIndices[0];

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
                textView.showList();
                readonlyView.showList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            viewController.saveList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstGraphicView.SelectedIndices.Count == 0) // warns if no person is selected
            {
                MessageBox.Show("You must select an person to delete!", "Error");
            }
            else
            {
                int selectedIndex = lstGraphicView.SelectedIndices[0];
                if (MessageBox.Show("Are you sure you want to delete this person?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {                    
                    if (viewController.removePerson(selectedIndex))
                    {
                        this.showList(); // updates the list view
                        textView.showList();
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
            if (lstGraphicView.SelectedIndices.Count == 0 || lstGraphicView.SelectedItems[0].Name != "Patient") // warns if no person is selected
            {
                MessageBox.Show("You must select a patient to treat!", "Error");
            }
            else if (lstGraphicView.SelectedItems[0].Text.Contains("Recovered"))
            {
                MessageBox.Show("This patient has recovered!", "Error");
            }
            else
            {
                graphicTreatView = new GraphicTreatView(this, lstGraphicView.SelectedIndices[0]);
                graphicTreatView.ShowDialog();
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

        private void lstGraphicView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGraphicView.SelectedIndices.Count != 0) // ensures that at least one person is selected
            {
                int selectedIndex = lstGraphicView.SelectedIndices[0];
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

        private void GraphicView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
