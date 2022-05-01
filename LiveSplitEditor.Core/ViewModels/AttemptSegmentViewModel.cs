using System.Diagnostics.CodeAnalysis;
using System.Reactive.Linq;

namespace LiveSplitEditor.Core.ViewModels;

[SuppressMessage("ReSharper", "UnassignedGetOnlyAutoProperty")]
public class AttemptSegmentViewModel : ViewModelBase
{
#pragma warning disable CS8618
	public AttemptSegmentViewModel(SegmentViewModel segment, AttemptViewModel attempt)
#pragma warning restore CS8618
	{
		Segment = segment;
		Attempt = attempt;

		Segment.SegmentHistory
			   .WatchValue(Attempt.Id)
			   .Select(sa => sa.Time)
			   .ToPropertyEx(this, m => m.AttemptTime);

		this.WhenAnyValue(m => m.Segment.BestSegmentTime, m => m.AttemptTime, GetGoldSplitDelta)
			.ToPropertyEx(this, m => m.GoldSplitDelta);
	}

	public SegmentViewModel Segment { get; }
	public AttemptViewModel Attempt { get; }

	[ObservableAsProperty]
	public TimeViewModel? AttemptTime { get; }

	[ObservableAsProperty]
	public TimeViewModel GoldSplitDelta { get; }

	private static TimeViewModel GetGoldSplitDelta(TimeViewModel? bestSegmentTime, TimeViewModel? attemptTime)
	{
		TimeSpan? realTimeDelta = null;
		TimeSpan? gameTimeDelta = null;

		if (attemptTime?.RealTime != null && bestSegmentTime?.RealTime != null)
			realTimeDelta = attemptTime.RealTime - bestSegmentTime.RealTime;

		if (attemptTime?.GameTime != null && bestSegmentTime?.GameTime != null)
			gameTimeDelta = attemptTime.GameTime - bestSegmentTime.GameTime;

		return new TimeViewModel { RealTime = realTimeDelta, GameTime = gameTimeDelta };
	}
}