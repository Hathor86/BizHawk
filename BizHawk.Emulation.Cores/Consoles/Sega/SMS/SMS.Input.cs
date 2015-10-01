﻿using BizHawk.Emulation.Common;

namespace BizHawk.Emulation.Cores.Sega.MasterSystem
{
	public partial class SMS
	{
		public static readonly ControllerDefinition SmsController = new ControllerDefinition
			{
				Name = "SMS Controller",
				BoolButtons =
				{
					"Reset", "Pause",
					"P1 Up", "P1 Down", "P1 Left", "P1 Right", "P1 B1", "P1 B2",
					"P2 Up", "P2 Down", "P2 Left", "P2 Right", "P2 B1", "P2 B2"
				}
			};

		public static readonly ControllerDefinition GGController = new ControllerDefinition
		{
			Name = "GG Controller",
			BoolButtons =
				{
					"Reset",
					"P1 Up", "P1 Down", "P1 Left", "P1 Right", "P1 B1", "P1 B2", "P1 Start"
				}
		};

		public ControllerDefinition ControllerDefinition
		{
			get
			{
				if (IsGameGear)
				{
					return GGController;
				}

				return SmsController;
			}
		}

		public IController Controller { get; set; }

		byte ReadControls1()
		{
			InputCallbacks.Call();
			lagged = false;
			byte value = 0xFF;

			if (Controller["P1 Up"]) value &= 0xFE;
			if (Controller["P1 Down"]) value &= 0xFD;
			if (Controller["P1 Left"]) value &= 0xFB;
			if (Controller["P1 Right"]) value &= 0xF7;
			if (Controller["P1 B1"]) value &= 0xEF;
			if (Controller["P1 B2"]) value &= 0xDF;

			if (Controller["P2 Up"]) value &= 0xBF;
			if (Controller["P2 Down"]) value &= 0x7F;

			return value;
		}

		byte ReadControls2()
		{
			InputCallbacks.Call();
			lagged = false;
			byte value = 0xFF;

			if (Controller["P2 Left"]) value &= 0xFE;
			if (Controller["P2 Right"]) value &= 0xFD;
			if (Controller["P2 B1"]) value &= 0xFB;
			if (Controller["P2 B2"]) value &= 0xF7;

			if (Controller["Reset"]) value &= 0xEF;

			if ((Port3F & 0x0F) == 5)
			{
				if (region == "Japan")
				{
					value &= 0x3F;
				}
				else // US / Europe
				{
					if (Port3F >> 4 == 0x0F)
						value |= 0xC0;
					else
						value &= 0x3F;
				}
			}

			return value;
		}

		byte ReadPort0()
		{
			if (IsGameGear == false)
			{
				return 0xFF;
			}

			byte value = 0xFF;
			if ((Controller["Pause"] && !IsGameGear) ||
				(Controller["P1 Start"] && IsGameGear))
			{
				value ^= 0x80;
			}

			if (RegionStr == "Japan")
			{
				value ^= 0x40;
			}

			return value;
		}
	}
}