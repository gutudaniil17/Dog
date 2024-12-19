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
        private Button SaveButton;
        private Button LoadButton;
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
        private System.Windows.Forms.GroupBox ActionsGroupBox;
        
        private MenuStrip mainMenuStrip;
        private ToolStrip toolBar;
        private StatusStrip statusBar;
        private ContextMenuStrip contextMenu;
        private ToolStripProgressBar toolStripProgressBar;
        private ToolStripButton toolStripSaveButton;
        private ToolStripButton toolStripLoadButton;
        private ToolStripButton toolStripDeleteButton;
        private ToolStripLabel toolStripStatusLabel;
        private ToolStripComboBox toolStripComboBox;
        private ToolStripTextBox toolStripTextBox;


        private void InitializeComponent()
{
    // Initialize controls and GroupBoxes
    this.DogDetailsGroupBox = new System.Windows.Forms.GroupBox();
    this.BirthDetailsGroupBox = new System.Windows.Forms.GroupBox();
    this.ActionsGroupBox = new System.Windows.Forms.GroupBox();

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
    this.SaveButton = new System.Windows.Forms.Button();
    this.LoadButton = new System.Windows.Forms.Button();
    this.TextBoxErrorProvider = new System.Windows.Forms.ErrorProvider();
    
    this.mainMenuStrip = new MenuStrip();
    this.toolBar = new ToolStrip();
    this.statusBar = new StatusStrip();
    this.contextMenu = new ContextMenuStrip();
    this.toolStripProgressBar = new ToolStripProgressBar();
    this.toolStripSaveButton = new ToolStripButton();
    this.toolStripLoadButton = new ToolStripButton();
    this.toolStripDeleteButton = new ToolStripButton();
    this.toolStripStatusLabel = new ToolStripLabel();
    this.toolStripComboBox = new ToolStripComboBox();
    this.toolStripTextBox = new ToolStripTextBox();

    // MainMenu
    ToolStripMenuItem fileMenuItem = new ToolStripMenuItem("File");
    ToolStripMenuItem createMenuItem = new ToolStripMenuItem("Create");
    ToolStripMenuItem saveMenuItem = new ToolStripMenuItem("Save");
    ToolStripMenuItem loadMenuItem = new ToolStripMenuItem("Load");
    ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");
    ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit");

    fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createMenuItem, saveMenuItem, loadMenuItem, deleteMenuItem, new ToolStripSeparator(), exitMenuItem });
    this.mainMenuStrip.Items.Add(fileMenuItem);

    // ToolBar
    this.toolStripSaveButton.Text = "Save";
    // this.toolStripSaveButton.Click += ToolStripSaveButton_Click;

    this.toolStripLoadButton.Text = "Load";
    // this.toolStripLoadButton.Click += ToolStripLoadButton_Click;

    this.toolStripDeleteButton.Text = "Delete";
    // this.toolStripDeleteButton.Click += ToolStripDeleteButton_Click;

    this.toolBar.Items.AddRange(new ToolStripItem[] { this.toolStripSaveButton, this.toolStripLoadButton, this.toolStripDeleteButton });

    // StatusBar
    this.toolStripStatusLabel.Text = "Ready";
    this.statusBar.Items.Add(this.toolStripStatusLabel);
    this.statusBar.Items.Add(this.toolStripProgressBar);

    // ContextMenu
    // this.contextMenu.Items.Add("Create", null, CreateMenuItem_Click);
    // this.contextMenu.Items.Add("Save", null, SaveMenuItem_Click);
    // this.contextMenu.Items.Add("Load", null, LoadMenuItem_Click);
    // this.contextMenu.Items.Add("Delete", null, DeleteMenuItem_Click);
    // this.contextMenu.Items.Add(new ToolStripSeparator());
    // this.contextMenu.Items.Add("Exit", null, ExitMenuItem_Click);
    // // Mouse Event Handlers
    // this.MouseMove += MainForm_MouseMove;
    // this.MouseDown += MainForm_MouseDown;
    // this.MouseUp += MainForm_MouseUp;
    // this.MouseClick += MainForm_MouseClick;
    // this.MouseDoubleClick += MainForm_MouseDoubleClick;
    // this.MouseWheel += MainForm_MouseWheel;
    // this.MouseEnter += MainForm_MouseEnter;
    // this.MouseLeave += MainForm_MouseLeave;
    // this.MouseHover += MainForm_MouseHover;

    // ToolStrip ComboBox
    this.toolStripComboBox.Items.AddRange(new object[] { "Option 1", "Option 2", "Option 3" });

    // ToolStrip TextBox
    this.toolStripTextBox.Width = 150;

    // Setting up GroupBoxes
    this.DogDetailsGroupBox.Text = "Dog Details";
    this.DogDetailsGroupBox.Location = new System.Drawing.Point(20, 50); // Adjusted to leave space for the MenuStrip
    this.DogDetailsGroupBox.Size = new System.Drawing.Size(300, 350);

    this.BirthDetailsGroupBox.Text = "Birth and Other Info";
    this.BirthDetailsGroupBox.Location = new System.Drawing.Point(350, 50); // Adjusted to leave space for the MenuStrip
    this.BirthDetailsGroupBox.Size = new System.Drawing.Size(300, 350);

    this.ActionsGroupBox.Text = "Actions";
    this.ActionsGroupBox.Location = new System.Drawing.Point(20, 400);
    this.ActionsGroupBox.Size = new System.Drawing.Size(630, 80);

    // DogDetails GroupBox (Name, Color, OwnerName, Weight, Height)
    this.NameLabel.Location = new System.Drawing.Point(10, 30);
    this.NameLabel.Text = "Name";
    this.NameTextBox.Location = new System.Drawing.Point(115, 30);  // Moved 10px to the right
    this.NameTextBox.Size = new System.Drawing.Size(180, 20);
    this.NameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameTextBox_Validating); // Link Validating event

    this.ColorLabel.Location = new System.Drawing.Point(10, 70);
    this.ColorLabel.Text = "Color";
    this.ColorTextBox.Location = new System.Drawing.Point(115, 70);  // Moved 10px to the right
    this.ColorTextBox.Size = new System.Drawing.Size(180, 20);

    this.OwnerNameLabel.Location = new System.Drawing.Point(10, 110);
    this.OwnerNameLabel.Text = "Owner Name";
    this.OwnerNameTextBox.Location = new System.Drawing.Point(115, 110);  // Moved 10px to the right
    this.OwnerNameTextBox.Size = new System.Drawing.Size(180, 20);

    this.WeightLabel.Location = new System.Drawing.Point(10, 150);
    this.WeightLabel.Text = "Weight";
    this.WeightNumericUpDown.Location = new System.Drawing.Point(115, 150);  // Moved 10px to the right
    this.WeightNumericUpDown.Size = new System.Drawing.Size(180, 20);

    this.HeightLabel.Location = new System.Drawing.Point(10, 190);
    this.HeightLabel.Text = "Height";
    this.HeightNumericUpDown.Location = new System.Drawing.Point(115, 190);  // Moved 10px to the right
    this.HeightNumericUpDown.Size = new System.Drawing.Size(180, 20);

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

    // BirthDetails GroupBox (Breed, Eye Color, Sex, Vaccinated, Birth Date)
    this.BreedLabel.Location = new System.Drawing.Point(10, 30);
    this.BreedLabel.Text = "Breed";
    this.BreedComboBox.Location = new System.Drawing.Point(115, 30);  // Moved 10px to the right
    this.BreedComboBox.Size = new System.Drawing.Size(180, 20);
    this.BreedComboBox.DataSource = Enum.GetValues(typeof(BreedType));

    this.EyeColorLabel.Location = new System.Drawing.Point(10, 70);
    this.EyeColorLabel.Text = "Eye Color";
    this.EyeColorComboBox.Location = new System.Drawing.Point(115, 70);  // Moved 10px to the right
    this.EyeColorComboBox.Size = new System.Drawing.Size(180, 20);
    this.EyeColorComboBox.DataSource = Enum.GetValues(typeof(EyeColor));

    this.SexLabel.Location = new System.Drawing.Point(10, 110);
    this.SexLabel.Text = "Sex";
    this.SexComboBox.Location = new System.Drawing.Point(115, 110);  // Moved 10px to the right
    this.SexComboBox.Size = new System.Drawing.Size(180, 20);
    this.SexComboBox.DataSource = Enum.GetValues(typeof(SexType));

    this.VaccinatedLabel.Location = new System.Drawing.Point(10, 150);
    this.VaccinatedLabel.Text = "Vaccinated";
    this.VaccinatedCheckBox.Location = new System.Drawing.Point(115, 150);  // Moved 10px to the right
    this.VaccinatedCheckBox.Size = new System.Drawing.Size(180, 20);

    this.BirthDateLabel.Location = new System.Drawing.Point(10, 190);
    this.BirthDateLabel.Text = "Birth Date";
    this.BirthDatePicker.Location = new System.Drawing.Point(115, 190);  // Moved 10px to the right
    this.BirthDatePicker.Size = new System.Drawing.Size(180, 20);

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

    // Actions GroupBox (Buttons for Save, Load)
    this.SaveButton.Text = "Save";
    this.SaveButton.Click += new EventHandler(this.SaveButton_Click);

    this.LoadButton.Text = "Load";
    this.LoadButton.Click += new EventHandler(this.LoadButton_Click);

    this.ActionsGroupBox.Controls.Add(this.SaveButton);
    this.ActionsGroupBox.Controls.Add(this.LoadButton);

    // Form settings
    this.Controls.Add(this.mainMenuStrip);
    this.Controls.Add(this.toolBar);
    this.Controls.Add(this.statusBar);
    this.Controls.Add(this.DogDetailsGroupBox);
    this.Controls.Add(this.BirthDetailsGroupBox);
    this.Controls.Add(this.ActionsGroupBox);
    this.MainMenuStrip = this.mainMenuStrip;
    this.Text = "Dog Details Form";
    this.Size = new System.Drawing.Size(700, 550);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
}





    }

}