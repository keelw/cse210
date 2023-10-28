using System;

class MathAssignment : Assignment {
    private string _textbookSection, _problems;

    public MathAssignment(string studentName, string type, string textbookSection, string problems) : base(studentName, type) {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList() {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}