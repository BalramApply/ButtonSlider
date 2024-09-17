namespace ButtonSlider;

public partial class ButtonPage : ContentPage
{
    public ButtonPage()
    {
        InitializeComponent();
    }

    private void ButtonClicked(Object sender, EventArgs args)
    {
        Button btn = sender as Button;
        String alertBody = "";

        switch (btn.Text)
        {
            case "Default Style":
                alertBody = "you clicked the default style button.";
                break;
            case "Button 2":
                alertBody = "you clicked the button 2.";
                break;
            case "Button 3":
                alertBody = "you clicked the button 3. Its BackgroundClor " + "is Burlywood and the TextColor is SddleBrown. "
                            + "it has a 5 unit Blue border. ";
                break;
            case "Button 4":
                alertBody = "you clicked the button 4. its BackgroundColor " + "is DarkRed and the TextColor is Yellow.";
                break;
            case "Button 5":
                alertBody = "you clicked the button 5. with its transpanrent" +
                            "BackgroundColor, it just look like text";
                break;
        }
        DisplayAlert("Button Clicked", alertBody, "OK");
    }

    private void SubmitForm(Object sender, EventArgs args)
    {

    }

    private void GoSMCC(Object sender, EventArgs args)
    {

    }

    private void GoFlights(Object sender, EventArgs args)
    {

    }
}