using HOLMS.Types.Primitive;

namespace HOLMS.Types.TenancyConfig {
    public partial class ReservationStatusColors {
        public ReservationStatusColors(
            StatusColor tentativeColorIndividual, StatusColor tentativeColorGroup,
            StatusColor guaranteedColorIndividual, StatusColor guaranteedColorGroup,
            StatusColor depositedColorIndividual, StatusColor depositedColorGroup,
            StatusColor arrivalColorIndividual, StatusColor arrivalColorGroup,
            StatusColor inhouseColorIndividual, StatusColor inhouseColorGroup,
            StatusColor departureColorIndividual, StatusColor departureColorGroup,
            StatusColor checkedOutColorIndividual, StatusColor checkedOutColorGroup,
            StatusColor noShowColorIndividual, StatusColor noShowColorGroup,
            StatusColor canceledColorIndividual, StatusColor canceledColorGroup,
            StatusColor canceledWithFeeColorIndividual, StatusColor canceledWithFeeColorGroup,
            StatusColor openColorIndividual, StatusColor openColorGroup,
            StatusColor arrivalOverdueColorIndividual, StatusColor arrivalOverdueColorGroup) {
            UnguaranteedNotDueIndividual = tentativeColorIndividual;
            UnguaranteedNotDueGroup = tentativeColorGroup;
            GuaranteedColorIndividual = guaranteedColorIndividual;
            GuaranteedColorGroup = guaranteedColorGroup;
            UnguaranteedOverdueIndividual = depositedColorIndividual;
            UnguaranteedOverdueGroup = depositedColorGroup;
            ArrivalColorIndividual = arrivalColorIndividual;
            ArrivalColorGroup = arrivalColorGroup;
            InhouseColorIndividual = inhouseColorIndividual;
            InhouseColorGroup = inhouseColorGroup;
            DepartureColorIndividual = departureColorIndividual;
            DepartureColorGroup = departureColorGroup;
            CheckedOutColorIndividual = checkedOutColorIndividual;
            CheckedOutColorGroup = checkedOutColorGroup;
            NoShowColorIndividual = noShowColorIndividual;
            NoShowColorGroup = noShowColorGroup;
            CanceledColorIndividual = canceledColorIndividual;
            CanceledColorGroup = canceledColorGroup;
            CanceledWithFeeColorIndividual = canceledWithFeeColorIndividual;
            CanceledWithFeeColorGroup = canceledWithFeeColorGroup;
            OpenColorIndividual = openColorIndividual;
            OpenColorGroup = openColorGroup;
            ArrivalOverdueColorIndividual = arrivalOverdueColorIndividual;
            ArrivalOverdueColorGroup = arrivalOverdueColorGroup;
        }
    }
}
