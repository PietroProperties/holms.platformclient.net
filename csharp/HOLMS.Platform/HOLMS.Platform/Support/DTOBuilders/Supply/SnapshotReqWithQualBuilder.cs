using HOLMS.Support.Time;
using HOLMS.Types.Primitive;
using HOLMS.Types.Supply;
using HOLMS.Types.Supply.RPC;
using HOLMS.Types.TenancyConfig.Indicators;

namespace HOLMS.Platform.Support.DTOBuilders.Supply {
    public class SnapshotReqWithQualBuilder {
        private readonly PbInclusiveOpsdateRange _dr;
        private readonly PropertyIndicator _p;
        private readonly QualificationIndicator _qi;

        public SnapshotReqWithQualBuilder(InclusiveOpsdateRange dr, PropertyIndicator pi,
            QualificationIndicator qi) {
            _dr = dr.ToPB;
            _p = pi;
            _qi = qi;
        }

        public SupplySnapshotSvcSnapshotWithQualReq Build() {
            var req = new SupplySnapshotSvcSnapshotWithQualReq {
                DateRange = _dr,
                Property = _p
            };

            if (_qi != null) {
                req.Qualification = _qi;
            }

            return req;
        }
    }
}
