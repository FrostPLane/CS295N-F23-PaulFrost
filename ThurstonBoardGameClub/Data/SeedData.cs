﻿using ThurstonBoardGameClub.Models;
using System;
using System.Linq;

namespace ThurstonBoardGameClub.Data
{
    public class SeedData
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Messages.Any())  // this is to prevent duplicate data from being added
            {
/*                AppUser user = new AppUser
                {
                    Name = "Test Name"
                };
                context.AppUsers.Add(user);
                context.SaveChanges();*/

                Message message = new Message
                {
                    MessageId = 1,
                    From = "First From",
                    To = "First To",
                    Subject = "First Subject",
                    Text = "First Text",
                    Priority = 1,
                    Date = DateTime.Parse("11/1/2023")
                };
                context.Messages.Add(message);  // queues up the message to be added to the DB

                message = new Message
                {
                    MessageId = 2,
                    From = "Second From",
                    To = "Second To",
                    Subject = "Second Subject",
                    Text = "Second Text",
                    Priority = 2,
                    Date = DateTime.Parse("11/2/2023")
                };
                context.Messages.Add(message);

/*                AppUser senderFirstUser = new AppUser() { Name = "First User" };
                context.AppUsers.Add(senderFirstUser);
                context.SaveChanges();*/  
                // This will add a UserID to the reviewer object

                message = new Message
                {
                    MessageId = 3,
                    From = "Third From",
                    To = "Third To",
                    Subject = "Third Subject",
                    Text = "Third Text",
                    Priority = 3,
                    Date = DateTime.Parse("11/3/2023")
                };
                context.Messages.Add(message);

                message = new Message
                {
                    MessageId = 4,
                    From = "Third From",
                    To = "Fourth To",
                    Subject = "Fourth Subject",
                    Text = "Fourth Text",
                    Priority = 4,
                    Date = DateTime.Parse("11/4/2023")
                };
                context.Messages.Add(message);

                context.SaveChanges(); // stores all the reviews in the DB
            }
        }
    }
}
