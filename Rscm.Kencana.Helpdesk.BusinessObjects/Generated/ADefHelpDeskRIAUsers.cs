
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
	/// Encapsulates the 'ADefHelpDesk_RIAUsers' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ADefHelpDeskRIAUsers))]	
	[XmlType("ADefHelpDeskRIAUsers")]
	public partial class ADefHelpDeskRIAUsers : esADefHelpDeskRIAUsers
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ADefHelpDeskRIAUsers();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 userID)
		{
			var obj = new ADefHelpDeskRIAUsers();
			obj.UserID = userID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 userID, esSqlAccessType sqlAccessType)
		{
			var obj = new ADefHelpDeskRIAUsers();
			obj.UserID = userID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("ADefHelpDeskRIAUsersCollection")]
	public partial class ADefHelpDeskRIAUsersCollection : esADefHelpDeskRIAUsersCollection, IEnumerable<ADefHelpDeskRIAUsers>
	{
		public ADefHelpDeskRIAUsers FindByPrimaryKey(System.Int32 userID)
		{
			return this.SingleOrDefault(e => e.UserID == userID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ADefHelpDeskRIAUsers))]
		public class ADefHelpDeskRIAUsersCollectionWCFPacket : esCollectionWCFPacket<ADefHelpDeskRIAUsersCollection>
		{
			public static implicit operator ADefHelpDeskRIAUsersCollection(ADefHelpDeskRIAUsersCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ADefHelpDeskRIAUsersCollectionWCFPacket(ADefHelpDeskRIAUsersCollection collection)
			{
				return new ADefHelpDeskRIAUsersCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ADefHelpDeskRIAUsersQuery : esADefHelpDeskRIAUsersQuery
	{
		public ADefHelpDeskRIAUsersQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ADefHelpDeskRIAUsersQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ADefHelpDeskRIAUsersQuery query)
		{
			return ADefHelpDeskRIAUsersQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ADefHelpDeskRIAUsersQuery(string query)
		{
			return (ADefHelpDeskRIAUsersQuery)ADefHelpDeskRIAUsersQuery.SerializeHelper.FromXml(query, typeof(ADefHelpDeskRIAUsersQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esADefHelpDeskRIAUsers : esEntity
	{
		public esADefHelpDeskRIAUsers()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 userID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userID);
			else
				return LoadByPrimaryKeyStoredProcedure(userID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 userID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userID);
			else
				return LoadByPrimaryKeyStoredProcedure(userID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 userID)
		{
			ADefHelpDeskRIAUsersQuery query = new ADefHelpDeskRIAUsersQuery();
			query.Where(query.UserID == userID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 userID)
		{
			esParameters parms = new esParameters();
			parms.Add("UserID", userID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to ADefHelpDesk_RIAUsers.UserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? UserID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskRIAUsersMetadata.ColumnNames.UserID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskRIAUsersMetadata.ColumnNames.UserID, value))
				{
					OnPropertyChanged(ADefHelpDeskRIAUsersMetadata.PropertyNames.UserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_RIAUsers.RIAPassword
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String RIAPassword
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskRIAUsersMetadata.ColumnNames.RIAPassword);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskRIAUsersMetadata.ColumnNames.RIAPassword, value))
				{
					OnPropertyChanged(ADefHelpDeskRIAUsersMetadata.PropertyNames.RIAPassword);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_RIAUsers.IPAddress
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String IPAddress
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskRIAUsersMetadata.ColumnNames.IPAddress);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskRIAUsersMetadata.ColumnNames.IPAddress, value))
				{
					OnPropertyChanged(ADefHelpDeskRIAUsersMetadata.PropertyNames.IPAddress);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_RIAUsers.CreatedDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreatedDate
		{
			get
			{
				return base.GetSystemDateTime(ADefHelpDeskRIAUsersMetadata.ColumnNames.CreatedDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ADefHelpDeskRIAUsersMetadata.ColumnNames.CreatedDate, value))
				{
					OnPropertyChanged(ADefHelpDeskRIAUsersMetadata.PropertyNames.CreatedDate);
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
						case "RIAPassword": this.str().RIAPassword = (string)value; break;							
						case "IPAddress": this.str().IPAddress = (string)value; break;							
						case "CreatedDate": this.str().CreatedDate = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "UserID":
						
							if (value == null || value is System.Int32)
								this.UserID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskRIAUsersMetadata.PropertyNames.UserID);
							break;
						
						case "CreatedDate":
						
							if (value == null || value is System.DateTime)
								this.CreatedDate = (System.DateTime?)value;
								OnPropertyChanged(ADefHelpDeskRIAUsersMetadata.PropertyNames.CreatedDate);
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
			public esStrings(esADefHelpDeskRIAUsers entity)
			{
				this.entity = entity;
			}
			
	
			public System.String UserID
			{
				get
				{
					System.Int32? data = entity.UserID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UserID = null;
					else entity.UserID = Convert.ToInt32(value);
				}
			}
				
			public System.String RIAPassword
			{
				get
				{
					System.String data = entity.RIAPassword;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.RIAPassword = null;
					else entity.RIAPassword = Convert.ToString(value);
				}
			}
				
			public System.String IPAddress
			{
				get
				{
					System.String data = entity.IPAddress;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IPAddress = null;
					else entity.IPAddress = Convert.ToString(value);
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
			

			private esADefHelpDeskRIAUsers entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskRIAUsersMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ADefHelpDeskRIAUsersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskRIAUsersQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskRIAUsersQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ADefHelpDeskRIAUsersQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ADefHelpDeskRIAUsersQuery query;		
	}



	[Serializable]
	abstract public partial class esADefHelpDeskRIAUsersCollection : esEntityCollection<ADefHelpDeskRIAUsers>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskRIAUsersMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ADefHelpDeskRIAUsersCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ADefHelpDeskRIAUsersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskRIAUsersQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskRIAUsersQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ADefHelpDeskRIAUsersQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ADefHelpDeskRIAUsersQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ADefHelpDeskRIAUsersQuery)query);
		}

		#endregion
		
		private ADefHelpDeskRIAUsersQuery query;
	}



	[Serializable]
	abstract public partial class esADefHelpDeskRIAUsersQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskRIAUsersMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "UserID": return this.UserID;
				case "RIAPassword": return this.RIAPassword;
				case "IPAddress": return this.IPAddress;
				case "CreatedDate": return this.CreatedDate;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem UserID
		{
			get { return new esQueryItem(this, ADefHelpDeskRIAUsersMetadata.ColumnNames.UserID, esSystemType.Int32); }
		} 
		
		public esQueryItem RIAPassword
		{
			get { return new esQueryItem(this, ADefHelpDeskRIAUsersMetadata.ColumnNames.RIAPassword, esSystemType.String); }
		} 
		
		public esQueryItem IPAddress
		{
			get { return new esQueryItem(this, ADefHelpDeskRIAUsersMetadata.ColumnNames.IPAddress, esSystemType.String); }
		} 
		
		public esQueryItem CreatedDate
		{
			get { return new esQueryItem(this, ADefHelpDeskRIAUsersMetadata.ColumnNames.CreatedDate, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class ADefHelpDeskRIAUsers : esADefHelpDeskRIAUsers
	{

		
		
	}
	



	[Serializable]
	public partial class ADefHelpDeskRIAUsersMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ADefHelpDeskRIAUsersMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ADefHelpDeskRIAUsersMetadata.ColumnNames.UserID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskRIAUsersMetadata.PropertyNames.UserID;
			c.IsInPrimaryKey = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskRIAUsersMetadata.ColumnNames.RIAPassword, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskRIAUsersMetadata.PropertyNames.RIAPassword;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskRIAUsersMetadata.ColumnNames.IPAddress, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskRIAUsersMetadata.PropertyNames.IPAddress;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskRIAUsersMetadata.ColumnNames.CreatedDate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ADefHelpDeskRIAUsersMetadata.PropertyNames.CreatedDate;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ADefHelpDeskRIAUsersMetadata Meta()
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
			 public const string RIAPassword = "RIAPassword";
			 public const string IPAddress = "IPAddress";
			 public const string CreatedDate = "CreatedDate";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string UserID = "UserID";
			 public const string RIAPassword = "RIAPassword";
			 public const string IPAddress = "IPAddress";
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
			lock (typeof(ADefHelpDeskRIAUsersMetadata))
			{
				if(ADefHelpDeskRIAUsersMetadata.mapDelegates == null)
				{
					ADefHelpDeskRIAUsersMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ADefHelpDeskRIAUsersMetadata.meta == null)
				{
					ADefHelpDeskRIAUsersMetadata.meta = new ADefHelpDeskRIAUsersMetadata();
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


				meta.AddTypeMap("UserID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("RIAPassword", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("IPAddress", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("CreatedDate", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "ADefHelpDesk_RIAUsers";
				meta.Destination = "ADefHelpDesk_RIAUsers";
				
				meta.spInsert = "proc_ADefHelpDesk_RIAUsersInsert";				
				meta.spUpdate = "proc_ADefHelpDesk_RIAUsersUpdate";		
				meta.spDelete = "proc_ADefHelpDesk_RIAUsersDelete";
				meta.spLoadAll = "proc_ADefHelpDesk_RIAUsersLoadAll";
				meta.spLoadByPrimaryKey = "proc_ADefHelpDesk_RIAUsersLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ADefHelpDeskRIAUsersMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
