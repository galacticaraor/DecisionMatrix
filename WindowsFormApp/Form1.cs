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
            tblResults.RowCount = tblResults.RowCount + 1;
            tblResults.Controls.Add(new Label() { Text = "Factor 1" });
            tblResults.Controls.Add(new Button() { Text = "Edit" });
            tblResults.Controls.Add(new Button() { Text = "Delete" });
        }
    }
}
