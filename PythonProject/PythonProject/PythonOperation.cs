using System;
using Python.Runtime;
namespace PythonProject
{
    public class PythonOperation
    {
        PyModule scope;
        public PythonOperation()
        {
            //Runtime.PythonDLL= @"libpython3.10.dylib";
        }

        public void Initialize()
        {
            PythonEngine.Initialize();
            scope = Py.CreateScope();
        }

        public void Execute()
        {
            using (Py.GIL())
            {
                scope.Exec("print('hello world')");
            }
        }
    }
}

