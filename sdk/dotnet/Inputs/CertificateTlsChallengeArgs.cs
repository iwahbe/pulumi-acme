// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Acme.Inputs
{

    public sealed class CertificateTlsChallengeArgs : global::Pulumi.ResourceArgs
    {
        [Input("port")]
        public Input<int>? Port { get; set; }

        public CertificateTlsChallengeArgs()
        {
        }
        public static new CertificateTlsChallengeArgs Empty => new CertificateTlsChallengeArgs();
    }
}
