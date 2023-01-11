using HA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Plugins.Interfaces.Repository
{
    public interface IObligationSubjectRepository
    {
        IEnumerable<ObligationSubject> GetObligationSubjects();

        ObligationSubject GetObligationSubjectById(int obligationSubjectId);

        void AddObligationSubject(ObligationSubject obligationSubject);

        void UpdateObligationSubject(ObligationSubject obligationSubject);

        void DeleteObligationSubject(int obligationSubjectId);

        void DeleteObligationSubject(ObligationSubject obligationSubject);
    }
}
