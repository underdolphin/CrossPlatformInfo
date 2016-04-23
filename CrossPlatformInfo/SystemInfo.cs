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

namespace CrossPlatformInfo
{
    public class SystemInfo
    {
        public OperatingSystem OSInfo
        {
            get
            {
                return Environment.OSVersion;
            }
        }

        public Version OSVersion
        {
            get
            {
                return Environment.OSVersion.Version;
            }
        }

        public string ServicePackName
        {
            get
            {
                return Environment.OSVersion.ServicePack;
            }
        }

        public string OSFamilyName
        {
            get
            {
                switch (Environment.OSVersion.Platform)
                {
                    case PlatformID.Win32NT:
                        return "Win32NT";
                    case PlatformID.Unix:
                        return "Unix";
                    case PlatformID.MacOSX:
                        return "MacOSX";
                    default:
                        return "OtherOS";
                }
            }
        }

        public string OSName
        {
            get
            {
                var osFamily = OSFamilyName;
                var osVersion = OSVersion;
                var osMajorVersion = osVersion.Major;
                var osMinerVersion = osVersion.Minor;
                var servicePackName = ServicePackName;
                var osName = "";
                switch (osFamily)
                {
                    case "Win32NT":
                        osName = "Windows";
                        break;
                    case "Unix":
                        osName = "Unix";
                        break;
                    default:
                        osName = "Others";
                        break;
                }

                if (osName == "Windows")
                {
                    switch (osMajorVersion)
                    {
                        case 6:
                            switch (osMinerVersion)
                            {
                                case 0:
                                    osName += " Vista";
                                    osName += " " + servicePackName;
                                    break;
                                case 1:
                                    osName += " 7";
                                    osName += " " + servicePackName;
                                    break;
                                case 2:
                                    osName += " 8";
                                    break;
                                case 3:
                                    osName += " 8.1";
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 10:
                            osName += " 10";
                            break;
                        default:
                            osName += " NT Others";
                            break;
                    }
                }
                return osName;
            }
        }

        public int OSBit
        {
            get
            {
                if (Environment.Is64BitOperatingSystem)
                {
                    return 64;
                }
                else
                {
                    return 32;
                }
            }
        }

        public int ProcessBit
        {
            get
            {
                if (IntPtr.Size == 8)
                {
                    return 64;
                }
                else if (IntPtr.Size == 4)
                {
                    return 32;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int ProcessorCout
        {
            get
            {
                return Environment.ProcessorCount;
            }
        }
    }
}
