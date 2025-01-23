using System;

public class Button
{
    // Define a delegate for the event
    public delegate void ClickEventHandler(object sender, EventArgs e);

    // Define the event using the delegate
    public event ClickEventHandler Click;

    // Method to simulate a button click
    public void OnClick()
    {
        try
        {
            Console.WriteLine("Button clicked!");
            // Raise the event
            Click?.Invoke(this, EventArgs.Empty);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while handling the button click: {ex.Message}");
        }
    }
}