namespace LEARNING_CONCEPTS
{
	// **************************************************
	//public class Father : object
	//{
	//	public Father() : base()
	//	{
	//	}

	//	public void Work()
	//	{
	//		System.Windows.Forms.MessageBox.Show
	//			("از ساعت هشت صبح تا چهار بعد از ظهر کفاشی می‌کنم");
	//	}
	//}
	// **************************************************

	// **************************************************
	public class Father : object
	{
		public Father() : base()
		{
		}

		/// <summary>
		/// یعنی فرزند من می‌تواند همان کار مرا داشته باشد
		/// و یا کار تکمیلی و یا حتی دیگری را پیشه کند
		/// </summary>
		public virtual void Work()
		{
			System.Windows.Forms.MessageBox.Show
				("از ساعت هشت صبح تا چهار بعد از ظهر کفاشی می‌کنم");
		}
	}
	// **************************************************
}
