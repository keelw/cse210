using System;

class Journal {
  
    // member variables here
    public List<Entry> _entryList = new List<Entry>();

    // Constructor
    public Journal() {

    }
    // This function will add an entry object to the list of entries
    public void AddEntry(Entry entry) 
    {
      _entryList.Add(entry);
    }

    // This function will display the journal by using the display function 
    // in the entry object
    public void DisplayJournal() 
    {
        foreach (Entry entry in _entryList)
        {
            entry.Display();
        }    
    }

    // this function will save the journal as a file of the users choosing
    public void SaveJournal(string fileName)
    {
      using (StreamWriter outputFile = new StreamWriter(fileName))
      {
        foreach (Entry entry in _entryList)
        {
          // get the variables from the entry object in the list
          string _date = entry._date;
          string _prompt = entry._prompt;
          string _response = entry._response;

          outputFile.WriteLine($"{_date}|{_prompt}|{_response}");
        }
      }
    }
}

