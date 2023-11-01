using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Sistema_Gerenciamento
{
    public partial class Menu_CRUD : Form
    {
        public Menu_CRUD()
        {
            InitializeComponent();
        }

        private void mn_Cadastration_User_Click(object sender, EventArgs e)
        {
            Insert_CRUD tela_Insert = new Insert_CRUD();
            tela_Insert.Show();
            this.Visible = false;
        }

        private void mn_Consultation_User_Click(object sender, EventArgs e)
        {
            Select_CRUD tela_Select = new Select_CRUD();
            tela_Select.Show();
            this.Visible = false;
        }

        private void mn_Edition_Update_Click(object sender, EventArgs e)
        {
            Update_CRUD tela_Update = new Update_CRUD();
            tela_Update.Show();
            this.Visible = false;
        }

        private void mn_Edition_Delete_Click(object sender, EventArgs e)
        {
            Delete_CRUD tela_Delete = new Delete_CRUD();
            tela_Delete.Show();
            this.Visible = false;
        }

        private void Menu_CRUD_Load(object sender, EventArgs e)
        {

        }
    }
}
