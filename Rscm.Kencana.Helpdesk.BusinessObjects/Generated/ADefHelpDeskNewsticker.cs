
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
	/// Encapsulates the 'ADefHelpDesk_Newsticker' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ADefHelpDeskNewsticker))]	
	[XmlType("ADefHelpDeskNewsticker")]
	public partial class ADefHelpDeskNewsticker : esADefHelpDeskNewsticker
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ADefHelpDeskNewsticker();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new ADefHelpDeskNewsticker();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new ADefHelpDeskNewsticker();
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
	[XmlType("ADefHelpDeskNewstickerCollection")]
	public partial class ADefHelpDeskNewstickerCollection : esADefHelpDeskNewstickerCollection, IEnumerable<ADefHelpDeskNewsticker>
	{
		public ADefHelpDeskNewsticker FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ADefHelpDeskNewsticker))]
		public class ADefHelpDeskNewstickerCollectionWCFPacket : esCollectionWCFPacket<ADefHelpDeskNewstickerCollection>
		{
			public static implicit operator ADefHelpDeskNewstickerCollection(ADefHelpDeskNewstickerCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ADefHelpDeskNewstickerCollectionWCFPacket(ADefHelpDeskNewstickerCollection collection)
			{
				return new ADefHelpDeskNewstickerCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ADefHelpDeskNewstickerQuery : esADefHelpDeskNewstickerQuery
	{
		public ADefHelpDeskNewstickerQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ADefHelpDeskNewstickerQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ADefHelpDeskNewstickerQuery query)
		{
			return ADefHelpDeskNewstickerQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ADefHelpDeskNewstickerQuery(string query)
		{
			return (ADefHelpDeskNewstickerQuery)ADefHelpDeskNewstickerQuery.SerializeHelper.FromXml(query, typeof(ADefHelpDeskNewstickerQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esADefHelpDeskNewsticker : esEntity
	{
		public esADefHelpDeskNewsticker()
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
			ADefHelpDeskNewstickerQuery query = new ADefHelpDeskNewstickerQuery();
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
		/// Maps to ADefHelpDesk_Newsticker.id
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskNewstickerMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskNewstickerMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(ADefHelpDeskNewstickerMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Newsticker.creator
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Creator
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskNewstickerMetadata.ColumnNames.Creator);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskNewstickerMetadata.ColumnNames.Creator, value))
				{
					OnPropertyChanged(ADefHelpDeskNewstickerMetadata.PropertyNames.Creator);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Newsticker.createdDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreatedDate
		{
			get
			{
				return base.GetSystemDateTime(ADefHelpDeskNewstickerMetadata.ColumnNames.CreatedDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ADefHelpDeskNewstickerMetadata.ColumnNames.CreatedDate, value))
				{
					OnPropertyChanged(ADefHelpDeskNewstickerMetadata.PropertyNames.CreatedDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Newsticker.dueDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? DueDate
		{
			get
			{
				return base.GetSystemDateTime(ADefHelpDeskNewstickerMetadata.ColumnNames.DueDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ADefHelpDeskNewstickerMetadata.ColumnNames.DueDate, value))
				{
					OnPropertyChanged(ADefHelpDeskNewstickerMetadata.PropertyNames.DueDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Newsticker.line1
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Line1
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskNewstickerMetadata.ColumnNames.Line1);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskNewstickerMetadata.ColumnNames.Line1, value))
				{
					OnPropertyChanged(ADefHelpDeskNewstickerMetadata.PropertyNames.Line1);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Newsticker.line2
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Line2
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskNewstickerMetadata.ColumnNames.Line2);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskNewstickerMetadata.ColumnNames.Line2, value))
				{
					OnPropertyChanged(ADefHelpDeskNewstickerMetadata.PropertyNames.Line2);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Newsticker.line3
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Line3
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskNewstickerMetadata.ColumnNames.Line3);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskNewstickerMetadata.ColumnNames.Line3, value))
				{
					OnPropertyChanged(ADefHelpDeskNewstickerMetadata.PropertyNames.Line3);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Newsticker.isValid
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? IsValid
		{
			get
			{
				return base.GetSystemBoolean(ADefHelpDeskNewstickerMetadata.ColumnNames.IsValid);
			}
			
			set
			{
				if(base.SetSystemBoolean(ADefHelpDeskNewstickerMetadata.ColumnNames.IsValid, value))
				{
					OnPropertyChanged(ADefHelpDeskNewstickerMetadata.PropertyNames.IsValid);
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
						case "Creator": this.str().Creator = (string)value; break;							
						case "CreatedDate": this.str().CreatedDate = (string)value; break;							
						case "DueDate": this.str().DueDate = (string)value; break;							
						case "Line1": this.str().Line1 = (string)value; break;							
						case "Line2": this.str().Line2 = (string)value; break;							
						case "Line3": this.str().Line3 = (string)value; break;							
						case "IsValid": this.str().IsValid = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int32)
								this.Id = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskNewstickerMetadata.PropertyNames.Id);
							break;
						
						case "CreatedDate":
						
							if (value == null || value is System.DateTime)
								this.CreatedDate = (System.DateTime?)value;
								OnPropertyChanged(ADefHelpDeskNewstickerMetadata.PropertyNames.CreatedDate);
							break;
						
						case "DueDate":
						
							if (value == null || value is System.DateTime)
								this.DueDate = (System.DateTime?)value;
								OnPropertyChanged(ADefHelpDeskNewstickerMetadata.PropertyNames.DueDate);
							break;
						
						case "IsValid":
						
							if (value == null || value is System.Boolean)
								this.IsValid = (System.Boolean?)value;
								OnPropertyChanged(ADefHelpDeskNewstickerMetadata.PropertyNames.IsValid);
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
			public esStrings(esADefHelpDeskNewsticker entity)
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
				
			public System.String Creator
			{
				get
				{
					System.String data = entity.Creator;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Creator = null;
					else entity.Creator = Convert.ToString(value);
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
				
			public System.String DueDate
			{
				get
				{
					System.DateTime? data = entity.DueDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.DueDate = null;
					else entity.DueDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String Line1
			{
				get
				{
					System.String data = entity.Line1;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Line1 = null;
					else entity.Line1 = Convert.ToString(value);
				}
			}
				
			public System.String Line2
			{
				get
				{
					System.String data = entity.Line2;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Line2 = null;
					else entity.Line2 = Convert.ToString(value);
				}
			}
				
			public System.String Line3
			{
				get
				{
					System.String data = entity.Line3;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Line3 = null;
					else entity.Line3 = Convert.ToString(value);
				}
			}
				
			public System.String IsValid
			{
				get
				{
					System.Boolean? data = entity.IsValid;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.IsValid = null;
					else entity.IsValid = Convert.ToBoolean(value);
				}
			}
			

			private esADefHelpDeskNewsticker entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskNewstickerMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ADefHelpDeskNewstickerQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskNewstickerQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskNewstickerQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ADefHelpDeskNewstickerQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ADefHelpDeskNewstickerQuery query;		
	}



	[Serializable]
	abstract public partial class esADefHelpDeskNewstickerCollection : esEntityCollection<ADefHelpDeskNewsticker>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskNewstickerMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ADefHelpDeskNewstickerCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ADefHelpDeskNewstickerQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskNewstickerQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskNewstickerQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ADefHelpDeskNewstickerQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ADefHelpDeskNewstickerQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ADefHelpDeskNewstickerQuery)query);
		}

		#endregion
		
		private ADefHelpDeskNewstickerQuery query;
	}



	[Serializable]
	abstract public partial class esADefHelpDeskNewstickerQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskNewstickerMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "Creator": return this.Creator;
				case "CreatedDate": return this.CreatedDate;
				case "DueDate": return this.DueDate;
				case "Line1": return this.Line1;
				case "Line2": return this.Line2;
				case "Line3": return this.Line3;
				case "IsValid": return this.IsValid;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, ADefHelpDeskNewstickerMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem Creator
		{
			get { return new esQueryItem(this, ADefHelpDeskNewstickerMetadata.ColumnNames.Creator, esSystemType.String); }
		} 
		
		public esQueryItem CreatedDate
		{
			get { return new esQueryItem(this, ADefHelpDeskNewstickerMetadata.ColumnNames.CreatedDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem DueDate
		{
			get { return new esQueryItem(this, ADefHelpDeskNewstickerMetadata.ColumnNames.DueDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem Line1
		{
			get { return new esQueryItem(this, ADefHelpDeskNewstickerMetadata.ColumnNames.Line1, esSystemType.String); }
		} 
		
		public esQueryItem Line2
		{
			get { return new esQueryItem(this, ADefHelpDeskNewstickerMetadata.ColumnNames.Line2, esSystemType.String); }
		} 
		
		public esQueryItem Line3
		{
			get { return new esQueryItem(this, ADefHelpDeskNewstickerMetadata.ColumnNames.Line3, esSystemType.String); }
		} 
		
		public esQueryItem IsValid
		{
			get { return new esQueryItem(this, ADefHelpDeskNewstickerMetadata.ColumnNames.IsValid, esSystemType.Boolean); }
		} 
		
		#endregion
		
	}


	
	public partial class ADefHelpDeskNewsticker : esADefHelpDeskNewsticker
	{

		
		
	}
	



	[Serializable]
	public partial class ADefHelpDeskNewstickerMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ADefHelpDeskNewstickerMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ADefHelpDeskNewstickerMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskNewstickerMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskNewstickerMetadata.ColumnNames.Creator, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskNewstickerMetadata.PropertyNames.Creator;
			c.CharacterMaxLength = 255;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskNewstickerMetadata.ColumnNames.CreatedDate, 2, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ADefHelpDeskNewstickerMetadata.PropertyNames.CreatedDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskNewstickerMetadata.ColumnNames.DueDate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ADefHelpDeskNewstickerMetadata.PropertyNames.DueDate;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskNewstickerMetadata.ColumnNames.Line1, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskNewstickerMetadata.PropertyNames.Line1;
			c.CharacterMaxLength = 1073741823;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskNewstickerMetadata.ColumnNames.Line2, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskNewstickerMetadata.PropertyNames.Line2;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskNewstickerMetadata.ColumnNames.Line3, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskNewstickerMetadata.PropertyNames.Line3;
			c.CharacterMaxLength = 100;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskNewstickerMetadata.ColumnNames.IsValid, 7, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ADefHelpDeskNewstickerMetadata.PropertyNames.IsValid;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ADefHelpDeskNewstickerMetadata Meta()
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
			 public const string Id = "id";
			 public const string Creator = "creator";
			 public const string CreatedDate = "createdDate";
			 public const string DueDate = "dueDate";
			 public const string Line1 = "line1";
			 public const string Line2 = "line2";
			 public const string Line3 = "line3";
			 public const string IsValid = "isValid";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string Creator = "Creator";
			 public const string CreatedDate = "CreatedDate";
			 public const string DueDate = "DueDate";
			 public const string Line1 = "Line1";
			 public const string Line2 = "Line2";
			 public const string Line3 = "Line3";
			 public const string IsValid = "IsValid";
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
			lock (typeof(ADefHelpDeskNewstickerMetadata))
			{
				if(ADefHelpDeskNewstickerMetadata.mapDelegates == null)
				{
					ADefHelpDeskNewstickerMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ADefHelpDeskNewstickerMetadata.meta == null)
				{
					ADefHelpDeskNewstickerMetadata.meta = new ADefHelpDeskNewstickerMetadata();
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
				meta.AddTypeMap("Creator", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("CreatedDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("DueDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Line1", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Line2", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Line3", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("IsValid", new esTypeMap("bit", "System.Boolean"));			
				
				
				
				meta.Source = "ADefHelpDesk_Newsticker";
				meta.Destination = "ADefHelpDesk_Newsticker";
				
				meta.spInsert = "proc_ADefHelpDesk_NewstickerInsert";				
				meta.spUpdate = "proc_ADefHelpDesk_NewstickerUpdate";		
				meta.spDelete = "proc_ADefHelpDesk_NewstickerDelete";
				meta.spLoadAll = "proc_ADefHelpDesk_NewstickerLoadAll";
				meta.spLoadByPrimaryKey = "proc_ADefHelpDesk_NewstickerLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ADefHelpDeskNewstickerMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
