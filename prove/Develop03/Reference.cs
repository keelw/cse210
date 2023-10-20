using System;

class Reference {
    // Variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructors
    public Reference(string book, int chapter, int verse) {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._endVerse = 0;
    }

    public Reference(string book, int chapter, int verse, int endVerse) {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._endVerse = endVerse;
    }

    public void DisplayReference() {
        // Check if there is 2 verses or 1 and display the reference accordingly
        if (_endVerse == 0) {
            Console.Write($"{_book} {_chapter}:{_verse}");
        }

        else {
            Console.Write($"{_book} {_chapter}:{_verse}-{_endVerse} ");
        }
    }
}