using MetricsAgent.DAL.Repositories;
using MetricsAgent.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.DAL.Interfaces
{
    public interface IDotNetMetricsRepository : IRepository<DotNetMetric>
    {

    }
}
