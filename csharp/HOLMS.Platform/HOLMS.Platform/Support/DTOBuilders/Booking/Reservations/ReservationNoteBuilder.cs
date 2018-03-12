using System;
using HOLMS.Types.Booking.Indicators;
using HOLMS.Types.Booking.Reservations;
using HOLMS.Types.Operations.NoteRequests;

namespace HOLMS.Platform.Support.DTOBuilders.Booking.Reservations {
    public class ReservationNoteBuilder {
        private readonly ReservationNoteIndicator _id;
        private readonly NoteRequestIndicator _sourceNote;
        private readonly NoteCategory _category;
        private readonly string _additionalNote;
        private readonly bool _includeOnConfirmation;
        private readonly ReservationIndicator _lodgingReservation;
        private readonly string _sourceNoteSubject;
        private bool _isFulfilled;

        public ReservationNoteBuilder(Guid id, NoteRequestIndicator sourceNote,
            NoteCategory category, string additionalNote, bool includeOnConfirmation,
            ReservationIndicator lodgingReservation, string sourceNoteSubject, bool isFulfilled) {
            _id = new ReservationNoteIndicator(id);
            _sourceNote = sourceNote;
            _category = category;
            _additionalNote = additionalNote;
            _includeOnConfirmation = includeOnConfirmation;
            _lodgingReservation = lodgingReservation;
            _sourceNoteSubject = sourceNoteSubject;
            _isFulfilled = isFulfilled;
        }

        public ReservationNote Build() {
            var rn = new ReservationNote {
                AdditionalNote = _additionalNote ?? string.Empty,
                Category = _category,
                EntityId = _id,
                IncludeOnConfirmation = _includeOnConfirmation,
                LodgingReservation = _lodgingReservation,
                SourceNoteSubject = _sourceNoteSubject ?? string.Empty,
                IsFulfilled = _isFulfilled
            };

            if (_sourceNote != null) {
                rn.SourceNote = _sourceNote;
            }

            return rn;
        }
    }
}
