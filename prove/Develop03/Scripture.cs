using System;
class Scripture {
    // Variables
    // Create the scriptures array and leave it empty
    private string[] _scripture = new string[0];
    private Word word;

    private string _scriptureText;

    // Constructor(s)
    public Scripture(string scriptureText) {
        this._scriptureText = scriptureText;

        // get the scripture into the list
        SplitScripture();
    }

    // Getter
    public string[] GetScripture() {
        return _scripture;
    }

    // Setter
    public void SetScripture(string[] newScripture) {
        _scripture = newScripture;
    }


    // Split the scripture string into a list of words using the words
    private void SplitScripture() {
        _scripture = _scriptureText.Split(" ");
    } 

    // Display the scripture
    public void DisplayScripture() {
        foreach (string scripture in _scripture) {
            Console.Write($"{scripture} ");
        }
    }

    // Remove words using the word class
    public void RemoveWords() {
        word = new Word(_scripture);
        _scripture = word.Remove();
    }

    // Determine if the _scripture array is completely "hidden" or not
    public bool IsEmpty() {
        bool isEmpty = false;

        foreach (string scripture in _scripture) {
            if (!scripture.Contains("_")) {
                isEmpty = false;
                break;
            }

            else {
                isEmpty = true;
            }
        }
        return isEmpty;
    }
}