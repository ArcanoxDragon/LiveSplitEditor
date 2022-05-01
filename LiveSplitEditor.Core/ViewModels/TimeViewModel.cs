namespace LiveSplitEditor.Core.ViewModels;

public class TimeViewModel : ViewModelBase
{
	[Reactive]
	public TimeSpan? RealTime { get; set; }

	[Reactive]
	public TimeSpan? GameTime { get; set; }
}