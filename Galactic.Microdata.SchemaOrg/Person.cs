﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Galactic.Microdata.SchemaOrg
{
    /// <summary>
    /// http://schema.org/Person
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
    [DataContract(Name = "Person", Namespace = "http://schema.org/Person")]
    public class Person : Thing
    {
        // ----- CONSTANTS -----

        // ----- VARIABLES -----

        /// <summary>
        /// An additional name for a Person, can be used for a middle name.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "additionalName")]
        public string AdditionalName;

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        //[DataMember(EmitDefaultValue = false, Name = "address")]
        //public PostalAddress Address;

        /// <summary>
        /// An organization that this person is affiliated with. For example,
        /// a school/university, a club, or a team.
        /// </summary>
        //[DataMember(EmitDefaultValue = false, Name = "affiliation")]
        //public Organization Affiliation;

        /// <summary>
        /// An educational organizations that the person is an alumni of.
        /// Inverse property: alumni.
        /// </summary>
        //[DataMember(EmitDefaultValue = false, Name = "alumniOf")]
        //public EducationalOrganization AlumniOf;

        /// <summary>
        /// An award won by this person or for this creative work.
        /// Supersedes awards.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "award")]
        public string Award;

        /// <summary>
        /// Date of birth.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "birthDate")]
        public DateTime BirthDate;

        /// <summary>
        /// The place where the person was born.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "birthPlace")]
        public Place BirthPlace;

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        //[DataMember(EmitDefaultValue = false, Name = "address")]
        //public PostalAddress Address;

        /// <summary>
        /// A child of a person.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "children")]
        public Person Children;

        /// <summary>
        /// A colleague of the person.
        /// Supersedes colleagues.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "colleague")]
        public Person Colleague;

        /// <summary>
        /// A contact point for a person or organization.
        /// Supersedes contactPoints.
        /// </summary>
        //[DataMember(EmitDefaultValue = false, Name = "contactPoint")]
        //public ContactPoint contactPoint;

        /// <summary>
        /// Date of death.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "deathDate")]
        public DateTime DeathDate;

        /// <summary>
        /// The place where the person died.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "deathPlace")]
        public Place DeathPlace;

        /// <summary>
        /// The Dun & Bradstreet DUNS number for identifying an
        /// organization or business person.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "duns")]
        public string Duns;

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "email")]
        public string Email;

        /// <summary>
        /// Family name. In the U.S., the last name of an Person.
        /// This can be used along with givenName instead of the
        /// name property.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "familyName")]
        public string FamilyName;

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "faxNumber")]
        public string FaxNumber;

        /// <summary>
        /// The most generic uni-directional social relation.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "follows")]
        public Person Follows;

        /// <summary>
        /// Gender of the person.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "gender")]
        public string Gender;

        /// <summary>
        /// Given name. In the U.S., the first name of a Person. This
        /// can be used along with familyName instead of the name
        /// property.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "givenName")]
        public string GivenName;

        /// <summary>
        /// The Global Location Number (GLN, sometimes also referred
        /// to as International Location Number or ILN) of the
        /// respective organization, person, or place. The GLN is a
        /// 13-digit number used to identify parties and physical
        /// locations.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "globalLocationNumber")]
        public string GlobalLocationNumber;

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "hasPOS")]
        public Place HasPos;

        /// <summary>
        /// An honorific prefix preceding a Person's name such as
        /// Dr/Mrs/Mr.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "honorificSuffix")]
        public string HonorificSuffix;

        /// <summary>
        /// A count of a specific user interactions with this item—for
        /// example, 20 UserLikes, 5 UserComments, or 300 UserDownloads.
        /// The user interaction type should be one of the sub types of
        /// UserInteraction.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "interactionCount")]
        public string InteractionCount;

        /// <summary>
        /// The International Standard of Industrial Classification of All
        /// Economic Activities (ISIC), Revision 4 code for a particular
        /// organization, business person, or place.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "isicV4")]
        public string IsicV4;

        /// <summary>
        /// The job title of the person (for example, Financial Manager).
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "jobTitle")]
        public string JobTitle;

        /// <summary>
        /// The most generic bi-directional social/work relation.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "knows")]
        public Person Knows;

        /// <summary>
        /// A pointer to products or services offered by the organization
        /// or person.
        /// </summary>
        //[DataMember(EmitDefaultValue = false, Name = "makesOffer")]
        //public Offer MakesOffer;

        /// <summary>
        /// The North American Industry Classification System (NAICS) code
        /// for a particular organization or business person.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "naics")]
        public string Naics;

        /// <summary>
        /// Nationality of the person.
        /// </summary>
        //[DataMember(EmitDefaultValue = false, Name = "nationality")]
        //public Country Nationality;

        /// <summary>
        /// The total financial value of the organization or person as
        /// calculated by subtracting assets from liabilities.
        /// </summary>
        //[DataMember(EmitDefaultValue = false, Name = "netWorth")]
        //public PriceSpecification NetWorth;

        /// <summary>
        /// A parent of this person. Supersedes parents.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "parent")]
        public Person Parent;

        /// <summary>
        /// Event that this person is a performer or participant in.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "preformerIn")]
        public Event PerformerIn;

        /// <summary>
        /// The most generic familial relation.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "relatedTo")]
        public Person RelatedTo;

        /// <summary>
        /// A pointer to products or services sought by the organization
        /// or person (demand).
        /// </summary>
        //[DataMember(EmitDefaultValue = false, Name = "seeks")]
        //public Demand Seeks;

        /// <summary>
        /// A sibling of the person. Supersedes siblings.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "sibling")]
        public Person Sibling;

        /// <summary>
        /// The person's spouse.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "spouse")]
        public Person Spouse;

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person,
        /// e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "taxID")]
        public string TaxId;

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "telephone")]
        public string Telephone;

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "vatID")]
        public string VatId;

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        //[DataMember(EmitDefaultValue = false, Name = "weight")]
        //public QuantitativeValue Weight;

        /// <summary>
        /// Organizations that the person works for.
        /// </summary>
        //[DataMember(EmitDefaultValue = false, Name = "worksFor")]
        //public Organization WorksFor;

        // ----- PROPERTIES -----

        /// <summary>
        /// The brand(s) associated with a product or service, or the 
        /// brand(s) maintained by an organization or business person.
        /// Expected Types: Organization or Brand.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "brand")]
        public dynamic Brand
        {
            get;
            set;
        }

        /// <summary>
        /// The height of the item.
        /// Expected Types: Distance or QuantitativeValue.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "height")]
        public dynamic Height
        {
            get;
            set;
        }

        /// <summary>
        /// A contact location for a person's residence.
        /// Expected Types: ContactPoint on Place.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "homeLocation")]
        public dynamic HomeLocation
        {
            get;
            set;
        }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person
        /// or Organization belongs.
        /// Inverse property: member.
        /// Expected Types: Organization or ProgramMembership
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "memberOf")]
        public dynamic MemberOf
        {
            get;
            set;
        }

        /// <summary>
        /// Products owned by the organization or person.
        /// Inverse property: member.
        /// Expected Types: OwnershipInfo or Product
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "owns")]
        public dynamic Owns
        {
            get;
            set;
        }

        /// <summary>
        /// A contact location for a person's place of work.
        /// Expected Types: ContactPoint or Place
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "workLocation")]
        public dynamic WorkLocation
        {
            get;
            set;
        }

        // ----- CONSTRUCTORS -----

        // ----- METHODS -----

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Person()
        {

        }

        /// <summary>
        /// Construct a Person from an ExpandoObject with like properties and values.
        /// </summary>
        /// <param name="expando">The ExpandoObject to use when populating the Person.</param>
        public Person (ExpandoObject expando) : base(expando)
        {
        }
    }
}
