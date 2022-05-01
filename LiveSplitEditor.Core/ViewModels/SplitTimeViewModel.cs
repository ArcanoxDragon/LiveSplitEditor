namespace LiveSplitEditor.Core.ViewModels
{
	public class SplitTimeViewModel : ViewModelBase
	{
		public SplitTimeViewModel(string name)
		{
			Name = name;
		}

		public string Name { get; }

		[Reactive]
		public TimeViewModel? Time { get; set; }
	}
}