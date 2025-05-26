using System;
using System.Windows.Forms;

namespace gacc
{
    public static class Authorization
    {
        // уровень доступа
        private static int access = 0;
        private static string userName = "";
        private static string userLogin = "";
        public static int Access
        {
            get { return access; }
            set { access = value; }
        }
        public static string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public static string UserLogin
        {
            get { return userLogin; }
            set { userLogin = value; }
        }

        // авторизация
        public static bool Authorize()
        {

            DialogLogin loginForm = new DialogLogin();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                string login = loginForm.txtLogin.Text;
                string password = loginForm.txtPassword.Text;
                DBImage.udt = DBImage.uta.GetData();
                if (DBImage.udt.Rows.Count > 0)
                {
                    for (int i = 0; i < DBImage.udt.Rows.Count; i++)
                    {
                        if (DBImage.udt.Rows[i].ItemArray[2].ToString() == login &&
                            DBImage.udt.Rows[i].ItemArray[3].ToString() == password)
                        {
                            userLogin = login;
                            userName = DBImage.udt.Rows[i].ItemArray[1].ToString();
                            access = Convert.ToInt32(DBImage.udt.Rows[i].ItemArray[4]);
                            // авторизация успешна
                            DBImage.udt.Dispose();
                            return true;
                        }
                    }
                }
            }
            // авторизация не удалась
            return false;
        }
    }
}