using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChanges();
    }
}
#region
//Coordina los cambios realizados en los datos
//asegura que se guarden en la base de datos como una unidad.
#endregion