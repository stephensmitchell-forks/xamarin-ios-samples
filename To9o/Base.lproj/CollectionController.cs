// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;
using System.Collections.Generic;
using System.Linq;

namespace StoryboardTables
{
	public partial class CollectionController : UICollectionViewController
	{
		public CollectionController (IntPtr handle) : base (handle)
		{
		}
		List<Task> tasks;
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			tasks = AppDelegate.Current.TaskMgr.GetTasks ().ToList ();

			// bind every time, to reflect deletion in the Detail view
			Collection.Source = new AllCollectionSource(tasks.ToArray ());
		}
	}
}
