namespace BasicWebApp.Middlewares;

public class Pausing
{
    private RequestDelegate _next;
    private TimeSpan _delay; 
    private DateTime _recent; 

    public Pausing(RequestDelegate next, TimeSpan delay)
    {
        _next = next;
        _delay = delay;
    }

    public async Task Invoke(HttpContext context)
    {
        var current = DateTime.Now; 
        if(current < _recent + _delay)
            await context.Response.WriteAsync("Server busy, try after some time...");
        else
        {
            _recent = current;
            await _next.Invoke(context);
        }
    }
}