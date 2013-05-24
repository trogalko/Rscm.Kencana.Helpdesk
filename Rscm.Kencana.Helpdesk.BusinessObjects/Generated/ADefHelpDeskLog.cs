
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
	/// Encapsulates the 'ADefHelpDesk_Log' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ADefHelpDeskLog))]	
	[XmlType("ADefHelpDeskLog")]
	public partial class ADefHelpDeskLog : esADefHelpDeskLog
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ADefHelpDeskLog();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 logID)
		{
			var obj = new ADefHelpDeskLog();
			obj.LogID = logID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 logID, esSqlAccessType sqlAccessType)
		{
			var obj = new ADefHelpDeskLog();
			obj.LogID = logID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("ADefHelpDeskLogCollection")]
	public partial class ADefHelpDeskLogCollection : esADefHelpDeskLogCollection, IEnumerable<ADefHelpDeskLog>
	{
		public ADefHelpDeskLog FindByPrimaryKey(System.Int32 logID)
		{
			return this.SingleOrDefault(e => e.LogID == logID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ADefHelpDeskLog))]
		public class ADefHelpDeskLogCollectionWCFPacket : esCollectionWCFPacket<ADefHelpDeskLogCollection>
		{
			public static implicit operator ADefHelpDeskLogCollection(ADefHelpDeskLogCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ADefHelpDeskLogCollectionWCFPacket(ADefHelpDeskLogCollection collection)
			{
				return new ADefHelpDeskLogCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ADefHelpDeskLogQuery : esADefHelpDeskLogQuery
	{
		public ADefHelpDeskLogQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ADefHelpDeskLogQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ADefHelpDeskLogQuery query)
		{
			return ADefHelpDeskLogQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ADefHelpDeskLogQuery(string query)
		{
			return (ADefHelpDeskLogQuery)ADefHelpDeskLogQuery.SerializeHelper.FromXml(query, typeof(ADefHelpDeskLogQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esADefHelpDeskLog : esEntity
	{
		public esADefHelpDeskLog()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 logID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(logID);
			else
				return LoadByPrimaryKeyStoredProcedure(logID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 logID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(logID);
			else
				return LoadByPrimaryKeyStoredProcedure(logID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 logID)
		{
			ADefHelpDeskLogQuery query = new ADefHelpDeskLogQuery();
			query.Where(query.LogID == logID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 logID)
		{
			esParameters parms = new esParameters();
			parms.Add("LogID", logID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Log.LogID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? LogID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskLogMetadata.ColumnNames.LogID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskLogMetadata.ColumnNames.LogID, value))
				{
					OnPropertyChanged(ADefHelpDeskLogMetadata.PropertyNames.LogID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Log.TaskID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? TaskID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskLogMetadata.ColumnNames.TaskID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskLogMetadata.ColumnNames.TaskID, value))
				{
					this._UpToADefHelpDeskTasksByTaskID = null;
					this.OnPropertyChanged("UpToADefHelpDeskTasksByTaskID");
					OnPropertyChanged(ADefHelpDeskLogMetadata.PropertyNames.TaskID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Log.LogDescription
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String LogDescription
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskLogMetadata.ColumnNames.LogDescription);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskLogMetadata.ColumnNames.LogDescription, value))
				{
					OnPropertyChanged(ADefHelpDeskLogMetadata.PropertyNames.LogDescription);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Log.DateCreated
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? DateCreated
		{
			get
			{
				return base.GetSystemDateTime(ADefHelpDeskLogMetadata.ColumnNames.DateCreated);
			}
			
			set
			{
				if(base.SetSystemDateTime(ADefHelpDeskLogMetadata.ColumnNames.DateCreated, value))
				{
					OnPropertyChanged(ADefHelpDeskLogMetadata.PropertyNames.DateCreated);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Log.UserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? UserID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskLogMetadata.ColumnNames.UserID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskLogMetadata.ColumnNames.UserID, value))
				{
					OnPropertyChanged(ADefHelpDeskLogMetadata.PropertyNames.UserID);
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
						case "LogID": this.str().LogID = (string)value; break;							
						case "TaskID": this.str().TaskID = (string)value; break;							
						case "LogDescription": this.str().LogDescription = (string)value; break;							
						case "DateCreated": this.str().DateCreated = (string)value; break;							
						case "UserID": this.str().UserID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "LogID":
						
							if (value == null || value is System.Int32)
								this.LogID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskLogMetadata.PropertyNames.LogID);
							break;
						
						case "TaskID":
						
							if (value == null || value is System.Int32)
								this.TaskID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskLogMetadata.PropertyNames.TaskID);
							break;
						
						case "DateCreated":
						
							if (value == null || value is System.DateTime)
								this.DateCreated = (System.DateTime?)value;
								OnPropertyChanged(ADefHelpDeskLogMetadata.PropertyNames.DateCreated);
							break;
						
						case "UserID":
						
							if (value == null || value is System.Int32)
								this.UserID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskLogMetadata.PropertyNames.UserID);
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
			public esStrings(esADefHelpDeskLog entity)
			{
				this.entity = entity;
			}
			
	
			public System.String LogID
			{
				get
				{
					System.Int32? data = entity.LogID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LogID = null;
					else entity.LogID = Convert.ToInt32(value);
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
				
			public System.String LogDescription
			{
				get
				{
					System.String data = entity.LogDescription;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LogDescription = null;
					else entity.LogDescription = Convert.ToString(value);
				}
			}
				
			public System.String DateCreated
			{
				get
				{
					System.DateTime? data = entity.DateCreated;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.DateCreated = null;
					else entity.DateCreated = Convert.ToDateTime(value);
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
			

			private esADefHelpDeskLog entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskLogMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ADefHelpDeskLogQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskLogQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskLogQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ADefHelpDeskLogQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ADefHelpDeskLogQuery query;		
	}



	[Serializable]
	abstract public partial class esADefHelpDeskLogCollection : esEntityCollection<ADefHelpDeskLog>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskLogMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ADefHelpDeskLogCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ADefHelpDeskLogQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskLogQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskLogQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ADefHelpDeskLogQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ADefHelpDeskLogQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ADefHelpDeskLogQuery)query);
		}

		#endregion
		
		private ADefHelpDeskLogQuery query;
	}



	[Serializable]
	abstract public partial class esADefHelpDeskLogQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskLogMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "LogID": return this.LogID;
				case "TaskID": return this.TaskID;
				case "LogDescription": return this.LogDescription;
				case "DateCreated": return this.DateCreated;
				case "UserID": return this.UserID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem LogID
		{
			get { return new esQueryItem(this, ADefHelpDeskLogMetadata.ColumnNames.LogID, esSystemType.Int32); }
		} 
		
		public esQueryItem TaskID
		{
			get { return new esQueryItem(this, ADefHelpDeskLogMetadata.ColumnNames.TaskID, esSystemType.Int32); }
		} 
		
		public esQueryItem LogDescription
		{
			get { return new esQueryItem(this, ADefHelpDeskLogMetadata.ColumnNames.LogDescription, esSystemType.String); }
		} 
		
		public esQueryItem DateCreated
		{
			get { return new esQueryItem(this, ADefHelpDeskLogMetadata.ColumnNames.DateCreated, esSystemType.DateTime); }
		} 
		
		public esQueryItem UserID
		{
			get { return new esQueryItem(this, ADefHelpDeskLogMetadata.ColumnNames.UserID, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class ADefHelpDeskLog : esADefHelpDeskLog
	{

				
		#region UpToADefHelpDeskTasksByTaskID - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_ADefHelpDesk_Log_ADefHelpDesk_Tasks
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
	public partial class ADefHelpDeskLogMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ADefHelpDeskLogMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ADefHelpDeskLogMetadata.ColumnNames.LogID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskLogMetadata.PropertyNames.LogID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskLogMetadata.ColumnNames.TaskID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskLogMetadata.PropertyNames.TaskID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskLogMetadata.ColumnNames.LogDescription, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskLogMetadata.PropertyNames.LogDescription;
			c.CharacterMaxLength = 500;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskLogMetadata.ColumnNames.DateCreated, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ADefHelpDeskLogMetadata.PropertyNames.DateCreated;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskLogMetadata.ColumnNames.UserID, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskLogMetadata.PropertyNames.UserID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ADefHelpDeskLogMetadata Meta()
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
			 public const string LogID = "LogID";
			 public const string TaskID = "TaskID";
			 public const string LogDescription = "LogDescription";
			 public const string DateCreated = "DateCreated";
			 public const string UserID = "UserID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string LogID = "LogID";
			 public const string TaskID = "TaskID";
			 public const string LogDescription = "LogDescription";
			 public const string DateCreated = "DateCreated";
			 public const string UserID = "UserID";
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
			lock (typeof(ADefHelpDeskLogMetadata))
			{
				if(ADefHelpDeskLogMetadata.mapDelegates == null)
				{
					ADefHelpDeskLogMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ADefHelpDeskLogMetadata.meta == null)
				{
					ADefHelpDeskLogMetadata.meta = new ADefHelpDeskLogMetadata();
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


				meta.AddTypeMap("LogID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("TaskID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("LogDescription", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("DateCreated", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("UserID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "ADefHelpDesk_Log";
				meta.Destination = "ADefHelpDesk_Log";
				
				meta.spInsert = "proc_ADefHelpDesk_LogInsert";				
				meta.spUpdate = "proc_ADefHelpDesk_LogUpdate";		
				meta.spDelete = "proc_ADefHelpDesk_LogDelete";
				meta.spLoadAll = "proc_ADefHelpDesk_LogLoadAll";
				meta.spLoadByPrimaryKey = "proc_ADefHelpDesk_LogLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ADefHelpDeskLogMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
