// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Acme.Outputs
{

    [OutputType]
    public sealed class CertificateTlsChallenge
    {
        public readonly int? Port;

        [OutputConstructor]
        private CertificateTlsChallenge(int? port)
        {
            Port = port;
        }
    }
}
