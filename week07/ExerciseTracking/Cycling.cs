using System;
using System.Collections.Generic;
public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return (speed / 60.0) * minutes;
    }

    public override double GetPace()
    {
        return 60.0 / speed;
    }
}
