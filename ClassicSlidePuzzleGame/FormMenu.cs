using System;
using System.Windows.Forms;

namespace ClassicSlidePuzzleGame
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void ButtonEasy_Click(object sender, EventArgs e)
        {
            FormEasy f = new FormEasy();
            f.Show();
        }

        private void ButtonMedium_Click(object sender, EventArgs e)
        {
            FormMedium f = new FormMedium();
            f.Show();
        }

        private void ButtonHard_Click(object sender, EventArgs e)
        {
            FormHard f = new FormHard();
            f.Show();
        }
    }
}