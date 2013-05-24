
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
	/// Encapsulates the 'ADefHelpDesk_TaskDetails' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ADefHelpDeskTaskDetails))]	
	[XmlType("ADefHelpDeskTaskDetails")]
	public partial class ADefHelpDeskTaskDetails : esADefHelpDeskTaskDetails
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ADefHelpDeskTaskDetails();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 detailID)
		{
			var obj = new ADefHelpDeskTaskDetails();
			obj.DetailID = detailID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 detailID, esSqlAccessType sqlAccessType)
		{
			var obj = new ADefHelpDeskTaskDetails();
			obj.DetailID = detailID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("ADefHelpDeskTaskDetailsCollection")]
	public partial class ADefHelpDeskTaskDetailsCollection : esADefHelpDeskTaskDetailsCollection, IEnumerable<ADefHelpDeskTaskDetails>
	{
		public ADefHelpDeskTaskDetails FindByPrimaryKey(System.Int32 detailID)
		{
			return this.SingleOrDefault(e => e.DetailID == detailID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ADefHelpDeskTaskDetails))]
		public class ADefHelpDeskTaskDetailsCollectionWCFPacket : esCollectionWCFPacket<ADefHelpDeskTaskDetailsCollection>
		{
			public static implicit operator ADefHelpDeskTaskDetailsCollection(ADefHelpDeskTaskDetailsCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ADefHelpDeskTaskDetailsCollectionWCFPacket(ADefHelpDeskTaskDetailsCollection collection)
			{
				return new ADefHelpDeskTaskDetailsCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ADefHelpDeskTaskDetailsQuery : esADefHelpDeskTaskDetailsQuery
	{
		public ADefHelpDeskTaskDetailsQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ADefHelpDeskTaskDetailsQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ADefHelpDeskTaskDetailsQuery query)
		{
			return ADefHelpDeskTaskDetailsQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ADefHelpDeskTaskDetailsQuery(string query)
		{
			return (ADefHelpDeskTaskDetailsQuery)ADefHelpDeskTaskDetailsQuery.SerializeHelper.FromXml(query, typeof(ADefHelpDeskTaskDetailsQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esADefHelpDeskTaskDetails : esEntity
	{
		public esADefHelpDeskTaskDetails()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 detailID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(detailID);
			else
				return LoadByPrimaryKeyStoredProcedure(detailID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 detailID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(detailID);
			else
				return LoadByPrimaryKeyStoredProcedure(detailID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 detailID)
		{
			ADefHelpDeskTaskDetailsQuery query = new ADefHelpDeskTaskDetailsQuery();
			query.Where(query.DetailID == detailID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 detailID)
		{
			esParameters parms = new esParameters();
			parms.Add("DetailID", detailID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to ADefHelpDesk_TaskDetails.DetailID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? DetailID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskTaskDetailsMetadata.ColumnNames.DetailID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskTaskDetailsMetadata.ColumnNames.DetailID, value))
				{
					OnPropertyChanged(ADefHelpDeskTaskDetailsMetadata.PropertyNames.DetailID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_TaskDetails.TaskID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? TaskID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskTaskDetailsMetadata.ColumnNames.TaskID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskTaskDetailsMetadata.ColumnNames.TaskID, value))
				{
					this._UpToADefHelpDeskTasksByTaskID = null;
					this.OnPropertyChanged("UpToADefHelpDeskTasksByTaskID");
					OnPropertyChanged(ADefHelpDeskTaskDetailsMetadata.PropertyNames.TaskID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_TaskDetails.DetailType
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String DetailType
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskTaskDetailsMetadata.ColumnNames.DetailType);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskTaskDetailsMetadata.ColumnNames.DetailType, value))
				{
					OnPropertyChanged(ADefHelpDeskTaskDetailsMetadata.PropertyNames.DetailType);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_TaskDetails.InsertDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? InsertDate
		{
			get
			{
				return base.GetSystemDateTime(ADefHelpDeskTaskDetailsMetadata.ColumnNames.InsertDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ADefHelpDeskTaskDetailsMetadata.ColumnNames.InsertDate, value))
				{
					OnPropertyChanged(ADefHelpDeskTaskDetailsMetadata.PropertyNames.InsertDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_TaskDetails.UserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? UserID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskTaskDetailsMetadata.ColumnNames.UserID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskTaskDetailsMetadata.ColumnNames.UserID, value))
				{
					OnPropertyChanged(ADefHelpDeskTaskDetailsMetadata.PropertyNames.UserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_TaskDetails.Description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskTaskDetailsMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskTaskDetailsMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(ADefHelpDeskTaskDetailsMetadata.PropertyNames.Description);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_TaskDetails.StartTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? StartTime
		{
			get
			{
				return base.GetSystemDateTime(ADefHelpDeskTaskDetailsMetadata.ColumnNames.StartTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(ADefHelpDeskTaskDetailsMetadata.ColumnNames.StartTime, value))
				{
					OnPropertyChanged(ADefHelpDeskTaskDetailsMetadata.PropertyNames.StartTime);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_TaskDetails.StopTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? StopTime
		{
			get
			{
				return base.GetSystemDateTime(ADefHelpDeskTaskDetailsMetadata.ColumnNames.StopTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(ADefHelpDeskTaskDetailsMetadata.ColumnNames.StopTime, value))
				{
					OnPropertyChanged(ADefHelpDeskTaskDetailsMetadata.PropertyNames.StopTime);
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
						case "DetailID": this.str().DetailID = (string)value; break;							
						case "TaskID": this.str().TaskID = (string)value; break;							
						case "DetailType": this.str().DetailType = (string)value; break;							
						case "InsertDate": this.str().InsertDate = (string)value; break;							
						case "UserID": this.str().UserID = (string)value; break;							
						case "Description": this.str().Description = (string)value; break;							
						case "StartTime": this.str().StartTime = (string)value; break;							
						case "StopTime": this.str().StopTime = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "DetailID":
						
							if (value == null || value is System.Int32)
								this.DetailID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskTaskDetailsMetadata.PropertyNames.DetailID);
							break;
						
						case "TaskID":
						
							if (value == null || value is System.Int32)
								this.TaskID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskTaskDetailsMetadata.PropertyNames.TaskID);
							break;
						
						case "InsertDate":
						
							if (value == null || value is System.DateTime)
								this.InsertDate = (System.DateTime?)value;
								OnPropertyChanged(ADefHelpDeskTaskDetailsMetadata.PropertyNames.InsertDate);
							break;
						
						case "UserID":
						
							if (value == null || value is System.Int32)
								this.UserID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskTaskDetailsMetadata.PropertyNames.UserID);
							break;
						
						case "StartTime":
						
							if (value == null || value is System.DateTime)
								this.StartTime = (System.DateTime?)value;
								OnPropertyChanged(ADefHelpDeskTaskDetailsMetadata.PropertyNames.StartTime);
							break;
						
						case "StopTime":
						
							if (value == null || value is System.DateTime)
								this.StopTime = (System.DateTime?)value;
								OnPropertyChanged(ADefHelpDeskTaskDetailsMetadata.PropertyNames.StopTime);
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
			public esStrings(esADefHelpDeskTaskDetails entity)
			{
				this.entity = entity;
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
				
			public System.String DetailType
			{
				get
				{
					System.String data = entity.DetailType;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.DetailType = null;
					else entity.DetailType = Convert.ToString(value);
				}
			}
				
			public System.String InsertDate
			{
				get
				{
					System.DateTime? data = entity.InsertDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.InsertDate = null;
					else entity.InsertDate = Convert.ToDateTime(value);
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
				
			public System.String Description
			{
				get
				{
					System.String data = entity.Description;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Description = null;
					else entity.Description = Convert.ToString(value);
				}
			}
				
			public System.String StartTime
			{
				get
				{
					System.DateTime? data = entity.StartTime;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.StartTime = null;
					else entity.StartTime = Convert.ToDateTime(value);
				}
			}
				
			public System.String StopTime
			{
				get
				{
					System.DateTime? data = entity.StopTime;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.StopTime = null;
					else entity.StopTime = Convert.ToDateTime(value);
				}
			}
			

			private esADefHelpDeskTaskDetails entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskTaskDetailsMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ADefHelpDeskTaskDetailsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskTaskDetailsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskTaskDetailsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ADefHelpDeskTaskDetailsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ADefHelpDeskTaskDetailsQuery query;		
	}



	[Serializable]
	abstract public partial class esADefHelpDeskTaskDetailsCollection : esEntityCollection<ADefHelpDeskTaskDetails>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskTaskDetailsMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ADefHelpDeskTaskDetailsCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ADefHelpDeskTaskDetailsQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskTaskDetailsQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskTaskDetailsQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ADefHelpDeskTaskDetailsQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ADefHelpDeskTaskDetailsQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ADefHelpDeskTaskDetailsQuery)query);
		}

		#endregion
		
		private ADefHelpDeskTaskDetailsQuery query;
	}



	[Serializable]
	abstract public partial class esADefHelpDeskTaskDetailsQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskTaskDetailsMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "DetailID": return this.DetailID;
				case "TaskID": return this.TaskID;
				case "DetailType": return this.DetailType;
				case "InsertDate": return this.InsertDate;
				case "UserID": return this.UserID;
				case "Description": return this.Description;
				case "StartTime": return this.StartTime;
				case "StopTime": return this.StopTime;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem DetailID
		{
			get { return new esQueryItem(this, ADefHelpDeskTaskDetailsMetadata.ColumnNames.DetailID, esSystemType.Int32); }
		} 
		
		public esQueryItem TaskID
		{
			get { return new esQueryItem(this, ADefHelpDeskTaskDetailsMetadata.ColumnNames.TaskID, esSystemType.Int32); }
		} 
		
		public esQueryItem DetailType
		{
			get { return new esQueryItem(this, ADefHelpDeskTaskDetailsMetadata.ColumnNames.DetailType, esSystemType.String); }
		} 
		
		public esQueryItem InsertDate
		{
			get { return new esQueryItem(this, ADefHelpDeskTaskDetailsMetadata.ColumnNames.InsertDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem UserID
		{
			get { return new esQueryItem(this, ADefHelpDeskTaskDetailsMetadata.ColumnNames.UserID, esSystemType.Int32); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, ADefHelpDeskTaskDetailsMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		public esQueryItem StartTime
		{
			get { return new esQueryItem(this, ADefHelpDeskTaskDetailsMetadata.ColumnNames.StartTime, esSystemType.DateTime); }
		} 
		
		public esQueryItem StopTime
		{
			get { return new esQueryItem(this, ADefHelpDeskTaskDetailsMetadata.ColumnNames.StopTime, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class ADefHelpDeskTaskDetails : esADefHelpDeskTaskDetails
	{

		#region ADefHelpDeskAttachmentsCollectionByDetailID - Zero To Many
		
		static public esPrefetchMap Prefetch_ADefHelpDeskAttachmentsCollectionByDetailID
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap();
				map.PrefetchDelegate = Rscm.Kencana.Helpdesk.BusinessObjects.ADefHelpDeskTaskDetails.ADefHelpDeskAttachmentsCollectionByDetailID_Delegate;
				map.PropertyName = "ADefHelpDeskAttachmentsCollectionByDetailID";
				map.MyColumnName = "DetailID";
				map.ParentColumnName = "DetailID";
				map.IsMultiPartKey = false;
				return map;
			}
		}		
		
		static private void ADefHelpDeskAttachmentsCollectionByDetailID_Delegate(esPrefetchParameters data)
		{
			ADefHelpDeskTaskDetailsQuery parent = new ADefHelpDeskTaskDetailsQuery(data.NextAlias());

			ADefHelpDeskAttachmentsQuery me = data.You != null ? data.You as ADefHelpDeskAttachmentsQuery : new ADefHelpDeskAttachmentsQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.DetailID == me.DetailID);

			data.You = parent;
		}			
		
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_ADefHelpDesk_Attachments_ADefHelpDesk_TaskDetails
		/// </summary>

		[XmlIgnore]
		public ADefHelpDeskAttachmentsCollection ADefHelpDeskAttachmentsCollectionByDetailID
		{
			get
			{
				if(this._ADefHelpDeskAttachmentsCollectionByDetailID == null)
				{
					this._ADefHelpDeskAttachmentsCollectionByDetailID = new ADefHelpDeskAttachmentsCollection();
					this._ADefHelpDeskAttachmentsCollectionByDetailID.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("ADefHelpDeskAttachmentsCollectionByDetailID", this._ADefHelpDeskAttachmentsCollectionByDetailID);
				
					if (this.DetailID != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._ADefHelpDeskAttachmentsCollectionByDetailID.Query.Where(this._ADefHelpDeskAttachmentsCollectionByDetailID.Query.DetailID == this.DetailID);
							this._ADefHelpDeskAttachmentsCollectionByDetailID.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._ADefHelpDeskAttachmentsCollectionByDetailID.fks.Add(ADefHelpDeskAttachmentsMetadata.ColumnNames.DetailID, this.DetailID);
					}
				}

				return this._ADefHelpDeskAttachmentsCollectionByDetailID;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._ADefHelpDeskAttachmentsCollectionByDetailID != null) 
				{ 
					this.RemovePostSave("ADefHelpDeskAttachmentsCollectionByDetailID"); 
					this._ADefHelpDeskAttachmentsCollectionByDetailID = null;
					
				} 
			} 			
		}
			
		
		private ADefHelpDeskAttachmentsCollection _ADefHelpDeskAttachmentsCollectionByDetailID;
		#endregion

				
		#region UpToADefHelpDeskTasksByTaskID - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - FK_ADefHelpDesk_TaskDetails_ADefHelpDesk_Tasks
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
		

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "ADefHelpDeskAttachmentsCollectionByDetailID":
					coll = this.ADefHelpDeskAttachmentsCollectionByDetailID;
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
			
			props.Add(new esPropertyDescriptor(this, "ADefHelpDeskAttachmentsCollectionByDetailID", typeof(ADefHelpDeskAttachmentsCollection), new ADefHelpDeskAttachments()));
		
			return props;
		}
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
			if(this._ADefHelpDeskAttachmentsCollectionByDetailID != null)
			{
				Apply(this._ADefHelpDeskAttachmentsCollectionByDetailID, "DetailID", this.DetailID);
			}
		}
		
	}
	



	[Serializable]
	public partial class ADefHelpDeskTaskDetailsMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ADefHelpDeskTaskDetailsMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ADefHelpDeskTaskDetailsMetadata.ColumnNames.DetailID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskTaskDetailsMetadata.PropertyNames.DetailID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTaskDetailsMetadata.ColumnNames.TaskID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskTaskDetailsMetadata.PropertyNames.TaskID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTaskDetailsMetadata.ColumnNames.DetailType, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskTaskDetailsMetadata.PropertyNames.DetailType;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTaskDetailsMetadata.ColumnNames.InsertDate, 3, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ADefHelpDeskTaskDetailsMetadata.PropertyNames.InsertDate;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTaskDetailsMetadata.ColumnNames.UserID, 4, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskTaskDetailsMetadata.PropertyNames.UserID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTaskDetailsMetadata.ColumnNames.Description, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskTaskDetailsMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 1073741823;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTaskDetailsMetadata.ColumnNames.StartTime, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ADefHelpDeskTaskDetailsMetadata.PropertyNames.StartTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTaskDetailsMetadata.ColumnNames.StopTime, 7, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ADefHelpDeskTaskDetailsMetadata.PropertyNames.StopTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ADefHelpDeskTaskDetailsMetadata Meta()
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
			 public const string DetailID = "DetailID";
			 public const string TaskID = "TaskID";
			 public const string DetailType = "DetailType";
			 public const string InsertDate = "InsertDate";
			 public const string UserID = "UserID";
			 public const string Description = "Description";
			 public const string StartTime = "StartTime";
			 public const string StopTime = "StopTime";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string DetailID = "DetailID";
			 public const string TaskID = "TaskID";
			 public const string DetailType = "DetailType";
			 public const string InsertDate = "InsertDate";
			 public const string UserID = "UserID";
			 public const string Description = "Description";
			 public const string StartTime = "StartTime";
			 public const string StopTime = "StopTime";
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
			lock (typeof(ADefHelpDeskTaskDetailsMetadata))
			{
				if(ADefHelpDeskTaskDetailsMetadata.mapDelegates == null)
				{
					ADefHelpDeskTaskDetailsMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ADefHelpDeskTaskDetailsMetadata.meta == null)
				{
					ADefHelpDeskTaskDetailsMetadata.meta = new ADefHelpDeskTaskDetailsMetadata();
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


				meta.AddTypeMap("DetailID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("TaskID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("DetailType", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("InsertDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("UserID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("StartTime", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("StopTime", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "ADefHelpDesk_TaskDetails";
				meta.Destination = "ADefHelpDesk_TaskDetails";
				
				meta.spInsert = "proc_ADefHelpDesk_TaskDetailsInsert";				
				meta.spUpdate = "proc_ADefHelpDesk_TaskDetailsUpdate";		
				meta.spDelete = "proc_ADefHelpDesk_TaskDetailsDelete";
				meta.spLoadAll = "proc_ADefHelpDesk_TaskDetailsLoadAll";
				meta.spLoadByPrimaryKey = "proc_ADefHelpDesk_TaskDetailsLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ADefHelpDeskTaskDetailsMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
