public class BreathingActivity : MindfulnessActivity
{
    public override void ExecuteActivity()
    {
        StartActivity("Breathing Exercise", "This activity will help you relax by guiding you through slow breathing.");
        for (int i = 0; i < duration / 2; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(3);
            Console.WriteLine("Now breathe out...");
            ShowSpinner(3);
        }
        EndActivity("Breathing Exercise");
    }
}
