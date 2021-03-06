﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQToSQL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="cinemaDB")]
	public partial class CinemaDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertActor(Actor instance);
    partial void UpdateActor(Actor instance);
    partial void DeleteActor(Actor instance);
    partial void InsertCast(Cast instance);
    partial void UpdateCast(Cast instance);
    partial void DeleteCast(Cast instance);
    partial void Insertmovy(movy instance);
    partial void Updatemovy(movy instance);
    partial void Deletemovy(movy instance);
    partial void Insertreservation(reservation instance);
    partial void Updatereservation(reservation instance);
    partial void Deletereservation(reservation instance);
    partial void Insertroom(room instance);
    partial void Updateroom(room instance);
    partial void Deleteroom(room instance);
    partial void Insertschedule(schedule instance);
    partial void Updateschedule(schedule instance);
    partial void Deleteschedule(schedule instance);
    #endregion
		
		public CinemaDBDataContext() : 
				base(global::LINQToSQL.Properties.Settings.Default.cinemaDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CinemaDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CinemaDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CinemaDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CinemaDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Actor> Actors
		{
			get
			{
				return this.GetTable<Actor>();
			}
		}
		
		public System.Data.Linq.Table<Cast> Casts
		{
			get
			{
				return this.GetTable<Cast>();
			}
		}
		
		public System.Data.Linq.Table<movy> movies
		{
			get
			{
				return this.GetTable<movy>();
			}
		}
		
		public System.Data.Linq.Table<reservation> reservations
		{
			get
			{
				return this.GetTable<reservation>();
			}
		}
		
		public System.Data.Linq.Table<room> rooms
		{
			get
			{
				return this.GetTable<room>();
			}
		}
		
		public System.Data.Linq.Table<schedule> schedules
		{
			get
			{
				return this.GetTable<schedule>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Actors")]
	public partial class Actor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private System.DateTime _Birthdate;
		
		private decimal _Cachet;
		
		private EntitySet<Cast> _Casts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnBirthdateChanging(System.DateTime value);
    partial void OnBirthdateChanged();
    partial void OnCachetChanging(decimal value);
    partial void OnCachetChanged();
    #endregion
		
		public Actor()
		{
			this._Casts = new EntitySet<Cast>(new Action<Cast>(this.attach_Casts), new Action<Cast>(this.detach_Casts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthdate", DbType="Date NOT NULL")]
		public System.DateTime Birthdate
		{
			get
			{
				return this._Birthdate;
			}
			set
			{
				if ((this._Birthdate != value))
				{
					this.OnBirthdateChanging(value);
					this.SendPropertyChanging();
					this._Birthdate = value;
					this.SendPropertyChanged("Birthdate");
					this.OnBirthdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cachet", DbType="Money NOT NULL")]
		public decimal Cachet
		{
			get
			{
				return this._Cachet;
			}
			set
			{
				if ((this._Cachet != value))
				{
					this.OnCachetChanging(value);
					this.SendPropertyChanging();
					this._Cachet = value;
					this.SendPropertyChanged("Cachet");
					this.OnCachetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Actor_Cast", Storage="_Casts", ThisKey="ID", OtherKey="ActorId")]
		public EntitySet<Cast> Casts
		{
			get
			{
				return this._Casts;
			}
			set
			{
				this._Casts.Assign(value);
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
		
		private void attach_Casts(Cast entity)
		{
			this.SendPropertyChanging();
			entity.Actor = this;
		}
		
		private void detach_Casts(Cast entity)
		{
			this.SendPropertyChanging();
			entity.Actor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Casts")]
	public partial class Cast : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MovieId;
		
		private int _ActorId;
		
		private EntityRef<Actor> _Actor;
		
		private EntityRef<movy> _movy;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMovieIdChanging(int value);
    partial void OnMovieIdChanged();
    partial void OnActorIdChanging(int value);
    partial void OnActorIdChanged();
    #endregion
		
		public Cast()
		{
			this._Actor = default(EntityRef<Actor>);
			this._movy = default(EntityRef<movy>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MovieId
		{
			get
			{
				return this._MovieId;
			}
			set
			{
				if ((this._MovieId != value))
				{
					if (this._movy.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMovieIdChanging(value);
					this.SendPropertyChanging();
					this._MovieId = value;
					this.SendPropertyChanged("MovieId");
					this.OnMovieIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActorId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ActorId
		{
			get
			{
				return this._ActorId;
			}
			set
			{
				if ((this._ActorId != value))
				{
					if (this._Actor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnActorIdChanging(value);
					this.SendPropertyChanging();
					this._ActorId = value;
					this.SendPropertyChanged("ActorId");
					this.OnActorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Actor_Cast", Storage="_Actor", ThisKey="ActorId", OtherKey="ID", IsForeignKey=true)]
		public Actor Actor
		{
			get
			{
				return this._Actor.Entity;
			}
			set
			{
				Actor previousValue = this._Actor.Entity;
				if (((previousValue != value) 
							|| (this._Actor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Actor.Entity = null;
						previousValue.Casts.Remove(this);
					}
					this._Actor.Entity = value;
					if ((value != null))
					{
						value.Casts.Add(this);
						this._ActorId = value.ID;
					}
					else
					{
						this._ActorId = default(int);
					}
					this.SendPropertyChanged("Actor");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="movy_Cast", Storage="_movy", ThisKey="MovieId", OtherKey="ID", IsForeignKey=true)]
		public movy movy
		{
			get
			{
				return this._movy.Entity;
			}
			set
			{
				movy previousValue = this._movy.Entity;
				if (((previousValue != value) 
							|| (this._movy.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._movy.Entity = null;
						previousValue.Casts.Remove(this);
					}
					this._movy.Entity = value;
					if ((value != null))
					{
						value.Casts.Add(this);
						this._MovieId = value.ID;
					}
					else
					{
						this._MovieId = default(int);
					}
					this.SendPropertyChanged("movy");
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
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.movies")]
	public partial class movy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _titolo;
		
		private string _genere;
		
		private System.Nullable<int> _durata;
		
		private EntitySet<Cast> _Casts;
		
		private EntitySet<schedule> _schedules;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OntitoloChanging(string value);
    partial void OntitoloChanged();
    partial void OngenereChanging(string value);
    partial void OngenereChanged();
    partial void OndurataChanging(System.Nullable<int> value);
    partial void OndurataChanged();
    #endregion
		
		public movy()
		{
			this._Casts = new EntitySet<Cast>(new Action<Cast>(this.attach_Casts), new Action<Cast>(this.detach_Casts));
			this._schedules = new EntitySet<schedule>(new Action<schedule>(this.attach_schedules), new Action<schedule>(this.detach_schedules));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_titolo", DbType="NVarChar(255)")]
		public string titolo
		{
			get
			{
				return this._titolo;
			}
			set
			{
				if ((this._titolo != value))
				{
					this.OntitoloChanging(value);
					this.SendPropertyChanging();
					this._titolo = value;
					this.SendPropertyChanged("titolo");
					this.OntitoloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_genere", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string genere
		{
			get
			{
				return this._genere;
			}
			set
			{
				if ((this._genere != value))
				{
					this.OngenereChanging(value);
					this.SendPropertyChanging();
					this._genere = value;
					this.SendPropertyChanged("genere");
					this.OngenereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_durata", DbType="Int")]
		public System.Nullable<int> durata
		{
			get
			{
				return this._durata;
			}
			set
			{
				if ((this._durata != value))
				{
					this.OndurataChanging(value);
					this.SendPropertyChanging();
					this._durata = value;
					this.SendPropertyChanged("durata");
					this.OndurataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="movy_Cast", Storage="_Casts", ThisKey="ID", OtherKey="MovieId")]
		public EntitySet<Cast> Casts
		{
			get
			{
				return this._Casts;
			}
			set
			{
				this._Casts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="movy_schedule", Storage="_schedules", ThisKey="ID", OtherKey="movieID")]
		public EntitySet<schedule> schedules
		{
			get
			{
				return this._schedules;
			}
			set
			{
				this._schedules.Assign(value);
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
		
		private void attach_Casts(Cast entity)
		{
			this.SendPropertyChanging();
			entity.movy = this;
		}
		
		private void detach_Casts(Cast entity)
		{
			this.SendPropertyChanging();
			entity.movy = null;
		}
		
		private void attach_schedules(schedule entity)
		{
			this.SendPropertyChanging();
			entity.movy = this;
		}
		
		private void detach_schedules(schedule entity)
		{
			this.SendPropertyChanging();
			entity.movy = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.reservations")]
	public partial class reservation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _scheduleID;
		
		private System.Nullable<int> _ppl;
		
		private string _mail;
		
		private int _ID;
		
		private EntityRef<schedule> _schedule;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnscheduleIDChanging(int value);
    partial void OnscheduleIDChanged();
    partial void OnpplChanging(System.Nullable<int> value);
    partial void OnpplChanged();
    partial void OnmailChanging(string value);
    partial void OnmailChanged();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    #endregion
		
		public reservation()
		{
			this._schedule = default(EntityRef<schedule>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_scheduleID", DbType="Int NOT NULL")]
		public int scheduleID
		{
			get
			{
				return this._scheduleID;
			}
			set
			{
				if ((this._scheduleID != value))
				{
					if (this._schedule.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnscheduleIDChanging(value);
					this.SendPropertyChanging();
					this._scheduleID = value;
					this.SendPropertyChanged("scheduleID");
					this.OnscheduleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ppl", DbType="Int")]
		public System.Nullable<int> ppl
		{
			get
			{
				return this._ppl;
			}
			set
			{
				if ((this._ppl != value))
				{
					this.OnpplChanging(value);
					this.SendPropertyChanging();
					this._ppl = value;
					this.SendPropertyChanged("ppl");
					this.OnpplChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mail", DbType="NVarChar(255)")]
		public string mail
		{
			get
			{
				return this._mail;
			}
			set
			{
				if ((this._mail != value))
				{
					this.OnmailChanging(value);
					this.SendPropertyChanging();
					this._mail = value;
					this.SendPropertyChanged("mail");
					this.OnmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="schedule_reservation", Storage="_schedule", ThisKey="scheduleID", OtherKey="ID", IsForeignKey=true)]
		public schedule schedule
		{
			get
			{
				return this._schedule.Entity;
			}
			set
			{
				schedule previousValue = this._schedule.Entity;
				if (((previousValue != value) 
							|| (this._schedule.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._schedule.Entity = null;
						previousValue.reservations.Remove(this);
					}
					this._schedule.Entity = value;
					if ((value != null))
					{
						value.reservations.Add(this);
						this._scheduleID = value.ID;
					}
					else
					{
						this._scheduleID = default(int);
					}
					this.SendPropertyChanged("schedule");
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
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.rooms")]
	public partial class room : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _nome;
		
		private System.Nullable<int> _posti;
		
		private EntitySet<schedule> _schedules;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OnpostiChanging(System.Nullable<int> value);
    partial void OnpostiChanged();
    #endregion
		
		public room()
		{
			this._schedules = new EntitySet<schedule>(new Action<schedule>(this.attach_schedules), new Action<schedule>(this.detach_schedules));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="NVarChar(255)")]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_posti", DbType="Int")]
		public System.Nullable<int> posti
		{
			get
			{
				return this._posti;
			}
			set
			{
				if ((this._posti != value))
				{
					this.OnpostiChanging(value);
					this.SendPropertyChanging();
					this._posti = value;
					this.SendPropertyChanged("posti");
					this.OnpostiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="room_schedule", Storage="_schedules", ThisKey="ID", OtherKey="roomID")]
		public EntitySet<schedule> schedules
		{
			get
			{
				return this._schedules;
			}
			set
			{
				this._schedules.Assign(value);
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
		
		private void attach_schedules(schedule entity)
		{
			this.SendPropertyChanging();
			entity.room = this;
		}
		
		private void detach_schedules(schedule entity)
		{
			this.SendPropertyChanging();
			entity.room = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.schedules")]
	public partial class schedule : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _movieID;
		
		private int _roomID;
		
		private System.Nullable<decimal> _price;
		
		private System.Nullable<System.TimeSpan> _time;
		
		private System.Nullable<int> _disp;
		
		private EntitySet<reservation> _reservations;
		
		private EntityRef<movy> _movy;
		
		private EntityRef<room> _room;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnmovieIDChanging(int value);
    partial void OnmovieIDChanged();
    partial void OnroomIDChanging(int value);
    partial void OnroomIDChanged();
    partial void OnpriceChanging(System.Nullable<decimal> value);
    partial void OnpriceChanged();
    partial void OntimeChanging(System.Nullable<System.TimeSpan> value);
    partial void OntimeChanged();
    partial void OndispChanging(System.Nullable<int> value);
    partial void OndispChanged();
    #endregion
		
		public schedule()
		{
			this._reservations = new EntitySet<reservation>(new Action<reservation>(this.attach_reservations), new Action<reservation>(this.detach_reservations));
			this._movy = default(EntityRef<movy>);
			this._room = default(EntityRef<room>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_movieID", DbType="Int NOT NULL")]
		public int movieID
		{
			get
			{
				return this._movieID;
			}
			set
			{
				if ((this._movieID != value))
				{
					if (this._movy.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmovieIDChanging(value);
					this.SendPropertyChanging();
					this._movieID = value;
					this.SendPropertyChanged("movieID");
					this.OnmovieIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_roomID", DbType="Int NOT NULL")]
		public int roomID
		{
			get
			{
				return this._roomID;
			}
			set
			{
				if ((this._roomID != value))
				{
					if (this._room.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnroomIDChanging(value);
					this.SendPropertyChanging();
					this._roomID = value;
					this.SendPropertyChanged("roomID");
					this.OnroomIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Money")]
		public System.Nullable<decimal> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time", DbType="Time")]
		public System.Nullable<System.TimeSpan> time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this.OntimeChanging(value);
					this.SendPropertyChanging();
					this._time = value;
					this.SendPropertyChanged("time");
					this.OntimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_disp", DbType="Int")]
		public System.Nullable<int> disp
		{
			get
			{
				return this._disp;
			}
			set
			{
				if ((this._disp != value))
				{
					this.OndispChanging(value);
					this.SendPropertyChanging();
					this._disp = value;
					this.SendPropertyChanged("disp");
					this.OndispChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="schedule_reservation", Storage="_reservations", ThisKey="ID", OtherKey="scheduleID")]
		public EntitySet<reservation> reservations
		{
			get
			{
				return this._reservations;
			}
			set
			{
				this._reservations.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="movy_schedule", Storage="_movy", ThisKey="movieID", OtherKey="ID", IsForeignKey=true)]
		public movy movy
		{
			get
			{
				return this._movy.Entity;
			}
			set
			{
				movy previousValue = this._movy.Entity;
				if (((previousValue != value) 
							|| (this._movy.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._movy.Entity = null;
						previousValue.schedules.Remove(this);
					}
					this._movy.Entity = value;
					if ((value != null))
					{
						value.schedules.Add(this);
						this._movieID = value.ID;
					}
					else
					{
						this._movieID = default(int);
					}
					this.SendPropertyChanged("movy");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="room_schedule", Storage="_room", ThisKey="roomID", OtherKey="ID", IsForeignKey=true)]
		public room room
		{
			get
			{
				return this._room.Entity;
			}
			set
			{
				room previousValue = this._room.Entity;
				if (((previousValue != value) 
							|| (this._room.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._room.Entity = null;
						previousValue.schedules.Remove(this);
					}
					this._room.Entity = value;
					if ((value != null))
					{
						value.schedules.Add(this);
						this._roomID = value.ID;
					}
					else
					{
						this._roomID = default(int);
					}
					this.SendPropertyChanged("room");
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
		
		private void attach_reservations(reservation entity)
		{
			this.SendPropertyChanging();
			entity.schedule = this;
		}
		
		private void detach_reservations(reservation entity)
		{
			this.SendPropertyChanging();
			entity.schedule = null;
		}
	}
}
#pragma warning restore 1591
