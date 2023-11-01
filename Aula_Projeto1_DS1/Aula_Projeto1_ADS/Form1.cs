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

namespace Aula_Projeto1_ADS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=aula1209;uid=root;pwd=etec";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            conexaoMYSQL.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from Aluno", conexaoMYSQL);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvAluno.DataSource = dt;
        }
    }
}
