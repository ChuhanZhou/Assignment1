#pragma checksum "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75ee2ef1a2804ea0ded252d2f41e0a24dc02b216"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Family List</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "float: left;width: 100%;height: auto");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "float: left");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<p style=\"float: left;position: relative;top: 8px\">\r\n            Key word:\r\n        </p>\r\n        ");
            __builder.OpenElement(8, "select");
            __builder.AddAttribute(9, "class", "form-control selectpicker");
            __builder.AddAttribute(10, "style", "float: left;position: relative;width:auto;height: 32px;top: 4px");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                                                                                                                                                          ChangeKeyWord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                                                                                                                                 searchKeyWord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchKeyWord = __value, searchKeyWord));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 16 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
             foreach (var keyWord in KeyWordList)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "                ");
            __builder.OpenElement(16, "option");
            __builder.AddContent(17, 
#nullable restore
#line 18 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                         keyWord

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 19 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 22 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
     switch (searchKeyWord)
    {
        case "All":
            break;
        case "Address":

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "style", "float: left");
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "p");
            __builder.AddAttribute(27, "style", "float: left;position: relative;height: 32px;top: 4px");
            __builder.AddMarkupContent(28, "\r\n                    Street Name:");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "type", "text");
            __builder.AddAttribute(31, "style", "width:150px");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                                                                               searchInfo1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchInfo1 = __value, searchInfo1));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "style", "float: left");
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "p");
            __builder.AddAttribute(41, "style", "float: left;position: relative;height: 32px;top: 4px");
            __builder.AddMarkupContent(42, "\r\n                    House Number:");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "number");
            __builder.AddAttribute(45, "min", "1");
            __builder.AddAttribute(46, "style", "width:150px");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                                                                                          searchInfo2

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchInfo2 = __value, searchInfo2, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 37 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
            break;
        case "Person Id":

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "style", "float: left");
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "p");
            __builder.AddAttribute(57, "style", "float: left;position: relative;height: 32px;top: 4px");
            __builder.AddMarkupContent(58, "\r\n                    : ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "type", "number");
            __builder.AddAttribute(61, "min", "0");
            __builder.AddAttribute(62, "style", "width:150px");
            __builder.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                                                                               searchInfo1

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchInfo1 = __value, searchInfo1, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 44 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
            break;
        case "Number Of Person":

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, "            ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "style", "float: left");
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.AddMarkupContent(72, "<p style=\"float: left;position: relative;height: 32px;top: 6px\">\r\n                    Type:\r\n                </p>\r\n                ");
            __builder.OpenElement(73, "select");
            __builder.AddAttribute(74, "class", "form-control selectpicker");
            __builder.AddAttribute(75, "style", "float: left;position: relative;width:auto;height: 32px;top: 4px");
            __builder.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                                                                                                                                                                 ChangeSearchInfo1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                                                                                                                                          searchInfo1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchInfo1 = __value, searchInfo1));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.OpenElement(80, "option");
            __builder.AddContent(81, "All");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                    ");
            __builder.OpenElement(83, "option");
            __builder.AddContent(84, "Adult");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                    ");
            __builder.OpenElement(86, "option");
            __builder.AddContent(87, "Child");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n            ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "style", "float: left");
            __builder.AddMarkupContent(93, "\r\n                ");
            __builder.OpenElement(94, "p");
            __builder.AddAttribute(95, "style", "float: left;position: relative;height: 32px;top: 4px");
            __builder.AddMarkupContent(96, "\r\n                    From:");
            __builder.OpenElement(97, "input");
            __builder.AddAttribute(98, "type", "number");
            __builder.AddAttribute(99, "min", "0");
            __builder.AddAttribute(100, "style", "width:150px");
            __builder.AddAttribute(101, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                                                                                  searchInfo2

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(102, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchInfo2 = __value, searchInfo2, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n            ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "style", "float: left");
            __builder.AddMarkupContent(108, "\r\n                ");
            __builder.OpenElement(109, "p");
            __builder.AddAttribute(110, "style", "float: left;position: relative;height: 32px;top: 4px");
            __builder.AddMarkupContent(111, "\r\n                    to:");
            __builder.OpenElement(112, "input");
            __builder.AddAttribute(113, "type", "number");
            __builder.AddAttribute(114, "min", "0");
            __builder.AddAttribute(115, "style", "width:150px");
            __builder.AddAttribute(116, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                                                                                searchInfo3

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(117, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchInfo3 = __value, searchInfo3, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
#nullable restore
#line 66 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
            break;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
     if (searchKeyWord != "All")
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(121, "        ");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "style", "float: left");
            __builder.AddMarkupContent(124, "\r\n            ");
            __builder.OpenElement(125, "button");
            __builder.AddAttribute(126, "class", "btn-primary");
            __builder.AddAttribute(127, "style", "float: left;position: relative;width:auto;left: 10px;height: 32px;top: 4px;border-radius: 5px");
            __builder.AddAttribute(128, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                                                                                                                                                        SearchByKeyWord

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(129, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, " \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n");
#nullable restore
#line 73 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "style", "float: left;width: 100%;height: auto");
            __builder.AddMarkupContent(135, "\r\n    ");
            __builder.OpenElement(136, "p");
            __builder.AddAttribute(137, "style", "color: red");
            __builder.AddMarkupContent(138, "\r\n        ");
            __builder.AddContent(139, 
#nullable restore
#line 77 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
         error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(140, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n");
            __builder.OpenElement(143, "div");
            __builder.AddMarkupContent(144, "\r\n");
#nullable restore
#line 81 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
     if (allFamily == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(145, "        ");
            __builder.AddMarkupContent(146, "<p>       \r\n            <em>Loading...</em>\r\n        </p>\r\n");
#nullable restore
#line 86 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
    }
    else if (allFamily.GetCount()==0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(147, "        ");
            __builder.AddMarkupContent(148, "<p>       \r\n            <em>Don\'t have any family.</em>\r\n        </p>\r\n");
#nullable restore
#line 92 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
    }
    else 
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(149, "        ");
            __builder.OpenElement(150, "table");
            __builder.AddAttribute(151, "class", "table");
            __builder.AddMarkupContent(152, "        \r\n            ");
            __builder.AddMarkupContent(153, @"<thead>
            <tr>
                <th>Street Name</th>
                <th>House Number</th>
                <th>Number of Adults</th>
                <th>Number of Children</th>
                <th>Number of Pets</th>
                <th>Manage</th>
                <th>Delete</th>
            </tr>
            </thead>        
            ");
            __builder.OpenElement(154, "tbody");
            __builder.AddMarkupContent(155, "\r\n");
#nullable restore
#line 108 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
             foreach (var family in allFamily.families) {           

#line default
#line hidden
#nullable disable
            __builder.AddContent(156, "                ");
            __builder.OpenElement(157, "tr");
            __builder.AddMarkupContent(158, "               \r\n                    ");
            __builder.OpenElement(159, "td");
            __builder.AddContent(160, 
#nullable restore
#line 110 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                         family.StreetName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "               \r\n                    ");
            __builder.OpenElement(162, "td");
            __builder.AddContent(163, 
#nullable restore
#line 111 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                         family.HouseNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n                    ");
            __builder.OpenElement(165, "td");
            __builder.AddContent(166, 
#nullable restore
#line 112 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                         family.Adults.adults.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n                    ");
            __builder.OpenElement(168, "td");
            __builder.AddContent(169, 
#nullable restore
#line 113 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                         family.Children.childs.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n                    ");
            __builder.OpenElement(171, "td");
            __builder.AddContent(172, 
#nullable restore
#line 114 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                         family.Pets.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\r\n                    ");
            __builder.OpenElement(174, "td");
            __builder.AddMarkupContent(175, "\r\n                        ");
            __builder.OpenElement(176, "button");
            __builder.AddAttribute(177, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 116 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                                            ()=>ManageOldFamily(family)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(178, "\r\n                            <i class=\"oi oi-spreadsheet\" style=\"color: black\"></i>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n                    ");
            __builder.OpenElement(181, "td");
            __builder.AddMarkupContent(182, "\r\n                        ");
            __builder.OpenElement(183, "button");
            __builder.AddAttribute(184, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 121 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
                                            ()=>RemoveFamily(family)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(185, "\r\n                            <i class=\"oi oi-delete\" style=\"color: red\"></i>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "        \r\n");
#nullable restore
#line 126 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
            }        

#line default
#line hidden
#nullable disable
            __builder.AddContent(189, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n");
#nullable restore
#line 129 "D:\学习资料\VIA\(DNP)\C#\DNP1\Assignment1\Pages\AllFamily.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
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
