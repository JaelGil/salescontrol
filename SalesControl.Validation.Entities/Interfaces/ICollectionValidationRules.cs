﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.Validation.Entities.Interfaces
{
    public interface ICollectionValidationRules<T, TProperty>
    {
        ICollectionValidationRules<T, TProperty> SetValidator(
        IModelValidator<TProperty> validator);
    }
}
