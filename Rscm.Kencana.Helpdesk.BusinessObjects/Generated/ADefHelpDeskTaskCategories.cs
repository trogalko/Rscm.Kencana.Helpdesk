
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
	/// Encapsulates the 'ADefHelpDesk_TaskCategories' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ADefHelpDeskTaskCategories))]	
	[XmlType("ADefHelpDeskTaskCategories")]
	public partial class ADefHelpDeskTaskCategories : esADefHelpDeskTaskCategories
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ADefHelpDeskTaskCategories();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new ADefHelpDeskTaskCategories();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new ADefHelpDeskTaskCategories();
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
	[XmlType("ADefHelpDeskTaskCategoriesCollection")]
	public partial class ADefHelpDeskTaskCategoriesCollection : esADefHelpDeskTaskCategoriesCollection, IEnumerable<ADefHelpDeskTaskCategories>
	{
		public ADefHelpDeskTaskCategories FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ADefHelpDeskTaskCategories))]
		public class ADefHelpDeskTaskCategoriesCollectionWCFPacket : esCollectionWCFPacket<ADefHelpDeskTaskCategoriesCollection>
		{
			public static implicit operator ADefHelpDeskTaskCategoriesCollection(ADefHelpDeskTaskCategoriesCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ADefHelpDeskTaskCategoriesCollectionWCFPacket(ADefHelpDeskTaskCategoriesCollection collection)
			{
				return new ADefHelpDeskTaskCategoriesCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ADefHelpDeskTaskCategoriesQuery : esADefHelpDeskTaskCategoriesQuery
	{
		public ADefHelpDeskTaskCategoriesQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ADefHelpDeskTaskCategoriesQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ADefHelpDeskTaskCategoriesQuery query)
		{
			return ADefHelpDeskTaskCategoriesQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ADefHelpDeskTaskCategoriesQuery(string query)
		{
			return (ADefHelpDeskTaskCategoriesQuery)ADefHelpDeskTaskCategoriesQuery.SerializeHelper.FromXml(query, typeof(ADefHelpDeskTaskCategoriesQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esADefHelpDeskTaskCategories : esEntity
	{
		public esADefHelpDeskTaskCategories()
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
			ADefHelpDeskTaskCategoriesQuery query = new ADefHelpDeskTaskCategoriesQuery();
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
		/// Maps to ADefHelpDesk_TaskCategories.ID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskTaskCategoriesMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskTaskCategoriesMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(ADefHelpDeskTaskCategoriesMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_TaskCategories.TaskID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? TaskID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskTaskCategoriesMetadata.ColumnNames.TaskID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskTaskCategoriesMetadata.ColumnNames.TaskID, value))
				{
					this._UpToADefHelpDeskTasksByTaskID = null;
					this.OnPropertyChanged("UpToADefHelpDeskTasksByTaskID");
					OnPropertyChanged(ADefHelpDeskTaskCategoriesMetadata.PropertyNames.TaskID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_TaskCategories.CategoryID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? CategoryID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskTaskCategoriesMetadata.ColumnNames.CategoryID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskTaskCategoriesMetadata.ColumnNames.CategoryID, value))
				{
					this._UpToADefHelpDeskCategoriesByCategoryID = null;
					this.OnPropertyChanged("UpToADefHelpDeskCategoriesByCategoryID");
					OnPropertyChanged(ADefHelpDeskTaskCategoriesMetadata.PropertyNames.CategoryID);
				}
			}
		}		
		
		[CLSCompliant(false)]
		internal protected ADefHelpDeskCategories _UpToADefHelpDeskCategoriesByCategoryID;
		[CLSCompliant(false)]
		internal protected ADefHelpDeskTasks _UpToADefHelpDeskTasksByTaskID;
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
						case "TaskID": this.str().TaskID = (string)value; break;							
						case "CategoryID": this.str().CategoryID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int32)
								this.Id = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskTaskCategoriesMetadata.PropertyNames.Id);
							break;
						
						case "TaskID":
						
							if (value == null || value is System.Int32)
								this.TaskID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskTaskCategoriesMetadata.PropertyNames.TaskID);
							break;
						
						case "CategoryID":
						
							if (value == null || value is System.Int32)
								this.CategoryID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskTaskCategoriesMetadata.PropertyNames.CategoryID);
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
			public esStrings(esADefHelpDeskTaskCategories entity)
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
				
			public System.String TaskID
			{
				get
				{
					System.Int32? data = entity.TaskID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TaskID = null;
					else entity.TaskID = Convert.ToInt32(value);
				}
			}
				
			public System.String CategoryID
			{
				get
				{
					System.Int32? data = entity.CategoryID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CategoryID = null;
					else entity.CategoryID = Convert.ToInt32(value);
				}
			}
			

			private esADefHelpDeskTaskCategories entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskTaskCategoriesMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ADefHelpDeskTaskCategoriesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskTaskCategoriesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskTaskCategoriesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ADefHelpDeskTaskCategoriesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ADefHelpDeskTaskCategoriesQuery query;		
	}



	[Serializable]
	abstract public partial class esADefHelpDeskTaskCategoriesCollection : esEntityCollection<ADefHelpDeskTaskCategories>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskTaskCategoriesMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ADefHelpDeskTaskCategoriesCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ADefHelpDeskTaskCategoriesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskTaskCategoriesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskTaskCategoriesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ADefHelpDeskTaskCategoriesQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ADefHelpDeskTaskCategoriesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ADefHelpDeskTaskCategoriesQuery)query);
		}

		#endregion
		
		private ADefHelpDeskTaskCategoriesQuery query;
	}



	[Serializable]
	abstract public partial class esADefHelpDeskTaskCategoriesQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskTaskCategoriesMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "TaskID": return this.TaskID;
				case "CategoryID": return this.CategoryID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, ADefHelpDeskTaskCategoriesMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem TaskID
		{
			get { return new esQueryItem(this, ADefHelpDeskTaskCategoriesMetadata.ColumnNames.TaskID, esSystemType.Int32); }
		} 
		
		public esQueryItem CategoryID
		{
			get { return new esQueryItem(this, ADefHelpDeskTaskCategoriesMetadata.ColumnNames.CategoryID, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class ADefHelpDeskTaskCategories : esADefHelpDeskTaskCategories
	{

				
		#region UpToADefHelpDeskCategoriesByCategoryID - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_ADefHelpDesk_TaskCategories_ADefHelpDesk_Categories
		/// </summary>

		[XmlIgnore]
					
		public ADefHelpDeskCategories UpToADefHelpDeskCategoriesByCategoryID
		{
			get
			{
				if (this.es.IsLazyLoadDisabled) return null;
				
				if(this._UpToADefHelpDeskCategoriesByCategoryID == null && CategoryID != null)
				{
					this._UpToADefHelpDeskCategoriesByCategoryID = new ADefHelpDeskCategories();
					this._UpToADefHelpDeskCategoriesByCategoryID.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToADefHelpDeskCategoriesByCategoryID", this._UpToADefHelpDeskCategoriesByCategoryID);
					this._UpToADefHelpDeskCategoriesByCategoryID.Query.Where(this._UpToADefHelpDeskCategoriesByCategoryID.Query.CategoryID == this.CategoryID);
					this._UpToADefHelpDeskCategoriesByCategoryID.Query.Load();
				}	
				return this._UpToADefHelpDeskCategoriesByCategoryID;
			}
			
			set
			{
				this.RemovePreSave("UpToADefHelpDeskCategoriesByCategoryID");
				

				if(value == null)
				{
					this.CategoryID = null;
					this._UpToADefHelpDeskCategoriesByCategoryID = null;
				}
				else
				{
					this.CategoryID = value.CategoryID;
					this._UpToADefHelpDeskCategoriesByCategoryID = value;
					this.SetPreSave("UpToADefHelpDeskCategoriesByCategoryID", this._UpToADefHelpDeskCategoriesByCategoryID);
				}
				
			}
		}
		#endregion
		

				
		#region UpToADefHelpDeskTasksByTaskID - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_ADefHelpDesk_TaskCategories_ADefHelpDesk_Tasks
		/// </summary>

		[XmlIgnore]
					
		public ADefHelpDeskTasks UpToADefHelpDeskTasksByTaskID
		{
			get
			{
				if (this.es.IsLazyLoadDisabled) return null;
				
				if(this._UpToADefHelpDeskTasksByTaskID == null && TaskID != null)
				{
					this._UpToADefHelpDeskTasksByTaskID = new ADefHelpDeskTasks();
					this._UpToADefHelpDeskTasksByTaskID.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToADefHelpDeskTasksByTaskID", this._UpToADefHelpDeskTasksByTaskID);
					this._UpToADefHelpDeskTasksByTaskID.Query.Where(this._UpToADefHelpDeskTasksByTaskID.Query.TaskID == this.TaskID);
					this._UpToADefHelpDeskTasksByTaskID.Query.Load();
				}	
				return this._UpToADefHelpDeskTasksByTaskID;
			}
			
			set
			{
				this.RemovePreSave("UpToADefHelpDeskTasksByTaskID");
				

				if(value == null)
				{
					this.TaskID = null;
					this._UpToADefHelpDeskTasksByTaskID = null;
				}
				else
				{
					this.TaskID = value.TaskID;
					this._UpToADefHelpDeskTasksByTaskID = value;
					this.SetPreSave("UpToADefHelpDeskTasksByTaskID", this._UpToADefHelpDeskTasksByTaskID);
				}
				
			}
		}
		#endregion
		

		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PreSave.
		/// </summary>
		protected override void ApplyPreSaveKeys()
		{
			if(!this.es.IsDeleted && this._UpToADefHelpDeskCategoriesByCategoryID != null)
			{
				this.CategoryID = this._UpToADefHelpDeskCategoriesByCategoryID.CategoryID;
			}
			if(!this.es.IsDeleted && this._UpToADefHelpDeskTasksByTaskID != null)
			{
				this.TaskID = this._UpToADefHelpDeskTasksByTaskID.TaskID;
			}
		}
		
	}
	



	[Serializable]
	public partial class ADefHelpDeskTaskCategoriesMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ADefHelpDeskTaskCategoriesMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ADefHelpDeskTaskCategoriesMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskTaskCategoriesMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTaskCategoriesMetadata.ColumnNames.TaskID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskTaskCategoriesMetadata.PropertyNames.TaskID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTaskCategoriesMetadata.ColumnNames.CategoryID, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskTaskCategoriesMetadata.PropertyNames.CategoryID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ADefHelpDeskTaskCategoriesMetadata Meta()
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
			 public const string TaskID = "TaskID";
			 public const string CategoryID = "CategoryID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string TaskID = "TaskID";
			 public const string CategoryID = "CategoryID";
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
			lock (typeof(ADefHelpDeskTaskCategoriesMetadata))
			{
				if(ADefHelpDeskTaskCategoriesMetadata.mapDelegates == null)
				{
					ADefHelpDeskTaskCategoriesMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ADefHelpDeskTaskCategoriesMetadata.meta == null)
				{
					ADefHelpDeskTaskCategoriesMetadata.meta = new ADefHelpDeskTaskCategoriesMetadata();
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
				meta.AddTypeMap("TaskID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("CategoryID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "ADefHelpDesk_TaskCategories";
				meta.Destination = "ADefHelpDesk_TaskCategories";
				
				meta.spInsert = "proc_ADefHelpDesk_TaskCategoriesInsert";				
				meta.spUpdate = "proc_ADefHelpDesk_TaskCategoriesUpdate";		
				meta.spDelete = "proc_ADefHelpDesk_TaskCategoriesDelete";
				meta.spLoadAll = "proc_ADefHelpDesk_TaskCategoriesLoadAll";
				meta.spLoadByPrimaryKey = "proc_ADefHelpDesk_TaskCategoriesLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ADefHelpDeskTaskCategoriesMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
