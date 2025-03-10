﻿using Windows.Win32.Foundation;
using static Windows.Win32.PInvoke;

namespace Jiayi.UI.Eventing.Handlers;

public class ExitHandler() : EventHandler(WM_CLOSE)
{
	public override void HandleMessage(Window window, uint message, WPARAM wParam, LPARAM lParam)
	{
		window.Close();
	}
}