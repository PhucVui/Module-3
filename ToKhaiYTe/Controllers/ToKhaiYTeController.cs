using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ToKhaiYTe.Models;

namespace ToKhaiYTe.Controllers
{
    public class ToKhaiYTeController : Controller
    {
        private readonly ToKhaiYTeContext _context;

        public ToKhaiYTeController(ToKhaiYTeContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Register()

        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(ToKhaiYTeViewModel toKhaiYTeViewModel)
        {
            if (ModelState.IsValid)
            {
                NguoiKhaiBao nguoiKhaiBao = new NguoiKhaiBao();
                nguoiKhaiBao.HoTen = toKhaiYTeViewModel.HoVaTen;
                nguoiKhaiBao.YearId = toKhaiYTeViewModel.YearId;
                nguoiKhaiBao.GioiTinh = toKhaiYTeViewModel.GioiTinh;
                nguoiKhaiBao.SoHoChieu = toKhaiYTeViewModel.SoHoChieu;

                ThongTinDiChuyen thongTinDiChuyen = new ThongTinDiChuyen();
                thongTinDiChuyen.TauBay = toKhaiYTeViewModel.ThongTinDiChuyen.TauBay;
                thongTinDiChuyen.TauThuyen = toKhaiYTeViewModel.ThongTinDiChuyen.TauThuyen;
                thongTinDiChuyen.Oto = toKhaiYTeViewModel.ThongTinDiChuyen.Oto;
                thongTinDiChuyen.SoHieuPhuongTien = toKhaiYTeViewModel.ThongTinDiChuyen.SoHieuPhuongTien;
                thongTinDiChuyen.DayId = toKhaiYTeViewModel.ThongTinDiChuyen.DayId;
                thongTinDiChuyen.SoGhe = toKhaiYTeViewModel.ThongTinDiChuyen.SoGhe;
                thongTinDiChuyen.MonthId = toKhaiYTeViewModel.ThongTinDiChuyen.MonthId;
                thongTinDiChuyen.YearId = toKhaiYTeViewModel.ThongTinDiChuyen.YearId;
                thongTinDiChuyen.Khac = toKhaiYTeViewModel.ThongTinDiChuyen.Khac;
                thongTinDiChuyen.TrongVong21Ngay = toKhaiYTeViewModel.ThongTinDiChuyen.TrongVong21Ngay;
                _context.Add(thongTinDiChuyen);
                await _context.SaveChangesAsync();

                ThongTinLienLac thongTinLienLac = new ThongTinLienLac();
                thongTinLienLac.ProvinceId = toKhaiYTeViewModel.ThongTinLienLac.ProvinceId;
                thongTinLienLac.WardId = toKhaiYTeViewModel.ThongTinLienLac.WardId;
                thongTinLienLac.DistrictId = toKhaiYTeViewModel.ThongTinLienLac.DistrictId;
                thongTinLienLac.Email = toKhaiYTeViewModel.ThongTinLienLac.Email;
                thongTinLienLac.PhoneNum = toKhaiYTeViewModel.ThongTinLienLac.PhoneNum;
                thongTinLienLac.HouseNum = toKhaiYTeViewModel.ThongTinLienLac.HouseNum;
                _context.Add(thongTinLienLac);
                await _context.SaveChangesAsync();

                DauHieu dauHieu = new DauHieu();
                dauHieu.Sot = toKhaiYTeViewModel.DauHieu.Sot;
                dauHieu.Ho = toKhaiYTeViewModel.DauHieu.Ho;
                dauHieu.KhoTho = toKhaiYTeViewModel.DauHieu.KhoTho;
                dauHieu.BuonNon = toKhaiYTeViewModel.DauHieu.BuonNon;
                dauHieu.DauHong = toKhaiYTeViewModel.DauHieu.DauHong;
                dauHieu.NoiBanNgoaiDa = toKhaiYTeViewModel.DauHieu.NoiBanNgoaiDa;
                dauHieu.XuatHuyetNgoaiDa = toKhaiYTeViewModel.DauHieu.XuatHuyetNgoaiDa;
                dauHieu.TieuChay = toKhaiYTeViewModel.DauHieu.TieuChay;
                _context.Add(dauHieu);
                await _context.SaveChangesAsync();

                PhoiNhiem phoiNhiem = new PhoiNhiem();
                phoiNhiem.DanhsachVacxin = toKhaiYTeViewModel.PhoiNhiem.DanhsachVacxin;
                phoiNhiem.TiepXucDongVat = toKhaiYTeViewModel.PhoiNhiem.TiepXucDongVat;
                phoiNhiem.TiepXucNguoiNhiemCovic = toKhaiYTeViewModel.PhoiNhiem.TiepXucNguoiNhiemCovic;
                _context.Add(phoiNhiem);
                await _context.SaveChangesAsync();

                nguoiKhaiBao.ThongTinDiChuyenId = thongTinDiChuyen.Id;
                nguoiKhaiBao.ThongTinLienLacId = thongTinLienLac.Id;
                nguoiKhaiBao.DauHieuId = dauHieu.Id;
                nguoiKhaiBao.PhoiNhiemId = phoiNhiem.id;
                nguoiKhaiBao.GateId = toKhaiYTeViewModel.GatesId;
                _context.Add(nguoiKhaiBao);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index", "ToKhaiYTe");
        }

        public IActionResult Index()
        {
            return View(_context.NguoiKhaiBaos.ToList());
        }
        public IActionResult XemThongTinDiLai(int id)
        {
            var thongtindilai = _context.ThongTinDiChuyens.FirstOrDefault(el => el.Id == id);
            return View(thongtindilai);
        }
        public IActionResult XemThongTinLienLac(int id)
        {
            var thongtinlienlac = _context.ThongTinLienLacs.FirstOrDefault(el => el.Id == id);
            return View(thongtinlienlac);

        }
        public IActionResult XemDauHieu(int id)
        {
            var dauhieu = _context.DauHieus.FirstOrDefault(el => el.Id == id);
            return View(dauhieu);
        }
        public IActionResult XemPhoiNhiem(int id)
        {
            var phoinhiem = _context.PhoiNhiems.FirstOrDefault(el => el.id == id);
            return View(phoinhiem);
        }

        [Route("/ToKhaiYTe/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var tokhaiyte = _context.NguoiKhaiBaos.FirstOrDefault(el => el.Id == id);

            var dauhieu = _context.DauHieus.FirstOrDefault(el => el.Id == tokhaiyte.DauHieuId);
            _context.Remove(dauhieu);

            _context.Remove(tokhaiyte);
            var result = _context.SaveChanges();
            return Json(new { result });
        }

        public JsonResult GetDistrictById(int id) =>
             Json(new SelectList(_context.District.Where(x => x.ProvinceId == id).ToList(), "Id", "Name"));

        public JsonResult GetWardById(int id) =>
             Json(new SelectList(_context.Ward.Where(x => x.DistrictId == id).ToList(), "Id", "Name"));
    }
}
