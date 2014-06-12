
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 6/11/2014 9:33:46 AM
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
	/// Encapsulates the 'ADefHelpDesk_Tasks' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(ADefHelpDeskTasks))]	
	[XmlType("ADefHelpDeskTasks")]
	public partial class ADefHelpDeskTasks : esADefHelpDeskTasks
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new ADefHelpDeskTasks();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.Int32 taskID)
		{
			var obj = new ADefHelpDeskTasks();
			obj.TaskID = taskID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.Int32 taskID, esSqlAccessType sqlAccessType)
		{
			var obj = new ADefHelpDeskTasks();
			obj.TaskID = taskID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("ADefHelpDeskTasksCollection")]
	public partial class ADefHelpDeskTasksCollection : esADefHelpDeskTasksCollection, IEnumerable<ADefHelpDeskTasks>
	{
		public ADefHelpDeskTasks FindByPrimaryKey(System.Int32 taskID)
		{
			return this.SingleOrDefault(e => e.TaskID == taskID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(ADefHelpDeskTasks))]
		public class ADefHelpDeskTasksCollectionWCFPacket : esCollectionWCFPacket<ADefHelpDeskTasksCollection>
		{
			public static implicit operator ADefHelpDeskTasksCollection(ADefHelpDeskTasksCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator ADefHelpDeskTasksCollectionWCFPacket(ADefHelpDeskTasksCollection collection)
			{
				return new ADefHelpDeskTasksCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]	
	public partial class ADefHelpDeskTasksQuery : esADefHelpDeskTasksQuery
	{
		public ADefHelpDeskTasksQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "ADefHelpDeskTasksQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(ADefHelpDeskTasksQuery query)
		{
			return ADefHelpDeskTasksQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator ADefHelpDeskTasksQuery(string query)
		{
			return (ADefHelpDeskTasksQuery)ADefHelpDeskTasksQuery.SerializeHelper.FromXml(query, typeof(ADefHelpDeskTasksQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esADefHelpDeskTasks : esEntity
	{
		public esADefHelpDeskTasks()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 taskID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(taskID);
			else
				return LoadByPrimaryKeyStoredProcedure(taskID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 taskID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(taskID);
			else
				return LoadByPrimaryKeyStoredProcedure(taskID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 taskID)
		{
			ADefHelpDeskTasksQuery query = new ADefHelpDeskTasksQuery();
			query.Where(query.TaskID == taskID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 taskID)
		{
			esParameters parms = new esParameters();
			parms.Add("TaskID", taskID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.TaskID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? TaskID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskTasksMetadata.ColumnNames.TaskID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskTasksMetadata.ColumnNames.TaskID, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.TaskID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.PortalID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? PortalID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskTasksMetadata.ColumnNames.PortalID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskTasksMetadata.ColumnNames.PortalID, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.PortalID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.Description
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Description
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskTasksMetadata.ColumnNames.Description);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskTasksMetadata.ColumnNames.Description, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.Description);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.Status
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Status
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskTasksMetadata.ColumnNames.Status);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskTasksMetadata.ColumnNames.Status, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.Status);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.Priority
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Priority
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskTasksMetadata.ColumnNames.Priority);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskTasksMetadata.ColumnNames.Priority, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.Priority);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.CreatedDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CreatedDate
		{
			get
			{
				return base.GetSystemDateTime(ADefHelpDeskTasksMetadata.ColumnNames.CreatedDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ADefHelpDeskTasksMetadata.ColumnNames.CreatedDate, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.CreatedDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.EstimatedStart
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? EstimatedStart
		{
			get
			{
				return base.GetSystemDateTime(ADefHelpDeskTasksMetadata.ColumnNames.EstimatedStart);
			}
			
			set
			{
				if(base.SetSystemDateTime(ADefHelpDeskTasksMetadata.ColumnNames.EstimatedStart, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.EstimatedStart);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.EstimatedCompletion
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? EstimatedCompletion
		{
			get
			{
				return base.GetSystemDateTime(ADefHelpDeskTasksMetadata.ColumnNames.EstimatedCompletion);
			}
			
			set
			{
				if(base.SetSystemDateTime(ADefHelpDeskTasksMetadata.ColumnNames.EstimatedCompletion, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.EstimatedCompletion);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.DueDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? DueDate
		{
			get
			{
				return base.GetSystemDateTime(ADefHelpDeskTasksMetadata.ColumnNames.DueDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ADefHelpDeskTasksMetadata.ColumnNames.DueDate, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.DueDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.AssignedRoleID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? AssignedRoleID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskTasksMetadata.ColumnNames.AssignedRoleID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskTasksMetadata.ColumnNames.AssignedRoleID, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.AssignedRoleID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.TicketPassword
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String TicketPassword
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskTasksMetadata.ColumnNames.TicketPassword);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskTasksMetadata.ColumnNames.TicketPassword, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.TicketPassword);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.RequesterUserID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? RequesterUserID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskTasksMetadata.ColumnNames.RequesterUserID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskTasksMetadata.ColumnNames.RequesterUserID, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.RequesterUserID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.RequesterName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String RequesterName
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskTasksMetadata.ColumnNames.RequesterName);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskTasksMetadata.ColumnNames.RequesterName, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.RequesterName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.RequesterEmail
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String RequesterEmail
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskTasksMetadata.ColumnNames.RequesterEmail);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskTasksMetadata.ColumnNames.RequesterEmail, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.RequesterEmail);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.RequesterPhone
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String RequesterPhone
		{
			get
			{
				return base.GetSystemString(ADefHelpDeskTasksMetadata.ColumnNames.RequesterPhone);
			}
			
			set
			{
				if(base.SetSystemString(ADefHelpDeskTasksMetadata.ColumnNames.RequesterPhone, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.RequesterPhone);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.EstimatedHours
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? EstimatedHours
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskTasksMetadata.ColumnNames.EstimatedHours);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskTasksMetadata.ColumnNames.EstimatedHours, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.EstimatedHours);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.ConfirmAsFinishDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? ConfirmAsFinishDate
		{
			get
			{
				return base.GetSystemDateTime(ADefHelpDeskTasksMetadata.ColumnNames.ConfirmAsFinishDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ADefHelpDeskTasksMetadata.ColumnNames.ConfirmAsFinishDate, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.ConfirmAsFinishDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.CancelledDate
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? CancelledDate
		{
			get
			{
				return base.GetSystemDateTime(ADefHelpDeskTasksMetadata.ColumnNames.CancelledDate);
			}
			
			set
			{
				if(base.SetSystemDateTime(ADefHelpDeskTasksMetadata.ColumnNames.CancelledDate, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.CancelledDate);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.ApprovedByRequestorID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.Int32? ApprovedByRequestorID
		{
			get
			{
				return base.GetSystemInt32(ADefHelpDeskTasksMetadata.ColumnNames.ApprovedByRequestorID);
			}
			
			set
			{
				if(base.SetSystemInt32(ADefHelpDeskTasksMetadata.ColumnNames.ApprovedByRequestorID, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.ApprovedByRequestorID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to ADefHelpDesk_Tasks.ApprovedByRequestorDateTime
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.DateTime? ApprovedByRequestorDateTime
		{
			get
			{
				return base.GetSystemDateTime(ADefHelpDeskTasksMetadata.ColumnNames.ApprovedByRequestorDateTime);
			}
			
			set
			{
				if(base.SetSystemDateTime(ADefHelpDeskTasksMetadata.ColumnNames.ApprovedByRequestorDateTime, value))
				{
					OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.ApprovedByRequestorDateTime);
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
						case "TaskID": this.str().TaskID = (string)value; break;							
						case "PortalID": this.str().PortalID = (string)value; break;							
						case "Description": this.str().Description = (string)value; break;							
						case "Status": this.str().Status = (string)value; break;							
						case "Priority": this.str().Priority = (string)value; break;							
						case "CreatedDate": this.str().CreatedDate = (string)value; break;							
						case "EstimatedStart": this.str().EstimatedStart = (string)value; break;							
						case "EstimatedCompletion": this.str().EstimatedCompletion = (string)value; break;							
						case "DueDate": this.str().DueDate = (string)value; break;							
						case "AssignedRoleID": this.str().AssignedRoleID = (string)value; break;							
						case "TicketPassword": this.str().TicketPassword = (string)value; break;							
						case "RequesterUserID": this.str().RequesterUserID = (string)value; break;							
						case "RequesterName": this.str().RequesterName = (string)value; break;							
						case "RequesterEmail": this.str().RequesterEmail = (string)value; break;							
						case "RequesterPhone": this.str().RequesterPhone = (string)value; break;							
						case "EstimatedHours": this.str().EstimatedHours = (string)value; break;							
						case "ConfirmAsFinishDate": this.str().ConfirmAsFinishDate = (string)value; break;							
						case "CancelledDate": this.str().CancelledDate = (string)value; break;							
						case "ApprovedByRequestorID": this.str().ApprovedByRequestorID = (string)value; break;							
						case "ApprovedByRequestorDateTime": this.str().ApprovedByRequestorDateTime = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "TaskID":
						
							if (value == null || value is System.Int32)
								this.TaskID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.TaskID);
							break;
						
						case "PortalID":
						
							if (value == null || value is System.Int32)
								this.PortalID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.PortalID);
							break;
						
						case "CreatedDate":
						
							if (value == null || value is System.DateTime)
								this.CreatedDate = (System.DateTime?)value;
								OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.CreatedDate);
							break;
						
						case "EstimatedStart":
						
							if (value == null || value is System.DateTime)
								this.EstimatedStart = (System.DateTime?)value;
								OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.EstimatedStart);
							break;
						
						case "EstimatedCompletion":
						
							if (value == null || value is System.DateTime)
								this.EstimatedCompletion = (System.DateTime?)value;
								OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.EstimatedCompletion);
							break;
						
						case "DueDate":
						
							if (value == null || value is System.DateTime)
								this.DueDate = (System.DateTime?)value;
								OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.DueDate);
							break;
						
						case "AssignedRoleID":
						
							if (value == null || value is System.Int32)
								this.AssignedRoleID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.AssignedRoleID);
							break;
						
						case "RequesterUserID":
						
							if (value == null || value is System.Int32)
								this.RequesterUserID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.RequesterUserID);
							break;
						
						case "EstimatedHours":
						
							if (value == null || value is System.Int32)
								this.EstimatedHours = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.EstimatedHours);
							break;
						
						case "ConfirmAsFinishDate":
						
							if (value == null || value is System.DateTime)
								this.ConfirmAsFinishDate = (System.DateTime?)value;
								OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.ConfirmAsFinishDate);
							break;
						
						case "CancelledDate":
						
							if (value == null || value is System.DateTime)
								this.CancelledDate = (System.DateTime?)value;
								OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.CancelledDate);
							break;
						
						case "ApprovedByRequestorID":
						
							if (value == null || value is System.Int32)
								this.ApprovedByRequestorID = (System.Int32?)value;
								OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.ApprovedByRequestorID);
							break;
						
						case "ApprovedByRequestorDateTime":
						
							if (value == null || value is System.DateTime)
								this.ApprovedByRequestorDateTime = (System.DateTime?)value;
								OnPropertyChanged(ADefHelpDeskTasksMetadata.PropertyNames.ApprovedByRequestorDateTime);
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
			public esStrings(esADefHelpDeskTasks entity)
			{
				this.entity = entity;
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
				
			public System.String EstimatedStart
			{
				get
				{
					System.DateTime? data = entity.EstimatedStart;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.EstimatedStart = null;
					else entity.EstimatedStart = Convert.ToDateTime(value);
				}
			}
				
			public System.String EstimatedCompletion
			{
				get
				{
					System.DateTime? data = entity.EstimatedCompletion;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.EstimatedCompletion = null;
					else entity.EstimatedCompletion = Convert.ToDateTime(value);
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
				
			public System.String TicketPassword
			{
				get
				{
					System.String data = entity.TicketPassword;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.TicketPassword = null;
					else entity.TicketPassword = Convert.ToString(value);
				}
			}
				
			public System.String RequesterUserID
			{
				get
				{
					System.Int32? data = entity.RequesterUserID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.RequesterUserID = null;
					else entity.RequesterUserID = Convert.ToInt32(value);
				}
			}
				
			public System.String RequesterName
			{
				get
				{
					System.String data = entity.RequesterName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.RequesterName = null;
					else entity.RequesterName = Convert.ToString(value);
				}
			}
				
			public System.String RequesterEmail
			{
				get
				{
					System.String data = entity.RequesterEmail;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.RequesterEmail = null;
					else entity.RequesterEmail = Convert.ToString(value);
				}
			}
				
			public System.String RequesterPhone
			{
				get
				{
					System.String data = entity.RequesterPhone;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.RequesterPhone = null;
					else entity.RequesterPhone = Convert.ToString(value);
				}
			}
				
			public System.String EstimatedHours
			{
				get
				{
					System.Int32? data = entity.EstimatedHours;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.EstimatedHours = null;
					else entity.EstimatedHours = Convert.ToInt32(value);
				}
			}
				
			public System.String ConfirmAsFinishDate
			{
				get
				{
					System.DateTime? data = entity.ConfirmAsFinishDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ConfirmAsFinishDate = null;
					else entity.ConfirmAsFinishDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String CancelledDate
			{
				get
				{
					System.DateTime? data = entity.CancelledDate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CancelledDate = null;
					else entity.CancelledDate = Convert.ToDateTime(value);
				}
			}
				
			public System.String ApprovedByRequestorID
			{
				get
				{
					System.Int32? data = entity.ApprovedByRequestorID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ApprovedByRequestorID = null;
					else entity.ApprovedByRequestorID = Convert.ToInt32(value);
				}
			}
				
			public System.String ApprovedByRequestorDateTime
			{
				get
				{
					System.DateTime? data = entity.ApprovedByRequestorDateTime;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ApprovedByRequestorDateTime = null;
					else entity.ApprovedByRequestorDateTime = Convert.ToDateTime(value);
				}
			}
			

			private esADefHelpDeskTasks entity;
		}
		
		[NonSerialized]
		private esStrings esstrings;		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskTasksMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public ADefHelpDeskTasksQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskTasksQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskTasksQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(ADefHelpDeskTasksQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private ADefHelpDeskTasksQuery query;		
	}



	[Serializable]
	abstract public partial class esADefHelpDeskTasksCollection : esEntityCollection<ADefHelpDeskTasks>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskTasksMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "ADefHelpDeskTasksCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public ADefHelpDeskTasksQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ADefHelpDeskTasksQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(ADefHelpDeskTasksQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ADefHelpDeskTasksQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(ADefHelpDeskTasksQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((ADefHelpDeskTasksQuery)query);
		}

		#endregion
		
		private ADefHelpDeskTasksQuery query;
	}



	[Serializable]
	abstract public partial class esADefHelpDeskTasksQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ADefHelpDeskTasksMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "TaskID": return this.TaskID;
				case "PortalID": return this.PortalID;
				case "Description": return this.Description;
				case "Status": return this.Status;
				case "Priority": return this.Priority;
				case "CreatedDate": return this.CreatedDate;
				case "EstimatedStart": return this.EstimatedStart;
				case "EstimatedCompletion": return this.EstimatedCompletion;
				case "DueDate": return this.DueDate;
				case "AssignedRoleID": return this.AssignedRoleID;
				case "TicketPassword": return this.TicketPassword;
				case "RequesterUserID": return this.RequesterUserID;
				case "RequesterName": return this.RequesterName;
				case "RequesterEmail": return this.RequesterEmail;
				case "RequesterPhone": return this.RequesterPhone;
				case "EstimatedHours": return this.EstimatedHours;
				case "ConfirmAsFinishDate": return this.ConfirmAsFinishDate;
				case "CancelledDate": return this.CancelledDate;
				case "ApprovedByRequestorID": return this.ApprovedByRequestorID;
				case "ApprovedByRequestorDateTime": return this.ApprovedByRequestorDateTime;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem TaskID
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.TaskID, esSystemType.Int32); }
		} 
		
		public esQueryItem PortalID
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.PortalID, esSystemType.Int32); }
		} 
		
		public esQueryItem Description
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.Description, esSystemType.String); }
		} 
		
		public esQueryItem Status
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.Status, esSystemType.String); }
		} 
		
		public esQueryItem Priority
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.Priority, esSystemType.String); }
		} 
		
		public esQueryItem CreatedDate
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.CreatedDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem EstimatedStart
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.EstimatedStart, esSystemType.DateTime); }
		} 
		
		public esQueryItem EstimatedCompletion
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.EstimatedCompletion, esSystemType.DateTime); }
		} 
		
		public esQueryItem DueDate
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.DueDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem AssignedRoleID
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.AssignedRoleID, esSystemType.Int32); }
		} 
		
		public esQueryItem TicketPassword
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.TicketPassword, esSystemType.String); }
		} 
		
		public esQueryItem RequesterUserID
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.RequesterUserID, esSystemType.Int32); }
		} 
		
		public esQueryItem RequesterName
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.RequesterName, esSystemType.String); }
		} 
		
		public esQueryItem RequesterEmail
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.RequesterEmail, esSystemType.String); }
		} 
		
		public esQueryItem RequesterPhone
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.RequesterPhone, esSystemType.String); }
		} 
		
		public esQueryItem EstimatedHours
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.EstimatedHours, esSystemType.Int32); }
		} 
		
		public esQueryItem ConfirmAsFinishDate
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.ConfirmAsFinishDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem CancelledDate
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.CancelledDate, esSystemType.DateTime); }
		} 
		
		public esQueryItem ApprovedByRequestorID
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.ApprovedByRequestorID, esSystemType.Int32); }
		} 
		
		public esQueryItem ApprovedByRequestorDateTime
		{
			get { return new esQueryItem(this, ADefHelpDeskTasksMetadata.ColumnNames.ApprovedByRequestorDateTime, esSystemType.DateTime); }
		} 
		
		#endregion
		
	}


	
	public partial class ADefHelpDeskTasks : esADefHelpDeskTasks
	{

		#region ADefHelpDeskLogCollectionByTaskID - Zero To Many
		
		static public esPrefetchMap Prefetch_ADefHelpDeskLogCollectionByTaskID
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap();
				map.PrefetchDelegate = Rscm.Kencana.Helpdesk.BusinessObjects.ADefHelpDeskTasks.ADefHelpDeskLogCollectionByTaskID_Delegate;
				map.PropertyName = "ADefHelpDeskLogCollectionByTaskID";
				map.MyColumnName = "TaskID";
				map.ParentColumnName = "TaskID";
				map.IsMultiPartKey = false;
				return map;
			}
		}		
		
		static private void ADefHelpDeskLogCollectionByTaskID_Delegate(esPrefetchParameters data)
		{
			ADefHelpDeskTasksQuery parent = new ADefHelpDeskTasksQuery(data.NextAlias());

			ADefHelpDeskLogQuery me = data.You != null ? data.You as ADefHelpDeskLogQuery : new ADefHelpDeskLogQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.TaskID == me.TaskID);

			data.You = parent;
		}			
		
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_ADefHelpDesk_Log_ADefHelpDesk_Tasks
		/// </summary>

		[XmlIgnore]
		public ADefHelpDeskLogCollection ADefHelpDeskLogCollectionByTaskID
		{
			get
			{
				if(this._ADefHelpDeskLogCollectionByTaskID == null)
				{
					this._ADefHelpDeskLogCollectionByTaskID = new ADefHelpDeskLogCollection();
					this._ADefHelpDeskLogCollectionByTaskID.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("ADefHelpDeskLogCollectionByTaskID", this._ADefHelpDeskLogCollectionByTaskID);
				
					if (this.TaskID != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._ADefHelpDeskLogCollectionByTaskID.Query.Where(this._ADefHelpDeskLogCollectionByTaskID.Query.TaskID == this.TaskID);
							this._ADefHelpDeskLogCollectionByTaskID.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._ADefHelpDeskLogCollectionByTaskID.fks.Add(ADefHelpDeskLogMetadata.ColumnNames.TaskID, this.TaskID);
					}
				}

				return this._ADefHelpDeskLogCollectionByTaskID;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._ADefHelpDeskLogCollectionByTaskID != null) 
				{ 
					this.RemovePostSave("ADefHelpDeskLogCollectionByTaskID"); 
					this._ADefHelpDeskLogCollectionByTaskID = null;
					
				} 
			} 			
		}
			
		
		private ADefHelpDeskLogCollection _ADefHelpDeskLogCollectionByTaskID;
		#endregion

		#region ADefHelpDeskTaskAssociationsCollectionByTaskID - Zero To Many
		
		static public esPrefetchMap Prefetch_ADefHelpDeskTaskAssociationsCollectionByTaskID
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap();
				map.PrefetchDelegate = Rscm.Kencana.Helpdesk.BusinessObjects.ADefHelpDeskTasks.ADefHelpDeskTaskAssociationsCollectionByTaskID_Delegate;
				map.PropertyName = "ADefHelpDeskTaskAssociationsCollectionByTaskID";
				map.MyColumnName = "TaskID";
				map.ParentColumnName = "TaskID";
				map.IsMultiPartKey = false;
				return map;
			}
		}		
		
		static private void ADefHelpDeskTaskAssociationsCollectionByTaskID_Delegate(esPrefetchParameters data)
		{
			ADefHelpDeskTasksQuery parent = new ADefHelpDeskTasksQuery(data.NextAlias());

			ADefHelpDeskTaskAssociationsQuery me = data.You != null ? data.You as ADefHelpDeskTaskAssociationsQuery : new ADefHelpDeskTaskAssociationsQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.TaskID == me.TaskID);

			data.You = parent;
		}			
		
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_ADefHelpDesk_TaskAssociations_ADefHelpDesk_Tasks
		/// </summary>

		[XmlIgnore]
		public ADefHelpDeskTaskAssociationsCollection ADefHelpDeskTaskAssociationsCollectionByTaskID
		{
			get
			{
				if(this._ADefHelpDeskTaskAssociationsCollectionByTaskID == null)
				{
					this._ADefHelpDeskTaskAssociationsCollectionByTaskID = new ADefHelpDeskTaskAssociationsCollection();
					this._ADefHelpDeskTaskAssociationsCollectionByTaskID.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("ADefHelpDeskTaskAssociationsCollectionByTaskID", this._ADefHelpDeskTaskAssociationsCollectionByTaskID);
				
					if (this.TaskID != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._ADefHelpDeskTaskAssociationsCollectionByTaskID.Query.Where(this._ADefHelpDeskTaskAssociationsCollectionByTaskID.Query.TaskID == this.TaskID);
							this._ADefHelpDeskTaskAssociationsCollectionByTaskID.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._ADefHelpDeskTaskAssociationsCollectionByTaskID.fks.Add(ADefHelpDeskTaskAssociationsMetadata.ColumnNames.TaskID, this.TaskID);
					}
				}

				return this._ADefHelpDeskTaskAssociationsCollectionByTaskID;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._ADefHelpDeskTaskAssociationsCollectionByTaskID != null) 
				{ 
					this.RemovePostSave("ADefHelpDeskTaskAssociationsCollectionByTaskID"); 
					this._ADefHelpDeskTaskAssociationsCollectionByTaskID = null;
					
				} 
			} 			
		}
			
		
		private ADefHelpDeskTaskAssociationsCollection _ADefHelpDeskTaskAssociationsCollectionByTaskID;
		#endregion

		#region ADefHelpDeskTaskCategoriesCollectionByTaskID - Zero To Many
		
		static public esPrefetchMap Prefetch_ADefHelpDeskTaskCategoriesCollectionByTaskID
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap();
				map.PrefetchDelegate = Rscm.Kencana.Helpdesk.BusinessObjects.ADefHelpDeskTasks.ADefHelpDeskTaskCategoriesCollectionByTaskID_Delegate;
				map.PropertyName = "ADefHelpDeskTaskCategoriesCollectionByTaskID";
				map.MyColumnName = "TaskID";
				map.ParentColumnName = "TaskID";
				map.IsMultiPartKey = false;
				return map;
			}
		}		
		
		static private void ADefHelpDeskTaskCategoriesCollectionByTaskID_Delegate(esPrefetchParameters data)
		{
			ADefHelpDeskTasksQuery parent = new ADefHelpDeskTasksQuery(data.NextAlias());

			ADefHelpDeskTaskCategoriesQuery me = data.You != null ? data.You as ADefHelpDeskTaskCategoriesQuery : new ADefHelpDeskTaskCategoriesQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.TaskID == me.TaskID);

			data.You = parent;
		}			
		
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_ADefHelpDesk_TaskCategories_ADefHelpDesk_Tasks
		/// </summary>

		[XmlIgnore]
		public ADefHelpDeskTaskCategoriesCollection ADefHelpDeskTaskCategoriesCollectionByTaskID
		{
			get
			{
				if(this._ADefHelpDeskTaskCategoriesCollectionByTaskID == null)
				{
					this._ADefHelpDeskTaskCategoriesCollectionByTaskID = new ADefHelpDeskTaskCategoriesCollection();
					this._ADefHelpDeskTaskCategoriesCollectionByTaskID.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("ADefHelpDeskTaskCategoriesCollectionByTaskID", this._ADefHelpDeskTaskCategoriesCollectionByTaskID);
				
					if (this.TaskID != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._ADefHelpDeskTaskCategoriesCollectionByTaskID.Query.Where(this._ADefHelpDeskTaskCategoriesCollectionByTaskID.Query.TaskID == this.TaskID);
							this._ADefHelpDeskTaskCategoriesCollectionByTaskID.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._ADefHelpDeskTaskCategoriesCollectionByTaskID.fks.Add(ADefHelpDeskTaskCategoriesMetadata.ColumnNames.TaskID, this.TaskID);
					}
				}

				return this._ADefHelpDeskTaskCategoriesCollectionByTaskID;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._ADefHelpDeskTaskCategoriesCollectionByTaskID != null) 
				{ 
					this.RemovePostSave("ADefHelpDeskTaskCategoriesCollectionByTaskID"); 
					this._ADefHelpDeskTaskCategoriesCollectionByTaskID = null;
					
				} 
			} 			
		}
			
		
		private ADefHelpDeskTaskCategoriesCollection _ADefHelpDeskTaskCategoriesCollectionByTaskID;
		#endregion

		#region ADefHelpDeskTaskDetailsCollectionByTaskID - Zero To Many
		
		static public esPrefetchMap Prefetch_ADefHelpDeskTaskDetailsCollectionByTaskID
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap();
				map.PrefetchDelegate = Rscm.Kencana.Helpdesk.BusinessObjects.ADefHelpDeskTasks.ADefHelpDeskTaskDetailsCollectionByTaskID_Delegate;
				map.PropertyName = "ADefHelpDeskTaskDetailsCollectionByTaskID";
				map.MyColumnName = "TaskID";
				map.ParentColumnName = "TaskID";
				map.IsMultiPartKey = false;
				return map;
			}
		}		
		
		static private void ADefHelpDeskTaskDetailsCollectionByTaskID_Delegate(esPrefetchParameters data)
		{
			ADefHelpDeskTasksQuery parent = new ADefHelpDeskTasksQuery(data.NextAlias());

			ADefHelpDeskTaskDetailsQuery me = data.You != null ? data.You as ADefHelpDeskTaskDetailsQuery : new ADefHelpDeskTaskDetailsQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.TaskID == me.TaskID);

			data.You = parent;
		}			
		
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_ADefHelpDesk_TaskDetails_ADefHelpDesk_Tasks
		/// </summary>

		[XmlIgnore]
		public ADefHelpDeskTaskDetailsCollection ADefHelpDeskTaskDetailsCollectionByTaskID
		{
			get
			{
				if(this._ADefHelpDeskTaskDetailsCollectionByTaskID == null)
				{
					this._ADefHelpDeskTaskDetailsCollectionByTaskID = new ADefHelpDeskTaskDetailsCollection();
					this._ADefHelpDeskTaskDetailsCollectionByTaskID.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("ADefHelpDeskTaskDetailsCollectionByTaskID", this._ADefHelpDeskTaskDetailsCollectionByTaskID);
				
					if (this.TaskID != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._ADefHelpDeskTaskDetailsCollectionByTaskID.Query.Where(this._ADefHelpDeskTaskDetailsCollectionByTaskID.Query.TaskID == this.TaskID);
							this._ADefHelpDeskTaskDetailsCollectionByTaskID.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._ADefHelpDeskTaskDetailsCollectionByTaskID.fks.Add(ADefHelpDeskTaskDetailsMetadata.ColumnNames.TaskID, this.TaskID);
					}
				}

				return this._ADefHelpDeskTaskDetailsCollectionByTaskID;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._ADefHelpDeskTaskDetailsCollectionByTaskID != null) 
				{ 
					this.RemovePostSave("ADefHelpDeskTaskDetailsCollectionByTaskID"); 
					this._ADefHelpDeskTaskDetailsCollectionByTaskID = null;
					
				} 
			} 			
		}
			
		
		private ADefHelpDeskTaskDetailsCollection _ADefHelpDeskTaskDetailsCollectionByTaskID;
		#endregion

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "ADefHelpDeskLogCollectionByTaskID":
					coll = this.ADefHelpDeskLogCollectionByTaskID;
					break;
				case "ADefHelpDeskTaskAssociationsCollectionByTaskID":
					coll = this.ADefHelpDeskTaskAssociationsCollectionByTaskID;
					break;
				case "ADefHelpDeskTaskCategoriesCollectionByTaskID":
					coll = this.ADefHelpDeskTaskCategoriesCollectionByTaskID;
					break;
				case "ADefHelpDeskTaskDetailsCollectionByTaskID":
					coll = this.ADefHelpDeskTaskDetailsCollectionByTaskID;
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
			
			props.Add(new esPropertyDescriptor(this, "ADefHelpDeskLogCollectionByTaskID", typeof(ADefHelpDeskLogCollection), new ADefHelpDeskLog()));
			props.Add(new esPropertyDescriptor(this, "ADefHelpDeskTaskAssociationsCollectionByTaskID", typeof(ADefHelpDeskTaskAssociationsCollection), new ADefHelpDeskTaskAssociations()));
			props.Add(new esPropertyDescriptor(this, "ADefHelpDeskTaskCategoriesCollectionByTaskID", typeof(ADefHelpDeskTaskCategoriesCollection), new ADefHelpDeskTaskCategories()));
			props.Add(new esPropertyDescriptor(this, "ADefHelpDeskTaskDetailsCollectionByTaskID", typeof(ADefHelpDeskTaskDetailsCollection), new ADefHelpDeskTaskDetails()));
		
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
			if(this._ADefHelpDeskLogCollectionByTaskID != null)
			{
				Apply(this._ADefHelpDeskLogCollectionByTaskID, "TaskID", this.TaskID);
			}
			if(this._ADefHelpDeskTaskAssociationsCollectionByTaskID != null)
			{
				Apply(this._ADefHelpDeskTaskAssociationsCollectionByTaskID, "TaskID", this.TaskID);
			}
			if(this._ADefHelpDeskTaskCategoriesCollectionByTaskID != null)
			{
				Apply(this._ADefHelpDeskTaskCategoriesCollectionByTaskID, "TaskID", this.TaskID);
			}
			if(this._ADefHelpDeskTaskDetailsCollectionByTaskID != null)
			{
				Apply(this._ADefHelpDeskTaskDetailsCollectionByTaskID, "TaskID", this.TaskID);
			}
		}
		
	}
	



	[Serializable]
	public partial class ADefHelpDeskTasksMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ADefHelpDeskTasksMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.TaskID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.TaskID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.PortalID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.PortalID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.Description, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.Description;
			c.CharacterMaxLength = 150;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.Status, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.Status;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.Priority, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.Priority;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.CreatedDate, 5, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.CreatedDate;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.EstimatedStart, 6, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.EstimatedStart;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.EstimatedCompletion, 7, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.EstimatedCompletion;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.DueDate, 8, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.DueDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.AssignedRoleID, 9, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.AssignedRoleID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.TicketPassword, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.TicketPassword;
			c.CharacterMaxLength = 50;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.RequesterUserID, 11, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.RequesterUserID;
			c.NumericPrecision = 10;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.RequesterName, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.RequesterName;
			c.CharacterMaxLength = 350;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.RequesterEmail, 13, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.RequesterEmail;
			c.CharacterMaxLength = 350;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.RequesterPhone, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.RequesterPhone;
			c.CharacterMaxLength = 50;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.EstimatedHours, 15, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.EstimatedHours;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.ConfirmAsFinishDate, 16, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.ConfirmAsFinishDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.CancelledDate, 17, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.CancelledDate;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.ApprovedByRequestorID, 18, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.ApprovedByRequestorID;
			c.NumericPrecision = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(ADefHelpDeskTasksMetadata.ColumnNames.ApprovedByRequestorDateTime, 19, typeof(System.DateTime), esSystemType.DateTime);
			c.PropertyName = ADefHelpDeskTasksMetadata.PropertyNames.ApprovedByRequestorDateTime;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public ADefHelpDeskTasksMetadata Meta()
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
			 public const string TaskID = "TaskID";
			 public const string PortalID = "PortalID";
			 public const string Description = "Description";
			 public const string Status = "Status";
			 public const string Priority = "Priority";
			 public const string CreatedDate = "CreatedDate";
			 public const string EstimatedStart = "EstimatedStart";
			 public const string EstimatedCompletion = "EstimatedCompletion";
			 public const string DueDate = "DueDate";
			 public const string AssignedRoleID = "AssignedRoleID";
			 public const string TicketPassword = "TicketPassword";
			 public const string RequesterUserID = "RequesterUserID";
			 public const string RequesterName = "RequesterName";
			 public const string RequesterEmail = "RequesterEmail";
			 public const string RequesterPhone = "RequesterPhone";
			 public const string EstimatedHours = "EstimatedHours";
			 public const string ConfirmAsFinishDate = "ConfirmAsFinishDate";
			 public const string CancelledDate = "CancelledDate";
			 public const string ApprovedByRequestorID = "ApprovedByRequestorID";
			 public const string ApprovedByRequestorDateTime = "ApprovedByRequestorDateTime";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string TaskID = "TaskID";
			 public const string PortalID = "PortalID";
			 public const string Description = "Description";
			 public const string Status = "Status";
			 public const string Priority = "Priority";
			 public const string CreatedDate = "CreatedDate";
			 public const string EstimatedStart = "EstimatedStart";
			 public const string EstimatedCompletion = "EstimatedCompletion";
			 public const string DueDate = "DueDate";
			 public const string AssignedRoleID = "AssignedRoleID";
			 public const string TicketPassword = "TicketPassword";
			 public const string RequesterUserID = "RequesterUserID";
			 public const string RequesterName = "RequesterName";
			 public const string RequesterEmail = "RequesterEmail";
			 public const string RequesterPhone = "RequesterPhone";
			 public const string EstimatedHours = "EstimatedHours";
			 public const string ConfirmAsFinishDate = "ConfirmAsFinishDate";
			 public const string CancelledDate = "CancelledDate";
			 public const string ApprovedByRequestorID = "ApprovedByRequestorID";
			 public const string ApprovedByRequestorDateTime = "ApprovedByRequestorDateTime";
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
			lock (typeof(ADefHelpDeskTasksMetadata))
			{
				if(ADefHelpDeskTasksMetadata.mapDelegates == null)
				{
					ADefHelpDeskTasksMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ADefHelpDeskTasksMetadata.meta == null)
				{
					ADefHelpDeskTasksMetadata.meta = new ADefHelpDeskTasksMetadata();
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


				meta.AddTypeMap("TaskID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("PortalID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("Description", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Status", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Priority", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("CreatedDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("EstimatedStart", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("EstimatedCompletion", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("DueDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("AssignedRoleID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("TicketPassword", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("RequesterUserID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("RequesterName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("RequesterEmail", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("RequesterPhone", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("EstimatedHours", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("ConfirmAsFinishDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("CancelledDate", new esTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("ApprovedByRequestorID", new esTypeMap("int", "System.Int32"));
				meta.AddTypeMap("ApprovedByRequestorDateTime", new esTypeMap("datetime", "System.DateTime"));			
				
				
				
				meta.Source = "ADefHelpDesk_Tasks";
				meta.Destination = "ADefHelpDesk_Tasks";
				
				meta.spInsert = "proc_ADefHelpDesk_TasksInsert";				
				meta.spUpdate = "proc_ADefHelpDesk_TasksUpdate";		
				meta.spDelete = "proc_ADefHelpDesk_TasksDelete";
				meta.spLoadAll = "proc_ADefHelpDesk_TasksLoadAll";
				meta.spLoadByPrimaryKey = "proc_ADefHelpDesk_TasksLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ADefHelpDeskTasksMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
