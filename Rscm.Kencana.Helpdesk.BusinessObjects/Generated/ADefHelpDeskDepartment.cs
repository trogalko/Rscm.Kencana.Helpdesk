
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 5/15/2013 10:58:44 AM
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
	/// Encapsulates the 'ADefHelpDeskDepartment' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ADefHelpDeskDepartment))]	
	[XmlType("ADefHelpDeskDepartment")]
	public partial class ADefHelpDeskDepartment : esADefHelpDeskDepartment
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ADefHelpDeskDepartment();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new ADefHelpDeskDepartment();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new ADefHelpDeskDepartment();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("ADefHelpDeskDepartmentCollection")]
	public partial class ADefHelpDeskDepartmentCollection : esADefHelpDeskDepartmentCollection, IEnumerable<ADefHelpDeskDepartment>
	{
		public ADefHelpDeskDepartment FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ADefHelpDeskDepartment))]
		public class ADefHelpDeskDepartmentCollectionWCFPacket : esCollectionWCFPacket<ADefHelpDeskDepartmentCollection>
		{
			public static implicit operator ADefHelpDeskDepartmentCollection(ADefHelpDeskDepartmentCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ADefHelpDeskDepartmentCollectionWCFPacket(ADefHelpDeskDepartmentCollection collection)
			{
				return new ADefHelpDeskDepartmentCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ADefHelpDeskDepartmentQuery : esADefHelpDeskDepartmentQuery
	{
		public ADefHelpDeskDepartmentQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ADefHelpDeskDepartmentQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ADefHelpDeskDepartmentQuery query)
		{
			return ADefHelpDeskDepartmentQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ADefHelpDeskDepartmentQuery(string query)
		{
			return (ADefHelpDeskDepartmentQuery)ADefHelpDeskDepartmentQuery.SerializeHelper.FromXml(query, typeof(ADefHelpDeskDepartmentQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esADefHelpDeskDepartment : esEntity
	{
		public esADefHelpDeskDepartment()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 id)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 id)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 id)
		{
			ADefHelpDeskDepartmentQuery query = new ADefHelpDeskDepartmentQuery();
			query.Where(query.Id == id);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 id)
		{
			esParameters parms = new esParameters();
			parms.Add("Id", id);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to ADefHelpDeskDepartment.ID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskDepartmentMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskDepartmentMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(ADefHelpDeskDepartmentMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDeskDepartment.Department
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Department
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskDepartmentMetadata.ColumnNames.Department);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskDepartmentMetadata.ColumnNames.Department, value))
				{
					OnPropertyChanged(ADefHelpDeskDepartmentMetadata.PropertyNames.Department);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDeskDepartment.CreatedDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreatedDate
		{
			get
			{
				return base.GetSystemDateTime(ADefHelpDeskDepartmentMetadata.ColumnNames.CreatedDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ADefHelpDeskDepartmentMetadata.ColumnNames.CreatedDate, value))
				{
					OnPropertyChanged(ADefHelpDeskDepartmentMetadata.PropertyNames.CreatedDate);
				}
			}
		}		
		
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
						case "Id": this.str().Id = (string)value; break;							
						case "Department": this.str().Department = (string)value; break;							
						case "CreatedDate": this.str().CreatedDate = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int32)
								this.Id = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskDepartmentMetadata.PropertyNames.Id);
							break;
						
						case "CreatedDate":
						
							if (value == null || value is System.DateTime)
								this.CreatedDate = (System.DateTime?)value;
								OnPropertyChanged(ADefHelpDeskDepartmentMetadata.PropertyNames.CreatedDate);
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
			public esStrings(esADefHelpDeskDepartment entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Id
			{
				get
				{
					System.Int32? data = entity.Id;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Id = null;
					else entity.Id = Convert.ToInt32(value);
				}
			}
				
			public System.String Department
			{
				get
				{
					System.String data = entity.Department;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Department = null;
					else entity.Department = Convert.ToString(value);
				}
			}
				
			public System.String CreatedDate
			{
				get
				{
					System.DateTime? data = entity.CreatedDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CreatedDate = null;
					else entity.CreatedDate = Convert.ToDateTime(value);
				}
			}
			

			private esADefHelpDeskDepartment entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskDepartmentMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ADefHelpDeskDepartmentQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskDepartmentQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskDepartmentQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ADefHelpDeskDepartmentQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ADefHelpDeskDepartmentQuery query;		
	}



	[Serializable]
	abstract public partial class esADefHelpDeskDepartmentCollection : esEntityCollection<ADefHelpDeskDepartment>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskDepartmentMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ADefHelpDeskDepartmentCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ADefHelpDeskDepartmentQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskDepartmentQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskDepartmentQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ADefHelpDeskDepartmentQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ADefHelpDeskDepartmentQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ADefHelpDeskDepartmentQuery)query);
		}

		#endregion
		
		private ADefHelpDeskDepartmentQuery query;
	}



	[Serializable]
	abstract public partial class esADefHelpDeskDepartmentQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskDepartmentMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "Department": return this.Department;
				case "CreatedDate": return this.CreatedDate;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, ADefHelpDeskDepartmentMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem Department
		{
			get { return new esQueryItem(this, ADefHelpDeskDepartmentMetadata.ColumnNames.Department, esSystemType.String); }
		} 
		
		public esQueryItem CreatedDate
		{
			get { return new esQueryItem(this, ADefHelpDeskDepartmentMetadata.ColumnNames.CreatedDate, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class ADefHelpDeskDepartment : esADefHelpDeskDepartment
	{

		
		
	}
	



	[Serializable]
	public partial class ADefHelpDeskDepartmentMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ADefHelpDeskDepartmentMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ADefHelpDeskDepartmentMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskDepartmentMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskDepartmentMetadata.ColumnNames.Department, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskDepartmentMetadata.PropertyNames.Department;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskDepartmentMetadata.ColumnNames.CreatedDate, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ADefHelpDeskDepartmentMetadata.PropertyNames.CreatedDate;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ADefHelpDeskDepartmentMetadata Meta()
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
			 public const string Id = "ID";
			 public const string Department = "Department";
			 public const string CreatedDate = "CreatedDate";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string Department = "Department";
			 public const string CreatedDate = "CreatedDate";
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
			lock (typeof(ADefHelpDeskDepartmentMetadata))
			{
				if(ADefHelpDeskDepartmentMetadata.mapDelegates == null)
				{
					ADefHelpDeskDepartmentMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ADefHelpDeskDepartmentMetadata.meta == null)
				{
					ADefHelpDeskDepartmentMetadata.meta = new ADefHelpDeskDepartmentMetadata();
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


				meta.AddTypeMap("Id", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Department", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("CreatedDate", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "ADefHelpDeskDepartment";
				meta.Destination = "ADefHelpDeskDepartment";
				
				meta.spInsert = "proc_ADefHelpDeskDepartmentInsert";				
				meta.spUpdate = "proc_ADefHelpDeskDepartmentUpdate";		
				meta.spDelete = "proc_ADefHelpDeskDepartmentDelete";
				meta.spLoadAll = "proc_ADefHelpDeskDepartmentLoadAll";
				meta.spLoadByPrimaryKey = "proc_ADefHelpDeskDepartmentLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ADefHelpDeskDepartmentMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
