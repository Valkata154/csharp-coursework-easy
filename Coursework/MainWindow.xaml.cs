using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Coursework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Adding all the countries to the combobox
            string[] Lines = File.ReadAllLines("C:/Users/valka/source/repos/Coursework/Coursework/Countries.txt");
            foreach (string Line in Lines)
                countryComboBox.Items.Add(Line);
        }


        private void Validate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // First Name Validation
                if (String.IsNullOrEmpty(firstNameTextBox.Text))
                {
                    throw new System.ArgumentException("First Name can't be blank!");
                }

                // Surname Validation
                if (String.IsNullOrEmpty(surnameTextBox.Text))
                {
                    throw new System.ArgumentException("Surname can't be blank!");
                }

                // Age Validation  
                if (ageTextBox.Text == "")
                {
                    throw new System.ArgumentException("Age can't be blank!");
                }
                else
                {
                    int studentAge;
                    bool convert = int.TryParse(ageTextBox.Text, out studentAge);
                    if (convert == false)
                    {
                        throw new System.ArgumentException("Age must be string!");
                    }
                    else
                    {
                        if (studentAge < 16 || studentAge > 101)
                        {
                            throw new System.ArgumentException("Age must be between 16 and 101 years!");
                        }
                    }
                }

                // Course Validation
                if (String.IsNullOrEmpty(courseCombobox.Text))
                {
                    throw new System.ArgumentException("Course can't be blank!");
                }

                // Address 1 Validation
                if (String.IsNullOrEmpty(address1TextBox.Text))
                {
                    throw new System.ArgumentException("Address 1 can't be blank!");
                }

                // City Validation
                if (String.IsNullOrEmpty(cityTextBox.Text))
                {
                    throw new System.ArgumentException("City can't be blank!");
                }

                // Postcode Validation
                if (String.IsNullOrEmpty(postcodeTextBox.Text))
                {
                    throw new System.ArgumentException("Postcode can't be blank!");
                }

                // Email Validation
                Regex rgx = new Regex("[A-Za-z0-9]");

                if (String.IsNullOrEmpty(emailTextBox.Text))
                {
                    throw new System.ArgumentException("Email can't be blank!");
                }
                else
                {
                    // Check for @
                    if (!(emailTextBox.Text.Contains("@")))
                    {
                        throw new System.ArgumentException("Email must contain @!");
                    }
                    // Check for A-Za-z0-9 in first and last letter

                    int length = emailTextBox.Text.Length - 1;
                    if (!(Regex.IsMatch(emailTextBox.Text[0].ToString(), @"^[a-zA-Z0-9]+$")))
                    {
                        throw new System.ArgumentException("Email first letter must be from A-Z, a-z or 0-9!");
                    }
                    else if (!(Regex.IsMatch(emailTextBox.Text[length].ToString(), @"^[a-zA-Z0-9]+$")))
                    {
                        throw new System.ArgumentException("Email last letter must be from A-Z, a-z or 0-9!");
                    }
                }

                // Checkboxes Validation
                if (yesCheckBox.IsChecked == false && noCheckBox.IsChecked == false)
                {
                    throw new System.ArgumentException("Checkboxes must be checked!");
                }

                // Country Validation
                if (yesCheckBox.IsChecked == true)
                {
                    if (countryComboBox.Text == "")
                    {
                        throw new System.ArgumentException("Country must be selected!");
                    }
                }

                // Success Message
                MessageBox.Show("Validated Successfully!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Clearing all the input data
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            firstNameTextBox.Text = "";
            surnameTextBox.Text = "";
            ageTextBox.Text = "";
            courseCombobox.Text = "";
            address1TextBox.Text = "";
            address2TextBox.Text = "";
            cityTextBox.Text = "";
            postcodeTextBox.Text = "";
            emailTextBox.Text = "";
            yesCheckBox.IsChecked = false;
            noCheckBox.IsChecked = false;
            countryComboBox.Text = "";
        }

        private void YesCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // Unchecking noCheckBox when yesCheckBox is checked
            if (yesCheckBox.IsChecked == true)
            {
                noCheckBox.IsChecked = false;
            }
            // Showing country combobox and label if Yes is checked.
            countryComboBox.Visibility = Visibility.Visible;
            countryLbl.Visibility = Visibility.Visible;   
        }

        private void YesCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            // Hiding country combobox and label if No is checked.
            countryComboBox.Visibility = Visibility.Hidden;
            countryLbl.Visibility = Visibility.Hidden;
        }

        // Unchecking yesCheckBox when noCheckBox is checked
        private void NoCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (noCheckBox.IsChecked == true)
            {
                yesCheckBox.IsChecked = false;
                countryComboBox.Text = "";
            }
        }
    }
}
