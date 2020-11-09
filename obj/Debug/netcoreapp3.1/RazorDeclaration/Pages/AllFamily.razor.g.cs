#pragma checksum "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75ee2ef1a2804ea0ded252d2f41e0a24dc02b216"
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
#line 2 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
using global::Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
using global::Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AllFamily")]
    public partial class AllFamily : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 133 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
       
    private static readonly List<string> KeyWordList = new[]
    {
        "All","Address","Person Id","Number Of Person"
    }.ToList();
    private FamilyList allFamily;
    private string error;
    private string searchKeyWord;
    private string searchInfo1;
    private string searchInfo2;
    private string searchInfo3;
    private string historyKeyWord;
    private string historySearchInfo1;
    
    protected override async Task OnInitializedAsync()
    {
        if (MainLayout.IsLogin())
        {
            InitAllFamily();
        }
        else
        {
            NavigationManager.NavigateTo("");
        }
    }

    private void InitAllFamily()
    {
        allFamily = ModelManager.GetAllFamily();
    }
    
    private void ChangeKeyWord()
    {
        if (historyKeyWord!=searchKeyWord)
        {
            error = null;
            switch (searchKeyWord)
            {
                case "All":
                    break;
                case "Address":
                    searchInfo1 = null;
                    searchInfo2 = "1";
                    searchInfo3 = null;
                    break;
                case "Person Id":
                    searchInfo1 = "0";
                    searchInfo2 = null;
                    searchInfo3 = null;
                    break;
                case "Number Of Person":
                    searchInfo1 = "All";
                    searchInfo2 = "0";
                    searchInfo3 = "0";
                    break;
            }
            SearchByKeyWord();
        }
        historyKeyWord = searchKeyWord;
    }

    private void ChangeSearchInfo1()
    {
        if (historySearchInfo1!=searchInfo1)
        {
            error = null;
            CheckSearchInfo("Number Of Person",0);
            SearchByKeyWord();
        }
        historySearchInfo1 = searchInfo1;
    }
    
    private void SearchByKeyWord()
    {
        error = null;
        InitAllFamily();
        switch (searchKeyWord)
        {
            case "All":
                break;
            case "Address":
                if (!string.IsNullOrEmpty(searchInfo1))
                {
                    allFamily = allFamily.GetFamilyListByStreetName(searchInfo1);
                }
                if (!string.IsNullOrEmpty(searchInfo2))
                {
                    allFamily = allFamily.GetFamilyListByHouseNumber(int.Parse(searchInfo2));
                }
                break;
            case "Person Id":
                if (!string.IsNullOrEmpty(searchInfo1))
                {
                    if (ModelManager.GetAllAdult().GetAdultById(int.Parse(searchInfo1))!=null)
                    {
                        allFamily = allFamily.GetFamilyListByPerson(ModelManager.GetAllAdult().GetAdultById(int.Parse(searchInfo1)));
                    }
                    else if(ModelManager.GetAllChild().GetChildById(int.Parse(searchInfo1))!=null)
                    {
                        allFamily = allFamily.GetFamilyListByPerson(ModelManager.GetAllChild().GetChildById(int.Parse(searchInfo1)));
                    }
                    else
                    {
                        allFamily = new FamilyList();
                    }
                }
                break;
            case "Number Of Person":
                CheckSearchInfo(searchKeyWord,0);
                switch (searchInfo1)
                {
                    case "All":
                        foreach (var family in allFamily.GetAllWithList())
                        {
                            if (!(family.Adults.GetCount()+family.Children.GetCount()>=int.Parse(searchInfo2)&&family.Adults.GetCount()+family.Children.GetCount()<=int.Parse(searchInfo3)))
                            {
                                allFamily.families.Remove(family);
                            }
                        }
                        break;
                    case "Adult":
                        foreach (var family in allFamily.GetAllWithList())
                        {
                            if (!(family.Adults.GetCount()>=int.Parse(searchInfo2)&&family.Adults.GetCount()<=int.Parse(searchInfo3)))
                            {
                                allFamily.families.Remove(family);
                            }
                        }
                        break;
                    case "Child":
                        foreach (var family in allFamily.GetAllWithList())
                        {
                            if (!(family.Children.GetCount()>=int.Parse(searchInfo2)&&family.Children.GetCount()<=int.Parse(searchInfo3)))
                            {
                                allFamily.families.Remove(family);
                            }
                        }
                        break;
                }
                break;
        }
    }
    
    private void CheckSearchInfo(string keyword,int min)
    {
        try
        {
            if (string.IsNullOrEmpty(searchInfo2))
            {
                searchInfo2 = "" + min;
            }
            else if(int.Parse(searchInfo2)<min)
            {
                searchInfo2 = "" + min;
            }
            if (string.IsNullOrEmpty(searchInfo3))
            {
                searchInfo2 = "" + int.Parse(searchInfo2);
            }
            if (int.Parse(searchInfo3)<int.Parse(searchInfo2))
            {
                searchInfo3 = "" + int.Parse(searchInfo2);
            }
        }
        catch (Exception e)
        {
            error = keyword + " is a number.";
        }
    }
    
    private void ManageOldFamily(Family targetFamily)
    {
        NavigationManager.NavigateTo("/ManageFamily");
        ManageFamily.SetInfo(targetFamily);
    }

    private void RemoveFamily(Family targetFamily)
    {
        ModelManager.RemoveFamily(targetFamily);
        InitAllFamily();
        SearchByKeyWord();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModelManager ModelManager { get; set; }
    }
}
#pragma warning restore 1591
