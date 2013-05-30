
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 5/30/2013 11:05:44 AM
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace Rscm.Kencana.Helpdesk.BusinessObjects
{
	/// <summary>
	/// Encapsulates the 'ServiceUnit' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ServiceUnit))]	
	[XmlType("ServiceUnit")]
	public partial class ServiceUnit : esServiceUnit
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ServiceUnit();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String serviceUnitID)
		{
			var obj = new ServiceUnit();
			obj.ServiceUnitID = serviceUnitID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String serviceUnitID, esSqlAccessType sqlAccessType)
		{
			var obj = new ServiceUnit();
			obj.ServiceUnitID = serviceUnitID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("ServiceUnitCollection")]
	public partial class ServiceUnitCollection : esServiceUnitCollection, IEnumerable<ServiceUnit>
	{
		public ServiceUnit FindByPrimaryKey(System.String serviceUnitID)
		{
			return this.SingleOrDefault(e => e.ServiceUnitID == serviceUnitID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ServiceUnit))]
		public class ServiceUnitCollectionWCFPacket : esCollectionWCFPacket<ServiceUnitCollection>
		{
			public static implicit operator ServiceUnitCollection(ServiceUnitCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ServiceUnitCollectionWCFPacket(ServiceUnitCollection collection)
			{
				return new ServiceUnitCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ServiceUnitQuery : esServiceUnitQuery
	{
		public ServiceUnitQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ServiceUnitQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ServiceUnitQuery query)
		{
			return ServiceUnitQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ServiceUnitQuery(string query)
		{
			return (ServiceUnitQuery)ServiceUnitQuery.SerializeHelper.FromXml(query, typeof(ServiceUnitQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esServiceUnit : esEntity
	{
		public esServiceUnit()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String serviceUnitID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(serviceUnitID);
			else
				return LoadByPrimaryKeyStoredProcedure(serviceUnitID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String serviceUnitID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(serviceUnitID);
			else
				return LoadByPrimaryKeyStoredProcedure(serviceUnitID);
		}

		private bool LoadByPrimaryKeyDynamic(System.String serviceUnitID)
		{
			ServiceUnitQuery query = new ServiceUnitQuery();
			query.Where(query.ServiceUnitID == serviceUnitID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String serviceUnitID)
		{
			esParameters parms = new esParameters();
			parms.Add("ServiceUnitID", serviceUnitID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to ServiceUnit.ServiceUnitID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ServiceUnitID
		{
			get
			{
				return base.GetSystemString(ServiceUnitMetadata.ColumnNames.ServiceUnitID);
			}
			
			set
			{
				if(base.SetSystemString(ServiceUnitMetadata.ColumnNames.ServiceUnitID, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ServiceUnitID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.DepartmentID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String DepartmentID
		{
			get
			{
				return base.GetSystemString(ServiceUnitMetadata.ColumnNames.DepartmentID);
			}
			
			set
			{
				if(base.SetSystemString(ServiceUnitMetadata.ColumnNames.DepartmentID, value))
				{
					//this._UpToDepartmentByDepartmentID = null;
					this.OnPropertyChanged("UpToDepartmentByDepartmentID");
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.DepartmentID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.ServiceUnitName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ServiceUnitName
		{
			get
			{
				return base.GetSystemString(ServiceUnitMetadata.ColumnNames.ServiceUnitName);
			}
			
			set
			{
				if(base.SetSystemString(ServiceUnitMetadata.ColumnNames.ServiceUnitName, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ServiceUnitName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.ShortName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ShortName
		{
			get
			{
				return base.GetSystemString(ServiceUnitMetadata.ColumnNames.ShortName);
			}
			
			set
			{
				if(base.SetSystemString(ServiceUnitMetadata.ColumnNames.ShortName, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ShortName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.ServiceUnitOfficer
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ServiceUnitOfficer
		{
			get
			{
				return base.GetSystemString(ServiceUnitMetadata.ColumnNames.ServiceUnitOfficer);
			}
			
			set
			{
				if(base.SetSystemString(ServiceUnitMetadata.ColumnNames.ServiceUnitOfficer, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ServiceUnitOfficer);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.LocationID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LocationID
		{
			get
			{
				return base.GetSystemString(ServiceUnitMetadata.ColumnNames.LocationID);
			}
			
			set
			{
				if(base.SetSystemString(ServiceUnitMetadata.ColumnNames.LocationID, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.LocationID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.SRRegistrationType
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String SRRegistrationType
		{
			get
			{
				return base.GetSystemString(ServiceUnitMetadata.ColumnNames.SRRegistrationType);
			}
			
			set
			{
				if(base.SetSystemString(ServiceUnitMetadata.ColumnNames.SRRegistrationType, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SRRegistrationType);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.IsUsingJobOrder
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsUsingJobOrder
		{
			get
			{
				return base.GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsUsingJobOrder);
			}
			
			set
			{
				if(base.SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsUsingJobOrder, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsUsingJobOrder);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.IsPatientTransaction
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsPatientTransaction
		{
			get
			{
				return base.GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsPatientTransaction);
			}
			
			set
			{
				if(base.SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsPatientTransaction, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsPatientTransaction);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.IsTransactionEntry
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsTransactionEntry
		{
			get
			{
				return base.GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsTransactionEntry);
			}
			
			set
			{
				if(base.SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsTransactionEntry, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsTransactionEntry);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.IsDispensaryUnit
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsDispensaryUnit
		{
			get
			{
				return base.GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsDispensaryUnit);
			}
			
			set
			{
				if(base.SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsDispensaryUnit, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsDispensaryUnit);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.IsPurchasingUnit
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsPurchasingUnit
		{
			get
			{
				return base.GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsPurchasingUnit);
			}
			
			set
			{
				if(base.SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsPurchasingUnit, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsPurchasingUnit);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.IsGenerateMedicalNo
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsGenerateMedicalNo
		{
			get
			{
				return base.GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsGenerateMedicalNo);
			}
			
			set
			{
				if(base.SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsGenerateMedicalNo, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsGenerateMedicalNo);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.IsActive
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsActive
		{
			get
			{
				return base.GetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsActive);
			}
			
			set
			{
				if(base.SetSystemBoolean(ServiceUnitMetadata.ColumnNames.IsActive, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsActive);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.ChartOfAccountIdIncome
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ChartOfAccountIdIncome
		{
			get
			{
				return base.GetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdIncome);
			}
			
			set
			{
				if(base.SetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdIncome, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ChartOfAccountIdIncome);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.SubledgerIdIncome
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? SubledgerIdIncome
		{
			get
			{
				return base.GetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdIncome);
			}
			
			set
			{
				if(base.SetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdIncome, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SubledgerIdIncome);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.ChartOfAccountIdAcrual
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ChartOfAccountIdAcrual
		{
			get
			{
				return base.GetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdAcrual);
			}
			
			set
			{
				if(base.SetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdAcrual, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ChartOfAccountIdAcrual);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.SubledgerIdAcrual
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? SubledgerIdAcrual
		{
			get
			{
				return base.GetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdAcrual);
			}
			
			set
			{
				if(base.SetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdAcrual, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SubledgerIdAcrual);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.ChartOfAccountIdDiscount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ChartOfAccountIdDiscount
		{
			get
			{
				return base.GetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdDiscount);
			}
			
			set
			{
				if(base.SetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdDiscount, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ChartOfAccountIdDiscount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.SubledgerIdDiscount
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? SubledgerIdDiscount
		{
			get
			{
				return base.GetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdDiscount);
			}
			
			set
			{
				if(base.SetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdDiscount, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SubledgerIdDiscount);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.LastUpdateDateTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? LastUpdateDateTime
		{
			get
			{
				return base.GetSystemDateTime(ServiceUnitMetadata.ColumnNames.LastUpdateDateTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(ServiceUnitMetadata.ColumnNames.LastUpdateDateTime, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.LastUpdateDateTime);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.LastUpdateByUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastUpdateByUserID
		{
			get
			{
				return base.GetSystemString(ServiceUnitMetadata.ColumnNames.LastUpdateByUserID);
			}
			
			set
			{
				if(base.SetSystemString(ServiceUnitMetadata.ColumnNames.LastUpdateByUserID, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.LastUpdateByUserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.ChartOfAccountIdCost
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ChartOfAccountIdCost
		{
			get
			{
				return base.GetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdCost);
			}
			
			set
			{
				if(base.SetSystemInt32(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdCost, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ChartOfAccountIdCost);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ServiceUnit.SubledgerIdCost
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? SubledgerIdCost
		{
			get
			{
				return base.GetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdCost);
			}
			
			set
			{
				if(base.SetSystemInt32(ServiceUnitMetadata.ColumnNames.SubledgerIdCost, value))
				{
					OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SubledgerIdCost);
				}
			}
		}		
		
		[CLSCompliant(false)]
		//internal protected Department _UpToDepartmentByDepartmentID;
		#endregion	

		#region .str() Properties
		
		public override void SetProperties(IDictionary values)
		{
			foreach (string propertyName in values.Keys)
			{
				this.SetProperty(propertyName, values[propertyName]);
			}
		}
		
		public override void SetProperty(string name, object value)
		{
			esColumnMetadata col = this.Meta.Columns.FindByPropertyName(name);
			if (col != null)
			{
				if(value == null || value is System.String)
				{				
					// Use the strongly typed property
					switch (name)
					{							
						case "ServiceUnitID": this.str().ServiceUnitID = (string)value; break;							
						case "DepartmentID": this.str().DepartmentID = (string)value; break;							
						case "ServiceUnitName": this.str().ServiceUnitName = (string)value; break;							
						case "ShortName": this.str().ShortName = (string)value; break;							
						case "ServiceUnitOfficer": this.str().ServiceUnitOfficer = (string)value; break;							
						case "LocationID": this.str().LocationID = (string)value; break;							
						case "SRRegistrationType": this.str().SRRegistrationType = (string)value; break;							
						case "IsUsingJobOrder": this.str().IsUsingJobOrder = (string)value; break;							
						case "IsPatientTransaction": this.str().IsPatientTransaction = (string)value; break;							
						case "IsTransactionEntry": this.str().IsTransactionEntry = (string)value; break;							
						case "IsDispensaryUnit": this.str().IsDispensaryUnit = (string)value; break;							
						case "IsPurchasingUnit": this.str().IsPurchasingUnit = (string)value; break;							
						case "IsGenerateMedicalNo": this.str().IsGenerateMedicalNo = (string)value; break;							
						case "IsActive": this.str().IsActive = (string)value; break;							
						case "ChartOfAccountIdIncome": this.str().ChartOfAccountIdIncome = (string)value; break;							
						case "SubledgerIdIncome": this.str().SubledgerIdIncome = (string)value; break;							
						case "ChartOfAccountIdAcrual": this.str().ChartOfAccountIdAcrual = (string)value; break;							
						case "SubledgerIdAcrual": this.str().SubledgerIdAcrual = (string)value; break;							
						case "ChartOfAccountIdDiscount": this.str().ChartOfAccountIdDiscount = (string)value; break;							
						case "SubledgerIdDiscount": this.str().SubledgerIdDiscount = (string)value; break;							
						case "LastUpdateDateTime": this.str().LastUpdateDateTime = (string)value; break;							
						case "LastUpdateByUserID": this.str().LastUpdateByUserID = (string)value; break;							
						case "ChartOfAccountIdCost": this.str().ChartOfAccountIdCost = (string)value; break;							
						case "SubledgerIdCost": this.str().SubledgerIdCost = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "IsUsingJobOrder":
						
							if (value == null || value is System.Boolean)
								this.IsUsingJobOrder = (System.Boolean?)value;
								OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsUsingJobOrder);
							break;
						
						case "IsPatientTransaction":
						
							if (value == null || value is System.Boolean)
								this.IsPatientTransaction = (System.Boolean?)value;
								OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsPatientTransaction);
							break;
						
						case "IsTransactionEntry":
						
							if (value == null || value is System.Boolean)
								this.IsTransactionEntry = (System.Boolean?)value;
								OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsTransactionEntry);
							break;
						
						case "IsDispensaryUnit":
						
							if (value == null || value is System.Boolean)
								this.IsDispensaryUnit = (System.Boolean?)value;
								OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsDispensaryUnit);
							break;
						
						case "IsPurchasingUnit":
						
							if (value == null || value is System.Boolean)
								this.IsPurchasingUnit = (System.Boolean?)value;
								OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsPurchasingUnit);
							break;
						
						case "IsGenerateMedicalNo":
						
							if (value == null || value is System.Boolean)
								this.IsGenerateMedicalNo = (System.Boolean?)value;
								OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsGenerateMedicalNo);
							break;
						
						case "IsActive":
						
							if (value == null || value is System.Boolean)
								this.IsActive = (System.Boolean?)value;
								OnPropertyChanged(ServiceUnitMetadata.PropertyNames.IsActive);
							break;
						
						case "ChartOfAccountIdIncome":
						
							if (value == null || value is System.Int32)
								this.ChartOfAccountIdIncome = (System.Int32?)value;
								OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ChartOfAccountIdIncome);
							break;
						
						case "SubledgerIdIncome":
						
							if (value == null || value is System.Int32)
								this.SubledgerIdIncome = (System.Int32?)value;
								OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SubledgerIdIncome);
							break;
						
						case "ChartOfAccountIdAcrual":
						
							if (value == null || value is System.Int32)
								this.ChartOfAccountIdAcrual = (System.Int32?)value;
								OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ChartOfAccountIdAcrual);
							break;
						
						case "SubledgerIdAcrual":
						
							if (value == null || value is System.Int32)
								this.SubledgerIdAcrual = (System.Int32?)value;
								OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SubledgerIdAcrual);
							break;
						
						case "ChartOfAccountIdDiscount":
						
							if (value == null || value is System.Int32)
								this.ChartOfAccountIdDiscount = (System.Int32?)value;
								OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ChartOfAccountIdDiscount);
							break;
						
						case "SubledgerIdDiscount":
						
							if (value == null || value is System.Int32)
								this.SubledgerIdDiscount = (System.Int32?)value;
								OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SubledgerIdDiscount);
							break;
						
						case "LastUpdateDateTime":
						
							if (value == null || value is System.DateTime)
								this.LastUpdateDateTime = (System.DateTime?)value;
								OnPropertyChanged(ServiceUnitMetadata.PropertyNames.LastUpdateDateTime);
							break;
						
						case "ChartOfAccountIdCost":
						
							if (value == null || value is System.Int32)
								this.ChartOfAccountIdCost = (System.Int32?)value;
								OnPropertyChanged(ServiceUnitMetadata.PropertyNames.ChartOfAccountIdCost);
							break;
						
						case "SubledgerIdCost":
						
							if (value == null || value is System.Int32)
								this.SubledgerIdCost = (System.Int32?)value;
								OnPropertyChanged(ServiceUnitMetadata.PropertyNames.SubledgerIdCost);
							break;
					

						default:
							break;
					}
				}
			}
            else if (this.ContainsColumn(name))
            {
                this.SetColumn(name, value);
            }
			else
			{
				throw new Exception("SetProperty Error: '" + name + "' not found");
			}
		}		

		public esStrings str()
		{
			if (esstrings == null)
			{
				esstrings = new esStrings(this);
			}
			return esstrings;
		}

		sealed public class esStrings
		{
			public esStrings(esServiceUnit entity)
			{
				this.entity = entity;
			}
			
	
			public System.String ServiceUnitID
			{
				get
				{
					System.String data = entity.ServiceUnitID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ServiceUnitID = null;
					else entity.ServiceUnitID = Convert.ToString(value);
				}
			}
				
			public System.String DepartmentID
			{
				get
				{
					System.String data = entity.DepartmentID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.DepartmentID = null;
					else entity.DepartmentID = Convert.ToString(value);
				}
			}
				
			public System.String ServiceUnitName
			{
				get
				{
					System.String data = entity.ServiceUnitName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ServiceUnitName = null;
					else entity.ServiceUnitName = Convert.ToString(value);
				}
			}
				
			public System.String ShortName
			{
				get
				{
					System.String data = entity.ShortName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ShortName = null;
					else entity.ShortName = Convert.ToString(value);
				}
			}
				
			public System.String ServiceUnitOfficer
			{
				get
				{
					System.String data = entity.ServiceUnitOfficer;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ServiceUnitOfficer = null;
					else entity.ServiceUnitOfficer = Convert.ToString(value);
				}
			}
				
			public System.String LocationID
			{
				get
				{
					System.String data = entity.LocationID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LocationID = null;
					else entity.LocationID = Convert.ToString(value);
				}
			}
				
			public System.String SRRegistrationType
			{
				get
				{
					System.String data = entity.SRRegistrationType;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SRRegistrationType = null;
					else entity.SRRegistrationType = Convert.ToString(value);
				}
			}
				
			public System.String IsUsingJobOrder
			{
				get
				{
					System.Boolean? data = entity.IsUsingJobOrder;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsUsingJobOrder = null;
					else entity.IsUsingJobOrder = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsPatientTransaction
			{
				get
				{
					System.Boolean? data = entity.IsPatientTransaction;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsPatientTransaction = null;
					else entity.IsPatientTransaction = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsTransactionEntry
			{
				get
				{
					System.Boolean? data = entity.IsTransactionEntry;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsTransactionEntry = null;
					else entity.IsTransactionEntry = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsDispensaryUnit
			{
				get
				{
					System.Boolean? data = entity.IsDispensaryUnit;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsDispensaryUnit = null;
					else entity.IsDispensaryUnit = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsPurchasingUnit
			{
				get
				{
					System.Boolean? data = entity.IsPurchasingUnit;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsPurchasingUnit = null;
					else entity.IsPurchasingUnit = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsGenerateMedicalNo
			{
				get
				{
					System.Boolean? data = entity.IsGenerateMedicalNo;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsGenerateMedicalNo = null;
					else entity.IsGenerateMedicalNo = Convert.ToBoolean(value);
				}
			}
				
			public System.String IsActive
			{
				get
				{
					System.Boolean? data = entity.IsActive;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsActive = null;
					else entity.IsActive = Convert.ToBoolean(value);
				}
			}
				
			public System.String ChartOfAccountIdIncome
			{
				get
				{
					System.Int32? data = entity.ChartOfAccountIdIncome;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ChartOfAccountIdIncome = null;
					else entity.ChartOfAccountIdIncome = Convert.ToInt32(value);
				}
			}
				
			public System.String SubledgerIdIncome
			{
				get
				{
					System.Int32? data = entity.SubledgerIdIncome;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SubledgerIdIncome = null;
					else entity.SubledgerIdIncome = Convert.ToInt32(value);
				}
			}
				
			public System.String ChartOfAccountIdAcrual
			{
				get
				{
					System.Int32? data = entity.ChartOfAccountIdAcrual;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ChartOfAccountIdAcrual = null;
					else entity.ChartOfAccountIdAcrual = Convert.ToInt32(value);
				}
			}
				
			public System.String SubledgerIdAcrual
			{
				get
				{
					System.Int32? data = entity.SubledgerIdAcrual;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SubledgerIdAcrual = null;
					else entity.SubledgerIdAcrual = Convert.ToInt32(value);
				}
			}
				
			public System.String ChartOfAccountIdDiscount
			{
				get
				{
					System.Int32? data = entity.ChartOfAccountIdDiscount;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ChartOfAccountIdDiscount = null;
					else entity.ChartOfAccountIdDiscount = Convert.ToInt32(value);
				}
			}
				
			public System.String SubledgerIdDiscount
			{
				get
				{
					System.Int32? data = entity.SubledgerIdDiscount;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SubledgerIdDiscount = null;
					else entity.SubledgerIdDiscount = Convert.ToInt32(value);
				}
			}
				
			public System.String LastUpdateDateTime
			{
				get
				{
					System.DateTime? data = entity.LastUpdateDateTime;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastUpdateDateTime = null;
					else entity.LastUpdateDateTime = Convert.ToDateTime(value);
				}
			}
				
			public System.String LastUpdateByUserID
			{
				get
				{
					System.String data = entity.LastUpdateByUserID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastUpdateByUserID = null;
					else entity.LastUpdateByUserID = Convert.ToString(value);
				}
			}
				
			public System.String ChartOfAccountIdCost
			{
				get
				{
					System.Int32? data = entity.ChartOfAccountIdCost;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ChartOfAccountIdCost = null;
					else entity.ChartOfAccountIdCost = Convert.ToInt32(value);
				}
			}
				
			public System.String SubledgerIdCost
			{
				get
				{
					System.Int32? data = entity.SubledgerIdCost;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SubledgerIdCost = null;
					else entity.SubledgerIdCost = Convert.ToInt32(value);
				}
			}
			

			private esServiceUnit entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ServiceUnitMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ServiceUnitQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ServiceUnitQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ServiceUnitQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ServiceUnitQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ServiceUnitQuery query;		
	}



	[Serializable]
	abstract public partial class esServiceUnitCollection : esEntityCollection<ServiceUnit>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ServiceUnitMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ServiceUnitCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ServiceUnitQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ServiceUnitQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ServiceUnitQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ServiceUnitQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ServiceUnitQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ServiceUnitQuery)query);
		}

		#endregion
		
		private ServiceUnitQuery query;
	}



	[Serializable]
	abstract public partial class esServiceUnitQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ServiceUnitMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "ServiceUnitID": return this.ServiceUnitID;
				case "DepartmentID": return this.DepartmentID;
				case "ServiceUnitName": return this.ServiceUnitName;
				case "ShortName": return this.ShortName;
				case "ServiceUnitOfficer": return this.ServiceUnitOfficer;
				case "LocationID": return this.LocationID;
				case "SRRegistrationType": return this.SRRegistrationType;
				case "IsUsingJobOrder": return this.IsUsingJobOrder;
				case "IsPatientTransaction": return this.IsPatientTransaction;
				case "IsTransactionEntry": return this.IsTransactionEntry;
				case "IsDispensaryUnit": return this.IsDispensaryUnit;
				case "IsPurchasingUnit": return this.IsPurchasingUnit;
				case "IsGenerateMedicalNo": return this.IsGenerateMedicalNo;
				case "IsActive": return this.IsActive;
				case "ChartOfAccountIdIncome": return this.ChartOfAccountIdIncome;
				case "SubledgerIdIncome": return this.SubledgerIdIncome;
				case "ChartOfAccountIdAcrual": return this.ChartOfAccountIdAcrual;
				case "SubledgerIdAcrual": return this.SubledgerIdAcrual;
				case "ChartOfAccountIdDiscount": return this.ChartOfAccountIdDiscount;
				case "SubledgerIdDiscount": return this.SubledgerIdDiscount;
				case "LastUpdateDateTime": return this.LastUpdateDateTime;
				case "LastUpdateByUserID": return this.LastUpdateByUserID;
				case "ChartOfAccountIdCost": return this.ChartOfAccountIdCost;
				case "SubledgerIdCost": return this.SubledgerIdCost;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem ServiceUnitID
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ServiceUnitID, esSystemType.String); }
		} 
		
		public esQueryItem DepartmentID
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.DepartmentID, esSystemType.String); }
		} 
		
		public esQueryItem ServiceUnitName
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ServiceUnitName, esSystemType.String); }
		} 
		
		public esQueryItem ShortName
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ShortName, esSystemType.String); }
		} 
		
		public esQueryItem ServiceUnitOfficer
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ServiceUnitOfficer, esSystemType.String); }
		} 
		
		public esQueryItem LocationID
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.LocationID, esSystemType.String); }
		} 
		
		public esQueryItem SRRegistrationType
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SRRegistrationType, esSystemType.String); }
		} 
		
		public esQueryItem IsUsingJobOrder
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsUsingJobOrder, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsPatientTransaction
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsPatientTransaction, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsTransactionEntry
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsTransactionEntry, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsDispensaryUnit
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsDispensaryUnit, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsPurchasingUnit
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsPurchasingUnit, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsGenerateMedicalNo
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsGenerateMedicalNo, esSystemType.Boolean); }
		} 
		
		public esQueryItem IsActive
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.IsActive, esSystemType.Boolean); }
		} 
		
		public esQueryItem ChartOfAccountIdIncome
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ChartOfAccountIdIncome, esSystemType.Int32); }
		} 
		
		public esQueryItem SubledgerIdIncome
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SubledgerIdIncome, esSystemType.Int32); }
		} 
		
		public esQueryItem ChartOfAccountIdAcrual
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ChartOfAccountIdAcrual, esSystemType.Int32); }
		} 
		
		public esQueryItem SubledgerIdAcrual
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SubledgerIdAcrual, esSystemType.Int32); }
		} 
		
		public esQueryItem ChartOfAccountIdDiscount
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ChartOfAccountIdDiscount, esSystemType.Int32); }
		} 
		
		public esQueryItem SubledgerIdDiscount
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SubledgerIdDiscount, esSystemType.Int32); }
		} 
		
		public esQueryItem LastUpdateDateTime
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.LastUpdateDateTime, esSystemType.DateTime); }
		} 
		
		public esQueryItem LastUpdateByUserID
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.LastUpdateByUserID, esSystemType.String); }
		} 
		
		public esQueryItem ChartOfAccountIdCost
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.ChartOfAccountIdCost, esSystemType.Int32); }
		} 
		
		public esQueryItem SubledgerIdCost
		{
			get { return new esQueryItem(this, ServiceUnitMetadata.ColumnNames.SubledgerIdCost, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class ServiceUnit : esServiceUnit
	{

		#region ServiceUnitBookingCollectionByServiceUnitID - Zero To Many
		
		static public esPrefetchMap Prefetch_ServiceUnitBookingCollectionByServiceUnitID
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap();
				//map.PrefetchDelegate = Rscm.Kencana.Helpdesk.BusinessObjects.ServiceUnit.ServiceUnitBookingCollectionByServiceUnitID_Delegate;
				map.PropertyName = "ServiceUnitBookingCollectionByServiceUnitID";
				map.MyColumnName = "ServiceUnitID";
				map.ParentColumnName = "ServiceUnitID";
				map.IsMultiPartKey = false;
				return map;
			}
		}		
		
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_ServiceUnitBooking_ServiceUnit
		/// </summary>

		
			
		
		
		#endregion

				
		#region UpToDepartmentByDepartmentID - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - RefServiceUnitToDepartment
		/// </summary>

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "ServiceUnitBookingCollectionByServiceUnitID":
					//coll = this.ServiceUnitBookingCollectionByServiceUnitID;
					break;	
			}

			return coll;
		}		
		/// <summary>
		/// Used internally by the entity's hierarchical properties.
		/// </summary>
        //protected override List<esPropertyDescriptor> GetHierarchicalProperties()
        //{
        //    List<esPropertyDescriptor> props = new List<esPropertyDescriptor>();
			
        //    props.Add(new esPropertyDescriptor(this, "ServiceUnitBookingCollectionByServiceUnitID", typeof(ServiceUnitBookingCollection), new ServiceUnitBooking()));
		
        //    return props;
        //}
		
	}
	



	[Serializable]
	public partial class ServiceUnitMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ServiceUnitMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.ServiceUnitID, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.ServiceUnitID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 10;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.DepartmentID, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.DepartmentID;
			c.CharacterMaxLength = 10;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.ServiceUnitName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.ServiceUnitName;
			c.CharacterMaxLength = 4000;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.ShortName, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.ShortName;
			c.CharacterMaxLength = 35;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.ServiceUnitOfficer, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.ServiceUnitOfficer;
			c.CharacterMaxLength = 100;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.LocationID, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.LocationID;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.SRRegistrationType, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.SRRegistrationType;
			c.CharacterMaxLength = 20;
			c.HasDefault = true;
			c.Default = @"('')";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.IsUsingJobOrder, 7, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.IsUsingJobOrder;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.IsPatientTransaction, 8, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.IsPatientTransaction;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.IsTransactionEntry, 9, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.IsTransactionEntry;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.IsDispensaryUnit, 10, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.IsDispensaryUnit;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.IsPurchasingUnit, 11, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.IsPurchasingUnit;
			c.HasDefault = true;
			c.Default = @"((0))";
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.IsGenerateMedicalNo, 12, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.IsGenerateMedicalNo;
			c.HasDefault = true;
			c.Default = @"((0))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.IsActive, 13, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.IsActive;
			c.HasDefault = true;
			c.Default = @"((1))";
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdIncome, 14, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.ChartOfAccountIdIncome;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.SubledgerIdIncome, 15, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.SubledgerIdIncome;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdAcrual, 16, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.ChartOfAccountIdAcrual;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.SubledgerIdAcrual, 17, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.SubledgerIdAcrual;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdDiscount, 18, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.ChartOfAccountIdDiscount;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.SubledgerIdDiscount, 19, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.SubledgerIdDiscount;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.LastUpdateDateTime, 20, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.LastUpdateDateTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.LastUpdateByUserID, 21, typeof(System.String), esSystemType.String);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.LastUpdateByUserID;
			c.CharacterMaxLength = 40;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.ChartOfAccountIdCost, 22, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.ChartOfAccountIdCost;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ServiceUnitMetadata.ColumnNames.SubledgerIdCost, 23, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ServiceUnitMetadata.PropertyNames.SubledgerIdCost;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ServiceUnitMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base.m_dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base.m_columns; }
		}
		
		#region ColumnNames
		public class ColumnNames
		{ 
			 public const string ServiceUnitID = "ServiceUnitID";
			 public const string DepartmentID = "DepartmentID";
			 public const string ServiceUnitName = "ServiceUnitName";
			 public const string ShortName = "ShortName";
			 public const string ServiceUnitOfficer = "ServiceUnitOfficer";
			 public const string LocationID = "LocationID";
			 public const string SRRegistrationType = "SRRegistrationType";
			 public const string IsUsingJobOrder = "IsUsingJobOrder";
			 public const string IsPatientTransaction = "IsPatientTransaction";
			 public const string IsTransactionEntry = "IsTransactionEntry";
			 public const string IsDispensaryUnit = "IsDispensaryUnit";
			 public const string IsPurchasingUnit = "IsPurchasingUnit";
			 public const string IsGenerateMedicalNo = "IsGenerateMedicalNo";
			 public const string IsActive = "IsActive";
			 public const string ChartOfAccountIdIncome = "ChartOfAccountIdIncome";
			 public const string SubledgerIdIncome = "SubledgerIdIncome";
			 public const string ChartOfAccountIdAcrual = "ChartOfAccountIdAcrual";
			 public const string SubledgerIdAcrual = "SubledgerIdAcrual";
			 public const string ChartOfAccountIdDiscount = "ChartOfAccountIdDiscount";
			 public const string SubledgerIdDiscount = "SubledgerIdDiscount";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
			 public const string ChartOfAccountIdCost = "ChartOfAccountIdCost";
			 public const string SubledgerIdCost = "SubledgerIdCost";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string ServiceUnitID = "ServiceUnitID";
			 public const string DepartmentID = "DepartmentID";
			 public const string ServiceUnitName = "ServiceUnitName";
			 public const string ShortName = "ShortName";
			 public const string ServiceUnitOfficer = "ServiceUnitOfficer";
			 public const string LocationID = "LocationID";
			 public const string SRRegistrationType = "SRRegistrationType";
			 public const string IsUsingJobOrder = "IsUsingJobOrder";
			 public const string IsPatientTransaction = "IsPatientTransaction";
			 public const string IsTransactionEntry = "IsTransactionEntry";
			 public const string IsDispensaryUnit = "IsDispensaryUnit";
			 public const string IsPurchasingUnit = "IsPurchasingUnit";
			 public const string IsGenerateMedicalNo = "IsGenerateMedicalNo";
			 public const string IsActive = "IsActive";
			 public const string ChartOfAccountIdIncome = "ChartOfAccountIdIncome";
			 public const string SubledgerIdIncome = "SubledgerIdIncome";
			 public const string ChartOfAccountIdAcrual = "ChartOfAccountIdAcrual";
			 public const string SubledgerIdAcrual = "SubledgerIdAcrual";
			 public const string ChartOfAccountIdDiscount = "ChartOfAccountIdDiscount";
			 public const string SubledgerIdDiscount = "SubledgerIdDiscount";
			 public const string LastUpdateDateTime = "LastUpdateDateTime";
			 public const string LastUpdateByUserID = "LastUpdateByUserID";
			 public const string ChartOfAccountIdCost = "ChartOfAccountIdCost";
			 public const string SubledgerIdCost = "SubledgerIdCost";
		}
		#endregion	

		public esProviderSpecificMetadata GetProviderMetadata(string mapName)
		{
			MapToMeta mapMethod = mapDelegates[mapName];

			if (mapMethod != null)
				return mapMethod(mapName);
			else
				return null;
		}
		
		#region MAP esDefault
		
		static private int RegisterDelegateesDefault()
		{
			// This is only executed once per the life of the application
			lock (typeof(ServiceUnitMetadata))
			{
				if(ServiceUnitMetadata.mapDelegates == null)
				{
					ServiceUnitMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ServiceUnitMetadata.meta == null)
				{
					ServiceUnitMetadata.meta = new ServiceUnitMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esDefault);
				mapDelegates.Add("esDefault", mapMethod);
				mapMethod("esDefault");
			}
			return 0;
		}			

		private esProviderSpecificMetadata esDefault(string mapName)
		{
			if(!m_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();			


				meta.AddTypeMap("ServiceUnitID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("DepartmentID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ServiceUnitName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ShortName", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ServiceUnitOfficer", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("LocationID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("SRRegistrationType", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("IsUsingJobOrder", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsPatientTransaction", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsTransactionEntry", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsDispensaryUnit", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsPurchasingUnit", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsGenerateMedicalNo", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("ChartOfAccountIdIncome", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("SubledgerIdIncome", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("ChartOfAccountIdAcrual", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("SubledgerIdAcrual", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("ChartOfAccountIdDiscount", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("SubledgerIdDiscount", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("LastUpdateDateTime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("LastUpdateByUserID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("ChartOfAccountIdCost", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("SubledgerIdCost", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "ServiceUnit";
				meta.Destination = "ServiceUnit";
				
				meta.spInsert = "proc_ServiceUnitInsert";				
				meta.spUpdate = "proc_ServiceUnitUpdate";		
				meta.spDelete = "proc_ServiceUnitDelete";
				meta.spLoadAll = "proc_ServiceUnitLoadAll";
				meta.spLoadByPrimaryKey = "proc_ServiceUnitLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ServiceUnitMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
        #endregion