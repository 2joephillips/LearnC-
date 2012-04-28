using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;


namespace CourseManager
{
    public partial class OfficeAssignments : Form
    {
        //Create an ObjectContext instance based on SchoolEntities
        private SchoolEntities schoolContext;
        public OfficeAssignments()
        {
            InitializeComponent();
        }

        private void OfficeAssignment_Load(object sender, EventArgs e)
        {
            schoolContext = new SchoolEntities();
            //Bet Persons of type Instructor.
            ObjectQuery<Instructor> instructorQuery = schoolContext.People.OfType<Instructor>();

            //Bind the query results to the GridView Control. 
            //Display only location and name.
            officeGridView.DataSource = instructorQuery.Execute(MergeOption.OverwriteChanges);
            officeGridView.Columns["HireDate"].Visible = false;
            officeGridView.Columns["Timestamp"].Visible = false;
            officeGridView.Columns["PersonID"].Visible = false;
            officeGridView.Columns["EnrollmentDate"].Visible = false;
            officeGridView.Columns["StudentGrades"].Visible = false;
            officeGridView.Columns["Courses"].Visible = false;
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            //Save object changes to the data base,
            //display a message, and refresh form.
            schoolContext.SaveChanges();
            MessageBox.Show("Change(s) saved to the database.");
            this.Refresh();
        }
    }
}
