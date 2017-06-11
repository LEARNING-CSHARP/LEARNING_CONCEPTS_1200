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
			//Father oFather = new Father();

			//oFather.Work();

			Son oSon = new Son();

			oSon.Work();
		}
	}
}
