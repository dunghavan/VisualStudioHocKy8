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

namespace DemoWebAPI2.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DB_WEBAPI")]
	public partial class LinQClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblCategory(tblCategory instance);
    partial void UpdatetblCategory(tblCategory instance);
    partial void DeletetblCategory(tblCategory instance);
    partial void InserttblProduct(tblProduct instance);
    partial void UpdatetblProduct(tblProduct instance);
    partial void DeletetblProduct(tblProduct instance);
    #endregion
		
		public LinQClassDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DB_WEBAPIConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinQClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinQClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinQClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinQClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblCategory> tblCategories
		{
			get
			{
				return this.GetTable<tblCategory>();
			}
		}
		
		public System.Data.Linq.Table<tblProduct> tblProducts
		{
			get
			{
				return this.GetTable<tblProduct>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblCategories")]
	public partial class tblCategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _category;
		
		private EntitySet<tblProduct> _tblProducts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OncategoryChanging(string value);
    partial void OncategoryChanged();
    #endregion
		
		public tblCategory()
		{
			this._tblProducts = new EntitySet<tblProduct>(new Action<tblProduct>(this.attach_tblProducts), new Action<tblProduct>(this.detach_tblProducts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category", DbType="NChar(20)")]
		public string category
		{
			get
			{
				return this._category;
			}
			set
			{
				if ((this._category != value))
				{
					this.OncategoryChanging(value);
					this.SendPropertyChanging();
					this._category = value;
					this.SendPropertyChanged("category");
					this.OncategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblCategory_tblProduct", Storage="_tblProducts", ThisKey="id", OtherKey="catID")]
		public EntitySet<tblProduct> tblProducts
		{
			get
			{
				return this._tblProducts;
			}
			set
			{
				this._tblProducts.Assign(value);
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
		
		private void attach_tblProducts(tblProduct entity)
		{
			this.SendPropertyChanging();
			entity.tblCategory = this;
		}
		
		private void detach_tblProducts(tblProduct entity)
		{
			this.SendPropertyChanging();
			entity.tblCategory = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblProducts")]
	public partial class tblProduct : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _description;
		
		private decimal _price;
		
		private System.Nullable<int> _unitInStock;
		
		private System.Nullable<int> _catID;
		
		private EntityRef<tblCategory> _tblCategory;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    partial void OnunitInStockChanging(System.Nullable<int> value);
    partial void OnunitInStockChanged();
    partial void OncatIDChanging(System.Nullable<int> value);
    partial void OncatIDChanged();
    #endregion
		
		public tblProduct()
		{
			this._tblCategory = default(EntityRef<tblCategory>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(10,2) NOT NULL")]
		public decimal price
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_unitInStock", DbType="Int")]
		public System.Nullable<int> unitInStock
		{
			get
			{
				return this._unitInStock;
			}
			set
			{
				if ((this._unitInStock != value))
				{
					this.OnunitInStockChanging(value);
					this.SendPropertyChanging();
					this._unitInStock = value;
					this.SendPropertyChanged("unitInStock");
					this.OnunitInStockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_catID", DbType="Int")]
		public System.Nullable<int> catID
		{
			get
			{
				return this._catID;
			}
			set
			{
				if ((this._catID != value))
				{
					if (this._tblCategory.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncatIDChanging(value);
					this.SendPropertyChanging();
					this._catID = value;
					this.SendPropertyChanged("catID");
					this.OncatIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblCategory_tblProduct", Storage="_tblCategory", ThisKey="catID", OtherKey="id", IsForeignKey=true)]
		public tblCategory tblCategory
		{
			get
			{
				return this._tblCategory.Entity;
			}
			set
			{
				tblCategory previousValue = this._tblCategory.Entity;
				if (((previousValue != value) 
							|| (this._tblCategory.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblCategory.Entity = null;
						previousValue.tblProducts.Remove(this);
					}
					this._tblCategory.Entity = value;
					if ((value != null))
					{
						value.tblProducts.Add(this);
						this._catID = value.id;
					}
					else
					{
						this._catID = default(Nullable<int>);
					}
					this.SendPropertyChanged("tblCategory");
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
