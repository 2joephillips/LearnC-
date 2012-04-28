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
    public partial class Enrollment : Form
    {
        //Create an ObjectContext instance based on SchoolEntities.
        private SchoolEntities schoolContext;
        public Enrollment()
        {
            InitializeComponent();
        }

     

        private void Enrollment_Load(object sender, EventArgs e)
        {
            //Initialize the ObjectContext.
            schoolContext = new SchoolEntities();

            //Define a quert that returns all Deparment objects and 
            //related Course objects, ordered by name.
            ObjectQuery<Department> departmentQuery = schoolContext.Departments.Include("Courses")
                .OrderBy("it.Name");

            //Bind the Combox control to the query.
            this.departmentList.DataSource = departmentQuery
                .Execute(MergeOption.OverwriteChanges);
            this.departmentList.DisplayMember = "Name";

        }

        private void departmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentList.Items.Clear();
            //Get the object for the selected department.
            Department department = (Department)this.departmentList.SelectedItem;

            //Get the object Combox control to the Course properties of the selected department.
            courseList.DataSource = department.Courses;
            courseList.DisplayMember = "Title";
        }

        private void courseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentList.Items.Clear();
            //Get the CourseID from the Selected Course
            Course course = (Course)courseList.SelectedItem;
            int courseId = course.CourseID;

            //Get All StudentGrade Types for the Supplied CourseId
            Course studentQuery = schoolContext.Courses.Where(
                "it.CourseId = @courseId", new ObjectParameter("CourseId", courseId)).Include("StudentGrades").FirstOrDefault();
            
            //Get All students for each StudentGrade
            foreach (StudentGrade sg in studentQuery.StudentGrades)
            {
                sg.PersonReference.Load();
                studentList.Items.Add(sg.Person.LastName + ", " + sg.Person.FirstName);
            }

            studentList.Items.Add(" ");

            //Get all Instructor types for the supplied CourseId
            Course instructorQuery = schoolContext.Courses.Where(
                "it.CourseId = @courseID", new ObjectParameter("courseID", courseId)).Include("People").FirstOrDefault();

            //Display each instructor for the specified course.
            foreach (Instructor instrutor in instructorQuery.People
                .OfType<Instructor>())
            {
                studentList.Items.Add("Instructor: " + instrutor.LastName + ", " + instrutor.FirstName);
            }
        }
    }
}
