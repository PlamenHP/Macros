using System;
using System.Collections.Generic;
using System.Text;

namespace Macros.Application
{
    public class ApplicationSettings
    {
        public ApplicationSettings() => this.Secret = default!;

        public string Secret { get; private set; }
    }
}
