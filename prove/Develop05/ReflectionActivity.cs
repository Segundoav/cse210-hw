public class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you accomplished something difficult.",
        "Think of a time when you helped someone in need."
    };

    public override void ExecuteActivity()
    {
        StartActivity("Reflection Exercise", "This activity will help you reflect on moments in your life.");
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");
        ShowSpinner(duration);
        EndActivity("Reflection Exercise");
    }
}
