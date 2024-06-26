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

namespace ConsoleApp38
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Location_DataBase")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertconnexion(connexion instance);
    partial void Updateconnexion(connexion instance);
    partial void Deleteconnexion(connexion instance);
    partial void Insertreservation(reservation instance);
    partial void Updatereservation(reservation instance);
    partial void Deletereservation(reservation instance);
    partial void Insertvoiture(voiture instance);
    partial void Updatevoiture(voiture instance);
    partial void Deletevoiture(voiture instance);
    partial void Insertmaintenance(maintenance instance);
    partial void Updatemaintenance(maintenance instance);
    partial void Deletemaintenance(maintenance instance);
    partial void Insertclient(client instance);
    partial void Updateclient(client instance);
    partial void Deleteclient(client instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ConsoleApp38.Properties.Settings.Default.Location_DataBaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<connexion> connexions
		{
			get
			{
				return this.GetTable<connexion>();
			}
		}
		
		public System.Data.Linq.Table<reservation> reservations
		{
			get
			{
				return this.GetTable<reservation>();
			}
		}
		
		public System.Data.Linq.Table<voiture> voitures
		{
			get
			{
				return this.GetTable<voiture>();
			}
		}
		
		public System.Data.Linq.Table<maintenance> maintenances
		{
			get
			{
				return this.GetTable<maintenance>();
			}
		}
		
		public System.Data.Linq.Table<client> clients
		{
			get
			{
				return this.GetTable<client>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.connexion")]
	public partial class connexion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _username;
		
		private string _password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public connexion()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(20)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(20)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.reservation")]
	public partial class reservation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id_reservation;
		
		private string _id_voiture;
		
		private string _id_client;
		
		private System.DateTime _date_debut;
		
		private System.DateTime _date_fin;
		
		private decimal _montant;
		
		private decimal _avance;
		
		private decimal _reste;
		
		private EntityRef<voiture> _voiture;
		
		private EntityRef<client> _client;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_reservationChanging(string value);
    partial void Onid_reservationChanged();
    partial void Onid_voitureChanging(string value);
    partial void Onid_voitureChanged();
    partial void Onid_clientChanging(string value);
    partial void Onid_clientChanged();
    partial void Ondate_debutChanging(System.DateTime value);
    partial void Ondate_debutChanged();
    partial void Ondate_finChanging(System.DateTime value);
    partial void Ondate_finChanged();
    partial void OnmontantChanging(decimal value);
    partial void OnmontantChanged();
    partial void OnavanceChanging(decimal value);
    partial void OnavanceChanged();
    partial void OnresteChanging(decimal value);
    partial void OnresteChanged();
    #endregion
		
		public reservation()
		{
			this._voiture = default(EntityRef<voiture>);
			this._client = default(EntityRef<client>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_reservation", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id_reservation
		{
			get
			{
				return this._id_reservation;
			}
			set
			{
				if ((this._id_reservation != value))
				{
					this.Onid_reservationChanging(value);
					this.SendPropertyChanging();
					this._id_reservation = value;
					this.SendPropertyChanged("id_reservation");
					this.Onid_reservationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_voiture", DbType="VarChar(10)")]
		public string id_voiture
		{
			get
			{
				return this._id_voiture;
			}
			set
			{
				if ((this._id_voiture != value))
				{
					if (this._voiture.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_voitureChanging(value);
					this.SendPropertyChanging();
					this._id_voiture = value;
					this.SendPropertyChanged("id_voiture");
					this.Onid_voitureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_client", DbType="VarChar(10)")]
		public string id_client
		{
			get
			{
				return this._id_client;
			}
			set
			{
				if ((this._id_client != value))
				{
					if (this._client.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_clientChanging(value);
					this.SendPropertyChanging();
					this._id_client = value;
					this.SendPropertyChanged("id_client");
					this.Onid_clientChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_debut", DbType="Date NOT NULL")]
		public System.DateTime date_debut
		{
			get
			{
				return this._date_debut;
			}
			set
			{
				if ((this._date_debut != value))
				{
					this.Ondate_debutChanging(value);
					this.SendPropertyChanging();
					this._date_debut = value;
					this.SendPropertyChanged("date_debut");
					this.Ondate_debutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_fin", DbType="Date NOT NULL")]
		public System.DateTime date_fin
		{
			get
			{
				return this._date_fin;
			}
			set
			{
				if ((this._date_fin != value))
				{
					this.Ondate_finChanging(value);
					this.SendPropertyChanging();
					this._date_fin = value;
					this.SendPropertyChanged("date_fin");
					this.Ondate_finChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_montant", DbType="Decimal(18,0) NOT NULL")]
		public decimal montant
		{
			get
			{
				return this._montant;
			}
			set
			{
				if ((this._montant != value))
				{
					this.OnmontantChanging(value);
					this.SendPropertyChanging();
					this._montant = value;
					this.SendPropertyChanged("montant");
					this.OnmontantChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_avance", DbType="Decimal(18,0) NOT NULL")]
		public decimal avance
		{
			get
			{
				return this._avance;
			}
			set
			{
				if ((this._avance != value))
				{
					this.OnavanceChanging(value);
					this.SendPropertyChanging();
					this._avance = value;
					this.SendPropertyChanged("avance");
					this.OnavanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_reste", DbType="Decimal(18,0) NOT NULL")]
		public decimal reste
		{
			get
			{
				return this._reste;
			}
			set
			{
				if ((this._reste != value))
				{
					this.OnresteChanging(value);
					this.SendPropertyChanging();
					this._reste = value;
					this.SendPropertyChanged("reste");
					this.OnresteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="voiture_reservation", Storage="_voiture", ThisKey="id_voiture", OtherKey="id_voiture", IsForeignKey=true)]
		public voiture voiture
		{
			get
			{
				return this._voiture.Entity;
			}
			set
			{
				voiture previousValue = this._voiture.Entity;
				if (((previousValue != value) 
							|| (this._voiture.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._voiture.Entity = null;
						previousValue.reservations.Remove(this);
					}
					this._voiture.Entity = value;
					if ((value != null))
					{
						value.reservations.Add(this);
						this._id_voiture = value.id_voiture;
					}
					else
					{
						this._id_voiture = default(string);
					}
					this.SendPropertyChanged("voiture");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="client_reservation", Storage="_client", ThisKey="id_client", OtherKey="id_client", IsForeignKey=true)]
		public client client
		{
			get
			{
				return this._client.Entity;
			}
			set
			{
				client previousValue = this._client.Entity;
				if (((previousValue != value) 
							|| (this._client.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._client.Entity = null;
						previousValue.reservations.Remove(this);
					}
					this._client.Entity = value;
					if ((value != null))
					{
						value.reservations.Add(this);
						this._id_client = value.id_client;
					}
					else
					{
						this._id_client = default(string);
					}
					this.SendPropertyChanged("client");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.voiture")]
	public partial class voiture : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id_voiture;
		
		private string _marque;
		
		private string _modele;
		
		private int _annee_acquisition;
		
		private decimal _prix;
		
		private string _matricule;
		
		private EntitySet<reservation> _reservations;
		
		private EntitySet<maintenance> _maintenances;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_voitureChanging(string value);
    partial void Onid_voitureChanged();
    partial void OnmarqueChanging(string value);
    partial void OnmarqueChanged();
    partial void OnmodeleChanging(string value);
    partial void OnmodeleChanged();
    partial void Onannee_acquisitionChanging(int value);
    partial void Onannee_acquisitionChanged();
    partial void OnprixChanging(decimal value);
    partial void OnprixChanged();
    partial void OnmatriculeChanging(string value);
    partial void OnmatriculeChanged();
    #endregion
		
		public voiture()
		{
			this._reservations = new EntitySet<reservation>(new Action<reservation>(this.attach_reservations), new Action<reservation>(this.detach_reservations));
			this._maintenances = new EntitySet<maintenance>(new Action<maintenance>(this.attach_maintenances), new Action<maintenance>(this.detach_maintenances));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_voiture", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id_voiture
		{
			get
			{
				return this._id_voiture;
			}
			set
			{
				if ((this._id_voiture != value))
				{
					this.Onid_voitureChanging(value);
					this.SendPropertyChanging();
					this._id_voiture = value;
					this.SendPropertyChanged("id_voiture");
					this.Onid_voitureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_marque", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string marque
		{
			get
			{
				return this._marque;
			}
			set
			{
				if ((this._marque != value))
				{
					this.OnmarqueChanging(value);
					this.SendPropertyChanging();
					this._marque = value;
					this.SendPropertyChanged("marque");
					this.OnmarqueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modele", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string modele
		{
			get
			{
				return this._modele;
			}
			set
			{
				if ((this._modele != value))
				{
					this.OnmodeleChanging(value);
					this.SendPropertyChanging();
					this._modele = value;
					this.SendPropertyChanged("modele");
					this.OnmodeleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_annee_acquisition", DbType="Int NOT NULL")]
		public int annee_acquisition
		{
			get
			{
				return this._annee_acquisition;
			}
			set
			{
				if ((this._annee_acquisition != value))
				{
					this.Onannee_acquisitionChanging(value);
					this.SendPropertyChanging();
					this._annee_acquisition = value;
					this.SendPropertyChanged("annee_acquisition");
					this.Onannee_acquisitionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prix", DbType="Decimal(18,0) NOT NULL")]
		public decimal prix
		{
			get
			{
				return this._prix;
			}
			set
			{
				if ((this._prix != value))
				{
					this.OnprixChanging(value);
					this.SendPropertyChanging();
					this._prix = value;
					this.SendPropertyChanged("prix");
					this.OnprixChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matricule", DbType="VarChar(50)")]
		public string matricule
		{
			get
			{
				return this._matricule;
			}
			set
			{
				if ((this._matricule != value))
				{
					this.OnmatriculeChanging(value);
					this.SendPropertyChanging();
					this._matricule = value;
					this.SendPropertyChanged("matricule");
					this.OnmatriculeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="voiture_reservation", Storage="_reservations", ThisKey="id_voiture", OtherKey="id_voiture")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="voiture_maintenance", Storage="_maintenances", ThisKey="id_voiture", OtherKey="id_voiture")]
		public EntitySet<maintenance> maintenances
		{
			get
			{
				return this._maintenances;
			}
			set
			{
				this._maintenances.Assign(value);
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
			entity.voiture = this;
		}
		
		private void detach_reservations(reservation entity)
		{
			this.SendPropertyChanging();
			entity.voiture = null;
		}
		
		private void attach_maintenances(maintenance entity)
		{
			this.SendPropertyChanging();
			entity.voiture = this;
		}
		
		private void detach_maintenances(maintenance entity)
		{
			this.SendPropertyChanging();
			entity.voiture = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.maintenance")]
	public partial class maintenance : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id_maintenance;
		
		private string _type;
		
		private System.Nullable<System.DateTime> _date_debut;
		
		private System.Nullable<System.DateTime> _date_fin;
		
		private string _id_voiture;
		
		private EntityRef<voiture> _voiture;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_maintenanceChanging(string value);
    partial void Onid_maintenanceChanged();
    partial void OntypeChanging(string value);
    partial void OntypeChanged();
    partial void Ondate_debutChanging(System.Nullable<System.DateTime> value);
    partial void Ondate_debutChanged();
    partial void Ondate_finChanging(System.Nullable<System.DateTime> value);
    partial void Ondate_finChanged();
    partial void Onid_voitureChanging(string value);
    partial void Onid_voitureChanged();
    #endregion
		
		public maintenance()
		{
			this._voiture = default(EntityRef<voiture>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_maintenance", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id_maintenance
		{
			get
			{
				return this._id_maintenance;
			}
			set
			{
				if ((this._id_maintenance != value))
				{
					this.Onid_maintenanceChanging(value);
					this.SendPropertyChanging();
					this._id_maintenance = value;
					this.SendPropertyChanged("id_maintenance");
					this.Onid_maintenanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_debut", DbType="Date")]
		public System.Nullable<System.DateTime> date_debut
		{
			get
			{
				return this._date_debut;
			}
			set
			{
				if ((this._date_debut != value))
				{
					this.Ondate_debutChanging(value);
					this.SendPropertyChanging();
					this._date_debut = value;
					this.SendPropertyChanged("date_debut");
					this.Ondate_debutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_fin", DbType="Date")]
		public System.Nullable<System.DateTime> date_fin
		{
			get
			{
				return this._date_fin;
			}
			set
			{
				if ((this._date_fin != value))
				{
					this.Ondate_finChanging(value);
					this.SendPropertyChanging();
					this._date_fin = value;
					this.SendPropertyChanged("date_fin");
					this.Ondate_finChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_voiture", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string id_voiture
		{
			get
			{
				return this._id_voiture;
			}
			set
			{
				if ((this._id_voiture != value))
				{
					if (this._voiture.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_voitureChanging(value);
					this.SendPropertyChanging();
					this._id_voiture = value;
					this.SendPropertyChanged("id_voiture");
					this.Onid_voitureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="voiture_maintenance", Storage="_voiture", ThisKey="id_voiture", OtherKey="id_voiture", IsForeignKey=true)]
		public voiture voiture
		{
			get
			{
				return this._voiture.Entity;
			}
			set
			{
				voiture previousValue = this._voiture.Entity;
				if (((previousValue != value) 
							|| (this._voiture.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._voiture.Entity = null;
						previousValue.maintenances.Remove(this);
					}
					this._voiture.Entity = value;
					if ((value != null))
					{
						value.maintenances.Add(this);
						this._id_voiture = value.id_voiture;
					}
					else
					{
						this._id_voiture = default(string);
					}
					this.SendPropertyChanged("voiture");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.client")]
	public partial class client : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id_client;
		
		private string _nom;
		
		private string _prenom;
		
		private string _cin;
		
		private int _tel;
		
		private EntitySet<reservation> _reservations;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_clientChanging(string value);
    partial void Onid_clientChanged();
    partial void OnnomChanging(string value);
    partial void OnnomChanged();
    partial void OnprenomChanging(string value);
    partial void OnprenomChanged();
    partial void OncinChanging(string value);
    partial void OncinChanged();
    partial void OntelChanging(int value);
    partial void OntelChanged();
    #endregion
		
		public client()
		{
			this._reservations = new EntitySet<reservation>(new Action<reservation>(this.attach_reservations), new Action<reservation>(this.detach_reservations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_client", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id_client
		{
			get
			{
				return this._id_client;
			}
			set
			{
				if ((this._id_client != value))
				{
					this.Onid_clientChanging(value);
					this.SendPropertyChanging();
					this._id_client = value;
					this.SendPropertyChanged("id_client");
					this.Onid_clientChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nom", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nom
		{
			get
			{
				return this._nom;
			}
			set
			{
				if ((this._nom != value))
				{
					this.OnnomChanging(value);
					this.SendPropertyChanging();
					this._nom = value;
					this.SendPropertyChanged("nom");
					this.OnnomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prenom", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string prenom
		{
			get
			{
				return this._prenom;
			}
			set
			{
				if ((this._prenom != value))
				{
					this.OnprenomChanging(value);
					this.SendPropertyChanging();
					this._prenom = value;
					this.SendPropertyChanged("prenom");
					this.OnprenomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cin", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string cin
		{
			get
			{
				return this._cin;
			}
			set
			{
				if ((this._cin != value))
				{
					this.OncinChanging(value);
					this.SendPropertyChanging();
					this._cin = value;
					this.SendPropertyChanged("cin");
					this.OncinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tel", DbType="Int NOT NULL")]
		public int tel
		{
			get
			{
				return this._tel;
			}
			set
			{
				if ((this._tel != value))
				{
					this.OntelChanging(value);
					this.SendPropertyChanging();
					this._tel = value;
					this.SendPropertyChanged("tel");
					this.OntelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="client_reservation", Storage="_reservations", ThisKey="id_client", OtherKey="id_client")]
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
			entity.client = this;
		}
		
		private void detach_reservations(reservation entity)
		{
			this.SendPropertyChanging();
			entity.client = null;
		}
	}
}
#pragma warning restore 1591
