using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LiveSplitEditor.App.Views.Controls
{
	public partial class AttemptInfo : UserControl
	{
		public AttemptInfo()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}
