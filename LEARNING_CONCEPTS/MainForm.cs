namespace LEARNING_CONCEPTS
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			//Father father = new Father();

			//father.Work();

			Son son = new Son();

			son.Work();
		}
	}
}
