using HA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Plugins.Interfaces.Repository
{
    public interface IObligationRepository
    {
        IEnumerable<Obligation> GetObligations();

        Obligation GetObligationById(int obligationId);

        void AddObligation(Obligation obligation);

        void UpdateObligation(Obligation obligation);

        void DeleteObligation(int obligationId);

        void DeleteObligation(Obligation obligation);
    }
}
