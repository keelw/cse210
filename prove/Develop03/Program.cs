// As a stretch challenge, the Remove() function in the Word.cs class was designed
// so that there are 3 words removed at random and no words are hidden twice. Meaning,
// 3 different words will be removed EACH time.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a reference object
        Reference reference = new Reference("Alma", 7, 11, 12);

        // Create the scripture object
        string scriptureString = "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.";
        Scripture scripture = new Scripture(scriptureString);
        
        bool continueRunning = true;
        while (continueRunning == true) {
            // clear the console
            Console.Clear();
            // display the reference
            reference.DisplayReference();

            // display the scripture
            scripture.DisplayScripture();

            // prompt and wait for user input
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();

            // quit the program if the user wants
            if (userInput == "quit") {
                continueRunning = false;
                break;
            }
            
            // quit the program if the scripture is completely hidden
            if (scripture.IsEmpty()) {
                continueRunning = false;
                break;
            }
    
            // remove words from the scripture if nothing is entered
            if (userInput == "") {
                scripture.RemoveWords();
            }
        }
    }
}