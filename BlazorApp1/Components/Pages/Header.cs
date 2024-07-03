using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components.Pages;

public partial class Header
{
    string reEnterPassword = string.Empty;
    
    bool isRegister = false;
    private void NavigateToInitPage()
    {
        Navigation.NavigateTo("/Home");
    }

    private async Task LoginBtnAsync()
    {
        
    }
    
    private async Task RegisterBtnAsync()
    {
        
    }
    

    private void NeedToRegisterBtn()
    {
        isRegister = true;
    }
}