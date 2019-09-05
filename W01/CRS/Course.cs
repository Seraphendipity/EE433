using System;

namespace CRS
{
    /// <summary>
    /// Implementation of a course that can be used for any number of 
    /// students or semesters.
    /// </summary>
    public class Course : ICRSElement {

        // REFERENCE
        private bool bActive = true;
        public int id {get;}
        private static int idCounter = 0;

        // PROPERTIES
        public string subject {get; set;} // eg EE, MA, PH, etc.
        public int crn {get; set;} // eg 333, 433, 314, 101, etc.
        public string title {get; set;} // eg Software Solutions
        
        // CREATE
        /// <summary>
        /// Constructs a new course instance.
        /// </summary>
        /// <param name="subject">The department ID, eg "EE" or "PH".</param>
        /// <param name="crn">Course Reference Number, not 
        /// unique; eg "314", "101", etc.</param>
        /// <param name="title">A short descriptive title, eg 
        /// "Software Development Principles".</param>

        public Course(string subject, int crn, string title) {
            this.id = idCounter;
            idCounter++;
            this.update(subject, crn, title);
        }

        // READ - also getters
        /// <summary>
        /// Returns a string representation of the course.
        /// </summary>
        /// <returns>"C-{id}: {crn}, {title}"</returns>
        public string toString()
        {
            return $"C-{id}: {subject}, {crn}, {title}";
        }

        /// <summary>
        /// Returns a JSON string representation of the course.
        /// </summary>
        /// <returns>"C-{id}: {crn}, {title}"</returns>
        public string toJson() {
            return $@"{{
                ""id"": ""{id}"",
                ""subject"": ""{subject}"",
                ""crn"": ""{crn}"",
                ""title"": ""{title}""
            }}";
        }

        // UPDATE - also setters
        /// <summary>
        /// Updates course information. Additionally, getters may be used
        /// for individual data changes.
        /// </summary>
        /// <param name="subject">Course subject/department initials.</param>
        /// <param name="crn">Course Reference Number crn</param>
        /// <param name="title"></param>
        public void update(string subject, int crn, string title) {
            this.subject = subject;
            this.crn = crn;
            this.title = title;
        }

        public void update() {
            //nothing rn
        }

        // DELETE - deactivate moreover
        /// <summary>
        /// Sets the object to inactive, so parsers know to skip this data as
        /// if it does not exist. Due to the value and relative low memory of
        /// CRS data, it is never fully deleted in a product's lifetime.
        /// </summary>
        /// <returns>Deletion message verifying the object was deactivated.</returns>
        public  string delete() {
            this.bActive = false;
            return $"Object {{{this.toString()}}} was successfully deactivated.";
        }
    }
}