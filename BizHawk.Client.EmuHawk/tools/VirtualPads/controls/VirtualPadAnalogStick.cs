﻿using System;
using System.Drawing;
using System.Windows.Forms;

using BizHawk.Emulation.Common;
using BizHawk.Client.Common;
using System.Windows;

namespace BizHawk.Client.EmuHawk
{
	public partial class VirtualPadAnalogStick : UserControl, IVirtualPadControl
	{
		private bool _programmaticallyUpdatingNumerics;
		private bool _readonly;

		public VirtualPadAnalogStick()
		{
			InitializeComponent();
			AnalogStick.ClearCallback = ClearCallback;
		}

		public float[] RangeX = new float[] { -128f, 0.0f, 127f };
		public float[] RangeY = new float[] { -128f, 0.0f, 127f };


		private void VirtualPadAnalogStick_Load(object sender, EventArgs e)
		{
			AnalogStick.Name = Name;
			AnalogStick.XName = Name;
			AnalogStick.YName = Name.Replace("X", "Y"); // TODO: allow schema to dictate this but this is a convenient default
			AnalogStick.SetRangeX(RangeX);
			AnalogStick.SetRangeY(RangeY);

			ManualX.Minimum = (decimal)RangeX[0];
			ManualX.Maximum = (decimal)RangeX[2];

			ManualY.Minimum = (decimal)RangeX[0];
			ManualY.Maximum = (decimal)RangeX[2];

			MaxXNumeric.Minimum = 1;
			MaxXNumeric.Maximum = 100;
			MaxXNumeric.Value = 100;

			MaxYNumeric.Minimum = 1;
			MaxYNumeric.Maximum = 100;
			MaxYNumeric.Value = 100; // Note: these trigger change events that change the analog stick too
		}

		#region IVirtualPadControl Implementation

		public void UpdateValues()
		{
			// Nothing to do
			// This tool already draws as necessary
		}

		public void Set(IController controller)
		{
			AnalogStick.Set(controller);
			SetNumericsFromAnalog();
		}

		public void ClearCallback()
		{
			ManualX.Value = 0;
			ManualY.Value = 0;
			//see HOOMOO
			Global.AutofireStickyXORAdapter.SetSticky(AnalogStick.XName, false);
			Global.StickyXORAdapter.Unset(AnalogStick.XName);
			Global.AutofireStickyXORAdapter.SetSticky(AnalogStick.YName, false);
			Global.StickyXORAdapter.Unset(AnalogStick.YName);
			AnalogStick.HasValue = false;
		}

		public void Clear()
		{
			AnalogStick.Clear();
		}

		public bool ReadOnly
		{
			get
			{
				return _readonly;
			}

			set
			{
				if (_readonly != value)
				{
					XLabel.Enabled =
						ManualX.Enabled =
						YLabel.Enabled =
						ManualY.Enabled =
						MaxLabel.Enabled =
						MaxXNumeric.Enabled =
						MaxYNumeric.Enabled =
						!value;

					AnalogStick.ReadOnly = 
						_readonly =
						value;
				
					Refresh();
				}
			}
		}

		#endregion

		public void Bump(int? x, int? y)
		{
			if (x.HasValue)
			{
				AnalogStick.HasValue = true;
				AnalogStick.X += x.Value;
			}

			if (y.HasValue)
			{
				AnalogStick.HasValue = true;
				AnalogStick.Y += y.Value;
			}

			SetNumericsFromAnalog();
		}

		public void SetPrevious(IController previous)
		{
			AnalogStick.SetPrevious(previous);
		}

		private void ManualX_ValueChanged(object sender, EventArgs e)
		{
			SetAnalogControlFromNumerics();
		}

		private void ManualX_KeyUp(object sender, KeyEventArgs e)
		{
			SetAnalogControlFromNumerics();
		}

		private void ManualY_KeyUp(object sender, KeyEventArgs e)
		{
			SetAnalogControlFromNumerics();
		}

		private void ManualY_ValueChanged(object sender, EventArgs e)
		{
			SetAnalogControlFromNumerics();
		}

		private void SetAnalogControlFromNumerics()
		{
			if (!_programmaticallyUpdatingNumerics)
			{
				AnalogStick.X = (int)ManualX.Value;
				AnalogStick.Y = (int)ManualY.Value;
				AnalogStick.HasValue = true;
				AnalogStick.Refresh();
			}
		}

		private void SetNumericsFromAnalog()
		{
			if (AnalogStick.HasValue)
			{
				// Setting .Value of a numeric causes a draw, so avoid it unless necessary
				if (ManualX.Value != AnalogStick.X)
				{
					ManualX.Value = AnalogStick.X;
				}

				if (ManualY.Value != AnalogStick.Y)
				{
					ManualY.Value = AnalogStick.Y;
				}
			}
			else
			{
				if (ManualX.Value != 0)
				{
					ManualX.Value = 0;
				}

				if (ManualY.Value != 0)
				{
					ManualY.Value = 0;
				}
			}
		}

		private void AnalogStick_MouseDown(object sender, MouseEventArgs e)
		{
			if (!ReadOnly)
			{
				_programmaticallyUpdatingNumerics = true;
				SetNumericsFromAnalog();
				_programmaticallyUpdatingNumerics = false;
			}
		}

		private void AnalogStick_MouseMove(object sender, MouseEventArgs e)
		{
			if (!ReadOnly)
			{
				_programmaticallyUpdatingNumerics = true;
				SetNumericsFromAnalog();
				_programmaticallyUpdatingNumerics = false;
			}
		}

		private void MaxXNumeric_ValueChanged(object sender, EventArgs e)
		{
			SetAnalogMaxFromNumerics();
		}

		private void MaxXNumeric_KeyUp(object sender, KeyEventArgs e)
		{
			SetAnalogMaxFromNumerics();
		}

		private void MaxYNumeric_ValueChanged(object sender, EventArgs e)
		{
			SetAnalogMaxFromNumerics();
		}

		private void MaxYNumeric_KeyUp(object sender, KeyEventArgs e)
		{
			SetAnalogMaxFromNumerics();
		}

		private void SetAnalogMaxFromNumerics()
		{
			if (!_programmaticallyUpdatingNumerics)
			{
				//blehh,... this damn feature
				AnalogStick.SetUserRange((float)MaxXNumeric.Value, (float)MaxYNumeric.Value);
			}
		}
	}
}
