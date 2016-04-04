namespace Csharp_Warehouse_System
{
    partial class Form1
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
            this.L_Account = new System.Windows.Forms.Label();
            this.L_Password = new System.Windows.Forms.Label();
            this.L_Info = new System.Windows.Forms.Label();
            this.T_Account = new System.Windows.Forms.TextBox();
            this.T_Password = new System.Windows.Forms.TextBox();
            this.B_Login = new System.Windows.Forms.Button();
            this.B_Get_Info = new System.Windows.Forms.Button();
            this.B_Modify = new System.Windows.Forms.Button();
            this.B_Deduct = new System.Windows.Forms.Button();
            this.B_Add = new System.Windows.Forms.Button();
            this.B_Staff = new System.Windows.Forms.Button();
            this.B_Sum = new System.Windows.Forms.Button();
            this.B_Logout = new System.Windows.Forms.Button();
            this.L_M_Name = new System.Windows.Forms.Label();
            this.L_M_Number = new System.Windows.Forms.Label();
            this.L_M_Price = new System.Windows.Forms.Label();
            this.T_M_Number = new System.Windows.Forms.TextBox();
            this.T_M_Price = new System.Windows.Forms.TextBox();
            this.T_M_Name = new System.Windows.Forms.TextBox();
            this.B_Done = new System.Windows.Forms.Button();
            this.T_M_Name1 = new System.Windows.Forms.TextBox();
            this.T_M_Price1 = new System.Windows.Forms.TextBox();
            this.T_M_Number1 = new System.Windows.Forms.TextBox();
            this.B_Find = new System.Windows.Forms.Button();
            this.T_M_ID1 = new System.Windows.Forms.TextBox();
            this.T_M_ID = new System.Windows.Forms.TextBox();
            this.L_M_ID = new System.Windows.Forms.Label();
            this.L_List = new System.Windows.Forms.Label();
            this.B_Add_P = new System.Windows.Forms.Button();
            this.B_Del_P = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_Account
            // 
            this.L_Account.AutoSize = true;
            this.L_Account.Location = new System.Drawing.Point(161, 165);
            this.L_Account.Name = "L_Account";
            this.L_Account.Size = new System.Drawing.Size(33, 12);
            this.L_Account.TabIndex = 0;
            this.L_Account.Text = "label1";
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.Location = new System.Drawing.Point(161, 206);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(33, 12);
            this.L_Password.TabIndex = 1;
            this.L_Password.Text = "label2";
            // 
            // L_Info
            // 
            this.L_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Info.AutoSize = true;
            this.L_Info.Location = new System.Drawing.Point(229, 310);
            this.L_Info.Name = "L_Info";
            this.L_Info.Size = new System.Drawing.Size(33, 12);
            this.L_Info.TabIndex = 2;
            this.L_Info.Text = "label3";
            this.L_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_Account
            // 
            this.T_Account.Location = new System.Drawing.Point(231, 162);
            this.T_Account.Name = "T_Account";
            this.T_Account.Size = new System.Drawing.Size(100, 22);
            this.T_Account.TabIndex = 3;
            this.T_Account.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_Account_KeyPress);
            // 
            // T_Password
            // 
            this.T_Password.Location = new System.Drawing.Point(231, 203);
            this.T_Password.Name = "T_Password";
            this.T_Password.Size = new System.Drawing.Size(100, 22);
            this.T_Password.TabIndex = 4;
            this.T_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_Password_KeyPress);
            // 
            // B_Login
            // 
            this.B_Login.Location = new System.Drawing.Point(243, 259);
            this.B_Login.Name = "B_Login";
            this.B_Login.Size = new System.Drawing.Size(75, 23);
            this.B_Login.TabIndex = 5;
            this.B_Login.Text = "button1";
            this.B_Login.UseVisualStyleBackColor = true;
            this.B_Login.Click += new System.EventHandler(this.B_Login_Click);
            // 
            // B_Get_Info
            // 
            this.B_Get_Info.Location = new System.Drawing.Point(436, 186);
            this.B_Get_Info.Name = "B_Get_Info";
            this.B_Get_Info.Size = new System.Drawing.Size(75, 23);
            this.B_Get_Info.TabIndex = 6;
            this.B_Get_Info.Text = "button1";
            this.B_Get_Info.UseVisualStyleBackColor = true;
            this.B_Get_Info.Click += new System.EventHandler(this.B_Get_Info_Click);
            // 
            // B_Modify
            // 
            this.B_Modify.Location = new System.Drawing.Point(436, 136);
            this.B_Modify.Name = "B_Modify";
            this.B_Modify.Size = new System.Drawing.Size(75, 23);
            this.B_Modify.TabIndex = 7;
            this.B_Modify.Text = "button1";
            this.B_Modify.UseVisualStyleBackColor = true;
            this.B_Modify.Click += new System.EventHandler(this.B_Modify_Click);
            // 
            // B_Deduct
            // 
            this.B_Deduct.Location = new System.Drawing.Point(436, 84);
            this.B_Deduct.Name = "B_Deduct";
            this.B_Deduct.Size = new System.Drawing.Size(75, 23);
            this.B_Deduct.TabIndex = 8;
            this.B_Deduct.Text = "button1";
            this.B_Deduct.UseVisualStyleBackColor = true;
            this.B_Deduct.Click += new System.EventHandler(this.B_Deduct_Click);
            // 
            // B_Add
            // 
            this.B_Add.Location = new System.Drawing.Point(436, 37);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(75, 23);
            this.B_Add.TabIndex = 9;
            this.B_Add.Text = "button1";
            this.B_Add.UseVisualStyleBackColor = true;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // B_Staff
            // 
            this.B_Staff.Location = new System.Drawing.Point(338, 37);
            this.B_Staff.Name = "B_Staff";
            this.B_Staff.Size = new System.Drawing.Size(75, 23);
            this.B_Staff.TabIndex = 10;
            this.B_Staff.Text = "button1";
            this.B_Staff.UseVisualStyleBackColor = true;
            this.B_Staff.Click += new System.EventHandler(this.B_Staff_Click);
            // 
            // B_Sum
            // 
            this.B_Sum.Location = new System.Drawing.Point(338, 186);
            this.B_Sum.Name = "B_Sum";
            this.B_Sum.Size = new System.Drawing.Size(75, 23);
            this.B_Sum.TabIndex = 11;
            this.B_Sum.Text = "button1";
            this.B_Sum.UseVisualStyleBackColor = true;
            this.B_Sum.Click += new System.EventHandler(this.B_Sum_Click);
            // 
            // B_Logout
            // 
            this.B_Logout.Location = new System.Drawing.Point(436, 299);
            this.B_Logout.Name = "B_Logout";
            this.B_Logout.Size = new System.Drawing.Size(75, 23);
            this.B_Logout.TabIndex = 12;
            this.B_Logout.Text = "button1";
            this.B_Logout.UseVisualStyleBackColor = true;
            this.B_Logout.Click += new System.EventHandler(this.B_Logout_Click);
            // 
            // L_M_Name
            // 
            this.L_M_Name.AutoSize = true;
            this.L_M_Name.Location = new System.Drawing.Point(25, 104);
            this.L_M_Name.Name = "L_M_Name";
            this.L_M_Name.Size = new System.Drawing.Size(33, 12);
            this.L_M_Name.TabIndex = 13;
            this.L_M_Name.Text = "label1";
            // 
            // L_M_Number
            // 
            this.L_M_Number.AutoSize = true;
            this.L_M_Number.Location = new System.Drawing.Point(25, 158);
            this.L_M_Number.Name = "L_M_Number";
            this.L_M_Number.Size = new System.Drawing.Size(33, 12);
            this.L_M_Number.TabIndex = 14;
            this.L_M_Number.Text = "label1";
            // 
            // L_M_Price
            // 
            this.L_M_Price.AutoSize = true;
            this.L_M_Price.Location = new System.Drawing.Point(25, 209);
            this.L_M_Price.Name = "L_M_Price";
            this.L_M_Price.Size = new System.Drawing.Size(33, 12);
            this.L_M_Price.TabIndex = 15;
            this.L_M_Price.Text = "label1";
            // 
            // T_M_Number
            // 
            this.T_M_Number.Location = new System.Drawing.Point(85, 155);
            this.T_M_Number.Name = "T_M_Number";
            this.T_M_Number.Size = new System.Drawing.Size(100, 22);
            this.T_M_Number.TabIndex = 16;
            // 
            // T_M_Price
            // 
            this.T_M_Price.Location = new System.Drawing.Point(85, 206);
            this.T_M_Price.Name = "T_M_Price";
            this.T_M_Price.Size = new System.Drawing.Size(100, 22);
            this.T_M_Price.TabIndex = 17;
            // 
            // T_M_Name
            // 
            this.T_M_Name.Location = new System.Drawing.Point(85, 101);
            this.T_M_Name.Name = "T_M_Name";
            this.T_M_Name.Size = new System.Drawing.Size(100, 22);
            this.T_M_Name.TabIndex = 18;
            // 
            // B_Done
            // 
            this.B_Done.Location = new System.Drawing.Point(243, 259);
            this.B_Done.Name = "B_Done";
            this.B_Done.Size = new System.Drawing.Size(75, 23);
            this.B_Done.TabIndex = 19;
            this.B_Done.Text = "button1";
            this.B_Done.UseVisualStyleBackColor = true;
            this.B_Done.Click += new System.EventHandler(this.B_Done_Click);
            // 
            // T_M_Name1
            // 
            this.T_M_Name1.Location = new System.Drawing.Point(218, 101);
            this.T_M_Name1.Name = "T_M_Name1";
            this.T_M_Name1.Size = new System.Drawing.Size(100, 22);
            this.T_M_Name1.TabIndex = 22;
            // 
            // T_M_Price1
            // 
            this.T_M_Price1.Location = new System.Drawing.Point(218, 206);
            this.T_M_Price1.Name = "T_M_Price1";
            this.T_M_Price1.Size = new System.Drawing.Size(100, 22);
            this.T_M_Price1.TabIndex = 21;
            // 
            // T_M_Number1
            // 
            this.T_M_Number1.Location = new System.Drawing.Point(218, 155);
            this.T_M_Number1.Name = "T_M_Number1";
            this.T_M_Number1.Size = new System.Drawing.Size(100, 22);
            this.T_M_Number1.TabIndex = 20;
            // 
            // B_Find
            // 
            this.B_Find.Location = new System.Drawing.Point(110, 259);
            this.B_Find.Name = "B_Find";
            this.B_Find.Size = new System.Drawing.Size(75, 23);
            this.B_Find.TabIndex = 23;
            this.B_Find.Text = "button1";
            this.B_Find.UseVisualStyleBackColor = true;
            this.B_Find.Click += new System.EventHandler(this.B_Find_Click);
            // 
            // T_M_ID1
            // 
            this.T_M_ID1.Location = new System.Drawing.Point(218, 51);
            this.T_M_ID1.Name = "T_M_ID1";
            this.T_M_ID1.Size = new System.Drawing.Size(100, 22);
            this.T_M_ID1.TabIndex = 26;
            // 
            // T_M_ID
            // 
            this.T_M_ID.Location = new System.Drawing.Point(85, 51);
            this.T_M_ID.Name = "T_M_ID";
            this.T_M_ID.Size = new System.Drawing.Size(100, 22);
            this.T_M_ID.TabIndex = 25;
            // 
            // L_M_ID
            // 
            this.L_M_ID.AutoSize = true;
            this.L_M_ID.Location = new System.Drawing.Point(25, 54);
            this.L_M_ID.Name = "L_M_ID";
            this.L_M_ID.Size = new System.Drawing.Size(33, 12);
            this.L_M_ID.TabIndex = 24;
            this.L_M_ID.Text = "label1";
            // 
            // L_List
            // 
            this.L_List.AutoSize = true;
            this.L_List.Location = new System.Drawing.Point(25, 54);
            this.L_List.Name = "L_List";
            this.L_List.Size = new System.Drawing.Size(33, 12);
            this.L_List.TabIndex = 27;
            this.L_List.Text = "label1";
            // 
            // B_Add_P
            // 
            this.B_Add_P.Location = new System.Drawing.Point(338, 84);
            this.B_Add_P.Name = "B_Add_P";
            this.B_Add_P.Size = new System.Drawing.Size(75, 23);
            this.B_Add_P.TabIndex = 28;
            this.B_Add_P.Text = "button1";
            this.B_Add_P.UseVisualStyleBackColor = true;
            this.B_Add_P.Click += new System.EventHandler(this.B_Add_P_Click);
            // 
            // B_Del_P
            // 
            this.B_Del_P.Location = new System.Drawing.Point(338, 136);
            this.B_Del_P.Name = "B_Del_P";
            this.B_Del_P.Size = new System.Drawing.Size(75, 23);
            this.B_Del_P.TabIndex = 29;
            this.B_Del_P.Text = "button1";
            this.B_Del_P.UseVisualStyleBackColor = true;
            this.B_Del_P.Click += new System.EventHandler(this.B_Del_P_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 356);
            this.Controls.Add(this.B_Del_P);
            this.Controls.Add(this.B_Add_P);
            this.Controls.Add(this.L_List);
            this.Controls.Add(this.T_M_ID1);
            this.Controls.Add(this.T_M_ID);
            this.Controls.Add(this.L_M_ID);
            this.Controls.Add(this.B_Find);
            this.Controls.Add(this.T_M_Name1);
            this.Controls.Add(this.T_M_Price1);
            this.Controls.Add(this.T_M_Number1);
            this.Controls.Add(this.B_Done);
            this.Controls.Add(this.T_M_Name);
            this.Controls.Add(this.T_M_Price);
            this.Controls.Add(this.T_M_Number);
            this.Controls.Add(this.L_M_Price);
            this.Controls.Add(this.L_M_Number);
            this.Controls.Add(this.L_M_Name);
            this.Controls.Add(this.B_Logout);
            this.Controls.Add(this.B_Sum);
            this.Controls.Add(this.B_Staff);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.B_Deduct);
            this.Controls.Add(this.B_Modify);
            this.Controls.Add(this.B_Get_Info);
            this.Controls.Add(this.B_Login);
            this.Controls.Add(this.T_Password);
            this.Controls.Add(this.T_Account);
            this.Controls.Add(this.L_Info);
            this.Controls.Add(this.L_Password);
            this.Controls.Add(this.L_Account);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Account;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.Label L_Info;
        private System.Windows.Forms.TextBox T_Account;
        private System.Windows.Forms.TextBox T_Password;
        private System.Windows.Forms.Button B_Login;
        private System.Windows.Forms.Button B_Get_Info;
        private System.Windows.Forms.Button B_Modify;
        private System.Windows.Forms.Button B_Deduct;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.Button B_Staff;
        private System.Windows.Forms.Button B_Sum;
        private System.Windows.Forms.Button B_Logout;
        private System.Windows.Forms.Label L_M_Name;
        private System.Windows.Forms.Label L_M_Number;
        private System.Windows.Forms.Label L_M_Price;
        private System.Windows.Forms.TextBox T_M_Number;
        private System.Windows.Forms.TextBox T_M_Price;
        private System.Windows.Forms.TextBox T_M_Name;
        private System.Windows.Forms.Button B_Done;
        private System.Windows.Forms.TextBox T_M_Name1;
        private System.Windows.Forms.TextBox T_M_Price1;
        private System.Windows.Forms.TextBox T_M_Number1;
        private System.Windows.Forms.Button B_Find;
        private System.Windows.Forms.TextBox T_M_ID1;
        private System.Windows.Forms.TextBox T_M_ID;
        private System.Windows.Forms.Label L_M_ID;
        private System.Windows.Forms.Label L_List;
        private System.Windows.Forms.Button B_Add_P;
        private System.Windows.Forms.Button B_Del_P;
    }
}

