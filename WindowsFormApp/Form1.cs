using System.Windows.Forms;

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
            details.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tblResults.RowStyles.Add(new RowStyle() { SizeType = SizeType.AutoSize });
            tblResults.Controls.Add(new Label() { Text = "Factor 1" });
            Button btnEdit = new Button() { Text = "Edit" };
            btnEdit.Click += delegate
            {
                Details details = new Details();
                details.ShowDialog();
            };
            tblResults.Controls.Add(btnEdit);
            Button btnDelete = new Button() { Text = "Delete" };
            btnDelete.Click += delegate
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    MessageBox.Show("Row deleted");
                }
            };
            tblResults.Controls.Add(btnDelete);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
