using Avalonia.ReactiveUI;
using LiveSplitEditor.Core.DesignData;
using LiveSplitEditor.Core.ViewModels;

namespace LiveSplitEditor.App.Views;

public partial class MainWindow : ReactiveWindow<SplitFileViewModel>
{
	public MainWindow()
	{
		ViewModel = SplitFiles.TestSplitFile;

		InitializeComponent();
	}
}