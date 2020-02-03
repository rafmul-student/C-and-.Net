using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
namespace lab_3
{
    class DisposeObject : IDisposable
    {
        private bool disposed = false;              
        private IntPtr handle;                         
        private Component component = new Component();
        public extern static bool CloseHandle(IntPtr handle);
        public DisposeObject(IntPtr _handle)
        {
            this.handle = _handle;
        }
        ~DisposeObject()         
        {
            Dispose(false);
        }
        public void Dispose()  
        {
            Dispose(true);
            GC.SuppressFinalize(this); 
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)    
            {
                if (disposing)
                {
                    component.Dispose(); 
                }
                Marshal.FreeHGlobal(handle); 
                handle = IntPtr.Zero;
            }
            disposed = true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            IntPtr p = Marshal.AllocHGlobal(sizeof(int));
            Marshal.WriteInt32(p, n);
            int n1 = Marshal.ReadInt32(p);
            Console.WriteLine("n = {0}\nn1 = {1}", n, n1);
            DisposeObject dispose = new DisposeObject(p);
            dispose.Dispose();
        }
    }
}
