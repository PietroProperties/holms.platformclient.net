using HOLMS.Types.Folio.RPC;

namespace HOLMS.Platform.Support.Conversions
{
    public static class MasterClientResultToMessageConversions
    {
        public static string ToMessage(ReservationFolioSvcRequestMasterFolioResult result)
        {
            switch (result)
            {
                case ReservationFolioSvcRequestMasterFolioResult.MasterFolioSvcRequestMasterFolioOk:
                    return "Master Folio Assigned Successfully.";
                case ReservationFolioSvcRequestMasterFolioResult.MasterFolioSvcRequestMasterFolioClientHasMaster:
                    return "Client reservation already has a master. Please remove the existing link first.";
                case ReservationFolioSvcRequestMasterFolioResult.MasterFolioSvcRequestMasterFolioMasterHasMaster:
                    return "Master reservation already has a master. Please remove the existing link first.";
                case ReservationFolioSvcRequestMasterFolioResult.MasterFolioSvcRequestClientHasClient:
                    return "Client reservation already has a client. Please remove the existing link first.";
                case ReservationFolioSvcRequestMasterFolioResult.MasterFolioSvcRequestMasterFolioDisallowedMaster:
                    return "Master reservation is already linked with a group booking. Please remove the existing link first.";
                case ReservationFolioSvcRequestMasterFolioResult.MasterFolioSvcRequestMasterFolioDisallowedClient:
                    return "Client reservation is already linked with a group booking. Please remove the existing link first."; ;
                case ReservationFolioSvcRequestMasterFolioResult.MasterFolioSvcRequestMasterFolioFailure:
                    return "Assignment failed. ";
                default:
                    return result.ToString();
            }
        }
    }
}
