using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.Validation.Entities.Enums
{
    public enum ValidationConstrain
    {
        AlwaysValidate,
        ValidateIfThereAreNoPreviousErrors
    }
}

//Cuando se registren distintas clases de validación para un modelo, esta enumeración nos
//permitirá especificar si un validador se ejecutara siempre o solo cuando no haya errores
//previos de algún otro validador.