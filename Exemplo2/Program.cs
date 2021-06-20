using System;
using System.Collections.Generic;

using Exemplo2.Entities;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post()
            {
                Moment = DateTime.Parse("20/06/2021 13:59:43"),
                Title = "Traveling to New Zeland",
                Content = "I'm going to visit this wonderful country",
                Likes = 12
            };

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            List<Comment> commentsPost2 = new List<Comment>();
            commentsPost2.Add(c3);
            commentsPost2.Add(c4);

            Post p2 = new Post()
            {
                Moment = DateTime.Parse("20/06/2021 14:02:47"),
                Title = "Goog night guys",
                Content = "See you tomorrow",
                Likes = 5,
                Comments = commentsPost2
            };
        }
    }
}
