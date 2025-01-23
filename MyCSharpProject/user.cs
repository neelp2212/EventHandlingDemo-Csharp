using System;

public class User
{
    private string name;

    public User(string name)
    {
        this.name = name;
    }

    // Method to handle the button click event
    public void OnButtonClick(object sender, EventArgs e)
    {
        try
        {
            Console.WriteLine($"{name} received the button click event.");
            // Simulate an error for demonstration purposes
            if (name == "Alice")
            {
                throw new InvalidOperationException("Simulated error for user Alice.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred in {name}'s event handler: {ex.Message}");
        }
    }
}