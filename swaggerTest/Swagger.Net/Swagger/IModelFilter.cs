﻿using Newtonsoft.Json.Serialization;
using System;

namespace Swagger.Net
{
    public interface IModelFilter
    {
        void Apply(Schema model, ModelFilterContext context);
    }

    public class ModelFilterContext
    {
        public ModelFilterContext(
            Type systemType,
            JsonObjectContract jsonObjectContract,
            SchemaRegistry schemaRegistry)
        {
            SystemType = systemType;
            JsonObjectContract = jsonObjectContract;
            SchemaRegistry = schemaRegistry;
        }

        public Type SystemType { get; private set; }

        public JsonObjectContract JsonObjectContract { get; private set; }

        public SchemaRegistry SchemaRegistry { get; private set; }
    }
}
