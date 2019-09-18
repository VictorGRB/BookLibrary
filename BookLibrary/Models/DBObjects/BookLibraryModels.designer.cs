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

namespace BookLibrary.Models.DBObjects
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Books")]
	public partial class BookLibraryModelsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void InsertBooksCategory(BooksCategory instance);
    partial void UpdateBooksCategory(BooksCategory instance);
    partial void DeleteBooksCategory(BooksCategory instance);
    partial void InsertBorrowForm(BorrowForm instance);
    partial void UpdateBorrowForm(BorrowForm instance);
    partial void DeleteBorrowForm(BorrowForm instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertLocationInLibrary(LocationInLibrary instance);
    partial void UpdateLocationInLibrary(LocationInLibrary instance);
    partial void DeleteLocationInLibrary(LocationInLibrary instance);
    #endregion
		
		public BookLibraryModelsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BooksConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BookLibraryModelsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BookLibraryModelsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BookLibraryModelsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BookLibraryModelsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<BooksCategory> BooksCategories
		{
			get
			{
				return this.GetTable<BooksCategory>();
			}
		}
		
		public System.Data.Linq.Table<BorrowForm> BorrowForms
		{
			get
			{
				return this.GetTable<BorrowForm>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<LocationInLibrary> LocationInLibraries
		{
			get
			{
				return this.GetTable<LocationInLibrary>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Books")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IDBook;
		
		private string _Name;
		
		private string _Author;
		
		private string _Publisher;
		
		private int _NumberOfCopies;
		
		private System.Guid _IDBooksCategory;
		
		private System.Guid _IDLocationInLibrary;
		
		private string _imageUrl;
		
		private EntitySet<BorrowForm> _BorrowForms;
		
		private EntityRef<BooksCategory> _BooksCategory;
		
		private EntityRef<LocationInLibrary> _LocationInLibrary;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDBookChanging(System.Guid value);
    partial void OnIDBookChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnPublisherChanging(string value);
    partial void OnPublisherChanged();
    partial void OnNumberOfCopiesChanging(decimal value);
    partial void OnNumberOfCopiesChanged();
    partial void OnIDBooksCategoryChanging(System.Guid value);
    partial void OnIDBooksCategoryChanged();
    partial void OnIDLocationInLibraryChanging(System.Guid value);
    partial void OnIDLocationInLibraryChanged();
    partial void OnimageUrlChanging(string value);
    partial void OnimageUrlChanged();
    #endregion
		
		public Book()
		{
			this._BorrowForms = new EntitySet<BorrowForm>(new Action<BorrowForm>(this.attach_BorrowForms), new Action<BorrowForm>(this.detach_BorrowForms));
			this._BooksCategory = default(EntityRef<BooksCategory>);
			this._LocationInLibrary = default(EntityRef<LocationInLibrary>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBook", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IDBook
		{
			get
			{
				return this._IDBook;
			}
			set
			{
				if ((this._IDBook != value))
				{
					this.OnIDBookChanging(value);
					this.SendPropertyChanging();
					this._IDBook = value;
					this.SendPropertyChanged("IDBook");
					this.OnIDBookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Publisher", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Publisher
		{
			get
			{
				return this._Publisher;
			}
			set
			{
				if ((this._Publisher != value))
				{
					this.OnPublisherChanging(value);
					this.SendPropertyChanging();
					this._Publisher = value;
					this.SendPropertyChanged("Publisher");
					this.OnPublisherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumberOfCopies", DbType="Decimal(18,0) NOT NULL")]
		public int NumberOfCopies
		{
			get
			{
				return this._NumberOfCopies;
			}
			set
			{
				if ((this._NumberOfCopies != value))
				{
					this.OnNumberOfCopiesChanging(value);
					this.SendPropertyChanging();
					this._NumberOfCopies = value;
					this.SendPropertyChanged("NumberOfCopies");
					this.OnNumberOfCopiesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBooksCategory", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IDBooksCategory
		{
			get
			{
				return this._IDBooksCategory;
			}
			set
			{
				if ((this._IDBooksCategory != value))
				{
					if (this._BooksCategory.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDBooksCategoryChanging(value);
					this.SendPropertyChanging();
					this._IDBooksCategory = value;
					this.SendPropertyChanged("IDBooksCategory");
					this.OnIDBooksCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDLocationInLibrary", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IDLocationInLibrary
		{
			get
			{
				return this._IDLocationInLibrary;
			}
			set
			{
				if ((this._IDLocationInLibrary != value))
				{
					if (this._LocationInLibrary.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDLocationInLibraryChanging(value);
					this.SendPropertyChanging();
					this._IDLocationInLibrary = value;
					this.SendPropertyChanged("IDLocationInLibrary");
					this.OnIDLocationInLibraryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imageUrl", DbType="NVarChar(MAX)")]
		public string imageUrl
		{
			get
			{
				return this._imageUrl;
			}
			set
			{
				if ((this._imageUrl != value))
				{
					this.OnimageUrlChanging(value);
					this.SendPropertyChanging();
					this._imageUrl = value;
					this.SendPropertyChanged("imageUrl");
					this.OnimageUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_BorrowForm", Storage="_BorrowForms", ThisKey="IDBook", OtherKey="IDBook")]
		public EntitySet<BorrowForm> BorrowForms
		{
			get
			{
				return this._BorrowForms;
			}
			set
			{
				this._BorrowForms.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BooksCategory_Book", Storage="_BooksCategory", ThisKey="IDBooksCategory", OtherKey="IDBooksCategory", IsForeignKey=true)]
		public BooksCategory BooksCategory
		{
			get
			{
				return this._BooksCategory.Entity;
			}
			set
			{
				BooksCategory previousValue = this._BooksCategory.Entity;
				if (((previousValue != value) 
							|| (this._BooksCategory.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BooksCategory.Entity = null;
						previousValue.Books.Remove(this);
					}
					this._BooksCategory.Entity = value;
					if ((value != null))
					{
						value.Books.Add(this);
						this._IDBooksCategory = value.IDBooksCategory;
					}
					else
					{
						this._IDBooksCategory = default(System.Guid);
					}
					this.SendPropertyChanged("BooksCategory");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LocationInLibrary_Book", Storage="_LocationInLibrary", ThisKey="IDLocationInLibrary", OtherKey="IDLocationInLibrary", IsForeignKey=true)]
		public LocationInLibrary LocationInLibrary
		{
			get
			{
				return this._LocationInLibrary.Entity;
			}
			set
			{
				LocationInLibrary previousValue = this._LocationInLibrary.Entity;
				if (((previousValue != value) 
							|| (this._LocationInLibrary.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LocationInLibrary.Entity = null;
						previousValue.Books.Remove(this);
					}
					this._LocationInLibrary.Entity = value;
					if ((value != null))
					{
						value.Books.Add(this);
						this._IDLocationInLibrary = value.IDLocationInLibrary;
					}
					else
					{
						this._IDLocationInLibrary = default(System.Guid);
					}
					this.SendPropertyChanged("LocationInLibrary");
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
		
		private void attach_BorrowForms(BorrowForm entity)
		{
			this.SendPropertyChanging();
			entity.Book = this;
		}
		
		private void detach_BorrowForms(BorrowForm entity)
		{
			this.SendPropertyChanging();
			entity.Book = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BooksCategory")]
	public partial class BooksCategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IDBooksCategory;
		
		private string _Genre;
		
		private bool _ChildAppropriate;
		
		private EntitySet<Book> _Books;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDBooksCategoryChanging(System.Guid value);
    partial void OnIDBooksCategoryChanged();
    partial void OnGenreChanging(string value);
    partial void OnGenreChanged();
    partial void OnChildAppropriateChanging(bool value);
    partial void OnChildAppropriateChanged();
    #endregion
		
		public BooksCategory()
		{
			this._Books = new EntitySet<Book>(new Action<Book>(this.attach_Books), new Action<Book>(this.detach_Books));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBooksCategory", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IDBooksCategory
		{
			get
			{
				return this._IDBooksCategory;
			}
			set
			{
				if ((this._IDBooksCategory != value))
				{
					this.OnIDBooksCategoryChanging(value);
					this.SendPropertyChanging();
					this._IDBooksCategory = value;
					this.SendPropertyChanged("IDBooksCategory");
					this.OnIDBooksCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Genre
		{
			get
			{
				return this._Genre;
			}
			set
			{
				if ((this._Genre != value))
				{
					this.OnGenreChanging(value);
					this.SendPropertyChanging();
					this._Genre = value;
					this.SendPropertyChanged("Genre");
					this.OnGenreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChildAppropriate", DbType="Bit NOT NULL")]
		public bool ChildAppropriate
		{
			get
			{
				return this._ChildAppropriate;
			}
			set
			{
				if ((this._ChildAppropriate != value))
				{
					this.OnChildAppropriateChanging(value);
					this.SendPropertyChanging();
					this._ChildAppropriate = value;
					this.SendPropertyChanged("ChildAppropriate");
					this.OnChildAppropriateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BooksCategory_Book", Storage="_Books", ThisKey="IDBooksCategory", OtherKey="IDBooksCategory")]
		public EntitySet<Book> Books
		{
			get
			{
				return this._Books;
			}
			set
			{
				this._Books.Assign(value);
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
		
		private void attach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.BooksCategory = this;
		}
		
		private void detach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.BooksCategory = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BorrowForm")]
	public partial class BorrowForm : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IDBorrowForm;
		
		private System.Guid _IDBook;
		
		private System.Guid _IDCustomer;
		
		private System.DateTime _BorrowedFrom;
		
		private System.DateTime _BorrowedUntil;
		
		private bool _ReturnedOnTime;
		
		private bool _ProperConditionsReturn;
		
		private EntityRef<Book> _Book;
		
		private EntityRef<Customer> _Customer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDBorrowFormChanging(System.Guid value);
    partial void OnIDBorrowFormChanged();
    partial void OnIDBookChanging(System.Guid value);
    partial void OnIDBookChanged();
    partial void OnIDCustomerChanging(System.Guid value);
    partial void OnIDCustomerChanged();
    partial void OnBorrowedFromChanging(System.DateTime value);
    partial void OnBorrowedFromChanged();
    partial void OnBorrowedUntilChanging(System.DateTime value);
    partial void OnBorrowedUntilChanged();
    partial void OnReturnedOnTimeChanging(bool value);
    partial void OnReturnedOnTimeChanged();
    partial void OnProperConditionsReturnChanging(bool value);
    partial void OnProperConditionsReturnChanged();
    #endregion
		
		public BorrowForm()
		{
			this._Book = default(EntityRef<Book>);
			this._Customer = default(EntityRef<Customer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBorrowForm", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IDBorrowForm
		{
			get
			{
				return this._IDBorrowForm;
			}
			set
			{
				if ((this._IDBorrowForm != value))
				{
					this.OnIDBorrowFormChanging(value);
					this.SendPropertyChanging();
					this._IDBorrowForm = value;
					this.SendPropertyChanged("IDBorrowForm");
					this.OnIDBorrowFormChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBook", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IDBook
		{
			get
			{
				return this._IDBook;
			}
			set
			{
				if ((this._IDBook != value))
				{
					if (this._Book.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDBookChanging(value);
					this.SendPropertyChanging();
					this._IDBook = value;
					this.SendPropertyChanged("IDBook");
					this.OnIDBookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCustomer", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IDCustomer
		{
			get
			{
				return this._IDCustomer;
			}
			set
			{
				if ((this._IDCustomer != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDCustomerChanging(value);
					this.SendPropertyChanging();
					this._IDCustomer = value;
					this.SendPropertyChanged("IDCustomer");
					this.OnIDCustomerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BorrowedFrom", DbType="DateTime NOT NULL")]
		public System.DateTime BorrowedFrom
		{
			get
			{
				return this._BorrowedFrom;
			}
			set
			{
				if ((this._BorrowedFrom != value))
				{
					this.OnBorrowedFromChanging(value);
					this.SendPropertyChanging();
					this._BorrowedFrom = value;
					this.SendPropertyChanged("BorrowedFrom");
					this.OnBorrowedFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BorrowedUntil", DbType="DateTime NOT NULL")]
		public System.DateTime BorrowedUntil
		{
			get
			{
				return this._BorrowedUntil;
			}
			set
			{
				if ((this._BorrowedUntil != value))
				{
					this.OnBorrowedUntilChanging(value);
					this.SendPropertyChanging();
					this._BorrowedUntil = value;
					this.SendPropertyChanged("BorrowedUntil");
					this.OnBorrowedUntilChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReturnedOnTime", DbType="Bit NOT NULL")]
		public bool ReturnedOnTime
		{
			get
			{
				return this._ReturnedOnTime;
			}
			set
			{
				if ((this._ReturnedOnTime != value))
				{
					this.OnReturnedOnTimeChanging(value);
					this.SendPropertyChanging();
					this._ReturnedOnTime = value;
					this.SendPropertyChanged("ReturnedOnTime");
					this.OnReturnedOnTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProperConditionsReturn", DbType="Bit NOT NULL")]
		public bool ProperConditionsReturn
		{
			get
			{
				return this._ProperConditionsReturn;
			}
			set
			{
				if ((this._ProperConditionsReturn != value))
				{
					this.OnProperConditionsReturnChanging(value);
					this.SendPropertyChanging();
					this._ProperConditionsReturn = value;
					this.SendPropertyChanged("ProperConditionsReturn");
					this.OnProperConditionsReturnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_BorrowForm", Storage="_Book", ThisKey="IDBook", OtherKey="IDBook", IsForeignKey=true)]
		public Book Book
		{
			get
			{
				return this._Book.Entity;
			}
			set
			{
				Book previousValue = this._Book.Entity;
				if (((previousValue != value) 
							|| (this._Book.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Book.Entity = null;
						previousValue.BorrowForms.Remove(this);
					}
					this._Book.Entity = value;
					if ((value != null))
					{
						value.BorrowForms.Add(this);
						this._IDBook = value.IDBook;
					}
					else
					{
						this._IDBook = default(System.Guid);
					}
					this.SendPropertyChanged("Book");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_BorrowForm", Storage="_Customer", ThisKey="IDCustomer", OtherKey="IDCustomer", IsForeignKey=true)]
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
						previousValue.BorrowForms.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.BorrowForms.Add(this);
						this._IDCustomer = value.IDCustomer;
					}
					else
					{
						this._IDCustomer = default(System.Guid);
					}
					this.SendPropertyChanged("Customer");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IDCustomer;
		
		private string _Name;
		
		private string _EmailAddress;
		
		private string _Address;
		
		private string _PhoneNumber;
		
		private System.DateTime _CustomerSince;
		
		private int _BooksReturnedOnTime;
		
		private bool _MonthlyFeePayed;
		
		private EntitySet<BorrowForm> _BorrowForms;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDCustomerChanging(System.Guid value);
    partial void OnIDCustomerChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailAddressChanging(string value);
    partial void OnEmailAddressChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnCustomerSinceChanging(System.DateTime value);
    partial void OnCustomerSinceChanged();
    partial void OnBooksReturnedOnTimeChanging(decimal value);
    partial void OnBooksReturnedOnTimeChanged();
    partial void OnMonthlyFeePayedChanging(bool value);
    partial void OnMonthlyFeePayedChanged();
    #endregion
		
		public Customer()
		{
			this._BorrowForms = new EntitySet<BorrowForm>(new Action<BorrowForm>(this.attach_BorrowForms), new Action<BorrowForm>(this.detach_BorrowForms));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCustomer", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IDCustomer
		{
			get
			{
				return this._IDCustomer;
			}
			set
			{
				if ((this._IDCustomer != value))
				{
					this.OnIDCustomerChanging(value);
					this.SendPropertyChanging();
					this._IDCustomer = value;
					this.SendPropertyChanged("IDCustomer");
					this.OnIDCustomerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailAddress", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EmailAddress
		{
			get
			{
				return this._EmailAddress;
			}
			set
			{
				if ((this._EmailAddress != value))
				{
					this.OnEmailAddressChanging(value);
					this.SendPropertyChanging();
					this._EmailAddress = value;
					this.SendPropertyChanged("EmailAddress");
					this.OnEmailAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerSince", DbType="DateTime NOT NULL")]
		public System.DateTime CustomerSince
		{
			get
			{
				return this._CustomerSince;
			}
			set
			{
				if ((this._CustomerSince != value))
				{
					this.OnCustomerSinceChanging(value);
					this.SendPropertyChanging();
					this._CustomerSince = value;
					this.SendPropertyChanged("CustomerSince");
					this.OnCustomerSinceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BooksReturnedOnTime", DbType="Decimal(18,0) NOT NULL")]
		public int BooksReturnedOnTime
		{
			get
			{
				return this._BooksReturnedOnTime;
			}
			set
			{
				if ((this._BooksReturnedOnTime != value))
				{
					this.OnBooksReturnedOnTimeChanging(value);
					this.SendPropertyChanging();
					this._BooksReturnedOnTime = value;
					this.SendPropertyChanged("BooksReturnedOnTime");
					this.OnBooksReturnedOnTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MonthlyFeePayed", DbType="Bit NOT NULL")]
		public bool MonthlyFeePayed
		{
			get
			{
				return this._MonthlyFeePayed;
			}
			set
			{
				if ((this._MonthlyFeePayed != value))
				{
					this.OnMonthlyFeePayedChanging(value);
					this.SendPropertyChanging();
					this._MonthlyFeePayed = value;
					this.SendPropertyChanged("MonthlyFeePayed");
					this.OnMonthlyFeePayedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_BorrowForm", Storage="_BorrowForms", ThisKey="IDCustomer", OtherKey="IDCustomer")]
		public EntitySet<BorrowForm> BorrowForms
		{
			get
			{
				return this._BorrowForms;
			}
			set
			{
				this._BorrowForms.Assign(value);
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
		
		private void attach_BorrowForms(BorrowForm entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_BorrowForms(BorrowForm entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LocationInLibrary")]
	public partial class LocationInLibrary : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IDLocationInLibrary;
		
		private string _Name;
		
		private System.Nullable<int> _Floor;
		
		private System.Nullable<int> _Sector;
		
		private string _Shelf;
		
		private EntitySet<Book> _Books;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDLocationInLibraryChanging(System.Guid value);
    partial void OnIDLocationInLibraryChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnFloorChanging(System.Nullable<int> value);
    partial void OnFloorChanged();
    partial void OnSectorChanging(System.Nullable<int> value);
    partial void OnSectorChanged();
    partial void OnShelfChanging(string value);
    partial void OnShelfChanged();
    #endregion
		
		public LocationInLibrary()
		{
			this._Books = new EntitySet<Book>(new Action<Book>(this.attach_Books), new Action<Book>(this.detach_Books));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDLocationInLibrary", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IDLocationInLibrary
		{
			get
			{
				return this._IDLocationInLibrary;
			}
			set
			{
				if ((this._IDLocationInLibrary != value))
				{
					this.OnIDLocationInLibraryChanging(value);
					this.SendPropertyChanging();
					this._IDLocationInLibrary = value;
					this.SendPropertyChanged("IDLocationInLibrary");
					this.OnIDLocationInLibraryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Floor", DbType="Int")]
		public System.Nullable<int> Floor
		{
			get
			{
				return this._Floor;
			}
			set
			{
				if ((this._Floor != value))
				{
					this.OnFloorChanging(value);
					this.SendPropertyChanging();
					this._Floor = value;
					this.SendPropertyChanged("Floor");
					this.OnFloorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sector", DbType="Int")]
		public System.Nullable<int> Sector
		{
			get
			{
				return this._Sector;
			}
			set
			{
				if ((this._Sector != value))
				{
					this.OnSectorChanging(value);
					this.SendPropertyChanging();
					this._Sector = value;
					this.SendPropertyChanged("Sector");
					this.OnSectorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Shelf", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Shelf
		{
			get
			{
				return this._Shelf;
			}
			set
			{
				if ((this._Shelf != value))
				{
					this.OnShelfChanging(value);
					this.SendPropertyChanging();
					this._Shelf = value;
					this.SendPropertyChanged("Shelf");
					this.OnShelfChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LocationInLibrary_Book", Storage="_Books", ThisKey="IDLocationInLibrary", OtherKey="IDLocationInLibrary")]
		public EntitySet<Book> Books
		{
			get
			{
				return this._Books;
			}
			set
			{
				this._Books.Assign(value);
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
		
		private void attach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.LocationInLibrary = this;
		}
		
		private void detach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.LocationInLibrary = null;
		}
	}
}
#pragma warning restore 1591
