namespace Pr_1
{
    public partial class FromMain : Form
    {
        public FromMain()
        {
            InitializeComponent();
        }

        private void FromMain_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                labelUsers.Text = "Список пользователей:";

                foreach (User u in users)
                {
                    labelInAboutUsers.Text += ($"{u.Id}. {u.Name} - {u.Age}\n");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
