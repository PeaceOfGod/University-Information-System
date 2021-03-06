﻿namespace UniversityInformationSystem.Models.ViewModels.Student
{
    using Enums;

    public class MandatoryCourseViewModel
    {
        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public string TeacherUsername { get; set; }

        public Grade Grade { get; set; }
    }
}
