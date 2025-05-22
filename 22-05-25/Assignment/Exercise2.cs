using System;
Dictionary<string, string> phoneBook = new Dictionary<string, string>
{
    { "Ramya", "123456789" },
    { "Sowmya", "987654321" },
    { "Reddy", "345678921" }
};

// Display contacts
foreach (var contact in phoneBook)
    Console.WriteLine($"{contact.Key}: {contact.Value}");

// Search by name
Console.Write("\nEnter name to search: ");
string searchName = Console.ReadLine();
if (phoneBook.TryGetValue(searchName, out var number))
    Console.WriteLine($"{searchName}'s number is {number}");
else
    Console.WriteLine("Contact not found.");