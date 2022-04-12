using System.Globalization;
using System.Windows.Data;

namespace LiveSplitEditor.Converters
{
	public class BooleanSelectorConverter : IValueConverter
	{
		public object? TrueValue  { get; set; }
		public object? FalseValue { get; set; }

		public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
			=> value is true ? TrueValue : FalseValue;

		public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
			=> throw new NotSupportedException();
	}
}