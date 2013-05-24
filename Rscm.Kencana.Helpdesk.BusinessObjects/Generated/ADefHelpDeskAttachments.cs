
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 5/15/2013 10:58:25 AM
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
	/// Encapsulates the 'ADefHelpDesk_Attachments' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ADefHelpDeskAttachments))]	
	[XmlType("ADefHelpDeskAttachments")]
	public partial class ADefHelpDeskAttachments : esADefHelpDeskAttachments
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ADefHelpDeskAttachments();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 attachmentID)
		{
			var obj = new ADefHelpDeskAttachments();
			obj.AttachmentID = attachmentID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 attachmentID, esSqlAccessType sqlAccessType)
		{
			var obj = new ADefHelpDeskAttachments();
			obj.AttachmentID = attachmentID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("ADefHelpDeskAttachmentsCollection")]
	public partial class ADefHelpDeskAttachmentsCollection : esADefHelpDeskAttachmentsCollection, IEnumerable<ADefHelpDeskAttachments>
	{
		public ADefHelpDeskAttachments FindByPrimaryKey(System.Int32 attachmentID)
		{
			return this.SingleOrDefault(e => e.AttachmentID == attachmentID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ADefHelpDeskAttachments))]
		public class ADefHelpDeskAttachmentsCollectionWCFPacket : esCollectionWCFPacket<ADefHelpDeskAttachmentsCollection>
		{
			public static implicit operator ADefHelpDeskAttachmentsCollection(ADefHelpDeskAttachmentsCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ADefHelpDeskAttachmentsCollectionWCFPacket(ADefHelpDeskAttachmentsCollection collection)
			{
				return new ADefHelpDeskAttachmentsCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ADefHelpDeskAttachmentsQuery : esADefHelpDeskAttachmentsQuery
	{
		public ADefHelpDeskAttachmentsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ADefHelpDeskAttachmentsQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ADefHelpDeskAttachmentsQuery query)
		{
			return ADefHelpDeskAttachmentsQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ADefHelpDeskAttachmentsQuery(string query)
		{
			return (ADefHelpDeskAttachmentsQuery)ADefHelpDeskAttachmentsQuery.SerializeHelper.FromXml(query, typeof(ADefHelpDeskAttachmentsQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esADefHelpDeskAttachments : esEntity
	{
		public esADefHelpDeskAttachments()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 attachmentID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(attachmentID);
			else
				return LoadByPrimaryKeyStoredProcedure(attachmentID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 attachmentID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(attachmentID);
			else
				return LoadByPrimaryKeyStoredProcedure(attachmentID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 attachmentID)
		{
			ADefHelpDeskAttachmentsQuery query = new ADefHelpDeskAttachmentsQuery();
			query.Where(query.AttachmentID == attachmentID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 attachmentID)
		{
			esParameters parms = new esParameters();
			parms.Add("AttachmentID", attachmentID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Attachments.AttachmentID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? AttachmentID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskAttachmentsMetadata.ColumnNames.AttachmentID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskAttachmentsMetadata.ColumnNames.AttachmentID, value))
				{
					OnPropertyChanged(ADefHelpDeskAttachmentsMetadata.PropertyNames.AttachmentID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Attachments.DetailID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? DetailID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskAttachmentsMetadata.ColumnNames.DetailID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskAttachmentsMetadata.ColumnNames.DetailID, value))
				{
					this._UpToADefHelpDeskTaskDetailsByDetailID = null;
					this.OnPropertyChanged("UpToADefHelpDeskTaskDetailsByDetailID");
					OnPropertyChanged(ADefHelpDeskAttachmentsMetadata.PropertyNames.DetailID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Attachments.AttachmentPath
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String AttachmentPath
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskAttachmentsMetadata.ColumnNames.AttachmentPath);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskAttachmentsMetadata.ColumnNames.AttachmentPath, value))
				{
					OnPropertyChanged(ADefHelpDeskAttachmentsMetadata.PropertyNames.AttachmentPath);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Attachments.FileName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String FileName
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskAttachmentsMetadata.ColumnNames.FileName);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskAttachmentsMetadata.ColumnNames.FileName, value))
				{
					OnPropertyChanged(ADefHelpDeskAttachmentsMetadata.PropertyNames.FileName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Attachments.OriginalFileName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String OriginalFileName
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskAttachmentsMetadata.ColumnNames.OriginalFileName);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskAttachmentsMetadata.ColumnNames.OriginalFileName, value))
				{
					OnPropertyChanged(ADefHelpDeskAttachmentsMetadata.PropertyNames.OriginalFileName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Attachments.UserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? UserID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskAttachmentsMetadata.ColumnNames.UserID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskAttachmentsMetadata.ColumnNames.UserID, value))
				{
					OnPropertyChanged(ADefHelpDeskAttachmentsMetadata.PropertyNames.UserID);
				}
			}
		}		
		
		[CLSCompliant(false)]
		internal protected ADefHelpDeskTaskDetails _UpToADefHelpDeskTaskDetailsByDetailID;
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
						case "AttachmentID": this.str().AttachmentID = (string)value; break;							
						case "DetailID": this.str().DetailID = (string)value; break;							
						case "AttachmentPath": this.str().AttachmentPath = (string)value; break;							
						case "FileName": this.str().FileName = (string)value; break;							
						case "OriginalFileName": this.str().OriginalFileName = (string)value; break;							
						case "UserID": this.str().UserID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "AttachmentID":
						
							if (value == null || value is System.Int32)
								this.AttachmentID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskAttachmentsMetadata.PropertyNames.AttachmentID);
							break;
						
						case "DetailID":
						
							if (value == null || value is System.Int32)
								this.DetailID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskAttachmentsMetadata.PropertyNames.DetailID);
							break;
						
						case "UserID":
						
							if (value == null || value is System.Int32)
								this.UserID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskAttachmentsMetadata.PropertyNames.UserID);
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
			public esStrings(esADefHelpDeskAttachments entity)
			{
				this.entity = entity;
			}
			
	
			public System.String AttachmentID
			{
				get
				{
					System.Int32? data = entity.AttachmentID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AttachmentID = null;
					else entity.AttachmentID = Convert.ToInt32(value);
				}
			}
				
			public System.String DetailID
			{
				get
				{
					System.Int32? data = entity.DetailID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.DetailID = null;
					else entity.DetailID = Convert.ToInt32(value);
				}
			}
				
			public System.String AttachmentPath
			{
				get
				{
					System.String data = entity.AttachmentPath;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AttachmentPath = null;
					else entity.AttachmentPath = Convert.ToString(value);
				}
			}
				
			public System.String FileName
			{
				get
				{
					System.String data = entity.FileName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FileName = null;
					else entity.FileName = Convert.ToString(value);
				}
			}
				
			public System.String OriginalFileName
			{
				get
				{
					System.String data = entity.OriginalFileName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.OriginalFileName = null;
					else entity.OriginalFileName = Convert.ToString(value);
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
			

			private esADefHelpDeskAttachments entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskAttachmentsMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ADefHelpDeskAttachmentsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskAttachmentsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskAttachmentsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ADefHelpDeskAttachmentsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ADefHelpDeskAttachmentsQuery query;		
	}



	[Serializable]
	abstract public partial class esADefHelpDeskAttachmentsCollection : esEntityCollection<ADefHelpDeskAttachments>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskAttachmentsMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ADefHelpDeskAttachmentsCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ADefHelpDeskAttachmentsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskAttachmentsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskAttachmentsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ADefHelpDeskAttachmentsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ADefHelpDeskAttachmentsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ADefHelpDeskAttachmentsQuery)query);
		}

		#endregion
		
		private ADefHelpDeskAttachmentsQuery query;
	}



	[Serializable]
	abstract public partial class esADefHelpDeskAttachmentsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskAttachmentsMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "AttachmentID": return this.AttachmentID;
				case "DetailID": return this.DetailID;
				case "AttachmentPath": return this.AttachmentPath;
				case "FileName": return this.FileName;
				case "OriginalFileName": return this.OriginalFileName;
				case "UserID": return this.UserID;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem AttachmentID
		{
			get { return new esQueryItem(this, ADefHelpDeskAttachmentsMetadata.ColumnNames.AttachmentID, esSystemType.Int32); }
		} 
		
		public esQueryItem DetailID
		{
			get { return new esQueryItem(this, ADefHelpDeskAttachmentsMetadata.ColumnNames.DetailID, esSystemType.Int32); }
		} 
		
		public esQueryItem AttachmentPath
		{
			get { return new esQueryItem(this, ADefHelpDeskAttachmentsMetadata.ColumnNames.AttachmentPath, esSystemType.String); }
		} 
		
		public esQueryItem FileName
		{
			get { return new esQueryItem(this, ADefHelpDeskAttachmentsMetadata.ColumnNames.FileName, esSystemType.String); }
		} 
		
		public esQueryItem OriginalFileName
		{
			get { return new esQueryItem(this, ADefHelpDeskAttachmentsMetadata.ColumnNames.OriginalFileName, esSystemType.String); }
		} 
		
		public esQueryItem UserID
		{
			get { return new esQueryItem(this, ADefHelpDeskAttachmentsMetadata.ColumnNames.UserID, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class ADefHelpDeskAttachments : esADefHelpDeskAttachments
	{

				
		#region UpToADefHelpDeskTaskDetailsByDetailID - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_ADefHelpDesk_Attachments_ADefHelpDesk_TaskDetails
		/// </summary>

		[XmlIgnore]
					
		public ADefHelpDeskTaskDetails UpToADefHelpDeskTaskDetailsByDetailID
		{
			get
			{
				if (this.es.IsLazyLoadDisabled) return null;
				
				if(this._UpToADefHelpDeskTaskDetailsByDetailID == null && DetailID != null)
				{
					this._UpToADefHelpDeskTaskDetailsByDetailID = new ADefHelpDeskTaskDetails();
					this._UpToADefHelpDeskTaskDetailsByDetailID.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToADefHelpDeskTaskDetailsByDetailID", this._UpToADefHelpDeskTaskDetailsByDetailID);
					this._UpToADefHelpDeskTaskDetailsByDetailID.Query.Where(this._UpToADefHelpDeskTaskDetailsByDetailID.Query.DetailID == this.DetailID);
					this._UpToADefHelpDeskTaskDetailsByDetailID.Query.Load();
				}	
				return this._UpToADefHelpDeskTaskDetailsByDetailID;
			}
			
			set
			{
				this.RemovePreSave("UpToADefHelpDeskTaskDetailsByDetailID");
				

				if(value == null)
				{
					this.DetailID = null;
					this._UpToADefHelpDeskTaskDetailsByDetailID = null;
				}
				else
				{
					this.DetailID = value.DetailID;
					this._UpToADefHelpDeskTaskDetailsByDetailID = value;
					this.SetPreSave("UpToADefHelpDeskTaskDetailsByDetailID", this._UpToADefHelpDeskTaskDetailsByDetailID);
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
			if(!this.es.IsDeleted && this._UpToADefHelpDeskTaskDetailsByDetailID != null)
			{
				this.DetailID = this._UpToADefHelpDeskTaskDetailsByDetailID.DetailID;
			}
		}
		
	}
	



	[Serializable]
	public partial class ADefHelpDeskAttachmentsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ADefHelpDeskAttachmentsMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ADefHelpDeskAttachmentsMetadata.ColumnNames.AttachmentID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskAttachmentsMetadata.PropertyNames.AttachmentID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskAttachmentsMetadata.ColumnNames.DetailID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskAttachmentsMetadata.PropertyNames.DetailID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskAttachmentsMetadata.ColumnNames.AttachmentPath, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskAttachmentsMetadata.PropertyNames.AttachmentPath;
			c.CharacterMaxLength = 1000;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskAttachmentsMetadata.ColumnNames.FileName, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskAttachmentsMetadata.PropertyNames.FileName;
			c.CharacterMaxLength = 150;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskAttachmentsMetadata.ColumnNames.OriginalFileName, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskAttachmentsMetadata.PropertyNames.OriginalFileName;
			c.CharacterMaxLength = 150;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskAttachmentsMetadata.ColumnNames.UserID, 5, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskAttachmentsMetadata.PropertyNames.UserID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ADefHelpDeskAttachmentsMetadata Meta()
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
			 public const string AttachmentID = "AttachmentID";
			 public const string DetailID = "DetailID";
			 public const string AttachmentPath = "AttachmentPath";
			 public const string FileName = "FileName";
			 public const string OriginalFileName = "OriginalFileName";
			 public const string UserID = "UserID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string AttachmentID = "AttachmentID";
			 public const string DetailID = "DetailID";
			 public const string AttachmentPath = "AttachmentPath";
			 public const string FileName = "FileName";
			 public const string OriginalFileName = "OriginalFileName";
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
			lock (typeof(ADefHelpDeskAttachmentsMetadata))
			{
				if(ADefHelpDeskAttachmentsMetadata.mapDelegates == null)
				{
					ADefHelpDeskAttachmentsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ADefHelpDeskAttachmentsMetadata.meta == null)
				{
					ADefHelpDeskAttachmentsMetadata.meta = new ADefHelpDeskAttachmentsMetadata();
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


				meta.AddTypeMap("AttachmentID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("DetailID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("AttachmentPath", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("FileName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("OriginalFileName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("UserID", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "ADefHelpDesk_Attachments";
				meta.Destination = "ADefHelpDesk_Attachments";
				
				meta.spInsert = "proc_ADefHelpDesk_AttachmentsInsert";				
				meta.spUpdate = "proc_ADefHelpDesk_AttachmentsUpdate";		
				meta.spDelete = "proc_ADefHelpDesk_AttachmentsDelete";
				meta.spLoadAll = "proc_ADefHelpDesk_AttachmentsLoadAll";
				meta.spLoadByPrimaryKey = "proc_ADefHelpDesk_AttachmentsLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ADefHelpDeskAttachmentsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
