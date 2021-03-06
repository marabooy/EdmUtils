//---------------------------------------------------------------------
// <copyright file="IJsonValue.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

namespace Microsoft.OData.Utils.Json
{
    /// <summary>
    /// Defines JSON Value kinds.
    /// </summary>
    internal enum JsonValueKind
    {
        /// <summary>
        /// Represents a Primitive JSON value kind. Primitive value could be:
        /// null, boolean, string, Int32, Decimal, Double.
        /// </summary>
        Primitive,

        /// <summary>
        /// Represents an Object JSON value kind.
        /// An object JSON is a wrapper of a key/value pair.
        /// </summary>
        Object,

        /// <summary>
        /// Represents an Array JSON value kind.
        /// An array JSON is a collection of other JSON values.
        /// </summary>
        Array
    }

    /// <summary>
    /// Represents the definition of a JSON value.
    /// </summary>
    internal interface IJsonValue
    {
        /// <summary>
        /// Gets the kind of this JSON value.
        /// </summary>
        JsonValueKind ValueKind { get; }
    }
}
