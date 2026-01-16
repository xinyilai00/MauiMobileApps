using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class ControlEntryResult : ContentPage, IQueryAttributable
{
	public ControlEntryResult()
	{
		InitializeComponent();
		BindingContext = new ControlEntryResultViewModel();
    }

	public void ApplyQueryAttributes(IDictionary<string, object> query)
	{
		if (BindingContext is ControlEntryResultViewModel vm
			&& query.TryGetValue("entryText", out var value)
			&& value is string text)
		{
			vm.EntryText = text;
		}
	}
}