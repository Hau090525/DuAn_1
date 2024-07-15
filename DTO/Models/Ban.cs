using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class Ban
{
    public int IdBan { get; set; }

    public string? TenBan { get; set; }

    public string? ViTri { get; set; }

    public string? TrangThai { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
