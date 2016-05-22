using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationCPP
{
    public class CppInterface
    {
        public static string getIntPtr()
        {
            IntPtr pIntPtr = new IntPtr();
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            retStringIntPtr(out pIntPtr);
            stopwatch.Stop();
            TimeSpan timespan = stopwatch.Elapsed;
            double milliseconds = timespan.TotalMilliseconds;

            string retString;
            retString = Marshal.PtrToStringAnsi(pIntPtr);
            Marshal.FreeCoTaskMem(pIntPtr);

            return retString;
        }

        [DllImport("CPPDll.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void retString(ref StringBuilder strRet);

        [DllImport("CPPDll.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int retInt();

        [DllImport("CPPDll.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void retStringIntPtr(out IntPtr strRet);
    }
}
