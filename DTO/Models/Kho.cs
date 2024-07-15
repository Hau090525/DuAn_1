using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Kho
{
    public int IdKho { get; set; }

    public int IdNv { get; set; }

    public int? SoLuongTon { get; set; }

    public virtual NhanVien IdNvNavigation { get; set; } = null!;

    public virtual ICollection<Nguyenlieu> Nguyenlieus { get; set; } = new List<Nguyenlieu>();
}
