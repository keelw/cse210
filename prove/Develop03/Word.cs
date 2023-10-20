using System;

class Word {
    // variables 
    string[] scripture;
    System.Random random = new System.Random(); 


    // constructors
    public Word(string[] scripture) {
        this.scripture = scripture;
    }

    // remove words and replace them with "_" in the right quantity
    public string[] Remove() {
        // count words removed with each action
        int words = 0;

        // keep track of the scripture length
        int scriptureLength = scripture.Length;

        // remove 3 words each time
        while (words < 3) {
            // get a random number between 0 and the length
            int num = random.Next(0,scriptureLength);
            
            // create a hiddenWord
            string hiddenWord = "";

            // Only remove words that haven't already been hidden
            if (!scripture[num].Contains("_"))
            {
                // remove the words
                for(int i=0; i<scripture[num].Length; i++) {
                    hiddenWord += "_";
                }

                scripture[num] = hiddenWord;
                
                // count it
                words++;

            }
        }
        // return the list
        return scripture;
    }
}