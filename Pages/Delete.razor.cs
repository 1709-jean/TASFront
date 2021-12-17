using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS.Services;
using Microsoft.AspNetCore.Components;

namespace UAS.Pages
{
    public partial class Delete
    {
         [Parameter]
          public string Id { get; set; }

             [Inject]
          public IStudentsServices StudentService { get; set; }

            [Inject]
          public NavigationManager NavigationManager { get; set; }
           protected async override Task OnInitializedAsync()
        {
            await StudentService.Delete(int.Parse(Id));
            NavigationManager.NavigateTo("/studentspage");
        }
    }
}