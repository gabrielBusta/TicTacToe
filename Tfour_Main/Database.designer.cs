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

namespace Tfour_Main
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Tfour")]
	public partial class DatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPlayerHistory(PlayerHistory instance);
    partial void UpdatePlayerHistory(PlayerHistory instance);
    partial void DeletePlayerHistory(PlayerHistory instance);
    partial void InsertPlayerInformation(PlayerInformation instance);
    partial void UpdatePlayerInformation(PlayerInformation instance);
    partial void DeletePlayerInformation(PlayerInformation instance);
    #endregion
		
		public DatabaseDataContext() : 
				base(global::Tfour_Main.Properties.Settings.Default.TfourConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<PlayerHistory> PlayerHistories
		{
			get
			{
				return this.GetTable<PlayerHistory>();
			}
		}
		
		public System.Data.Linq.Table<PlayerInformation> PlayerInformations
		{
			get
			{
				return this.GetTable<PlayerInformation>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PlayerHistory")]
	public partial class PlayerHistory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _HistoryID;
		
		private string _PlayerOne;
		
		private int _PlayerOneScore;
		
		private string _Apponet;
		
		private int _ApponetScore;
		
		private string _Winner;
		
		private System.DateTime _GameDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHistoryIDChanging(int value);
    partial void OnHistoryIDChanged();
    partial void OnPlayerOneChanging(string value);
    partial void OnPlayerOneChanged();
    partial void OnPlayerOneScoreChanging(int value);
    partial void OnPlayerOneScoreChanged();
    partial void OnApponetChanging(string value);
    partial void OnApponetChanged();
    partial void OnApponetScoreChanging(int value);
    partial void OnApponetScoreChanged();
    partial void OnWinnerChanging(string value);
    partial void OnWinnerChanged();
    partial void OnGameDateChanging(System.DateTime value);
    partial void OnGameDateChanged();
    #endregion
		
		public PlayerHistory()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HistoryID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int HistoryID
		{
			get
			{
				return this._HistoryID;
			}
			set
			{
				if ((this._HistoryID != value))
				{
					this.OnHistoryIDChanging(value);
					this.SendPropertyChanging();
					this._HistoryID = value;
					this.SendPropertyChanged("HistoryID");
					this.OnHistoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerOne", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string PlayerOne
		{
			get
			{
				return this._PlayerOne;
			}
			set
			{
				if ((this._PlayerOne != value))
				{
					this.OnPlayerOneChanging(value);
					this.SendPropertyChanging();
					this._PlayerOne = value;
					this.SendPropertyChanged("PlayerOne");
					this.OnPlayerOneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerOneScore", DbType="Int NOT NULL")]
		public int PlayerOneScore
		{
			get
			{
				return this._PlayerOneScore;
			}
			set
			{
				if ((this._PlayerOneScore != value))
				{
					this.OnPlayerOneScoreChanging(value);
					this.SendPropertyChanging();
					this._PlayerOneScore = value;
					this.SendPropertyChanged("PlayerOneScore");
					this.OnPlayerOneScoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apponet", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Apponet
		{
			get
			{
				return this._Apponet;
			}
			set
			{
				if ((this._Apponet != value))
				{
					this.OnApponetChanging(value);
					this.SendPropertyChanging();
					this._Apponet = value;
					this.SendPropertyChanged("Apponet");
					this.OnApponetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApponetScore", DbType="Int NOT NULL")]
		public int ApponetScore
		{
			get
			{
				return this._ApponetScore;
			}
			set
			{
				if ((this._ApponetScore != value))
				{
					this.OnApponetScoreChanging(value);
					this.SendPropertyChanging();
					this._ApponetScore = value;
					this.SendPropertyChanged("ApponetScore");
					this.OnApponetScoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Winner", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Winner
		{
			get
			{
				return this._Winner;
			}
			set
			{
				if ((this._Winner != value))
				{
					this.OnWinnerChanging(value);
					this.SendPropertyChanging();
					this._Winner = value;
					this.SendPropertyChanged("Winner");
					this.OnWinnerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GameDate", DbType="DateTime NOT NULL")]
		public System.DateTime GameDate
		{
			get
			{
				return this._GameDate;
			}
			set
			{
				if ((this._GameDate != value))
				{
					this.OnGameDateChanging(value);
					this.SendPropertyChanging();
					this._GameDate = value;
					this.SendPropertyChanged("GameDate");
					this.OnGameDateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PlayerInformation")]
	public partial class PlayerInformation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _UserID;
		
		private string _Password;
		
		private string _Email;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public PlayerInformation()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
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
