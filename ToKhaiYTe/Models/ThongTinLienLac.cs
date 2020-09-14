using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models
{
    public class ThongTinLienLac
    {
        public int Id { get; set; }
        public int ProvinceId { get; set; }
        public int DistrictId { get; set; }
        public int WardId { get; set; }
        [Required]
        public string HouseNum{ get; set; }
        [Required]
        public int PhoneNum { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
    
}
