using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class StudentsPage
    {
        public List<Students> Students { get; set; } = new List<Students>();

    [Inject]
        public IStudentsServices StudentsService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Students = (await StudentsService.GetAll()).ToList();
        }

    }
}