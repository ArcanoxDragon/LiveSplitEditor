using System.Collections.ObjectModel;
using System.Reactive.Disposables;
using System.Reactive.Linq;

namespace LiveSplitEditor.Core.ViewModels
{
	public class AttemptsViewModel : ViewModelBase, IActivatableViewModel
	{
		private ReadOnlyObservableCollection<AttemptViewModel>? attempts;

		public AttemptsViewModel() => this.WhenActivated(disposables => {
			this.WhenAnyValue(m => m.SplitFile)
				.Where(sf => sf != null)
				.SelectMany(sf => sf!.AttemptHistory.Connect())
				.DisposeMany()
				.Bind(out this.attempts)
				.Subscribe()
				.DisposeWith(disposables);
		});

		public ViewModelActivator Activator { get; } = new();

		[Reactive]
		public SplitFileViewModel? SplitFile { get; set; }

		[ObservableAsProperty]
		public ReadOnlyObservableCollection<AttemptViewModel>? Attempts => this.attempts;
	}
}