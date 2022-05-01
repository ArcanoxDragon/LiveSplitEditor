using System.Diagnostics.CodeAnalysis;

namespace LiveSplitEditor.Core.ViewModels;

[SuppressMessage("ReSharper", "UnassignedGetOnlyAutoProperty")]
public class AttemptViewModel : ViewModelBase
{
	public AttemptViewModel(int id)
	{
		Id = id;

		this.WhenAnyValue(m => m.RealTime, m => m.GameTime, (rt, gt) => rt.HasValue || gt.HasValue)
			.ToPropertyEx(this, m => m.IsCompleted);

		this.WhenAnyValue(m => m.IsCompleted, c => !c)
			.ToPropertyEx(this, m => m.IsAbandoned);
	}

	public int Id { get; }

	[Reactive]
	public DateTime? Started { get; set; }

	[Reactive]
	public DateTime? Ended { get; set; }

	[Reactive]
	public bool IsStartedSynced { get; set; }

	[Reactive]
	public bool IsEndedSynced { get; set; }

	[Reactive]
	public TimeSpan? RealTime { get; set; }

	[Reactive]
	public TimeSpan? GameTime { get; set; }

	[ObservableAsProperty]
	public bool IsCompleted { get; }

	[ObservableAsProperty]
	public bool IsAbandoned { get; }
}