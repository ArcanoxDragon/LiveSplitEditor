using LiveSplitEditor.DesignData;

namespace LiveSplitEditor;

public partial class MainWindow
{
	public MainWindow()
	{
		InitializeComponent();

		DataContext = SplitFiles.TestSplitFile;
	}
}