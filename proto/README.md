This directory contains the protocol buffer and gRPC definitions for the HOLMS
application server.

Style Conventions
=================
Each file should contain a syntax = "proto3" directive, a package name,
a c# namespace, and a go_package directive. 

Assume the file's relative path is "booking/lodging_reservation.proto",
then the package would be holms.types.booking, the C# namespace would be 
HOLMS.Types.Booking.LodgingReservation (Pascal), and the go_package would be
"booking/lodgingreservation" (all lowercase, no spaces).

