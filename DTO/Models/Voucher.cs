using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Voucher
{
    public string CodeVoucher { get; set; } = null!;

    public string? MoTa { get; set; }

    public double? PhanTram { get; set; }

    public string? LoaiMa { get; set; }

    public int? SoLuong { get; set; }

    public int? Diem { get; set; }

    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
