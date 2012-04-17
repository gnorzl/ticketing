﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mvc4.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Proxit")]
	public partial class GebruikerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertGebruiker(Gebruiker instance);
    partial void UpdateGebruiker(Gebruiker instance);
    partial void DeleteGebruiker(Gebruiker instance);
    #endregion
		
		public GebruikerDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ProxitConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public GebruikerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GebruikerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GebruikerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GebruikerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Gebruiker> Gebruikers
		{
			get
			{
				return this.GetTable<Gebruiker>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Gebruikers")]
	public partial class Gebruiker : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _wachtwoord;
		
		private string _emailadres;
		
		private string _voornaam;
		
		private string _achternaam;
		
		private string _telefoon;
		
		private string _token;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnwachtwoordChanging(string value);
    partial void OnwachtwoordChanged();
    partial void OnemailadresChanging(string value);
    partial void OnemailadresChanged();
    partial void OnvoornaamChanging(string value);
    partial void OnvoornaamChanged();
    partial void OnachternaamChanging(string value);
    partial void OnachternaamChanged();
    partial void OntelefoonChanging(string value);
    partial void OntelefoonChanged();
    partial void OntokenChanging(string value);
    partial void OntokenChanged();
    #endregion
		
		public Gebruiker()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wachtwoord", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string wachtwoord
		{
			get
			{
				return this._wachtwoord;
			}
			set
			{
				if ((this._wachtwoord != value))
				{
					this.OnwachtwoordChanging(value);
					this.SendPropertyChanging();
					this._wachtwoord = value;
					this.SendPropertyChanged("wachtwoord");
					this.OnwachtwoordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emailadres", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string emailadres
		{
			get
			{
				return this._emailadres;
			}
			set
			{
				if ((this._emailadres != value))
				{
					this.OnemailadresChanging(value);
					this.SendPropertyChanging();
					this._emailadres = value;
					this.SendPropertyChanged("emailadres");
					this.OnemailadresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_voornaam", DbType="NVarChar(50)")]
		public string voornaam
		{
			get
			{
				return this._voornaam;
			}
			set
			{
				if ((this._voornaam != value))
				{
					this.OnvoornaamChanging(value);
					this.SendPropertyChanging();
					this._voornaam = value;
					this.SendPropertyChanged("voornaam");
					this.OnvoornaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_achternaam", DbType="NVarChar(50)")]
		public string achternaam
		{
			get
			{
				return this._achternaam;
			}
			set
			{
				if ((this._achternaam != value))
				{
					this.OnachternaamChanging(value);
					this.SendPropertyChanging();
					this._achternaam = value;
					this.SendPropertyChanged("achternaam");
					this.OnachternaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefoon", DbType="NChar(15)")]
		public string telefoon
		{
			get
			{
				return this._telefoon;
			}
			set
			{
				if ((this._telefoon != value))
				{
					this.OntelefoonChanging(value);
					this.SendPropertyChanging();
					this._telefoon = value;
					this.SendPropertyChanged("telefoon");
					this.OntelefoonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_token", DbType="NChar(20)")]
		public string token
		{
			get
			{
				return this._token;
			}
			set
			{
				if ((this._token != value))
				{
					this.OntokenChanging(value);
					this.SendPropertyChanging();
					this._token = value;
					this.SendPropertyChanged("token");
					this.OntokenChanged();
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
}
#pragma warning restore 1591