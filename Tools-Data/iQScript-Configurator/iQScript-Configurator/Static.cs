using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace iQScript_Configurator
{
    internal static class Static
    {
        public static string Version => Assembly.GetExecutingAssembly().GetName().Version.ToString();
    }
}
