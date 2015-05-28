using Microsoft.Practices.Prism.StoreApps;
using System.ComponentModel.DataAnnotations;

namespace PrismApp.Models
{
    public class Service : ValidatableBindableBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}