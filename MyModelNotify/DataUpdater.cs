using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading;

namespace MyModelNotify
{
    public class DataUpdater
    {
        private BackgroundWorker _backgroundWorker;
        private Foo _foo;

        public DataUpdater(Foo aFoo)
        {
            this._foo = aFoo;
            this._backgroundWorker = new BackgroundWorker();
            this._backgroundWorker.DoWork += new DoWorkEventHandler(doBackgroundWork);
        }

        private void doBackgroundWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(1000);
                _foo.Counter += 1;
            }
        }

        public void Run()
        {
            this._backgroundWorker.RunWorkerAsync();
        }
    }
}
