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
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }
        public static Users Enter_User;

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Enter_User = null;
            ModelEF modelef = new ModelEF();
            // поиск пользователя по логину и паролю 
            Enter_User = modelef.Users.FirstOrDefault(x =>x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
            if (Enter_User != null)
            {
                switch (Enter_User.RoleID) //переход по формам в зависимости от роли
                {
                    case 1:
                        FormManager formManager = new FormManager();
                        formManager.ShowDialog();
                        break;
                    case 2: 
                        FormSeller formSeller = new FormSeller();
                        formSeller.ShowDialog();
                        break;
                    case 3:
                        FormDirector formDirector = new FormDirector();
                        formDirector.ShowDialog();
                        break;
                    default: throw new Exception("Роль не найдена");
                }
            }
        }
    }
}
