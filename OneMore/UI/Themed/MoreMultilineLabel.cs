﻿//************************************************************************************************
// Copyright © 2024 Steven M Cohn. All rights reserved.
//************************************************************************************************

namespace River.OneMoreAddIn.UI
{
	using System;
	using System.Drawing;
	using System.Windows.Forms;


	/// <summary>
	/// Manages a multi-line label with auto-wrapping. It must be Docked to its parent
	/// with Fill mode or left/right anchored.
	/// </summary>
	internal class MoreMultilineLabel : Panel, IThemedControl
	{
		private readonly MoreLabel label;
		private string preferredBack;
		private string preferredFore;


		public MoreMultilineLabel()
			: base()
		{
			label = new MoreLabel
			{
				AutoSize = true,
				Dock = DockStyle.Fill
			};

			Controls.Add(label);
		}


		public string PreferredBack
		{
			get => preferredBack;
			set => preferredBack = label.PreferredBack = value;
		}


		public string PreferredFore
		{
			get => preferredFore;
			set => preferredFore = label.PreferredFore = value;
		}


		public override string Text
		{
			get => base.Text;
			set => label.Text = base.Text = value;
		}


		protected override void OnResize(EventArgs eventargs)
		{
			base.OnResize(eventargs);
			label.MaximumSize = new Size(Width, 0);
		}
	}
}
