using System;
using System.Collections.Generic;
class program
{
    static void Main()
    {
        //create a dictionary
        Dictionary<string,string> contacts = new Dictionary<string,string>();

        //Add 5 contacts
        contacts.Add("Ramya", "123456789");
        contacts.Add("Sowmya", "123456789");
        contacts.Add("Reddy", "123456789");
        contacts.Add("Prasad", "123456789");
        contacts.Add("vara", "123456789");

        //update phone numbers
        contacts["Ramya"] = " 987654321";

        //check if name exists
        if(contacts.ContainsKey("Reddy"))
        {
            Console.WriteLine("Reddy is in the contact list.");
        }

        //print all contacts
        Console.WriteLine("\nAll contacts:");
        foreach(var contact in contacts)
        {
            Console.WriteLine($"{contact.Key} - {contact.Value}");
        }
    }
}