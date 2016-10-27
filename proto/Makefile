INCLUDE_PATH=/usr/local/include
PROTO_PATH=.
GO_SRC_PATH=$GOPATH/src
GO_GOOGLE_APIS_PATH=$GOPATH/src/github.com/grpc-ecosystem/grpc-gateway/third_party/googleapis
PROTOC_CMD="protoc -I${PROTO_PATH} -I${GOPATH}/src -I${GO_GOOGLE_APIS_PATH} -Igoogle/protobuf \
    --go_out=Mgoogle/api/annotations.proto=github.com/grpc-ecosystem/grpc-gateway/third_party/googleapis/google/api,plugins=grpc,import_prefix=github.com/shortbar/holms.types/golang/:../golang/ \
    --grpc-gateway_out=../golang" 

# gRPC service definitions
$PROTOC_CMD ./booking/rpc/*.proto
$PROTOC_CMD ./crm/rpc/*.proto
$PROTOC_CMD ./iam/rpc/*.proto
$PROTOC_CMD ./money/rpc/*.proto
$PROTOC_CMD ./operations/rpc/*.proto
$PROTOC_CMD ./supply/rpc/*.proto
$PROTOC_CMD ./tenancy_config/rpc/*.proto

# Message definitions
$PROTOC_CMD booking/*.proto
$PROTOC_CMD booking/channels/*.proto
$PROTOC_CMD booking/check_in/*.proto
$PROTOC_CMD booking/groups/*.proto
$PROTOC_CMD booking/guarantees/*.proto
$PROTOC_CMD booking/history/*.proto
$PROTOC_CMD booking/indicators/*.proto
$PROTOC_CMD booking/reservations/*.proto
$PROTOC_CMD booking/pricing/*.proto
$PROTOC_CMD booking/incidental_reservations/*.proto

$PROTOC_CMD crm/groups/*.proto
$PROTOC_CMD crm/guests/*.proto

$PROTOC_CMD iam/*.proto

$PROTOC_CMD money/accounting/*.proto
$PROTOC_CMD money/cards/*.proto
$PROTOC_CMD money/folio/*.proto

$PROTOC_CMD operations/*.proto
$PROTOC_CMD operations/attractions/*.proto
$PROTOC_CMD operations/housekeeping/*.proto
$PROTOC_CMD operations/messaging/*.proto
$PROTOC_CMD operations/note_requests/*.proto
$PROTOC_CMD operations/out_of_order/*.proto
$PROTOC_CMD operations/pbx_events/*.proto
$PROTOC_CMD operations/reporting/*.proto
$PROTOC_CMD operations/rooms/*.proto
$PROTOC_CMD operations/room_claims/*.proto

$PROTOC_CMD pbx_connector/*.proto

$PROTOC_CMD primitive/*.proto

$PROTOC_CMD supply/*.proto
$PROTOC_CMD supply/incidental_items/*.proto
$PROTOC_CMD supply/packages/*.proto
$PROTOC_CMD supply/room_types/*.proto
$PROTOC_CMD supply/snapshot/*.proto

$PROTOC_CMD tenancy_config/*.proto
$PROTOC_CMD tenancy_config/indicators/*.proto

$PROTOC_CMD google/protobuf/*.proto

grep -r "github.com/shortbar/holms.types/golang/github.com" ../golang/|cut -f1 -d:|xargs sed -i -r 's/github.com\/shortbar\/holms.types\/golang\/github.com\//github.com\//gi'
grep -r "github.com/shortbar/holms.types/golang/golang.org" ../golang/|cut -f1 -d:|xargs sed -i -r 's/github.com\/shortbar\/holms.types\/golang\/golang.org\//golang.org\//gi'
grep -r "github.com/shortbar/holms.types/golang/google.golang.org" ../golang/|cut -f1 -d:|xargs sed -i -r 's/github.com\/shortbar\/holms.types\/golang\/google.golang.org\//google.golang.org\//gi'
