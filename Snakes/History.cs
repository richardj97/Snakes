using System;
using System.IO;
using System.Windows.Forms;

namespace Snakes
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();

            using (var streamReader = File.OpenText(Application.StartupPath + "/History.txt"))
            {
                var lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var line in lines)
                {
                    HistoryLb.Items.Add(line);
                }
            }
        }
    }
}
