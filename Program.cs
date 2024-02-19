class Uptime
{
    static void Main(string[] args)
    {
        var ticks = Environment.TickCount;
        
        var Days = ticks / 86400000;
        ticks %= 86400000;

        var Hours = ticks / 3600000;
        ticks %= 3600000;

        var Minutes = ticks / 60000;
        ticks %= 60000;

        var now = DateTime.Now;
        Console.WriteLine(
            now.Hour + ":" +
            now.Minute.ToString().PadLeft(2,'0') + ":" +
            now.Second.ToString().PadLeft(2,'0') +
            "  up " + Days + " days,  " + Hours + ":" + Minutes.ToString().PadLeft(2,'0') +
            ",  1 user,  load average: 0.00, 0.00, 0.00");
    }
}

