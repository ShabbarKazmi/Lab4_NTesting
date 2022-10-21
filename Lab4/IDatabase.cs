namespace Lab4
{
    public interface IDatabase
    {
        void AddEntry(Entry entry);
        bool DeleteEntry(Entry entry);
        bool EditEntry(Entry replacementEntry);
        Entry FindEntry(int id);
        System.Collections.ObjectModel.ObservableCollection<Entry> GetEntries();
        string InitializeConnectionString();
        System.Collections.ObjectModel.ObservableCollection<Entry> SortDatabaseEntries(string SortFilter);
    }
}