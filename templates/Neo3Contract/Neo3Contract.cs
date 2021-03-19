using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System;
using System.ComponentModel;

namespace Neo3Contract
{
    [DisplayName("Neo3Contract")]
    [ManifestExtra("Author", "NEO")]
    [ManifestExtra("Email", "developer@neo.org")]
    [ManifestExtra("Description", "This is a Neo3Contract")]
    class Neo3Contract : SmartContract
    {
        public static bool Main()
        {
            return true;
        }
    }
}
