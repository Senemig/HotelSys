#pragma checksum "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83360019c0678449007b4b49af3e46c3f4dfd41b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sistema_Quartos), @"mvc.1.0.view", @"/Views/Sistema/Quartos.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\_ViewImports.cshtml"
using HotelSys;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\_ViewImports.cshtml"
using HotelSys.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83360019c0678449007b4b49af3e46c3f4dfd41b", @"/Views/Sistema/Quartos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc28ddeac5f9159d5f9e588dd7bca11425816501", @"/Views/_ViewImports.cshtml")]
    public class Views_Sistema_Quartos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Quarto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
  
    ViewData["Title"] = "Quartos";
    DateTime dtCheckIn;
    DateTime dtCheckOut;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 10 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Lista de Quartos</h2>\r\n");
            WriteLiteral(@"        <table class=""table table-hover"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">Número</th>
                    <th scope=""col"">Situação</th>
                    <th scope=""col"">Cliente</th>
                    <th scope=""col"">Check In</th>
                    <th scope=""col"">Check Out</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 25 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                 foreach (Quarto quarto in Model)
                {
                    if (quarto.Status == "Vazio")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"table-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 847, "\"", 908, 3);
            WriteAttributeValue("", 857, "location.href=\'/Sistema/VerQuarto/", 857, 34, true);
#nullable restore
#line 29 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
WriteAttributeValue("", 891, quarto.idQuarto, 891, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 907, "\'", 907, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td scope=\"row\">");
#nullable restore
#line 30 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                                       Write(quarto.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                           Write(quarto.Status.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 33 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                                 if (quarto.cliente != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                               Write(quarto.cliente.Nome.ToUpper());

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                                                                  
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 39 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                                 if (quarto.CheckIn != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                               Write(quarto.CheckIn);

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                                                   
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 45 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                                 if (quarto.CheckOut != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                               Write(quarto.CheckOut);

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                                                    
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"table-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1971, "\"", 2032, 3);
            WriteAttributeValue("", 1981, "location.href=\'/Sistema/VerQuarto/", 1981, 34, true);
#nullable restore
#line 54 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
WriteAttributeValue("", 2015, quarto.idQuarto, 2015, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2031, "\'", 2031, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td scope=\"row\">");
#nullable restore
#line 55 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                                       Write(quarto.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 56 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                           Write(quarto.Status.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 58 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                                 if (quarto.cliente != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                               Write(quarto.cliente.Nome.ToUpper());

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                                                                  
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 64 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                                 if (quarto.CheckIn != null)
                                {
                                    dtCheckIn = (DateTime)quarto.CheckIn;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                               Write(dtCheckIn.ToShortDateString());

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                                                                  ;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 71 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                                 if (quarto.CheckOut != null)
                                {
                                    dtCheckOut = (DateTime)quarto.CheckOut;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                               Write(dtCheckOut.ToShortDateString());

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                                                                   ;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 78 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 82 "C:\Users\ferna\Desktop\workspace\C#\HotelSys\Views\Sistema\Quartos.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Quarto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
