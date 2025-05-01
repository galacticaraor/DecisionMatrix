using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class Factors : Form
    {
        public int Weight
        {
            get
            {
                if (cmbWeight.SelectedValue != null)
                {
                    return int.Parse(cmbWeight.SelectedValue.ToString());
                }
                else
                {
                    return 0;
                }
            }
        }
        public string FactorName { get { return txtName.Text; } }

        public Factors()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim()=="")
            {
                MessageBox.Show("Name is required", "Name is Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbWeight.SelectedItem == null)
            {
                MessageBox.Show("Weight is required", "Weight is Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
