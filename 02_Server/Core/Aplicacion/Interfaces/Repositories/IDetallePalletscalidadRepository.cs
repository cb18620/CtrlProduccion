using Aplicacion.DTOs.Almacen;
using Aplicacion.Wrappers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces.Repositories
{
    public interface IDetallePalletsRepository
    {
        Task<Response<List<AlmContenidoPalletsDto>>> GetDestallePallet(int idCabecera);


    }
}
