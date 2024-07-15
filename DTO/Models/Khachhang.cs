using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Khachhang
{
    public int IdKh { get; set; }

    public string TenKh { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public int? DiemTichLuy { get; set; }

    public int IdNd { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual ICollection<Taikhoan> Taikhoans { get; set; } = new List<Taikhoan>();
}
