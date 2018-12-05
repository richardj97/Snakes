using System;
using System.Drawing;
using System.Windows.Forms;
using Snakes.Components;

namespace Snakes
{
    public partial class SettingsForm : Form
    {
        private bool hasSelected = false;
        private History HistoryForm;

        public SettingsForm()
        {
            InitializeComponent();

            HeightCmb.SelectedIndex = 7;
            WidthCmb.SelectedIndex = 7;
            SpeedCmb.SelectedIndex = 3;
            this.ActiveControl = UsernameTb;
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (HeightCmb.Text != string.Empty && SpeedCmb.Text != string.Empty && WidthCmb.Text != string.Empty
                && UsernameTb.Text != string.Empty)
            {
                if (radioButton1.Checked)
                {
                    Settings.BrushCol = Color.White;
                    Settings.BrushCol2 = Color.Firebrick;
                    Settings.BrushCol3 = Color.Firebrick;
                }
                else if (radioButton2.Checked)
                {
                    Settings.BrushCol = Color.White;
                    Settings.BrushCol2 = Color.White;
                    Settings.BrushCol3 = Color.White;
                }

                Settings.Width = Int32.Parse(WidthCmb.Text);
                Settings.Height = Int32.Parse(HeightCmb.Text);
                Settings.Speed = Int32.Parse(SpeedCmb.Text);
                Settings.Username = UsernameTb.Text;
                hasSelected = true;

                this.Hide();
                Game GameForm = new Game(this);
                GameForm.Show();
            }
        }
        private void HeightCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            WidthCmb.SelectedIndex = HeightCmb.SelectedIndex;
        }
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hasSelected)
            {
                this.Hide();
            }
            else { Application.Exit(); }
        }
        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            HistoryForm = new History();
            HistoryForm.ShowDialog();
        }
    }
}