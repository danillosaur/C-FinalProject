using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class StudentForm : Form
    {
        public Student Student { get; private set; }

        private bool isEditMode = false;

        // =========================
        // ADD MODE
        // =========================
        public StudentForm()
        {
            InitializeComponent();
            Student = new Student();
        }

        // =========================
        // EDIT MODE
        // =========================
        public StudentForm(Student student)
        {
            InitializeComponent();
            isEditMode = true;

            txtID.Text = student.StudentID;
            txtName.Text = student.Name;
            txtAge.Text = student.Age.ToString();
            txtCourse.Text = student.Course;

            // work on a COPY (safe edit)
            Student = new Student
            {
                StudentID = student.StudentID,
                Name = student.Name,
                Age = student.Age,
                Course = student.Course
            };
        }

        // =========================
        // SAVE BUTTON
        // =========================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Age must be a number.");
                return;
            }

            Student.StudentID = txtID.Text;
            Student.Name = txtName.Text;
            Student.Age = age;
            Student.Course = txtCourse.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        // =========================
        // CANCEL BUTTON
        // =========================
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}