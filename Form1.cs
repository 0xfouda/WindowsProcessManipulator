using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace WindowsFormsApplication1
{

    public partial class MemRW : Form
    {

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess,
          int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress,
            char[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress,
            uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess,
            IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        // privileges
        const int PROCESS_CREATE_THREAD = 0x0002;
        const int PROCESS_QUERY_INFORMATION = 0x0400;
        const int PROCESS_VM_OPERATION = 0x0008;
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_READ = 0x0010;

        // used for memory allocation
        const uint MEM_COMMIT = 0x00001000;
        const uint MEM_RESERVE = 0x00002000;
        const uint PAGE_READWRITE = 4;
        const uint PAGE_READWRITEEXEC = 0x40;
        public MemRW()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbx_allprocs.SelectedItem != null)
            {
                Process process = Process.GetProcessesByName(lbx_allprocs.SelectedItem.ToString())[0];
                IntPtr processHandle = OpenProcess(PROCESS_VM_READ, false, process.Id);

                int bytesRead = (txtbx_len.Text == "") ? 5 : Convert.ToInt32(txtbx_len.Text);
                byte[] buffer = new byte[bytesRead * 2]; //'Hello World!' takes 12*2 bytes because of Unicode 
                int memadd = int.Parse(txtbx_memadd.Text, System.Globalization.NumberStyles.HexNumber);
                ReadProcessMemory((int)processHandle, memadd, buffer, buffer.Length, ref bytesRead);
                string hex = BitConverter.ToString(buffer);
                txtbx_hx.Text = hex.Replace('-', '\t');
                txtbx_ascii.Text = Encoding.ASCII.GetString(buffer);
                //MessageBox.Show(chars.ToString());
            }
            else
            {
                MessageBox.Show("Please Select a Process");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (lbx_allprocs.SelectedItem != null)
            {
            Process process = Process.GetProcessesByName(lbx_allprocs.SelectedItem.ToString())[0];
            IntPtr processHandle = OpenProcess(PROCESS_VM_READ | PROCESS_VM_OPERATION | PROCESS_VM_WRITE, false, process.Id);
            int bytesWrite = textBox1.Text.Length;
            char[] txt = textBox1.Text.ToString().ToCharArray();
            int memadd = int.Parse(txtbx_memadd.Text, System.Globalization.NumberStyles.HexNumber);

            WriteProcessMemory((int)processHandle, memadd, txt, txt.Length, ref bytesWrite);

            MessageBox.Show(textBox1.Text + " has been written to memory!");
            }
            else
            {
                MessageBox.Show("Please Select a Process");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Process proc in Process.GetProcesses())
            {
                lbx_allprocs.Items.Add(proc.ProcessName);
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog();
            txtbx_dllpath.Text = fbd.FileName;
        }

        private void btn_inject_Click(object sender, EventArgs e)
        {
            if (lbx_allprocs.SelectedItem != null)
            {
                if (txtbx_dllpath.Text.ToUpper().EndsWith("DLL"))
                {
                    Process process = Process.GetProcessesByName(lbx_allprocs.SelectedItem.ToString())[0];
                    IntPtr processHandle = OpenProcess(PROCESS_VM_READ | PROCESS_VM_WRITE | PROCESS_VM_OPERATION | PROCESS_QUERY_INFORMATION | PROCESS_CREATE_THREAD, false, process.Id);
                    IntPtr loadLibraryAddr = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");
                    IntPtr allocAddr = VirtualAllocEx(processHandle, IntPtr.Zero, (uint)((txtbx_dllpath.Text.Length + 1) * Marshal.SizeOf(typeof(char))), MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);
                    int bytesWritten = txtbx_dllpath.Text.Length;
                    WriteProcessMemory((int)processHandle, (int)allocAddr, txtbx_dllpath.Text.ToCharArray(), txtbx_dllpath.Text.Length, ref bytesWritten);
                    CreateRemoteThread(processHandle, IntPtr.Zero, 0, loadLibraryAddr, allocAddr, 0, IntPtr.Zero);

                }
                else
                {
                    MessageBox.Show("Please Select a valid DLL!");
                }
            }
            else
            {
                MessageBox.Show("Please Select a Process to Inject!");
            }
        }

        private void btn_injectshellcode_Click(object sender, EventArgs e)
        {
            if (lbx_allprocs.SelectedItem != null)
            {
                
                    if (txtbx_shellcode.Text.Length > 0)
                    {
                        char[] shellcode = Encoding.Default.GetChars(Convert.FromBase64String(txtbx_shellcode.Text));
                        MessageBox.Show(BitConverter.ToString(Encoding.Default.GetBytes(shellcode)));
                        //get process handle
                        Process process = Process.GetProcessesByName(lbx_allprocs.SelectedItem.ToString())[0];
                        IntPtr processHandle = OpenProcess(PROCESS_VM_READ | PROCESS_VM_WRITE | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_CREATE_THREAD, false, process.Id);
                        //Allocate Memory with RWX
                        IntPtr AllocatedSpaceAddr = VirtualAllocEx(processHandle, IntPtr.Zero, (uint)shellcode.Length, MEM_COMMIT | MEM_RESERVE, PAGE_READWRITEEXEC);
                        //Write Shellcode into Allocated Space
                        int bytesWritten = shellcode.Length;
                        WriteProcessMemory((int)processHandle,(int) AllocatedSpaceAddr, shellcode, shellcode.Length, ref bytesWritten);
                        //Execute Shellcode
                        IntPtr threadID = CreateRemoteThread(processHandle, IntPtr.Zero, 0, AllocatedSpaceAddr,IntPtr.Zero,0,IntPtr.Zero);
                        MessageBox.Show("Process " + process.ProcessName + " Injected, Thread " + threadID.ToString() + " Created !!");
                    }
                
                else
                {
                    MessageBox.Show("Please Select a valid DLL!");
                }
            }
            else
            {
                MessageBox.Show("Please Select a Process to Inject!");
            }
        }
    }
}
