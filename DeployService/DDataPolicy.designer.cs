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

namespace DeployService
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DDATAPOLICY")]
	public partial class DDataPolicyDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertRefEmployee(RefEmployee instance);
    partial void UpdateRefEmployee(RefEmployee instance);
    partial void DeleteRefEmployee(RefEmployee instance);
    partial void InsertRefMapAction(RefMapAction instance);
    partial void UpdateRefMapAction(RefMapAction instance);
    partial void DeleteRefMapAction(RefMapAction instance);
    partial void InsertRefObjectType(RefObjectType instance);
    partial void UpdateRefObjectType(RefObjectType instance);
    partial void DeleteRefObjectType(RefObjectType instance);
    partial void InsertRefPriorityCalculated(RefPriorityCalculated instance);
    partial void UpdateRefPriorityCalculated(RefPriorityCalculated instance);
    partial void DeleteRefPriorityCalculated(RefPriorityCalculated instance);
    #endregion
		
		public DDataPolicyDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DDATAPOLICYConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DDataPolicyDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DDataPolicyDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DDataPolicyDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DDataPolicyDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<RefEmployee> RefEmployees
		{
			get
			{
				return this.GetTable<RefEmployee>();
			}
		}
		
		public System.Data.Linq.Table<RefMapAction> RefMapActions
		{
			get
			{
				return this.GetTable<RefMapAction>();
			}
		}
		
		public System.Data.Linq.Table<RefObjectType> RefObjectTypes
		{
			get
			{
				return this.GetTable<RefObjectType>();
			}
		}
		
		public System.Data.Linq.Table<RefPriorityCalculated> RefPriorityCalculateds
		{
			get
			{
				return this.GetTable<RefPriorityCalculated>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.REF_EMPLOYEE")]
	public partial class RefEmployee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _EMPLOYEE_ID;
		
		private string _FIRST_NAME;
		
		private string _LAST_NAME;
		
		private string _PHONE;
		
		private string _EMAIL;
		
		private string _TITLE;
		
		private string _DIVISION;
		
		private string _DEPARTMENT;
		
		private string _TEAM;
		
		private string _VINYL_USERNAME;
		
		private string _CREATED_BY;
		
		private System.Nullable<System.DateTime> _CREATED_ON;
		
		private string _MODIFIED_BY;
		
		private System.Nullable<System.DateTime> _MODIFIED_ON;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEMPLOYEE_IDChanging(string value);
    partial void OnEMPLOYEE_IDChanged();
    partial void OnFIRST_NAMEChanging(string value);
    partial void OnFIRST_NAMEChanged();
    partial void OnLAST_NAMEChanging(string value);
    partial void OnLAST_NAMEChanged();
    partial void OnPHONEChanging(string value);
    partial void OnPHONEChanged();
    partial void OnEMAILChanging(string value);
    partial void OnEMAILChanged();
    partial void OnTITLEChanging(string value);
    partial void OnTITLEChanged();
    partial void OnDIVISIONChanging(string value);
    partial void OnDIVISIONChanged();
    partial void OnDEPARTMENTChanging(string value);
    partial void OnDEPARTMENTChanged();
    partial void OnTEAMChanging(string value);
    partial void OnTEAMChanged();
    partial void OnVINYL_USERNAMEChanging(string value);
    partial void OnVINYL_USERNAMEChanged();
    partial void OnCREATED_BYChanging(string value);
    partial void OnCREATED_BYChanged();
    partial void OnCREATED_ONChanging(System.Nullable<System.DateTime> value);
    partial void OnCREATED_ONChanged();
    partial void OnMODIFIED_BYChanging(string value);
    partial void OnMODIFIED_BYChanged();
    partial void OnMODIFIED_ONChanging(System.Nullable<System.DateTime> value);
    partial void OnMODIFIED_ONChanged();
    #endregion
		
		public RefEmployee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMPLOYEE_ID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string EMPLOYEE_ID
		{
			get
			{
				return this._EMPLOYEE_ID;
			}
			set
			{
				if ((this._EMPLOYEE_ID != value))
				{
					this.OnEMPLOYEE_IDChanging(value);
					this.SendPropertyChanging();
					this._EMPLOYEE_ID = value;
					this.SendPropertyChanged("EMPLOYEE_ID");
					this.OnEMPLOYEE_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FIRST_NAME", DbType="NVarChar(160)")]
		public string FIRST_NAME
		{
			get
			{
				return this._FIRST_NAME;
			}
			set
			{
				if ((this._FIRST_NAME != value))
				{
					this.OnFIRST_NAMEChanging(value);
					this.SendPropertyChanging();
					this._FIRST_NAME = value;
					this.SendPropertyChanged("FIRST_NAME");
					this.OnFIRST_NAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LAST_NAME", DbType="NVarChar(240)")]
		public string LAST_NAME
		{
			get
			{
				return this._LAST_NAME;
			}
			set
			{
				if ((this._LAST_NAME != value))
				{
					this.OnLAST_NAMEChanging(value);
					this.SendPropertyChanging();
					this._LAST_NAME = value;
					this.SendPropertyChanged("LAST_NAME");
					this.OnLAST_NAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PHONE", DbType="NVarChar(128)")]
		public string PHONE
		{
			get
			{
				return this._PHONE;
			}
			set
			{
				if ((this._PHONE != value))
				{
					this.OnPHONEChanging(value);
					this.SendPropertyChanging();
					this._PHONE = value;
					this.SendPropertyChanged("PHONE");
					this.OnPHONEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMAIL", DbType="NVarChar(964)")]
		public string EMAIL
		{
			get
			{
				return this._EMAIL;
			}
			set
			{
				if ((this._EMAIL != value))
				{
					this.OnEMAILChanging(value);
					this.SendPropertyChanging();
					this._EMAIL = value;
					this.SendPropertyChanged("EMAIL");
					this.OnEMAILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TITLE", DbType="NVarChar(480)")]
		public string TITLE
		{
			get
			{
				return this._TITLE;
			}
			set
			{
				if ((this._TITLE != value))
				{
					this.OnTITLEChanging(value);
					this.SendPropertyChanging();
					this._TITLE = value;
					this.SendPropertyChanged("TITLE");
					this.OnTITLEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIVISION", DbType="NVarChar(160)")]
		public string DIVISION
		{
			get
			{
				return this._DIVISION;
			}
			set
			{
				if ((this._DIVISION != value))
				{
					this.OnDIVISIONChanging(value);
					this.SendPropertyChanging();
					this._DIVISION = value;
					this.SendPropertyChanged("DIVISION");
					this.OnDIVISIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DEPARTMENT", DbType="NVarChar(480)")]
		public string DEPARTMENT
		{
			get
			{
				return this._DEPARTMENT;
			}
			set
			{
				if ((this._DEPARTMENT != value))
				{
					this.OnDEPARTMENTChanging(value);
					this.SendPropertyChanging();
					this._DEPARTMENT = value;
					this.SendPropertyChanged("DEPARTMENT");
					this.OnDEPARTMENTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TEAM", DbType="NVarChar(200)")]
		public string TEAM
		{
			get
			{
				return this._TEAM;
			}
			set
			{
				if ((this._TEAM != value))
				{
					this.OnTEAMChanging(value);
					this.SendPropertyChanging();
					this._TEAM = value;
					this.SendPropertyChanged("TEAM");
					this.OnTEAMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VINYL_USERNAME", DbType="NVarChar(50)")]
		public string VINYL_USERNAME
		{
			get
			{
				return this._VINYL_USERNAME;
			}
			set
			{
				if ((this._VINYL_USERNAME != value))
				{
					this.OnVINYL_USERNAMEChanging(value);
					this.SendPropertyChanging();
					this._VINYL_USERNAME = value;
					this.SendPropertyChanged("VINYL_USERNAME");
					this.OnVINYL_USERNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATED_BY", DbType="NVarChar(50)")]
		public string CREATED_BY
		{
			get
			{
				return this._CREATED_BY;
			}
			set
			{
				if ((this._CREATED_BY != value))
				{
					this.OnCREATED_BYChanging(value);
					this.SendPropertyChanging();
					this._CREATED_BY = value;
					this.SendPropertyChanged("CREATED_BY");
					this.OnCREATED_BYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATED_ON", DbType="DateTime")]
		public System.Nullable<System.DateTime> CREATED_ON
		{
			get
			{
				return this._CREATED_ON;
			}
			set
			{
				if ((this._CREATED_ON != value))
				{
					this.OnCREATED_ONChanging(value);
					this.SendPropertyChanging();
					this._CREATED_ON = value;
					this.SendPropertyChanged("CREATED_ON");
					this.OnCREATED_ONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MODIFIED_BY", DbType="NVarChar(50)")]
		public string MODIFIED_BY
		{
			get
			{
				return this._MODIFIED_BY;
			}
			set
			{
				if ((this._MODIFIED_BY != value))
				{
					this.OnMODIFIED_BYChanging(value);
					this.SendPropertyChanging();
					this._MODIFIED_BY = value;
					this.SendPropertyChanged("MODIFIED_BY");
					this.OnMODIFIED_BYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MODIFIED_ON", DbType="DateTime")]
		public System.Nullable<System.DateTime> MODIFIED_ON
		{
			get
			{
				return this._MODIFIED_ON;
			}
			set
			{
				if ((this._MODIFIED_ON != value))
				{
					this.OnMODIFIED_ONChanging(value);
					this.SendPropertyChanging();
					this._MODIFIED_ON = value;
					this.SendPropertyChanged("MODIFIED_ON");
					this.OnMODIFIED_ONChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.REF_MAP_ACTION")]
	public partial class RefMapAction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MAP_ACTION;
		
		private System.Nullable<short> _SOURCE_TABLE;
		
		private System.Nullable<short> _SOURCE_FIELD;
		
		private System.Nullable<short> _DEFAULT;
		
		private System.Nullable<short> _MAPPING_RULE;
		
		private string _CREATED_BY;
		
		private System.Nullable<System.DateTime> _CREATED_ON;
		
		private string _MODIFIED_BY;
		
		private System.Nullable<System.DateTime> _MODIFIED_ON;
		
		private bool _LINEAGE_REQUIRED;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAP_ACTIONChanging(string value);
    partial void OnMAP_ACTIONChanged();
    partial void OnSOURCE_TABLEChanging(System.Nullable<short> value);
    partial void OnSOURCE_TABLEChanged();
    partial void OnSOURCE_FIELDChanging(System.Nullable<short> value);
    partial void OnSOURCE_FIELDChanged();
    partial void OnDEFAULTChanging(System.Nullable<short> value);
    partial void OnDEFAULTChanged();
    partial void OnMAPPING_RULEChanging(System.Nullable<short> value);
    partial void OnMAPPING_RULEChanged();
    partial void OnCREATED_BYChanging(string value);
    partial void OnCREATED_BYChanged();
    partial void OnCREATED_ONChanging(System.Nullable<System.DateTime> value);
    partial void OnCREATED_ONChanged();
    partial void OnMODIFIED_BYChanging(string value);
    partial void OnMODIFIED_BYChanged();
    partial void OnMODIFIED_ONChanging(System.Nullable<System.DateTime> value);
    partial void OnMODIFIED_ONChanged();
    partial void OnLINEAGE_REQUIREDChanging(bool value);
    partial void OnLINEAGE_REQUIREDChanged();
    #endregion
		
		public RefMapAction()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAP_ACTION", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MAP_ACTION
		{
			get
			{
				return this._MAP_ACTION;
			}
			set
			{
				if ((this._MAP_ACTION != value))
				{
					this.OnMAP_ACTIONChanging(value);
					this.SendPropertyChanging();
					this._MAP_ACTION = value;
					this.SendPropertyChanged("MAP_ACTION");
					this.OnMAP_ACTIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOURCE_TABLE", DbType="SmallInt")]
		public System.Nullable<short> SOURCE_TABLE
		{
			get
			{
				return this._SOURCE_TABLE;
			}
			set
			{
				if ((this._SOURCE_TABLE != value))
				{
					this.OnSOURCE_TABLEChanging(value);
					this.SendPropertyChanging();
					this._SOURCE_TABLE = value;
					this.SendPropertyChanged("SOURCE_TABLE");
					this.OnSOURCE_TABLEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOURCE_FIELD", DbType="SmallInt")]
		public System.Nullable<short> SOURCE_FIELD
		{
			get
			{
				return this._SOURCE_FIELD;
			}
			set
			{
				if ((this._SOURCE_FIELD != value))
				{
					this.OnSOURCE_FIELDChanging(value);
					this.SendPropertyChanging();
					this._SOURCE_FIELD = value;
					this.SendPropertyChanged("SOURCE_FIELD");
					this.OnSOURCE_FIELDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[DEFAULT]", Storage="_DEFAULT", DbType="SmallInt")]
		public System.Nullable<short> DEFAULT
		{
			get
			{
				return this._DEFAULT;
			}
			set
			{
				if ((this._DEFAULT != value))
				{
					this.OnDEFAULTChanging(value);
					this.SendPropertyChanging();
					this._DEFAULT = value;
					this.SendPropertyChanged("DEFAULT");
					this.OnDEFAULTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPPING_RULE", DbType="SmallInt")]
		public System.Nullable<short> MAPPING_RULE
		{
			get
			{
				return this._MAPPING_RULE;
			}
			set
			{
				if ((this._MAPPING_RULE != value))
				{
					this.OnMAPPING_RULEChanging(value);
					this.SendPropertyChanging();
					this._MAPPING_RULE = value;
					this.SendPropertyChanged("MAPPING_RULE");
					this.OnMAPPING_RULEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATED_BY", DbType="NVarChar(50)")]
		public string CREATED_BY
		{
			get
			{
				return this._CREATED_BY;
			}
			set
			{
				if ((this._CREATED_BY != value))
				{
					this.OnCREATED_BYChanging(value);
					this.SendPropertyChanging();
					this._CREATED_BY = value;
					this.SendPropertyChanged("CREATED_BY");
					this.OnCREATED_BYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATED_ON", DbType="DateTime")]
		public System.Nullable<System.DateTime> CREATED_ON
		{
			get
			{
				return this._CREATED_ON;
			}
			set
			{
				if ((this._CREATED_ON != value))
				{
					this.OnCREATED_ONChanging(value);
					this.SendPropertyChanging();
					this._CREATED_ON = value;
					this.SendPropertyChanged("CREATED_ON");
					this.OnCREATED_ONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MODIFIED_BY", DbType="NVarChar(50)")]
		public string MODIFIED_BY
		{
			get
			{
				return this._MODIFIED_BY;
			}
			set
			{
				if ((this._MODIFIED_BY != value))
				{
					this.OnMODIFIED_BYChanging(value);
					this.SendPropertyChanging();
					this._MODIFIED_BY = value;
					this.SendPropertyChanged("MODIFIED_BY");
					this.OnMODIFIED_BYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MODIFIED_ON", DbType="DateTime")]
		public System.Nullable<System.DateTime> MODIFIED_ON
		{
			get
			{
				return this._MODIFIED_ON;
			}
			set
			{
				if ((this._MODIFIED_ON != value))
				{
					this.OnMODIFIED_ONChanging(value);
					this.SendPropertyChanging();
					this._MODIFIED_ON = value;
					this.SendPropertyChanged("MODIFIED_ON");
					this.OnMODIFIED_ONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LINEAGE_REQUIRED", DbType="Bit NOT NULL")]
		public bool LINEAGE_REQUIRED
		{
			get
			{
				return this._LINEAGE_REQUIRED;
			}
			set
			{
				if ((this._LINEAGE_REQUIRED != value))
				{
					this.OnLINEAGE_REQUIREDChanging(value);
					this.SendPropertyChanging();
					this._LINEAGE_REQUIRED = value;
					this.SendPropertyChanged("LINEAGE_REQUIRED");
					this.OnLINEAGE_REQUIREDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.REF_OBJECT_TYPE")]
	public partial class RefObjectType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OBJECT_TYPE_ID;
		
		private string _OBJECT_TYPE;
		
		private string _URL;
		
		private string _CREATED_BY;
		
		private System.Nullable<System.DateTime> _CREATED_ON;
		
		private string _MODIFIED_BY;
		
		private System.Nullable<System.DateTime> _MODIFIED_ON;
		
		private bool _BUSINESS;
		
		private bool _TECHNICAL;
		
		private System.Nullable<System.Guid> _PAGE_ID;
		
		private int _SORT_ORDER;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOBJECT_TYPE_IDChanging(int value);
    partial void OnOBJECT_TYPE_IDChanged();
    partial void OnOBJECT_TYPEChanging(string value);
    partial void OnOBJECT_TYPEChanged();
    partial void OnURLChanging(string value);
    partial void OnURLChanged();
    partial void OnCREATED_BYChanging(string value);
    partial void OnCREATED_BYChanged();
    partial void OnCREATED_ONChanging(System.Nullable<System.DateTime> value);
    partial void OnCREATED_ONChanged();
    partial void OnMODIFIED_BYChanging(string value);
    partial void OnMODIFIED_BYChanged();
    partial void OnMODIFIED_ONChanging(System.Nullable<System.DateTime> value);
    partial void OnMODIFIED_ONChanged();
    partial void OnBUSINESSChanging(bool value);
    partial void OnBUSINESSChanged();
    partial void OnTECHNICALChanging(bool value);
    partial void OnTECHNICALChanged();
    partial void OnPAGE_IDChanging(System.Nullable<System.Guid> value);
    partial void OnPAGE_IDChanged();
    partial void OnSORT_ORDERChanging(int value);
    partial void OnSORT_ORDERChanged();
    #endregion
		
		public RefObjectType()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OBJECT_TYPE_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int OBJECT_TYPE_ID
		{
			get
			{
				return this._OBJECT_TYPE_ID;
			}
			set
			{
				if ((this._OBJECT_TYPE_ID != value))
				{
					this.OnOBJECT_TYPE_IDChanging(value);
					this.SendPropertyChanging();
					this._OBJECT_TYPE_ID = value;
					this.SendPropertyChanged("OBJECT_TYPE_ID");
					this.OnOBJECT_TYPE_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OBJECT_TYPE", DbType="NVarChar(150)")]
		public string OBJECT_TYPE
		{
			get
			{
				return this._OBJECT_TYPE;
			}
			set
			{
				if ((this._OBJECT_TYPE != value))
				{
					this.OnOBJECT_TYPEChanging(value);
					this.SendPropertyChanging();
					this._OBJECT_TYPE = value;
					this.SendPropertyChanged("OBJECT_TYPE");
					this.OnOBJECT_TYPEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URL", DbType="NVarChar(500)")]
		public string URL
		{
			get
			{
				return this._URL;
			}
			set
			{
				if ((this._URL != value))
				{
					this.OnURLChanging(value);
					this.SendPropertyChanging();
					this._URL = value;
					this.SendPropertyChanged("URL");
					this.OnURLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATED_BY", DbType="NVarChar(50)")]
		public string CREATED_BY
		{
			get
			{
				return this._CREATED_BY;
			}
			set
			{
				if ((this._CREATED_BY != value))
				{
					this.OnCREATED_BYChanging(value);
					this.SendPropertyChanging();
					this._CREATED_BY = value;
					this.SendPropertyChanged("CREATED_BY");
					this.OnCREATED_BYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATED_ON", DbType="DateTime")]
		public System.Nullable<System.DateTime> CREATED_ON
		{
			get
			{
				return this._CREATED_ON;
			}
			set
			{
				if ((this._CREATED_ON != value))
				{
					this.OnCREATED_ONChanging(value);
					this.SendPropertyChanging();
					this._CREATED_ON = value;
					this.SendPropertyChanged("CREATED_ON");
					this.OnCREATED_ONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MODIFIED_BY", DbType="NVarChar(50)")]
		public string MODIFIED_BY
		{
			get
			{
				return this._MODIFIED_BY;
			}
			set
			{
				if ((this._MODIFIED_BY != value))
				{
					this.OnMODIFIED_BYChanging(value);
					this.SendPropertyChanging();
					this._MODIFIED_BY = value;
					this.SendPropertyChanged("MODIFIED_BY");
					this.OnMODIFIED_BYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MODIFIED_ON", DbType="DateTime")]
		public System.Nullable<System.DateTime> MODIFIED_ON
		{
			get
			{
				return this._MODIFIED_ON;
			}
			set
			{
				if ((this._MODIFIED_ON != value))
				{
					this.OnMODIFIED_ONChanging(value);
					this.SendPropertyChanging();
					this._MODIFIED_ON = value;
					this.SendPropertyChanged("MODIFIED_ON");
					this.OnMODIFIED_ONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BUSINESS", DbType="Bit NOT NULL")]
		public bool BUSINESS
		{
			get
			{
				return this._BUSINESS;
			}
			set
			{
				if ((this._BUSINESS != value))
				{
					this.OnBUSINESSChanging(value);
					this.SendPropertyChanging();
					this._BUSINESS = value;
					this.SendPropertyChanged("BUSINESS");
					this.OnBUSINESSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TECHNICAL", DbType="Bit NOT NULL")]
		public bool TECHNICAL
		{
			get
			{
				return this._TECHNICAL;
			}
			set
			{
				if ((this._TECHNICAL != value))
				{
					this.OnTECHNICALChanging(value);
					this.SendPropertyChanging();
					this._TECHNICAL = value;
					this.SendPropertyChanged("TECHNICAL");
					this.OnTECHNICALChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PAGE_ID", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> PAGE_ID
		{
			get
			{
				return this._PAGE_ID;
			}
			set
			{
				if ((this._PAGE_ID != value))
				{
					this.OnPAGE_IDChanging(value);
					this.SendPropertyChanging();
					this._PAGE_ID = value;
					this.SendPropertyChanged("PAGE_ID");
					this.OnPAGE_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SORT_ORDER", DbType="Int NOT NULL")]
		public int SORT_ORDER
		{
			get
			{
				return this._SORT_ORDER;
			}
			set
			{
				if ((this._SORT_ORDER != value))
				{
					this.OnSORT_ORDERChanging(value);
					this.SendPropertyChanging();
					this._SORT_ORDER = value;
					this.SendPropertyChanged("SORT_ORDER");
					this.OnSORT_ORDERChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.REF_PRIORITY_CALCULATED")]
	public partial class RefPriorityCalculated : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _REQUEST_VALUE;
		
		private string _EFFORT;
		
		private System.Nullable<decimal> _CALC_PRIORITY;
		
		private string _CREATED_BY;
		
		private System.Nullable<System.DateTime> _CREATED_ON;
		
		private string _MODIFIED_BY;
		
		private System.Nullable<System.DateTime> _MODIFIED_ON;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnREQUEST_VALUEChanging(string value);
    partial void OnREQUEST_VALUEChanged();
    partial void OnEFFORTChanging(string value);
    partial void OnEFFORTChanged();
    partial void OnCALC_PRIORITYChanging(System.Nullable<decimal> value);
    partial void OnCALC_PRIORITYChanged();
    partial void OnCREATED_BYChanging(string value);
    partial void OnCREATED_BYChanged();
    partial void OnCREATED_ONChanging(System.Nullable<System.DateTime> value);
    partial void OnCREATED_ONChanged();
    partial void OnMODIFIED_BYChanging(string value);
    partial void OnMODIFIED_BYChanged();
    partial void OnMODIFIED_ONChanging(System.Nullable<System.DateTime> value);
    partial void OnMODIFIED_ONChanged();
    #endregion
		
		public RefPriorityCalculated()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_REQUEST_VALUE", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string REQUEST_VALUE
		{
			get
			{
				return this._REQUEST_VALUE;
			}
			set
			{
				if ((this._REQUEST_VALUE != value))
				{
					this.OnREQUEST_VALUEChanging(value);
					this.SendPropertyChanging();
					this._REQUEST_VALUE = value;
					this.SendPropertyChanged("REQUEST_VALUE");
					this.OnREQUEST_VALUEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EFFORT", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string EFFORT
		{
			get
			{
				return this._EFFORT;
			}
			set
			{
				if ((this._EFFORT != value))
				{
					this.OnEFFORTChanging(value);
					this.SendPropertyChanging();
					this._EFFORT = value;
					this.SendPropertyChanged("EFFORT");
					this.OnEFFORTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CALC_PRIORITY", DbType="Decimal(5,2)")]
		public System.Nullable<decimal> CALC_PRIORITY
		{
			get
			{
				return this._CALC_PRIORITY;
			}
			set
			{
				if ((this._CALC_PRIORITY != value))
				{
					this.OnCALC_PRIORITYChanging(value);
					this.SendPropertyChanging();
					this._CALC_PRIORITY = value;
					this.SendPropertyChanged("CALC_PRIORITY");
					this.OnCALC_PRIORITYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATED_BY", DbType="NVarChar(50)")]
		public string CREATED_BY
		{
			get
			{
				return this._CREATED_BY;
			}
			set
			{
				if ((this._CREATED_BY != value))
				{
					this.OnCREATED_BYChanging(value);
					this.SendPropertyChanging();
					this._CREATED_BY = value;
					this.SendPropertyChanged("CREATED_BY");
					this.OnCREATED_BYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATED_ON", DbType="DateTime")]
		public System.Nullable<System.DateTime> CREATED_ON
		{
			get
			{
				return this._CREATED_ON;
			}
			set
			{
				if ((this._CREATED_ON != value))
				{
					this.OnCREATED_ONChanging(value);
					this.SendPropertyChanging();
					this._CREATED_ON = value;
					this.SendPropertyChanged("CREATED_ON");
					this.OnCREATED_ONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MODIFIED_BY", DbType="NVarChar(50)")]
		public string MODIFIED_BY
		{
			get
			{
				return this._MODIFIED_BY;
			}
			set
			{
				if ((this._MODIFIED_BY != value))
				{
					this.OnMODIFIED_BYChanging(value);
					this.SendPropertyChanging();
					this._MODIFIED_BY = value;
					this.SendPropertyChanged("MODIFIED_BY");
					this.OnMODIFIED_BYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MODIFIED_ON", DbType="DateTime")]
		public System.Nullable<System.DateTime> MODIFIED_ON
		{
			get
			{
				return this._MODIFIED_ON;
			}
			set
			{
				if ((this._MODIFIED_ON != value))
				{
					this.OnMODIFIED_ONChanging(value);
					this.SendPropertyChanging();
					this._MODIFIED_ON = value;
					this.SendPropertyChanged("MODIFIED_ON");
					this.OnMODIFIED_ONChanged();
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