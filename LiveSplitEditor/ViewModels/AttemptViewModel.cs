using System.Collections.ObjectModel;

namespace LiveSplitEditor.ViewModels;

public class AttemptViewModel : ViewModelBase
{
	private int       id;
	private DateTime? started;
	private DateTime? ended;
	private bool      isStartedSynced;
	private bool      isEndedSynced;
	private TimeSpan? realTime;
	private TimeSpan? gameTime;

	public int Id
	{
		get => this.id;
		set => SetValue(ref this.id, value);
	}

	public DateTime? Started
	{
		get => this.started;
		set => SetValue(ref this.started, value);
	}

	public DateTime? Ended
	{
		get => this.ended;
		set => SetValue(ref this.ended, value);
	}

	public bool IsStartedSynced
	{
		get => this.isStartedSynced;
		set => SetValue(ref this.isStartedSynced, value);
	}

	public bool IsEndedSynced
	{
		get => this.isEndedSynced;
		set => SetValue(ref this.isEndedSynced, value);
	}

	public TimeSpan? RealTime
	{
		get => this.realTime;
		set
		{
			RaisePropertyChanging(nameof(IsCompleted));
			RaisePropertyChanging(nameof(IsAbandoned));
			SetValue(ref this.realTime, value);
			RaisePropertyChanged(nameof(IsCompleted));
			RaisePropertyChanged(nameof(IsAbandoned));
		}
	}

	public TimeSpan? GameTime
	{
		get => this.gameTime;
		set
		{
			RaisePropertyChanging(nameof(IsCompleted));
			RaisePropertyChanging(nameof(IsAbandoned));
			SetValue(ref this.gameTime, value);
			RaisePropertyChanged(nameof(IsCompleted));
			RaisePropertyChanged(nameof(IsAbandoned));
		}
	}

	public ObservableCollection<AttemptSegmentViewModel> Segments { get; } = new();

	public bool IsCompleted => RealTime.HasValue || GameTime.HasValue;
	public bool IsAbandoned => !IsCompleted;
}