namespace HOLMS.Types.Money.Cards {
    public partial class NotPresentPaymentCard {
        public string MaskedPAN => CardNumber.Substring(CardNumber.Length - 4);
    }
}
