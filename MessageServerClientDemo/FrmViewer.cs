using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageServerClientDemo
{
    public partial class FrmViewer : Form
    {
        public FrmViewer(string url)
        {
            InitializeComponent();
            chromiumWebBrowser1.Load(url);
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {
            if (e.IsLoading)
            {
                this.BeginInvoke(new Action(() =>
                {
                    this.Cursor = Cursors.WaitCursor;
                }));
            }
            else
            {
                this.BeginInvoke(new Action(() =>
                {
                    this.Cursor = Cursors.WaitCursor;
                }));
            }
        }
    }
}
