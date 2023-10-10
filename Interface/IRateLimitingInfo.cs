using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateLimiting
{
    public interface IRateLimitingInfo
    {
        string Key { get; }

        void Visit();

        bool Check();
    }
}
