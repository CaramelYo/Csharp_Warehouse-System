using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Warehouse_System
{
    public partial class Form1 : Form
    {
        int L_Number = 8, T_Number = 10, B_Number = 12;
        Label[] labels = new Label[8];
        TextBox[] textboxes = new TextBox[10];
        Button[] buttons = new Button[12];
        enum FormState { Null, Supervisor, Employee, Add, Deduct, Modify, GetInfo, NewP, DelP};

        public Form1()
        {
            InitializeComponent();

            ToolTip tooltip = new ToolTip();

            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 1000;
            tooltip.ReshowDelay = 500;
            tooltip.IsBalloon = true;

            tooltip.SetToolTip(L_Info, "顯示資訊");
            tooltip.SetToolTip(L_Account, "帳號");
            tooltip.SetToolTip(L_Password, "密碼");
            tooltip.SetToolTip(L_M_ID, "商品ID");
            tooltip.SetToolTip(L_M_Name, "商品名稱");
            tooltip.SetToolTip(L_M_Number, "商品數量");
            tooltip.SetToolTip(L_M_Price, "商品價格");
            tooltip.SetToolTip(L_List, "顯示清單資訊");

            tooltip.SetToolTip(T_Account, "請輸入帳號");
            tooltip.SetToolTip(T_Password, "請輸入密碼");
            tooltip.SetToolTip(T_M_ID, "請輸入商品ID(身份)");
            tooltip.SetToolTip(T_M_Name, "請輸入商品名稱(帳號)");
            tooltip.SetToolTip(T_M_Number, "請輸入數量(密碼)");
            tooltip.SetToolTip(T_M_Price, "請輸入價格");
            tooltip.SetToolTip(T_M_ID1, "請輸入新商品ID");
            tooltip.SetToolTip(T_M_Name1, "請輸入新商品名稱");
            tooltip.SetToolTip(T_M_Number1, "請輸入新數量");
            tooltip.SetToolTip(T_M_Price1, "請輸入新價格");

            tooltip.SetToolTip(B_Login, "按此登入");
            tooltip.SetToolTip(B_Add, "按此新增商品");
            tooltip.SetToolTip(B_Deduct, "按此扣除商品");
            tooltip.SetToolTip(B_Modify, "按此修改商品");
            tooltip.SetToolTip(B_Get_Info, "按此看商品資訊");
            tooltip.SetToolTip(B_Logout, "按此登出");
            tooltip.SetToolTip(B_Staff, "按此看全員工帳密");
            tooltip.SetToolTip(B_Add_P, "按此新增帳號");
            tooltip.SetToolTip(B_Del_P, "按此刪除帳密");
            tooltip.SetToolTip(B_Sum, "按此看全商品資訊");
            tooltip.SetToolTip(B_Find, "按此查訊");
            tooltip.SetToolTip(B_Done, "Done");


            labels[0] = L_Info;
            labels[1] = L_Account;
            labels[2] = L_Password;
            labels[3] = L_M_ID;
            labels[4] = L_M_Name;
            labels[5] = L_M_Number;
            labels[6] = L_M_Price;
            labels[7] = L_List;

            textboxes[0] = T_Account;
            textboxes[1] = T_Password;
            textboxes[2] = T_M_ID;
            textboxes[3] = T_M_Name;
            textboxes[4] = T_M_Number;
            textboxes[5] = T_M_Price;
            textboxes[6] = T_M_ID1;
            textboxes[7] = T_M_Name1;
            textboxes[8] = T_M_Number1;
            textboxes[9] = T_M_Price1;
            textboxes[1].PasswordChar = '*';

            buttons[0] = B_Login;
            buttons[1] = B_Add;
            buttons[2] = B_Deduct;
            buttons[3] = B_Modify;
            buttons[4] = B_Get_Info;
            buttons[5] = B_Logout;
            buttons[6] = B_Staff;
            buttons[7] = B_Add_P;
            buttons[8] = B_Del_P;
            buttons[9] = B_Sum;
            buttons[10] = B_Find;
            buttons[11] = B_Done;

            L_Info.Text = "請輸入帳號密碼以登入";
            L_Account.Text = "帳號：";
            L_Password.Text = "密碼：";
            L_M_ID.Text = "商品ID";
            L_M_Name.Text = "商品名稱";
            L_M_Number.Text = "商品數量";
            L_M_Price.Text = "商品價格";

            B_Login.Text = "登入";
            B_Add.Text = "新增商品";
            B_Deduct.Text = "扣除商品";
            B_Modify.Text = "修改商品";
            B_Get_Info.Text = "商品資訊";
            B_Logout.Text = "登出";
            B_Staff.Text = "員工資料";
            B_Add_P.Text = "加入員工";
            B_Del_P.Text = "踢除員工";
            B_Sum.Text = "全商品情況";
            B_Find.Text = "查詢";

            People.NewPerson(true, "Supervisor01", "Super01");
            People.NewPerson(false, "Employee01", "Emp01");
            People.NewPerson(false, "Employee02", "Emp02");
            People.NewPerson(false, "Employee03", "Emp03");

            return;
        }

        class People
        {
            public static People[] people = new People[50];
            public static int number = 0;

            bool supervisor;
            string account, password;

            public bool Supervisor
            {
                get
                {
                    return supervisor;
                }

                set
                {
                    supervisor = value;
                }
            }

            public string Account
            {
                get
                {
                    return account;
                }

                set
                {
                    account = value;
                }
            }

            public string Password
            {
                get
                {
                    return password;
                }

                set
                {
                    password = value;
                }
            }

            People(bool super, string acc, string pw)
            {
                supervisor = super;
                account = acc;
                password = pw;
                ++number;

                return;
            }
            
            public static bool NewPerson(bool super, string acc, string pw)
            {
                if (acc[0] >= 'A' && acc[0] <= 'Z')
                {
                    for (int i = 0; i < number; ++i)
                    {
                        if (people[i].Account == acc)
                        {
                            MessageBox.Show("已有此帳號!!請重新想一個!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            return false;
                        }
                    }

                    people[number] = new People(super, acc, pw);
                    MessageBox.Show("恭喜創帳號成功!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    return true;
                }
                else
                {
                    MessageBox.Show("帳號開頭必須大寫!!請重新想一個!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    return false;
                }
            }

            public static bool DeletePerson(string acc)
            {
                for (int i = 0; i < number; ++i)
                {
                    if (people[i].Account == acc)
                    {
                        //to delete
                        for (int j = i + 1; j < number; ++j)
                        {
                            people[j - 1] = people[j];
                        }

                        --number;

                        MessageBox.Show("已刪除此帳號!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        return true;
                    }
                }

                MessageBox.Show("查無此帳號!!請重新輸入!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return false;
            }

            public static int FindPerson(string acc, string pw)
            {
                if (acc == "" || pw == "")
                    return -1;

                for (int i = 0; i < number; ++i)
                {
                    if (people[i].Account == acc && people[i].Password == pw)
                    {
                            return people[i].Supervisor ? 1 : 2 ;
                    }
                }

                return 0;
            }
        }

        class Merchandise
        {
            string name;
            int ID, price, number;

            public static Merchandise[] merchandise = new Merchandise[50];
            public static int category = 0, focus = 0;
            
            public int Id
            {
                get { return ID;  }
                set { ID = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Price
            {
                get { return price; }
                set { price = value;  }
            }

            public int Number
            {
                get { return number; }
                set { number = value;  }
            }

            Merchandise(int id, string na, int p, int nu)
            {
                ID = id;
                name = na;
                price = p;
                number = nu;
                ++category;

                return;
            }

            public static bool NewMerchandise(int id, string na, int p, int nu)
            {
                for (int i = 0; i < category; ++i)
                {
                    if (merchandise[i].Id == id)
                    {
                        merchandise[i].Number += nu;
                        MessageBox.Show("已有此商品!!直接將數量加進其中!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        return false;
                    }
                }

                merchandise[category] = new Merchandise(id, na, p, nu);
                MessageBox.Show("恭喜新增商品成功!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return true;
            }

            public static bool DeductMerchandise(int id, int nu)
            {
                //by ID
                for (int i = 0; i < category; ++i)
                {
                    if (merchandise[i].Id == id)
                    {
                        if( merchandise[i].Number > nu )
                        {
                            //to deduct
                            merchandise[i].Number -= nu;

                            MessageBox.Show("已減少此商品!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            //to delete
                            //to destroy?????
                            for(int j = i + 1; j<category;++j)
                            {
                                merchandise[j - 1] = merchandise[j];
                            }

                            --category;

                            MessageBox.Show("已刪除此商品", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }

                        return true;
                    }
                }

                MessageBox.Show("查無此商品!!請重新輸入!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return false;
            }

            public static bool DeductMerchandise(string na, int nu)
            {
                //by name
                for (int i = 0; i < category; ++i)
                {
                    if (merchandise[i].Name == na)
                    {
                        if (merchandise[i].Number > nu)
                        {
                            //to deduct
                            merchandise[i].Number -= nu;

                            MessageBox.Show("已減少此商品!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            //to delete
                            //to destroy?????
                            for (int j = i + 1; j < category; ++j)
                            {
                                merchandise[j - 1] = merchandise[j];
                            }

                            --category;

                            MessageBox.Show("已刪除此商品", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }

                        return true;
                    }
                }

                MessageBox.Show("查無此商品!!請重新輸入!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                return false;
            }

            public static int FindMerchandise(int id)
            {
                //by ID
                for(int i =0; i<category; ++i)
                {
                    if (merchandise[i].Id == id)
                    {
                        focus = i;
                        return focus;
                    }
                }

                return -1;
            }

            public static int FindMerchandise(string na)
            {
                //by name
                for (int i = 0; i < category; ++i)
                {
                    if (merchandise[i].Name== na)
                    {
                        focus = i;
                        return focus;
                    }
                }

                return -1;
            }
        }
        

        private void B_Login_Click(object sender, EventArgs e)
        {
            //to login
            Form1_Load(this, e, People.FindPerson(textboxes[0].Text, textboxes[1].Text));

            return;
        }

        private void B_Logout_Click(object sender, EventArgs e)
        {
            //to logout
            MessageBox.Show("辛苦了!!路上小心!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Form1_Load(this, e);

            return;
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            //to go to add mode
            Form1_Load(this, e, (int)FormState.Add);

            B_Done.Text = "新增";

            return;
        }
        
        private void B_Deduct_Click(object sender, EventArgs e)
        {
            //to go to deduct mode
            Form1_Load(this, e, (int)FormState.Deduct);
            
            B_Done.Text = "刪除";

            return;
        }


        private void B_Modify_Click(object sender, EventArgs e)
        {
            //to go to modify mode
            Form1_Load(this, e, (int)FormState.Modify);

            B_Done.Text = "修改";

            return;
        }

        private void B_Get_Info_Click(object sender, EventArgs e)
        {
            //to go to info mode
            Form1_Load(this, e, (int)FormState.GetInfo);

            return;
        }

        private void B_Find_Click(object sender, EventArgs e)
        {
            //to find
            if (T_M_ID.Text != "")
            {
                int j = Merchandise.FindMerchandise(int.Parse(T_M_ID.Text));
                if (j != -1)
                {
                    L_M_Name.Visible = true;
                    L_M_Number.Visible = true;
                    L_M_Price.Visible = true;

                    for (int i = 2; i < 6; ++i)
                        textboxes[i].Visible = true;

                    T_M_ID.Text = Merchandise.merchandise[j].Id.ToString();
                    T_M_Name.Text = Merchandise.merchandise[j].Name;
                    T_M_Price.Text = Merchandise.merchandise[j].Price.ToString();
                    T_M_Number.Text = Merchandise.merchandise[j].Number.ToString();

                    if (B_Done.Visible)
                    {
                        for (j = 2; j < 6; ++j)
                            textboxes[j].Enabled = false;
                        for (; j < T_Number; ++j)
                            textboxes[j].Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("查無此商品!!請重新輸入!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            else if (T_M_Name.Text != "")
            {
                int j = Merchandise.FindMerchandise(T_M_Name.Text);
                if (j != -1)
                {
                    L_M_Name.Visible = true;
                    L_M_Number.Visible = true;
                    L_M_Price.Visible = true;

                    T_M_ID.Text = Merchandise.merchandise[j].Id.ToString();
                    T_M_Name.Text = Merchandise.merchandise[j].Name;
                    T_M_Price.Text = Merchandise.merchandise[j].Price.ToString();
                    T_M_Number.Text = Merchandise.merchandise[j].Number.ToString();

                    if (B_Done.Visible)
                    {
                        for (j = 2; j < 6; ++j)
                            textboxes[j].Enabled = false;
                        for (; j < T_Number; ++j)
                            textboxes[j].Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("查無此商品!!請重新輸入!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
                MessageBox.Show("ID或名稱不能皆為空!!請重新輸入!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            return;
        }

        private void B_Done_Click(object sender, EventArgs e)
        {
            switch(((Button)sender).Text)
            {
                case "新增":
                    if(T_M_ID.Text != "" && T_M_Name.Text != "" && T_M_Price.Text != "" && T_M_Number.Text != "")
                        Merchandise.NewMerchandise(int.Parse(T_M_ID.Text), T_M_Name.Text, int.Parse(T_M_Price.Text), int.Parse(T_M_Number.Text));
                    else
                        MessageBox.Show("各欄位皆不能為空!!請重新輸入!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    Form1_Load(this, e, (int)FormState.Add);

                    break;
                case "刪除":
                    if (T_M_Number.Text != "")
                    {
                        if (T_M_ID.Text != "")
                            Merchandise.DeductMerchandise(int.Parse(T_M_ID.Text), int.Parse(T_M_Number.Text));
                        else if (T_M_Name.Text != "")
                            Merchandise.DeductMerchandise(T_M_Name.Text, int.Parse(T_M_Number.Text));
                        else
                            MessageBox.Show("ID或名稱不能皆為空!!請重新輸入!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("數量不能為空!!請重新輸入!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    Form1_Load(this, e, (int)FormState.Deduct);

                    break;
                case "修改":
                    if(!T_M_ID1.Enabled)
                    {
                        MessageBox.Show("請先查詢商品!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Form1_Load(this, e, (int)FormState.Modify);
                        break;
                    }

                    if (T_M_ID1.Text != "")
                        Merchandise.merchandise[Merchandise.focus].Id = int.Parse(T_M_ID1.Text);

                    if (T_M_Name1.Text != "")
                        Merchandise.merchandise[Merchandise.focus].Name = T_M_Name1.Text;

                    if (T_M_Price1.Text != "")
                        Merchandise.merchandise[Merchandise.focus].Price = int.Parse(T_M_Price1.Text);

                    if (T_M_Number1.Text != "")
                        Merchandise.merchandise[Merchandise.focus].Number = int.Parse(T_M_Number1.Text);

                    MessageBox.Show("修改商品成功!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    Form1_Load(this, e, (int)FormState.Modify);

                    break;
                case "加入":
                    if (T_M_ID.Text != "" && T_M_Name.Text != "" && T_M_Number.Text != "")
                    {
                        if(T_M_ID.Text != "工頭")
                            People.NewPerson(false, T_M_Name.Text, T_M_Number.Text);
                        else
                            People.NewPerson(true, T_M_Name.Text, T_M_Number.Text);
                    }
                    else
                        MessageBox.Show("各欄位皆不能為空!!請重新輸入!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    Form1_Load(this, e, (int)FormState.NewP);

                    break;
                case "踢除":
                    if (T_M_Name.Text != "")
                        People.DeletePerson(T_M_Name.Text);
                    else
                        MessageBox.Show("各欄位皆不能為空!!請重新輸入!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    Form1_Load(this, e, (int)FormState.DelP);

                    break;
                default:
                    break;
            }

            return;
        }

        private void B_Staff_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < L_Number; ++i)
                labels[i].Visible = false;

            for (int i = 0; i < T_Number; ++i)
                textboxes[i].Visible = false;

            B_Find.Visible = false;
            B_Done.Visible = false;

            L_List.Visible = true;
            L_List.Text = "員工清單:\n";

            for(int i = 0; i<People.number;++i)
            {
                L_List.Text += People.people[i].Supervisor ? "身份: 工頭  " : "身份: 勞工  ";
                L_List.Text += "帳號: " + People.people[i].Account + "  密碼: " + People.people[i].Password + "\n";
            }

            return;
        }

        private void B_Sum_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < L_Number; ++i)
                labels[i].Visible = false;

            for (int i = 0; i < T_Number; ++i)
                textboxes[i].Visible = false;

            B_Find.Visible = false;
            B_Done.Visible = false;

            L_List.Visible = true;
            L_List.Text = "商品清單:\n";

            for (int i = 0; i < Merchandise.category; ++i)
            {
                L_List.Text += "商品ID: " + Merchandise.merchandise[i].Id.ToString() + "  商品名稱" + Merchandise.merchandise[i].Name + "  商品數量: " + Merchandise.merchandise[i].Number + "  商品價格: " + Merchandise.merchandise[i].Price + "\n";
            }

            return;
        }

        private void B_Add_P_Click(object sender, EventArgs e)
        {
            Form1_Load(this, e, (int)FormState.NewP);

            return;
        }

        private void B_Del_P_Click(object sender, EventArgs e)
        {
            Form1_Load(this, e, (int)FormState.DelP);

            return;
        }

        private void T_Account_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
                L_Info.Text = "小寫";
            else if (e.KeyChar >= 'A' && e.KeyChar <= 'Z')
                L_Info.Text = "大寫";
            else
                L_Info.Text = "其他";

            return;
        }

        private void T_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            T_Account_KeyPress(this, e);

            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialization state
            L_Info.Visible = true;
            L_Account.Visible = true;
            L_Password.Visible = true;
      
            for (int i = 3; i < L_Number; ++i)
                labels[i].Visible = false;

            L_Info.Text = "請輸入帳號密碼以登入";

            T_Account.Visible = true;
            T_Password.Visible = true;
            for (int i = 2; i < T_Number; ++i)
                textboxes[i].Visible = false;

            B_Login.Visible = true;

            for (int i = 1; i < B_Number; ++i)
                buttons[i].Visible = false;

            return;
        }

        private void Form1_Load(object sender, EventArgs e, int mode)
        {
            int j;

            for (int i = 0; i < T_Number; ++i)
            {
                textboxes[i].Enabled = true;
                textboxes[i].Text = "";
            }

            L_M_ID.Text = "商品ID";
            L_M_Name.Text = "商品名稱";
            L_M_Number.Text = "商品數量";

            switch (mode)
            {
                case -1:
                    MessageBox.Show("帳號密碼不能為空!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    break;
                case 0:
                    MessageBox.Show("無此帳號密碼!!請查明後再輸入", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    break;
                case (int)FormState.Supervisor:
                    //Supervisor
                    MessageBox.Show("你好，工頭!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    for (int i = 1; i < L_Number; ++i)
                        labels[i].Visible = false;

                    for (int i = 0; i < T_Number; ++i)
                        textboxes[i].Visible = false;

                    B_Login.Visible = false;
                    B_Find.Visible = false;
                    B_Done.Visible = false;

                    for (int i = 1; i < B_Number-2; ++i)
                        buttons[i].Visible = true;
                    
                    L_Info.Text = "歡迎老闆大驚光臨!!";

                    break;
                case (int)FormState.Employee:
                    //Employee
                    MessageBox.Show("你好，可憐的勞工!!", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    for (int i = 1; i < L_Number; ++i)
                        labels[i].Visible = false;

                    for (int i = 0; i < T_Number; ++i)
                        textboxes[i].Visible = false;

                    B_Login.Visible = false;

                    for (j = 1; j < 6; ++j)
                        buttons[j].Visible = true;
                    for (; j < B_Number; ++j)
                        buttons[j].Visible = false;

                    L_Info.Text = "歡迎光臨!!";

                    break;
                case (int)FormState.Add:
                    //Add mode
                    L_List.Visible = false;

                    for (int i = 3; i < L_Number-1; ++i)
                        labels[i].Visible = true;
                    
                    for (j = 2; j < 6; ++j)
                        textboxes[j].Visible = true;
                    for (; j < T_Number; ++j)
                        textboxes[j].Visible = false;
                    
                    B_Done.Visible = true;
                    B_Find.Visible = false;

                    B_Done.Text = "新增";

                    break;
                case (int)FormState.Deduct:
                    //Deduct mode
                    L_M_Price.Visible = false;
                    L_List.Visible = false;

                    for (int i = 3; i < L_Number-2; ++i)
                        labels[i].Visible = true;

                    for (j = 2; j < 5; ++j)
                        textboxes[j].Visible = true;
                    for (; j < T_Number; ++j)
                        textboxes[j].Visible = false;
                    
                    B_Done.Visible = true;
                    B_Find.Visible = false;

                    B_Done.Text = "刪除";

                    break;
                case (int)FormState.Modify:
                    //Modify mode
                    L_List.Visible = false;

                    for (int i = 3; i < L_Number-1; ++i)
                        labels[i].Visible = true;

                    for (j = 2; j < T_Number; ++j)
                        textboxes[j].Visible = true;
                    for (j = 6; j < T_Number; ++j)
                        textboxes[j].Enabled = false;
                    
                    B_Done.Visible = true;
                    B_Find.Visible = true;

                    B_Done.Text = "修改";
                    break;
                case (int)FormState.GetInfo:
                    //GetInfo mode
                    L_M_ID.Visible = true;

                    for (int i = 4; i < L_Number; ++i)
                        labels[i].Visible = false;
                    
                    T_M_ID.Visible = true;

                    for (j = 3; j < T_Number; ++j)
                        textboxes[j].Visible = false;
                    
                    B_Done.Visible = false;
                    B_Find.Visible = true;

                    break;

                case (int)FormState.NewP:
                    //NewP mode
                    L_M_Price.Visible = false;
                    L_List.Visible = false;

                    for (int i = 3; i < L_Number - 2; ++i)
                        labels[i].Visible = true;

                    for (j = 2; j < 5; ++j)
                        textboxes[j].Visible = true;
                    for (; j < T_Number; ++j)
                        textboxes[j].Visible = false;
                    
                    B_Done.Visible = true;
                    B_Find.Visible = false;

                    L_M_ID.Text = "身份";
                    L_M_Name.Text = "帳號";
                    L_M_Number.Text = "密碼";

                    B_Done.Text = "加入";

                    break;

                case (int)FormState.DelP:
                    //DelP mode
                    for (int i = 1; i < L_Number; ++i)
                        labels[i].Visible = false;
                    
                    L_M_Name.Visible = true;

                    for (j = 2; j < T_Number; ++j)
                        textboxes[j].Visible = false;

                    T_M_Name.Visible = true;
                    
                    B_Done.Visible = true;
                    B_Find.Visible = false;
                    
                    L_M_Name.Text = "帳號";

                    B_Done.Text = "踢除";

                    break;

                default:
                    MessageBox.Show("Form1_Load GG", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
            }

            return;
        }
    }
}
