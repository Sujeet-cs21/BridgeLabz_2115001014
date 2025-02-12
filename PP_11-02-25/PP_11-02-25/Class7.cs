using System;
using System.Collections.Generic;

namespace PP_11_02_25
{
    class User
    {
        public int UserID;
        public string Name;
        public int Age;
        public List<int> Friends;
        public User Next;

        public User(int userID, string name, int age)
        {
            UserID = userID;
            Name = name;
            Age = age;
            Friends = new List<int>();
        }
    }

    class Class7
    {
        private User head = null;

        public void AddUser(int userID, string name, int age)
        {
            User newUser = new User(userID, name, age);
            if (head == null)
            {
                head = newUser;
            }
            else
            {
                User temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newUser;
            }
        }

        public void AddFriend(int userID1, int userID2)
        {
            User user1 = SearchUser(userID1);
            User user2 = SearchUser(userID2);

            if (user1 != null && user2 != null)
            {
                user1.Friends.Add(userID2);
                user2.Friends.Add(userID1);
            }
        }

        public void RemoveFriend(int userID1, int userID2)
        {
            User user1 = SearchUser(userID1);
            User user2 = SearchUser(userID2);

            if (user1 != null && user2 != null)
            {
                user1.Friends.Remove(userID2);
                user2.Friends.Remove(userID1);
            }
        }

        public void DisplayFriends(int userID)
        {
            User user = SearchUser(userID);
            if (user != null)
            {
                Console.Write("Friends of " + user.Name + ": ");
                foreach (int friendID in user.Friends)
                {
                    Console.Write(friendID + " ");
                }
                Console.WriteLine();
            }
        }

        public User SearchUser(int userID)
        {
            User temp = head;
            while (temp != null)
            {
                if (temp.UserID == userID)
                    return temp;
                temp = temp.Next;
            }
            return null;
        }

        public void FindMutualFriends(int userID1, int userID2)
        {
            User user1 = SearchUser(userID1);
            User user2 = SearchUser(userID2);

            if (user1 != null && user2 != null)
            {
                Console.Write("Mutual friends between " + user1.Name + " and " + user2.Name + ": ");
                foreach (int friend in user1.Friends)
                {
                    if (user2.Friends.Contains(friend))
                    {
                        Console.Write(friend + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void CountFriends(int userID)
        {
            User user = SearchUser(userID);
            if (user != null)
            {
                Console.WriteLine(user.Name + " has " + user.Friends.Count + " friends.");
            }
        }

        public void DisplayUsers()
        {
            User temp = head;
            while (temp != null)
            {
                Console.Write(temp.Name + "->");
                temp = temp.Next;
            }
            Console.WriteLine() ;
        }

        public static void Main7()
        {
            Class7 sm = new Class7();

            sm.AddUser(1, "User1", 25);
            sm.AddUser(2, "User2", 24);
            sm.AddUser(3, "User3", 26);

            sm.AddFriend(1, 2);
            sm.AddFriend(1, 3);
            sm.AddFriend(2, 3);

            sm.DisplayFriends(1);
            sm.DisplayFriends(2);
            sm.DisplayFriends(3);

            sm.FindMutualFriends(1, 2);
            sm.CountFriends(1);

            sm.RemoveFriend(1, 2);
            sm.DisplayFriends(1);
        }
    }

}
