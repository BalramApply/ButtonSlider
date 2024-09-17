namespace ButtonSlider;

public partial class SliderPage : ContentPage
{
    public SliderPage()
    {
        InitializeComponent();
    }

    private void mySlider100Changed(Object sender, ValueChangedEventArgs args)
    {
        Slider sldr = sender as Slider;
        int newValue = (int)sldr.Value;

        lblSlider100Value.Text = String.Concat("the slider value is ", newValue, "[0 - 100");
    }

    private void SliderPercentChanged(Object sender, ValueChangedEventArgs args)
    {
        Slider sldr = sender as Slider;
        double newValue = sldr.Value;
        lblSliderPercentValue.Text = newValue.ToString("N2") + "%";
    }

    private void SliderCatChanged(Object sender, ValueChangedEventArgs args)
    {
        Slider sldr = sender as Slider;
        int newValue = (int)sldr.Value;
        lblSliderCatValue.Text = newValue.ToString("");
    }
}