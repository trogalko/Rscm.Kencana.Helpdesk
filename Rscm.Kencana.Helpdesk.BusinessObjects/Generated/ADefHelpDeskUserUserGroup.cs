
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 6/17/2013 3:22:35 PM
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
	/// Encapsulates the 'ADefHelpDesk_UserUserGroup' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ADefHelpDeskUserUserGroup))]	
	[XmlType("ADefHelpDeskUserUserGroup")]
	public partial class ADefHelpDeskUserUserGroup : esADefHelpDeskUserUserGroup
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ADefHelpDeskUserUserGroup();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String userID, System.String userServiceUnitID)
		{
			var obj = new ADefHelpDeskUserUserGroup();
			obj.UserID = userID;
			obj.UserServiceUnitID = userServiceUnitID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String userID, System.String userServiceUnitID, esSqlAccessType sqlAccessType)
		{
			var obj = new ADefHelpDeskUserUserGroup();
			obj.UserID = userID;
			obj.UserServiceUnitID = userServiceUnitID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("ADefHelpDeskUserUserGroupCollection")]
	public partial class ADefHelpDeskUserUserGroupCollection : esADefHelpDeskUserUserGroupCollection, IEnumerable<ADefHelpDeskUserUserGroup>
	{
		public ADefHelpDeskUserUserGroup FindByPrimaryKey(System.String userID, System.String userServiceUnitID)
		{
			return this.SingleOrDefault(e => e.UserID == userID && e.UserServiceUnitID == userServiceUnitID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ADefHelpDeskUserUserGroup))]
		public class ADefHelpDeskUserUserGroupCollectionWCFPacket : esCollectionWCFPacket<ADefHelpDeskUserUserGroupCollection>
		{
			public static implicit operator ADefHelpDeskUserUserGroupCollection(ADefHelpDeskUserUserGroupCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ADefHelpDeskUserUserGroupCollectionWCFPacket(ADefHelpDeskUserUserGroupCollection collection)
			{
				return new ADefHelpDeskUserUserGroupCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ADefHelpDeskUserUserGroupQuery : esADefHelpDeskUserUserGroupQuery
	{
		public ADefHelpDeskUserUserGroupQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ADefHelpDeskUserUserGroupQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ADefHelpDeskUserUserGroupQuery query)
		{
			return ADefHelpDeskUserUserGroupQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ADefHelpDeskUserUserGroupQuery(string query)
		{
			return (ADefHelpDeskUserUserGroupQuery)ADefHelpDeskUserUserGroupQuery.SerializeHelper.FromXml(query, typeof(ADefHelpDeskUserUserGroupQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esADefHelpDeskUserUserGroup : esEntity
	{
		public esADefHelpDeskUserUserGroup()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String userID, System.String userServiceUnitID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userID, userServiceUnitID);
			else
				return LoadByPrimaryKeyStoredProcedure(userID, userServiceUnitID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String userID, System.String userServiceUnitID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userID, userServiceUnitID);
			else
				return LoadByPrimaryKeyStoredProcedure(userID, userServiceUnitID);
		}

		private bool LoadByPrimaryKeyDynamic(System.String userID, System.String userServiceUnitID)
		{
			ADefHelpDeskUserUserGroupQuery query = new ADefHelpDeskUserUserGroupQuery();
			query.Where(query.UserID == userID, query.UserServiceUnitID == userServiceUnitID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String userID, System.String userServiceUnitID)
		{
			esParameters parms = new esParameters();
			parms.Add("UserID", userID);			parms.Add("UserServiceUnitID", userServiceUnitID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to ADefHelpDesk_UserUserGroup.UserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserID
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskUserUserGroupMetadata.ColumnNames.UserID);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskUserUserGroupMetadata.ColumnNames.UserID, value))
				{
					OnPropertyChanged(ADefHelpDeskUserUserGroupMetadata.PropertyNames.UserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_UserUserGroup.UserServiceUnitID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String UserServiceUnitID
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskUserUserGroupMetadata.ColumnNames.UserServiceUnitID);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskUserUserGroupMetadata.ColumnNames.UserServiceUnitID, value))
				{
					OnPropertyChanged(ADefHelpDeskUserUserGroupMetadata.PropertyNames.UserServiceUnitID);
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
						case "UserID": this.str().UserID = (string)value; break;							
						case "UserServiceUnitID": this.str().UserServiceUnitID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{

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
			public esStrings(esADefHelpDeskUserUserGroup entity)
			{
				this.entity = entity;
			}
			
	
			public System.String UserID
			{
				get
				{
					System.String data = entity.UserID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UserID = null;
					else entity.UserID = Convert.ToString(value);
				}
			}
				
			public System.String UserServiceUnitID
			{
				get
				{
					System.String data = entity.UserServiceUnitID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UserServiceUnitID = null;
					else entity.UserServiceUnitID = Convert.ToString(value);
				}
			}
			

			private esADefHelpDeskUserUserGroup entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskUserUserGroupMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ADefHelpDeskUserUserGroupQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskUserUserGroupQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskUserUserGroupQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ADefHelpDeskUserUserGroupQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ADefHelpDeskUserUserGroupQuery query;		
	}



	[Serializable]
	abstract public partial class esADefHelpDeskUserUserGroupCollection : esEntityCollection<ADefHelpDeskUserUserGroup>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskUserUserGroupMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ADefHelpDeskUserUserGroupCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ADefHelpDeskUserUserGroupQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskUserUserGroupQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskUserUserGroupQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ADefHelpDeskUserUserGroupQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ADefHelpDeskUserUserGroupQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ADefHelpDeskUserUserGroupQuery)query);
		}

		#endregion
		
		private ADefHelpDeskUserUserGroupQuery query;
	}



	[Serializable]
	abstract public partial class esADefHelpDeskUserUserGroupQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskUserUserGroupMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "UserID": return this.UserID;
				case "UserServiceUnitID": return this.UserServiceUnitID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem UserID
		{
			get { return new esQueryItem(this, ADefHelpDeskUserUserGroupMetadata.ColumnNames.UserID, esSystemType.String); }
		} 
		
		public esQueryItem UserServiceUnitID
		{
			get { return new esQueryItem(this, ADefHelpDeskUserUserGroupMetadata.ColumnNames.UserServiceUnitID, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class ADefHelpDeskUserUserGroup : esADefHelpDeskUserUserGroup
	{

		
		
	}
	



	[Serializable]
	public partial class ADefHelpDeskUserUserGroupMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ADefHelpDeskUserUserGroupMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ADefHelpDeskUserUserGroupMetadata.ColumnNames.UserID, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskUserUserGroupMetadata.PropertyNames.UserID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskUserUserGroupMetadata.ColumnNames.UserServiceUnitID, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskUserUserGroupMetadata.PropertyNames.UserServiceUnitID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 5;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ADefHelpDeskUserUserGroupMetadata Meta()
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
			 public const string UserID = "UserID";
			 public const string UserServiceUnitID = "UserServiceUnitID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string UserID = "UserID";
			 public const string UserServiceUnitID = "UserServiceUnitID";
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
			lock (typeof(ADefHelpDeskUserUserGroupMetadata))
			{
				if(ADefHelpDeskUserUserGroupMetadata.mapDelegates == null)
				{
					ADefHelpDeskUserUserGroupMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ADefHelpDeskUserUserGroupMetadata.meta == null)
				{
					ADefHelpDeskUserUserGroupMetadata.meta = new ADefHelpDeskUserUserGroupMetadata();
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


				meta.AddTypeMap("UserID", new esTypeMap("varchar", "System.String"));
				meta.AddTypeMap("UserServiceUnitID", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "ADefHelpDesk_UserUserGroup";
				meta.Destination = "ADefHelpDesk_UserUserGroup";
				
				meta.spInsert = "proc_ADefHelpDesk_UserUserGroupInsert";				
				meta.spUpdate = "proc_ADefHelpDesk_UserUserGroupUpdate";		
				meta.spDelete = "proc_ADefHelpDesk_UserUserGroupDelete";
				meta.spLoadAll = "proc_ADefHelpDesk_UserUserGroupLoadAll";
				meta.spLoadByPrimaryKey = "proc_ADefHelpDesk_UserUserGroupLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ADefHelpDeskUserUserGroupMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
