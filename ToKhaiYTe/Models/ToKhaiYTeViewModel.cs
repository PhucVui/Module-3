using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models
{
    public class ToKhaiYTeViewModel
    {
        public int Id { get; set; }
        public int GatesId { get; set; }
        public string HoVaTen{ get; set; }
        public int YearId { get; set; }
        public string GioiTinh { get; set; }
        public string SoHoChieu { get; set; }
        public ThongTinDiChuyen ThongTinDiChuyen { get; set; }
        public DauHieu DauHieu { get; set; }
        public PhoiNhiem PhoiNhiem { get; set; }
        public ThongTinLienLac ThongTinLienLac { get; set; }
        
  
    }
}
