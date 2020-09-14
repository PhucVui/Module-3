using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models
{
    public class ToKhaiYTeViewModel
    {
        public int Id { get; set; }
        [Required]
        public int GatesId { get; set; }
        [Required]
        public string HoVaTen{ get; set; }
        [Required]
        public int YearId { get; set; }
        [Required]
        public string GioiTinh { get; set; }
        [Required]
        public string SoHoChieu { get; set; }
       
        public ThongTinDiChuyen ThongTinDiChuyen { get; set; }
        [Required]
        public DauHieu DauHieu { get; set; }
       
        public PhoiNhiem PhoiNhiem { get; set; }
        [Required]
        public ThongTinLienLac ThongTinLienLac { get; set; }
        
  
    }
}
