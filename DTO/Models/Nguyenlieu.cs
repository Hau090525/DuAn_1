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

<<<<<<< HEAD
=======
    public int? SoLuong { get; set; }

>>>>>>> f2c9c63a17c8462f4f6fc049f0ae15c8392caca8
    public virtual ICollection<Monan> Monans { get; set; } = new List<Monan>();
}
