namespace LiveSplitEditor.Core.ViewModels;

public class SplitFileViewModel : ViewModelBase
{
	[Reactive]
	public string? Version { get; set; }

	[Reactive]
	public string? GameName { get; set; }

	[Reactive]
	public string? CategoryName { get; set; }

	public SourceCache<AttemptViewModel, int>    AttemptHistory { get; } = new(a => a.Id);
	public SourceCache<SegmentViewModel, string> Segments       { get; } = new(s => s.Name);
}