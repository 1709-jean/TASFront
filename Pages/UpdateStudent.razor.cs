using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS.Models;
using UAS.Services;
using Microsoft.AspNetCore.Components;

namespace UAS.Pages
{
    public partial class UpdateStudent
    {
        public Students Student { get; set; } = new Students();

          [Inject]
          public IStudentsServices StudentsServices { get; set; }
          [Inject]
          public NavigationManager NavigationManager { get; set; }
           public List <Students> Students { get; set; } = new List<Students>();
         
          [Parameter]
          public string Id { get; set; }
          
          protected async override Task OnInitializedAsync()
        {
            Student = await StudentsServices.GetById(int.Parse(Id));
          
        }

    
        protected async Task HandleValidSubmit(){
            Students result = await StudentsServices.Update(int.Parse(Id),Student);
            NavigationManager.NavigateTo("StudentsPage");
        }
    }
}