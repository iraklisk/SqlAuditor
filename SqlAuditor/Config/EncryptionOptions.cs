using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlAuditor.Config
{
    [Serializable]
    public enum EncryptionOptions
    {
        None = 0,
        Normal = 1,
        Strong = 2
    }
}
