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
    public partial class Update_CRUD : Form
    {
        public Update_CRUD()
        {
            InitializeComponent();
        }

        private void btn_Back_Screen_Click(object sender, EventArgs e)
        {
            Menu_CRUD tela_Menu = new Menu_CRUD();
            tela_Menu.Show();
            this.Visible = false;
        }

        private void btn_Consultation_User_Click(object sender, EventArgs e)
        {
            Select_CRUD tela_Select = new Select_CRUD();
            tela_Select.Show();
            this.Visible = false;
        }

        private void Update_CRUD_Load(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=db_CRUD_Prototype;uid=root;pwd=etec";
            MySqlConnection conexaoMySql = new MySqlConnection(conexao);
            conexaoMySql.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select id_User as Codigo, name_User as Nome, age_User as Idade, adress_User as Endereco, phone_User as Telefone, email_User as Email from tb_User; ", conexaoMySql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgv_Consultation_User.DataSource = dt;
        }

        private void btn_Updade_User_Click(object sender, EventArgs e)
        {
            DialogResult messageBox = MessageBox.Show("Deseja realmente atualizar estas informações?", "Sistema de gerenciamento - Protótipo", MessageBoxButtons.YesNo);

            if (messageBox == DialogResult.Yes)
            {
                string connection = "server=localhost;database=db_CRUD_Prototype;uid=root;pwd=etec";
                MySqlConnection connectionMySql = new MySqlConnection(connection);
                connectionMySql.Open();

                MySqlCommand command = new MySqlCommand("update tb_User set name_User='" + txt_Update_Name.Text + "', age_User=" + txt_Update_Age.Text + ", adress_User='" + txt_Update_Adress.Text + "', phone_User='" + txt_Update_Phone.Text + "', email_User='" + txt_Update_Email.Text + "' where id_User=" + txt_Update_Id.Text, connectionMySql);
                command.ExecuteNonQuery();
                MessageBox.Show("Dados alterados com sucesso!");
                txt_Update_Name.Text = "";
                txt_Update_Age.Text = "";
                txt_Update_Adress.Text = "";
                txt_Update_Phone.Text = "";
                txt_Update_Email.Text = "";
            }
         }

        private void dgv_Consultation_User_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv_Consultation_User_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Update_Id.Text = dgv_Consultation_User.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Update_Name.Text = dgv_Consultation_User.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Update_Age.Text = dgv_Consultation_User.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Update_Adress.Text = dgv_Consultation_User.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Update_Phone.Text = dgv_Consultation_User.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Update_Email.Text = dgv_Consultation_User.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
