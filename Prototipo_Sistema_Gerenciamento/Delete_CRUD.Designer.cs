
namespace Prototipo_Sistema_Gerenciamento
{
    partial class Delete_CRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Back_Screen = new System.Windows.Forms.Button();
            this.dgv_Consultation_User = new System.Windows.Forms.DataGridView();
            this.btn_Delete_User = new System.Windows.Forms.Button();
            this.lbl_Title_Delete = new System.Windows.Forms.Label();
            this.lbl_Delete_Id = new System.Windows.Forms.Label();
            this.lbl_Delete_Name = new System.Windows.Forms.Label();
            this.lbl_Delete_Adress = new System.Windows.Forms.Label();
            this.lbl_Delete_Phone = new System.Windows.Forms.Label();
            this.lbl_Delete_Email = new System.Windows.Forms.Label();
            this.txt_Delete_Id = new System.Windows.Forms.TextBox();
            this.txt_Delete_Name = new System.Windows.Forms.TextBox();
            this.txt_Delete_Age = new System.Windows.Forms.TextBox();
            this.txt_Delete_Adress = new System.Windows.Forms.TextBox();
            this.txt_Delete_Phone = new System.Windows.Forms.TextBox();
            this.txt_Delete_Email = new System.Windows.Forms.TextBox();
            this.lbl_Delete_Age = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consultation_User)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back_Screen
            // 
            this.btn_Back_Screen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back_Screen.Location = new System.Drawing.Point(84, 410);
            this.btn_Back_Screen.Name = "btn_Back_Screen";
            this.btn_Back_Screen.Size = new System.Drawing.Size(97, 28);
            this.btn_Back_Screen.TabIndex = 0;
            this.btn_Back_Screen.Text = "VOLTAR";
            this.btn_Back_Screen.UseVisualStyleBackColor = true;
            this.btn_Back_Screen.Click += new System.EventHandler(this.btn_Back_Screen_Click);
            // 
            // dgv_Consultation_User
            // 
            this.dgv_Consultation_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Consultation_User.Location = new System.Drawing.Point(84, 41);
            this.dgv_Consultation_User.Name = "dgv_Consultation_User";
            this.dgv_Consultation_User.Size = new System.Drawing.Size(642, 157);
            this.dgv_Consultation_User.TabIndex = 1;
            this.dgv_Consultation_User.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Consultation_User_CellMouseDoubleClick);
            // 
            // btn_Delete_User
            // 
            this.btn_Delete_User.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_User.Location = new System.Drawing.Point(373, 412);
            this.btn_Delete_User.Name = "btn_Delete_User";
            this.btn_Delete_User.Size = new System.Drawing.Size(86, 26);
            this.btn_Delete_User.TabIndex = 2;
            this.btn_Delete_User.Text = "EXLUIR";
            this.btn_Delete_User.UseVisualStyleBackColor = true;
            this.btn_Delete_User.Click += new System.EventHandler(this.btn_Delete_User_Click);
            // 
            // lbl_Title_Delete
            // 
            this.lbl_Title_Delete.AutoSize = true;
            this.lbl_Title_Delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title_Delete.Location = new System.Drawing.Point(303, 9);
            this.lbl_Title_Delete.Name = "lbl_Title_Delete";
            this.lbl_Title_Delete.Size = new System.Drawing.Size(217, 19);
            this.lbl_Title_Delete.TabIndex = 3;
            this.lbl_Title_Delete.Text = "Excluir informações do Usuário";
            // 
            // lbl_Delete_Id
            // 
            this.lbl_Delete_Id.AutoSize = true;
            this.lbl_Delete_Id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete_Id.Location = new System.Drawing.Point(94, 216);
            this.lbl_Delete_Id.Name = "lbl_Delete_Id";
            this.lbl_Delete_Id.Size = new System.Drawing.Size(57, 19);
            this.lbl_Delete_Id.TabIndex = 4;
            this.lbl_Delete_Id.Text = "Código:";
            this.lbl_Delete_Id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Delete_Name
            // 
            this.lbl_Delete_Name.AutoSize = true;
            this.lbl_Delete_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete_Name.Location = new System.Drawing.Point(101, 248);
            this.lbl_Delete_Name.Name = "lbl_Delete_Name";
            this.lbl_Delete_Name.Size = new System.Drawing.Size(50, 19);
            this.lbl_Delete_Name.TabIndex = 5;
            this.lbl_Delete_Name.Text = "Nome:";
            this.lbl_Delete_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Delete_Adress
            // 
            this.lbl_Delete_Adress.AutoSize = true;
            this.lbl_Delete_Adress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete_Adress.Location = new System.Drawing.Point(81, 312);
            this.lbl_Delete_Adress.Name = "lbl_Delete_Adress";
            this.lbl_Delete_Adress.Size = new System.Drawing.Size(70, 19);
            this.lbl_Delete_Adress.TabIndex = 6;
            this.lbl_Delete_Adress.Text = "Endereço:";
            this.lbl_Delete_Adress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Delete_Adress.Click += new System.EventHandler(this.lbl_Delete_Adress_Click);
            // 
            // lbl_Delete_Phone
            // 
            this.lbl_Delete_Phone.AutoSize = true;
            this.lbl_Delete_Phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete_Phone.Location = new System.Drawing.Point(88, 344);
            this.lbl_Delete_Phone.Name = "lbl_Delete_Phone";
            this.lbl_Delete_Phone.Size = new System.Drawing.Size(63, 19);
            this.lbl_Delete_Phone.TabIndex = 7;
            this.lbl_Delete_Phone.Text = "Telefone:";
            this.lbl_Delete_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Delete_Email
            // 
            this.lbl_Delete_Email.AutoSize = true;
            this.lbl_Delete_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete_Email.Location = new System.Drawing.Point(100, 376);
            this.lbl_Delete_Email.Name = "lbl_Delete_Email";
            this.lbl_Delete_Email.Size = new System.Drawing.Size(51, 19);
            this.lbl_Delete_Email.TabIndex = 8;
            this.lbl_Delete_Email.Text = "E-mail:";
            this.lbl_Delete_Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Delete_Id
            // 
            this.txt_Delete_Id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Delete_Id.Location = new System.Drawing.Point(157, 213);
            this.txt_Delete_Id.Name = "txt_Delete_Id";
            this.txt_Delete_Id.Size = new System.Drawing.Size(569, 26);
            this.txt_Delete_Id.TabIndex = 9;
            // 
            // txt_Delete_Name
            // 
            this.txt_Delete_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Delete_Name.Location = new System.Drawing.Point(157, 245);
            this.txt_Delete_Name.Name = "txt_Delete_Name";
            this.txt_Delete_Name.Size = new System.Drawing.Size(569, 26);
            this.txt_Delete_Name.TabIndex = 10;
            // 
            // txt_Delete_Age
            // 
            this.txt_Delete_Age.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Delete_Age.Location = new System.Drawing.Point(157, 277);
            this.txt_Delete_Age.Name = "txt_Delete_Age";
            this.txt_Delete_Age.Size = new System.Drawing.Size(569, 26);
            this.txt_Delete_Age.TabIndex = 11;
            // 
            // txt_Delete_Adress
            // 
            this.txt_Delete_Adress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Delete_Adress.Location = new System.Drawing.Point(157, 309);
            this.txt_Delete_Adress.Name = "txt_Delete_Adress";
            this.txt_Delete_Adress.Size = new System.Drawing.Size(569, 26);
            this.txt_Delete_Adress.TabIndex = 12;
            // 
            // txt_Delete_Phone
            // 
            this.txt_Delete_Phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Delete_Phone.Location = new System.Drawing.Point(157, 341);
            this.txt_Delete_Phone.Name = "txt_Delete_Phone";
            this.txt_Delete_Phone.Size = new System.Drawing.Size(569, 26);
            this.txt_Delete_Phone.TabIndex = 13;
            // 
            // txt_Delete_Email
            // 
            this.txt_Delete_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Delete_Email.Location = new System.Drawing.Point(157, 373);
            this.txt_Delete_Email.Name = "txt_Delete_Email";
            this.txt_Delete_Email.Size = new System.Drawing.Size(569, 26);
            this.txt_Delete_Email.TabIndex = 14;
            // 
            // lbl_Delete_Age
            // 
            this.lbl_Delete_Age.AutoSize = true;
            this.lbl_Delete_Age.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete_Age.Location = new System.Drawing.Point(104, 280);
            this.lbl_Delete_Age.Name = "lbl_Delete_Age";
            this.lbl_Delete_Age.Size = new System.Drawing.Size(47, 19);
            this.lbl_Delete_Age.TabIndex = 15;
            this.lbl_Delete_Age.Text = "Idade:";
            this.lbl_Delete_Age.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(614, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "CONSULTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Delete_Age);
            this.Controls.Add(this.txt_Delete_Email);
            this.Controls.Add(this.txt_Delete_Phone);
            this.Controls.Add(this.txt_Delete_Adress);
            this.Controls.Add(this.txt_Delete_Age);
            this.Controls.Add(this.txt_Delete_Name);
            this.Controls.Add(this.txt_Delete_Id);
            this.Controls.Add(this.lbl_Delete_Email);
            this.Controls.Add(this.lbl_Delete_Phone);
            this.Controls.Add(this.lbl_Delete_Adress);
            this.Controls.Add(this.lbl_Delete_Name);
            this.Controls.Add(this.lbl_Delete_Id);
            this.Controls.Add(this.lbl_Title_Delete);
            this.Controls.Add(this.btn_Delete_User);
            this.Controls.Add(this.dgv_Consultation_User);
            this.Controls.Add(this.btn_Back_Screen);
            this.Name = "Delete_CRUD";
            this.Text = "Delete_CRUD";
            this.Load += new System.EventHandler(this.Delete_CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consultation_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back_Screen;
        private System.Windows.Forms.DataGridView dgv_Consultation_User;
        private System.Windows.Forms.Button btn_Delete_User;
        private System.Windows.Forms.Label lbl_Title_Delete;
        private System.Windows.Forms.Label lbl_Delete_Id;
        private System.Windows.Forms.Label lbl_Delete_Name;
        private System.Windows.Forms.Label lbl_Delete_Adress;
        private System.Windows.Forms.Label lbl_Delete_Phone;
        private System.Windows.Forms.Label lbl_Delete_Email;
        private System.Windows.Forms.TextBox txt_Delete_Id;
        private System.Windows.Forms.TextBox txt_Delete_Name;
        private System.Windows.Forms.TextBox txt_Delete_Age;
        private System.Windows.Forms.TextBox txt_Delete_Adress;
        private System.Windows.Forms.TextBox txt_Delete_Phone;
        private System.Windows.Forms.TextBox txt_Delete_Email;
        private System.Windows.Forms.Label lbl_Delete_Age;
        private System.Windows.Forms.Button button1;
    }
}