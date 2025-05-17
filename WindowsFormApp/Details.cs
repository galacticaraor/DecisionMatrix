using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ClassLibrary;
using DAL;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormApp
{
    public partial class Details : Form
    {
        private DecisionMatrix _decisionMatrix = new DecisionMatrix();
        private bool _add = false;
        public Details()
        {
            InitializeComponent();
        }

        public void LoadForm(string uuid)
        {
            //If the user is adding then
            if (string.IsNullOrEmpty(uuid))
            {
                _add = true;
            }
            DecisionMatrixManager manager = new DecisionMatrixManager(new JsonStorage());
            _decisionMatrix = manager.Get(uuid);
            //Bind the name and date updated to the controls
            txtName.Text = _decisionMatrix.Name;
            lblDateUpdated.Text = _decisionMatrix.DateUpdated.ToString();
            //Loop through the pros
            foreach (Factor f in _decisionMatrix.Pros)
            {
                //Add the pro to the table
                tblPros.Controls.Add(new Label() { Text = f.Weight.ToString() });
                tblPros.Controls.Add(new Label() { Text = f.Name });
                Button btnEdit = new Button() { Text = "Edit" };
                btnEdit.Click += delegate
                {
                    btnEditPro_Click(f.UUID, f.Name, f.Weight);
                };
                tblPros.Controls.Add(btnEdit);
                Button btnDelete = new Button() { Text = "Delete" };
                btnDelete.Click += delegate
                {
                    btnDeletePro_Click(f.UUID);
                };
                tblPros.Controls.Add(btnDelete);
            }
            //Loop through the cons
            foreach (Factor f in _decisionMatrix.Cons)
            {
                //Add the con to the table
                tblCons.Controls.Add(new Label() { Text = f.Weight.ToString() });
                tblCons.Controls.Add(new Label() { Text = f.Name });
                Button btnEdit = new Button() { Text = "Edit" };
                btnEdit.Click += delegate
                {
                    btnEditCon_Click(f.UUID, f.Name, f.Weight);
                };
                tblCons.Controls.Add(btnEdit);
                Button btnDelete = new Button() { Text = "Delete" };
                btnDelete.Click += delegate
                {
                    btnDeleteCon_Click(f.UUID);
                };
                tblCons.Controls.Add(btnDelete);
            }
        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            Factors factors = new Factors();
            factors.LoadForm("", 0);
            //Display the factor form
            DialogResult dialogResult = factors.ShowDialog();
            //If the user clicked OK then
            if (dialogResult == DialogResult.OK)
            {
                _decisionMatrix.AddPro(new Factor() { Name = factors.Name, Weight = factors.Weight });
                LoadForm(_decisionMatrix.UUID);
            }
        }

        private void btnEditPro_Click(string uuid, string name, int weight)
        {
            Factors factors = new Factors();
            factors.LoadForm(name, weight);
            //Display the factor form
            DialogResult dialogResult = factors.ShowDialog();
            //If the user clicked OK then
            if (dialogResult == DialogResult.OK)
            {
                _decisionMatrix.EditPro(new Factor(uuid, name, weight));
                LoadForm(_decisionMatrix.UUID);
            }
        }

        private void btnDeletePro_Click(string uuid)
        {
            _decisionMatrix.DeletePro(uuid);
            LoadForm(_decisionMatrix.UUID);
        }

        private void btnAddCon_Click(object sender, EventArgs e)
        {
            Factors factors = new Factors();
            factors.LoadForm("", 0);
            //Display the factor form
            DialogResult dialogResult = factors.ShowDialog();
            //If the user clicked OK then
            if (dialogResult == DialogResult.OK)
            {
                _decisionMatrix.AddCon(new Factor() { Name = factors.Name, Weight = factors.Weight });
                LoadForm(_decisionMatrix.UUID);
            }
        }

        private void btnEditCon_Click(string uuid, string name, int weight)
        {
            Factors factors = new Factors();
            factors.LoadForm(name, weight);
            //Display the factor form
            DialogResult dialogResult = factors.ShowDialog();
            //If the user clicked OK then
            if (dialogResult == DialogResult.OK)
            {
                _decisionMatrix.EditCon(new Factor(uuid, name, weight));
                LoadForm(_decisionMatrix.UUID);
            }
        }

        private void btnDeleteCon_Click(string uuid)
        {
            _decisionMatrix.DeleteCon(uuid);
            LoadForm(_decisionMatrix.UUID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DecisionMatrixManager manager = new DecisionMatrixManager(new JsonStorage());
            _decisionMatrix.Name = txtName.Text;
            _decisionMatrix.DateUpdated = DateTime.Now;
            FileResult fileResult = new FileResult(true, "");
            //If the user is adding a matrix then
            if (_add)
            {
                fileResult = manager.Add(_decisionMatrix);
            }
            else
            {
                fileResult = manager.Edit(_decisionMatrix);
            }
            if (!fileResult.Successful)
            {
                MessageBox.Show("An error occurred: " + fileResult.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
