using System.Globalization;
using Avalonia.Data.Converters;

namespace LiveSplitEditor.App.Converters;

public class BooleanSelectorConverter : IValueConverter
{
	public object? TrueValue  { get; set; }
	public object? FalseValue { get; set; }

	public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
		=> value is true ? TrueValue : FalseValue;

	public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
		=> throw new NotSupportedException();
}