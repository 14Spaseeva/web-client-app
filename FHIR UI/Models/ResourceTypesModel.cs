﻿using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FHIR_UI.Models
{
    /// <summary>
    /// contains properties of FHIR types
    /// </summary>
    public class ResourceTypesModel
    {

        public readonly Array typesAsArray_;

       public ResourceTypesModel()
        {
            typesAsArray_ = Enum.GetValues(typeof(ResourceType));
        }
    }
}
