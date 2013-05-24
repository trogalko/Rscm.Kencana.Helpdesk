
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
	/// Encapsulates the 'ADefHelpDesk_Version' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ADefHelpDeskVersion))]	
	[XmlType("ADefHelpDeskVersion")]
	public partial class ADefHelpDeskVersion : esADefHelpDeskVersion
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ADefHelpDeskVersion();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String versionNumber)
		{
			var obj = new ADefHelpDeskVersion();
			obj.VersionNumber = versionNumber;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String versionNumber, esSqlAccessType sqlAccessType)
		{
			var obj = new ADefHelpDeskVersion();
			obj.VersionNumber = versionNumber;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("ADefHelpDeskVersionCollection")]
	public partial class ADefHelpDeskVersionCollection : esADefHelpDeskVersionCollection, IEnumerable<ADefHelpDeskVersion>
	{
		public ADefHelpDeskVersion FindByPrimaryKey(System.String versionNumber)
		{
			return this.SingleOrDefault(e => e.VersionNumber == versionNumber);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ADefHelpDeskVersion))]
		public class ADefHelpDeskVersionCollectionWCFPacket : esCollectionWCFPacket<ADefHelpDeskVersionCollection>
		{
			public static implicit operator ADefHelpDeskVersionCollection(ADefHelpDeskVersionCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ADefHelpDeskVersionCollectionWCFPacket(ADefHelpDeskVersionCollection collection)
			{
				return new ADefHelpDeskVersionCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ADefHelpDeskVersionQuery : esADefHelpDeskVersionQuery
	{
		public ADefHelpDeskVersionQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ADefHelpDeskVersionQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ADefHelpDeskVersionQuery query)
		{
			return ADefHelpDeskVersionQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ADefHelpDeskVersionQuery(string query)
		{
			return (ADefHelpDeskVersionQuery)ADefHelpDeskVersionQuery.SerializeHelper.FromXml(query, typeof(ADefHelpDeskVersionQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esADefHelpDeskVersion : esEntity
	{
		public esADefHelpDeskVersion()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String versionNumber)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(versionNumber);
			else
				return LoadByPrimaryKeyStoredProcedure(versionNumber);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String versionNumber)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(versionNumber);
			else
				return LoadByPrimaryKeyStoredProcedure(versionNumber);
		}

		private bool LoadByPrimaryKeyDynamic(System.String versionNumber)
		{
			ADefHelpDeskVersionQuery query = new ADefHelpDeskVersionQuery();
			query.Where(query.VersionNumber == versionNumber);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String versionNumber)
		{
			esParameters parms = new esParameters();
			parms.Add("VersionNumber", versionNumber);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Version.VersionNumber
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String VersionNumber
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskVersionMetadata.ColumnNames.VersionNumber);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskVersionMetadata.ColumnNames.VersionNumber, value))
				{
					OnPropertyChanged(ADefHelpDeskVersionMetadata.PropertyNames.VersionNumber);
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
						case "VersionNumber": this.str().VersionNumber = (string)value; break;
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
			public esStrings(esADefHelpDeskVersion entity)
			{
				this.entity = entity;
			}
			
	
			public System.String VersionNumber
			{
				get
				{
					System.String data = entity.VersionNumber;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.VersionNumber = null;
					else entity.VersionNumber = Convert.ToString(value);
				}
			}
			

			private esADefHelpDeskVersion entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskVersionMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ADefHelpDeskVersionQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskVersionQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskVersionQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ADefHelpDeskVersionQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ADefHelpDeskVersionQuery query;		
	}



	[Serializable]
	abstract public partial class esADefHelpDeskVersionCollection : esEntityCollection<ADefHelpDeskVersion>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskVersionMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ADefHelpDeskVersionCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ADefHelpDeskVersionQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskVersionQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskVersionQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ADefHelpDeskVersionQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ADefHelpDeskVersionQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ADefHelpDeskVersionQuery)query);
		}

		#endregion
		
		private ADefHelpDeskVersionQuery query;
	}



	[Serializable]
	abstract public partial class esADefHelpDeskVersionQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskVersionMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "VersionNumber": return this.VersionNumber;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem VersionNumber
		{
			get { return new esQueryItem(this, ADefHelpDeskVersionMetadata.ColumnNames.VersionNumber, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class ADefHelpDeskVersion : esADefHelpDeskVersion
	{

		
		
	}
	



	[Serializable]
	public partial class ADefHelpDeskVersionMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ADefHelpDeskVersionMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ADefHelpDeskVersionMetadata.ColumnNames.VersionNumber, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskVersionMetadata.PropertyNames.VersionNumber;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ADefHelpDeskVersionMetadata Meta()
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
			 public const string VersionNumber = "VersionNumber";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string VersionNumber = "VersionNumber";
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
			lock (typeof(ADefHelpDeskVersionMetadata))
			{
				if(ADefHelpDeskVersionMetadata.mapDelegates == null)
				{
					ADefHelpDeskVersionMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ADefHelpDeskVersionMetadata.meta == null)
				{
					ADefHelpDeskVersionMetadata.meta = new ADefHelpDeskVersionMetadata();
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


				meta.AddTypeMap("VersionNumber", new esTypeMap("varchar", "System.String"));			
				
				
				
				meta.Source = "ADefHelpDesk_Version";
				meta.Destination = "ADefHelpDesk_Version";
				
				meta.spInsert = "proc_ADefHelpDesk_VersionInsert";				
				meta.spUpdate = "proc_ADefHelpDesk_VersionUpdate";		
				meta.spDelete = "proc_ADefHelpDesk_VersionDelete";
				meta.spLoadAll = "proc_ADefHelpDesk_VersionLoadAll";
				meta.spLoadByPrimaryKey = "proc_ADefHelpDesk_VersionLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ADefHelpDeskVersionMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
