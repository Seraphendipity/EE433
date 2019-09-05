using System;

namespace CRS
{
    public class StudentCollection {
        public int id {get;}
        static int idCounter = 0;
        public string blazerId {get; set;} //StudentCollection Registration Number
        public string fName {get; set;}
        public string lName {get; set;}
        
        // CREATE
        public StudentCollection(string blazerId, string fName) {
            this.id = idCounter;
            idCounter++;
            updateStudentCollection(blazerId, fName, lName);
        }

        // READ - also getters
        public string toString()
        {
            return $"S-{id}: {blazerId}, {fName}, {lName}";
        }

        // UPDATE - also setters
        public void updateStudentCollection(string blazerId, string fName, string lName) {
            this.blazerId = blazerId;
            this.fName = fName;
        }

        // DELETE - will not be read from the DB
        public  string deleteStudentCollection() {
            return $"Object {{{this.toString()}}} was successfully deleted.";
        }
    }
}