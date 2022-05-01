using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using LiveSplitEditor.Core.ViewModels;

namespace LiveSplitEditor.App.Views.Tabs;

public partial class AttemptsTab : ReactiveUserControl<AttemptsViewModel>
{
	public AttemptsTab()
	{
		InitializeComponent();
	}

	private void InitializeComponent()
	{
		AvaloniaXamlLoader.Load(this);
	}
}