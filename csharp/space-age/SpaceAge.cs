using System;

public class SpaceAge
{
    private double seconds { get; set; }
    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth()
    {
        double age = this.seconds / 31557600;
        return age;
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnMercury()
    {
        double age = (this.seconds / 31557600) / 0.2408467;
        return age;
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnVenus()
    {
        double age = (this.seconds / 31557600) / 0.61519726;
        return age;
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnMars()
    {
        double age = (this.seconds / 31557600) / 1.8808158;
        return age;
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnJupiter()
    {
        double age = (this.seconds / 31557600) / 11.862615;
        return age;
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnSaturn()
    {
        double age = (this.seconds / 31557600) / 29.447498;
        return age;
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnUranus()
    {
        double age = (this.seconds / 31557600) / 84.016846;
        return age;
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnNeptune()
    {
        double age = (this.seconds / 31557600) / 164.79132;
        return age;
        throw new NotImplementedException("You need to implement this function.");
    }
}