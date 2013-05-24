
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 5/15/2013 10:58:34 AM
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
	/// Encapsulates the 'ADefHelpDesk_Categories' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ADefHelpDeskCategories))]	
	[XmlType("ADefHelpDeskCategories")]
	public partial class ADefHelpDeskCategories : esADefHelpDeskCategories
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ADefHelpDeskCategories();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 categoryID)
		{
			var obj = new ADefHelpDeskCategories();
			obj.CategoryID = categoryID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 categoryID, esSqlAccessType sqlAccessType)
		{
			var obj = new ADefHelpDeskCategories();
			obj.CategoryID = categoryID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("ADefHelpDeskCategoriesCollection")]
	public partial class ADefHelpDeskCategoriesCollection : esADefHelpDeskCategoriesCollection, IEnumerable<ADefHelpDeskCategories>
	{
		public ADefHelpDeskCategories FindByPrimaryKey(System.Int32 categoryID)
		{
			return this.SingleOrDefault(e => e.CategoryID == categoryID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ADefHelpDeskCategories))]
		public class ADefHelpDeskCategoriesCollectionWCFPacket : esCollectionWCFPacket<ADefHelpDeskCategoriesCollection>
		{
			public static implicit operator ADefHelpDeskCategoriesCollection(ADefHelpDeskCategoriesCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ADefHelpDeskCategoriesCollectionWCFPacket(ADefHelpDeskCategoriesCollection collection)
			{
				return new ADefHelpDeskCategoriesCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ADefHelpDeskCategoriesQuery : esADefHelpDeskCategoriesQuery
	{
		public ADefHelpDeskCategoriesQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ADefHelpDeskCategoriesQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ADefHelpDeskCategoriesQuery query)
		{
			return ADefHelpDeskCategoriesQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ADefHelpDeskCategoriesQuery(string query)
		{
			return (ADefHelpDeskCategoriesQuery)ADefHelpDeskCategoriesQuery.SerializeHelper.FromXml(query, typeof(ADefHelpDeskCategoriesQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esADefHelpDeskCategories : esEntity
	{
		public esADefHelpDeskCategories()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 categoryID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(categoryID);
			else
				return LoadByPrimaryKeyStoredProcedure(categoryID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 categoryID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(categoryID);
			else
				return LoadByPrimaryKeyStoredProcedure(categoryID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 categoryID)
		{
			ADefHelpDeskCategoriesQuery query = new ADefHelpDeskCategoriesQuery();
			query.Where(query.CategoryID == categoryID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 categoryID)
		{
			esParameters parms = new esParameters();
			parms.Add("CategoryID", categoryID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Categories.CategoryID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? CategoryID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskCategoriesMetadata.ColumnNames.CategoryID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskCategoriesMetadata.ColumnNames.CategoryID, value))
				{
					OnPropertyChanged(ADefHelpDeskCategoriesMetadata.PropertyNames.CategoryID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Categories.PortalID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? PortalID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskCategoriesMetadata.ColumnNames.PortalID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskCategoriesMetadata.ColumnNames.PortalID, value))
				{
					OnPropertyChanged(ADefHelpDeskCategoriesMetadata.PropertyNames.PortalID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Categories.ParentCategoryID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ParentCategoryID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskCategoriesMetadata.ColumnNames.ParentCategoryID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskCategoriesMetadata.ColumnNames.ParentCategoryID, value))
				{
					OnPropertyChanged(ADefHelpDeskCategoriesMetadata.PropertyNames.ParentCategoryID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Categories.CategoryName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CategoryName
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskCategoriesMetadata.ColumnNames.CategoryName);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskCategoriesMetadata.ColumnNames.CategoryName, value))
				{
					OnPropertyChanged(ADefHelpDeskCategoriesMetadata.PropertyNames.CategoryName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Categories.Level
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Level
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskCategoriesMetadata.ColumnNames.Level);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskCategoriesMetadata.ColumnNames.Level, value))
				{
					OnPropertyChanged(ADefHelpDeskCategoriesMetadata.PropertyNames.Level);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Categories.RequestorVisible
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? RequestorVisible
		{
			get
			{
				return base.GetSystemBoolean(ADefHelpDeskCategoriesMetadata.ColumnNames.RequestorVisible);
			}
			
			set
			{
				if(base.SetSystemBoolean(ADefHelpDeskCategoriesMetadata.ColumnNames.RequestorVisible, value))
				{
					OnPropertyChanged(ADefHelpDeskCategoriesMetadata.PropertyNames.RequestorVisible);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Categories.Selectable
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Boolean? Selectable
		{
			get
			{
				return base.GetSystemBoolean(ADefHelpDeskCategoriesMetadata.ColumnNames.Selectable);
			}
			
			set
			{
				if(base.SetSystemBoolean(ADefHelpDeskCategoriesMetadata.ColumnNames.Selectable, value))
				{
					OnPropertyChanged(ADefHelpDeskCategoriesMetadata.PropertyNames.Selectable);
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
						case "CategoryID": this.str().CategoryID = (string)value; break;							
						case "PortalID": this.str().PortalID = (string)value; break;							
						case "ParentCategoryID": this.str().ParentCategoryID = (string)value; break;							
						case "CategoryName": this.str().CategoryName = (string)value; break;							
						case "Level": this.str().Level = (string)value; break;							
						case "RequestorVisible": this.str().RequestorVisible = (string)value; break;							
						case "Selectable": this.str().Selectable = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "CategoryID":
						
							if (value == null || value is System.Int32)
								this.CategoryID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskCategoriesMetadata.PropertyNames.CategoryID);
							break;
						
						case "PortalID":
						
							if (value == null || value is System.Int32)
								this.PortalID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskCategoriesMetadata.PropertyNames.PortalID);
							break;
						
						case "ParentCategoryID":
						
							if (value == null || value is System.Int32)
								this.ParentCategoryID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskCategoriesMetadata.PropertyNames.ParentCategoryID);
							break;
						
						case "Level":
						
							if (value == null || value is System.Int32)
								this.Level = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskCategoriesMetadata.PropertyNames.Level);
							break;
						
						case "RequestorVisible":
						
							if (value == null || value is System.Boolean)
								this.RequestorVisible = (System.Boolean?)value;
								OnPropertyChanged(ADefHelpDeskCategoriesMetadata.PropertyNames.RequestorVisible);
							break;
						
						case "Selectable":
						
							if (value == null || value is System.Boolean)
								this.Selectable = (System.Boolean?)value;
								OnPropertyChanged(ADefHelpDeskCategoriesMetadata.PropertyNames.Selectable);
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
			public esStrings(esADefHelpDeskCategories entity)
			{
				this.entity = entity;
			}
			
	
			public System.String CategoryID
			{
				get
				{
					System.Int32? data = entity.CategoryID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CategoryID = null;
					else entity.CategoryID = Convert.ToInt32(value);
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
				
			public System.String ParentCategoryID
			{
				get
				{
					System.Int32? data = entity.ParentCategoryID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ParentCategoryID = null;
					else entity.ParentCategoryID = Convert.ToInt32(value);
				}
			}
				
			public System.String CategoryName
			{
				get
				{
					System.String data = entity.CategoryName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CategoryName = null;
					else entity.CategoryName = Convert.ToString(value);
				}
			}
				
			public System.String Level
			{
				get
				{
					System.Int32? data = entity.Level;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Level = null;
					else entity.Level = Convert.ToInt32(value);
				}
			}
				
			public System.String RequestorVisible
			{
				get
				{
					System.Boolean? data = entity.RequestorVisible;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.RequestorVisible = null;
					else entity.RequestorVisible = Convert.ToBoolean(value);
				}
			}
				
			public System.String Selectable
			{
				get
				{
					System.Boolean? data = entity.Selectable;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Selectable = null;
					else entity.Selectable = Convert.ToBoolean(value);
				}
			}
			

			private esADefHelpDeskCategories entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskCategoriesMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ADefHelpDeskCategoriesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskCategoriesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskCategoriesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ADefHelpDeskCategoriesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ADefHelpDeskCategoriesQuery query;		
	}



	[Serializable]
	abstract public partial class esADefHelpDeskCategoriesCollection : esEntityCollection<ADefHelpDeskCategories>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskCategoriesMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ADefHelpDeskCategoriesCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ADefHelpDeskCategoriesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskCategoriesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskCategoriesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ADefHelpDeskCategoriesQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ADefHelpDeskCategoriesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ADefHelpDeskCategoriesQuery)query);
		}

		#endregion
		
		private ADefHelpDeskCategoriesQuery query;
	}



	[Serializable]
	abstract public partial class esADefHelpDeskCategoriesQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskCategoriesMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "CategoryID": return this.CategoryID;
				case "PortalID": return this.PortalID;
				case "ParentCategoryID": return this.ParentCategoryID;
				case "CategoryName": return this.CategoryName;
				case "Level": return this.Level;
				case "RequestorVisible": return this.RequestorVisible;
				case "Selectable": return this.Selectable;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem CategoryID
		{
			get { return new esQueryItem(this, ADefHelpDeskCategoriesMetadata.ColumnNames.CategoryID, esSystemType.Int32); }
		} 
		
		public esQueryItem PortalID
		{
			get { return new esQueryItem(this, ADefHelpDeskCategoriesMetadata.ColumnNames.PortalID, esSystemType.Int32); }
		} 
		
		public esQueryItem ParentCategoryID
		{
			get { return new esQueryItem(this, ADefHelpDeskCategoriesMetadata.ColumnNames.ParentCategoryID, esSystemType.Int32); }
		} 
		
		public esQueryItem CategoryName
		{
			get { return new esQueryItem(this, ADefHelpDeskCategoriesMetadata.ColumnNames.CategoryName, esSystemType.String); }
		} 
		
		public esQueryItem Level
		{
			get { return new esQueryItem(this, ADefHelpDeskCategoriesMetadata.ColumnNames.Level, esSystemType.Int32); }
		} 
		
		public esQueryItem RequestorVisible
		{
			get { return new esQueryItem(this, ADefHelpDeskCategoriesMetadata.ColumnNames.RequestorVisible, esSystemType.Boolean); }
		} 
		
		public esQueryItem Selectable
		{
			get { return new esQueryItem(this, ADefHelpDeskCategoriesMetadata.ColumnNames.Selectable, esSystemType.Boolean); }
		} 
		
		#endregion
		
	}


	
	public partial class ADefHelpDeskCategories : esADefHelpDeskCategories
	{

		#region ADefHelpDeskTaskCategoriesCollectionByCategoryID - Zero To Many
		
		static public esPrefetchMap Prefetch_ADefHelpDeskTaskCategoriesCollectionByCategoryID
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap();
				map.PrefetchDelegate = Rscm.Kencana.Helpdesk.BusinessObjects.ADefHelpDeskCategories.ADefHelpDeskTaskCategoriesCollectionByCategoryID_Delegate;
				map.PropertyName = "ADefHelpDeskTaskCategoriesCollectionByCategoryID";
				map.MyColumnName = "CategoryID";
				map.ParentColumnName = "CategoryID";
				map.IsMultiPartKey = false;
				return map;
			}
		}		
		
		static private void ADefHelpDeskTaskCategoriesCollectionByCategoryID_Delegate(esPrefetchParameters data)
		{
			ADefHelpDeskCategoriesQuery parent = new ADefHelpDeskCategoriesQuery(data.NextAlias());

			ADefHelpDeskTaskCategoriesQuery me = data.You != null ? data.You as ADefHelpDeskTaskCategoriesQuery : new ADefHelpDeskTaskCategoriesQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.CategoryID == me.CategoryID);

			data.You = parent;
		}			
		
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_ADefHelpDesk_TaskCategories_ADefHelpDesk_Categories
		/// </summary>

		[XmlIgnore]
		public ADefHelpDeskTaskCategoriesCollection ADefHelpDeskTaskCategoriesCollectionByCategoryID
		{
			get
			{
				if(this._ADefHelpDeskTaskCategoriesCollectionByCategoryID == null)
				{
					this._ADefHelpDeskTaskCategoriesCollectionByCategoryID = new ADefHelpDeskTaskCategoriesCollection();
					this._ADefHelpDeskTaskCategoriesCollectionByCategoryID.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("ADefHelpDeskTaskCategoriesCollectionByCategoryID", this._ADefHelpDeskTaskCategoriesCollectionByCategoryID);
				
					if (this.CategoryID != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._ADefHelpDeskTaskCategoriesCollectionByCategoryID.Query.Where(this._ADefHelpDeskTaskCategoriesCollectionByCategoryID.Query.CategoryID == this.CategoryID);
							this._ADefHelpDeskTaskCategoriesCollectionByCategoryID.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._ADefHelpDeskTaskCategoriesCollectionByCategoryID.fks.Add(ADefHelpDeskTaskCategoriesMetadata.ColumnNames.CategoryID, this.CategoryID);
					}
				}

				return this._ADefHelpDeskTaskCategoriesCollectionByCategoryID;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._ADefHelpDeskTaskCategoriesCollectionByCategoryID != null) 
				{ 
					this.RemovePostSave("ADefHelpDeskTaskCategoriesCollectionByCategoryID"); 
					this._ADefHelpDeskTaskCategoriesCollectionByCategoryID = null;
					
				} 
			} 			
		}
			
		
		private ADefHelpDeskTaskCategoriesCollection _ADefHelpDeskTaskCategoriesCollectionByCategoryID;
		#endregion

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "ADefHelpDeskTaskCategoriesCollectionByCategoryID":
					coll = this.ADefHelpDeskTaskCategoriesCollectionByCategoryID;
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
			
			props.Add(new esPropertyDescriptor(this, "ADefHelpDeskTaskCategoriesCollectionByCategoryID", typeof(ADefHelpDeskTaskCategoriesCollection), new ADefHelpDeskTaskCategories()));
		
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
			if(this._ADefHelpDeskTaskCategoriesCollectionByCategoryID != null)
			{
				Apply(this._ADefHelpDeskTaskCategoriesCollectionByCategoryID, "CategoryID", this.CategoryID);
			}
		}
		
	}
	



	[Serializable]
	public partial class ADefHelpDeskCategoriesMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ADefHelpDeskCategoriesMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ADefHelpDeskCategoriesMetadata.ColumnNames.CategoryID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskCategoriesMetadata.PropertyNames.CategoryID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskCategoriesMetadata.ColumnNames.PortalID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskCategoriesMetadata.PropertyNames.PortalID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskCategoriesMetadata.ColumnNames.ParentCategoryID, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskCategoriesMetadata.PropertyNames.ParentCategoryID;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskCategoriesMetadata.ColumnNames.CategoryName, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskCategoriesMetadata.PropertyNames.CategoryName;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskCategoriesMetadata.ColumnNames.Level, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskCategoriesMetadata.PropertyNames.Level;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskCategoriesMetadata.ColumnNames.RequestorVisible, 5, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ADefHelpDeskCategoriesMetadata.PropertyNames.RequestorVisible;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskCategoriesMetadata.ColumnNames.Selectable, 6, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = ADefHelpDeskCategoriesMetadata.PropertyNames.Selectable;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ADefHelpDeskCategoriesMetadata Meta()
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
			 public const string CategoryID = "CategoryID";
			 public const string PortalID = "PortalID";
			 public const string ParentCategoryID = "ParentCategoryID";
			 public const string CategoryName = "CategoryName";
			 public const string Level = "Level";
			 public const string RequestorVisible = "RequestorVisible";
			 public const string Selectable = "Selectable";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string CategoryID = "CategoryID";
			 public const string PortalID = "PortalID";
			 public const string ParentCategoryID = "ParentCategoryID";
			 public const string CategoryName = "CategoryName";
			 public const string Level = "Level";
			 public const string RequestorVisible = "RequestorVisible";
			 public const string Selectable = "Selectable";
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
			lock (typeof(ADefHelpDeskCategoriesMetadata))
			{
				if(ADefHelpDeskCategoriesMetadata.mapDelegates == null)
				{
					ADefHelpDeskCategoriesMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ADefHelpDeskCategoriesMetadata.meta == null)
				{
					ADefHelpDeskCategoriesMetadata.meta = new ADefHelpDeskCategoriesMetadata();
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


				meta.AddTypeMap("CategoryID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("PortalID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("ParentCategoryID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("CategoryName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Level", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("RequestorVisible", new esTypeMap("bit", "System.Boolean"));
				meta.AddTypeMap("Selectable", new esTypeMap("bit", "System.Boolean"));			
				
				
				
				meta.Source = "ADefHelpDesk_Categories";
				meta.Destination = "ADefHelpDesk_Categories";
				
				meta.spInsert = "proc_ADefHelpDesk_CategoriesInsert";				
				meta.spUpdate = "proc_ADefHelpDesk_CategoriesUpdate";		
				meta.spDelete = "proc_ADefHelpDesk_CategoriesDelete";
				meta.spLoadAll = "proc_ADefHelpDesk_CategoriesLoadAll";
				meta.spLoadByPrimaryKey = "proc_ADefHelpDesk_CategoriesLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ADefHelpDeskCategoriesMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
