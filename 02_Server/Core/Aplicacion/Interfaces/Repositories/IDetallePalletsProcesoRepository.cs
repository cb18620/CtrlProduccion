using Aplicacion.DTOs.Almacen;
using Aplicacion.Wrappers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces.Repositories
{
    public interface IDetallePalletsProcesoRepository
    {
        Task<Response<List<AlmContenidoPalletsDto>>> GetDestallePalletProceso(int idCabecera);


    }
}
