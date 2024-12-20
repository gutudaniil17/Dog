using System;
using System.Linq;
using System.Windows.Forms;
using DogNamespace;

namespace Dog
{
    partial class FormMain
    {
        // Controls Declaration
        private TextBox NameTextBox;
        private TextBox ColorTextBox;
        private TextBox OwnerNameTextBox;
        private NumericUpDown WeightNumericUpDown;
        private NumericUpDown HeightNumericUpDown;
        private ComboBox BreedComboBox;
        private ComboBox EyeColorComboBox;
        private ComboBox SexComboBox;
        private CheckBox VaccinatedCheckBox;
        private DateTimePicker BirthDatePicker;
        private ErrorProvider TextBoxErrorProvider;
        
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label OwnerNameLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label BreedLabel;
        private System.Windows.Forms.Label EyeColorLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label VaccinatedLabel;
        private System.Windows.Forms.Label BirthDateLabel;
        
        private System.Windows.Forms.GroupBox DogDetailsGroupBox;
        private System.Windows.Forms.GroupBox BirthDetailsGroupBox;
        private ToolStrip toolBar;
        private StatusStrip statusBar;
        private ContextMenuStrip contextMenu;
        private ToolStripComboBox toolStripComboBox;
        private ToolStripTextBox toolStripTextBox;


        private void InitializeComponent()
{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.DogDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.OwnerNameLabel = new System.Windows.Forms.Label();
            this.OwnerNameTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BirthDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.BreedLabel = new System.Windows.Forms.Label();
            this.BreedComboBox = new System.Windows.Forms.ComboBox();
            this.EyeColorLabel = new System.Windows.Forms.Label();
            this.EyeColorComboBox = new System.Windows.Forms.ComboBox();
            this.SexLabel = new System.Windows.Forms.Label();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.VaccinatedLabel = new System.Windows.Forms.Label();
            this.VaccinatedCheckBox = new System.Windows.Forms.CheckBox();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.TextBoxErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inNewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DogDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).BeginInit();
            this.BirthDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxErrorProvider)).BeginInit();
            this.toolBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DogDetailsGroupBox
            // 
            this.DogDetailsGroupBox.Controls.Add(this.NameLabel);
            this.DogDetailsGroupBox.Controls.Add(this.NameTextBox);
            this.DogDetailsGroupBox.Controls.Add(this.ColorLabel);
            this.DogDetailsGroupBox.Controls.Add(this.ColorTextBox);
            this.DogDetailsGroupBox.Controls.Add(this.OwnerNameLabel);
            this.DogDetailsGroupBox.Controls.Add(this.OwnerNameTextBox);
            this.DogDetailsGroupBox.Controls.Add(this.WeightLabel);
            this.DogDetailsGroupBox.Controls.Add(this.WeightNumericUpDown);
            this.DogDetailsGroupBox.Controls.Add(this.HeightLabel);
            this.DogDetailsGroupBox.Controls.Add(this.HeightNumericUpDown);
            this.DogDetailsGroupBox.Location = new System.Drawing.Point(12, 28);
            this.DogDetailsGroupBox.Name = "DogDetailsGroupBox";
            this.DogDetailsGroupBox.Size = new System.Drawing.Size(300, 350);
            this.DogDetailsGroupBox.TabIndex = 4;
            this.DogDetailsGroupBox.TabStop = false;
            this.DogDetailsGroupBox.Text = "Dog Details";
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(10, 30);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 23);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(115, 30);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(180, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameTextBox_Validating);
            // 
            // ColorLabel
            // 
            this.ColorLabel.Location = new System.Drawing.Point(10, 70);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(100, 23);
            this.ColorLabel.TabIndex = 2;
            this.ColorLabel.Text = "Color";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(115, 70);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(180, 20);
            this.ColorTextBox.TabIndex = 3;
            // 
            // OwnerNameLabel
            // 
            this.OwnerNameLabel.Location = new System.Drawing.Point(10, 110);
            this.OwnerNameLabel.Name = "OwnerNameLabel";
            this.OwnerNameLabel.Size = new System.Drawing.Size(100, 23);
            this.OwnerNameLabel.TabIndex = 4;
            this.OwnerNameLabel.Text = "Owner Name";
            // 
            // OwnerNameTextBox
            // 
            this.OwnerNameTextBox.Location = new System.Drawing.Point(115, 110);
            this.OwnerNameTextBox.Name = "OwnerNameTextBox";
            this.OwnerNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.OwnerNameTextBox.TabIndex = 5;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Location = new System.Drawing.Point(10, 150);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(100, 23);
            this.WeightLabel.TabIndex = 6;
            this.WeightLabel.Text = "Weight";
            // 
            // WeightNumericUpDown
            // 
            this.WeightNumericUpDown.Location = new System.Drawing.Point(115, 150);
            this.WeightNumericUpDown.Name = "WeightNumericUpDown";
            this.WeightNumericUpDown.Size = new System.Drawing.Size(180, 20);
            this.WeightNumericUpDown.TabIndex = 7;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Location = new System.Drawing.Point(10, 190);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(100, 23);
            this.HeightLabel.TabIndex = 8;
            this.HeightLabel.Text = "Height";
            // 
            // HeightNumericUpDown
            // 
            this.HeightNumericUpDown.Location = new System.Drawing.Point(115, 190);
            this.HeightNumericUpDown.Name = "HeightNumericUpDown";
            this.HeightNumericUpDown.Size = new System.Drawing.Size(180, 20);
            this.HeightNumericUpDown.TabIndex = 9;
            // 
            // BirthDetailsGroupBox
            // 
            this.BirthDetailsGroupBox.Controls.Add(this.BreedLabel);
            this.BirthDetailsGroupBox.Controls.Add(this.BreedComboBox);
            this.BirthDetailsGroupBox.Controls.Add(this.EyeColorLabel);
            this.BirthDetailsGroupBox.Controls.Add(this.EyeColorComboBox);
            this.BirthDetailsGroupBox.Controls.Add(this.SexLabel);
            this.BirthDetailsGroupBox.Controls.Add(this.SexComboBox);
            this.BirthDetailsGroupBox.Controls.Add(this.VaccinatedLabel);
            this.BirthDetailsGroupBox.Controls.Add(this.VaccinatedCheckBox);
            this.BirthDetailsGroupBox.Controls.Add(this.BirthDateLabel);
            this.BirthDetailsGroupBox.Controls.Add(this.BirthDatePicker);
            this.BirthDetailsGroupBox.Location = new System.Drawing.Point(331, 28);
            this.BirthDetailsGroupBox.Name = "BirthDetailsGroupBox";
            this.BirthDetailsGroupBox.Size = new System.Drawing.Size(300, 350);
            this.BirthDetailsGroupBox.TabIndex = 5;
            this.BirthDetailsGroupBox.TabStop = false;
            this.BirthDetailsGroupBox.Text = "Birth and Other Info";
            // 
            // BreedLabel
            // 
            this.BreedLabel.Location = new System.Drawing.Point(10, 30);
            this.BreedLabel.Name = "BreedLabel";
            this.BreedLabel.Size = new System.Drawing.Size(100, 23);
            this.BreedLabel.TabIndex = 0;
            this.BreedLabel.Text = "Breed";
            // 
            // BreedComboBox
            // 
            this.BreedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BreedComboBox.Items.AddRange(new object[] {
            DogNamespace.BreedType.Labrador,
            DogNamespace.BreedType.Beagle,
            DogNamespace.BreedType.Bulldog,
            DogNamespace.BreedType.GermanShepherd,
            DogNamespace.BreedType.GoldenRetriever,
            DogNamespace.BreedType.Poodle,
            DogNamespace.BreedType.Rottweiler,
            DogNamespace.BreedType.Unknown});
            this.BreedComboBox.Location = new System.Drawing.Point(115, 30);
            this.BreedComboBox.Name = "BreedComboBox";
            this.BreedComboBox.Size = new System.Drawing.Size(180, 21);
            this.BreedComboBox.TabIndex = 1;
            // 
            // EyeColorLabel
            // 
            this.EyeColorLabel.Location = new System.Drawing.Point(10, 70);
            this.EyeColorLabel.Name = "EyeColorLabel";
            this.EyeColorLabel.Size = new System.Drawing.Size(100, 23);
            this.EyeColorLabel.TabIndex = 2;
            this.EyeColorLabel.Text = "Eye Color";
            // 
            // EyeColorComboBox
            // 
            this.EyeColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EyeColorComboBox.Items.AddRange(new object[] {
            DogNamespace.EyeColor.Brown,
            DogNamespace.EyeColor.Blue,
            DogNamespace.EyeColor.Green,
            DogNamespace.EyeColor.Amber,
            DogNamespace.EyeColor.Hazel,
            DogNamespace.EyeColor.Mixed,
            DogNamespace.EyeColor.Unknown});
            this.EyeColorComboBox.Location = new System.Drawing.Point(115, 70);
            this.EyeColorComboBox.Name = "EyeColorComboBox";
            this.EyeColorComboBox.Size = new System.Drawing.Size(180, 21);
            this.EyeColorComboBox.TabIndex = 3;
            // 
            // SexLabel
            // 
            this.SexLabel.Location = new System.Drawing.Point(10, 110);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(100, 23);
            this.SexLabel.TabIndex = 4;
            this.SexLabel.Text = "Sex";
            // 
            // SexComboBox
            // 
            this.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexComboBox.Items.AddRange(new object[] {
            DogNamespace.SexType.MALE,
            DogNamespace.SexType.FEMALE,
            DogNamespace.SexType.Unknown});
            this.SexComboBox.Location = new System.Drawing.Point(115, 110);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(180, 21);
            this.SexComboBox.TabIndex = 5;
            // 
            // VaccinatedLabel
            // 
            this.VaccinatedLabel.Location = new System.Drawing.Point(10, 150);
            this.VaccinatedLabel.Name = "VaccinatedLabel";
            this.VaccinatedLabel.Size = new System.Drawing.Size(100, 23);
            this.VaccinatedLabel.TabIndex = 6;
            this.VaccinatedLabel.Text = "Vaccinated";
            // 
            // VaccinatedCheckBox
            // 
            this.VaccinatedCheckBox.Location = new System.Drawing.Point(115, 150);
            this.VaccinatedCheckBox.Name = "VaccinatedCheckBox";
            this.VaccinatedCheckBox.Size = new System.Drawing.Size(180, 20);
            this.VaccinatedCheckBox.TabIndex = 7;
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.Location = new System.Drawing.Point(10, 190);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(100, 23);
            this.BirthDateLabel.TabIndex = 8;
            this.BirthDateLabel.Text = "Birth Date";
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(115, 190);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(180, 20);
            this.BirthDatePicker.TabIndex = 9;
            // 
            // TextBoxErrorProvider
            // 
            this.TextBoxErrorProvider.ContainerControl = this;
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(642, 25);
            this.toolBar.TabIndex = 2;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Save";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Save As";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Open";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 400);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(642, 22);
            this.statusBar.TabIndex = 3;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "File Path:";
            // 
            // contextMenu
            // 
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripComboBox
            // 
            this.toolStripComboBox.Items.AddRange(new object[] {
            "Option 1",
            "Option 2",
            "Option 3"});
            this.toolStripComboBox.Name = "toolStripComboBox";
            this.toolStripComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripTextBox
            // 
            this.toolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox.Name = "toolStripTextBox";
            this.toolStripTextBox.Size = new System.Drawing.Size(150, 23);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.windowToolStripMenuItem.Text = "Window";
            this.windowToolStripMenuItem.Click += new System.EventHandler(this.windowToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inNewWindowToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // inNewWindowToolStripMenuItem
            // 
            this.inNewWindowToolStripMenuItem.Name = "inNewWindowToolStripMenuItem";
            this.inNewWindowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inNewWindowToolStripMenuItem.Text = "In new window";
            this.inNewWindowToolStripMenuItem.Click += new System.EventHandler(this.inNewWindowToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(642, 422);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DogDetailsGroupBox);
            this.Controls.Add(this.BirthDetailsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMain";
            this.Text = "Dog Details Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing_1);
            this.DogDetailsGroupBox.ResumeLayout(false);
            this.DogDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).EndInit();
            this.BirthDetailsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxErrorProvider)).EndInit();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

}

        private System.ComponentModel.IContainer components;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem inNewWindowToolStripMenuItem;
    }

}