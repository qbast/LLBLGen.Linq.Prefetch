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
using System.Collections;
using System.Collections.Generic;
using NW26;
using NW26.FactoryClasses;
using NW26.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NW26.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: CustomerDemographics. </summary>
	public partial class CustomerDemographicsRelations
	{
		/// <summary>CTor</summary>
		public CustomerDemographicsRelations()
		{
		}

		/// <summary>Gets all relations of the CustomerDemographicsEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CustomerCustomerDemoEntityUsingCustomerTypeId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CustomerDemographicsEntity and CustomerCustomerDemoEntity over the 1:n relation they have, using the relation between the fields:
		/// CustomerDemographics.CustomerTypeId - CustomerCustomerDemo.CustomerTypeId
		/// </summary>
		public virtual IEntityRelation CustomerCustomerDemoEntityUsingCustomerTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CustomerCustomerDemos" , true);
				relation.AddEntityFieldPair(CustomerDemographicsFields.CustomerTypeId, CustomerCustomerDemoFields.CustomerTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerDemographicsEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerCustomerDemoEntity", false);
				return relation;
			}
		}


		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticCustomerDemographicsRelations
	{
		internal static readonly IEntityRelation CustomerCustomerDemoEntityUsingCustomerTypeIdStatic = new CustomerDemographicsRelations().CustomerCustomerDemoEntityUsingCustomerTypeId;

		/// <summary>CTor</summary>
		static StaticCustomerDemographicsRelations()
		{
		}
	}
}
