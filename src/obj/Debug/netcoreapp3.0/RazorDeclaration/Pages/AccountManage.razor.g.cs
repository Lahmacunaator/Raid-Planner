// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorLoginDiscord.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lahmac\Repos\LARaidPlanner\src\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lahmac\Repos\LARaidPlanner\src\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lahmac\Repos\LARaidPlanner\src\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lahmac\Repos\LARaidPlanner\src\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lahmac\Repos\LARaidPlanner\src\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lahmac\Repos\LARaidPlanner\src\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lahmac\Repos\LARaidPlanner\src\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lahmac\Repos\LARaidPlanner\src\_Imports.razor"
using BlazorLoginDiscord;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lahmac\Repos\LARaidPlanner\src\_Imports.razor"
using BlazorLoginDiscord.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lahmac\Repos\LARaidPlanner\src\Pages\AccountManage.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lahmac\Repos\LARaidPlanner\src\Pages\AccountManage.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account/Manage")]
    public partial class AccountManage : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Lahmac\Repos\LARaidPlanner\src\Pages\AccountManage.razor"
       
    private BlazorLoginDiscord.Data.UserService.DiscordUserClaim claim;
    private string token;
    private List<BlazorLoginDiscord.Data.UserService.Guild> guilds;

    protected override async Task OnInitializedAsync()
    {
        claim = usrSvc.GetInfo(httpContextAccessor.HttpContext);
        token = await usrSvc.GetTokenAsync(httpContextAccessor.HttpContext);
        guilds = await usrSvc.GetUserGuildsAsync(httpContextAccessor.HttpContext);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorLoginDiscord.Data.UserService usrSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
    }
}
#pragma warning restore 1591
