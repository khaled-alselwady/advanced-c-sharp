using System;

public class TemperatureChangedEventArgs : EventArgs
{
    public double OldTemperature { get; }
    public double NewTemperature { get; }
    public double Difference { get; }

    public TemperatureChangedEventArgs(double OldTemperature, double NewTemperature)
    {
        this.OldTemperature = OldTemperature;
        this.NewTemperature = NewTemperature;
        this.Difference = NewTemperature - OldTemperature;
    }
}

public class Thermostat
{
    public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

    private double _OldTemperature;
    private double _CurrentTemperature;

    public void SetTemperature(double NewTemperature)
    {
        if (NewTemperature != _CurrentTemperature)
        {
            _OldTemperature = _CurrentTemperature;
            _CurrentTemperature = NewTemperature;

            OnTemperatureChanged(_OldTemperature, _CurrentTemperature);
        }
    }

    private void OnTemperatureChanged(double OldTemperature, double NewTemperature)
    {
        OnTemperatureChanged(new TemperatureChangedEventArgs(OldTemperature, NewTemperature));
    }

    protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
    {
        TemperatureChanged?.Invoke(this, e);
    }
}

public class Display
{
    public void Subscribe(Thermostat thermostat)
    {
        thermostat.TemperatureChanged += HandleTemperatureChange;
    }

    private void HandleTemperatureChange(object sender, TemperatureChangedEventArgs e)
    {
        Console.WriteLine($"\n\nTemperature changed:");
        Console.WriteLine($"Temperature changed from {e.OldTemperature}°C");
        Console.WriteLine($"Temperature changed to {e.NewTemperature}°C");
        Console.WriteLine($"Temperature difference to {e.Difference}°C");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Thermostat thermostat = new Thermostat();
        Display display = new Display();

        display.Subscribe(thermostat);

        thermostat.SetTemperature(10);
        thermostat.SetTemperature(10);
        thermostat.SetTemperature(20);
        thermostat.SetTemperature(5);

        Console.ReadKey();
    }
}

