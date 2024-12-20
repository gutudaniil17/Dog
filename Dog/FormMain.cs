using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DogNamespace;

namespace Dog
{
    public partial class FormMain : Form
    {
        private Models.Dog dog = new Models.Dog();
        private string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\data.json";

        public FormMain()
        {
            InitializeComponent();
            BreedComboBox.SelectedIndex = 0;
            EyeColorComboBox.SelectedIndex = 0;
            SexComboBox.SelectedIndex = 0;
            toolStripStatusLabel1.Text = "Current Path: " + filePath;
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
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new FormMain();
            newForm.Show();
        }

        private void FormMain_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Warning",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                e.Cancel = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToFile();
            MessageBox.Show("File saved", "Info",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }

        private void saveToFile()
        {
            Models.Dog entity = new Models.Dog();
            entity.Name = NameTextBox.Text;
            entity.Color = ColorTextBox.Text;
            entity.OwnerName = OwnerNameTextBox.Text;
            dog.Weight = (double)WeightNumericUpDown.Value;
            dog.Height = (float)HeightNumericUpDown.Value;
            dog.Breed = (BreedType)BreedComboBox.SelectedItem;
            dog.EyeColor = (EyeColor)EyeColorComboBox.SelectedItem;
            dog.SexType = (SexType)SexComboBox.SelectedItem;
            dog.IsVaccinated = VaccinatedCheckBox.Checked;
            dog.BirthDate = BirthDatePicker.Value;
            var json = JsonConvert.SerializeObject(entity);
            File.WriteAllText(this.filePath, json);
        }

        private void saveAs()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Choose File",
                Filter = "JSON File (*.json)|*.json",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                CheckFileExists = false,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                this.filePath = filePath;
                Models.Dog entity = new Models.Dog();
                entity.Name = NameTextBox.Text;
                entity.Color = ColorTextBox.Text;
                entity.OwnerName = OwnerNameTextBox.Text;
                dog.Weight = (double)WeightNumericUpDown.Value;
                dog.Height = (float)HeightNumericUpDown.Value;
                dog.Breed = (BreedType)BreedComboBox.SelectedItem;
                dog.EyeColor = (EyeColor)EyeColorComboBox.SelectedItem;
                dog.SexType = (SexType)SexComboBox.SelectedItem;
                dog.IsVaccinated = VaccinatedCheckBox.Checked;
                dog.BirthDate = BirthDatePicker.Value;

                var json = JsonConvert.SerializeObject(entity);
                File.WriteAllText(this.filePath, json);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            saveToFile();
            MessageBox.Show("File saved", "Info",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
            MessageBox.Show("File saved", "Info",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            saveAs();
            MessageBox.Show("File saved", "Info",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Close();
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Choose File",
                Filter = "JSON File (*.json)|*.json",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File does not exist", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string jsonContent = File.ReadAllText(filePath);
                var entity = JsonConvert.DeserializeObject<Models.Dog>(jsonContent);
                if (entity == null)
                {
                    MessageBox.Show("File is empty", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NameTextBox.Text = dog.Name;
                ColorTextBox.Text = dog.Color;
                OwnerNameTextBox.Text = dog.OwnerName;
                WeightNumericUpDown.Value = (decimal)dog.Weight;
                HeightNumericUpDown.Value = (decimal)dog.Height;
                BreedComboBox.SelectedItem = dog.Breed;
                EyeColorComboBox.SelectedItem = dog.EyeColor;
                SexComboBox.SelectedItem = dog.SexType;
                VaccinatedCheckBox.Checked = dog.IsVaccinated;
                this.filePath = filePath;
                toolStripStatusLabel1.Text = "File Path: " + filePath;

                try
                {
                    BirthDatePicker.Value = dog.BirthDate;
                }
                catch (Exception ex)
                {
                    BirthDatePicker.Value = BirthDatePicker.MinDate;
                }
            }
        }

        private void inNewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.DropDown.Close();
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Choose File",
                Filter = "JSON File (*.json)|*.json",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File does not exist", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string jsonContent = File.ReadAllText(filePath);
                var entity = JsonConvert.DeserializeObject<Models.Dog>(jsonContent);
                if (entity == null)
                {
                    MessageBox.Show("File is empty", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newForm = new FormMain();
                newForm.NameTextBox.Text = dog.Name;
                newForm.ColorTextBox.Text = dog.Color;
                newForm.OwnerNameTextBox.Text = dog.OwnerName;
                newForm.WeightNumericUpDown.Value = (decimal)dog.Weight;
                newForm.HeightNumericUpDown.Value = (decimal)dog.Height;
                newForm.BreedComboBox.SelectedItem = dog.Breed;
                newForm.EyeColorComboBox.SelectedItem = dog.EyeColor;
                newForm.SexComboBox.SelectedItem = dog.SexType;
                newForm.VaccinatedCheckBox.Checked = dog.IsVaccinated;
                newForm.filePath = filePath;
                newForm.toolStripStatusLabel1.Text = "File Path: " + filePath;

                try
                {
                    newForm.BirthDatePicker.Value = dog.BirthDate;
                }
                catch (Exception ex)
                {
                    newForm.BirthDatePicker.Value = BirthDatePicker.MinDate;
                }
                newForm.Show();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Choose File",
                Filter = "JSON File (*.json)|*.json",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File does not exist", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string jsonContent = File.ReadAllText(filePath);
                var entity = JsonConvert.DeserializeObject<Models.Dog>(jsonContent);
                if (entity == null)
                {
                    MessageBox.Show("File is empty", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NameTextBox.Text = dog.Name;
                ColorTextBox.Text = dog.Color;
                OwnerNameTextBox.Text = dog.OwnerName;
                WeightNumericUpDown.Value = (decimal)dog.Weight;
                HeightNumericUpDown.Value = (decimal)dog.Height;
                BreedComboBox.SelectedItem = dog.Breed;
                EyeColorComboBox.SelectedItem = dog.EyeColor;
                SexComboBox.SelectedItem = dog.SexType;
                VaccinatedCheckBox.Checked = dog.IsVaccinated;
                this.filePath = filePath;
                toolStripStatusLabel1.Text = "File Path: " + filePath;

                try
                {
                    BirthDatePicker.Value = dog.BirthDate;
                }
                catch (Exception ex)
                {
                    BirthDatePicker.Value = BirthDatePicker.MinDate;
                }
            }
        }
    }
}