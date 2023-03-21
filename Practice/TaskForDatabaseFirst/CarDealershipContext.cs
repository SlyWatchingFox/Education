using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TaskForDatabaseFirst;

public partial class CarDealershipContext : DbContext
{
    public CarDealershipContext()
    {
    }

    public CarDealershipContext(DbContextOptions<CarDealershipContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Mechanic> Mechanics { get; set; }

    public virtual DbSet<Part> Parts { get; set; }

    public virtual DbSet<PartsUsed> PartsUseds { get; set; }

    public virtual DbSet<SalesInvoice> SalesInvoices { get; set; }

    public virtual DbSet<Salesperson> Salespeople { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<ServiceMechanic> ServiceMechanics { get; set; }

    public virtual DbSet<ServiceTicket> ServiceTickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Car Dealership");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.ToTable("Car");

            entity.Property(e => e.CarId).HasColumnName("Car_ID");
            entity.Property(e => e.CarFoSaleYN)
                .HasMaxLength(1)
                .HasColumnName("Car fo Sale Y/N");
            entity.Property(e => e.Colour).HasMaxLength(50);
            entity.Property(e => e.Make).HasMaxLength(50);
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.SerialNumber).HasColumnName("Serial Number");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last Name");
            entity.Property(e => e.PhoneNumber).HasColumnName("Phone Number");
            entity.Property(e => e.PostalCode).HasColumnName("Postal Code");
            entity.Property(e => e.StateProvince)
                .HasMaxLength(50)
                .HasColumnName("State/Province");
        });

        modelBuilder.Entity<Mechanic>(entity =>
        {
            entity.ToTable("Mechanic");

            entity.Property(e => e.MechanicId).HasColumnName("Mechanic_ID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last Name");
        });

        modelBuilder.Entity<Part>(entity =>
        {
            entity.HasKey(e => e.PartsId);

            entity.Property(e => e.PartsId).HasColumnName("Parts_ID");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.PartNumber).HasColumnName("Part Number");
            entity.Property(e => e.PurchasePrice).HasColumnName("Purchase Price");
            entity.Property(e => e.RetailPrice).HasColumnName("Retail Price");
        });

        modelBuilder.Entity<PartsUsed>(entity =>
        {
            entity.ToTable("Parts Used");

            entity.Property(e => e.PartsUsedId).HasColumnName("Parts_Used_ID");
            entity.Property(e => e.NumberUsed).HasColumnName("Number Used");
            entity.Property(e => e.PartId).HasColumnName("Part ID");
            entity.Property(e => e.ServiceTicketId).HasColumnName("Service Ticket ID");

            entity.HasOne(d => d.Part).WithMany(p => p.PartsUseds)
                .HasForeignKey(d => d.PartId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Parts Used_Parts");

            entity.HasOne(d => d.ServiceTicket).WithMany(p => p.PartsUseds)
                .HasForeignKey(d => d.ServiceTicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Parts Used_Service Ticket");
        });

        modelBuilder.Entity<SalesInvoice>(entity =>
        {
            entity.HasKey(e => e.InvoiceId);

            entity.ToTable("Sales Invoice");

            entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");
            entity.Property(e => e.CarId).HasColumnName("Car ID");
            entity.Property(e => e.CustomerId).HasColumnName("Customer ID");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.InvoiceNumber).HasColumnName("Invoice Number");
            entity.Property(e => e.SalespersonId).HasColumnName("Salesperson ID");

            entity.HasOne(d => d.Car).WithMany(p => p.SalesInvoices)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sales Invoice_Car");

            entity.HasOne(d => d.Customer).WithMany(p => p.SalesInvoices)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sales Invoice_Customer");

            entity.HasOne(d => d.Salesperson).WithMany(p => p.SalesInvoices)
                .HasForeignKey(d => d.SalespersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sales Invoice_Salesperson");
        });

        modelBuilder.Entity<Salesperson>(entity =>
        {
            entity.ToTable("Salesperson");

            entity.Property(e => e.SalespersonId).HasColumnName("Salesperson_ID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last Name");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.ToTable("Service");

            entity.Property(e => e.ServiceId).HasColumnName("Service_ID");
            entity.Property(e => e.HourlyRate).HasColumnName("Hourly Rate");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(50)
                .HasColumnName("Service Name");
        });

        modelBuilder.Entity<ServiceMechanic>(entity =>
        {
            entity.ToTable("Service Mechanic");

            entity.Property(e => e.ServiceMechanicId).HasColumnName("ServiceMechanic_ID");
            entity.Property(e => e.Comment).HasMaxLength(100);
            entity.Property(e => e.MechanicId).HasColumnName("Mechanic ID");
            entity.Property(e => e.ServiceId).HasColumnName("Service ID");
            entity.Property(e => e.ServiceTicketId).HasColumnName("Service Ticket ID");

            entity.HasOne(d => d.Mechanic).WithMany(p => p.ServiceMechanics)
                .HasForeignKey(d => d.MechanicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Service Mechanic_Mechanic");

            entity.HasOne(d => d.Service).WithMany(p => p.ServiceMechanics)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Service Mechanic_Service");

            entity.HasOne(d => d.ServiceTicket).WithMany(p => p.ServiceMechanics)
                .HasForeignKey(d => d.ServiceTicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Service Mechanic_Service Ticket");
        });

        modelBuilder.Entity<ServiceTicket>(entity =>
        {
            entity.ToTable("Service Ticket");

            entity.Property(e => e.ServiceTicketId).HasColumnName("Service_Ticket_ID");
            entity.Property(e => e.CarId).HasColumnName("Car ID");
            entity.Property(e => e.Comments).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("Customer ID");
            entity.Property(e => e.DataReceived)
                .HasColumnType("date")
                .HasColumnName("Data Received");
            entity.Property(e => e.DateReturnToCustomer)
                .HasColumnType("date")
                .HasColumnName("Date Return to Customer");
            entity.Property(e => e.ServiceTicketNumber).HasColumnName("Service Ticket Number");

            entity.HasOne(d => d.Car).WithMany(p => p.ServiceTickets)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Service Ticket_Car");

            entity.HasOne(d => d.Customer).WithMany(p => p.ServiceTickets)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Service Ticket_Customer");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
