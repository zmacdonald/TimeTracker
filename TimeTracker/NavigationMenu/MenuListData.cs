using System;
using System.Collections.Generic;

namespace TimeTracker
{
	public class MenuListData : List<MenuItem>
	{
		public MenuListData()
		{
			this.Add(new MenuItem()
			{
				Title = "Track Time",
				IconSource = "",
				TargetType = typeof(TrackTimePage)
			});

			this.Add(new MenuItem()
			{
				Title = "Time History",
				IconSource = "",
				TargetType = typeof(TimeHistoryPage)
			});
		}
	}
}

