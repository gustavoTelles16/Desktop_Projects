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
    public partial class Insert_CRUD : Form
    {
        public Insert_CRUD()
        {
            InitializeComponent();
        }

        private void Insert_CRUD_Load(object sender, EventArgs e)
        {

        }

        private void btn_Insert_User_Click(object sender, EventArgs e)
        {
            DialogResult messageBox = MessageBox.Show("Deseja realmente cadastrar esse usuário?", "Sistema de Gerenciamento - Protótipo", MessageBoxButtons.YesNo);

            if (txt_Name_User.Text == "" && txt_Age_User.Text == "" && txt_Adress_User.Text == "" && txt_Phone_User.Text == "" && txt_Email_User.Text == "")
            {
                MessageBox.Show("Você deve preeencher todos os campos para finalizar o cadastro!");
            }
            else if (messageBox == DialogResult.Yes)
            {
                MySqlConnection MySql = new MySqlConnection("server=localhost;database=db_CRUD_Prototype;uid=root;pwd=etec");
                MySql.Open();

                MySqlCommand comand = new MySqlCommand("insert into tb_User(name_User, age_User, adress_User, phone_User, email_User)values('" + txt_Name_User.Text + "'," + txt_Age_User.Text + ", '" + txt_Adress_User.Text + "', '" + txt_Phone_User.Text + "', '" + txt_Email_User.Text + "');", MySql);
                comand.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado no sucesso!");
                txt_Name_User.Text = "";
                txt_Age_User.Text = "";
                txt_Adress_User.Text = "";
                txt_Phone_User.Text = "";
                txt_Email_User.Text = "";        
            }
         }

        private void btn_BackScreen_Click(object sender, EventArgs e)
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
    }
}
