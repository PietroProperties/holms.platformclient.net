using System;

namespace HOLMS.Types.Operations.Housekeeping {
    public static class RoomReservationAssignmentStatusExtensions {
        public static string ToEnglish(this RoomReservationAssignmentStatus rras) {
            switch (rras) {
                case RoomReservationAssignmentStatus.VacantVacant:
                    return "Vacant";
                case RoomReservationAssignmentStatus.Stayover:
                    return "Stayover";
                case RoomReservationAssignmentStatus.LeavingNoneIncoming:
                    return "Departure";
                case RoomReservationAssignmentStatus.LeftNoneIncoming:
                    return "Checked Out";
                case RoomReservationAssignmentStatus.LeavingWithIncoming:
                    return "Departure/Arrival";
                case RoomReservationAssignmentStatus.LeftWithIncoming:
                    return "Checked Out/Arrival";
                case RoomReservationAssignmentStatus.LeftWithOutOfOrder:
                    return "Checked Out/OOO";
                case RoomReservationAssignmentStatus.LeftIncomingArrived:
                    return "Checked Out/Checked In";
                case RoomReservationAssignmentStatus.VacantWithIncoming:
                    return "Arrival";
                case RoomReservationAssignmentStatus.ArrivedAfterVacancy:
                    return "Checked In";
                case RoomReservationAssignmentStatus.RoomReservationAssignmentOutOfOrder:
                    return "Out of order";
                case RoomReservationAssignmentStatus.Other:
                    return "Other";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
