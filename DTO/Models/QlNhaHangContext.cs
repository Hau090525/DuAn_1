using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DTO.Models;

public partial class QlNhaHangContext : DbContext
{
    public QlNhaHangContext()
    {
    }

    public QlNhaHangContext(DbContextOptions<QlNhaHangContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ban> Bans { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Hoadonchitiet> Hoadonchitiets { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Monan> Monans { get; set; }

    public virtual DbSet<Nguyenlieu> Nguyenlieus { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<Taikhoan> Taikhoans { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=QUOC-AN;Database=QL_NHA_HANG;User Id=SA;Password=123456;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ban>(entity =>
        {
            entity.HasKey(e => e.IdBan).HasName("PK__BAN__142B84F949B86372");

            entity.ToTable("BAN");

            entity.Property(e => e.IdBan)
                .ValueGeneratedNever()
                .HasColumnName("ID_Ban");
            entity.Property(e => e.TenBan).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasMaxLength(50);
            entity.Property(e => e.ViTri).HasMaxLength(30);
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.IdHoaDon).HasName("PK__HOADON__14AFCFC59798880B");

            entity.ToTable("HOADON");

            entity.Property(e => e.IdHoaDon)
                .ValueGeneratedNever()
                .HasColumnName("ID_HoaDon");
            entity.Property(e => e.CodeVoucher)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Code_Voucher");
            entity.Property(e => e.IdBan).HasColumnName("ID_Ban");
            entity.Property(e => e.IdKh).HasColumnName("ID_KH");
            entity.Property(e => e.TenMonAn).HasMaxLength(50);
            entity.Property(e => e.TienGiam).HasColumnType("money");
            entity.Property(e => e.TongTien).HasColumnType("money");
            entity.Property(e => e.TrangThai).HasMaxLength(30);

            entity.HasOne(d => d.CodeVoucherNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.CodeVoucher)
                .HasConstraintName("FK_HOADON_VOUCHER");

            entity.HasOne(d => d.IdBanNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.IdBan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HOADON_BAN");

            entity.HasOne(d => d.IdKhNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.IdKh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HOADON_KHACHHANG");
        });

        modelBuilder.Entity<Hoadonchitiet>(entity =>
        {
            entity.HasKey(e => new { e.IdHoaDon, e.IdMonAn }).HasName("PK__HOADONCH__C9AEED64107471FE");

            entity.ToTable("HOADONCHITIET");

            entity.Property(e => e.IdHoaDon).HasColumnName("ID_HoaDon");
            entity.Property(e => e.IdMonAn).HasColumnName("ID_MonAn");
            entity.Property(e => e.ThanhTien).HasColumnType("money");

            entity.HasOne(d => d.IdHoaDonNavigation).WithMany(p => p.Hoadonchitiets)
                .HasForeignKey(d => d.IdHoaDon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HOADONCHITIET_HOADON");

            entity.HasOne(d => d.IdMonAnNavigation).WithMany(p => p.Hoadonchitiets)
                .HasForeignKey(d => d.IdMonAn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HOADONCHITIET_MONAN");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.IdKh).HasName("PK__KHACHHAN__8B62EC895F896B65");

            entity.ToTable("KHACHHANG");

            entity.Property(e => e.IdKh)
                .ValueGeneratedNever()
                .HasColumnName("ID_KH");
            entity.Property(e => e.IdNd).HasColumnName("ID_ND");
            entity.Property(e => e.Sdt)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenKh)
                .HasMaxLength(50)
                .HasColumnName("TenKH");
        });

        modelBuilder.Entity<Monan>(entity =>
        {
            entity.HasKey(e => e.IdMonAn).HasName("PK__MONAN__D0122A1CD3205904");

            entity.ToTable("MONAN");

            entity.Property(e => e.IdMonAn)
                .ValueGeneratedNever()
                .HasColumnName("ID_MonAn");
            entity.Property(e => e.DonGia).HasColumnType("money");
            entity.Property(e => e.IdNl).HasColumnName("ID_NL");
            entity.Property(e => e.Loai).HasMaxLength(30);
            entity.Property(e => e.TenMon).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasMaxLength(30);

            entity.HasOne(d => d.IdNlNavigation).WithMany(p => p.Monans)
                .HasForeignKey(d => d.IdNl)
                .HasConstraintName("FK_MONAN_NGUYENLIEU");
        });

        modelBuilder.Entity<Nguyenlieu>(entity =>
        {
            entity.HasKey(e => e.IdNl).HasName("PK__NGUYENLI__8B63E06D11590091");

            entity.ToTable("NGUYENLIEU");

            entity.Property(e => e.IdNl)
                .ValueGeneratedNever()
                .HasColumnName("ID_NL");
            entity.Property(e => e.DonGia).HasColumnType("money");
            entity.Property(e => e.DonViTinh).HasMaxLength(30);
            entity.Property(e => e.IdKho).HasColumnName("ID_Kho");
            entity.Property(e => e.TenNl)
                .HasMaxLength(50)
                .HasColumnName("TenNL");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.IdNv).HasName("PK__NHAN_VIE__8B63E063E976C0C3");

            entity.ToTable("NHAN_VIEN");

            entity.Property(e => e.IdNv)
                .ValueGeneratedNever()
                .HasColumnName("ID_NV");
            entity.Property(e => e.ChucVu).HasMaxLength(50);
            entity.Property(e => e.IdNd).HasColumnName("ID_ND");
            entity.Property(e => e.IdNql).HasColumnName("ID_NQL");
            entity.Property(e => e.Sdt)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TenNv)
                .HasMaxLength(50)
                .HasColumnName("TenNV");
            entity.Property(e => e.TinhTrang).HasMaxLength(30);

            entity.HasOne(d => d.IdNqlNavigation).WithMany(p => p.InverseIdNqlNavigation)
                .HasForeignKey(d => d.IdNql)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NHAN_VIEN_NHAN_VIEN");
        });

        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity.HasKey(e => e.IdNd).HasName("PK__TAIKHOAN__8B63E0750038840C");

            entity.ToTable("TAIKHOAN");

            entity.Property(e => e.IdNd)
                .ValueGeneratedNever()
                .HasColumnName("ID_ND");
            entity.Property(e => e.DiaChi).HasMaxLength(50);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdKh).HasColumnName("ID_KH");
            entity.Property(e => e.IdNv).HasColumnName("ID_NV");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sdt)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.TrangThai)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.VaiTro).HasMaxLength(50);

            entity.HasOne(d => d.IdKhNavigation).WithMany(p => p.Taikhoans)
                .HasForeignKey(d => d.IdKh)
                .HasConstraintName("FK_TAIKHOAN_KHACHHANG");

            entity.HasOne(d => d.IdNvNavigation).WithMany(p => p.Taikhoans)
                .HasForeignKey(d => d.IdNv)
                .HasConstraintName("FK_TAIKHOAN_NHAN_VIEN");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.CodeVoucher).HasName("PK__VOUCHER__0A25D13847E46E27");

            entity.ToTable("VOUCHER");

            entity.Property(e => e.CodeVoucher)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Code_Voucher");
            entity.Property(e => e.LoaiMa).HasMaxLength(50);
            entity.Property(e => e.MoTa).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
