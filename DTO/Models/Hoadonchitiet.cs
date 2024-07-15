using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Hoadonchitiet
{
    public int IdHoaDon { get; set; }

    public int IdMonAn { get; set; }

    public int? SoLuong { get; set; }

    public decimal? ThanhTien { get; set; }

    public virtual Hoadon IdHoaDonNavigation { get; set; } = null!;

    public virtual Monan IdMonAnNavigation { get; set; } = null!;
}
