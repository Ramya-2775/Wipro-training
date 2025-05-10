using System;
class chatbox
{
    public string respond (string greeting)
    {
        return $"Hello! : {greeting}";
    }

    //question
    public string respond(string question, bool isFormal)
    { 
            return $"thank you for the question: \"{question}\" .(Formal : {isFormal})";

    }

    //numerical query
    public string respond(int number)
    {
        return $"entered the number {number}. intresting!";
    }
}
class program
{
    static void Main()
    {
        chatbox chatbox = new chatbox();

        //greeeting
        Console.WriteLine(chatbox.respond("Hii there"));

        //question
        Console.WriteLine(chatbox.respond("whats for dinner"));

        //formal question
        Console.WriteLine(chatbox.respond("Could you please explain again"));

        //numerical query
        Console.WriteLine(chatbox.respond(30));
    }
}