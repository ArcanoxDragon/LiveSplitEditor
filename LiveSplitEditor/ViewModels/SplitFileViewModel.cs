using System.Collections.ObjectModel;

namespace LiveSplitEditor.ViewModels;

public class SplitFileViewModel : ViewModelBase
{
	private string?                                version;
	private string?                                gameName;
	private string?                                categoryName;
	private ObservableCollection<AttemptViewModel> attemptHistory = new();

	public string? Version
	{
		get => this.version;
		set => SetValue(ref this.version, value);
	}

	public string? GameName
	{
		get => this.gameName;
		set => SetValue(ref this.gameName, value);
	}

	public string? CategoryName
	{
		get => this.categoryName;
		set => SetValue(ref this.categoryName, value);
	}

	public ObservableCollection<AttemptViewModel> AttemptHistory
	{
		get => this.attemptHistory;
		set => SetValue(ref this.attemptHistory, value);
	}
}