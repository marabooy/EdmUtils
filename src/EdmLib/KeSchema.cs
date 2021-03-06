﻿// Copyright (c) Zhigang Xu.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;

namespace EdmLib
{
    /// <summary>
    /// Represents a schema
    /// </summary>
    public class KeSchema : KeElement
    {
        public override KeElementKind Kind { get; } = KeElementKind.Schema;

        public KeModel DelaringModel { get; set; }

        /// <summary>
        /// Schema namespace.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Schema alias.
        /// </summary>
        public string Alias { get; set; }

        public IList<KeEntityType> EntityTypes { get; set; } = new List<KeEntityType>();

        public IList<KeComplexType> ComplexTypes { get; set; } = new List<KeComplexType>();

        public IList<KeEnumType> EnumTypes { get; set; } = new List<KeEnumType>();

        public List<IEdmSchemaElement> SchemaElements;

        public List<IEdmEntityContainer> EntityContainers;

        public Dictionary<string, List<IEdmVocabularyAnnotation>> Annotations;

        public List<string> usedNamespaces;
    }
}
