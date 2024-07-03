using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components.Pages;

public partial class HomePage
{
    private string dashBoardNameEntered = "";

    private void GoToDashboard()
    {
        Navigation.NavigateTo($"/DashBoardPage/{dashBoardNameEntered}");
    }
}