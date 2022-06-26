using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        public delegate void BanParticipant();
        public event BanParticipant BannedUser;

        //Write a program for Online Attendance. The conditions are as follows:
        //The user provides their name as Input and then the application shows a message to “Welcome to[their Name]”.
        //Jack, Steven, and Mathew are banned for the organization.
        //So, when any user enters Jack, Steven, or Mathew as username, the application raised an event and fire alarm as well as sends a message to the administration. 
        public string Username;
        public void RegisterNewUser()
        {
            Console.WriteLine("Enter your name:");
            Username = Console.ReadLine();

            if ((Username == "Jack" || Username == "Steven" || Username == "Mathew"))
            {
                BanUser();
            }
            else
            {
                Console.WriteLine($"Hello, {Username}!");
            }

        }
        public void BanUser()
        {
            Console.WriteLine("Alarm! You are not allowed to attent the meeting!");
            Console.WriteLine("Administration is notified by email");
            Console.WriteLine("Press Ctrl + C to stop the alarm");
            Console.Beep();
        }

    }
}




