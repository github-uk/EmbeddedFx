﻿// Copyright 2012-2013 Steve Wood
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1634:FileHeaderMustShowCopyright", Justification = "Documentation ignored at present time.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1639:FileHeaderMustHaveSummary", Justification = "Documentation ignored at present time.")]

namespace EmbeddedFx
{
    using System.IO;
    using System.Reflection;

    internal sealed class EmbeddedResource
    {
        public EmbeddedResource(Assembly assembly, string resourceName)
        {
            this.Assembly = assembly;
            this.ResourceName = resourceName;
        }

        public Stream Content
        {
            get
            {
                return this.Assembly.GetManifestResourceStream(this.ResourceName);
            }
        }

        private Assembly Assembly { get; set; }

        private string ResourceName { get; set; }
    }
}