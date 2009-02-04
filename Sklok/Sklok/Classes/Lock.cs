using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;


namespace Sklok.Classes {

    public class MyLock {

        public int DesktopHandle;  //hold the desktop handle
        public int DesktopInputID; //hold desktop input id
        public int DesktopThreadID; //hold desktop threadid
        public static string NewDesktopString = "Sklocked!"; //name of the newly created desktop
        public FileStream TaskManagerController; //filestream object to control taskmanager


        public string FastSwitching = string.Empty; // Hold the original value of fast switching
        public string ShutdownWithoutLogin = string.Empty;  // Hold the original value of showing the shutdown button on welcome screen


        /// <summary>
        /// Enabled used to enable or disable the locker
        /// </summary>
        public bool Enabled {
            set {
                SetProcessPriorityHigh();                       // Set the process priority to high.

                if (value)                                      // Enable or disable the locker?
                    {
                    CreateNewDesktop();                         // Creating new desktop.
                    StartProcess(Application.ExecutablePath);   // Starting the locker form, to allow the user to enter login info.
                }
                else {
                    DestroyDesktop();                           // Destroy the desktop.
                    BlockWindowsSecurity(false);                // Restore registry values.
                    ExitProcess(0);                             // Exit the current process, if desktop attached with no process, default desktop will be activated.
                }
            }
        }

        private void CreateNewDesktop() {
            //save the orignal desktop
            this.DesktopThreadID = Win32.GetThreadDesktop(Win32.GetCurrentThreadId());
            //start switching the desktop
            this.DesktopInputID = Win32.OpenInputDesktop(0, false, Win32.DESKTOP_SWITCHDESKTOP);
            //create the new desktop
            this.DesktopHandle = Win32.CreateDesktop(NewDesktopString, "", 0, 0, Win32.GENERIC_ALL, 0);

            if (this.DesktopHandle != 0) {
                //desktop successfully created
                Win32.SetThreadDesktop(this.DesktopHandle);
                Win32.SwitchDesktop(this.DesktopHandle);
                //TODO: log message               
            }
            else {
                //TODO: create custom exception
                throw new ApplicationException("Unable to create desktop");                
            }
        }
        /// <summary>
        /// StartProcess used to start a specified process, on a specified desktop, this function is diff.               than shell execute, cause shell execute don't allow us to specify what desktop used. I think :)
        /// </summary>
        /// <param name="Path">Is the path of file to be started.</param>
        private void StartProcess(string path) {
            Win32.PROCESS_INFORMATION pi = new Win32.PROCESS_INFORMATION();
            Win32.STARTUPINFO si = new Win32.STARTUPINFO();
            bool result; 
            si.cb = Marshal.SizeOf(si);
            si.lpDesktop = NewDesktopString;

            result = Win32.CreateProcess(null, path, IntPtr.Zero, IntPtr.Zero, true, Win32.                                                           NORMAL_PRIORITY_CLASS, IntPtr.Zero, null, ref si, ref pi);

            if (result) {
                Win32.WaitForSingleObject(pi.hProcess, Win32.INFINITE);
                //The WaitForSingleObject is a blocking method therefore allowing processes to be spawned on the new desktop
                Win32.CloseHandle(pi.hProcess);
                Win32.CloseHandle(pi.hThread);
            }
            else {
                //unable to spawn processes on new desktop making it unusable. 
                //so destroy it to free memory.
                this.DestroyDesktop(); 
            }

            

            

        }

        /// <summary>
        /// DestroyDesktop used to Destroy created desktop, this function usually not used, because created desktop will terminated automatically 
        /// when we terminate any processs attached to it
        /// </summary>
        public void DestroyDesktop() {
            try {
                if (DesktopInputID != 0) { Win32.SwitchDesktop(DesktopInputID); DesktopInputID = 0; }
                if (DesktopThreadID != 0) { Win32.SetThreadDesktop(DesktopThreadID); DesktopThreadID = 0; }
                if (DesktopHandle != 0) { Win32.CloseDesktop(DesktopHandle); DesktopHandle = 0; }
            }
            catch { }
        }


        /// <summary>
        /// SetProcessPriorityHigh, used to set the priority to high, to make it start faster.
        /// </summary>
        private void SetProcessPriorityHigh() {
            Win32.SetThreadPriority(Win32.GetCurrentThread(), Win32.THREAD_BASE_PRIORITY_MAX);
            Win32.SetPriorityClass(Win32.GetCurrentProcess(), Win32.REALTIME_PRIORITY_CLASS);
        }


        ///// <summary>
        ///// TaskManager used to enable or disable the task manager, some people will wonder what is the use of it, we create new desktop, which
        ///// dosn't contain hotkeys or task manager, so why we use it? the answer is when you press Ctrl + Alt + Del in new created desktop, the 
        ///// task manager will appear in default task manager, so after the locker closed you will find the task manager, so I cancel it from
        ///// registery for maximum security and also open the file for binary and lock read, write to disable msgbox telling me that task manager
        ///// stopped by admin.
        ///// </summary>
        ///// <param name="Enabled">Bool value specify if taskmanager enabled or disabled.</param>
        //static void TaskManager(bool Enabled) {
        //    if (GetWinVersion()[0] == "WinNT") {
        //        RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
        //        RegKey.SetValue("DisableTaskMgr", !Enabled, RegistryValueKind.DWord); RegKey.Close();
        //        if (GetWinVersion()[1] == "Win2000") {
        //            RegKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Group Policy Objects\LocalUser\Software\Microsoft\Windows\CurrentVersion\Policies\System");
        //            RegKey.SetValue("DisableTaskMgr", !Enabled, RegistryValueKind.DWord); RegKey.Close();
        //        }
        //        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //        if (!Enabled) {
        //            for (int I = 0; I < Process.GetProcesses().Length; I++) {
        //                if (Process.GetProcesses()[I].ProcessName.ToLower() == "Taskmgr".ToLower()) Process.GetProcesses()[I].Kill();
        //                if (Process.GetProcesses()[I].MainWindowTitle.ToLower() == "Windowis Task Manager".ToLower()) Process.GetProcesses()[I].Kill();
        //            }
        //            TaskMan = File.Open(Environment.SystemDirectory + @"\Taskmgr.exe", FileMode.Open, FileAccess.Read, FileShare.None);
        //        }
        //        else if (TaskMan != null) TaskMan.Close();
        //    }
        //    else SystemParametersInfo(97, Enabled, Enabled, 0);
        //}


    }

}
