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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }



        private void btnAddPro_Click(object sender, EventArgs e)
        {
            Factors factors = new Factors();
            DialogResult dialogResult = factors.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                tblPros.Controls.Add(new Label() { Text = factors.Weight.ToString() });
                tblPros.Controls.Add(new Label() { Text = factors.FactorName });
                tblPros.Controls.Add(new Button() { Text = "Edit" });
                tblPros.Controls.Add(new Button() { Text = "Delete" });
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCon_Click(object sender, EventArgs e)
        {
            Factors factors = new Factors();
            DialogResult dialogResult = factors.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                tblCons.Controls.Add(new Label() { Text = factors.Weight.ToString() });
                tblCons.Controls.Add(new Label() { Text = factors.FactorName });
                tblCons.Controls.Add(new Button() { Text = "Edit" });
                tblCons.Controls.Add(new Button() { Text = "Delete" });
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
