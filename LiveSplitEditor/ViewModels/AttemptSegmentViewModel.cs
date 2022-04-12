using System.ComponentModel;

namespace LiveSplitEditor.ViewModels;

public class AttemptSegmentViewModel : ViewModelBase
{
	private SegmentViewModel? segment;
	private TimeSpan?         attemptTime;

	public SegmentViewModel? Segment
	{
		get => this.segment;
		set
		{
			if (this.segment == value)
				return;

			if (this.segment != null)
			{
				this.segment.PropertyChanging -= ValueOnPropertyChanging;
				this.segment.PropertyChanged -= ValueOnPropertyChanged;
			}

			RaisePropertyChanging(nameof(GoldSplitDelta));
			SetValue(ref this.segment, value);
			RaisePropertyChanged(nameof(GoldSplitDelta));

			if (value != null)
			{
				value.PropertyChanging += ValueOnPropertyChanging;
				value.PropertyChanged += ValueOnPropertyChanged;
			}
		}
	}

	public TimeSpan? AttemptTime
	{
		get => this.attemptTime;
		set
		{
			RaisePropertyChanging(nameof(GoldSplitDelta));
			SetValue(ref this.attemptTime, value);
			RaisePropertyChanged(nameof(GoldSplitDelta));
		}
	}

	public TimeSpan? GoldSplitDelta
	{
		get
		{
			if (AttemptTime is not { } attemptTime || Segment is not { BestSegmentTime: { } bestSegmentTime })
				return null;

			return attemptTime - bestSegmentTime;
		}
	}

	private void ValueOnPropertyChanging(object? sender, PropertyChangingEventArgs e)
	{
		if (e.PropertyName == nameof(SegmentViewModel.BestSegmentTime))
			RaisePropertyChanging(nameof(GoldSplitDelta));
	}

	private void ValueOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
	{
		if (e.PropertyName == nameof(SegmentViewModel.BestSegmentTime))
			RaisePropertyChanged(nameof(GoldSplitDelta));
	}
}