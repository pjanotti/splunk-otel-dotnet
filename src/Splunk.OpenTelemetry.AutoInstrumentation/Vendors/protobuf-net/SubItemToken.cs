//------------------------------------------------------------------------------
// <auto-generated />
// Vendored from https://github.com/protobuf-net/protobuf-net/archive/refs/tags/2.4.8.zip
//------------------------------------------------------------------------------

using System;

namespace Splunk.OpenTelemetry.AutoInstrumentation.Vendors.ProtoBuf
{
    /// <summary>
    /// Used to hold particulars relating to nested objects. This is opaque to the caller - simply
    /// give back the token you are given at the end of an object.
    /// </summary>
    internal readonly struct SubItemToken
    {
        internal readonly long value64;
        internal SubItemToken(int value) => value64 = value;
        internal SubItemToken(long value) => value64 = value;
    }
}
