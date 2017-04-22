@echo off
SETLOCAL EnableDelayedExpansion
for /F "tokens=1,2 delims=#" %%a in ('"prompt #$H#$E# & echo on & for %%b in (1) do     rem"') do (
  set "DEL=%%a"
)

SET PROTOC=%USERPROFILE%\.nuget\packages\Grpc.Tools\1.0.1-pre1\tools\windows_x64\protoc.exe
SET GRPCC=%USERPROFILE%\.nuget\packages\Grpc.Tools\1.0.1-pre1\tools\windows_x64\grpc_csharp_plugin.exe
SET OUT_DIR=%~dp0\HOLMS.Platform\HOLMS.Platform\Types\out
SET INCL_DIR=..\proto\google\protobuf

REM ---------- gRPC service definitions
for %%P in (..\proto\booking\rpc\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% --grpc_out=%OUT_DIR% %%P --plugin=protoc-gen-grpc=%GRPCC% || exit /b 255
for %%P in (..\proto\crm\rpc\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% --grpc_out=%OUT_DIR% %%P --plugin=protoc-gen-grpc=%GRPCC% || exit /b 255
for %%P in (..\proto\iam\rpc\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% --grpc_out=%OUT_DIR% %%P --plugin=protoc-gen-grpc=%GRPCC% || exit /b 255
for %%P in (..\proto\money\rpc\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% --grpc_out=%OUT_DIR% %%P --plugin=protoc-gen-grpc=%GRPCC% || exit /b 255
for %%P in (..\proto\operations\rpc\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% --grpc_out=%OUT_DIR% %%P --plugin=protoc-gen-grpc=%GRPCC% || exit /b 255
for %%P in (..\proto\supply\rpc\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% --grpc_out=%OUT_DIR% %%P --plugin=protoc-gen-grpc=%GRPCC% || exit /b 255
for %%P in (..\proto\tenancy_config\rpc\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% --grpc_out=%OUT_DIR% %%P --plugin=protoc-gen-grpc=%GRPCC% || exit /b 255
for %%P in (..\proto\reporting\rpc\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% --grpc_out=%OUT_DIR% %%P --plugin=protoc-gen-grpc=%GRPCC% || exit /b 255

REM ---------- Message definitions
for %%P in (..\proto\booking\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\booking\channels\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\booking\check_in\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\booking\groups\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\booking\guarantees\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\booking\history\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\booking\indicators\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\booking\reservations\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\booking\pricing\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\booking\incidental_reservations\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\booking\checkout\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255

for %%P in (..\proto\crm\groups\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\crm\guests\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255

for %%P in (..\proto\iam\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255

for %%P in (..\proto\money\accounting\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\money\cards\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\money\cards\transactions\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\money\folio\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255

for %%P in (..\proto\operations\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\operations\attractions\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\operations\housekeeping\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\operations\messaging\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\operations\note_requests\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\operations\out_of_order\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\operations\pbx_events\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\operations\reporting\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\operations\rooms\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\operations\room_claims\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255

for %%P in (..\proto\pbx_connector\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255

for %%P in (..\proto\primitive\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255

for %%P in (..\proto\reporting\input_params\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\reporting\outputs\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255

for %%P in (..\proto\supply\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\supply\incidental_items\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\supply\packages\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\supply\room_types\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\supply\snapshot\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255

for %%P in (..\proto\tenancy_config\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255
for %%P in (..\proto\tenancy_config\indicators\*.proto) do %PROTOC% -I..\proto\ -I%INCL_DIR% --csharp_out=%OUT_DIR% %%P || exit /b 255

call :colorEcho 0a "Build Successful" 
goto :eof

:colorEcho
<nul set /p ".=%DEL%" > "%~2"
findstr /v /a:%1 /R "^$" "%~2" nul
del "%~2" > nul 2>&1i
