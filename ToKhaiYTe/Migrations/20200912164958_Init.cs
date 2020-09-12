using Microsoft.EntityFrameworkCore.Migrations;

namespace ToKhaiYTe.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DauHieus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sot = table.Column<bool>(nullable: false),
                    Ho = table.Column<bool>(nullable: false),
                    KhoTho = table.Column<bool>(nullable: false),
                    DauHong = table.Column<bool>(nullable: false),
                    BuonNon = table.Column<bool>(nullable: false),
                    TieuChay = table.Column<bool>(nullable: false),
                    XuatHuyetNgoaiDa = table.Column<bool>(nullable: false),
                    NoiBanNgoaiDa = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DauHieus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "days",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    day = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "district",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    _name = table.Column<string>(maxLength: 100, nullable: true),
                    _prefix = table.Column<string>(maxLength: 20, nullable: true),
                    _province_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "gates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GateName = table.Column<string>(maxLength: 50, nullable: false),
                    IsPublished = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "months",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    month = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NguoiKhaiBaos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    GioiTinh = table.Column<string>(nullable: true),
                    SoHoChieu = table.Column<string>(nullable: true),
                    ThongTinDiChuyenId = table.Column<int>(nullable: false),
                    ThongTinLienLacId = table.Column<int>(nullable: false),
                    DauHieuId = table.Column<int>(nullable: false),
                    PhoiNhiemId = table.Column<int>(nullable: false),
                    GateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiKhaiBaos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoiNhiems",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DanhsachVacxin = table.Column<string>(nullable: true),
                    TiepXucDongVat = table.Column<bool>(nullable: false),
                    TiepXucNguoiNhiemCovic = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoiNhiems", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "province",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    _name = table.Column<string>(maxLength: 50, nullable: true),
                    _code = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ThongTinDiChuyens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TauBay = table.Column<bool>(nullable: false),
                    TauThuyen = table.Column<bool>(nullable: false),
                    Oto = table.Column<bool>(nullable: false),
                    Khac = table.Column<string>(nullable: true),
                    SoHieuPhuongTien = table.Column<string>(nullable: true),
                    SoGhe = table.Column<string>(nullable: true),
                    DayId = table.Column<int>(nullable: false),
                    MonthId = table.Column<int>(nullable: false),
                    YearId = table.Column<int>(nullable: false),
                    DiaDiemKhoiHanhId = table.Column<int>(nullable: false),
                    DiaDiemNoiDenId = table.Column<int>(nullable: false),
                    TrongVong21Ngay = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinDiChuyens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinLienLacs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceId = table.Column<int>(nullable: false),
                    DistrictId = table.Column<int>(nullable: false),
                    WardId = table.Column<int>(nullable: false),
                    HouseNum = table.Column<string>(nullable: true),
                    PhoneNum = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinLienLacs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ward",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    _name = table.Column<string>(maxLength: 50, nullable: false),
                    _prefix = table.Column<string>(maxLength: 20, nullable: true),
                    _province_id = table.Column<int>(nullable: true),
                    _district_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "years",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DauHieus");

            migrationBuilder.DropTable(
                name: "days");

            migrationBuilder.DropTable(
                name: "district");

            migrationBuilder.DropTable(
                name: "gates");

            migrationBuilder.DropTable(
                name: "months");

            migrationBuilder.DropTable(
                name: "NguoiKhaiBaos");

            migrationBuilder.DropTable(
                name: "PhoiNhiems");

            migrationBuilder.DropTable(
                name: "province");

            migrationBuilder.DropTable(
                name: "ThongTinDiChuyens");

            migrationBuilder.DropTable(
                name: "ThongTinLienLacs");

            migrationBuilder.DropTable(
                name: "ward");

            migrationBuilder.DropTable(
                name: "years");
        }
    }
}
