using HA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HA.Plugins.Interfaces.Repository
{
    public interface ITransactionRepository
    {
        IEnumerable<Transaction> GetTransactions();

        Transaction GetTransactionById(int transactionId);
        
        void AddTransaction(Transaction transaction);

        void UpdateTransaction(Transaction transaction);

        void DeleteTransaction(int transactionId);

        void DeleteTransaction(Transaction transaction);
    }
}
