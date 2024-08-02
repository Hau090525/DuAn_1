using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class NhanVien
{
    public int IdNv { get; set; }

    public string TenNv { get; set; } = null!;

    public DateOnly? NgayVaoLam { get; set; }

    public string Sdt { get; set; } = null!;

    public string? ChucVu { get; set; }

    public int IdNd { get; set; }

    public int IdNql { get; set; }

    public string? TinhTrang { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual NhanVien IdNqlNavigation { get; set; } = null!;

    public virtual ICollection<NhanVien> InverseIdNqlNavigation { get; set; } = new List<NhanVien>();

    public virtual ICollection<Taikhoan> Taikhoans { get; set; } = new List<Taikhoan>();
}
