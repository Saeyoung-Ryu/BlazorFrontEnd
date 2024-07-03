using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components.Pages;

public partial class DashBoardPage
{
    [Parameter]
    public string DashBoardName { get; set; }

    protected override void OnInitialized()
    {
        if (string.IsNullOrEmpty(DashBoardName))
        {
            var uri = Navigation.ToAbsoluteUri(Navigation.Uri);
            var segments = uri.AbsolutePath.Split('/');
            if (segments.Length > 2)
            {
                DashBoardName = segments[2];
            }
            
            if (string.IsNullOrEmpty(DashBoardName))
            {
                Navigation.NavigateTo("/Home");
            }
            
            // dashBoardName 존재하는지 찾기
        }
    }
}