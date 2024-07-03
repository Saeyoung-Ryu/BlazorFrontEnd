using Microsoft.AspNetCore.Components;
using Protocol.Type;

namespace BlazorApp1.Components.Pages;

public partial class PopupComponent
{
    [Parameter] public bool Show { get; set; }
    [Parameter] public EventCallback OnClose { get; set; }
    
    Player Player = new Player();
    bool reEnterPassword = false;
    bool isRegister = false;
    bool RememberEmail = false;
    
    private async Task RegisterBtnAsync()
    {
        
    }

    private void NeedToRegisterBtn()
    {
        
    }

    private void LoginBtnAsync()
    {
        
    }
    
    private void FindPassword()
    {
        // Your find password logic here
    }

    private void SignIn()
    {
        // Your sign in logic here
    }
    
    private void Close()
    {
        Show = false;
        OnClose.InvokeAsync();
    }
}