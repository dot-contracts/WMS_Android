using wms_android.data.Data;
using wms_android.data.Interfaces;
using wms_android.Interfaces;
using wms_android.Services;
using wms_android.ViewModels;

namespace wms_android.Views;

public partial class LoginPage : ContentPage
{
    // Constructor that accepts LoginViewModel
    public LoginPage(LoginViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    // Optional default constructor if needed
    public LoginPage()
    {
        InitializeComponent();

        // Retrieve services from the DI container
        var userService = ServiceHelper.GetService<IUserService>();
        var printerService = ServiceHelper.GetService<IPrinterService>();

        // Set the BindingContext using the resolved services
        BindingContext = new LoginViewModel(userService, printerService, this.Navigation);
    }
}


