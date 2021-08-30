using System;
using System.Collections.Generic;
using System.Text;

namespace Articles
{
    class Articles
    {
        public Articles(string title,string content,string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }


        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
