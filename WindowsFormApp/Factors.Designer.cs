namespace WindowsFormApp
{
    partial class Factors
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            cmbWeight = new ComboBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 16);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(115, 17);
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 65);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Weight:";
            // 
            // cmbWeight
            // 
            cmbWeight.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWeight.FormattingEnabled = true;
            cmbWeight.Items.AddRange(new object[] { "1", "2", "3" });
            cmbWeight.Location = new Point(115, 65);
            cmbWeight.Name = "cmbWeight";
            cmbWeight.Size = new Size(154, 23);
            cmbWeight.TabIndex = 3;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(51, 114);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 4;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(143, 114);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Factors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 187);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(cmbWeight);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Factors";
            Text = "Factors";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private ComboBox cmbWeight;
        private Button btnOK;
        private Button btnCancel;
    }
}