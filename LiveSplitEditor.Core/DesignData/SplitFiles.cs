using LiveSplitEditor.Core.ViewModels;

namespace LiveSplitEditor.Core.DesignData;

public static class SplitFiles
{
	public static readonly SplitFileViewModel TestSplitFile = new() {
		Version = "1.2.3",
		GameName = "Sample Game",
		CategoryName = "Sample Category",
	};

	static SplitFiles()
	{
		TestSplitFile.AttemptHistory.AddOrUpdate(Attempts.AllAttempts);
	}
}