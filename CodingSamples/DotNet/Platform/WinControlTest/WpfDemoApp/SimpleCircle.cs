using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace WpfDemoApp;

public class SimpleCircle : Control
{
    public double Radius { get; set; }

    public static readonly DependencyProperty TimeProperty 
        = DependencyProperty.Register("Time", typeof(string), typeof(SimpleCircle));
    
    public string Time
    {
        get => (string) GetValue(TimeProperty);
        set => SetValue(TimeProperty, value);
    }

    public int Count { get; set; }

    protected override void OnRender(DrawingContext drawingContext)
    {
        var story = new DoubleAnimation(Radius, 10, TimeSpan.FromSeconds(5))
        {
            AutoReverse = true,
            RepeatBehavior = new RepeatBehavior(1) //RepeatBehavior.Forever
        };
        var clock = story.CreateClock();
        var center = new Point(RenderSize.Width / 2, RenderSize.Height / 2);
        drawingContext.DrawEllipse(Brushes.Blue, new Pen(Brushes.Red, 5), center, null, Radius, clock, Radius, clock);
    }

    protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
    {
        InvalidateVisual();
        Time = DateTime.Now.ToString();
        Count += 10;
    }
}
