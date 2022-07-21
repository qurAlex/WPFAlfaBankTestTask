using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAlfaBankTestTask
{
    internal class Article
    {
        private string title;
        private string link;
        private string description;
        private string category;
        private DateTime pubDate;

        public string Title() { return title; }
        public string Link() { return link; }
        public string Description() { return description; }
        public string Category() { return category; }
        public DateTime PubDate() { return pubDate;}

        public Article() { }

        public Article(string title, string link, string description, string category, DateTime pubDate)
        {
            this.title = title;
            this.link = link;
            this.description = description;
            this.category = category;
            this.pubDate = pubDate;
        }
    }
}
