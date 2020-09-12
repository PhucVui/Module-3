using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models
{
    public class NguoiKhaiBao
    {       
        public int Id { get; set; }
        public string HoTen { get; set; }
        public int YearId { get; set; }
        public string GioiTinh { get; set; }    
        public string SoHoChieu { get; set; }      
        public int ThongTinDiChuyenId { get; set; }
        public int ThongTinLienLacId { get; set; }
        public int DauHieuId { get; set; }
        public int PhoiNhiemId { get; set; }
        public int GateId { get; set; }
    }
}
