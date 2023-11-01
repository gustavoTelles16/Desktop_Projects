using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prototipo_Sistema_Gerenciamento
{
    public partial class Select_CRUD : Form
    {
        public Select_CRUD()
        {
            InitializeComponent();
        }

        private void Select_CRUD_Load(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=db_CRUD_Prototype;uid=root;pwd=etec";
            MySqlConnection conexaoMySql = new MySqlConnection(conexao);
            conexaoMySql.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select id_User as Codigo, name_User as Nome, age_User as Idade, adress_User as Endereco, phone_User as Telefone, email_User as Email from tb_User; ", conexaoMySql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgv_Consultation_User.DataSource = dt;
        }

        private void btn_Back_Screen_Click(object sender, EventArgs e)
        {
            Menu_CRUD tela_Menu = new Menu_CRUD();
            tela_Menu.Show();
            this.Visible = false;
        }
    }
}
