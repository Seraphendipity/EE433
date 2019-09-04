using System;

namespace CRS
{
    public class Register {
        public int id {get;}
        static int idCounter = 0;
        public bool bActive{get; set;} = true;
        public string semester {get; set;} //Register Registration Number
        public Student student {get; set;}
        public Course course {get; set;}
        public int grade {get; set;}
        
        // CREATE
        public Register(string semester, Student student, Course course) : this(semester, student, course, 100) {
        }

        public Register(string semester, Student student, Course course, int grade) {
            this.id = idCounter;
            idCounter++;
            updateRegister(semester, student, course, grade);
        }

        // READ - also getters
        public string toString()
        {
            return $"R-{id}: {semester}, {{{student.toString()}}}, {{{course.toString()}}}, {grade}";
        }

        // UPDATE - also setters
        public void updateRegister(string semester, Student student, Course course, int grade) {
            this.semester = semester;
            this.student = student;
            this.course = course;
            this.grade = grade;
        }

        // DELETE - will not be read from the DB
        public  string deleteRegister() {
            this.bActive = false;
            return $"Object {{{this.toString()}}} was successfully deleted.";
        }
    }
}