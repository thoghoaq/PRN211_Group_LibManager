
namespace LibManager
{
    partial class frmLibManagement
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
            this.lbBookID = new System.Windows.Forms.Label();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbAuthorID = new System.Windows.Forms.Label();
            this.lbPublishYear = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbBookQuantity = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkStatusTrue = new System.Windows.Forms.CheckBox();
            this.checkStatusFalse = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grBookDetail = new System.Windows.Forms.GroupBox();
            this.grControl = new System.Windows.Forms.GroupBox();
            this.cboAuthorID = new System.Windows.Forms.ComboBox();
            this.cboCategoryID = new System.Windows.Forms.ComboBox();
            this.cboPublishYear = new System.Windows.Forms.ComboBox();
            this.btnNewAuthor = new System.Windows.Forms.Button();
            this.btnNewCategoryID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grBookDetail.SuspendLayout();
            this.grControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBookID
            // 
            this.lbBookID.AutoSize = true;
            this.lbBookID.Location = new System.Drawing.Point(32, 46);
            this.lbBookID.Name = "lbBookID";
            this.lbBookID.Size = new System.Drawing.Size(62, 20);
            this.lbBookID.TabIndex = 0;
            this.lbBookID.Text = "Book ID";
            this.lbBookID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Location = new System.Drawing.Point(32, 96);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(88, 20);
            this.lbCategoryID.TabIndex = 1;
            this.lbCategoryID.Text = "Category ID";
            this.lbCategoryID.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Location = new System.Drawing.Point(32, 154);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(87, 20);
            this.lbBookName.TabIndex = 2;
            this.lbBookName.Text = "Book Name";
            // 
            // lbAuthorID
            // 
            this.lbAuthorID.AutoSize = true;
            this.lbAuthorID.Location = new System.Drawing.Point(32, 212);
            this.lbAuthorID.Name = "lbAuthorID";
            this.lbAuthorID.Size = new System.Drawing.Size(73, 20);
            this.lbAuthorID.TabIndex = 3;
            this.lbAuthorID.Text = "Author ID";
            // 
            // lbPublishYear
            // 
            this.lbPublishYear.AutoSize = true;
            this.lbPublishYear.Location = new System.Drawing.Point(450, 34);
            this.lbPublishYear.Name = "lbPublishYear";
            this.lbPublishYear.Size = new System.Drawing.Size(88, 20);
            this.lbPublishYear.TabIndex = 4;
            this.lbPublishYear.Text = "Publish Year";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(450, 84);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(49, 20);
            this.lbStatus.TabIndex = 5;
            this.lbStatus.Text = "Status";
            // 
            // lbBookQuantity
            // 
            this.lbBookQuantity.AutoSize = true;
            this.lbBookQuantity.Location = new System.Drawing.Point(450, 142);
            this.lbBookQuantity.Name = "lbBookQuantity";
            this.lbBookQuantity.Size = new System.Drawing.Size(60, 20);
            this.lbBookQuantity.TabIndex = 6;
            this.lbBookQuantity.Text = "Quanity";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(129, 43);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(169, 27);
            this.txtBookID.TabIndex = 7;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(129, 151);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(169, 27);
            this.txtBookName.TabIndex = 9;
            this.txtBookName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(549, 139);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(169, 27);
            this.txtQuantity.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(743, 229);
            this.dataGridView1.TabIndex = 14;
            // 
            // checkStatusTrue
            // 
            this.checkStatusTrue.AutoSize = true;
            this.checkStatusTrue.Location = new System.Drawing.Point(549, 84);
            this.checkStatusTrue.Name = "checkStatusTrue";
            this.checkStatusTrue.Size = new System.Drawing.Size(59, 24);
            this.checkStatusTrue.TabIndex = 15;
            this.checkStatusTrue.Text = "True";
            this.checkStatusTrue.UseVisualStyleBackColor = true;
            // 
            // checkStatusFalse
            // 
            this.checkStatusFalse.AutoSize = true;
            this.checkStatusFalse.Location = new System.Drawing.Point(629, 84);
            this.checkStatusFalse.Name = "checkStatusFalse";
            this.checkStatusFalse.Size = new System.Drawing.Size(63, 24);
            this.checkStatusFalse.TabIndex = 16;
            this.checkStatusFalse.Text = "False";
            this.checkStatusFalse.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(527, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 33);
            this.panel1.TabIndex = 17;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(32, 26);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 29);
            this.btnAddNew.TabIndex = 18;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(148, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(279, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(399, 26);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // grBookDetail
            // 
            this.grBookDetail.Controls.Add(this.checkStatusFalse);
            this.grBookDetail.Controls.Add(this.btnNewCategoryID);
            this.grBookDetail.Controls.Add(this.checkStatusTrue);
            this.grBookDetail.Controls.Add(this.btnNewAuthor);
            this.grBookDetail.Controls.Add(this.cboPublishYear);
            this.grBookDetail.Controls.Add(this.txtQuantity);
            this.grBookDetail.Controls.Add(this.cboCategoryID);
            this.grBookDetail.Controls.Add(this.cboAuthorID);
            this.grBookDetail.Controls.Add(this.lbBookQuantity);
            this.grBookDetail.Controls.Add(this.panel1);
            this.grBookDetail.Controls.Add(this.lbStatus);
            this.grBookDetail.Controls.Add(this.lbPublishYear);
            this.grBookDetail.Location = new System.Drawing.Point(12, 12);
            this.grBookDetail.Name = "grBookDetail";
            this.grBookDetail.Size = new System.Drawing.Size(763, 246);
            this.grBookDetail.TabIndex = 22;
            this.grBookDetail.TabStop = false;
            this.grBookDetail.Text = "Book Detail";
            // 
            // grControl
            // 
            this.grControl.Controls.Add(this.btnExit);
            this.grControl.Controls.Add(this.btnAddNew);
            this.grControl.Controls.Add(this.btnDelete);
            this.grControl.Controls.Add(this.btnUpdate);
            this.grControl.Location = new System.Drawing.Point(12, 517);
            this.grControl.Name = "grControl";
            this.grControl.Size = new System.Drawing.Size(532, 72);
            this.grControl.TabIndex = 23;
            this.grControl.TabStop = false;
            this.grControl.Text = "Control";
            // 
            // cboAuthorID
            // 
            this.cboAuthorID.FormattingEnabled = true;
            this.cboAuthorID.Location = new System.Drawing.Point(117, 197);
            this.cboAuthorID.Name = "cboAuthorID";
            this.cboAuthorID.Size = new System.Drawing.Size(169, 28);
            this.cboAuthorID.TabIndex = 0;
            // 
            // cboCategoryID
            // 
            this.cboCategoryID.FormattingEnabled = true;
            this.cboCategoryID.Location = new System.Drawing.Point(117, 81);
            this.cboCategoryID.Name = "cboCategoryID";
            this.cboCategoryID.Size = new System.Drawing.Size(169, 28);
            this.cboCategoryID.TabIndex = 1;
            // 
            // cboPublishYear
            // 
            this.cboPublishYear.FormattingEnabled = true;
            this.cboPublishYear.Location = new System.Drawing.Point(549, 31);
            this.cboPublishYear.Name = "cboPublishYear";
            this.cboPublishYear.Size = new System.Drawing.Size(169, 28);
            this.cboPublishYear.TabIndex = 2;
            // 
            // btnNewAuthor
            // 
            this.btnNewAuthor.Location = new System.Drawing.Point(292, 197);
            this.btnNewAuthor.Name = "btnNewAuthor";
            this.btnNewAuthor.Size = new System.Drawing.Size(94, 29);
            this.btnNewAuthor.TabIndex = 3;
            this.btnNewAuthor.Text = "New";
            this.btnNewAuthor.UseVisualStyleBackColor = true;
            // 
            // btnNewCategoryID
            // 
            this.btnNewCategoryID.Location = new System.Drawing.Point(292, 79);
            this.btnNewCategoryID.Name = "btnNewCategoryID";
            this.btnNewCategoryID.Size = new System.Drawing.Size(94, 29);
            this.btnNewCategoryID.TabIndex = 4;
            this.btnNewCategoryID.Text = "New";
            this.btnNewCategoryID.UseVisualStyleBackColor = true;
            // 
            // frmLibManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lbAuthorID);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.lbCategoryID);
            this.Controls.Add(this.lbBookID);
            this.Controls.Add(this.grBookDetail);
            this.Controls.Add(this.grControl);
            this.Name = "frmLibManagement";
            this.Text = "LibManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grBookDetail.ResumeLayout(false);
            this.grBookDetail.PerformLayout();
            this.grControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBookID;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbAuthorID;
        private System.Windows.Forms.Label lbPublishYear;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbBookQuantity;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkStatusTrue;
        private System.Windows.Forms.CheckBox checkStatusFalse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grBookDetail;
        private System.Windows.Forms.ComboBox cboPublishYear;
        private System.Windows.Forms.ComboBox cboCategoryID;
        private System.Windows.Forms.ComboBox cboAuthorID;
        private System.Windows.Forms.GroupBox grControl;
        private System.Windows.Forms.Button btnNewCategoryID;
        private System.Windows.Forms.Button btnNewAuthor;
    }
}