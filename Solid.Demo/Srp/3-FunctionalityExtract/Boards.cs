﻿using System;

namespace Solid.Demo.Srp.FunctionalityExtract
{
	[Flags]
	public enum Boards
	{
		FreeBoard1 = 1,
		FreeBoard2 = 2,
		PaidBoard1 = 4,
		PaidBoard2 = 8,
	}
}