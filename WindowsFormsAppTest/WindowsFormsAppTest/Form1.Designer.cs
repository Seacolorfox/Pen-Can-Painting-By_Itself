namespace WindowsFormsAppTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_YourName = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.lst_Names = new System.Windows.Forms.ListBox();
            this.txt_Add_Name = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_DeleteAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ShowForm2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_YourName
            // 
            resources.ApplyResources(this.lbl_YourName, "lbl_YourName");
            this.lbl_YourName.Name = "lbl_YourName";
            this.lbl_YourName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Name
            // 
            resources.ApplyResources(this.txt_Name, "txt_Name");
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // btn_Ok
            // 
            resources.ApplyResources(this.btn_Ok, "btn_Ok");
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // lbl_Count
            // 
            resources.ApplyResources(this.lbl_Count, "lbl_Count");
            this.lbl_Count.Name = "lbl_Count";
            // 
            // lst_Names
            // 
            this.lst_Names.FormattingEnabled = true;
            resources.ApplyResources(this.lst_Names, "lst_Names");
            this.lst_Names.Name = "lst_Names";
            // 
            // txt_Add_Name
            // 
            resources.ApplyResources(this.txt_Add_Name, "txt_Add_Name");
            this.txt_Add_Name.Name = "txt_Add_Name";
            // 
            // btn_Add
            // 
            resources.ApplyResources(this.btn_Add, "btn_Add");
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_DeleteAll
            // 
            resources.ApplyResources(this.btn_DeleteAll, "btn_DeleteAll");
            this.btn_DeleteAll.Name = "btn_DeleteAll";
            this.btn_DeleteAll.UseVisualStyleBackColor = true;
            this.btn_DeleteAll.Click += new System.EventHandler(this.btn_DeleteAll_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_ShowForm2
            // 
            resources.ApplyResources(this.btn_ShowForm2, "btn_ShowForm2");
            this.btn_ShowForm2.Name = "btn_ShowForm2";
            this.btn_ShowForm2.UseVisualStyleBackColor = true;
            this.btn_ShowForm2.Click += new System.EventHandler(this.btn_ShowForm2_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_ShowForm2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_DeleteAll);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Add_Name);
            this.Controls.Add(this.lst_Names);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_YourName);
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_YourName;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.ListBox lst_Names;
        private System.Windows.Forms.TextBox txt_Add_Name;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_DeleteAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ShowForm2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

