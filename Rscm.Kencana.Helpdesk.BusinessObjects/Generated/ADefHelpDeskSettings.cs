
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
	/// Encapsulates the 'ADefHelpDesk_Settings' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ADefHelpDeskSettings))]	
	[XmlType("ADefHelpDeskSettings")]
	public partial class ADefHelpDeskSettings : esADefHelpDeskSettings
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ADefHelpDeskSettings();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 settingID)
		{
			var obj = new ADefHelpDeskSettings();
			obj.SettingID = settingID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 settingID, esSqlAccessType sqlAccessType)
		{
			var obj = new ADefHelpDeskSettings();
			obj.SettingID = settingID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("ADefHelpDeskSettingsCollection")]
	public partial class ADefHelpDeskSettingsCollection : esADefHelpDeskSettingsCollection, IEnumerable<ADefHelpDeskSettings>
	{
		public ADefHelpDeskSettings FindByPrimaryKey(System.Int32 settingID)
		{
			return this.SingleOrDefault(e => e.SettingID == settingID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ADefHelpDeskSettings))]
		public class ADefHelpDeskSettingsCollectionWCFPacket : esCollectionWCFPacket<ADefHelpDeskSettingsCollection>
		{
			public static implicit operator ADefHelpDeskSettingsCollection(ADefHelpDeskSettingsCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ADefHelpDeskSettingsCollectionWCFPacket(ADefHelpDeskSettingsCollection collection)
			{
				return new ADefHelpDeskSettingsCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ADefHelpDeskSettingsQuery : esADefHelpDeskSettingsQuery
	{
		public ADefHelpDeskSettingsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ADefHelpDeskSettingsQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ADefHelpDeskSettingsQuery query)
		{
			return ADefHelpDeskSettingsQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ADefHelpDeskSettingsQuery(string query)
		{
			return (ADefHelpDeskSettingsQuery)ADefHelpDeskSettingsQuery.SerializeHelper.FromXml(query, typeof(ADefHelpDeskSettingsQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esADefHelpDeskSettings : esEntity
	{
		public esADefHelpDeskSettings()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 settingID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(settingID);
			else
				return LoadByPrimaryKeyStoredProcedure(settingID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 settingID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(settingID);
			else
				return LoadByPrimaryKeyStoredProcedure(settingID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 settingID)
		{
			ADefHelpDeskSettingsQuery query = new ADefHelpDeskSettingsQuery();
			query.Where(query.SettingID == settingID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 settingID)
		{
			esParameters parms = new esParameters();
			parms.Add("SettingID", settingID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Settings.SettingID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? SettingID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskSettingsMetadata.ColumnNames.SettingID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskSettingsMetadata.ColumnNames.SettingID, value))
				{
					OnPropertyChanged(ADefHelpDeskSettingsMetadata.PropertyNames.SettingID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Settings.PortalID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? PortalID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskSettingsMetadata.ColumnNames.PortalID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskSettingsMetadata.ColumnNames.PortalID, value))
				{
					OnPropertyChanged(ADefHelpDeskSettingsMetadata.PropertyNames.PortalID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Settings.SettingName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String SettingName
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskSettingsMetadata.ColumnNames.SettingName);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskSettingsMetadata.ColumnNames.SettingName, value))
				{
					OnPropertyChanged(ADefHelpDeskSettingsMetadata.PropertyNames.SettingName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Settings.SettingValue
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String SettingValue
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskSettingsMetadata.ColumnNames.SettingValue);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskSettingsMetadata.ColumnNames.SettingValue, value))
				{
					OnPropertyChanged(ADefHelpDeskSettingsMetadata.PropertyNames.SettingValue);
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
						case "SettingID": this.str().SettingID = (string)value; break;							
						case "PortalID": this.str().PortalID = (string)value; break;							
						case "SettingName": this.str().SettingName = (string)value; break;							
						case "SettingValue": this.str().SettingValue = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "SettingID":
						
							if (value == null || value is System.Int32)
								this.SettingID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskSettingsMetadata.PropertyNames.SettingID);
							break;
						
						case "PortalID":
						
							if (value == null || value is System.Int32)
								this.PortalID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskSettingsMetadata.PropertyNames.PortalID);
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
			public esStrings(esADefHelpDeskSettings entity)
			{
				this.entity = entity;
			}
			
	
			public System.String SettingID
			{
				get
				{
					System.Int32? data = entity.SettingID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SettingID = null;
					else entity.SettingID = Convert.ToInt32(value);
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
				
			public System.String SettingName
			{
				get
				{
					System.String data = entity.SettingName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SettingName = null;
					else entity.SettingName = Convert.ToString(value);
				}
			}
				
			public System.String SettingValue
			{
				get
				{
					System.String data = entity.SettingValue;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SettingValue = null;
					else entity.SettingValue = Convert.ToString(value);
				}
			}
			

			private esADefHelpDeskSettings entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskSettingsMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ADefHelpDeskSettingsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskSettingsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskSettingsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ADefHelpDeskSettingsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ADefHelpDeskSettingsQuery query;		
	}



	[Serializable]
	abstract public partial class esADefHelpDeskSettingsCollection : esEntityCollection<ADefHelpDeskSettings>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskSettingsMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ADefHelpDeskSettingsCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ADefHelpDeskSettingsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskSettingsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskSettingsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ADefHelpDeskSettingsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ADefHelpDeskSettingsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ADefHelpDeskSettingsQuery)query);
		}

		#endregion
		
		private ADefHelpDeskSettingsQuery query;
	}



	[Serializable]
	abstract public partial class esADefHelpDeskSettingsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskSettingsMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "SettingID": return this.SettingID;
				case "PortalID": return this.PortalID;
				case "SettingName": return this.SettingName;
				case "SettingValue": return this.SettingValue;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem SettingID
		{
			get { return new esQueryItem(this, ADefHelpDeskSettingsMetadata.ColumnNames.SettingID, esSystemType.Int32); }
		} 
		
		public esQueryItem PortalID
		{
			get { return new esQueryItem(this, ADefHelpDeskSettingsMetadata.ColumnNames.PortalID, esSystemType.Int32); }
		} 
		
		public esQueryItem SettingName
		{
			get { return new esQueryItem(this, ADefHelpDeskSettingsMetadata.ColumnNames.SettingName, esSystemType.String); }
		} 
		
		public esQueryItem SettingValue
		{
			get { return new esQueryItem(this, ADefHelpDeskSettingsMetadata.ColumnNames.SettingValue, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class ADefHelpDeskSettings : esADefHelpDeskSettings
	{

		
		
	}
	



	[Serializable]
	public partial class ADefHelpDeskSettingsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ADefHelpDeskSettingsMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ADefHelpDeskSettingsMetadata.ColumnNames.SettingID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskSettingsMetadata.PropertyNames.SettingID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskSettingsMetadata.ColumnNames.PortalID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskSettingsMetadata.PropertyNames.PortalID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskSettingsMetadata.ColumnNames.SettingName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskSettingsMetadata.PropertyNames.SettingName;
			c.CharacterMaxLength = 150;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskSettingsMetadata.ColumnNames.SettingValue, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskSettingsMetadata.PropertyNames.SettingValue;
			c.CharacterMaxLength = 250;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ADefHelpDeskSettingsMetadata Meta()
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
			 public const string SettingID = "SettingID";
			 public const string PortalID = "PortalID";
			 public const string SettingName = "SettingName";
			 public const string SettingValue = "SettingValue";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string SettingID = "SettingID";
			 public const string PortalID = "PortalID";
			 public const string SettingName = "SettingName";
			 public const string SettingValue = "SettingValue";
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
			lock (typeof(ADefHelpDeskSettingsMetadata))
			{
				if(ADefHelpDeskSettingsMetadata.mapDelegates == null)
				{
					ADefHelpDeskSettingsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ADefHelpDeskSettingsMetadata.meta == null)
				{
					ADefHelpDeskSettingsMetadata.meta = new ADefHelpDeskSettingsMetadata();
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


				meta.AddTypeMap("SettingID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("PortalID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("SettingName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("SettingValue", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "ADefHelpDesk_Settings";
				meta.Destination = "ADefHelpDesk_Settings";
				
				meta.spInsert = "proc_ADefHelpDesk_SettingsInsert";				
				meta.spUpdate = "proc_ADefHelpDesk_SettingsUpdate";		
				meta.spDelete = "proc_ADefHelpDesk_SettingsDelete";
				meta.spLoadAll = "proc_ADefHelpDesk_SettingsLoadAll";
				meta.spLoadByPrimaryKey = "proc_ADefHelpDesk_SettingsLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ADefHelpDeskSettingsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
