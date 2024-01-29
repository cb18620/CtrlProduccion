using Aplicacion.Almacen.DTOs;
using Aplicacion.Wrappers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aplicacion.Interfaces.Repositories
{
    public interface ISalidadespachoRepository
    {
        Task<Response<List<AlmSalidadespachoDto>>> GetSalidadespacho();


    }
}
