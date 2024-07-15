using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Taikhoan
{
    public int IdNd { get; set; }

    public string Email { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string? TrangThai { get; set; }

    public string? VaiTro { get; set; }

    public string DiaChi { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public int? IdNv { get; set; }

    public int? IdKh { get; set; }

    public virtual Khachhang? IdKhNavigation { get; set; }

    public virtual NhanVien? IdNvNavigation { get; set; }
}
