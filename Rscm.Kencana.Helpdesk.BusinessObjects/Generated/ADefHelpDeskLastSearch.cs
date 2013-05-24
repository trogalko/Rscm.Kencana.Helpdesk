
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 5/15/2013 10:58:40 AM
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
	/// Encapsulates the 'ADefHelpDesk_LastSearch' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ADefHelpDeskLastSearch))]	
	[XmlType("ADefHelpDeskLastSearch")]
	public partial class ADefHelpDeskLastSearch : esADefHelpDeskLastSearch
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ADefHelpDeskLastSearch();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 id)
		{
			var obj = new ADefHelpDeskLastSearch();
			obj.Id = id;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 id, esSqlAccessType sqlAccessType)
		{
			var obj = new ADefHelpDeskLastSearch();
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
	[XmlType("ADefHelpDeskLastSearchCollection")]
	public partial class ADefHelpDeskLastSearchCollection : esADefHelpDeskLastSearchCollection, IEnumerable<ADefHelpDeskLastSearch>
	{
		public ADefHelpDeskLastSearch FindByPrimaryKey(System.Int32 id)
		{
			return this.SingleOrDefault(e => e.Id == id);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ADefHelpDeskLastSearch))]
		public class ADefHelpDeskLastSearchCollectionWCFPacket : esCollectionWCFPacket<ADefHelpDeskLastSearchCollection>
		{
			public static implicit operator ADefHelpDeskLastSearchCollection(ADefHelpDeskLastSearchCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ADefHelpDeskLastSearchCollectionWCFPacket(ADefHelpDeskLastSearchCollection collection)
			{
				return new ADefHelpDeskLastSearchCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ADefHelpDeskLastSearchQuery : esADefHelpDeskLastSearchQuery
	{
		public ADefHelpDeskLastSearchQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ADefHelpDeskLastSearchQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ADefHelpDeskLastSearchQuery query)
		{
			return ADefHelpDeskLastSearchQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ADefHelpDeskLastSearchQuery(string query)
		{
			return (ADefHelpDeskLastSearchQuery)ADefHelpDeskLastSearchQuery.SerializeHelper.FromXml(query, typeof(ADefHelpDeskLastSearchQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esADefHelpDeskLastSearch : esEntity
	{
		public esADefHelpDeskLastSearch()
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
			ADefHelpDeskLastSearchQuery query = new ADefHelpDeskLastSearchQuery();
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
		/// Maps to ADefHelpDesk_LastSearch.ID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskLastSearchMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskLastSearchMetadata.ColumnNames.Id, value))
				{
					OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.Id);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_LastSearch.UserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? UserID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskLastSearchMetadata.ColumnNames.UserID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskLastSearchMetadata.ColumnNames.UserID, value))
				{
					OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.UserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_LastSearch.PortalID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? PortalID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskLastSearchMetadata.ColumnNames.PortalID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskLastSearchMetadata.ColumnNames.PortalID, value))
				{
					OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.PortalID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_LastSearch.SearchText
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String SearchText
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskLastSearchMetadata.ColumnNames.SearchText);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskLastSearchMetadata.ColumnNames.SearchText, value))
				{
					OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.SearchText);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_LastSearch.Status
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Status
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskLastSearchMetadata.ColumnNames.Status);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskLastSearchMetadata.ColumnNames.Status, value))
				{
					OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.Status);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_LastSearch.Priority
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Priority
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskLastSearchMetadata.ColumnNames.Priority);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskLastSearchMetadata.ColumnNames.Priority, value))
				{
					OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.Priority);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_LastSearch.CreatedDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreatedDate
		{
			get
			{
				return base.GetSystemDateTime(ADefHelpDeskLastSearchMetadata.ColumnNames.CreatedDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ADefHelpDeskLastSearchMetadata.ColumnNames.CreatedDate, value))
				{
					OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.CreatedDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_LastSearch.DueDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? DueDate
		{
			get
			{
				return base.GetSystemDateTime(ADefHelpDeskLastSearchMetadata.ColumnNames.DueDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ADefHelpDeskLastSearchMetadata.ColumnNames.DueDate, value))
				{
					OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.DueDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_LastSearch.AssignedRoleID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? AssignedRoleID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskLastSearchMetadata.ColumnNames.AssignedRoleID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskLastSearchMetadata.ColumnNames.AssignedRoleID, value))
				{
					OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.AssignedRoleID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_LastSearch.Categories
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Categories
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskLastSearchMetadata.ColumnNames.Categories);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskLastSearchMetadata.ColumnNames.Categories, value))
				{
					OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.Categories);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_LastSearch.CurrentPage
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? CurrentPage
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskLastSearchMetadata.ColumnNames.CurrentPage);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskLastSearchMetadata.ColumnNames.CurrentPage, value))
				{
					OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.CurrentPage);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_LastSearch.PageSize
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? PageSize
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskLastSearchMetadata.ColumnNames.PageSize);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskLastSearchMetadata.ColumnNames.PageSize, value))
				{
					OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.PageSize);
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
						case "UserID": this.str().UserID = (string)value; break;							
						case "PortalID": this.str().PortalID = (string)value; break;							
						case "SearchText": this.str().SearchText = (string)value; break;							
						case "Status": this.str().Status = (string)value; break;							
						case "Priority": this.str().Priority = (string)value; break;							
						case "CreatedDate": this.str().CreatedDate = (string)value; break;							
						case "DueDate": this.str().DueDate = (string)value; break;							
						case "AssignedRoleID": this.str().AssignedRoleID = (string)value; break;							
						case "Categories": this.str().Categories = (string)value; break;							
						case "CurrentPage": this.str().CurrentPage = (string)value; break;							
						case "PageSize": this.str().PageSize = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value is System.Int32)
								this.Id = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.Id);
							break;
						
						case "UserID":
						
							if (value == null || value is System.Int32)
								this.UserID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.UserID);
							break;
						
						case "PortalID":
						
							if (value == null || value is System.Int32)
								this.PortalID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.PortalID);
							break;
						
						case "CreatedDate":
						
							if (value == null || value is System.DateTime)
								this.CreatedDate = (System.DateTime?)value;
								OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.CreatedDate);
							break;
						
						case "DueDate":
						
							if (value == null || value is System.DateTime)
								this.DueDate = (System.DateTime?)value;
								OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.DueDate);
							break;
						
						case "AssignedRoleID":
						
							if (value == null || value is System.Int32)
								this.AssignedRoleID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.AssignedRoleID);
							break;
						
						case "CurrentPage":
						
							if (value == null || value is System.Int32)
								this.CurrentPage = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.CurrentPage);
							break;
						
						case "PageSize":
						
							if (value == null || value is System.Int32)
								this.PageSize = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskLastSearchMetadata.PropertyNames.PageSize);
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
			public esStrings(esADefHelpDeskLastSearch entity)
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
				
			public System.String SearchText
			{
				get
				{
					System.String data = entity.SearchText;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SearchText = null;
					else entity.SearchText = Convert.ToString(value);
				}
			}
				
			public System.String Status
			{
				get
				{
					System.String data = entity.Status;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Status = null;
					else entity.Status = Convert.ToString(value);
				}
			}
				
			public System.String Priority
			{
				get
				{
					System.String data = entity.Priority;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Priority = null;
					else entity.Priority = Convert.ToString(value);
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
				
			public System.String AssignedRoleID
			{
				get
				{
					System.Int32? data = entity.AssignedRoleID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AssignedRoleID = null;
					else entity.AssignedRoleID = Convert.ToInt32(value);
				}
			}
				
			public System.String Categories
			{
				get
				{
					System.String data = entity.Categories;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Categories = null;
					else entity.Categories = Convert.ToString(value);
				}
			}
				
			public System.String CurrentPage
			{
				get
				{
					System.Int32? data = entity.CurrentPage;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CurrentPage = null;
					else entity.CurrentPage = Convert.ToInt32(value);
				}
			}
				
			public System.String PageSize
			{
				get
				{
					System.Int32? data = entity.PageSize;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PageSize = null;
					else entity.PageSize = Convert.ToInt32(value);
				}
			}
			

			private esADefHelpDeskLastSearch entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskLastSearchMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ADefHelpDeskLastSearchQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskLastSearchQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskLastSearchQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ADefHelpDeskLastSearchQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ADefHelpDeskLastSearchQuery query;		
	}



	[Serializable]
	abstract public partial class esADefHelpDeskLastSearchCollection : esEntityCollection<ADefHelpDeskLastSearch>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskLastSearchMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ADefHelpDeskLastSearchCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ADefHelpDeskLastSearchQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskLastSearchQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskLastSearchQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ADefHelpDeskLastSearchQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ADefHelpDeskLastSearchQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ADefHelpDeskLastSearchQuery)query);
		}

		#endregion
		
		private ADefHelpDeskLastSearchQuery query;
	}



	[Serializable]
	abstract public partial class esADefHelpDeskLastSearchQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskLastSearchMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "Id": return this.Id;
				case "UserID": return this.UserID;
				case "PortalID": return this.PortalID;
				case "SearchText": return this.SearchText;
				case "Status": return this.Status;
				case "Priority": return this.Priority;
				case "CreatedDate": return this.CreatedDate;
				case "DueDate": return this.DueDate;
				case "AssignedRoleID": return this.AssignedRoleID;
				case "Categories": return this.Categories;
				case "CurrentPage": return this.CurrentPage;
				case "PageSize": return this.PageSize;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem Id
		{
			get { return new esQueryItem(this, ADefHelpDeskLastSearchMetadata.ColumnNames.Id, esSystemType.Int32); }
		} 
		
		public esQueryItem UserID
		{
			get { return new esQueryItem(this, ADefHelpDeskLastSearchMetadata.ColumnNames.UserID, esSystemType.Int32); }
		} 
		
		public esQueryItem PortalID
		{
			get { return new esQueryItem(this, ADefHelpDeskLastSearchMetadata.ColumnNames.PortalID, esSystemType.Int32); }
		} 
		
		public esQueryItem SearchText
		{
			get { return new esQueryItem(this, ADefHelpDeskLastSearchMetadata.ColumnNames.SearchText, esSystemType.String); }
		} 
		
		public esQueryItem Status
		{
			get { return new esQueryItem(this, ADefHelpDeskLastSearchMetadata.ColumnNames.Status, esSystemType.String); }
		} 
		
		public esQueryItem Priority
		{
			get { return new esQueryItem(this, ADefHelpDeskLastSearchMetadata.ColumnNames.Priority, esSystemType.String); }
		} 
		
		public esQueryItem CreatedDate
		{
			get { return new esQueryItem(this, ADefHelpDeskLastSearchMetadata.ColumnNames.CreatedDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem DueDate
		{
			get { return new esQueryItem(this, ADefHelpDeskLastSearchMetadata.ColumnNames.DueDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem AssignedRoleID
		{
			get { return new esQueryItem(this, ADefHelpDeskLastSearchMetadata.ColumnNames.AssignedRoleID, esSystemType.Int32); }
		} 
		
		public esQueryItem Categories
		{
			get { return new esQueryItem(this, ADefHelpDeskLastSearchMetadata.ColumnNames.Categories, esSystemType.String); }
		} 
		
		public esQueryItem CurrentPage
		{
			get { return new esQueryItem(this, ADefHelpDeskLastSearchMetadata.ColumnNames.CurrentPage, esSystemType.Int32); }
		} 
		
		public esQueryItem PageSize
		{
			get { return new esQueryItem(this, ADefHelpDeskLastSearchMetadata.ColumnNames.PageSize, esSystemType.Int32); }
		} 
		
		#endregion
		
	}


	
	public partial class ADefHelpDeskLastSearch : esADefHelpDeskLastSearch
	{

		
		
	}
	



	[Serializable]
	public partial class ADefHelpDeskLastSearchMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ADefHelpDeskLastSearchMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ADefHelpDeskLastSearchMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskLastSearchMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskLastSearchMetadata.ColumnNames.UserID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskLastSearchMetadata.PropertyNames.UserID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskLastSearchMetadata.ColumnNames.PortalID, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskLastSearchMetadata.PropertyNames.PortalID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskLastSearchMetadata.ColumnNames.SearchText, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskLastSearchMetadata.PropertyNames.SearchText;
			c.CharacterMaxLength = 150;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskLastSearchMetadata.ColumnNames.Status, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskLastSearchMetadata.PropertyNames.Status;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskLastSearchMetadata.ColumnNames.Priority, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskLastSearchMetadata.PropertyNames.Priority;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskLastSearchMetadata.ColumnNames.CreatedDate, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ADefHelpDeskLastSearchMetadata.PropertyNames.CreatedDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskLastSearchMetadata.ColumnNames.DueDate, 7, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ADefHelpDeskLastSearchMetadata.PropertyNames.DueDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskLastSearchMetadata.ColumnNames.AssignedRoleID, 8, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskLastSearchMetadata.PropertyNames.AssignedRoleID;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskLastSearchMetadata.ColumnNames.Categories, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskLastSearchMetadata.PropertyNames.Categories;
			c.CharacterMaxLength = 2000;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskLastSearchMetadata.ColumnNames.CurrentPage, 10, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskLastSearchMetadata.PropertyNames.CurrentPage;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskLastSearchMetadata.ColumnNames.PageSize, 11, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskLastSearchMetadata.PropertyNames.PageSize;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ADefHelpDeskLastSearchMetadata Meta()
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
			 public const string Id = "ID";
			 public const string UserID = "UserID";
			 public const string PortalID = "PortalID";
			 public const string SearchText = "SearchText";
			 public const string Status = "Status";
			 public const string Priority = "Priority";
			 public const string CreatedDate = "CreatedDate";
			 public const string DueDate = "DueDate";
			 public const string AssignedRoleID = "AssignedRoleID";
			 public const string Categories = "Categories";
			 public const string CurrentPage = "CurrentPage";
			 public const string PageSize = "PageSize";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string UserID = "UserID";
			 public const string PortalID = "PortalID";
			 public const string SearchText = "SearchText";
			 public const string Status = "Status";
			 public const string Priority = "Priority";
			 public const string CreatedDate = "CreatedDate";
			 public const string DueDate = "DueDate";
			 public const string AssignedRoleID = "AssignedRoleID";
			 public const string Categories = "Categories";
			 public const string CurrentPage = "CurrentPage";
			 public const string PageSize = "PageSize";
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
			lock (typeof(ADefHelpDeskLastSearchMetadata))
			{
				if(ADefHelpDeskLastSearchMetadata.mapDelegates == null)
				{
					ADefHelpDeskLastSearchMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ADefHelpDeskLastSearchMetadata.meta == null)
				{
					ADefHelpDeskLastSearchMetadata.meta = new ADefHelpDeskLastSearchMetadata();
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
				meta.AddTypeMap("UserID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("PortalID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("SearchText", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Status", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Priority", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("CreatedDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("DueDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("AssignedRoleID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Categories", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("CurrentPage", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("PageSize", new esTypeMap("int", "System.Int32"));			
				
				
				
				meta.Source = "ADefHelpDesk_LastSearch";
				meta.Destination = "ADefHelpDesk_LastSearch";
				
				meta.spInsert = "proc_ADefHelpDesk_LastSearchInsert";				
				meta.spUpdate = "proc_ADefHelpDesk_LastSearchUpdate";		
				meta.spDelete = "proc_ADefHelpDesk_LastSearchDelete";
				meta.spLoadAll = "proc_ADefHelpDesk_LastSearchLoadAll";
				meta.spLoadByPrimaryKey = "proc_ADefHelpDesk_LastSearchLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ADefHelpDeskLastSearchMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
