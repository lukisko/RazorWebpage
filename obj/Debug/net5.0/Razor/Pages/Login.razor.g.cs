#pragma checksum "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/Pages/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0586e812a76a2bdd0c2b39b86f682802eac9118"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/_Imports.razor"
using assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/_Imports.razor"
using assignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/Pages/Login.razor"
using Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "form-group");
                __builder2.AddMarkupContent(4, "<label>User name:</label>\n            ");
                __builder2.OpenElement(5, "input");
                __builder2.AddAttribute(6, "type", "text");
                __builder2.AddAttribute(7, "placeholder", "user name");
                __builder2.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/Pages/Login.razor"
                                                                    username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "<label>Password:</label>\n            ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "type", "password");
                __builder2.AddAttribute(16, "placeholder", "password");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/Pages/Login.razor"
                                                                       password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "style", "color:red");
                __builder2.AddContent(22, 
#nullable restore
#line 18 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/Pages/Login.razor"
                                errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n        ");
                __builder2.OpenElement(24, "a");
                __builder2.AddAttribute(25, "href", "");
                __builder2.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/Pages/Login.razor"
                             PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(27, "\n            Login\n        ");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(28, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(29, "a");
                __builder2.AddAttribute(30, "href", "");
                __builder2.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/Pages/Login.razor"
                             PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(32, "\n            Log out\n        ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/DNP1/assignment1/assignment/Pages/Login.razor"
       
    private string username;
    private string password;
    private string errorMessage;

    public async Task PerformLogin(){
        errorMessage = "";
        try {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username,password);
            username = "";
            password = "";
            NavigationManager.NavigateTo("/");
        } catch (Exception e){
            errorMessage = e.Message;
        }
    }

    public async Task PerformLogout() {
        errorMessage = "";
        username = "";
        password ="";
        try {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        } catch (Exception e) {}
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
