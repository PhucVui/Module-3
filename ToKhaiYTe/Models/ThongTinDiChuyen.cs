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
        // luc truoc co bang date
        // bi loi~ nen xoa bang date, va cung doi truong dateid thanh 3 truong kia
        // nhung no van bao loi dateid uk date xoa roi phai ko anh???? alo nghe ne
        //h anh muon lam dieu gi?
        // lam cach nao de add vo db nhi :)) dateid cho mo he? xoa bang date roi
        // class co 3 truong nay, ma ben sql chua co

    }
}
