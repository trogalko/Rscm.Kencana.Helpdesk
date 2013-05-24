
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
	/// Encapsulates the 'ADefHelpDesk_TaskAssociations' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ADefHelpDeskTaskAssociations))]	
	[XmlType("ADefHelpDeskTaskAssociations")]
	public partial class ADefHelpDeskTaskAssociations : esADefHelpDeskTaskAssociations
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ADefHelpDeskTaskAssociations();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 taskRelationID)
		{
			var obj = new ADefHelpDeskTaskAssociations();
			obj.TaskRelationID = taskRelationID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 taskRelationID, esSqlAccessType sqlAccessType)
		{
			var obj = new ADefHelpDeskTaskAssociations();
			obj.TaskRelationID = taskRelationID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("ADefHelpDeskTaskAssociationsCollection")]
	public partial class ADefHelpDeskTaskAssociationsCollection : esADefHelpDeskTaskAssociationsCollection, IEnumerable<ADefHelpDeskTaskAssociations>
	{
		public ADefHelpDeskTaskAssociations FindByPrimaryKey(System.Int32 taskRelationID)
		{
			return this.SingleOrDefault(e => e.TaskRelationID == taskRelationID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ADefHelpDeskTaskAssociations))]
		public class ADefHelpDeskTaskAssociationsCollectionWCFPacket : esCollectionWCFPacket<ADefHelpDeskTaskAssociationsCollection>
		{
			public static implicit operator ADefHelpDeskTaskAssociationsCollection(ADefHelpDeskTaskAssociationsCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ADefHelpDeskTaskAssociationsCollectionWCFPacket(ADefHelpDeskTaskAssociationsCollection collection)
			{
				return new ADefHelpDeskTaskAssociationsCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ADefHelpDeskTaskAssociationsQuery : esADefHelpDeskTaskAssociationsQuery
	{
		public ADefHelpDeskTaskAssociationsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ADefHelpDeskTaskAssociationsQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ADefHelpDeskTaskAssociationsQuery query)
		{
			return ADefHelpDeskTaskAssociationsQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ADefHelpDeskTaskAssociationsQuery(string query)
		{
			return (ADefHelpDeskTaskAssociationsQuery)ADefHelpDeskTaskAssociationsQuery.SerializeHelper.FromXml(query, typeof(ADefHelpDeskTaskAssociationsQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esADefHelpDeskTaskAssociations : esEntity
	{
		public esADefHelpDeskTaskAssociations()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 taskRelationID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(taskRelationID);
			else
				return LoadByPrimaryKeyStoredProcedure(taskRelationID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 taskRelationID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(taskRelationID);
			else
				return LoadByPrimaryKeyStoredProcedure(taskRelationID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 taskRelationID)
		{
			ADefHelpDeskTaskAssociationsQuery query = new ADefHelpDeskTaskAssociationsQuery();
			query.Where(query.TaskRelationID == taskRelationID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 taskRelationID)
		{
			esParameters parms = new esParameters();
			parms.Add("TaskRelationID", taskRelationID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to ADefHelpDesk_TaskAssociations.TaskRelationID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? TaskRelationID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskTaskAssociationsMetadata.ColumnNames.TaskRelationID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskTaskAssociationsMetadata.ColumnNames.TaskRelationID, value))
				{
					OnPropertyChanged(ADefHelpDeskTaskAssociationsMetadata.PropertyNames.TaskRelationID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_TaskAssociations.TaskID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? TaskID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskTaskAssociationsMetadata.ColumnNames.TaskID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskTaskAssociationsMetadata.ColumnNames.TaskID, value))
				{
					this._UpToADefHelpDeskTasksByTaskID = null;
					this.OnPropertyChanged("UpToADefHelpDeskTasksByTaskID");
					OnPropertyChanged(ADefHelpDeskTaskAssociationsMetadata.PropertyNames.TaskID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_TaskAssociations.AssociatedID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? AssociatedID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskTaskAssociationsMetadata.ColumnNames.AssociatedID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskTaskAssociationsMetadata.ColumnNames.AssociatedID, value))
				{
					OnPropertyChanged(ADefHelpDeskTaskAssociationsMetadata.PropertyNames.AssociatedID);
				}
			}
		}		
		
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
						case "TaskRelationID": this.str().TaskRelationID = (string)value; break;							
						case "TaskID": this.str().TaskID = (string)value; break;							
						case "AssociatedID": this.str().AssociatedID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "TaskRelationID":
						
							if (value == null || value is System.Int32)
								this.TaskRelationID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskTaskAssociationsMetadata.PropertyNames.TaskRelationID);
							break;
						
						case "TaskID":
						
							if (value == null || value is System.Int32)
								this.TaskID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskTaskAssociationsMetadata.PropertyNames.TaskID);
							break;
						
						case "AssociatedID":
						
							if (value == null || value is System.Int32)
								this.AssociatedID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskTaskAssociationsMetadata.PropertyNames.AssociatedID);
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
			public esStrings(esADefHelpDeskTaskAssociations entity)
			{
				this.entity = entity;
			}
			
	
			public System.String TaskRelationID
			{
				get
				{
					System.Int32? data = entity.TaskRelationID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TaskRelationID = null;
					else entity.TaskRelationID = Convert.ToInt32(value);
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
				
			public System.String AssociatedID
			{
				get
				{
					System.Int32? data = entity.AssociatedID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AssociatedID = null;
					else entity.AssociatedID = Convert.ToInt32(value);
				}
			}
			

			private esADefHelpDeskTaskAssociations entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskTaskAssociationsMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ADefHelpDeskTaskAssociationsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskTaskAssociationsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskTaskAssociationsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ADefHelpDeskTaskAssociationsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ADefHelpDeskTaskAssociationsQuery query;		
	}



	[Serializable]
	abstract public partial class esADefHelpDeskTaskAssociationsCollection : esEntityCollection<ADefHelpDeskTaskAssociations>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskTaskAssociationsMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ADefHelpDeskTaskAssociationsCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ADefHelpDeskTaskAssociationsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskTaskAssociationsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskTaskAssociationsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ADefHelpDeskTaskAssociationsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ADefHelpDeskTaskAssociationsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ADefHelpDeskTaskAssociationsQuery)query);
		}

		#endregion
		
		private ADefHelpDeskTaskAssociationsQuery query;
	}



	[Serializable]
	abstract public partial class esADefHelpDeskTaskAssociationsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskTaskAssociationsMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "TaskRelationID": return this.TaskRelationID;
				case "TaskID": return this.TaskID;
				case "AssociatedID": return this.AssociatedID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem TaskRelationID
		{
			get { return new esQueryItem(this, ADefHelpDeskTaskAssociationsMetadata.ColumnNames.TaskRelationID, esSystemType.Int32); }
		} 
		
		public esQueryItem TaskID
		{
			get { return new esQueryItem(this, ADefHelpDeskTaskAssociationsMetadata.ColumnNames.TaskID, esSystemType.Int32); }
		} 
		
		public esQueryItem AssociatedID
		{
			get { return new esQueryItem(this, ADefHelpDeskTaskAssociationsMetadata.ColumnNames.AssociatedID, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class ADefHelpDeskTaskAssociations : esADefHelpDeskTaskAssociations
	{

				
		#region UpToADefHelpDeskTasksByTaskID - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_ADefHelpDesk_TaskAssociations_ADefHelpDesk_Tasks
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
			if(!this.es.IsDeleted && this._UpToADefHelpDeskTasksByTaskID != null)
			{
				this.TaskID = this._UpToADefHelpDeskTasksByTaskID.TaskID;
			}
		}
		
	}
	



	[Serializable]
	public partial class ADefHelpDeskTaskAssociationsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ADefHelpDeskTaskAssociationsMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ADefHelpDeskTaskAssociationsMetadata.ColumnNames.TaskRelationID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskTaskAssociationsMetadata.PropertyNames.TaskRelationID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTaskAssociationsMetadata.ColumnNames.TaskID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskTaskAssociationsMetadata.PropertyNames.TaskID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTaskAssociationsMetadata.ColumnNames.AssociatedID, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskTaskAssociationsMetadata.PropertyNames.AssociatedID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ADefHelpDeskTaskAssociationsMetadata Meta()
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
			 public const string TaskRelationID = "TaskRelationID";
			 public const string TaskID = "TaskID";
			 public const string AssociatedID = "AssociatedID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string TaskRelationID = "TaskRelationID";
			 public const string TaskID = "TaskID";
			 public const string AssociatedID = "AssociatedID";
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
			lock (typeof(ADefHelpDeskTaskAssociationsMetadata))
			{
				if(ADefHelpDeskTaskAssociationsMetadata.mapDelegates == null)
				{
					ADefHelpDeskTaskAssociationsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ADefHelpDeskTaskAssociationsMetadata.meta == null)
				{
					ADefHelpDeskTaskAssociationsMetadata.meta = new ADefHelpDeskTaskAssociationsMetadata();
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


				meta.AddTypeMap("TaskRelationID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("TaskID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("AssociatedID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "ADefHelpDesk_TaskAssociations";
				meta.Destination = "ADefHelpDesk_TaskAssociations";
				
				meta.spInsert = "proc_ADefHelpDesk_TaskAssociationsInsert";				
				meta.spUpdate = "proc_ADefHelpDesk_TaskAssociationsUpdate";		
				meta.spDelete = "proc_ADefHelpDesk_TaskAssociationsDelete";
				meta.spLoadAll = "proc_ADefHelpDesk_TaskAssociationsLoadAll";
				meta.spLoadByPrimaryKey = "proc_ADefHelpDesk_TaskAssociationsLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ADefHelpDeskTaskAssociationsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
