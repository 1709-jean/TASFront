using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS.Models;
using UAS.Services;
using Microsoft.AspNetCore.Components;

namespace UAS.Pages
{
    public partial class DetailStudent
    {
         [Parameter]
        public string id { get; set; }

        [Inject]
        public IStudentsServices StudentServices{ get; set; }


        public Students Student { get; set; } = new Students();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Student = await StudentServices.GetById(int.Parse(id));
        }
    }
}