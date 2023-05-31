using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02BirthdayReminder
{
    internal class Program
    {
        // Freind class
        class Friend
        {
            public string Name { get; set; }
            public DateTime Birthday { get; set; }
            public Friend(string name, DateTime birthday)
            {
                Name = name;
                Birthday = birthday;
            }
        }

        // List of Friends
        static List<Friend> friends = new List<Friend>();

        // finding a Friend witin a list
        static Friend FindFriendByName(string name)
        {
            foreach (Friend friend in friends)
            {
                if (friend.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return friend;
                }
            }
            return null;
        }


        // adding a friend method
        static void AddFriend()
        {
            Console.WriteLine("Please enter a friend's name:\n");
            string name = Console.ReadLine();

            Console.WriteLine("Pleas enter firiend`s birthdat (DD/MM/YYYY):");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
            {
                Friend friend = new Friend(name, birthday);
                friends.Add(friend);
                Console.WriteLine($"Friend {name} added to the list");
            }
            else
            {
                Console.WriteLine("Date format seems to be incorrect.");
            }
        }

        // editing a friend method

        static void EditFriend()
        {
            Console.WriteLine("Enter the friend's name to edit:");
            string name = Console.ReadLine();

            Friend friend = FindFriendByName(name);

            if (friend != null)
            {
                Console.WriteLine("Enter the friend's new name (leave empty to keep current name):");
                string newName = Console.ReadLine();

                if (!string.IsNullOrEmpty(newName))
                {
                    friend.Name = newName;
                }

                Console.WriteLine("Enter the friend's new birthday (DD/MM/YYYY, leave empty to keep current birthday):");
                string newBirthdayInput = Console.ReadLine();

                if (!string.IsNullOrEmpty(newBirthdayInput))
                {
                    if (DateTime.TryParse(newBirthdayInput, out DateTime newBirthday))
                    {
                        friend.Birthday = newBirthday;
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format. Friend not edited.");
                    }
                }

                Console.WriteLine("Friend edited successfully!");
            }
            else
            {
                Console.WriteLine("Friend not found.");
            }
        }

        // deleting a friend method
        static void DeleteFriend()
        {
            Console.WriteLine("Enter the friend's name to delete:");
            string name = Console.ReadLine();

            Friend friend = FindFriendByName(name);

            if (friend != null)
            {
                friends.Remove(friend);
                Console.WriteLine("Friend deleted successfully!");
            }
            else
            {
                Console.WriteLine("Friend not found.");
            }
        }

        // view who is in a friend's list
        static void ViewFriends()
        {
            if (friends.Count > 0)
            {
                Console.WriteLine("Friends:");
                foreach (Friend friend in friends)
                {
                    Console.WriteLine($"{friend.Name}: {friend.Birthday.ToShortDateString()}");
                }
            }
            else
            {
                Console.WriteLine("No friends found.");
            }
        }
        static void CheckUpcomingBirthdays()
        {
            Console.WriteLine("Provide number of days to check for birthdays:");
            if (int.TryParse(Console.ReadLine(), out int numberOfDays))
            {
                DateTime today = DateTime.Today;
                DateTime upcomingDate = today.AddDays(numberOfDays);

                Console.WriteLine("Here are upcoming birthdays:");

                foreach (Friend friend in friends)
                {
                    int daysUntilBday = (friend.Birthday.Date - today.Date).Days;
                    if (daysUntilBday >= 0 && daysUntilBday <= numberOfDays)
                    {
                        Console.WriteLine($"{friend.Name}: {friend.Birthday.ToShortTimeString()} Is in {daysUntilBday} days.");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("1. Add a Friend");
                Console.WriteLine("2. Edit a Friend");
                Console.WriteLine("3. Delete a Friend");
                Console.WriteLine("4. View Friends");
                Console.WriteLine("5. Check for upcoming Birthdays");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice:\n");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddFriend();
                        break;
                    case "2":
                        EditFriend();
                        break;
                    case "3":
                        DeleteFriend();
                        break;
                    case "4":
                        ViewFriends();
                        break;
                    case "5":
                        CheckUpcomingBirthdays();
                        break;
                    case "6":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
                // Console.ReadKey();
            }
        }
    }
}



       
    

