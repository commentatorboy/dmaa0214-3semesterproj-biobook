﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerProject.DatabaseLayer
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Runtime.Serialization;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dmaa0214_3Sem_2")]
	public partial class ConnectToDatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertHall(Hall instance);
    partial void UpdateHall(Hall instance);
    partial void DeleteHall(Hall instance);
    partial void InsertMovie(Movie instance);
    partial void UpdateMovie(Movie instance);
    partial void DeleteMovie(Movie instance);
    partial void InsertScheduler(Scheduler instance);
    partial void UpdateScheduler(Scheduler instance);
    partial void DeleteScheduler(Scheduler instance);
    partial void InsertSeat(Seat instance);
    partial void UpdateSeat(Seat instance);
    partial void DeleteSeat(Seat instance);
    partial void InsertReservation(Reservation instance);
    partial void UpdateReservation(Reservation instance);
    partial void DeleteReservation(Reservation instance);
    #endregion
		
		public ConnectToDatabaseDataContext() : 
				base(global::ServerProject.Properties.Settings.Default.dmaa0214_3Sem_2ConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public ConnectToDatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConnectToDatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConnectToDatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConnectToDatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Hall> Halls
		{
			get
			{
				return this.GetTable<Hall>();
			}
		}
		
		public System.Data.Linq.Table<Movie> Movies
		{
			get
			{
				return this.GetTable<Movie>();
			}
		}
		
		public System.Data.Linq.Table<Scheduler> Schedulers
		{
			get
			{
				return this.GetTable<Scheduler>();
			}
		}
		
		public System.Data.Linq.Table<Seat> Seats
		{
			get
			{
				return this.GetTable<Seat>();
			}
		}
		
		public System.Data.Linq.Table<Reservation> Reservations
		{
			get
			{
				return this.GetTable<Reservation>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CusID;
		
		private string _name;
		
		private string _phoneNumber;
		
		private EntitySet<Reservation> _Reservations;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCusIDChanging(int value);
    partial void OnCusIDChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnphoneNumberChanging(string value);
    partial void OnphoneNumberChanged();
    #endregion
		
		public Customer()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CusID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int CusID
		{
			get
			{
				return this._CusID;
			}
			set
			{
				if ((this._CusID != value))
				{
					this.OnCusIDChanging(value);
					this.SendPropertyChanging();
					this._CusID = value;
					this.SendPropertyChanged("CusID");
					this.OnCusIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(30)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phoneNumber", DbType="VarChar(20)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string phoneNumber
		{
			get
			{
				return this._phoneNumber;
			}
			set
			{
				if ((this._phoneNumber != value))
				{
					this.OnphoneNumberChanging(value);
					this.SendPropertyChanging();
					this._phoneNumber = value;
					this.SendPropertyChanged("phoneNumber");
					this.OnphoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Reservation", Storage="_Reservations", ThisKey="CusID", OtherKey="CustomerID")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4, EmitDefaultValue=false)]
		public EntitySet<Reservation> Reservations
		{
			get
			{
				if ((this.serializing 
							&& (this._Reservations.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._Reservations;
			}
			set
			{
				this._Reservations.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Reservations(Reservation entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Reservations(Reservation entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
		
		private void Initialize()
		{
			this._Reservations = new EntitySet<Reservation>(new Action<Reservation>(this.attach_Reservations), new Action<Reservation>(this.detach_Reservations));
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Hall")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Hall : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _HallID;
		
		private string _name;
		
		private System.Nullable<int> _MaxNumberOfSeats;
		
		private EntitySet<Scheduler> _Schedulers;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHallIDChanging(int value);
    partial void OnHallIDChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnMaxNumberOfSeatsChanging(System.Nullable<int> value);
    partial void OnMaxNumberOfSeatsChanged();
    #endregion
		
		public Hall()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HallID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int HallID
		{
			get
			{
				return this._HallID;
			}
			set
			{
				if ((this._HallID != value))
				{
					this.OnHallIDChanging(value);
					this.SendPropertyChanging();
					this._HallID = value;
					this.SendPropertyChanged("HallID");
					this.OnHallIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(30)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaxNumberOfSeats", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public System.Nullable<int> MaxNumberOfSeats
		{
			get
			{
				return this._MaxNumberOfSeats;
			}
			set
			{
				if ((this._MaxNumberOfSeats != value))
				{
					this.OnMaxNumberOfSeatsChanging(value);
					this.SendPropertyChanging();
					this._MaxNumberOfSeats = value;
					this.SendPropertyChanged("MaxNumberOfSeats");
					this.OnMaxNumberOfSeatsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Hall_Scheduler", Storage="_Schedulers", ThisKey="HallID", OtherKey="HallID")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4, EmitDefaultValue=false)]
		public EntitySet<Scheduler> Schedulers
		{
			get
			{
				if ((this.serializing 
							&& (this._Schedulers.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._Schedulers;
			}
			set
			{
				this._Schedulers.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Schedulers(Scheduler entity)
		{
			this.SendPropertyChanging();
			entity.Hall = this;
		}
		
		private void detach_Schedulers(Scheduler entity)
		{
			this.SendPropertyChanging();
			entity.Hall = null;
		}
		
		private void Initialize()
		{
			this._Schedulers = new EntitySet<Scheduler>(new Action<Scheduler>(this.attach_Schedulers), new Action<Scheduler>(this.detach_Schedulers));
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Movie")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Movie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MovieID;
		
		private string _name;
		
		private System.Nullable<int> _Playtime;
		
		private System.Nullable<int> _Price;
		
		private string _Image;
		
		private EntitySet<Scheduler> _Schedulers;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMovieIDChanging(int value);
    partial void OnMovieIDChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnPlaytimeChanging(System.Nullable<int> value);
    partial void OnPlaytimeChanged();
    partial void OnPriceChanging(System.Nullable<int> value);
    partial void OnPriceChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    #endregion
		
		public Movie()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int MovieID
		{
			get
			{
				return this._MovieID;
			}
			set
			{
				if ((this._MovieID != value))
				{
					this.OnMovieIDChanging(value);
					this.SendPropertyChanging();
					this._MovieID = value;
					this.SendPropertyChanged("MovieID");
					this.OnMovieIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(30)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Playtime", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public System.Nullable<int> Playtime
		{
			get
			{
				return this._Playtime;
			}
			set
			{
				if ((this._Playtime != value))
				{
					this.OnPlaytimeChanging(value);
					this.SendPropertyChanging();
					this._Playtime = value;
					this.SendPropertyChanged("Playtime");
					this.OnPlaytimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public System.Nullable<int> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="VarChar(50)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movie_Scheduler", Storage="_Schedulers", ThisKey="MovieID", OtherKey="MovieID")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6, EmitDefaultValue=false)]
		public EntitySet<Scheduler> Schedulers
		{
			get
			{
				if ((this.serializing 
							&& (this._Schedulers.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._Schedulers;
			}
			set
			{
				this._Schedulers.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Schedulers(Scheduler entity)
		{
			this.SendPropertyChanging();
			entity.Movie = this;
		}
		
		private void detach_Schedulers(Scheduler entity)
		{
			this.SendPropertyChanging();
			entity.Movie = null;
		}
		
		private void Initialize()
		{
			this._Schedulers = new EntitySet<Scheduler>(new Action<Scheduler>(this.attach_Schedulers), new Action<Scheduler>(this.detach_Schedulers));
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Scheduler")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Scheduler : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SchID;
		
		private System.Nullable<System.DateTime> _Datetime;
		
		private System.Nullable<System.TimeSpan> _Starttime;
		
		private System.Nullable<int> _MovieID;
		
		private System.Nullable<int> _HallID;
		
		private EntitySet<Seat> _Seats;
		
		private EntitySet<Reservation> _Reservations;
		
		private EntityRef<Hall> _Hall;
		
		private EntityRef<Movie> _Movie;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSchIDChanging(int value);
    partial void OnSchIDChanged();
    partial void OnDatetimeChanging(System.Nullable<System.DateTime> value);
    partial void OnDatetimeChanged();
    partial void OnStarttimeChanging(System.Nullable<System.TimeSpan> value);
    partial void OnStarttimeChanged();
    partial void OnMovieIDChanging(System.Nullable<int> value);
    partial void OnMovieIDChanged();
    partial void OnHallIDChanging(System.Nullable<int> value);
    partial void OnHallIDChanged();
    #endregion
		
		public Scheduler()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SchID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int SchID
		{
			get
			{
				return this._SchID;
			}
			set
			{
				if ((this._SchID != value))
				{
					this.OnSchIDChanging(value);
					this.SendPropertyChanging();
					this._SchID = value;
					this.SendPropertyChanged("SchID");
					this.OnSchIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Datetime", DbType="Date")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public System.Nullable<System.DateTime> Datetime
		{
			get
			{
				return this._Datetime;
			}
			set
			{
				if ((this._Datetime != value))
				{
					this.OnDatetimeChanging(value);
					this.SendPropertyChanging();
					this._Datetime = value;
					this.SendPropertyChanged("Datetime");
					this.OnDatetimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Starttime", DbType="Time")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public System.Nullable<System.TimeSpan> Starttime
		{
			get
			{
				return this._Starttime;
			}
			set
			{
				if ((this._Starttime != value))
				{
					this.OnStarttimeChanging(value);
					this.SendPropertyChanging();
					this._Starttime = value;
					this.SendPropertyChanged("Starttime");
					this.OnStarttimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieID", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public System.Nullable<int> MovieID
		{
			get
			{
				return this._MovieID;
			}
			set
			{
				if ((this._MovieID != value))
				{
					if (this._Movie.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMovieIDChanging(value);
					this.SendPropertyChanging();
					this._MovieID = value;
					this.SendPropertyChanged("MovieID");
					this.OnMovieIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HallID", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public System.Nullable<int> HallID
		{
			get
			{
				return this._HallID;
			}
			set
			{
				if ((this._HallID != value))
				{
					if (this._Hall.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnHallIDChanging(value);
					this.SendPropertyChanging();
					this._HallID = value;
					this.SendPropertyChanged("HallID");
					this.OnHallIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Scheduler_Seat", Storage="_Seats", ThisKey="SchID", OtherKey="SchedulerID")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6, EmitDefaultValue=false)]
		public EntitySet<Seat> Seats
		{
			get
			{
				if ((this.serializing 
							&& (this._Seats.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._Seats;
			}
			set
			{
				this._Seats.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Scheduler_Reservation", Storage="_Reservations", ThisKey="SchID", OtherKey="SchedulerID")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=7, EmitDefaultValue=false)]
		public EntitySet<Reservation> Reservations
		{
			get
			{
				if ((this.serializing 
							&& (this._Reservations.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._Reservations;
			}
			set
			{
				this._Reservations.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Hall_Scheduler", Storage="_Hall", ThisKey="HallID", OtherKey="HallID", IsForeignKey=true)]
		public Hall Hall
		{
			get
			{
				return this._Hall.Entity;
			}
			set
			{
				Hall previousValue = this._Hall.Entity;
				if (((previousValue != value) 
							|| (this._Hall.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Hall.Entity = null;
						previousValue.Schedulers.Remove(this);
					}
					this._Hall.Entity = value;
					if ((value != null))
					{
						value.Schedulers.Add(this);
						this._HallID = value.HallID;
					}
					else
					{
						this._HallID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Hall");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movie_Scheduler", Storage="_Movie", ThisKey="MovieID", OtherKey="MovieID", IsForeignKey=true, DeleteRule="SET DEFAULT")]
		public Movie Movie
		{
			get
			{
				return this._Movie.Entity;
			}
			set
			{
				Movie previousValue = this._Movie.Entity;
				if (((previousValue != value) 
							|| (this._Movie.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Movie.Entity = null;
						previousValue.Schedulers.Remove(this);
					}
					this._Movie.Entity = value;
					if ((value != null))
					{
						value.Schedulers.Add(this);
						this._MovieID = value.MovieID;
					}
					else
					{
						this._MovieID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Movie");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Seats(Seat entity)
		{
			this.SendPropertyChanging();
			entity.Scheduler = this;
		}
		
		private void detach_Seats(Seat entity)
		{
			this.SendPropertyChanging();
			entity.Scheduler = null;
		}
		
		private void attach_Reservations(Reservation entity)
		{
			this.SendPropertyChanging();
			entity.Scheduler = this;
		}
		
		private void detach_Reservations(Reservation entity)
		{
			this.SendPropertyChanging();
			entity.Scheduler = null;
		}
		
		private void Initialize()
		{
			this._Seats = new EntitySet<Seat>(new Action<Seat>(this.attach_Seats), new Action<Seat>(this.detach_Seats));
			this._Reservations = new EntitySet<Reservation>(new Action<Reservation>(this.attach_Reservations), new Action<Reservation>(this.detach_Reservations));
			this._Hall = default(EntityRef<Hall>);
			this._Movie = default(EntityRef<Movie>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Seat")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Seat : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _Row;
		
		private string _ColumnArray;
		
		private System.Nullable<int> _SchedulerID;
		
		private EntityRef<Scheduler> _Scheduler;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnRowChanging(System.Nullable<int> value);
    partial void OnRowChanged();
    partial void OnColumnArrayChanging(string value);
    partial void OnColumnArrayChanged();
    partial void OnSchedulerIDChanging(System.Nullable<int> value);
    partial void OnSchedulerIDChanged();
    #endregion
		
		public Seat()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Row", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public System.Nullable<int> Row
		{
			get
			{
				return this._Row;
			}
			set
			{
				if ((this._Row != value))
				{
					this.OnRowChanging(value);
					this.SendPropertyChanging();
					this._Row = value;
					this.SendPropertyChanged("Row");
					this.OnRowChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ColumnArray", DbType="VarChar(MAX)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string ColumnArray
		{
			get
			{
				return this._ColumnArray;
			}
			set
			{
				if ((this._ColumnArray != value))
				{
					this.OnColumnArrayChanging(value);
					this.SendPropertyChanging();
					this._ColumnArray = value;
					this.SendPropertyChanged("ColumnArray");
					this.OnColumnArrayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SchedulerID", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public System.Nullable<int> SchedulerID
		{
			get
			{
				return this._SchedulerID;
			}
			set
			{
				if ((this._SchedulerID != value))
				{
					if (this._Scheduler.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSchedulerIDChanging(value);
					this.SendPropertyChanging();
					this._SchedulerID = value;
					this.SendPropertyChanged("SchedulerID");
					this.OnSchedulerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Scheduler_Seat", Storage="_Scheduler", ThisKey="SchedulerID", OtherKey="SchID", IsForeignKey=true, DeleteRule="CASCADE")]
		public Scheduler Scheduler
		{
			get
			{
				return this._Scheduler.Entity;
			}
			set
			{
				Scheduler previousValue = this._Scheduler.Entity;
				if (((previousValue != value) 
							|| (this._Scheduler.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Scheduler.Entity = null;
						previousValue.Seats.Remove(this);
					}
					this._Scheduler.Entity = value;
					if ((value != null))
					{
						value.Seats.Add(this);
						this._SchedulerID = value.SchID;
					}
					else
					{
						this._SchedulerID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Scheduler");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			this._Scheduler = default(EntityRef<Scheduler>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Reservation")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Reservation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ResID;
		
		private System.Nullable<int> _CustomerID;
		
		private System.Nullable<int> _SchedulerID;
		
		private string _Row;
		
		private string _Seat;
		
		private EntityRef<Customer> _Customer;
		
		private EntityRef<Scheduler> _Scheduler;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnResIDChanging(int value);
    partial void OnResIDChanged();
    partial void OnCustomerIDChanging(System.Nullable<int> value);
    partial void OnCustomerIDChanged();
    partial void OnSchedulerIDChanging(System.Nullable<int> value);
    partial void OnSchedulerIDChanged();
    partial void OnRowChanging(string value);
    partial void OnRowChanged();
    partial void OnSeatChanging(string value);
    partial void OnSeatChanged();
    #endregion
		
		public Reservation()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int ResID
		{
			get
			{
				return this._ResID;
			}
			set
			{
				if ((this._ResID != value))
				{
					this.OnResIDChanging(value);
					this.SendPropertyChanging();
					this._ResID = value;
					this.SendPropertyChanged("ResID");
					this.OnResIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public System.Nullable<int> CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SchedulerID", DbType="Int")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public System.Nullable<int> SchedulerID
		{
			get
			{
				return this._SchedulerID;
			}
			set
			{
				if ((this._SchedulerID != value))
				{
					if (this._Scheduler.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSchedulerIDChanging(value);
					this.SendPropertyChanging();
					this._SchedulerID = value;
					this.SendPropertyChanged("SchedulerID");
					this.OnSchedulerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Row", DbType="VarChar(MAX)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public string Row
		{
			get
			{
				return this._Row;
			}
			set
			{
				if ((this._Row != value))
				{
					this.OnRowChanging(value);
					this.SendPropertyChanging();
					this._Row = value;
					this.SendPropertyChanged("Row");
					this.OnRowChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Seat", DbType="VarChar(MAX)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public string Seat
		{
			get
			{
				return this._Seat;
			}
			set
			{
				if ((this._Seat != value))
				{
					this.OnSeatChanging(value);
					this.SendPropertyChanging();
					this._Seat = value;
					this.SendPropertyChanged("Seat");
					this.OnSeatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Reservation", Storage="_Customer", ThisKey="CustomerID", OtherKey="CusID", IsForeignKey=true, DeleteRule="CASCADE")]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Reservations.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Reservations.Add(this);
						this._CustomerID = value.CusID;
					}
					else
					{
						this._CustomerID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Scheduler_Reservation", Storage="_Scheduler", ThisKey="SchedulerID", OtherKey="SchID", IsForeignKey=true, DeleteRule="SET DEFAULT")]
		public Scheduler Scheduler
		{
			get
			{
				return this._Scheduler.Entity;
			}
			set
			{
				Scheduler previousValue = this._Scheduler.Entity;
				if (((previousValue != value) 
							|| (this._Scheduler.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Scheduler.Entity = null;
						previousValue.Reservations.Remove(this);
					}
					this._Scheduler.Entity = value;
					if ((value != null))
					{
						value.Reservations.Add(this);
						this._SchedulerID = value.SchID;
					}
					else
					{
						this._SchedulerID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Scheduler");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			this._Customer = default(EntityRef<Customer>);
			this._Scheduler = default(EntityRef<Scheduler>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
}
#pragma warning restore 1591
