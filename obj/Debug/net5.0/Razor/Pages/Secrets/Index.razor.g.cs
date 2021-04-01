#pragma checksum "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae247eb8490b49cf08f7d19a5b089fe44cc8338c"
// <auto-generated/>
#pragma warning disable 1591
namespace keyvault.Pages.Secrets
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using keyvault;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\wjones\source\repos\keyvault\keyvault.web\_Imports.razor"
using keyvault.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor"
using web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/secrets")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Secrets</h1>");
#nullable restore
#line 10 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor"
 if (SecretList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Secret Name</th>\r\n                <th>Id</th>\r\n                <th>Updated On</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 26 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor"
             foreach (var SecretObject in SecretList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 29 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor"
                         SecretObject.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 31 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor"
                         SecretObject.value

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, "\r\n                        ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor"
                                          () => Reveal(SecretObject)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "X");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 34 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor"
                         SecretObject.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 35 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor"
                         SecretObject.updatedOn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", "/secrets/details/" + (
#nullable restore
#line 36 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor"
                                                   SecretObject.name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "View");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "href", "/secrets/edit/" + (
#nullable restore
#line 37 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor"
                                                SecretObject.name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\wjones\source\repos\keyvault\keyvault.web\Pages\Secrets\Index.razor"
       

    private List<SecretIndexViewModel> SecretList;

    protected override async Task OnInitializedAsync()
    {
        try 
        {
            SecretList = await _secretService.GetAll();
        }
        catch(AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
        catch(Exception e)
        {
            throw e;
        }

    }

    async void Reveal(SecretIndexViewModel secret)
    {
        SecretList.Where(a => a.name != secret.name && a.Revealed == true).ToList().ForEach(b => b.Reveal());
        if(secret.Revealed == false)
        {
            secret.value = (await _secretService.Reveal(secret.name)).value;
        }
        secret.Reveal();
        this.StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private keyvault.web.services.SecretService _secretService { get; set; }
    }
}
#pragma warning restore 1591