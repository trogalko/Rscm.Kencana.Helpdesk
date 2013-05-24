
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
	/// Encapsulates the 'ADefHelpDesk_UserRoles' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ADefHelpDeskUserRoles))]	
	[XmlType("ADefHelpDeskUserRoles")]
	public partial class ADefHelpDeskUserRoles : esADefHelpDeskUserRoles
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ADefHelpDeskUserRoles();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 userRoleID)
		{
			var obj = new ADefHelpDeskUserRoles();
			obj.UserRoleID = userRoleID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 userRoleID, esSqlAccessType sqlAccessType)
		{
			var obj = new ADefHelpDeskUserRoles();
			obj.UserRoleID = userRoleID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("ADefHelpDeskUserRolesCollection")]
	public partial class ADefHelpDeskUserRolesCollection : esADefHelpDeskUserRolesCollection, IEnumerable<ADefHelpDeskUserRoles>
	{
		public ADefHelpDeskUserRoles FindByPrimaryKey(System.Int32 userRoleID)
		{
			return this.SingleOrDefault(e => e.UserRoleID == userRoleID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ADefHelpDeskUserRoles))]
		public class ADefHelpDeskUserRolesCollectionWCFPacket : esCollectionWCFPacket<ADefHelpDeskUserRolesCollection>
		{
			public static implicit operator ADefHelpDeskUserRolesCollection(ADefHelpDeskUserRolesCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ADefHelpDeskUserRolesCollectionWCFPacket(ADefHelpDeskUserRolesCollection collection)
			{
				return new ADefHelpDeskUserRolesCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ADefHelpDeskUserRolesQuery : esADefHelpDeskUserRolesQuery
	{
		public ADefHelpDeskUserRolesQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ADefHelpDeskUserRolesQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ADefHelpDeskUserRolesQuery query)
		{
			return ADefHelpDeskUserRolesQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ADefHelpDeskUserRolesQuery(string query)
		{
			return (ADefHelpDeskUserRolesQuery)ADefHelpDeskUserRolesQuery.SerializeHelper.FromXml(query, typeof(ADefHelpDeskUserRolesQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esADefHelpDeskUserRoles : esEntity
	{
		public esADefHelpDeskUserRoles()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 userRoleID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userRoleID);
			else
				return LoadByPrimaryKeyStoredProcedure(userRoleID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 userRoleID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(userRoleID);
			else
				return LoadByPrimaryKeyStoredProcedure(userRoleID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 userRoleID)
		{
			ADefHelpDeskUserRolesQuery query = new ADefHelpDeskUserRolesQuery();
			query.Where(query.UserRoleID == userRoleID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 userRoleID)
		{
			esParameters parms = new esParameters();
			parms.Add("UserRoleID", userRoleID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to ADefHelpDesk_UserRoles.UserRoleID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? UserRoleID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskUserRolesMetadata.ColumnNames.UserRoleID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskUserRolesMetadata.ColumnNames.UserRoleID, value))
				{
					OnPropertyChanged(ADefHelpDeskUserRolesMetadata.PropertyNames.UserRoleID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_UserRoles.UserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? UserID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskUserRolesMetadata.ColumnNames.UserID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskUserRolesMetadata.ColumnNames.UserID, value))
				{
					this._UpToADefHelpDeskUsersByUserID = null;
					this.OnPropertyChanged("UpToADefHelpDeskUsersByUserID");
					OnPropertyChanged(ADefHelpDeskUserRolesMetadata.PropertyNames.UserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_UserRoles.RoleID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? RoleID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskUserRolesMetadata.ColumnNames.RoleID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskUserRolesMetadata.ColumnNames.RoleID, value))
				{
					this._UpToADefHelpDeskRolesByRoleID = null;
					this.OnPropertyChanged("UpToADefHelpDeskRolesByRoleID");
					OnPropertyChanged(ADefHelpDeskUserRolesMetadata.PropertyNames.RoleID);
				}
			}
		}		
		
		[CLSCompliant(false)]
		internal protected ADefHelpDeskRoles _UpToADefHelpDeskRolesByRoleID;
		[CLSCompliant(false)]
		internal protected ADefHelpDeskUsers _UpToADefHelpDeskUsersByUserID;
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
						case "UserRoleID": this.str().UserRoleID = (string)value; break;							
						case "UserID": this.str().UserID = (string)value; break;							
						case "RoleID": this.str().RoleID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "UserRoleID":
						
							if (value == null || value is System.Int32)
								this.UserRoleID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskUserRolesMetadata.PropertyNames.UserRoleID);
							break;
						
						case "UserID":
						
							if (value == null || value is System.Int32)
								this.UserID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskUserRolesMetadata.PropertyNames.UserID);
							break;
						
						case "RoleID":
						
							if (value == null || value is System.Int32)
								this.RoleID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskUserRolesMetadata.PropertyNames.RoleID);
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
			public esStrings(esADefHelpDeskUserRoles entity)
			{
				this.entity = entity;
			}
			
	
			public System.String UserRoleID
			{
				get
				{
					System.Int32? data = entity.UserRoleID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UserRoleID = null;
					else entity.UserRoleID = Convert.ToInt32(value);
				}
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
				
			public System.String RoleID
			{
				get
				{
					System.Int32? data = entity.RoleID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.RoleID = null;
					else entity.RoleID = Convert.ToInt32(value);
				}
			}
			

			private esADefHelpDeskUserRoles entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskUserRolesMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ADefHelpDeskUserRolesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskUserRolesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskUserRolesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ADefHelpDeskUserRolesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ADefHelpDeskUserRolesQuery query;		
	}



	[Serializable]
	abstract public partial class esADefHelpDeskUserRolesCollection : esEntityCollection<ADefHelpDeskUserRoles>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskUserRolesMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ADefHelpDeskUserRolesCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ADefHelpDeskUserRolesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskUserRolesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskUserRolesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ADefHelpDeskUserRolesQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ADefHelpDeskUserRolesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ADefHelpDeskUserRolesQuery)query);
		}

		#endregion
		
		private ADefHelpDeskUserRolesQuery query;
	}



	[Serializable]
	abstract public partial class esADefHelpDeskUserRolesQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskUserRolesMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "UserRoleID": return this.UserRoleID;
				case "UserID": return this.UserID;
				case "RoleID": return this.RoleID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem UserRoleID
		{
			get { return new esQueryItem(this, ADefHelpDeskUserRolesMetadata.ColumnNames.UserRoleID, esSystemType.Int32); }
		} 
		
		public esQueryItem UserID
		{
			get { return new esQueryItem(this, ADefHelpDeskUserRolesMetadata.ColumnNames.UserID, esSystemType.Int32); }
		} 
		
		public esQueryItem RoleID
		{
			get { return new esQueryItem(this, ADefHelpDeskUserRolesMetadata.ColumnNames.RoleID, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class ADefHelpDeskUserRoles : esADefHelpDeskUserRoles
	{

				
		#region UpToADefHelpDeskRolesByRoleID - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_UserRoles_ADefHelpDesk_Roles
		/// </summary>

		[XmlIgnore]
					
		public ADefHelpDeskRoles UpToADefHelpDeskRolesByRoleID
		{
			get
			{
				if (this.es.IsLazyLoadDisabled) return null;
				
				if(this._UpToADefHelpDeskRolesByRoleID == null && RoleID != null)
				{
					this._UpToADefHelpDeskRolesByRoleID = new ADefHelpDeskRoles();
					this._UpToADefHelpDeskRolesByRoleID.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToADefHelpDeskRolesByRoleID", this._UpToADefHelpDeskRolesByRoleID);
					this._UpToADefHelpDeskRolesByRoleID.Query.Where(this._UpToADefHelpDeskRolesByRoleID.Query.Id == this.RoleID);
					this._UpToADefHelpDeskRolesByRoleID.Query.Load();
				}	
				return this._UpToADefHelpDeskRolesByRoleID;
			}
			
			set
			{
				this.RemovePreSave("UpToADefHelpDeskRolesByRoleID");
				

				if(value == null)
				{
					this.RoleID = null;
					this._UpToADefHelpDeskRolesByRoleID = null;
				}
				else
				{
					this.RoleID = value.Id;
					this._UpToADefHelpDeskRolesByRoleID = value;
					this.SetPreSave("UpToADefHelpDeskRolesByRoleID", this._UpToADefHelpDeskRolesByRoleID);
				}
				
			}
		}
		#endregion
		

				
		#region UpToADefHelpDeskUsersByUserID - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_ADefHelpDesk_UserRoles_ADefHelpDesk_Users
		/// </summary>

		[XmlIgnore]
					
		public ADefHelpDeskUsers UpToADefHelpDeskUsersByUserID
		{
			get
			{
				if (this.es.IsLazyLoadDisabled) return null;
				
				if(this._UpToADefHelpDeskUsersByUserID == null && UserID != null)
				{
					this._UpToADefHelpDeskUsersByUserID = new ADefHelpDeskUsers();
					this._UpToADefHelpDeskUsersByUserID.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToADefHelpDeskUsersByUserID", this._UpToADefHelpDeskUsersByUserID);
					this._UpToADefHelpDeskUsersByUserID.Query.Where(this._UpToADefHelpDeskUsersByUserID.Query.UserID == this.UserID);
					this._UpToADefHelpDeskUsersByUserID.Query.Load();
				}	
				return this._UpToADefHelpDeskUsersByUserID;
			}
			
			set
			{
				this.RemovePreSave("UpToADefHelpDeskUsersByUserID");
				

				if(value == null)
				{
					this.UserID = null;
					this._UpToADefHelpDeskUsersByUserID = null;
				}
				else
				{
					this.UserID = value.UserID;
					this._UpToADefHelpDeskUsersByUserID = value;
					this.SetPreSave("UpToADefHelpDeskUsersByUserID", this._UpToADefHelpDeskUsersByUserID);
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
			if(!this.es.IsDeleted && this._UpToADefHelpDeskRolesByRoleID != null)
			{
				this.RoleID = this._UpToADefHelpDeskRolesByRoleID.Id;
			}
			if(!this.es.IsDeleted && this._UpToADefHelpDeskUsersByUserID != null)
			{
				this.UserID = this._UpToADefHelpDeskUsersByUserID.UserID;
			}
		}
		
	}
	



	[Serializable]
	public partial class ADefHelpDeskUserRolesMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ADefHelpDeskUserRolesMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ADefHelpDeskUserRolesMetadata.ColumnNames.UserRoleID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskUserRolesMetadata.PropertyNames.UserRoleID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskUserRolesMetadata.ColumnNames.UserID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskUserRolesMetadata.PropertyNames.UserID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskUserRolesMetadata.ColumnNames.RoleID, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskUserRolesMetadata.PropertyNames.RoleID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ADefHelpDeskUserRolesMetadata Meta()
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
			 public const string UserRoleID = "UserRoleID";
			 public const string UserID = "UserID";
			 public const string RoleID = "RoleID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string UserRoleID = "UserRoleID";
			 public const string UserID = "UserID";
			 public const string RoleID = "RoleID";
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
			lock (typeof(ADefHelpDeskUserRolesMetadata))
			{
				if(ADefHelpDeskUserRolesMetadata.mapDelegates == null)
				{
					ADefHelpDeskUserRolesMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ADefHelpDeskUserRolesMetadata.meta == null)
				{
					ADefHelpDeskUserRolesMetadata.meta = new ADefHelpDeskUserRolesMetadata();
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


				meta.AddTypeMap("UserRoleID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("UserID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("RoleID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "ADefHelpDesk_UserRoles";
				meta.Destination = "ADefHelpDesk_UserRoles";
				
				meta.spInsert = "proc_ADefHelpDesk_UserRolesInsert";				
				meta.spUpdate = "proc_ADefHelpDesk_UserRolesUpdate";		
				meta.spDelete = "proc_ADefHelpDesk_UserRolesDelete";
				meta.spLoadAll = "proc_ADefHelpDesk_UserRolesLoadAll";
				meta.spLoadByPrimaryKey = "proc_ADefHelpDesk_UserRolesLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ADefHelpDeskUserRolesMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
