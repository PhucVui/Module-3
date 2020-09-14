using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models
{
    public class PhoiNhiem
    {
        public int id { get; set; }      
        public string DanhsachVacxin { get; set; }
        [Required]
        public bool TiepXucDongVat { get; set; }
        [Required]
        public bool TiepXucNguoiNhiemCovic { get; set; }
    }
}
