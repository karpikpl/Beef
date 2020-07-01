/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable IDE0005 // Using directive is unnecessary; are required depending on code-gen options
#pragma warning disable CA2227, CA1819 // Collection/Array properties should be read only; ignored, as acceptable for a DTO.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Beef.Entities;
using Beef.RefData;
using Newtonsoft.Json;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Common.Entities
{
    /// <summary>
    /// Represents the <see cref="Product"/> arguments entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ProductArgs : EntityBase, IEquatable<ProductArgs>
    {
        #region Privates

        private string? _name;
        private string? _description;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Name")]
        public string? Name
        {
            get => _name;
            set => SetValue(ref _name, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(Name)); 
        }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Description")]
        public string? Description
        {
            get => _description;
            set => SetValue(ref _description, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(Description)); 
        }

        #endregion

        #region IEquatable

        /// <summary>
        /// Determines whether the specified object is equal to the current object by comparing the values of all the properties.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
        public override bool Equals(object? obj)
        {
            if (!(obj is ProductArgs val))
                return false;

            return Equals(val);
        }

        /// <summary>
        /// Determines whether the specified <see cref="ProductArgs"/> is equal to the current <see cref="ProductArgs"/> by comparing the values of all the properties.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
        public bool Equals(ProductArgs? obj)
        {
            if (obj == null)
                return false;
            else if (ReferenceEquals(obj, this))
                return true;

            return base.Equals((object)obj)
                && Equals(Name, obj.Name)
                && Equals(Description, obj.Description);
        }

        /// <summary>
        /// Compares two <see cref="ProductArgs"/> types for equality.
        /// </summary>
        /// <param name="a"><see cref="ProductArgs"/> A.</param>
        /// <param name="b"><see cref="ProductArgs"/> B.</param>
        /// <returns><c>true</c> indicates equal; otherwise, <c>false</c> for not equal.</returns>
        public static bool operator == (ProductArgs? a, ProductArgs? b) => Equals(a, b);

        /// <summary>
        /// Compares two <see cref="ProductArgs"/> types for non-equality.
        /// </summary>
        /// <param name="a"><see cref="ProductArgs"/> A.</param>
        /// <param name="b"><see cref="ProductArgs"/> B.</param>
        /// <returns><c>true</c> indicates not equal; otherwise, <c>false</c> for equal.</returns>
        public static bool operator != (ProductArgs? a, ProductArgs? b) => !Equals(a, b);

        /// <summary>
        /// Returns a hash code for the <see cref="ProductArgs"/>.
        /// </summary>
        /// <returns>A hash code for the <see cref="ProductArgs"/>.</returns>
        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(Name);
            hash.Add(Description);
            return base.GetHashCode() ^ hash.ToHashCode();
        }
    
        #endregion
        
        #region ICopyFrom
    
        /// <summary>
        /// Performs a copy from another <see cref="ProductArgs"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="ProductArgs"/> to copy from.</param>
        public override void CopyFrom(object from)
        {
            var fval = ValidateCopyFromType<ProductArgs>(from);
            CopyFrom(fval);
        }
        
        /// <summary>
        /// Performs a copy from another <see cref="ProductArgs"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="ProductArgs"/> to copy from.</param>
        public void CopyFrom(ProductArgs from)
        {
             if (from == null)
                 throw new ArgumentNullException(nameof(from));

            CopyFrom((EntityBase)from);
            Name = from.Name;
            Description = from.Description;

            OnAfterCopyFrom(from);
        }
    
        #endregion
        
        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="ProductArgs"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="ProductArgs"/>.</returns>
        public override object Clone()
        {
            var clone = new ProductArgs();
            clone.CopyFrom(this);
            return clone;
        }
        
        #endregion
        
        #region ICleanUp

        /// <summary>
        /// Performs a clean-up of the <see cref="ProductArgs"/> resetting property values as appropriate to ensure a basic level of data consistency.
        /// </summary>
        public override void CleanUp()
        {
            base.CleanUp();
            Name = Cleaner.Clean(Name, StringTrim.UseDefault, StringTransform.UseDefault);
            Description = Cleaner.Clean(Description, StringTrim.UseDefault, StringTransform.UseDefault);

            OnAfterCleanUp();
        }
    
        /// <summary>
        /// Indicates whether considered initial; i.e. all properties have their initial value.
        /// </summary>
        /// <returns><c>true</c> indicates is initial; otherwise, <c>false</c>.</returns>
        public override bool IsInitial
        {
            get
            {
                return Cleaner.IsInitial(Name)
                    && Cleaner.IsInitial(Description);
            }
        }

        #endregion

        #region PartialMethods
      
        partial void OnAfterCleanUp();

        partial void OnAfterCopyFrom(ProductArgs from);

        #endregion
    } 
}

#pragma warning restore CA2227, CA1819
#pragma warning restore IDE0005
#nullable restore