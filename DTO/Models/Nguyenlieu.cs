using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Nguyenlieu
{
    public int IdNl { get; set; }

    public string? TenNl { get; set; }

    public decimal? DonGia { get; set; }

    public int IdKho { get; set; }

    public string? DonViTinh { get; set; }
    public int SoLuong { get; set; }

    public virtual Kho IdKhoNavigation { get; set; } = null!;
}
