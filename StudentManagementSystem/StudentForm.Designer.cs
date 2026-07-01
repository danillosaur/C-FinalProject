namespace StudentManagementSystem
{
    partial class StudentForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblCourse;

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtCourse;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();

            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            // =========================
            // LABELS
            // =========================
            this.lblID.Text = "Student ID:";
            this.lblID.Location = new System.Drawing.Point(20, 20);

            this.lblName.Text = "Name:";
            this.lblName.Location = new System.Drawing.Point(20, 60);

            this.lblAge.Text = "Age:";
            this.lblAge.Location = new System.Drawing.Point(20, 100);

            this.lblCourse.Text = "Course:";
            this.lblCourse.Location = new System.Drawing.Point(20, 140);

            // =========================
            // TEXTBOXES
            // =========================
            this.txtID.Location = new System.Drawing.Point(120, 20);
            this.txtID.Width = 200;

            this.txtName.Location = new System.Drawing.Point(120, 60);
            this.txtName.Width = 200;

            this.txtAge.Location = new System.Drawing.Point(120, 100);
            this.txtAge.Width = 200;

            this.txtCourse.Location = new System.Drawing.Point(120, 140);
            this.txtCourse.Width = 200;

            // =========================
            // BUTTONS
            // =========================
            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(120, 190);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(220, 190);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // =========================
            // FORM
            // =========================
            this.ClientSize = new System.Drawing.Size(360, 250);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblCourse);

            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtCourse);

            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);

            this.Text = "Student Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        }

        #endregion
    }
}