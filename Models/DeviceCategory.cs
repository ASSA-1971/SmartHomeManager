using System.ComponentModel.DataAnnotations;

namespace SmartHomeManager.Models
{
    public class DeviceCategory
    {
        // primary key
        public int CategoryId { get; set; }

        // category name like smart lights or thermostats
        [Required]
        public string CategoryName { get; set; }

        // short description of what this category is
        public string Description { get; set; }

        // which brand makes these devices
        public string ManufacturerBrand { get; set; }

        // link to child devices
        public List<Device>? Devices { get; set; }
    }
}
