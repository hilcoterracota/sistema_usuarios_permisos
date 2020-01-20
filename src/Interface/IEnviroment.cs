using System.Collections.Generic;
using System.Threading.Tasks;
using Sampekey.Model.Configuration.Quid;

namespace Sampekey.Interface
{
    public interface IEnviroment
    {
        Task<IEnumerable<Enviroment>> GetAllEnviroments();
        Task<Enviroment> FindEnviromentById(string value);
        Task<Enviroment> AddEnviroment(Enviroment value);
        Task<Enviroment> UpdateEnviroment(Enviroment value);
        Task<bool> DeleteEnviroment(Enviroment value);

    }
}
