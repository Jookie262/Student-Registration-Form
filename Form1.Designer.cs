
namespace Student_Registration_Form
{
    partial class RegistrationForm
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
            this.artwork_panel = new System.Windows.Forms.Panel();
            this.form_panel = new System.Windows.Forms.Panel();
            this.table_layout_registration_form = new System.Windows.Forms.TableLayoutPanel();
            this.register_form = new System.Windows.Forms.Panel();
            this.label_student = new System.Windows.Forms.Label();
            this.label_registration_form = new System.Windows.Forms.Label();
            this.head_register_form = new System.Windows.Forms.Panel();
            this.footer_register_form = new System.Windows.Forms.Panel();
            this.register_button = new Guna.UI2.WinForms.Guna2Button();
            this.close_button = new System.Windows.Forms.PictureBox();
            this.label_first_name = new System.Windows.Forms.Label();
            this.label_middle_name = new System.Windows.Forms.Label();
            this.middle_name_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_last_name = new System.Windows.Forms.Label();
            this.last_name_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_gender = new System.Windows.Forms.Label();
            this.male_radio_button = new Guna.UI2.WinForms.Guna2RadioButton();
            this.female_radio_button = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label_date_of_birth = new System.Windows.Forms.Label();
            this.month_combo_box = new Guna.UI2.WinForms.Guna2ComboBox();
            this.year_combo_box = new Guna.UI2.WinForms.Guna2ComboBox();
            this.first_name_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.day_combo_box = new Guna.UI2.WinForms.Guna2ComboBox();
            this.body_register_form = new System.Windows.Forms.Panel();
            this.artwork_panel.SuspendLayout();
            this.form_panel.SuspendLayout();
            this.table_layout_registration_form.SuspendLayout();
            this.register_form.SuspendLayout();
            this.head_register_form.SuspendLayout();
            this.footer_register_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).BeginInit();
            this.body_register_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // artwork_panel
            // 
            this.artwork_panel.BackgroundImage = global::Student_Registration_Form.Properties.Resources.artwork;
            this.artwork_panel.Controls.Add(this.close_button);
            this.artwork_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.artwork_panel.Location = new System.Drawing.Point(408, 0);
            this.artwork_panel.Name = "artwork_panel";
            this.artwork_panel.Size = new System.Drawing.Size(392, 600);
            this.artwork_panel.TabIndex = 0;
            this.artwork_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // form_panel
            // 
            this.form_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            this.form_panel.Controls.Add(this.table_layout_registration_form);
            this.form_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.form_panel.Location = new System.Drawing.Point(0, 0);
            this.form_panel.Name = "form_panel";
            this.form_panel.Size = new System.Drawing.Size(410, 600);
            this.form_panel.TabIndex = 1;
            // 
            // table_layout_registration_form
            // 
            this.table_layout_registration_form.ColumnCount = 1;
            this.table_layout_registration_form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_layout_registration_form.Controls.Add(this.register_form, 0, 0);
            this.table_layout_registration_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_layout_registration_form.Location = new System.Drawing.Point(0, 0);
            this.table_layout_registration_form.Name = "table_layout_registration_form";
            this.table_layout_registration_form.RowCount = 1;
            this.table_layout_registration_form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_layout_registration_form.Size = new System.Drawing.Size(410, 600);
            this.table_layout_registration_form.TabIndex = 0;
            this.table_layout_registration_form.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // register_form
            // 
            this.register_form.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_form.Controls.Add(this.body_register_form);
            this.register_form.Controls.Add(this.footer_register_form);
            this.register_form.Controls.Add(this.head_register_form);
            this.register_form.Location = new System.Drawing.Point(35, 35);
            this.register_form.Name = "register_form";
            this.register_form.Size = new System.Drawing.Size(339, 529);
            this.register_form.TabIndex = 0;
            // 
            // label_student
            // 
            this.label_student.AutoSize = true;
            this.label_student.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_student.ForeColor = System.Drawing.Color.White;
            this.label_student.Location = new System.Drawing.Point(3, 1);
            this.label_student.Name = "label_student";
            this.label_student.Size = new System.Drawing.Size(123, 35);
            this.label_student.TabIndex = 0;
            this.label_student.Text = "Student";
            // 
            // label_registration_form
            // 
            this.label_registration_form.AutoSize = true;
            this.label_registration_form.Font = new System.Drawing.Font("Gadugi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_registration_form.ForeColor = System.Drawing.Color.White;
            this.label_registration_form.Location = new System.Drawing.Point(1, 32);
            this.label_registration_form.Name = "label_registration_form";
            this.label_registration_form.Size = new System.Drawing.Size(334, 44);
            this.label_registration_form.TabIndex = 0;
            this.label_registration_form.Text = "Registration Form";
            // 
            // head_register_form
            // 
            this.head_register_form.AutoSize = true;
            this.head_register_form.Controls.Add(this.label_registration_form);
            this.head_register_form.Controls.Add(this.label_student);
            this.head_register_form.Dock = System.Windows.Forms.DockStyle.Top;
            this.head_register_form.Location = new System.Drawing.Point(0, 0);
            this.head_register_form.Name = "head_register_form";
            this.head_register_form.Size = new System.Drawing.Size(339, 76);
            this.head_register_form.TabIndex = 2;
            this.head_register_form.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // footer_register_form
            // 
            this.footer_register_form.Controls.Add(this.register_button);
            this.footer_register_form.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer_register_form.Location = new System.Drawing.Point(0, 488);
            this.footer_register_form.Name = "footer_register_form";
            this.footer_register_form.Size = new System.Drawing.Size(339, 41);
            this.footer_register_form.TabIndex = 3;
            this.footer_register_form.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // register_button
            // 
            this.register_button.BorderRadius = 8;
            this.register_button.CheckedState.Parent = this.register_button;
            this.register_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_button.CustomImages.Parent = this.register_button;
            this.register_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(149)))));
            this.register_button.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.ForeColor = System.Drawing.Color.White;
            this.register_button.HoverState.Parent = this.register_button;
            this.register_button.Location = new System.Drawing.Point(9, 2);
            this.register_button.Name = "register_button";
            this.register_button.ShadowDecoration.Parent = this.register_button;
            this.register_button.Size = new System.Drawing.Size(108, 38);
            this.register_button.TabIndex = 9;
            this.register_button.Text = "Register";
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.Image = global::Student_Registration_Form.Properties.Resources.close_button;
            this.close_button.Location = new System.Drawing.Point(302, -13);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(90, 89);
            this.close_button.TabIndex = 0;
            this.close_button.TabStop = false;
            // 
            // label_first_name
            // 
            this.label_first_name.AutoSize = true;
            this.label_first_name.Font = new System.Drawing.Font("Gadugi", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_first_name.ForeColor = System.Drawing.Color.White;
            this.label_first_name.Location = new System.Drawing.Point(5, 16);
            this.label_first_name.Name = "label_first_name";
            this.label_first_name.Size = new System.Drawing.Size(91, 20);
            this.label_first_name.TabIndex = 0;
            this.label_first_name.Text = "First Name";
            // 
            // label_middle_name
            // 
            this.label_middle_name.AutoSize = true;
            this.label_middle_name.Font = new System.Drawing.Font("Gadugi", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_middle_name.ForeColor = System.Drawing.Color.White;
            this.label_middle_name.Location = new System.Drawing.Point(5, 96);
            this.label_middle_name.Name = "label_middle_name";
            this.label_middle_name.Size = new System.Drawing.Size(112, 20);
            this.label_middle_name.TabIndex = 0;
            this.label_middle_name.Text = "Middle Name";
            // 
            // middle_name_textbox
            // 
            this.middle_name_textbox.BorderRadius = 8;
            this.middle_name_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.middle_name_textbox.DefaultText = "";
            this.middle_name_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.middle_name_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.middle_name_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.middle_name_textbox.DisabledState.Parent = this.middle_name_textbox;
            this.middle_name_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.middle_name_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.middle_name_textbox.FocusedState.Parent = this.middle_name_textbox;
            this.middle_name_textbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middle_name_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.middle_name_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.middle_name_textbox.HoverState.Parent = this.middle_name_textbox;
            this.middle_name_textbox.Location = new System.Drawing.Point(9, 126);
            this.middle_name_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.middle_name_textbox.Name = "middle_name_textbox";
            this.middle_name_textbox.PasswordChar = '\0';
            this.middle_name_textbox.PlaceholderText = "";
            this.middle_name_textbox.SelectedText = "";
            this.middle_name_textbox.ShadowDecoration.Parent = this.middle_name_textbox;
            this.middle_name_textbox.Size = new System.Drawing.Size(317, 36);
            this.middle_name_textbox.TabIndex = 2;
            // 
            // label_last_name
            // 
            this.label_last_name.AutoSize = true;
            this.label_last_name.Font = new System.Drawing.Font("Gadugi", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_last_name.ForeColor = System.Drawing.Color.White;
            this.label_last_name.Location = new System.Drawing.Point(5, 176);
            this.label_last_name.Name = "label_last_name";
            this.label_last_name.Size = new System.Drawing.Size(90, 20);
            this.label_last_name.TabIndex = 0;
            this.label_last_name.Text = "Last Name";
            // 
            // last_name_textbox
            // 
            this.last_name_textbox.BorderRadius = 8;
            this.last_name_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.last_name_textbox.DefaultText = "";
            this.last_name_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.last_name_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.last_name_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.last_name_textbox.DisabledState.Parent = this.last_name_textbox;
            this.last_name_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.last_name_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.last_name_textbox.FocusedState.Parent = this.last_name_textbox;
            this.last_name_textbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.last_name_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.last_name_textbox.HoverState.Parent = this.last_name_textbox;
            this.last_name_textbox.Location = new System.Drawing.Point(9, 206);
            this.last_name_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.last_name_textbox.Name = "last_name_textbox";
            this.last_name_textbox.PasswordChar = '\0';
            this.last_name_textbox.PlaceholderText = "";
            this.last_name_textbox.SelectedText = "";
            this.last_name_textbox.ShadowDecoration.Parent = this.last_name_textbox;
            this.last_name_textbox.Size = new System.Drawing.Size(317, 36);
            this.last_name_textbox.TabIndex = 3;
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Gadugi", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.ForeColor = System.Drawing.Color.White;
            this.label_gender.Location = new System.Drawing.Point(5, 258);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(65, 20);
            this.label_gender.TabIndex = 0;
            this.label_gender.Text = "Gender";
            // 
            // male_radio_button
            // 
            this.male_radio_button.AutoSize = true;
            this.male_radio_button.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.male_radio_button.CheckedState.BorderThickness = 0;
            this.male_radio_button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.male_radio_button.CheckedState.InnerColor = System.Drawing.Color.White;
            this.male_radio_button.CheckedState.InnerOffset = -4;
            this.male_radio_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.male_radio_button.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_radio_button.ForeColor = System.Drawing.Color.White;
            this.male_radio_button.Location = new System.Drawing.Point(9, 288);
            this.male_radio_button.Name = "male_radio_button";
            this.male_radio_button.Size = new System.Drawing.Size(61, 23);
            this.male_radio_button.TabIndex = 4;
            this.male_radio_button.TabStop = true;
            this.male_radio_button.Text = "Male";
            this.male_radio_button.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.male_radio_button.UncheckedState.BorderThickness = 2;
            this.male_radio_button.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.male_radio_button.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.male_radio_button.UseVisualStyleBackColor = true;
            // 
            // female_radio_button
            // 
            this.female_radio_button.AutoSize = true;
            this.female_radio_button.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.female_radio_button.CheckedState.BorderThickness = 0;
            this.female_radio_button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.female_radio_button.CheckedState.InnerColor = System.Drawing.Color.White;
            this.female_radio_button.CheckedState.InnerOffset = -4;
            this.female_radio_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.female_radio_button.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_radio_button.ForeColor = System.Drawing.Color.White;
            this.female_radio_button.Location = new System.Drawing.Point(76, 288);
            this.female_radio_button.Name = "female_radio_button";
            this.female_radio_button.Size = new System.Drawing.Size(77, 23);
            this.female_radio_button.TabIndex = 5;
            this.female_radio_button.TabStop = true;
            this.female_radio_button.Text = "Female";
            this.female_radio_button.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.female_radio_button.UncheckedState.BorderThickness = 2;
            this.female_radio_button.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.female_radio_button.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.female_radio_button.UseVisualStyleBackColor = true;
            // 
            // label_date_of_birth
            // 
            this.label_date_of_birth.AutoSize = true;
            this.label_date_of_birth.Font = new System.Drawing.Font("Gadugi", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date_of_birth.ForeColor = System.Drawing.Color.White;
            this.label_date_of_birth.Location = new System.Drawing.Point(9, 328);
            this.label_date_of_birth.Name = "label_date_of_birth";
            this.label_date_of_birth.Size = new System.Drawing.Size(106, 20);
            this.label_date_of_birth.TabIndex = 0;
            this.label_date_of_birth.Text = "Date of Birth";
            // 
            // month_combo_box
            // 
            this.month_combo_box.BackColor = System.Drawing.Color.Transparent;
            this.month_combo_box.BorderRadius = 8;
            this.month_combo_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.month_combo_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.month_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.month_combo_box.FocusedColor = System.Drawing.Color.Empty;
            this.month_combo_box.FocusedState.Parent = this.month_combo_box;
            this.month_combo_box.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.month_combo_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.month_combo_box.FormattingEnabled = true;
            this.month_combo_box.HoverState.Parent = this.month_combo_box;
            this.month_combo_box.IntegralHeight = false;
            this.month_combo_box.ItemHeight = 28;
            this.month_combo_box.Items.AddRange(new object[] {
            "-Month-",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.month_combo_box.ItemsAppearance.Parent = this.month_combo_box;
            this.month_combo_box.Location = new System.Drawing.Point(117, 358);
            this.month_combo_box.MaxDropDownItems = 10;
            this.month_combo_box.Name = "month_combo_box";
            this.month_combo_box.ShadowDecoration.Parent = this.month_combo_box;
            this.month_combo_box.Size = new System.Drawing.Size(101, 34);
            this.month_combo_box.TabIndex = 7;
            // 
            // year_combo_box
            // 
            this.year_combo_box.BackColor = System.Drawing.Color.Transparent;
            this.year_combo_box.BorderRadius = 8;
            this.year_combo_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.year_combo_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.year_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year_combo_box.FocusedColor = System.Drawing.Color.Empty;
            this.year_combo_box.FocusedState.Parent = this.year_combo_box;
            this.year_combo_box.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.year_combo_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.year_combo_box.FormattingEnabled = true;
            this.year_combo_box.HoverState.Parent = this.year_combo_box;
            this.year_combo_box.IntegralHeight = false;
            this.year_combo_box.ItemHeight = 28;
            this.year_combo_box.Items.AddRange(new object[] {
            "-Year-",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010"});
            this.year_combo_box.ItemsAppearance.Parent = this.year_combo_box;
            this.year_combo_box.Location = new System.Drawing.Point(225, 358);
            this.year_combo_box.MaxDropDownItems = 10;
            this.year_combo_box.Name = "year_combo_box";
            this.year_combo_box.ShadowDecoration.Parent = this.year_combo_box;
            this.year_combo_box.Size = new System.Drawing.Size(101, 34);
            this.year_combo_box.TabIndex = 8;
            // 
            // first_name_textbox
            // 
            this.first_name_textbox.BorderRadius = 8;
            this.first_name_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.first_name_textbox.DefaultText = "";
            this.first_name_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.first_name_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.first_name_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.first_name_textbox.DisabledState.Parent = this.first_name_textbox;
            this.first_name_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.first_name_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.first_name_textbox.FocusedState.Parent = this.first_name_textbox;
            this.first_name_textbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.first_name_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.first_name_textbox.HoverState.Parent = this.first_name_textbox;
            this.first_name_textbox.Location = new System.Drawing.Point(9, 46);
            this.first_name_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.first_name_textbox.Name = "first_name_textbox";
            this.first_name_textbox.PasswordChar = '\0';
            this.first_name_textbox.PlaceholderText = "";
            this.first_name_textbox.SelectedText = "";
            this.first_name_textbox.ShadowDecoration.Parent = this.first_name_textbox;
            this.first_name_textbox.Size = new System.Drawing.Size(317, 36);
            this.first_name_textbox.TabIndex = 1;
            // 
            // day_combo_box
            // 
            this.day_combo_box.BackColor = System.Drawing.Color.Transparent;
            this.day_combo_box.BorderRadius = 8;
            this.day_combo_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.day_combo_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.day_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.day_combo_box.FocusedColor = System.Drawing.Color.Empty;
            this.day_combo_box.FocusedState.Parent = this.day_combo_box;
            this.day_combo_box.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_combo_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.day_combo_box.FormattingEnabled = true;
            this.day_combo_box.HoverState.Parent = this.day_combo_box;
            this.day_combo_box.IntegralHeight = false;
            this.day_combo_box.ItemHeight = 28;
            this.day_combo_box.Items.AddRange(new object[] {
            "-Day",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.day_combo_box.ItemsAppearance.Parent = this.day_combo_box;
            this.day_combo_box.Location = new System.Drawing.Point(9, 358);
            this.day_combo_box.MaxDropDownItems = 10;
            this.day_combo_box.Name = "day_combo_box";
            this.day_combo_box.ShadowDecoration.Parent = this.day_combo_box;
            this.day_combo_box.Size = new System.Drawing.Size(101, 34);
            this.day_combo_box.TabIndex = 6;
            // 
            // body_register_form
            // 
            this.body_register_form.Controls.Add(this.day_combo_box);
            this.body_register_form.Controls.Add(this.first_name_textbox);
            this.body_register_form.Controls.Add(this.year_combo_box);
            this.body_register_form.Controls.Add(this.month_combo_box);
            this.body_register_form.Controls.Add(this.label_date_of_birth);
            this.body_register_form.Controls.Add(this.female_radio_button);
            this.body_register_form.Controls.Add(this.male_radio_button);
            this.body_register_form.Controls.Add(this.label_gender);
            this.body_register_form.Controls.Add(this.last_name_textbox);
            this.body_register_form.Controls.Add(this.label_last_name);
            this.body_register_form.Controls.Add(this.middle_name_textbox);
            this.body_register_form.Controls.Add(this.label_middle_name);
            this.body_register_form.Controls.Add(this.label_first_name);
            this.body_register_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_register_form.Location = new System.Drawing.Point(0, 76);
            this.body_register_form.Name = "body_register_form";
            this.body_register_form.Size = new System.Drawing.Size(339, 412);
            this.body_register_form.TabIndex = 4;
            this.body_register_form.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.form_panel);
            this.Controls.Add(this.artwork_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration Form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.artwork_panel.ResumeLayout(false);
            this.form_panel.ResumeLayout(false);
            this.table_layout_registration_form.ResumeLayout(false);
            this.register_form.ResumeLayout(false);
            this.register_form.PerformLayout();
            this.head_register_form.ResumeLayout(false);
            this.head_register_form.PerformLayout();
            this.footer_register_form.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).EndInit();
            this.body_register_form.ResumeLayout(false);
            this.body_register_form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel artwork_panel;
        private System.Windows.Forms.Panel form_panel;
        private System.Windows.Forms.TableLayoutPanel table_layout_registration_form;
        private System.Windows.Forms.Panel register_form;
        private System.Windows.Forms.Label label_registration_form;
        private System.Windows.Forms.Label label_student;
        public System.Windows.Forms.Panel head_register_form;
        private System.Windows.Forms.Panel footer_register_form;
        private Guna.UI2.WinForms.Guna2Button register_button;
        private System.Windows.Forms.PictureBox close_button;
        private System.Windows.Forms.Panel body_register_form;
        private Guna.UI2.WinForms.Guna2ComboBox day_combo_box;
        private Guna.UI2.WinForms.Guna2TextBox first_name_textbox;
        private Guna.UI2.WinForms.Guna2ComboBox year_combo_box;
        private Guna.UI2.WinForms.Guna2ComboBox month_combo_box;
        private System.Windows.Forms.Label label_date_of_birth;
        private Guna.UI2.WinForms.Guna2RadioButton female_radio_button;
        private Guna.UI2.WinForms.Guna2RadioButton male_radio_button;
        private System.Windows.Forms.Label label_gender;
        private Guna.UI2.WinForms.Guna2TextBox last_name_textbox;
        private System.Windows.Forms.Label label_last_name;
        private Guna.UI2.WinForms.Guna2TextBox middle_name_textbox;
        private System.Windows.Forms.Label label_middle_name;
        private System.Windows.Forms.Label label_first_name;
    }
}

