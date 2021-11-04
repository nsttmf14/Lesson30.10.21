using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homelabs
{
    class Song
    {
        string name;
        string author;
        Song previous;
        public Song()
        {

        }
        public Song(string Name, string Author)
        {
            name = Name;
            author = Author;
            previous = null;
        }
        public Song(string Name, string Author, Song Previous)
        {
            name = Name;
            author = Author;
            previous = Previous;
        }
        public void SetName(string Name)
        {
            name = Name;
        }
        public void SetAuthor(string Author)
        {
            author = Author;
        }
        public void SetPrevious(Song Previous)
        {
            previous = Previous;
        }
        public string Title() //Возвращает название песни + исполнителя
        {
            return name + " " + author;
        }
        public override bool Equals(object d)
        {
            if (d is Song)
            {
                return (d as Song).Title().Equals(Title());
            }
            else
            {
                return false;
            }
        }
    }
}
