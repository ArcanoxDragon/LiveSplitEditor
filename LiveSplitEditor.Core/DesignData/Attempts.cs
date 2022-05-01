using System.Collections.ObjectModel;
using Humanizer;
using LiveSplitEditor.Core.ViewModels;

namespace LiveSplitEditor.Core.DesignData;

public class Attempts
{
	public static readonly AttemptViewModel AbandonedAttempt = new(1) {
		Started = DateTime.Now.Subtract(2.Days()),
		IsStartedSynced = true,
		Ended = DateTime.Now.Subtract(2.Days()).Add(1.Hours()),
		IsEndedSynced = true,
	};

	public static readonly AttemptViewModel CompletedAttempt = new(2) {
		Started = DateTime.Now.Subtract(1.Days()),
		IsStartedSynced = true,
		Ended = DateTime.Now.Subtract(1.Days()).Add(2.Hours()),
		IsEndedSynced = true,
		RealTime = 2.Hours(),
		GameTime = 2.Hours().Add(15.Minutes()),
	};

	public static readonly ObservableCollection<AttemptViewModel> AllAttempts = new() {
		AbandonedAttempt,
		CompletedAttempt,
	};
}