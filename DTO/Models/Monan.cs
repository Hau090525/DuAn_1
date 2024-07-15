using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Monan
{
    public int IdMonAn { get; set; }

    public string TenMon { get; set; } = null!;

    public decimal? DonGia { get; set; }

    public string? Loai { get; set; }

    public string? TrangThai { get; set; }

    public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; } = new List<Hoadonchitiet>();
}
