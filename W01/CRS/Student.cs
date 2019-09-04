using System;

namespace CRS
{
    public class Student {
        public int id {get;}
        static int idCounter = 0;
        private bool bActive = true;
        public string blazerId {get; set;} //Student Registration Number
        public string fName {get; set;}
        public string lName {get; set;}
        
        // CREATE
        public Student(string blazerId, string fName) {
            this.id = idCounter;
            idCounter++;
            updateStudent(blazerId, fName, lName);
        }

        // READ - also getters
        public string toString()
        {
            return $"S-{id}: {blazerId}, {fName}, {lName}";
        }

        // UPDATE - also setters
        public void updateStudent(string blazerId, string fName, string lName) {
            this.blazerId = blazerId;
            this.fName = fName;
        }

        // DELETE - will not be read from the DB
        public  string deleteStudent() {
            bActive = false;
            return $"Object {{{this.toString()}}} was successfully deleted.";
        }
    }
}