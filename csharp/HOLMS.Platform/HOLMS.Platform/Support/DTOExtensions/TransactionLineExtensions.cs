using HOLMS.Types.Money.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOLMS.Support.DTOExtensions {
    public static class TransactionLineExtensions {
        public static bool IsPaymentDesignation(this TransactionLineDesignation d) {
            return d == TransactionLineDesignation.CardPayment ||
                d == TransactionLineDesignation.CashPayment ||
                d == TransactionLineDesignation.CheckPayment;
        }
    }
}
