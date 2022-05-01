namespace LiveSplitEditor.Core.ViewModels;

public class SegmentViewModel : ViewModelBase
{
	public SegmentViewModel(string name)
	{
		Name = name;
	}

	public string Name { get; }

	[Reactive]
	public TimeViewModel? BestSegmentTime { get; set; }

	public SourceCache<SplitTimeViewModel, string>   SplitTimes     { get; } = new(st => st.Name);
	public SourceCache<SegmentAttemptViewModel, int> SegmentHistory { get; } = new(sa => sa.AttemptId);
}