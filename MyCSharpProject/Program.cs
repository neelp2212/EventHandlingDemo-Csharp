using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Create a button instance
            Button button = new Button();

            // Create a user instance
            User user = new User("User1");

            // Subscribe to the button's Click event
            button.Click += user.OnButtonClick;

            // Simulate button clicks
            button.OnClick(); // This will trigger the event
            button.OnClick(); // This will trigger the event again
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}