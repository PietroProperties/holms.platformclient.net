using System;
using HOLMS.Types.Primitive;

namespace HOLMS.Types.TenancyConfig {
    public partial class DefaultTemplates {
        public DefaultTemplates(Guid? reservationConfirmationTemplateId,
            Guid? arrivalLetterTemplateId, Guid? individualFolioTemplateId,
            Guid? groupFolioTemplateId) {
            if (reservationConfirmationTemplateId.HasValue) {
                ReservationConfirmationTemplateId = new TemplateIndicator(
                    reservationConfirmationTemplateId.Value);
            }

            if (arrivalLetterTemplateId.HasValue) {
                ArrivalLetterTemplateId = new TemplateIndicator(
                    arrivalLetterTemplateId.Value);
            }

            if (individualFolioTemplateId.HasValue) {
                IndividualFolioTemplateId = new TemplateIndicator(
                    individualFolioTemplateId.Value);
            }

            if (groupFolioTemplateId.HasValue) {
                GroupFolioTemplateId = new TemplateIndicator(
                    groupFolioTemplateId.Value);
            }
        }
    }
}
