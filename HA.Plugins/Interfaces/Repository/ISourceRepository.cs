using HA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Plugins.Interfaces.Repository
{
    public interface ISourceRepository
    {
        IEnumerable<Source> GetSources();

        Source GetSourceById(int sourceId);

        void AddSource(Source source);

        void UpdateSource(Source source);

        void DeleteSource(Source source);

        void DeleteSource(int sourceId);
    }
}
