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

		// User functions and variables ------------------->
		double dblTempIn = 0.0;
		double dblTempOut = 0.0;
		int intTypeIn = 0;
		int intTypeOut = 0;

		//Convert C to F
		double convertCelsius(double dblIn)
		{
			double dblOut = 0.0;
			return dblOut;
		}

		// Convert F to C
		double convertFarenheit(double dblIn)
		{
			double dblOut = 0.0;
			return dblOut;
		}

		// Convert F to K
		double convertKelvin(double dblIn)
		{
			double dblOut = 0.0;
			return dblOut;
		}

		// Button Click to do conversion
		private void button1_Click(object sender, EventArgs e)
		{
			try //...to maintain sanity.
			{
				// Validate input number
				if (double.TryParse(txtTempIn.Text, out dblTempIn))
				{
					intTypeIn = cmbTypeIn.SelectedIndex;
					intTypeOut = cmbTypeOut.SelectedIndex;
					if (intTypeIn < 0 || intTypeOut < 0)
					{
						MessageBox.Show("Please select conversions types.");
					}
					else if (intTypeIn == intTypeOut)
					{
						MessageBox.Show("Same types.");
					}
					else
					{
						if (intTypeIn == 0) //C
						{
							if (intTypeOut == 1) //F
							{
								dblTempOut = convertFarenheit(dblTempIn);
							}
							else if (intTypeOut == 2) //K
							{
								dblTempOut = dblTempIn + 333;
							}
						}
						else if (intTypeIn == 1) //F
						{
							if (intTypeOut == 0) //C
							{
								dblTempOut = convertCelsius(dblTempIn);
							}
							else if (intTypeOut == 2) //K
							{
								dblTempOut = convertKelvin(dblTempIn);
							}
							else if (intTypeIn == 2) //K
							{
								if (intTypeOut == 0) //C
								{
									dblTempOut = dblTempIn - 333;
								}
								else if (intTypeOut == 1) //F
								{
									dblTempOut = convertKelvin(dblTempIn);
								}
								return;
							}
							else
							{
								MessageBox.Show("Something went wrong!");
							}
						}


						MessageBox.Show("Index1: " + intTypeIn + "\nIndex2: " + intTypeOut);
					}
				}
				else
				{
					// Invalid number
					MessageBox.Show("Please enter a number.");
				}

					//--------------------------------------------
					//
					lblTempOut.Text = String.Format("{0:N2}", dblTempOut);
			}
			catch
			{
				MessageBox.Show("Something went wrong!");
			}
		}
	}
}
