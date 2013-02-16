using System;
using System.Collections.Generic;

namespace dewitcher
{
    public static partial class Console
    {
        public class Category
        {
            public string Name;
            public List<Entry> entries;
            public Category(string name)
            {
                this.entries = new List<Entry>();
                this.entries.Add(new Back());
                this.Name = name;
            }
            public void AddEntry(Entry entry) { this.entries.Add(entry); }
            public void AddEntries(Entry[] entries)
            {
                for (int i = 0; i < entries.Length; i++) { this.entries.Add(entries[i]); }
            }
        }
    }
}
