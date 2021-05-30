﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryShop
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Shop")]
	public partial class ShopDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEvents(Events instance);
    partial void UpdateEvents(Events instance);
    partial void DeleteEvents(Events instance);
    partial void InsertCustomers(Customers instance);
    partial void UpdateCustomers(Customers instance);
    partial void DeleteCustomers(Customers instance);
    partial void InsertProducts(Products instance);
    partial void UpdateProducts(Products instance);
    partial void DeleteProducts(Products instance);
    #endregion
		
		public ShopDataContext() : 
				base(global::LibraryShop.Properties.Settings.Default.ShopConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ShopDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShopDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShopDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ShopDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Events> Events
		{
			get
			{
				return this.GetTable<Events>();
			}
		}
		
		public System.Data.Linq.Table<Customers> Customers
		{
			get
			{
				return this.GetTable<Customers>();
			}
		}
		
		public System.Data.Linq.Table<Products> Products
		{
			get
			{
				return this.GetTable<Products>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Events")]
	public partial class Events : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<System.DateTime> _date;
		
		private System.Nullable<int> _product_id;
		
		private System.Nullable<int> _customer_id;
		
		private EntityRef<Customers> _Customers;
		
		private EntityRef<Products> _Products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OndateChanging(System.Nullable<System.DateTime> value);
    partial void OndateChanged();
    partial void Onproduct_idChanging(System.Nullable<int> value);
    partial void Onproduct_idChanged();
    partial void Oncustomer_idChanging(System.Nullable<int> value);
    partial void Oncustomer_idChanged();
    #endregion
		
		public Events()
		{
			this._Customers = default(EntityRef<Customers>);
			this._Products = default(EntityRef<Products>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_product_id", DbType="Int")]
		public System.Nullable<int> product_id
		{
			get
			{
				return this._product_id;
			}
			set
			{
				if ((this._product_id != value))
				{
					if (this._Products.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onproduct_idChanging(value);
					this.SendPropertyChanging();
					this._product_id = value;
					this.SendPropertyChanged("product_id");
					this.Onproduct_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customer_id", DbType="Int")]
		public System.Nullable<int> customer_id
		{
			get
			{
				return this._customer_id;
			}
			set
			{
				if ((this._customer_id != value))
				{
					if (this._Customers.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oncustomer_idChanging(value);
					this.SendPropertyChanging();
					this._customer_id = value;
					this.SendPropertyChanged("customer_id");
					this.Oncustomer_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customers_Events", Storage="_Customers", ThisKey="customer_id", OtherKey="id", IsForeignKey=true)]
		public Customers Customers
		{
			get
			{
				return this._Customers.Entity;
			}
			set
			{
				Customers previousValue = this._Customers.Entity;
				if (((previousValue != value) 
							|| (this._Customers.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customers.Entity = null;
						previousValue.Events.Remove(this);
					}
					this._Customers.Entity = value;
					if ((value != null))
					{
						value.Events.Add(this);
						this._customer_id = value.id;
					}
					else
					{
						this._customer_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Customers");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Products_Events", Storage="_Products", ThisKey="product_id", OtherKey="id", IsForeignKey=true)]
		public Products Products
		{
			get
			{
				return this._Products.Entity;
			}
			set
			{
				Products previousValue = this._Products.Entity;
				if (((previousValue != value) 
							|| (this._Products.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Products.Entity = null;
						previousValue.Events.Remove(this);
					}
					this._Products.Entity = value;
					if ((value != null))
					{
						value.Events.Add(this);
						this._product_id = value.id;
					}
					else
					{
						this._product_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Products");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customers")]
	public partial class Customers : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private EntitySet<Events> _Events;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public Customers()
		{
			this._Events = new EntitySet<Events>(new Action<Events>(this.attach_Events), new Action<Events>(this.detach_Events));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="Char(30)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customers_Events", Storage="_Events", ThisKey="id", OtherKey="customer_id")]
		public EntitySet<Events> Events
		{
			get
			{
				return this._Events;
			}
			set
			{
				this._Events.Assign(value);
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
		
		private void attach_Events(Events entity)
		{
			this.SendPropertyChanging();
			entity.Customers = this;
		}
		
		private void detach_Events(Events entity)
		{
			this.SendPropertyChanging();
			entity.Customers = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Products : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private System.Nullable<bool> _isAvaliable;
		
		private EntitySet<Events> _Events;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnisAvaliableChanging(System.Nullable<bool> value);
    partial void OnisAvaliableChanged();
    #endregion
		
		public Products()
		{
			this._Events = new EntitySet<Events>(new Action<Events>(this.attach_Events), new Action<Events>(this.detach_Events));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="Char(30)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isAvaliable", DbType="bool")]
		public System.Nullable<bool> isAvaliable
		{
			get
			{
				return this._isAvaliable;
			}
			set
			{
				if ((this._isAvaliable != value))
				{
					this.OnisAvaliableChanging(value);
					this.SendPropertyChanging();
					this._isAvaliable = value;
					this.SendPropertyChanged("isAvaliable");
					this.OnisAvaliableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Products_Events", Storage="_Events", ThisKey="id", OtherKey="product_id")]
		public EntitySet<Events> Events
		{
			get
			{
				return this._Events;
			}
			set
			{
				this._Events.Assign(value);
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
		
		private void attach_Events(Events entity)
		{
			this.SendPropertyChanging();
			entity.Products = this;
		}
		
		private void detach_Events(Events entity)
		{
			this.SendPropertyChanging();
			entity.Products = null;
		}
	}
}
#pragma warning restore 1591
