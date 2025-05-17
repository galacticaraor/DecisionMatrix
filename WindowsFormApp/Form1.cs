using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using ClassLibrary;
using DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System;
using Microsoft.VisualBasic.ApplicationServices;

namespace WindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.LoadForm("");
            details.ShowDialog();
        }

        private void btnEdit_Click(string uuid)
        {
            Details details = new Details();
            details.LoadForm(uuid);
            details.ShowDialog();
        }

        private void btnDelete_Click(string uuid)
        {
            //Display a confirmation of the delete
            var confirmResult = MessageBox.Show("Are you sure to delete this decision matrix?",
                                         "Confirm Delete!!",
                                         MessageBoxButtons.YesNo);

            //If the user clicked yes then
            if (confirmResult == DialogResult.Yes)
            {
                DecisionMatrixManager manager = new DecisionMatrixManager(new JsonStorage());
                FileResult fileResult = manager.Delete(uuid);
                if (fileResult.Successful)
                {
                    MessageBox.Show("Delete successful");
                    Search(txtKeyword.Text);
                }
                else
                {
                    MessageBox.Show("An error occurred: " + fileResult.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search(txtKeyword.Text);
        }

        private void Search(string keyword)
        {
            DecisionMatrixManager manager = new DecisionMatrixManager(new JsonStorage());
            List<DecisionMatrix> decisionMatrixes = manager.Search(keyword);
            //Clear the table
            tblResults.RowStyles.Clear();
            tblResults.Controls.Clear();
            //Loop through the decision matrixes
            foreach (DecisionMatrix dm in decisionMatrixes)
            {
                //Add the name, date updated, edit button and delete button
                tblResults.RowStyles.Add(new RowStyle() { SizeType = SizeType.AutoSize });
                tblResults.Controls.Add(new Label() { Text = dm.Name });
                tblResults.Controls.Add(new Label() { Text = dm.DateUpdated.ToString() });
                Button btnEdit = new Button() { Text = "Edit" };

                btnEdit.Click += delegate
                {
                    btnEdit_Click(dm.UUID);
                };
                tblResults.Controls.Add(btnEdit);
                Button btnDelete = new Button() { Text = "Delete" };
                btnDelete.Click += delegate
                {
                    btnDelete_Click(dm.UUID);
                };
                tblResults.Controls.Add(btnDelete);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
