using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BokarevChistyakovPr6PART2
{
    public partial class FormDirector : Form
    {
        public FormDirector()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelRole_Click(object sender, EventArgs e)
        {

        }

        private void labelNames_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormDirector_Load(object sender, EventArgs e)
        {
            ModelEF model = new ModelEF();
            labelNames.Text = FormAutorization.Enter_User.First_Name + " " + FormAutorization.Enter_User.Second_Name;
            labelRole.Text = model.Roles.First(x => x.ID == FormAutorization.Enter_User.RoleID).Name;
            pictureBox1.Image = Image.FromFile(@"Photo\" + FormAutorization.Enter_User.Pictures);
        }
    }
}
