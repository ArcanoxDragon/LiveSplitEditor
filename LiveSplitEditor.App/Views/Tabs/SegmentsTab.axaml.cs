using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LiveSplitEditor.App.Views.Tabs
{
	public partial class SegmentsTab : UserControl
	{
		public SegmentsTab()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}