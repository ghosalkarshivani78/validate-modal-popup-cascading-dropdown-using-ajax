﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("test2Model", "simp_ibfk_1", "city", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(createform.Models.city), "simp", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(createform.Models.simp), true)]

#endregion

namespace createform.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class test2Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new test2Entities object using the connection string found in the 'test2Entities' section of the application configuration file.
        /// </summary>
        public test2Entities() : base("name=test2Entities", "test2Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new test2Entities object.
        /// </summary>
        public test2Entities(string connectionString) : base(connectionString, "test2Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new test2Entities object.
        /// </summary>
        public test2Entities(EntityConnection connection) : base(connection, "test2Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<city> cities
        {
            get
            {
                if ((_cities == null))
                {
                    _cities = base.CreateObjectSet<city>("cities");
                }
                return _cities;
            }
        }
        private ObjectSet<city> _cities;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<simp> simps
        {
            get
            {
                if ((_simps == null))
                {
                    _simps = base.CreateObjectSet<simp>("simps");
                }
                return _simps;
            }
        }
        private ObjectSet<simp> _simps;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the cities EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTocities(city city)
        {
            base.AddObject("cities", city);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the simps EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTosimps(simp simp)
        {
            base.AddObject("simps", simp);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="test2Model", Name="city")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class city : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new city object.
        /// </summary>
        /// <param name="cityid">Initial value of the cityid property.</param>
        /// <param name="cityname">Initial value of the cityname property.</param>
        public static city Createcity(global::System.Int32 cityid, global::System.String cityname)
        {
            city city = new city();
            city.cityid = cityid;
            city.cityname = cityname;
            return city;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 cityid
        {
            get
            {
                return _cityid;
            }
            set
            {
                if (_cityid != value)
                {
                    OncityidChanging(value);
                    ReportPropertyChanging("cityid");
                    _cityid = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("cityid");
                    OncityidChanged();
                }
            }
        }
        private global::System.Int32 _cityid;
        partial void OncityidChanging(global::System.Int32 value);
        partial void OncityidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String cityname
        {
            get
            {
                return _cityname;
            }
            set
            {
                OncitynameChanging(value);
                ReportPropertyChanging("cityname");
                _cityname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("cityname");
                OncitynameChanged();
            }
        }
        private global::System.String _cityname;
        partial void OncitynameChanging(global::System.String value);
        partial void OncitynameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("test2Model", "simp_ibfk_1", "simp")]
        public EntityCollection<simp> simps
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<simp>("test2Model.simp_ibfk_1", "simp");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<simp>("test2Model.simp_ibfk_1", "simp", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="test2Model", Name="simp")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class simp : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new simp object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="firstname">Initial value of the firstname property.</param>
        /// <param name="email">Initial value of the email property.</param>
        /// <param name="cityid">Initial value of the cityid property.</param>
        /// <param name="number">Initial value of the number property.</param>
        public static simp Createsimp(global::System.Int32 id, global::System.String firstname, global::System.String email, global::System.Int32 cityid, global::System.String number)
        {
            simp simp = new simp();
            simp.id = id;
            simp.firstname = firstname;
            simp.email = email;
            simp.cityid = cityid;
            simp.number = number;
            return simp;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                OnfirstnameChanging(value);
                ReportPropertyChanging("firstname");
                _firstname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("firstname");
                OnfirstnameChanged();
            }
        }
        private global::System.String _firstname;
        partial void OnfirstnameChanging(global::System.String value);
        partial void OnfirstnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String email
        {
            get
            {
                return _email;
            }
            set
            {
                OnemailChanging(value);
                ReportPropertyChanging("email");
                _email = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("email");
                OnemailChanged();
            }
        }
        private global::System.String _email;
        partial void OnemailChanging(global::System.String value);
        partial void OnemailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 cityid
        {
            get
            {
                return _cityid;
            }
            set
            {
                OncityidChanging(value);
                ReportPropertyChanging("cityid");
                _cityid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("cityid");
                OncityidChanged();
            }
        }
        private global::System.Int32 _cityid;
        partial void OncityidChanging(global::System.Int32 value);
        partial void OncityidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String number
        {
            get
            {
                return _number;
            }
            set
            {
                OnnumberChanging(value);
                ReportPropertyChanging("number");
                _number = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("number");
                OnnumberChanged();
            }
        }
        private global::System.String _number;
        partial void OnnumberChanging(global::System.String value);
        partial void OnnumberChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("test2Model", "simp_ibfk_1", "city")]
        public city city
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<city>("test2Model.simp_ibfk_1", "city").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<city>("test2Model.simp_ibfk_1", "city").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<city> cityReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<city>("test2Model.simp_ibfk_1", "city");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<city>("test2Model.simp_ibfk_1", "city", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
