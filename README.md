# Temperature Calculator 2.0

Enhanced C# temperature conversion application with GUI and extended functionality.

## Features
- Windows Forms GUI interface
- Real-time conversion
- Extended temperature scales support
- Conversion history
- Export capabilities

## Technical Implementation
```csharp
public class AdvancedTemperatureConverter
{
    public double Convert(double value, TemperatureScale from, TemperatureScale to)
    {
        double kelvin = ToKelvin(value, from);
        return FromKelvin(kelvin, to);
    }
    
    private double ToKelvin(double value, TemperatureScale scale)
    {
        return scale switch
        {
            TemperatureScale.Celsius => value + 273.15,
            TemperatureScale.Fahrenheit => (value + 459.67) * 5/9,
            TemperatureScale.Kelvin => value,
            _ => throw new ArgumentException("Invalid scale")
        };
    }
}
```

## Project Structure
```
TemperatureCalculator2.0/
├── Program.cs
├── Forms/
│   ├── MainForm.cs
│   └── MainForm.Designer.cs
├── Logic/
│   └── TemperatureConverter.cs
└── Models/
    └── ConversionHistory.cs
```

## Enhancements from v1.0
- GUI interface
- Support for Rankine scale
- Conversion history tracking
- Export to CSV
- Enhanced error handling

## Installation
1. Clone repository
2. Open in Visual Studio
3. Build and run

## License
MIT License
