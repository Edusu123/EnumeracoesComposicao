using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo2.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }

        public Post(DateTime moment, string title, string content, int liket)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = liket;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.AppendLine($"{Likes} likes - {Moment.ToString("dd/MM/yyyyy HH:mm:ss")}");
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            
            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}
