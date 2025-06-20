using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Extensions;

namespace MauiGenericPopupError
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Dispatcher.Dispatch(async () =>
            {                
                var response = await this.ShowPopupAsync<ExampleClass?>(new GenericPopup(), new PopupOptions { CanBeDismissedByTappingOutsideOfPopup = true });
            });
		}
    }

}
