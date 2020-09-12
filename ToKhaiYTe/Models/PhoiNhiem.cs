using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models
{
    public class PhoiNhiem
    {
        public int id { get; set; }
        public string DanhsachVacxin { get; set; }
        public bool TiepXucDongVat { get; set; }
        public bool TiepXucNguoiNhiemCovic { get; set; }
    }
}
