using StaffManagament.Models;
using System.Collections.Generic;

namespace StaffManagament.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Staff> Staffs { get; set; }
    }
}
