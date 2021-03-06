#pragma checksum "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AddFamily.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a446062f2358e2c860abb04c40585794c248d0e9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1.Pages
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
#line 2 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AddFamily.razor"
using global::Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AddFamily.razor"
using global::Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddFamily")]
    public partial class AddFamily : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 217 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AddFamily.razor"
       
    private Family newFamily;
    private string error;
    private string errorForAdult;
    private string errorForChild;
    private string errorForPet;
    private int addAdultId;
    private int addChildId;
    private Pet addPet;
    
    protected override async Task OnInitializedAsync()
    {
        if (MainLayout.IsLogin())
        {
            newFamily = new Family();
            error = null;
            errorForAdult = null;
            errorForChild = null;
            errorForPet = null;
            addPet = new Pet
            {
                Species = Pet.ValidSpecies[0]
            };
        }
        else
        {
            NavigationManager.NavigateTo("");
        }
    }

    private void AddAdult()
    {
        errorForAdult = newFamily.Adults.AddAdult(ModelManager.GetAllAdult().GetAdultById(addAdultId));
    }

    private void RemoveAdult(Adult adult)
    {
        newFamily.Adults.RemoveAdult(adult);
        errorForAdult = null;
    }
    
    private void AddChild()
    {
        errorForChild = newFamily.Children.AddChild(ModelManager.GetAllChild().GetChildById(addChildId));
    }
    
    private void RemoveChild(Child child)
    {
        newFamily.Children.RemoveChild(child);
        errorForChild = null;
    }
    
    private void AddPet()
    {
        errorForPet = null;
        foreach (var x in newFamily.Pets.Where(x => x.Id == addPet.Id))
        {
            errorForPet = "This pet id is used.";
            break;
        }
        if (errorForPet==null)
        {
            newFamily.Pets.Add(addPet);
            addPet = new Pet
            {
                Species = addPet.Species
            };
        }
    }
    
    private void RemovePet(Pet pet)
    {
        foreach (var x in newFamily.Pets.Where(x => x.Id == pet.Id))
        {
            newFamily.Pets.Remove(x);
            break;
        }
        errorForPet = null;
    }

    private void AddNewFamily()
    {
        error = ModelManager.AddFamily(newFamily);
        if (error==null)
        {
            NavigationManager.NavigateTo("AllFamily");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModelManager ModelManager { get; set; }
    }
}
#pragma warning restore 1591
