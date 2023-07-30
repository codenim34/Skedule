using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skedule_v3
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
           
           new Announcement().Show();
        }

        private void quizbutton_Click(object sender, EventArgs e)
        {

            this.Hide();

            new Quiz().Show();
        }

        private void Routine_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Routine().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Assignment().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SelfAssesment().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToString("T");
            labelDate.Text = DateTime.Now.ToString("dddd") + ", " + DateTime.Now.ToString("dd,MMMM,yyyy");
        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
