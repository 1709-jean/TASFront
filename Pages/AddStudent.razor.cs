using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS.Models;
using UAS.Services;
using Microsoft.AspNetCore.Components;


namespace UAS.Pages
{
    public partial class AddStudent
    {
         public Students Student { get; set; } = new Students();

        [Inject]
        public IStudentsServices StudentsServices { get; set; }

       
        [Inject]
        public NavigationManager NavigationManager { get; set; }



        protected async Task HandleValidSubmit()
        {
            
            var result = await StudentsServices.Add(Student);
            NavigationManager.NavigateTo("studentspage"); 
        }
    }
}