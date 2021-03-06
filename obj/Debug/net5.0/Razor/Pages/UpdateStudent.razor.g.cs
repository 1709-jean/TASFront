#pragma checksum "C:\Frontend\UAS\Pages\UpdateStudent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff9a226feb758fad60cbab4b0bc791f1ce851895"
// <auto-generated/>
#pragma warning disable 1591
namespace UAS.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Frontend\UAS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Frontend\UAS\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Frontend\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Frontend\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Frontend\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Frontend\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Frontend\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Frontend\UAS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Frontend\UAS\_Imports.razor"
using UAS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Frontend\UAS\_Imports.razor"
using UAS.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editstudent/{id}")]
    public partial class UpdateStudent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 3 "C:\Frontend\UAS\Pages\UpdateStudent.razor"
                  Students

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\Frontend\UAS\Pages\UpdateStudent.razor"
                                           HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.AddMarkupContent(6, "<a href=\"/studentspage\"><button class=\"btn btn-primary\">Back</button></a>\r\n    ");
                __builder2.AddMarkupContent(7, "<h3>Update Siswa</h3>\r\n    <hr>\r\n     ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group row");
                __builder2.AddMarkupContent(10, "<label for=\"studentID\" class=\"col-sm-2 col-form-label\">\r\n            Nomor Siswa\r\n        </label>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "id", "StudentId");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "placeholder", "StudentId");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Frontend\UAS\Pages\UpdateStudent.razor"
                         Student.studentID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Student.studentID = __value, Student.studentID))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Student.studentID));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __Blazor.UAS.Pages.UpdateStudent.TypeInference.CreateValidationMessage_0(__builder2, 21, 22, 
#nullable restore
#line 15 "C:\Frontend\UAS\Pages\UpdateStudent.razor"
                                      ()=>Student.firstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group row");
                __builder2.AddMarkupContent(26, "<label for=\"firstName\" class=\"col-sm-2 col-form-label\">\r\n            Nama Depan\r\n        </label>\r\n        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "id", "firstName");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "placeholder", "First Name");
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Frontend\UAS\Pages\UpdateStudent.razor"
                         Student.firstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Student.firstName = __value, Student.firstName))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Student.firstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __Blazor.UAS.Pages.UpdateStudent.TypeInference.CreateValidationMessage_1(__builder2, 37, 38, 
#nullable restore
#line 25 "C:\Frontend\UAS\Pages\UpdateStudent.razor"
                                      ()=>Student.firstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n      ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group row");
                __builder2.AddMarkupContent(42, "<label for=\"lastName\" class=\"col-sm-2 col-form-label\">\r\n            Nama Belakang\r\n        </label>\r\n        ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "id", "lastName");
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "placeholder", "Last Name");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Frontend\UAS\Pages\UpdateStudent.razor"
                         Student.lastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Student.lastName = __value, Student.lastName))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Student.lastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n               ");
                __Blazor.UAS.Pages.UpdateStudent.TypeInference.CreateValidationMessage_2(__builder2, 53, 54, 
#nullable restore
#line 35 "C:\Frontend\UAS\Pages\UpdateStudent.razor"
                                         ()=>Student.lastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group row");
                __builder2.AddMarkupContent(58, "<label for=\"EnrollmentDate\" class=\"col-sm-2 col-form-label\">Tanggal Masuk</label>\r\n        ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-sm-10");
                __Blazor.UAS.Pages.UpdateStudent.TypeInference.CreateInputDate_3(__builder2, 61, 62, "form-control", 63, 
#nullable restore
#line 41 "C:\Frontend\UAS\Pages\UpdateStudent.razor"
                                    Student.enrollmentDate

#line default
#line hidden
#nullable disable
                , 64, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Student.enrollmentDate = __value, Student.enrollmentDate)), 65, () => Student.enrollmentDate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n    ");
                __builder2.AddMarkupContent(67, "<button class=\"btn btn-success\" type=\"submit\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.UAS.Pages.UpdateStudent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
