﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DogNamespace;
using System.Net;

namespace Dog
{
    public partial class FormMain : Form
    {
        private Models.Dog dog = new Models.Dog();

        public FormMain(bool hide = true)
        {
            InitializeComponent();
            this.AutoScroll = true;
            if (hide)
            {
                foreach (Control i in this.Controls)
                {
                    i.Visible = false;
                }
                menuStrip1.Visible = true;
                this.IsMdiContainer = true;
                this.saveToolStripMenuItem.Enabled = false;
                this.saveToolStripMenuItem.Visible = false;
                this.saveAsToolStripMenuItem.Enabled = false;
                this.saveAsToolStripMenuItem.Visible = false;
                this.openToolStripMenuItem.Enabled = false;
                this.openToolStripMenuItem.Visible = false;
            }
        }

        private void NameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (NameTextBox.Text.Length == 0)
            {
                TextBoxErrorProvider.SetError(NameTextBox, "This field cannot be empty");
            }
            else
            {
                TextBoxErrorProvider.SetError(NameTextBox, "");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool validated = true;
            Control[] objects = { NameTextBox, ColorTextBox, OwnerNameTextBox };

            foreach (Control obj in objects)
            {
                if (obj.Text.Length == 0)
                {
                    MessageBox.Show(obj.Name + " cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validated = false;
                }
            }

            if (validated)
            {
                dog.Name = NameTextBox.Text;
                dog.Weight = (double)WeightNumericUpDown.Value;
                dog.Breed = (BreedType)BreedComboBox.SelectedItem;
                dog.IsVaccinated = VaccinatedCheckBox.Checked;
                dog.BirthDate = BirthDatePicker.Value;
                dog.Color = ColorTextBox.Text;
                dog.Height = (float)HeightNumericUpDown.Value;
                dog.OwnerName = OwnerNameTextBox.Text;
                dog.EyeColor = (EyeColor)EyeColorComboBox.SelectedItem;
                dog.SexType = (SexType)SexComboBox.SelectedItem;

                if (SaveObject())
                {
                    MessageBox.Show("Object Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error Saving Object", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool SaveObject()
        {
            string jsonString = JsonConvert.SerializeObject(dog);
            if (File.Exists("data.json"))
            {
                using (StreamWriter sw = new StreamWriter("data.json", append: true))
                {
                    sw.WriteLine(jsonString);
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("data.json"))
                {
                    sw.WriteLine(jsonString);
                }
            }

            return true;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("data.json"))
            {
                List<string> lines = new List<string>(File.ReadAllLines("data.json"));

                if (lines.Count > 0)
                {
                    // Deserialize the last dog object from the file
                    Models.Dog dog = JsonConvert.DeserializeObject<Models.Dog>(lines.Last());

                    // Show message box with dog information
                    DialogResult result = MessageBox.Show(dog.ToString(), "Loaded Dog", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information);

                    // If OK is pressed, populate input fields with dog data
                    if (result == DialogResult.OK)
                    {
                        // Set input elements with the dog object fields
                        NameTextBox.Text = dog.Name;
                        ColorTextBox.Text = dog.Color;
                        OwnerNameTextBox.Text = dog.OwnerName;
                        // Set other fields as necessary
                        WeightNumericUpDown.Value = (decimal)dog.Weight;
                        BreedComboBox.SelectedItem = dog.Breed; // Assuming BreedType is already set in the ComboBox
                        VaccinatedCheckBox.Checked = dog.IsVaccinated;
                        BirthDatePicker.Value = dog.BirthDate;
                        HeightNumericUpDown.Value = (decimal)dog.Height;
                        EyeColorComboBox.SelectedItem = dog.EyeColor; // Assuming EyeColor enum is set in the ComboBox
                        SexComboBox.SelectedItem = dog.SexType; // Assuming Sex enum is set in the ComboBox
                    }
                    // If Cancel is pressed, do nothing (i.e., don't populate the input elements)
                    else
                    {
                        // Optionally, handle the cancel case if needed (e.g., show a message or log the cancellation)
                    }
                }
                else
                {
                    MessageBox.Show("No data in file", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No data file found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.MdiFormClosing)
                return;

            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new FormMain(false);
            newForm.TopLevel = true;
            newForm.MdiParent = this;
            newForm.MaximizeBox = false;
            newForm.MinimizeBox = false;
            newForm.menuStrip1.AllowMerge = false;
            newForm.newToolStripMenuItem.Enabled = false;
            newForm.windowToolStripMenuItem.Enabled = false;
            newForm.newToolStripMenuItem.Visible = false;
            newForm.windowToolStripMenuItem.Visible = false;
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            newForm.Show();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
    }
}