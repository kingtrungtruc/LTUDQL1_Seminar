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

namespace DTO.HT
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
	public partial class KiThiDTO_HTDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKiThi(KiThi instance);
    partial void UpdateKiThi(KiThi instance);
    partial void DeleteKiThi(KiThi instance);
    #endregion
		
		public KiThiDTO_HTDataContext() : 
				base(global::DTO.Properties.Settings.Default.CSDLConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public KiThiDTO_HTDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KiThiDTO_HTDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KiThiDTO_HTDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KiThiDTO_HTDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<KiThi> KiThis
		{
			get
			{
				return this.GetTable<KiThi>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KiThi")]
	public partial class KiThi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKiThi;
		
		private string _TenKiThi;
		
		private System.Nullable<System.DateTime> _NgayThi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKiThiChanging(string value);
    partial void OnMaKiThiChanged();
    partial void OnTenKiThiChanging(string value);
    partial void OnTenKiThiChanged();
    partial void OnNgayThiChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayThiChanged();
    #endregion
		
		public KiThi()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKiThi", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaKiThi
		{
			get
			{
				return this._MaKiThi;
			}
			set
			{
				if ((this._MaKiThi != value))
				{
					this.OnMaKiThiChanging(value);
					this.SendPropertyChanging();
					this._MaKiThi = value;
					this.SendPropertyChanged("MaKiThi");
					this.OnMaKiThiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKiThi", DbType="NChar(10)")]
		public string TenKiThi
		{
			get
			{
				return this._TenKiThi;
			}
			set
			{
				if ((this._TenKiThi != value))
				{
					this.OnTenKiThiChanging(value);
					this.SendPropertyChanging();
					this._TenKiThi = value;
					this.SendPropertyChanged("TenKiThi");
					this.OnTenKiThiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayThi", DbType="Date")]
		public System.Nullable<System.DateTime> NgayThi
		{
			get
			{
				return this._NgayThi;
			}
			set
			{
				if ((this._NgayThi != value))
				{
					this.OnNgayThiChanging(value);
					this.SendPropertyChanging();
					this._NgayThi = value;
					this.SendPropertyChanged("NgayThi");
					this.OnNgayThiChanged();
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