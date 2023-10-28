using System;

class WritingAssignment : Assignment {
    private string _title;

    public WritingAssignment(string studentName, string type, string title) : base(studentName, type) {
        _title = title;
    }

    public string GetWritingInformation() {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}