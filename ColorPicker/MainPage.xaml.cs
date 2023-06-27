namespace ColorPicker;

public partial class MainPage : ContentPage
{
	int _Rotation;

	public MainPage()
	{
		InitializeComponent();
        _Rotation = 0;   
	}

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var red = sldRed.Value;
        var blue = sldBlue.Value;
        var green = sldGreen.Value;

        Color color = Color.FromRgb(red, green, blue);
        SetColor(color);
    }

    private void SetColor(Color color)
    {
        btnRandom.Background = color;
        Container.BackgroundColor = color;
        lblHex.Text = $"Hex Value: {color.ToHex()}";

    }

    private void RandButton_Clicked(object sender, EventArgs e)
    {
        var random = new Random();
        var color = Color.FromRgb(
            random.Next(0, 265),
            random.Next(0, 265),
            random.Next(0, 265));
        SetColor(color);
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        var hexCode = Container.BackgroundColor.ToHex();
        Clipboard.SetTextAsync(hexCode);
    }

    private void ImageButton_Pressed(object sender, EventArgs e)
    {
        _Rotation += 355;
        imageButton.Rotation = _Rotation;
    }
}

