using LiveSplitEditor.Core.ViewModels;

namespace LiveSplitEditor.Core.DesignData;

public static class Segments
{
	public static readonly SegmentViewModel FirstSegment = new("First Segment") {
		BestSegmentTime = new TimeViewModel {
			RealTime = new TimeSpan(0, 3, 10),
		},
	};

	public static readonly SegmentViewModel SecondSegment = new("Second Segment") {
		BestSegmentTime = new TimeViewModel {
			RealTime = new TimeSpan(0, 4, 6),
		},
	};

	public static readonly SegmentViewModel ThirdSegment = new("Third Segment") {
		BestSegmentTime = new TimeViewModel {
			RealTime = new TimeSpan(0, 1, 43),
		},
	};

	static Segments()
	{
		// Abandoned attempt times
		FirstSegment.SegmentHistory.AddOrUpdate(new SegmentAttemptViewModel(Attempts.AbandonedAttempt.Id) {
			Time = new TimeViewModel {
				RealTime = new TimeSpan(0, 4, 15),
			},
		});
		
		// Completed attempt times
		FirstSegment.SegmentHistory.AddOrUpdate(new SegmentAttemptViewModel(Attempts.CompletedAttempt.Id) {
			Time = new TimeViewModel {
				RealTime = new TimeSpan(0, 3, 25),
			},
		});
		SecondSegment.SegmentHistory.AddOrUpdate(new SegmentAttemptViewModel(Attempts.CompletedAttempt.Id) {
			Time = new TimeViewModel {
				RealTime = new TimeSpan(0, 4, 15),
			},
		});
		ThirdSegment.SegmentHistory.AddOrUpdate(new SegmentAttemptViewModel(Attempts.CompletedAttempt.Id) {
			Time = new TimeViewModel {
				RealTime = new TimeSpan(0, 1, 55),
			},
		});
	}
}