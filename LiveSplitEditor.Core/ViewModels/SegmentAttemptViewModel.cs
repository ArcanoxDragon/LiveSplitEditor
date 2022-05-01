namespace LiveSplitEditor.Core.ViewModels;

public class SegmentAttemptViewModel : ViewModelBase
{
	public SegmentAttemptViewModel(int attemptId)
	{
		AttemptId = attemptId;
	}

	public int AttemptId { get; }

	[Reactive]
	public TimeViewModel? Time { get; set; }
}