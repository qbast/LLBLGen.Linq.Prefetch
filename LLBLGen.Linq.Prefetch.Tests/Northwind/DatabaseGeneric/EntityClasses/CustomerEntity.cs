﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using NW26;
using NW26.HelperClasses;
using NW26.FactoryClasses;
using NW26.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NW26.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Customer'.<br/><br/></summary>
	[Serializable]
	public partial class CustomerEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<CustomerCustomerDemoEntity> _customerCustomerDemos;
		private EntityCollection<OrderEntity> _orders;
		private EntityCollection<CustomerDemographicEntity> _customerDemographicCollectionViaCustomerCustomerDemo;
		private EntityCollection<EmployeeEntity> _employeeCollectionViaOrder;
		private EntityCollection<ShipperEntity> _shipperCollectionViaOrder;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name CustomerCustomerDemos</summary>
			public static readonly string CustomerCustomerDemos = "CustomerCustomerDemos";
			/// <summary>Member name Orders</summary>
			public static readonly string Orders = "Orders";
			/// <summary>Member name CustomerDemographicCollectionViaCustomerCustomerDemo</summary>
			public static readonly string CustomerDemographicCollectionViaCustomerCustomerDemo = "CustomerDemographicCollectionViaCustomerCustomerDemo";
			/// <summary>Member name EmployeeCollectionViaOrder</summary>
			public static readonly string EmployeeCollectionViaOrder = "EmployeeCollectionViaOrder";
			/// <summary>Member name ShipperCollectionViaOrder</summary>
			public static readonly string ShipperCollectionViaOrder = "ShipperCollectionViaOrder";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CustomerEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public CustomerEntity():base("CustomerEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public CustomerEntity(IEntityFields2 fields):base("CustomerEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this CustomerEntity</param>
		public CustomerEntity(IValidator validator):base("CustomerEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CustomerEntity(System.String customerId):base("CustomerEntity")
		{
			InitClassEmpty(null, null);
			this.CustomerId = customerId;
		}

		/// <summary> CTor</summary>
		/// <param name="customerId">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="validator">The custom validator object for this CustomerEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CustomerEntity(System.String customerId, IValidator validator):base("CustomerEntity")
		{
			InitClassEmpty(validator, null);
			this.CustomerId = customerId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected CustomerEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_customerCustomerDemos = (EntityCollection<CustomerCustomerDemoEntity>)info.GetValue("_customerCustomerDemos", typeof(EntityCollection<CustomerCustomerDemoEntity>));
				_orders = (EntityCollection<OrderEntity>)info.GetValue("_orders", typeof(EntityCollection<OrderEntity>));
				_customerDemographicCollectionViaCustomerCustomerDemo = (EntityCollection<CustomerDemographicEntity>)info.GetValue("_customerDemographicCollectionViaCustomerCustomerDemo", typeof(EntityCollection<CustomerDemographicEntity>));
				_employeeCollectionViaOrder = (EntityCollection<EmployeeEntity>)info.GetValue("_employeeCollectionViaOrder", typeof(EntityCollection<EmployeeEntity>));
				_shipperCollectionViaOrder = (EntityCollection<ShipperEntity>)info.GetValue("_shipperCollectionViaOrder", typeof(EntityCollection<ShipperEntity>));
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}


		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "CustomerCustomerDemos":
					this.CustomerCustomerDemos.Add((CustomerCustomerDemoEntity)entity);
					break;
				case "Orders":
					this.Orders.Add((OrderEntity)entity);
					break;
				case "CustomerDemographicCollectionViaCustomerCustomerDemo":
					this.CustomerDemographicCollectionViaCustomerCustomerDemo.IsReadOnly = false;
					this.CustomerDemographicCollectionViaCustomerCustomerDemo.Add((CustomerDemographicEntity)entity);
					this.CustomerDemographicCollectionViaCustomerCustomerDemo.IsReadOnly = true;
					break;
				case "EmployeeCollectionViaOrder":
					this.EmployeeCollectionViaOrder.IsReadOnly = false;
					this.EmployeeCollectionViaOrder.Add((EmployeeEntity)entity);
					this.EmployeeCollectionViaOrder.IsReadOnly = true;
					break;
				case "ShipperCollectionViaOrder":
					this.ShipperCollectionViaOrder.IsReadOnly = false;
					this.ShipperCollectionViaOrder.Add((ShipperEntity)entity);
					this.ShipperCollectionViaOrder.IsReadOnly = true;
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "CustomerCustomerDemos":
					toReturn.Add(Relations.CustomerCustomerDemoEntityUsingCustomerId);
					break;
				case "Orders":
					toReturn.Add(Relations.OrderEntityUsingCustomerId);
					break;
				case "CustomerDemographicCollectionViaCustomerCustomerDemo":
					toReturn.Add(Relations.CustomerCustomerDemoEntityUsingCustomerId, "CustomerEntity__", "CustomerCustomerDemo_", JoinHint.None);
					toReturn.Add(CustomerCustomerDemoEntity.Relations.CustomerDemographicEntityUsingCustomerTypeId, "CustomerCustomerDemo_", string.Empty, JoinHint.None);
					break;
				case "EmployeeCollectionViaOrder":
					toReturn.Add(Relations.OrderEntityUsingCustomerId, "CustomerEntity__", "Order_", JoinHint.None);
					toReturn.Add(OrderEntity.Relations.EmployeeEntityUsingEmployeeId, "Order_", string.Empty, JoinHint.None);
					break;
				case "ShipperCollectionViaOrder":
					toReturn.Add(Relations.OrderEntityUsingCustomerId, "CustomerEntity__", "Order_", JoinHint.None);
					toReturn.Add(OrderEntity.Relations.ShipperEntityUsingShipVia, "Order_", string.Empty, JoinHint.None);
					break;
				default:
					break;				
			}
			return toReturn;
		}
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it/ will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		protected override bool CheckOneWayRelations(string propertyName)
		{
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "CustomerCustomerDemos":
					this.CustomerCustomerDemos.Add((CustomerCustomerDemoEntity)relatedEntity);
					break;
				case "Orders":
					this.Orders.Add((OrderEntity)relatedEntity);
					break;
				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "CustomerCustomerDemos":
					this.PerformRelatedEntityRemoval(this.CustomerCustomerDemos, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Orders":
					this.PerformRelatedEntityRemoval(this.Orders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.CustomerCustomerDemos);
			toReturn.Add(this.Orders);
			return toReturn;
		}

		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				info.AddValue("_customerCustomerDemos", ((_customerCustomerDemos!=null) && (_customerCustomerDemos.Count>0) && !this.MarkedForDeletion)?_customerCustomerDemos:null);
				info.AddValue("_orders", ((_orders!=null) && (_orders.Count>0) && !this.MarkedForDeletion)?_orders:null);
				info.AddValue("_customerDemographicCollectionViaCustomerCustomerDemo", ((_customerDemographicCollectionViaCustomerCustomerDemo!=null) && (_customerDemographicCollectionViaCustomerCustomerDemo.Count>0) && !this.MarkedForDeletion)?_customerDemographicCollectionViaCustomerCustomerDemo:null);
				info.AddValue("_employeeCollectionViaOrder", ((_employeeCollectionViaOrder!=null) && (_employeeCollectionViaOrder.Count>0) && !this.MarkedForDeletion)?_employeeCollectionViaOrder:null);
				info.AddValue("_shipperCollectionViaOrder", ((_shipperCollectionViaOrder!=null) && (_shipperCollectionViaOrder.Count>0) && !this.MarkedForDeletion)?_shipperCollectionViaOrder:null);
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CustomerRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CustomerCustomerDemo' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomerCustomerDemos()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CustomerCustomerDemoFields.CustomerId, null, ComparisonOperator.Equal, this.CustomerId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Order' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoOrders()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(OrderFields.CustomerId, null, ComparisonOperator.Equal, this.CustomerId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CustomerDemographic' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomerDemographicCollectionViaCustomerCustomerDemo()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("CustomerDemographicCollectionViaCustomerCustomerDemo"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CustomerFields.CustomerId, null, ComparisonOperator.Equal, this.CustomerId, "CustomerEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Employee' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeCollectionViaOrder()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("EmployeeCollectionViaOrder"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CustomerFields.CustomerId, null, ComparisonOperator.Equal, this.CustomerId, "CustomerEntity__"));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Shipper' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoShipperCollectionViaOrder()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.Relations.AddRange(GetRelationsForFieldOfType("ShipperCollectionViaOrder"));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CustomerFields.CustomerId, null, ComparisonOperator.Equal, this.CustomerId, "CustomerEntity__"));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._customerCustomerDemos);
			collectionsQueue.Enqueue(this._orders);
			collectionsQueue.Enqueue(this._customerDemographicCollectionViaCustomerCustomerDemo);
			collectionsQueue.Enqueue(this._employeeCollectionViaOrder);
			collectionsQueue.Enqueue(this._shipperCollectionViaOrder);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._customerCustomerDemos = (EntityCollection<CustomerCustomerDemoEntity>) collectionsQueue.Dequeue();
			this._orders = (EntityCollection<OrderEntity>) collectionsQueue.Dequeue();
			this._customerDemographicCollectionViaCustomerCustomerDemo = (EntityCollection<CustomerDemographicEntity>) collectionsQueue.Dequeue();
			this._employeeCollectionViaOrder = (EntityCollection<EmployeeEntity>) collectionsQueue.Dequeue();
			this._shipperCollectionViaOrder = (EntityCollection<ShipperEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._customerCustomerDemos != null);
			toReturn |=(this._orders != null);
			toReturn |= (this._customerDemographicCollectionViaCustomerCustomerDemo != null);
			toReturn |= (this._employeeCollectionViaOrder != null);
			toReturn |= (this._shipperCollectionViaOrder != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CustomerCustomerDemoEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerCustomerDemoEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<OrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(OrderEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CustomerDemographicEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerDemographicEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ShipperEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShipperEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("CustomerCustomerDemos", _customerCustomerDemos);
			toReturn.Add("Orders", _orders);
			toReturn.Add("CustomerDemographicCollectionViaCustomerCustomerDemo", _customerDemographicCollectionViaCustomerCustomerDemo);
			toReturn.Add("EmployeeCollectionViaOrder", _employeeCollectionViaOrder);
			toReturn.Add("ShipperCollectionViaOrder", _shipperCollectionViaOrder);
			return toReturn;
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}


		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Address", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CompanyName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ContactName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ContactTitle", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Country", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CustomerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Fax", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Phone", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PostalCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Region", fieldHashtable);
		}
		#endregion

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this CustomerEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();

		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static CustomerRelations Relations
		{
			get	{ return new CustomerRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CustomerCustomerDemo' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomerCustomerDemos
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CustomerCustomerDemoEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerCustomerDemoEntityFactory))), (IEntityRelation)GetRelationsForField("CustomerCustomerDemos")[0], (int)NW26.EntityType.CustomerEntity, (int)NW26.EntityType.CustomerCustomerDemoEntity, 0, null, null, null, null, "CustomerCustomerDemos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Order' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathOrders
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<OrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(OrderEntityFactory))), (IEntityRelation)GetRelationsForField("Orders")[0], (int)NW26.EntityType.CustomerEntity, (int)NW26.EntityType.OrderEntity, 0, null, null, null, null, "Orders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CustomerDemographic' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomerDemographicCollectionViaCustomerCustomerDemo
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.CustomerCustomerDemoEntityUsingCustomerId;
				intermediateRelation.SetAliases(string.Empty, "CustomerCustomerDemo_");
				return new PrefetchPathElement2(new EntityCollection<CustomerDemographicEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerDemographicEntityFactory))), intermediateRelation,
					(int)NW26.EntityType.CustomerEntity, (int)NW26.EntityType.CustomerDemographicEntity, 0, null, null, GetRelationsForField("CustomerDemographicCollectionViaCustomerCustomerDemo"), null, "CustomerDemographicCollectionViaCustomerCustomerDemo", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeCollectionViaOrder
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.OrderEntityUsingCustomerId;
				intermediateRelation.SetAliases(string.Empty, "Order_");
				return new PrefetchPathElement2(new EntityCollection<EmployeeEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), intermediateRelation,
					(int)NW26.EntityType.CustomerEntity, (int)NW26.EntityType.EmployeeEntity, 0, null, null, GetRelationsForField("EmployeeCollectionViaOrder"), null, "EmployeeCollectionViaOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Shipper' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathShipperCollectionViaOrder
		{
			get
			{
				IEntityRelation intermediateRelation = Relations.OrderEntityUsingCustomerId;
				intermediateRelation.SetAliases(string.Empty, "Order_");
				return new PrefetchPathElement2(new EntityCollection<ShipperEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShipperEntityFactory))), intermediateRelation,
					(int)NW26.EntityType.CustomerEntity, (int)NW26.EntityType.ShipperEntity, 0, null, null, GetRelationsForField("ShipperCollectionViaOrder"), null, "ShipperCollectionViaOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany);
			}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The Address property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."Address"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Address
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.Address, true); }
			set	{ SetValue((int)CustomerFieldIndex.Address, value); }
		}

		/// <summary> The City property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."City"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.City, true); }
			set	{ SetValue((int)CustomerFieldIndex.City, value); }
		}

		/// <summary> The CompanyName property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."CompanyName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 40<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CompanyName
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.CompanyName, true); }
			set	{ SetValue((int)CustomerFieldIndex.CompanyName, value); }
		}

		/// <summary> The ContactName property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."ContactName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ContactName
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.ContactName, true); }
			set	{ SetValue((int)CustomerFieldIndex.ContactName, value); }
		}

		/// <summary> The ContactTitle property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."ContactTitle"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ContactTitle
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.ContactTitle, true); }
			set	{ SetValue((int)CustomerFieldIndex.ContactTitle, value); }
		}

		/// <summary> The Country property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."Country"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Country
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.Country, true); }
			set	{ SetValue((int)CustomerFieldIndex.Country, value); }
		}

		/// <summary> The CustomerId property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."CustomerID"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 5<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CustomerId
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.CustomerId, true); }
			set	{ SetValue((int)CustomerFieldIndex.CustomerId, value); }
		}

		/// <summary> The Fax property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."Fax"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 24<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Fax
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.Fax, true); }
			set	{ SetValue((int)CustomerFieldIndex.Fax, value); }
		}

		/// <summary> The Phone property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."Phone"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 24<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Phone
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.Phone, true); }
			set	{ SetValue((int)CustomerFieldIndex.Phone, value); }
		}

		/// <summary> The PostalCode property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."PostalCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PostalCode
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.PostalCode, true); }
			set	{ SetValue((int)CustomerFieldIndex.PostalCode, value); }
		}

		/// <summary> The Region property of the Entity Customer<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Customers"."Region"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Region
		{
			get { return (System.String)GetValue((int)CustomerFieldIndex.Region, true); }
			set	{ SetValue((int)CustomerFieldIndex.Region, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CustomerCustomerDemoEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CustomerCustomerDemoEntity))]
		public virtual EntityCollection<CustomerCustomerDemoEntity> CustomerCustomerDemos
		{
			get { return GetOrCreateEntityCollection<CustomerCustomerDemoEntity, CustomerCustomerDemoEntityFactory>("Customer", true, false, ref _customerCustomerDemos);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'OrderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(OrderEntity))]
		public virtual EntityCollection<OrderEntity> Orders
		{
			get { return GetOrCreateEntityCollection<OrderEntity, OrderEntityFactory>("Customer", true, false, ref _orders);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CustomerDemographicEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CustomerDemographicEntity))]
		public virtual EntityCollection<CustomerDemographicEntity> CustomerDemographicCollectionViaCustomerCustomerDemo
		{
			get { return GetOrCreateEntityCollection<CustomerDemographicEntity, CustomerDemographicEntityFactory>("CustomerCollectionViaCustomerCustomerDemo", false, true, ref _customerDemographicCollectionViaCustomerCustomerDemo);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(EmployeeEntity))]
		public virtual EntityCollection<EmployeeEntity> EmployeeCollectionViaOrder
		{
			get { return GetOrCreateEntityCollection<EmployeeEntity, EmployeeEntityFactory>("CustomerCollectionViaOrder", false, true, ref _employeeCollectionViaOrder);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ShipperEntity' which are related to this entity via a relation of type 'm:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ShipperEntity))]
		public virtual EntityCollection<ShipperEntity> ShipperCollectionViaOrder
		{
			get { return GetOrCreateEntityCollection<ShipperEntity, ShipperEntityFactory>("CustomerCollectionViaOrder", false, true, ref _shipperCollectionViaOrder);	}
		}
	
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the NW26.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)NW26.EntityType.CustomerEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
