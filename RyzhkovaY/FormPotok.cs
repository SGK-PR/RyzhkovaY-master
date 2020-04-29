using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RyzhkovaY
{
    public partial class FormPotok : Form
    {
        private Worker _worker;
        private SynchronizationContext _context;

        public FormPotok()
        {
            InitializeComponent();
            butStart.Click += butStart_Click;
            butStop.Click += butStop_Click;
            Load += FormPotok_Load;
        }

        private void FormPotok_Load(object sender, EventArgs e)
        {
            _context = SynchronizationContext.Current;
        }
        private void butStop_Click(object sender, EventArgs e)
        {
            if (_worker != null)
                _worker.Cansel();

        }

        private void butStart_Click(object sender, EventArgs e)
        {
            _worker = new Worker();
            _worker.ProcessChanged += worker_ProcessChanged;
            _worker.WorkCompleted += _worker_WorkCompleted;

            butStart.Enabled = false;

            Thread thread = new Thread(_worker.Work);
            thread.Start(_context);
        }
        private void _worker_WorkCompleted(bool cancelled)
        {
            
                 string message = cancelled ? "Процесс отменен" : "Процесс завершен";
                 MessageBox.Show(message);
                 butStart.Enabled = true;
            
        }

        private void worker_ProcessChanged(int progress)
        {
          
              progressBar1.Value = progress + 1;
              progressBar1.Value = progress;
       
        }
    }
}
