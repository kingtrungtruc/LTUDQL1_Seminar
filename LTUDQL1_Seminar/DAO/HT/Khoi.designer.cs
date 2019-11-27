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

namespace DAO.HT
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CSDL")]
	public partial class KhoiDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKhoi(Khoi instance);
    partial void UpdateKhoi(Khoi instance);
    partial void DeleteKhoi(Khoi instance);
    #endregion
		
		public KhoiDataContext() : 
				base(global::DAO.Properties.Settings.Default.CSDLConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public KhoiDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KhoiDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KhoiDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KhoiDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Khoi> Khois
		{
			get
			{
				return this.GetTable<Khoi>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Khoi")]
	public partial class Khoi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKhoi;
		
		private string _TenKhoi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhoiChanging(int value);
    partial void OnMaKhoiChanged();
    partial void OnTenKhoiChanging(string value);
    partial void OnTenKhoiChanged();
    #endregion
		
		public Khoi()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhoi", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaKhoi
		{
			get
			{
				return this._MaKhoi;
			}
			set
			{
				if ((this._MaKhoi != value))
				{
					this.OnMaKhoiChanging(value);
					this.SendPropertyChanging();
					this._MaKhoi = value;
					this.SendPropertyChanged("MaKhoi");
					this.OnMaKhoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhoi", DbType="NVarChar(50)")]
		public string TenKhoi
		{
			get
			{
				return this._TenKhoi;
			}
			set
			{
				if ((this._TenKhoi != value))
				{
					this.OnTenKhoiChanging(value);
					this.SendPropertyChanging();
					this._TenKhoi = value;
					this.SendPropertyChanged("TenKhoi");
					this.OnTenKhoiChanged();
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
