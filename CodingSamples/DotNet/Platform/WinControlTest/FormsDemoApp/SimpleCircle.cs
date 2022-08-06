namespace FormsDemoApp;

public class SimpleCircle : Control
{
    private Color borderColor = Color.Red;

    public int Radius { get; set; }

    protected override void OnPaint(PaintEventArgs e)
    {
        var rect = new Rectangle(Width / 2 - Radius, Height / 2 - Radius, 2 * Radius, 2 * Radius);
        e.Graphics.FillEllipse(Brushes.Blue, rect);
        using var pen = new Pen(borderColor, 5);
        e.Graphics.DrawEllipse(pen, rect);
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        borderColor = Color.Yellow;
        Refresh();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        borderColor = Color.Red;
        Refresh();
    }
}