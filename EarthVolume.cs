using System;

class EarthVolume
{
    static void Main(string[] args)
    {
        int radius = 6378;

        double kmVolume = (4 / 3.0) * Math.PI * Math.Pow(radius, 3);

        double cubicVolume = kmVolume * 0.239913;

        Console.WriteLine("The volume of Earth in cubic kilometers is " + kmVolume + 
                          " and in cubic miles is " + cubicVolume);
    }
}
