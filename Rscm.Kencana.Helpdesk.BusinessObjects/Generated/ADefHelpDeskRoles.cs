
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 5/15/2013 10:58:43 AM
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
	/// Encapsulates the 'ADefHelpDesk_Roles' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ADefHelpDeskRoles))]	
	[XmlType("ADefHelpDeskRoles")]
	public partial class ADefHelpDeskRoles : esADefHelpDeskRoles
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ADefHelpDeskRoles();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new ADefHelpDeskRoles();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new ADefHelpDeskRoles();
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
	[XmlType("ADefHelpDeskRolesCollection")]
	public partial class ADefHelpDeskRolesCollection : esADefHelpDeskRolesCollection, IEnumerable<ADefHelpDeskRoles>
	{
		public ADefHelpDeskRoles FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ADefHelpDeskRoles))]
		public class ADefHelpDeskRolesCollectionWCFPacket : esCollectionWCFPacket<ADefHelpDeskRolesCollection>
		{
			public static implicit operator ADefHelpDeskRolesCollection(ADefHelpDeskRolesCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ADefHelpDeskRolesCollectionWCFPacket(ADefHelpDeskRolesCollection collection)
			{
				return new ADefHelpDeskRolesCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ADefHelpDeskRolesQuery : esADefHelpDeskRolesQuery
	{
		public ADefHelpDeskRolesQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ADefHelpDeskRolesQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ADefHelpDeskRolesQuery query)
		{
			return ADefHelpDeskRolesQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ADefHelpDeskRolesQuery(string query)
		{
			return (ADefHelpDeskRolesQuery)ADefHelpDeskRolesQuery.SerializeHelper.FromXml(query, typeof(ADefHelpDeskRolesQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esADefHelpDeskRoles : esEntity
	{
		public esADefHelpDeskRoles()
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
			ADefHelpDeskRolesQuery query = new ADefHelpDeskRolesQuery();
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
		/// Maps to ADefHelpDesk_Roles.ID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskRolesMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskRolesMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(ADefHelpDeskRolesMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Roles.PortalID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? PortalID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskRolesMetadata.ColumnNames.PortalID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskRolesMetadata.ColumnNames.PortalID, value))
				{
					OnPropertyChanged(ADefHelpDeskRolesMetadata.PropertyNames.PortalID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Roles.RoleName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String RoleName
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskRolesMetadata.ColumnNames.RoleName);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskRolesMetadata.ColumnNames.RoleName, value))
				{
					OnPropertyChanged(ADefHelpDeskRolesMetadata.PropertyNames.RoleName);
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
						case "PortalID": this.str().PortalID = (string)value; break;							
						case "RoleName": this.str().RoleName = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int32)
								this.Id = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskRolesMetadata.PropertyNames.Id);
							break;
						
						case "PortalID":
						
							if (value == null || value is System.Int32)
								this.PortalID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskRolesMetadata.PropertyNames.PortalID);
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
			public esStrings(esADefHelpDeskRoles entity)
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
				
			public System.String PortalID
			{
				get
				{
					System.Int32? data = entity.PortalID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PortalID = null;
					else entity.PortalID = Convert.ToInt32(value);
				}
			}
				
			public System.String RoleName
			{
				get
				{
					System.String data = entity.RoleName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.RoleName = null;
					else entity.RoleName = Convert.ToString(value);
				}
			}
			

			private esADefHelpDeskRoles entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskRolesMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ADefHelpDeskRolesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskRolesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskRolesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ADefHelpDeskRolesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ADefHelpDeskRolesQuery query;		
	}



	[Serializable]
	abstract public partial class esADefHelpDeskRolesCollection : esEntityCollection<ADefHelpDeskRoles>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskRolesMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ADefHelpDeskRolesCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ADefHelpDeskRolesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskRolesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskRolesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ADefHelpDeskRolesQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ADefHelpDeskRolesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ADefHelpDeskRolesQuery)query);
		}

		#endregion
		
		private ADefHelpDeskRolesQuery query;
	}



	[Serializable]
	abstract public partial class esADefHelpDeskRolesQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskRolesMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "PortalID": return this.PortalID;
				case "RoleName": return this.RoleName;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, ADefHelpDeskRolesMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem PortalID
		{
			get { return new esQueryItem(this, ADefHelpDeskRolesMetadata.ColumnNames.PortalID, esSystemType.Int32); }
		} 
		
		public esQueryItem RoleName
		{
			get { return new esQueryItem(this, ADefHelpDeskRolesMetadata.ColumnNames.RoleName, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class ADefHelpDeskRoles : esADefHelpDeskRoles
	{

		#region ADefHelpDeskUserRolesCollectionByRoleID - Zero To Many
		
		static public esPrefetchMap Prefetch_ADefHelpDeskUserRolesCollectionByRoleID
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap();
				map.PrefetchDelegate = Rscm.Kencana.Helpdesk.BusinessObjects.ADefHelpDeskRoles.ADefHelpDeskUserRolesCollectionByRoleID_Delegate;
				map.PropertyName = "ADefHelpDeskUserRolesCollectionByRoleID";
				map.MyColumnName = "RoleID";
				map.ParentColumnName = "ID";
				map.IsMultiPartKey = false;
				return map;
			}
		}		
		
		static private void ADefHelpDeskUserRolesCollectionByRoleID_Delegate(esPrefetchParameters data)
		{
			ADefHelpDeskRolesQuery parent = new ADefHelpDeskRolesQuery(data.NextAlias());

			ADefHelpDeskUserRolesQuery me = data.You != null ? data.You as ADefHelpDeskUserRolesQuery : new ADefHelpDeskUserRolesQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.Id == me.RoleID);

			data.You = parent;
		}			
		
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_UserRoles_ADefHelpDesk_Roles
		/// </summary>

		[XmlIgnore]
		public ADefHelpDeskUserRolesCollection ADefHelpDeskUserRolesCollectionByRoleID
		{
			get
			{
				if(this._ADefHelpDeskUserRolesCollectionByRoleID == null)
				{
					this._ADefHelpDeskUserRolesCollectionByRoleID = new ADefHelpDeskUserRolesCollection();
					this._ADefHelpDeskUserRolesCollectionByRoleID.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("ADefHelpDeskUserRolesCollectionByRoleID", this._ADefHelpDeskUserRolesCollectionByRoleID);
				
					if (this.Id != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._ADefHelpDeskUserRolesCollectionByRoleID.Query.Where(this._ADefHelpDeskUserRolesCollectionByRoleID.Query.RoleID == this.Id);
							this._ADefHelpDeskUserRolesCollectionByRoleID.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._ADefHelpDeskUserRolesCollectionByRoleID.fks.Add(ADefHelpDeskUserRolesMetadata.ColumnNames.RoleID, this.Id);
					}
				}

				return this._ADefHelpDeskUserRolesCollectionByRoleID;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._ADefHelpDeskUserRolesCollectionByRoleID != null) 
				{ 
					this.RemovePostSave("ADefHelpDeskUserRolesCollectionByRoleID"); 
					this._ADefHelpDeskUserRolesCollectionByRoleID = null;
					
				} 
			} 			
		}
			
		
		private ADefHelpDeskUserRolesCollection _ADefHelpDeskUserRolesCollectionByRoleID;
		#endregion

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "ADefHelpDeskUserRolesCollectionByRoleID":
					coll = this.ADefHelpDeskUserRolesCollectionByRoleID;
					break;	
			}

			return coll;
		}		
		/// <summary>
		/// Used internally by the entity's hierarchical properties.
		/// </summary>
		protected override List<esPropertyDescriptor> GetHierarchicalProperties()
		{
			List<esPropertyDescriptor> props = new List<esPropertyDescriptor>();
			
			props.Add(new esPropertyDescriptor(this, "ADefHelpDeskUserRolesCollectionByRoleID", typeof(ADefHelpDeskUserRolesCollection), new ADefHelpDeskUserRoles()));
		
			return props;
		}
		
		/// <summary>
		/// Called by ApplyPostSaveKeys 
		/// </summary>
		/// <param name="coll">The collection to enumerate over</param>
		/// <param name="key">"The column name</param>
		/// <param name="value">The column value</param>
		private void Apply(esEntityCollectionBase coll, string key, object value)
		{
			foreach (esEntity obj in coll)
			{
				if (obj.es.IsAdded)
				{
					obj.SetProperty(key, value);
				}
			}
		}
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PostSave.
		/// </summary>
		protected override void ApplyPostSaveKeys()
		{
			if(this._ADefHelpDeskUserRolesCollectionByRoleID != null)
			{
				Apply(this._ADefHelpDeskUserRolesCollectionByRoleID, "RoleID", this.Id);
			}
		}
		
	}
	



	[Serializable]
	public partial class ADefHelpDeskRolesMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ADefHelpDeskRolesMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ADefHelpDeskRolesMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskRolesMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskRolesMetadata.ColumnNames.PortalID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskRolesMetadata.PropertyNames.PortalID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskRolesMetadata.ColumnNames.RoleName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskRolesMetadata.PropertyNames.RoleName;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ADefHelpDeskRolesMetadata Meta()
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
			 public const string PortalID = "PortalID";
			 public const string RoleName = "RoleName";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string PortalID = "PortalID";
			 public const string RoleName = "RoleName";
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
			lock (typeof(ADefHelpDeskRolesMetadata))
			{
				if(ADefHelpDeskRolesMetadata.mapDelegates == null)
				{
					ADefHelpDeskRolesMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ADefHelpDeskRolesMetadata.meta == null)
				{
					ADefHelpDeskRolesMetadata.meta = new ADefHelpDeskRolesMetadata();
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
				meta.AddTypeMap("PortalID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("RoleName", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "ADefHelpDesk_Roles";
				meta.Destination = "ADefHelpDesk_Roles";
				
				meta.spInsert = "proc_ADefHelpDesk_RolesInsert";				
				meta.spUpdate = "proc_ADefHelpDesk_RolesUpdate";		
				meta.spDelete = "proc_ADefHelpDesk_RolesDelete";
				meta.spLoadAll = "proc_ADefHelpDesk_RolesLoadAll";
				meta.spLoadByPrimaryKey = "proc_ADefHelpDesk_RolesLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ADefHelpDeskRolesMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
