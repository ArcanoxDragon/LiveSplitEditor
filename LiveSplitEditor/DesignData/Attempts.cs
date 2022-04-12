using System.Collections.ObjectModel;
using Humanizer;
using LiveSplitEditor.ViewModels;

namespace LiveSplitEditor.DesignData;

public class Attempts
{
	public static readonly AttemptViewModel AbandonedAttempt = new() {
		Id = 1,
		Started = DateTime.Now.Subtract(2.Days()),
		IsStartedSynced = true,
		Ended = DateTime.Now.Subtract(2.Days()).Add(1.Hours()),
		IsEndedSynced = true,
		Segments = {
			new AttemptSegmentViewModel { Segment = Segments.FirstSegment, AttemptTime = new TimeSpan(0, 4, 15) },
		},
	};

	public static readonly AttemptViewModel CompletedAttempt = new() {
		Id = 2,
		Started = DateTime.Now.Subtract(1.Days()),
		IsStartedSynced = true,
		Ended = DateTime.Now.Subtract(1.Days()).Add(2.Hours()),
		IsEndedSynced = true,
		RealTime = 2.Hours(),
		GameTime = 2.Hours().Add(15.Minutes()),
		Segments = {
			new AttemptSegmentViewModel { Segment = Segments.FirstSegment, AttemptTime = new TimeSpan(0, 3, 25) },
			new AttemptSegmentViewModel { Segment = Segments.SecondSegment, AttemptTime = new TimeSpan(0, 4, 15) },
			new AttemptSegmentViewModel { Segment = Segments.ThirdSegment, AttemptTime = new TimeSpan(0, 1, 55) },
		},
	};

	public static readonly ObservableCollection<AttemptViewModel> AllAttempts = new() {
		AbandonedAttempt,
		CompletedAttempt,
	};
}