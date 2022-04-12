﻿using System.Globalization;
using System.Windows.Data;

namespace LiveSplitEditor.Converters
{
	public class NullableVisibilityConverter : IValueConverter
	{
		public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
		{
			if (value is null)
				return Visibility.Collapsed;

			return Visibility.Visible;
		}

		public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
			=> throw new NotSupportedException();
	}
}