using HOLMS.Types.Money.Accounting;

namespace HOLMS.Platform.Support.DTOExtensions {
    public static class TransactionLineExtensions {
        public static bool IsPaymentDesignation(this TransactionLineDesignation d) {
            return d == TransactionLineDesignation.CardPayment ||
                d == TransactionLineDesignation.CashPayment ||
                d == TransactionLineDesignation.CheckPayment;
        }
    }
}
