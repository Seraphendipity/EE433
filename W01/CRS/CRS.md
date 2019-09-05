# Course Registration System


## Courses
The implementation assumes Courses in a perpetual state, ie not tied to any point in time. This means that a course does not worry about its semester, times, instructors, or the like. The intent is to seperate a "Course", as defined by its name, criteria, subject matter, etc., from its implementation within a specific semester.

[Register](#registers), thusly, implements the additional details. This does bring an interesting dilemna, though, on if standards should be tied to a Course or a Register. While this system does not model this, it is something to consider, and perhaps could be met with course standards in the Courses and Coursework (as the implementation of it) in a seperate, version-tracked class, linked to the Register by ID.

## Students
Students, like courses, are assumed to be in a perpetual state and not tied to any time-specific data. The goal is that courses and students are changed very seldomly -- aside from setup, adding new students/courses, and occasional updates, these should not be edited often.

## Registers
Registers are the inter-connecting glue between the various objects, representing moreover an event in time compared to the more object-like Course/Student instantiations. They contain references to the students, courses, and later perhaps instructors and program-implementations. They also contain semester-specific information, such as maximum number of students, grades of the students, year/semester, and potentially more (such as course/teacher reviews).

## Collections

## ID's and Reference Numbers
One tricky and almost clunky approach in the UAB CRS is the multitude of identifying numbers. Course Reference Number does not relate at all to the Course number used to identify a course alongside the department subject initials, merely labelled "course". With students, the blazerID and BOOL are both identifying items, albeit BOOL is the unique and true identifier. 

In this CRS, ID *always*, unless stated otherwise, pertains to the unique, identifying number from which a student, course, or register may be referenced. Note that it is only unique to the Class or entity -- this is by design, as opposed to a ID system that spans across all CRS Entities. Entities may be referenced by 'S' for student, 'C' for course, and 'R' for register.

The blazerID and CRN or other "Reference Number" only pertain to a handy and quick way to reference the course. The CRN is redefined as the numbers in the course initials (eg '433' in 'EE433'). While these are not necessarily unique, and indeed there is expected overlap between all courses, it is advisable to keep them unique within a subject/department and blazerID's as unique as possible. While no backend or code will rely on this stipulation and thus it will not serve as a constraint, these will be handy measures for searching through courses and students, and the less overlap reduces the amount of 'noise' users of the CRS will have to search through to find their intended target.

## Deletion and Deactivation
Data is not deleted, except in the case of a complete memory wipe or DB manipulation. However, objects have a `bActive` variable that maintains whether it is "deleted" or not. In this context, "active" does not mean whether it is in current use, so a register from two semesters past will still be "active". If an object is deactivated, it will not be used in searches, calculations, etc. -- the system essentially ignores it.

Potentially there will be "wipe inactive" functionality in future implementations.

## Collections
In an effort to minimize the duties and held information of each student, course, and register to the bare minimum.