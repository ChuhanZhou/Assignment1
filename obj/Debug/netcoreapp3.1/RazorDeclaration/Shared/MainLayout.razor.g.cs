#pragma checksum "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b51444ef953cdd4df576c2205998c34bd6e36dc"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Shared\MainLayout.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Shared\MainLayout.razor"
 
    private static bool show = false;
    
    public static void Login()
    {
        show = true;
    }
    
    public static void Logout()
    {
        show = false;
    }
    
    public static bool IsLogin()
    {
        return show;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591