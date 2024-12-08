using System.Globalization;
using System.Windows.Controls;
using System;

namespace Sharbat.Helper;

public static class TextBoxExtensions
{
    public static double ParseDouble(this TextBox textBox)
    {
        if (double.TryParse(textBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double result))
        {
            return result;
        }
        else
        {
            throw new FormatException($"'{textBox.Text}' ni double ga aylantirishning iloji yo'q.");
        }
    }
}
