using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;



namespace FlightAPIService.Models
{
    public partial class AirlineReservationContext : DbContext
    {
        public AirlineReservationContext()
        {
        }

        public AirlineReservationContext(DbContextOptions<AirlineReservationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAirlineDetail> TblAirlineDetails { get; set; }
        public virtual DbSet<TblAirportDetail> TblAirportDetails { get; set; }
        public virtual DbSet<TblFlightBookingDetail> TblFlightBookingDetails { get; set; }
        public virtual DbSet<TblFlightDetail> TblFlightDetails { get; set; }
        public virtual DbSet<TblFlightTicketPrice> TblFlightTicketPrices { get; set; }
        public virtual DbSet<TblUserDetail> TblUserDetails { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {

        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAirlineDetail>(entity =>
            {
                entity.HasKey(e => e.AlId)
                    .HasName("PK__tbl_Airl__84248F83E6A13F11");

                entity.ToTable("tbl_AirlineDetails");

                entity.Property(e => e.AlId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("al_id");

                entity.Property(e => e.AlAddr1)
                    .IsUnicode(false)
                    .HasColumnName("al_addr1");

                entity.Property(e => e.AlCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("al_city");

                entity.Property(e => e.AlCustCareNo)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("al_cust_care_no");

                entity.Property(e => e.AlEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("al_email");

                entity.Property(e => e.AlIsBlocked)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("al_is_blocked");

                entity.Property(e => e.AlLogo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("al_logo");

                entity.Property(e => e.AlName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("al_name");

                entity.Property(e => e.AlState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("al_state");
            });

            modelBuilder.Entity<TblAirportDetail>(entity =>
            {
                entity.HasKey(e => e.AirportCode);

                entity.ToTable("tbl_AirportDetails");

                entity.Property(e => e.AirportCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("airport_Code");

                entity.Property(e => e.AirportCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("airport_City");

                entity.Property(e => e.AirportName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("airport_Name");

                entity.Property(e => e.AirportState)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("airport_State");

                entity.Property(e => e.IsairportOperational).HasColumnName("isairport_Operational");
            });

            modelBuilder.Entity<TblFlightBookingDetail>(entity =>
            {
                entity.HasKey(e => e.FlightPnrNo);

                entity.ToTable("tbl_FlightBookingDetails");

                entity.Property(e => e.FlightPnrNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("flight_Pnr_No");

                entity.Property(e => e.AirlineId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("airline_Id");

                entity.Property(e => e.AirportCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("airport_Code");

                entity.Property(e => e.BookingStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("booking_Status");

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("flight_No");

                entity.Property(e => e.FlightSeatNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("flight_Seat_No");

                entity.Property(e => e.FlightTktPrice)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("flight_Tkt_Price");

                entity.Property(e => e.PassengerEmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("passenger_EmailId");

                entity.Property(e => e.PassengerIdProof)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("passenger_Id_Proof");

                entity.Property(e => e.PassengerMobileNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("passenger_Mobile_No");

                entity.Property(e => e.PassengerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("passenger_Name");
            });

            modelBuilder.Entity<TblFlightDetail>(entity =>
            {
                entity.HasKey(e => e.FlightId)
                    .HasName("PK__tbl_Flig__E373AB3D9E8A19A5");

                entity.ToTable("tbl_FlightDetails");

                entity.Property(e => e.FlightId).HasColumnName("flight_Id");

                entity.Property(e => e.AirlineId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("airline_Id");

                entity.Property(e => e.FlightArrivDt)
                    .HasColumnType("date")
                    .HasColumnName("flight_Arriv_Dt");

               

                entity.Property(e => e.FlightDeptDt)
                    .HasColumnType("date")
                    .HasColumnName("flight_Dept_Dt");

               

                entity.Property(e => e.FlightDestAirportcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("flight_Dest_Airportcode");

                entity.Property(e => e.FlightInstUsed)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("flight_Inst_Used");

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("flight_No");

                entity.Property(e => e.FlightNoOfRows)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("flight_No_Of_Rows");

                entity.Property(e => e.FlightSrcAirportcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("flight_Src_Airportcode");

                entity.Property(e => e.FlightTotalBusSeats)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("flight_Total_Bus_Seats");

                entity.Property(e => e.FlightTotalEcoSeats)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flight_Total_Eco_Seats");

                entity.Property(e => e.FlightTotalNoofseats)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flight_Total_Noofseats");
            });

            modelBuilder.Entity<TblFlightTicketPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_FlightTicketPrice");

                entity.Property(e => e.FlightDepartDt)
                    .HasColumnType("date")
                    .HasColumnName("flight_Depart_Dt");

                entity.Property(e => e.FlightDepartTime)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("flight_Depart_Time");

                entity.Property(e => e.FlightIsbooked).HasColumnName("flight_Isbooked");

                entity.Property(e => e.FlightMealType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flight_Meal_Type");

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("flight_No");

                entity.Property(e => e.FlightSeatNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("flight_Seat_No");

                entity.Property(e => e.FlightTktActPrice)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("flight_Tkt_Act_Price");

                entity.Property(e => e.FlightTktClass)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("flight_Tkt_Class");

                entity.Property(e => e.FlightTktDiscountPrice)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("flight_Tkt_Discount_Price");

                entity.Property(e => e.FlightTktFinalPrice)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("flight_Tkt_Final_Price");
            });

            modelBuilder.Entity<TblUserDetail>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tbl_UserDetails");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address1).IsUnicode(false);

                entity.Property(e => e.Address2).IsUnicode(false);

                entity.Property(e => e.AdharNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PanNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PinCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
