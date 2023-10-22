﻿namespace Exam._03.ChatLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> messages = Console.ReadLine().Split().ToList();
            List<string> conversation = new List<string>();

            string command = messages[0];

            while (command != "end")

            {
                string message = messages[1];

                if (command == "Chat")
                {
                    conversation.Add(message);

                }
                else if (command == "Delete")
                {
                    if (conversation.Contains(message))
                    {
                        conversation.Remove(message);
                    }
                }
                else if (command == "Edit")
                {
                    string editedVersion = messages[2];

                    if (conversation.Contains(message))
                    {
                        int index = conversation.IndexOf(message);
                        conversation.Remove(message);
                        conversation.Insert(index, editedVersion);
                    }
                }
                else if (command == "Pin")
                {
                    if (conversation.Contains(message))
                    {
                        int index = conversation.IndexOf(message);
                        conversation.Add(message);
                        conversation.RemoveAt(index);
                    }

                }
                else if (command == "Spam")
                {

                    for (int i = 1; i < messages.Count; i++)
                    {
                        conversation.Add(messages[i]);
                    }
                }

                messages = Console.ReadLine().Split().ToList();
                command = messages[0];
            }

            for (int i = 0; i < conversation.Count; i++)
            {
                Console.WriteLine(conversation[i]);
            }
        }
    }
}