using System;

namespace CRS
{
    public class Course {
        public int id {get;}
        static int idCounter = 0;
        private bool bActive = true;
        public string crn {get; set;} //Course Registration Number
        public string description {get; set;}
        
        // CREATE
        public Course(string crn, string description) {
            this.id = idCounter;
            idCounter++;
            updateCourse(crn, description);
        }

        // READ - also getters
        public string toString()
        {
            return $"C-{id}: {crn}, {description}";
        }

        // UPDATE - also setters
        public void updateCourse(string crn, string description) {
            this.crn = crn;
            this.description = description;
        }

        // DELETE - will not be read from the DB
        public  string deleteCourse() {
            this.bActive = false;
            return $"Object {{{this.toString()}}} was successfully deleted.";
        }
    }
}