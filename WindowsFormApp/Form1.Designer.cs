namespace WindowsFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtKeyword = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnExit = new Button();
            tblResults = new TableLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 21);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Keyword:";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(118, 22);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(189, 23);
            txtKeyword.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(328, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(56, 59);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(59, 337);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // tblResults
            // 
            tblResults.AutoScroll = true;
            tblResults.ColumnCount = 4;
            tblResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblResults.Location = new Point(59, 121);
            tblResults.Name = "tblResults";
            tblResults.RowCount = 1;
            tblResults.RowStyles.Add(new RowStyle());
            tblResults.Size = new Size(704, 201);
            tblResults.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblResults);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtKeyword);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Decision Matrixes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKeyword;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnExit;
        private TableLayoutPanel tblResults;
    }
}
