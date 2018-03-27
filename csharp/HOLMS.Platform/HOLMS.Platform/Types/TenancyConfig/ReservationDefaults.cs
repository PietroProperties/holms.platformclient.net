using System;
using HOLMS.Types.Extensions.Support;
using HOLMS.Types.Primitive;
using HOLMS.Types.Supply;

namespace HOLMS.Types.TenancyConfig {
    public partial class ReservationDefaults {
        public ReservationDefaults(Guid? defaultRateScheduleId,
            bool showCancellationPolicy, bool requirePhoneNumber, CharacterCaseType characterCase,
            int blockDropDays) {
            ShowCancellationPolicy = showCancellationPolicy;
            RequirePhoneNumber = requirePhoneNumber;
            CharacterCase = characterCase;
            BlockDropDays = blockDropDays;

            if (defaultRateScheduleId.HasValue) {
                DefaultRateSchedule = new RateScheduleIndicator {
                    Id = defaultRateScheduleId.Value.ToUUID()
                };
            }
        }
    }
}
