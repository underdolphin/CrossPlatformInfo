/* Copyright [yyyy] [name of copyright owner]

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
using System;
using System.Runtime.InteropServices;

namespace CrossPlatformInfo
{
    public class RuntimeInfo
    {
        public Version Version
        {
            get
            {
                return Environment.Version;
            }
        }

        public int MajorVersion
        {
            get
            {
                return Environment.Version.Major;
            }
        }

        public int MinorVersion
        {
            get
            {
                return Environment.Version.Minor;
            }
        }

        public int BuildVersion
        {
            get
            {
                return Environment.Version.Build;
            }
        }

        public int RevisionVersion
        {
            get
            {
                return Environment.Version.Revision;
            }
        }

        public string VersionString
        {
            get
            {
                return RuntimeEnvironment.GetSystemVersion();
            }
        }
    }
}
