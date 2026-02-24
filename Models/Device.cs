using System.ComponentModel.DataAnnotations;

namespace SmartHomeManager.Models
{
    public class Device
    {
        // primary key
        public int DeviceId { get; set; }

        // device name like living room light
        [Required]
        public string DeviceName { get; set; }

        // current status - online offline or maintenance
        public string Status { get; set; }

        // which room is it in
        public string Location { get; set; }

        // when was it installed
        public DateTime InstallDate { get; set; }

        // foreign key to category
        public int CategoryId { get; set; }

        // link back to parent category
        public DeviceCategory? Category { get; set; }
    }
}
