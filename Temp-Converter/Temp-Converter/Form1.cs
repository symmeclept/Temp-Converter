using System;
using System.Windows.Forms;
using System.Diagnostics;


namespace Temp_Converter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//Convert C to F
		double convertCelsius(double dblIn)
		{
			double dblOut = (dblIn * 1.8) + 32;
			return dblOut;
		}

		// Convert F to C
		double convertFarenheit(double dblIn)
		{
			double dblOut = (dblIn - 32) / 1.8;
			return dblOut;
		}

		// Convert F to K
		double convertKelvin(double dblIn)
		{
			double dblOut = (dblIn + 459.67) * 5 / 9;
			return dblOut;
		}

		// Reset the form
		void resetAllForms()
		{
			txtTempIn.Text = "";
			lblTempOut.Text = "...";
			cmbTypeIn.SelectedIndex = -1;
			cmbTypeOut.SelectedIndex = -1;

		}

		// Button Click to do conversion
		private void button1_Click(object sender, EventArgs e)
		{
			// User functions and variables ------------------->
			string sIn = txtTempIn.Text;
			double dblTempIn = 0.0;
			double dblTempOut = 0.0;
			int intTypeIn = 0;
			int intTypeOut = 0;

			try //...to maintain sanity.
			{
				// Validate input number
				if (double.TryParse(sIn, out dblTempIn))
				{
					intTypeIn = cmbTypeIn.SelectedIndex;
					intTypeOut = cmbTypeOut.SelectedIndex;
					if (intTypeIn <= -1 || intTypeOut <= -1)
					{
						MessageBox.Show("Please select conversions types.");
					}
					else if (intTypeIn == intTypeOut)
					{
						MessageBox.Show("Same types.");
					}
					else if (intTypeIn >= 0 && intTypeOut >= 0)
					{
						// All good, now convert
						if (intTypeIn == 0) //C ->
						{
							if (intTypeOut == 1) //F
							{
								dblTempOut = convertFarenheit(dblTempIn);
							}
							else if (intTypeOut == 2) //K
							{
								dblTempOut = dblTempIn + 273.15;
							}
						}

						else if (intTypeIn == 1) //F ->
						{
							if (intTypeOut == 0) //C
							{
								dblTempOut = convertCelsius(dblTempIn);
							}
							else if (intTypeOut == 2) //K
							{
								dblTempOut = convertKelvin(dblTempIn);
							}
						}

						else if (intTypeIn == 2) //K ->
						{
							if (intTypeOut == 0) //C
							{
								dblTempOut = (dblTempIn - 273.15);
							}
							else if (intTypeOut == 1) //F
							{
								dblTempOut = dblTempIn * 9;
								dblTempOut = dblTempOut / 5;
								dblTempOut = dblTempOut - 459.67;
							}

						}
					}
					else
					{
						MessageBox.Show("Something went wrong!");
					}
					// DEBUG
					MessageBox.Show("Index1: " + intTypeIn + "\nIndex2: "
									+ intTypeOut + "\nTemp: " + dblTempOut);
					//------Show your work!-------------------
					//
					string sOut = "";
					sOut = String.Format("{0:0.00}", dblTempOut);
					lblTempOut.Text = sOut;
				}
				else
				{
					// Invalid number
					MessageBox.Show("Please enter a number.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something went wrong!\nException: " + ex.Message);
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			resetAllForms();
		}
	}
}
