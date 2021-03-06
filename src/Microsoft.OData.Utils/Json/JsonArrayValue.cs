//---------------------------------------------------------------------
// <copyright file="JsonArrayValue.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

using System.Collections.Generic;

namespace Microsoft.OData.Utils.Json
{
    /// <summary>
    /// Represents a JSON array value.
    /// A json array value likes:
    /// [
    ///    ...
    /// ]
    /// The JSON array includes list of other <see cref="IJsonValue"/>.
    /// </summary>
    internal class JsonArrayValue : List<IJsonValue>, IJsonValue
    {
        /// <summary>
        /// Gets the kind of this JSON value.
        /// </summary>
        public JsonValueKind ValueKind => JsonValueKind.Array;
    }
}
