using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LiveSplitEditor.App.Views.Controls
{
	public partial class AttemptSegments : UserControl
	{
		public AttemptSegments()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
