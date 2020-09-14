using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace ToKhaiYTe.Models
{
    public class ThongTinDiChuyen
    {
        public int Id { get; set; }
        public bool TauBay { get; set; }
        public bool TauThuyen { get; set; }
        public bool Oto { get; set; }
        public string Khac { get; set; }
        public string SoHieuPhuongTien { get; set; }
        public string SoGhe { get; set; }     
        public int DayId { get; set; }      
        public int MonthId { get; set; }
        public int YearId { get; set; }
        public int DiaDiemKhoiHanhId { get; set; }      
        public int DiaDiemNoiDenId { get; set; }      
        public string TrongVong21Ngay { get; set; }
        

    }
}
