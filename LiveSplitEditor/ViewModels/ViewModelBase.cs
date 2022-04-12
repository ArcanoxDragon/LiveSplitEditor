using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace LiveSplitEditor.ViewModels;

public abstract class ViewModelBase : INotifyPropertyChanging, INotifyPropertyChanged
{
	public event PropertyChangingEventHandler? PropertyChanging;
	public event PropertyChangedEventHandler?  PropertyChanged;

	protected void RaisePropertyChanging([CallerMemberName] string? propertyName = null)
		=> PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));

	protected void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

	[NotifyPropertyChangedInvocator]
	protected void SetValue<T>(ref T backingField, T value, [CallerMemberName] string? propertyName = null)
	{
		RaisePropertyChanging(propertyName);
		backingField = value;
		RaisePropertyChanged(propertyName);
	}
}