using LiveSplitEditor.ViewModels;

namespace LiveSplitEditor.DesignData;

public class SplitFiles
{
	public static readonly SplitFileViewModel TestSplitFile = new() {
		Version = "1.2.3",
		GameName = "Sample Game",
		CategoryName = "Sample Category",
		AttemptHistory = Attempts.AllAttempts,
	};
}