using System.Collections.Generic;
using Final_Vidly.Models;

namespace Final_Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        public string Title
        {
            get {
                return Customer.Id != 0 ? "Edit customer" : "New customer";
            }
        }
    }
}