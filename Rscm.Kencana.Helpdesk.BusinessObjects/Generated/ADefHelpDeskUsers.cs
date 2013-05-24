
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
	/// Encapsulates the 'ADefHelpDesk_Users' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ADefHelpDeskUsers))]	
	[XmlType("ADefHelpDeskUsers")]
	public partial class ADefHelpDeskUsers : esADefHelpDeskUsers
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ADefHelpDeskUsers();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 userID)
		{
			var obj = new ADefHelpDeskUsers();
			obj.UserID = userID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 userID, esSqlAccessType sqlAccessType)
		{
			var obj = new ADefHelpDeskUsers();
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
	[XmlType("ADefHelpDeskUsersCollection")]
	public partial class ADefHelpDeskUsersCollection : esADefHelpDeskUsersCollection, IEnumerable<ADefHelpDeskUsers>
	{
		public ADefHelpDeskUsers FindByPrimaryKey(System.Int32 userID)
		{
			return this.SingleOrDefault(e => e.UserID == userID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ADefHelpDeskUsers))]
		public class ADefHelpDeskUsersCollectionWCFPacket : esCollectionWCFPacket<ADefHelpDeskUsersCollection>
		{
			public static implicit operator ADefHelpDeskUsersCollection(ADefHelpDeskUsersCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ADefHelpDeskUsersCollectionWCFPacket(ADefHelpDeskUsersCollection collection)
			{
				return new ADefHelpDeskUsersCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ADefHelpDeskUsersQuery : esADefHelpDeskUsersQuery
	{
		public ADefHelpDeskUsersQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ADefHelpDeskUsersQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ADefHelpDeskUsersQuery query)
		{
			return ADefHelpDeskUsersQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ADefHelpDeskUsersQuery(string query)
		{
			return (ADefHelpDeskUsersQuery)ADefHelpDeskUsersQuery.SerializeHelper.FromXml(query, typeof(ADefHelpDeskUsersQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esADefHelpDeskUsers : esEntity
	{
		public esADefHelpDeskUsers()
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
			ADefHelpDeskUsersQuery query = new ADefHelpDeskUsersQuery();
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
		/// Maps to ADefHelpDesk_Users.UserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? UserID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskUsersMetadata.ColumnNames.UserID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskUsersMetadata.ColumnNames.UserID, value))
				{
					OnPropertyChanged(ADefHelpDeskUsersMetadata.PropertyNames.UserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Users.Username
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Username
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskUsersMetadata.ColumnNames.Username);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskUsersMetadata.ColumnNames.Username, value))
				{
					OnPropertyChanged(ADefHelpDeskUsersMetadata.PropertyNames.Username);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Users.FirstName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FirstName
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskUsersMetadata.ColumnNames.FirstName);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskUsersMetadata.ColumnNames.FirstName, value))
				{
					OnPropertyChanged(ADefHelpDeskUsersMetadata.PropertyNames.FirstName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Users.LastName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LastName
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskUsersMetadata.ColumnNames.LastName);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskUsersMetadata.ColumnNames.LastName, value))
				{
					OnPropertyChanged(ADefHelpDeskUsersMetadata.PropertyNames.LastName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Users.IsSuperUser
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsSuperUser
		{
			get
			{
				return base.GetSystemBoolean(ADefHelpDeskUsersMetadata.ColumnNames.IsSuperUser);
			}
			
			set
			{
				if(base.SetSystemBoolean(ADefHelpDeskUsersMetadata.ColumnNames.IsSuperUser, value))
				{
					OnPropertyChanged(ADefHelpDeskUsersMetadata.PropertyNames.IsSuperUser);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Users.Email
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Email
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskUsersMetadata.ColumnNames.Email);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskUsersMetadata.ColumnNames.Email, value))
				{
					OnPropertyChanged(ADefHelpDeskUsersMetadata.PropertyNames.Email);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Users.Password
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Password
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskUsersMetadata.ColumnNames.Password);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskUsersMetadata.ColumnNames.Password, value))
				{
					OnPropertyChanged(ADefHelpDeskUsersMetadata.PropertyNames.Password);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Users.RIAPassword
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String RIAPassword
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskUsersMetadata.ColumnNames.RIAPassword);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskUsersMetadata.ColumnNames.RIAPassword, value))
				{
					OnPropertyChanged(ADefHelpDeskUsersMetadata.PropertyNames.RIAPassword);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Users.VerificationCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String VerificationCode
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskUsersMetadata.ColumnNames.VerificationCode);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskUsersMetadata.ColumnNames.VerificationCode, value))
				{
					OnPropertyChanged(ADefHelpDeskUsersMetadata.PropertyNames.VerificationCode);
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
						case "Username": this.str().Username = (string)value; break;							
						case "FirstName": this.str().FirstName = (string)value; break;							
						case "LastName": this.str().LastName = (string)value; break;							
						case "IsSuperUser": this.str().IsSuperUser = (string)value; break;							
						case "Email": this.str().Email = (string)value; break;							
						case "Password": this.str().Password = (string)value; break;							
						case "RIAPassword": this.str().RIAPassword = (string)value; break;							
						case "VerificationCode": this.str().VerificationCode = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "UserID":
						
							if (value == null || value is System.Int32)
								this.UserID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskUsersMetadata.PropertyNames.UserID);
							break;
						
						case "IsSuperUser":
						
							if (value == null || value is System.Boolean)
								this.IsSuperUser = (System.Boolean?)value;
								OnPropertyChanged(ADefHelpDeskUsersMetadata.PropertyNames.IsSuperUser);
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
			public esStrings(esADefHelpDeskUsers entity)
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
				
			public System.String Username
			{
				get
				{
					System.String data = entity.Username;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Username = null;
					else entity.Username = Convert.ToString(value);
				}
			}
				
			public System.String FirstName
			{
				get
				{
					System.String data = entity.FirstName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FirstName = null;
					else entity.FirstName = Convert.ToString(value);
				}
			}
				
			public System.String LastName
			{
				get
				{
					System.String data = entity.LastName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LastName = null;
					else entity.LastName = Convert.ToString(value);
				}
			}
				
			public System.String IsSuperUser
			{
				get
				{
					System.Boolean? data = entity.IsSuperUser;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsSuperUser = null;
					else entity.IsSuperUser = Convert.ToBoolean(value);
				}
			}
				
			public System.String Email
			{
				get
				{
					System.String data = entity.Email;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Email = null;
					else entity.Email = Convert.ToString(value);
				}
			}
				
			public System.String Password
			{
				get
				{
					System.String data = entity.Password;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Password = null;
					else entity.Password = Convert.ToString(value);
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
				
			public System.String VerificationCode
			{
				get
				{
					System.String data = entity.VerificationCode;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.VerificationCode = null;
					else entity.VerificationCode = Convert.ToString(value);
				}
			}
			

			private esADefHelpDeskUsers entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskUsersMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ADefHelpDeskUsersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskUsersQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskUsersQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ADefHelpDeskUsersQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ADefHelpDeskUsersQuery query;		
	}



	[Serializable]
	abstract public partial class esADefHelpDeskUsersCollection : esEntityCollection<ADefHelpDeskUsers>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskUsersMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ADefHelpDeskUsersCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ADefHelpDeskUsersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskUsersQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskUsersQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ADefHelpDeskUsersQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ADefHelpDeskUsersQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ADefHelpDeskUsersQuery)query);
		}

		#endregion
		
		private ADefHelpDeskUsersQuery query;
	}



	[Serializable]
	abstract public partial class esADefHelpDeskUsersQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskUsersMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "UserID": return this.UserID;
				case "Username": return this.Username;
				case "FirstName": return this.FirstName;
				case "LastName": return this.LastName;
				case "IsSuperUser": return this.IsSuperUser;
				case "Email": return this.Email;
				case "Password": return this.Password;
				case "RIAPassword": return this.RIAPassword;
				case "VerificationCode": return this.VerificationCode;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem UserID
		{
			get { return new esQueryItem(this, ADefHelpDeskUsersMetadata.ColumnNames.UserID, esSystemType.Int32); }
		} 
		
		public esQueryItem Username
		{
			get { return new esQueryItem(this, ADefHelpDeskUsersMetadata.ColumnNames.Username, esSystemType.String); }
		} 
		
		public esQueryItem FirstName
		{
			get { return new esQueryItem(this, ADefHelpDeskUsersMetadata.ColumnNames.FirstName, esSystemType.String); }
		} 
		
		public esQueryItem LastName
		{
			get { return new esQueryItem(this, ADefHelpDeskUsersMetadata.ColumnNames.LastName, esSystemType.String); }
		} 
		
		public esQueryItem IsSuperUser
		{
			get { return new esQueryItem(this, ADefHelpDeskUsersMetadata.ColumnNames.IsSuperUser, esSystemType.Boolean); }
		} 
		
		public esQueryItem Email
		{
			get { return new esQueryItem(this, ADefHelpDeskUsersMetadata.ColumnNames.Email, esSystemType.String); }
		} 
		
		public esQueryItem Password
		{
			get { return new esQueryItem(this, ADefHelpDeskUsersMetadata.ColumnNames.Password, esSystemType.String); }
		} 
		
		public esQueryItem RIAPassword
		{
			get { return new esQueryItem(this, ADefHelpDeskUsersMetadata.ColumnNames.RIAPassword, esSystemType.String); }
		} 
		
		public esQueryItem VerificationCode
		{
			get { return new esQueryItem(this, ADefHelpDeskUsersMetadata.ColumnNames.VerificationCode, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class ADefHelpDeskUsers : esADefHelpDeskUsers
	{

		#region ADefHelpDeskUserRolesCollectionByUserID - Zero To Many
		
		static public esPrefetchMap Prefetch_ADefHelpDeskUserRolesCollectionByUserID
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap();
				map.PrefetchDelegate = Rscm.Kencana.Helpdesk.BusinessObjects.ADefHelpDeskUsers.ADefHelpDeskUserRolesCollectionByUserID_Delegate;
				map.PropertyName = "ADefHelpDeskUserRolesCollectionByUserID";
				map.MyColumnName = "UserID";
				map.ParentColumnName = "UserID";
				map.IsMultiPartKey = false;
				return map;
			}
		}		
		
		static private void ADefHelpDeskUserRolesCollectionByUserID_Delegate(esPrefetchParameters data)
		{
			ADefHelpDeskUsersQuery parent = new ADefHelpDeskUsersQuery(data.NextAlias());

			ADefHelpDeskUserRolesQuery me = data.You != null ? data.You as ADefHelpDeskUserRolesQuery : new ADefHelpDeskUserRolesQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.UserID == me.UserID);

			data.You = parent;
		}			
		
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_ADefHelpDesk_UserRoles_ADefHelpDesk_Users
		/// </summary>

		[XmlIgnore]
		public ADefHelpDeskUserRolesCollection ADefHelpDeskUserRolesCollectionByUserID
		{
			get
			{
				if(this._ADefHelpDeskUserRolesCollectionByUserID == null)
				{
					this._ADefHelpDeskUserRolesCollectionByUserID = new ADefHelpDeskUserRolesCollection();
					this._ADefHelpDeskUserRolesCollectionByUserID.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("ADefHelpDeskUserRolesCollectionByUserID", this._ADefHelpDeskUserRolesCollectionByUserID);
				
					if (this.UserID != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._ADefHelpDeskUserRolesCollectionByUserID.Query.Where(this._ADefHelpDeskUserRolesCollectionByUserID.Query.UserID == this.UserID);
							this._ADefHelpDeskUserRolesCollectionByUserID.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._ADefHelpDeskUserRolesCollectionByUserID.fks.Add(ADefHelpDeskUserRolesMetadata.ColumnNames.UserID, this.UserID);
					}
				}

				return this._ADefHelpDeskUserRolesCollectionByUserID;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._ADefHelpDeskUserRolesCollectionByUserID != null) 
				{ 
					this.RemovePostSave("ADefHelpDeskUserRolesCollectionByUserID"); 
					this._ADefHelpDeskUserRolesCollectionByUserID = null;
					
				} 
			} 			
		}
			
		
		private ADefHelpDeskUserRolesCollection _ADefHelpDeskUserRolesCollectionByUserID;
		#endregion

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "ADefHelpDeskUserRolesCollectionByUserID":
					coll = this.ADefHelpDeskUserRolesCollectionByUserID;
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
			
			props.Add(new esPropertyDescriptor(this, "ADefHelpDeskUserRolesCollectionByUserID", typeof(ADefHelpDeskUserRolesCollection), new ADefHelpDeskUserRoles()));
		
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
			if(this._ADefHelpDeskUserRolesCollectionByUserID != null)
			{
				Apply(this._ADefHelpDeskUserRolesCollectionByUserID, "UserID", this.UserID);
			}
		}
		
	}
	



	[Serializable]
	public partial class ADefHelpDeskUsersMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ADefHelpDeskUsersMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ADefHelpDeskUsersMetadata.ColumnNames.UserID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskUsersMetadata.PropertyNames.UserID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskUsersMetadata.ColumnNames.Username, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskUsersMetadata.PropertyNames.Username;
			c.CharacterMaxLength = 100;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskUsersMetadata.ColumnNames.FirstName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskUsersMetadata.PropertyNames.FirstName;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskUsersMetadata.ColumnNames.LastName, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskUsersMetadata.PropertyNames.LastName;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskUsersMetadata.ColumnNames.IsSuperUser, 4, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ADefHelpDeskUsersMetadata.PropertyNames.IsSuperUser;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskUsersMetadata.ColumnNames.Email, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskUsersMetadata.PropertyNames.Email;
			c.CharacterMaxLength = 256;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskUsersMetadata.ColumnNames.Password, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskUsersMetadata.PropertyNames.Password;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskUsersMetadata.ColumnNames.RIAPassword, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskUsersMetadata.PropertyNames.RIAPassword;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskUsersMetadata.ColumnNames.VerificationCode, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskUsersMetadata.PropertyNames.VerificationCode;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ADefHelpDeskUsersMetadata Meta()
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
			 public const string Username = "Username";
			 public const string FirstName = "FirstName";
			 public const string LastName = "LastName";
			 public const string IsSuperUser = "IsSuperUser";
			 public const string Email = "Email";
			 public const string Password = "Password";
			 public const string RIAPassword = "RIAPassword";
			 public const string VerificationCode = "VerificationCode";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string UserID = "UserID";
			 public const string Username = "Username";
			 public const string FirstName = "FirstName";
			 public const string LastName = "LastName";
			 public const string IsSuperUser = "IsSuperUser";
			 public const string Email = "Email";
			 public const string Password = "Password";
			 public const string RIAPassword = "RIAPassword";
			 public const string VerificationCode = "VerificationCode";
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
			lock (typeof(ADefHelpDeskUsersMetadata))
			{
				if(ADefHelpDeskUsersMetadata.mapDelegates == null)
				{
					ADefHelpDeskUsersMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ADefHelpDeskUsersMetadata.meta == null)
				{
					ADefHelpDeskUsersMetadata.meta = new ADefHelpDeskUsersMetadata();
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
				meta.AddTypeMap("Username", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("FirstName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("LastName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("IsSuperUser", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Email", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Password", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("RIAPassword", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("VerificationCode", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "ADefHelpDesk_Users";
				meta.Destination = "ADefHelpDesk_Users";
				
				meta.spInsert = "proc_ADefHelpDesk_UsersInsert";				
				meta.spUpdate = "proc_ADefHelpDesk_UsersUpdate";		
				meta.spDelete = "proc_ADefHelpDesk_UsersDelete";
				meta.spLoadAll = "proc_ADefHelpDesk_UsersLoadAll";
				meta.spLoadByPrimaryKey = "proc_ADefHelpDesk_UsersLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ADefHelpDeskUsersMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
