namespace WindowsFormApp
{
    partial class Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddPro = new Button();
            btnAddCon = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            tblPros = new TableLayoutPanel();
            tblCons = new TableLayoutPanel();
            label1 = new Label();
            txtName = new TextBox();
            lblProTotal = new Label();
            lblConTotal = new Label();
            label2 = new Label();
            lblDateUpdated = new Label();
            SuspendLayout();
            // 
            // btnAddPro
            // 
            btnAddPro.Location = new Point(81, 302);
            btnAddPro.Name = "btnAddPro";
            btnAddPro.Size = new Size(75, 23);
            btnAddPro.TabIndex = 1;
            btnAddPro.Text = "Add &Pro";
            btnAddPro.UseVisualStyleBackColor = true;
            btnAddPro.Click += btnAddPro_Click;
            // 
            // btnAddCon
            // 
            btnAddCon.Location = new Point(687, 302);
            btnAddCon.Name = "btnAddCon";
            btnAddCon.Size = new Size(75, 23);
            btnAddCon.TabIndex = 2;
            btnAddCon.Text = "Add &Con";
            btnAddCon.UseVisualStyleBackColor = true;
            btnAddCon.Click += btnAddCon_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(81, 386);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(177, 386);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "C&ancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tblPros
            // 
            tblPros.ColumnCount = 4;
            tblPros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tblPros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9999962F));
            tblPros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tblPros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tblPros.Location = new Point(77, 65);
            tblPros.Name = "tblPros";
            tblPros.RowCount = 1;
            tblPros.RowStyles.Add(new RowStyle());
            tblPros.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPros.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPros.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPros.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPros.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPros.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPros.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPros.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPros.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPros.Size = new Size(327, 200);
            tblPros.TabIndex = 5;
            // 
            // tblCons
            // 
            tblCons.ColumnCount = 4;
            tblCons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tblCons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000038F));
            tblCons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tblCons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tblCons.Location = new Point(428, 65);
            tblCons.Name = "tblCons";
            tblCons.RowCount = 1;
            tblCons.RowStyles.Add(new RowStyle());
            tblCons.Size = new Size(334, 200);
            tblCons.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 26);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 7;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(139, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 23);
            txtName.TabIndex = 8;
            // 
            // lblProTotal
            // 
            lblProTotal.AutoSize = true;
            lblProTotal.Location = new Point(79, 272);
            lblProTotal.Name = "lblProTotal";
            lblProTotal.Size = new Size(38, 15);
            lblProTotal.TabIndex = 9;
            lblProTotal.Text = "label2";
            // 
            // lblConTotal
            // 
            lblConTotal.AutoSize = true;
            lblConTotal.Location = new Point(708, 274);
            lblConTotal.Name = "lblConTotal";
            lblConTotal.Size = new Size(38, 15);
            lblConTotal.TabIndex = 10;
            lblConTotal.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(430, 26);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 11;
            label2.Text = "Last Updated:";
            // 
            // lblDateUpdated
            // 
            lblDateUpdated.AutoSize = true;
            lblDateUpdated.Location = new Point(528, 26);
            lblDateUpdated.Name = "lblDateUpdated";
            lblDateUpdated.Size = new Size(38, 15);
            lblDateUpdated.TabIndex = 12;
            lblDateUpdated.Text = "label3";
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDateUpdated);
            Controls.Add(label2);
            Controls.Add(lblConTotal);
            Controls.Add(lblProTotal);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(tblCons);
            Controls.Add(tblPros);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnAddCon);
            Controls.Add(btnAddPro);
            Name = "Details";
            Text = "Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddPro;
        private Button btnAddCon;
        private Button btnSave;
        private Button btnCancel;
        private TableLayoutPanel tblPros;
        private TableLayoutPanel tblCons;
        private Label label1;
        private TextBox txtName;
        private Label lblProTotal;
        private Label lblConTotal;
        private Label label2;
        private Label lblDateUpdated;
    }
}