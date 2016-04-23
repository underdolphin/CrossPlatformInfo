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
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace CrossPlatformInfo
{
    public class HardwareInfo
    {
        ComputerInfo info;
        public HardwareInfo()
        {
            info = new ComputerInfo();
        }

        public ulong TotalPhysicalMemory
        {
            get
            {
                return info.TotalPhysicalMemory;
            }
        }

        public ulong AvailablePhysicalMemory
        {
            get
            {
                return info.AvailablePhysicalMemory;
            }
        }

        public ulong TotalVirtualMemory
        {
            get
            {
                return info.TotalVirtualMemory;
            }
        }

        public ulong AvailableVirtualMemory
        {
            get
            {
                return info.AvailableVirtualMemory;
            }
        }

        public int GetPrimaryScreenWidth
        {
            get
            {
                return Screen.PrimaryScreen.Bounds.Width;
            }
        }

        public int GetPrimaryScreenHeight
        {
            get
            {
                return Screen.PrimaryScreen.Bounds.Height;
            }
        }
    }
}
