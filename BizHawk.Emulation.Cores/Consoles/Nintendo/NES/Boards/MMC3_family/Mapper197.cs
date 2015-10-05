﻿namespace BizHawk.Emulation.Cores.Nintendo.NES
{
	public sealed class Mapper197 : MMC3Board_Base
	{
		public override bool Configure(NES.EDetectionOrigin origin)
		{
			//analyze board type
			switch (Cart.board_type)
			{
				case "MAPPER197":
					break;
				default:
					return false;
			}
			BaseSetup();
			return true;
		}
	}
}
