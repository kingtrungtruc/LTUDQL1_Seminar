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
	public partial class MaDeVaKhoiTrongKiThiDTO_HTDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMaDeVaKhoiTrongKiThi(MaDeVaKhoiTrongKiThi instance);
    partial void UpdateMaDeVaKhoiTrongKiThi(MaDeVaKhoiTrongKiThi instance);
    partial void DeleteMaDeVaKhoiTrongKiThi(MaDeVaKhoiTrongKiThi instance);
    #endregion
		
		public MaDeVaKhoiTrongKiThiDTO_HTDataContext() : 
				base(global::DTO.Properties.Settings.Default.CSDLConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MaDeVaKhoiTrongKiThiDTO_HTDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MaDeVaKhoiTrongKiThiDTO_HTDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MaDeVaKhoiTrongKiThiDTO_HTDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MaDeVaKhoiTrongKiThiDTO_HTDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MaDeVaKhoiTrongKiThi> MaDeVaKhoiTrongKiThis
		{
			get
			{
				return this.GetTable<MaDeVaKhoiTrongKiThi>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MaDeVaKhoiTrongKiThi")]
	public partial class MaDeVaKhoiTrongKiThi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKiThi;
		
		private string _MaDe;
		
		private System.Nullable<int> _MaKhoi;
		
		private string _MaDeVaKhoiTrongKiThi1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKiThiChanging(string value);
    partial void OnMaKiThiChanged();
    partial void OnMaDeChanging(string value);
    partial void OnMaDeChanged();
    partial void OnMaKhoiChanging(System.Nullable<int> value);
    partial void OnMaKhoiChanged();
    partial void OnMaDeVaKhoiTrongKiThi1Changing(string value);
    partial void OnMaDeVaKhoiTrongKiThi1Changed();
    #endregion
		
		public MaDeVaKhoiTrongKiThi()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKiThi", DbType="NChar(10)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDe", DbType="NChar(10)")]
		public string MaDe
		{
			get
			{
				return this._MaDe;
			}
			set
			{
				if ((this._MaDe != value))
				{
					this.OnMaDeChanging(value);
					this.SendPropertyChanging();
					this._MaDe = value;
					this.SendPropertyChanged("MaDe");
					this.OnMaDeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhoi", DbType="Int")]
		public System.Nullable<int> MaKhoi
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="MaDeVaKhoiTrongKiThi", Storage="_MaDeVaKhoiTrongKiThi1", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaDeVaKhoiTrongKiThi1
		{
			get
			{
				return this._MaDeVaKhoiTrongKiThi1;
			}
			set
			{
				if ((this._MaDeVaKhoiTrongKiThi1 != value))
				{
					this.OnMaDeVaKhoiTrongKiThi1Changing(value);
					this.SendPropertyChanging();
					this._MaDeVaKhoiTrongKiThi1 = value;
					this.SendPropertyChanged("MaDeVaKhoiTrongKiThi1");
					this.OnMaDeVaKhoiTrongKiThi1Changed();
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