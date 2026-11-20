using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricCalculator
{
    /// <summary>
    /// Contains the methods for the Geometric Calculator application, allowing users to calculate volumes and surface areas of various geometric bodies.
    /// </summary>
    public partial class Form1 : Form
    {
        //Store the calculated geometric bodies in a list for later statistics
        private readonly List<IGeometricBody> _calculatedBodies = new List<IGeometricBody>();

        /// <summary>
        ///  Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            UpdateUIForSelectedShape(); // Initialize the UI based on the default selected shape
        }

        /// <summary>
        /// Checks the selected geometric shape's dimensions and creates the corresponding geometric body object, then adds it to the results ListBox and the geometric bodies list in the code.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblPrimaryError.Text = string.Empty;
            lblHeightError.Text = string.Empty;

            bool isPrimaryValid = ValidateDimensionValue(txtPrimary.Text, lblPrimaryError, out double primaryValue);

            bool isHeightValid = true;
            double height = 0;

            if(!rbSphere.Checked) // Height is not needed for Sphere
            {
                isHeightValid = ValidateDimensionValue(txtHeight.Text, lblHeightError, out height);
            }

            if(!isPrimaryValid || !isHeightValid)
            {
                MessageBox.Show("Please correct the input errors before calculating.", "Input Error", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            IGeometricBody body = CreateGeometricBody(primaryValue, height);

            if(body != null)
            {
                _calculatedBodies.Add(body); // Store the calculated body for statistics
                string result = Formatter.FormatResult(body, chkRound.Checked);
                lstResults.Items.Add(result);
            }
            else
            {
                MessageBox.Show("Please select a geometric shape.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Creates a geometric body based on the selected shape and dimension values.
        /// </summary>
        /// <param name="primaryValue">The primary dimension value.</param>
        /// <param name="height">The height dimension value.</param>
        /// <returns>The created geometric body or null if the shape is not supported.</returns>
        private IGeometricBody CreateGeometricBody(double primaryValue, double height)
        {
            if (rbSphere.Checked)
            {
                return new Sphere(primaryValue);
            }
            else if (rbCylinder.Checked)
            {
                return new Cylinder(primaryValue, height);
            }
            else if (rbCone.Checked)
            {
                return new Cone(primaryValue, height);
            }
            else if (rbPyramid.Checked)
            {
                return new SquarePyramid(primaryValue, height);
            }
            return null; // This should never happen if the UI is set up correctly

        }

        /// <summary>
        /// Validates a dimension value entered by the user.
        /// </summary>
        /// <param name="input">The input string to validate.</param>
        /// <param name="errorLabel">The label to display validation errors.</param>
        /// <param name="value">The parsed double value if validation is successful.</param>
        /// <returns>True if the value is valid, false otherwise.</returns>
        private bool ValidateDimensionValue(string input, Label errorLabel, out double value)
        {
            value = 0;
            try
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new FormatException("Input cannot be empty.");
                }

                value = double.Parse(input.Trim());

                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Value must be greater than zero.");
                }

                return true;
            }
            catch (FormatException)
            {
                errorLabel.Text = "Please enter a valid number.";
                return false;
            }
            catch(OverflowException)
            {
                errorLabel.Text = "The number entered is too large or too small.";
                return false;
            }
            catch (ArgumentOutOfRangeException)
            {
                errorLabel.Text = "Please enter a valid number greater than zero.";
                return false;
            }
        }

        /// <summary>
        /// Handles the click event for the Statistics button.
        /// Displays the total number of calculated geometric bodies, the average volume, and the maximum volume among them.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStats_Click(object sender, EventArgs e)
        {
            if(_calculatedBodies.Count == 0)
            {
                MessageBox.Show("No geometric bodies have been calculated yet.", "Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int count = _calculatedBodies.Count;

            double totalVolume = 0;
            double maxVolume = double.MinValue;

            foreach(var body in _calculatedBodies)
            {
                double volume = body.CalculateVolume();
                totalVolume += volume;
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                }
            }

            double averageVolume = totalVolume / count;

            lblStats.Text = $"Total Bodies: {count}, Average Volume: {averageVolume:F2}, Max Volume: {maxVolume:F2}";
        }

        /// <summary>
        /// Clears all input fields and resets the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPrimary.Clear();
            txtHeight.Clear();
            lblPrimaryError.Text = string.Empty;
            lblHeightError.Text = string.Empty;
            lblStats.Text = string.Empty;

            lstResults.Items.Clear();
            _calculatedBodies.Clear();

            rbSphere.Checked = true; // Reset to default shape
            UpdateUIForSelectedShape(); // Update the UI for the default shape
            txtPrimary.Focus();
        }

        /// <summary>
        /// Closes the application when the Close button is clicked.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // <summary>
        // This method is called when any of the radio buttons is checked or unchecked.
        /// Updates the UI based on the selected geometric 3D shape.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Only act on the radio button that was just checked (not unchecked)
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                UpdateUIForSelectedShape();
            }
        }

        /// <summary>
        /// Synchronizes input labels, enables states, and clears error messages based on the selected shape.
        /// </summary>
        private void UpdateUIForSelectedShape()
        {
            // Update the UI based on the selected shape
            lblPrimaryError.Text = string.Empty;
            lblHeightError.Text = string.Empty;

            if(rbSphere.Checked)
            {
                lblPrimary.Text = "Radius (r):";
                txtHeight.Enabled = false;
                txtHeight.Clear();
            }
            else if (rbCylinder.Checked)
            {
                lblPrimary.Text = "Radius (r):";
                txtHeight.Enabled = true;
            }
            else if (rbCone.Checked)
            {
                lblPrimary.Text = "Radius (r):";
                txtHeight.Enabled = true;
            }
            else if (rbPyramid.Checked)
            {
                lblPrimary.Text = "Base Side Length (a) :";
                txtHeight.Enabled = true;
            }
        }
    }
}