public class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
        "List as many things as you can that you're grateful for.",
        "List as many places as you can where you feel at peace.",
        "List as many people as you can who make you smile."
    };

    public override void ExecuteActivity()
    {
        StartActivity("Listing Exercise", "This activity will help you list things that are important to you.");
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("You have a limited time to list as many responses as you can.");

        for (int i = 0; i < duration; i++)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
        }

        EndActivity("Listing Exercise");
    }
}
