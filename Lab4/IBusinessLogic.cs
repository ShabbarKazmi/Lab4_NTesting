namespace Lab4
{
    public interface IBusinessLogic
    {
        InvalidFieldError AddEntry(string clue, string answer, int difficulty, string date);
        EntryDeletionError DeleteEntry(int entryId);
        EntryEditError EditEntry(string clue, string answer, int difficulty, string date, int id);
        Entry FindEntry(int id);
        System.Collections.ObjectModel.ObservableCollection<Entry> GetEntries();
        bool IsEntrySelected(Entry entry);
        System.Collections.ObjectModel.ObservableCollection<Entry> SortByAnswer();
        System.Collections.ObjectModel.ObservableCollection<Entry> SortByClue();
    }
}