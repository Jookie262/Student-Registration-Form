
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
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.form_panel = new System.Windows.Forms.Panel();
            this.table_layout_registration_form = new System.Windows.Forms.TableLayoutPanel();
            this.register_form = new System.Windows.Forms.Panel();
            this.body_register_form = new System.Windows.Forms.Panel();
            this.DayComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.FirstNameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.YearComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.MonthComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.FemaleRadioButton = new Guna.UI2.WinForms.Guna2RadioButton();
            this.MaleRadioButton = new Guna.UI2.WinForms.Guna2RadioButton();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.LastNameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.MiddleNameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.footer_register_form = new System.Windows.Forms.Panel();
            this.RegisterButton = new Guna.UI2.WinForms.Guna2Button();
            this.head_register_form = new System.Windows.Forms.Panel();
            this.RegistrationFormLabel = new System.Windows.Forms.Label();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.artwork_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.form_panel.SuspendLayout();
            this.table_layout_registration_form.SuspendLayout();
            this.register_form.SuspendLayout();
            this.body_register_form.SuspendLayout();
            this.footer_register_form.SuspendLayout();
            this.head_register_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // artwork_panel
            // 
            this.artwork_panel.BackgroundImage = global::Student_Registration_Form.Properties.Resources.artwork;
            this.artwork_panel.Controls.Add(this.closeButton);
            this.artwork_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.artwork_panel.Location = new System.Drawing.Point(408, 0);
            this.artwork_panel.Name = "artwork_panel";
            this.artwork_panel.Size = new System.Drawing.Size(392, 600);
            this.artwork_panel.TabIndex = 0;
            this.artwork_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = global::Student_Registration_Form.Properties.Resources.close_button;
            this.closeButton.Location = new System.Drawing.Point(302, -13);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(90, 89);
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.close_button_Click);
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
            this.register_form.Location = new System.Drawing.Point(35, 37);
            this.register_form.Name = "register_form";
            this.register_form.Size = new System.Drawing.Size(339, 525);
            this.register_form.TabIndex = 0;
            // 
            // body_register_form
            // 
            this.body_register_form.Controls.Add(this.DayComboBox);
            this.body_register_form.Controls.Add(this.FirstNameTextbox);
            this.body_register_form.Controls.Add(this.YearComboBox);
            this.body_register_form.Controls.Add(this.MonthComboBox);
            this.body_register_form.Controls.Add(this.DateOfBirthLabel);
            this.body_register_form.Controls.Add(this.FemaleRadioButton);
            this.body_register_form.Controls.Add(this.MaleRadioButton);
            this.body_register_form.Controls.Add(this.GenderLabel);
            this.body_register_form.Controls.Add(this.LastNameTextbox);
            this.body_register_form.Controls.Add(this.LastNameLabel);
            this.body_register_form.Controls.Add(this.MiddleNameTextbox);
            this.body_register_form.Controls.Add(this.MiddleNameLabel);
            this.body_register_form.Controls.Add(this.FirstNameLabel);
            this.body_register_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_register_form.Location = new System.Drawing.Point(0, 76);
            this.body_register_form.Name = "body_register_form";
            this.body_register_form.Size = new System.Drawing.Size(339, 408);
            this.body_register_form.TabIndex = 4;
            this.body_register_form.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // DayComboBox
            // 
            this.DayComboBox.BackColor = System.Drawing.Color.Transparent;
            this.DayComboBox.BorderRadius = 8;
            this.DayComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DayComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.DayComboBox.FocusedState.Parent = this.DayComboBox;
            this.DayComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.DayComboBox.FormattingEnabled = true;
            this.DayComboBox.HoverState.Parent = this.DayComboBox;
            this.DayComboBox.IntegralHeight = false;
            this.DayComboBox.ItemHeight = 28;
            this.DayComboBox.ItemsAppearance.Parent = this.DayComboBox;
            this.DayComboBox.Location = new System.Drawing.Point(9, 356);
            this.DayComboBox.MaxDropDownItems = 10;
            this.DayComboBox.Name = "DayComboBox";
            this.DayComboBox.ShadowDecoration.Parent = this.DayComboBox;
            this.DayComboBox.Size = new System.Drawing.Size(101, 34);
            this.DayComboBox.TabIndex = 6;
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.BorderRadius = 8;
            this.FirstNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstNameTextbox.DefaultText = "";
            this.FirstNameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FirstNameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FirstNameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstNameTextbox.DisabledState.Parent = this.FirstNameTextbox;
            this.FirstNameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstNameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstNameTextbox.FocusedState.Parent = this.FirstNameTextbox;
            this.FirstNameTextbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.FirstNameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstNameTextbox.HoverState.Parent = this.FirstNameTextbox;
            this.FirstNameTextbox.Location = new System.Drawing.Point(9, 44);
            this.FirstNameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.PasswordChar = '\0';
            this.FirstNameTextbox.PlaceholderText = "";
            this.FirstNameTextbox.SelectedText = "";
            this.FirstNameTextbox.ShadowDecoration.Parent = this.FirstNameTextbox;
            this.FirstNameTextbox.Size = new System.Drawing.Size(317, 36);
            this.FirstNameTextbox.TabIndex = 1;
            // 
            // YearComboBox
            // 
            this.YearComboBox.BackColor = System.Drawing.Color.Transparent;
            this.YearComboBox.BorderRadius = 8;
            this.YearComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YearComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.YearComboBox.FocusedState.Parent = this.YearComboBox;
            this.YearComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.YearComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.HoverState.Parent = this.YearComboBox;
            this.YearComboBox.IntegralHeight = false;
            this.YearComboBox.ItemHeight = 28;
            this.YearComboBox.ItemsAppearance.Parent = this.YearComboBox;
            this.YearComboBox.Location = new System.Drawing.Point(225, 356);
            this.YearComboBox.MaxDropDownItems = 10;
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.ShadowDecoration.Parent = this.YearComboBox;
            this.YearComboBox.Size = new System.Drawing.Size(101, 34);
            this.YearComboBox.TabIndex = 8;
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.BackColor = System.Drawing.Color.Transparent;
            this.MonthComboBox.BorderRadius = 8;
            this.MonthComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MonthComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.MonthComboBox.FocusedState.Parent = this.MonthComboBox;
            this.MonthComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MonthComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.HoverState.Parent = this.MonthComboBox;
            this.MonthComboBox.IntegralHeight = false;
            this.MonthComboBox.ItemHeight = 28;
            this.MonthComboBox.ItemsAppearance.Parent = this.MonthComboBox;
            this.MonthComboBox.Location = new System.Drawing.Point(117, 356);
            this.MonthComboBox.MaxDropDownItems = 10;
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.ShadowDecoration.Parent = this.MonthComboBox;
            this.MonthComboBox.Size = new System.Drawing.Size(101, 34);
            this.MonthComboBox.TabIndex = 7;
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Gadugi", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthLabel.ForeColor = System.Drawing.Color.White;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(9, 326);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(106, 20);
            this.DateOfBirthLabel.TabIndex = 0;
            this.DateOfBirthLabel.Text = "Date of Birth";
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FemaleRadioButton.CheckedState.BorderThickness = 0;
            this.FemaleRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FemaleRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.FemaleRadioButton.CheckedState.InnerOffset = -4;
            this.FemaleRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FemaleRadioButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleRadioButton.ForeColor = System.Drawing.Color.White;
            this.FemaleRadioButton.Location = new System.Drawing.Point(76, 286);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(77, 23);
            this.FemaleRadioButton.TabIndex = 5;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.FemaleRadioButton.UncheckedState.BorderThickness = 2;
            this.FemaleRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.FemaleRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaleRadioButton.CheckedState.BorderThickness = 0;
            this.MaleRadioButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MaleRadioButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.MaleRadioButton.CheckedState.InnerOffset = -4;
            this.MaleRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaleRadioButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleRadioButton.ForeColor = System.Drawing.Color.White;
            this.MaleRadioButton.Location = new System.Drawing.Point(9, 286);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(61, 23);
            this.MaleRadioButton.TabIndex = 4;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MaleRadioButton.UncheckedState.BorderThickness = 2;
            this.MaleRadioButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.MaleRadioButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Gadugi", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.ForeColor = System.Drawing.Color.White;
            this.GenderLabel.Location = new System.Drawing.Point(5, 256);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(65, 20);
            this.GenderLabel.TabIndex = 0;
            this.GenderLabel.Text = "Gender";
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.BorderRadius = 8;
            this.LastNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastNameTextbox.DefaultText = "";
            this.LastNameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LastNameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LastNameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastNameTextbox.DisabledState.Parent = this.LastNameTextbox;
            this.LastNameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastNameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastNameTextbox.FocusedState.Parent = this.LastNameTextbox;
            this.LastNameTextbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.LastNameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastNameTextbox.HoverState.Parent = this.LastNameTextbox;
            this.LastNameTextbox.Location = new System.Drawing.Point(9, 204);
            this.LastNameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.PasswordChar = '\0';
            this.LastNameTextbox.PlaceholderText = "";
            this.LastNameTextbox.SelectedText = "";
            this.LastNameTextbox.ShadowDecoration.Parent = this.LastNameTextbox;
            this.LastNameTextbox.Size = new System.Drawing.Size(317, 36);
            this.LastNameTextbox.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Gadugi", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.White;
            this.LastNameLabel.Location = new System.Drawing.Point(5, 174);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name";
            // 
            // MiddleNameTextbox
            // 
            this.MiddleNameTextbox.BorderRadius = 8;
            this.MiddleNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MiddleNameTextbox.DefaultText = "";
            this.MiddleNameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MiddleNameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MiddleNameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MiddleNameTextbox.DisabledState.Parent = this.MiddleNameTextbox;
            this.MiddleNameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MiddleNameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MiddleNameTextbox.FocusedState.Parent = this.MiddleNameTextbox;
            this.MiddleNameTextbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(96)))));
            this.MiddleNameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MiddleNameTextbox.HoverState.Parent = this.MiddleNameTextbox;
            this.MiddleNameTextbox.Location = new System.Drawing.Point(9, 124);
            this.MiddleNameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MiddleNameTextbox.Name = "MiddleNameTextbox";
            this.MiddleNameTextbox.PasswordChar = '\0';
            this.MiddleNameTextbox.PlaceholderText = "";
            this.MiddleNameTextbox.SelectedText = "";
            this.MiddleNameTextbox.ShadowDecoration.Parent = this.MiddleNameTextbox;
            this.MiddleNameTextbox.Size = new System.Drawing.Size(317, 36);
            this.MiddleNameTextbox.TabIndex = 2;
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Font = new System.Drawing.Font("Gadugi", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleNameLabel.ForeColor = System.Drawing.Color.White;
            this.MiddleNameLabel.Location = new System.Drawing.Point(5, 94);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(112, 20);
            this.MiddleNameLabel.TabIndex = 0;
            this.MiddleNameLabel.Text = "Middle Name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Gadugi", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.White;
            this.FirstNameLabel.Location = new System.Drawing.Point(5, 14);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(91, 20);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // footer_register_form
            // 
            this.footer_register_form.Controls.Add(this.RegisterButton);
            this.footer_register_form.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer_register_form.Location = new System.Drawing.Point(0, 484);
            this.footer_register_form.Name = "footer_register_form";
            this.footer_register_form.Size = new System.Drawing.Size(339, 41);
            this.footer_register_form.TabIndex = 3;
            this.footer_register_form.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BorderRadius = 8;
            this.RegisterButton.CheckedState.Parent = this.RegisterButton;
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.CustomImages.Parent = this.RegisterButton;
            this.RegisterButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(149)))));
            this.RegisterButton.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.HoverState.Parent = this.RegisterButton;
            this.RegisterButton.Location = new System.Drawing.Point(9, 2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.ShadowDecoration.Parent = this.RegisterButton;
            this.RegisterButton.Size = new System.Drawing.Size(108, 38);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.Click += new System.EventHandler(this.register_button_Click);
            // 
            // head_register_form
            // 
            this.head_register_form.AutoSize = true;
            this.head_register_form.Controls.Add(this.RegistrationFormLabel);
            this.head_register_form.Controls.Add(this.StudentLabel);
            this.head_register_form.Dock = System.Windows.Forms.DockStyle.Top;
            this.head_register_form.Location = new System.Drawing.Point(0, 0);
            this.head_register_form.Name = "head_register_form";
            this.head_register_form.Size = new System.Drawing.Size(339, 76);
            this.head_register_form.TabIndex = 2;
            this.head_register_form.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // RegistrationFormLabel
            // 
            this.RegistrationFormLabel.AutoSize = true;
            this.RegistrationFormLabel.Font = new System.Drawing.Font("Gadugi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationFormLabel.ForeColor = System.Drawing.Color.White;
            this.RegistrationFormLabel.Location = new System.Drawing.Point(1, 32);
            this.RegistrationFormLabel.Name = "RegistrationFormLabel";
            this.RegistrationFormLabel.Size = new System.Drawing.Size(334, 44);
            this.RegistrationFormLabel.TabIndex = 0;
            this.RegistrationFormLabel.Text = "Registration Form";
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLabel.ForeColor = System.Drawing.Color.White;
            this.StudentLabel.Location = new System.Drawing.Point(3, 1);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(123, 35);
            this.StudentLabel.TabIndex = 0;
            this.StudentLabel.Text = "Student";
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
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.artwork_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.form_panel.ResumeLayout(false);
            this.table_layout_registration_form.ResumeLayout(false);
            this.register_form.ResumeLayout(false);
            this.register_form.PerformLayout();
            this.body_register_form.ResumeLayout(false);
            this.body_register_form.PerformLayout();
            this.footer_register_form.ResumeLayout(false);
            this.head_register_form.ResumeLayout(false);
            this.head_register_form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel artwork_panel;
        private System.Windows.Forms.Panel form_panel;
        private System.Windows.Forms.TableLayoutPanel table_layout_registration_form;
        private System.Windows.Forms.Panel register_form;
        private System.Windows.Forms.Label RegistrationFormLabel;
        private System.Windows.Forms.Label StudentLabel;
        public System.Windows.Forms.Panel head_register_form;
        private System.Windows.Forms.Panel footer_register_form;
        private Guna.UI2.WinForms.Guna2Button RegisterButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Panel body_register_form;
        private Guna.UI2.WinForms.Guna2ComboBox DayComboBox;
        private Guna.UI2.WinForms.Guna2TextBox FirstNameTextbox;
        private Guna.UI2.WinForms.Guna2ComboBox YearComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox MonthComboBox;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private Guna.UI2.WinForms.Guna2RadioButton FemaleRadioButton;
        private Guna.UI2.WinForms.Guna2RadioButton MaleRadioButton;
        private System.Windows.Forms.Label GenderLabel;
        private Guna.UI2.WinForms.Guna2TextBox LastNameTextbox;
        private System.Windows.Forms.Label LastNameLabel;
        private Guna.UI2.WinForms.Guna2TextBox MiddleNameTextbox;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
    }
}

