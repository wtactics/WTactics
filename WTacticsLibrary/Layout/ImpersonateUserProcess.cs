﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTacticsLibrary.Layout
{
    public class ImpersonateUserProcess
    {
        public static void Impersonate(Process process)
        {
#if !DEBUG
            string username = "";
            string password = "";
            System.Security.SecureString ssPwd = new System.Security.SecureString();
            process.StartInfo.UserName = username;
            for (int x = 0; x < password.Length; x++)
            {
                ssPwd.AppendChar(password[x]);
            }
            process.StartInfo.Password = ssPwd;
#endif
        }
    }
}
