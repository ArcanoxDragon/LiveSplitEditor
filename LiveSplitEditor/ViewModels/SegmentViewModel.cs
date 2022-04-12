namespace LiveSplitEditor.ViewModels;

public class SegmentViewModel : ViewModelBase
{
	private int       index;
	private string?   name;
	private TimeSpan? bestSegmentTime;

	public int Index
	{
		get => this.index;
		set
		{
			RaisePropertyChanging(nameof(Number));
			SetValue(ref this.index, value);
			RaisePropertyChanged(nameof(Number));
		}
	}

	public string? Name
	{
		get => this.name;
		set => SetValue(ref this.name, value);
	}

	public TimeSpan? BestSegmentTime
	{
		get => this.bestSegmentTime;
		set => SetValue(ref this.bestSegmentTime, value);
	}

	public int Number => Index + 1;
}