using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool Charge(int paymentAccountId, float amount)
        {
            var account = FindById(paymentAccountId);
            return account?.Charge(amount) ?? false;
        }

        private PaymentAccount FindById(int paymentAccountId)
        {
            return PaymentAccounts.SingleOrDefault(x => x.Id == paymentAccountId);
        }

        public void Fund(int paymentAccountId, float amount)
        {
            var account = FindById(paymentAccountId);
            account?.Fund(amount);
        }
    }
}
