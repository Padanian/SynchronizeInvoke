using System;
using System.Threading;
using System.Windows.Forms;

namespace SynchronizeInvoke
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void Test_Click(object sender, EventArgs e)
		{
			// create a thread. we use this instead of tasks
			// or thread pooling simply for demonstration.
			// normally, it's not a great idea to spawn
			// threads directly like this.
			var thread = new Thread(() => { 
				// fill the progress bar, slowly
				for(var i = 0;i<10001;++i)
				{
					// update the progress bar in a thread safe manner
					// you can't use a lambda here without assigning
					// it to a specific delegate type. Here we use
					// Action since it doesn't need any arguments
					// or a return value
					Action action = () =>
					{ 
						// execute this code on the UI thread
						Progress.Value = i / 100; 
					};
					// this marshals the code above onto the thread
					// that this form is running on (the UI thread)
					// everything within the action code is executed
					// on the UI thread. We only do this if 
					// InvokeRequired is true, otherwise we can
					// invoke the delegate directly. In this example,
					// it should always be true, but in the real world
					// it will not be necessarily. Calling Invoke when
					// it's not necessary (InvokeRequired=false) doesn't
					// hurt, but it causes unnecessary overhead.
					if (InvokeRequired)
						Invoke(action);
					else
						action();

					// all controls and forms implement Invoke.
					// There is also BeginInvoke/EndInvoke which 
					// you can use to invoke asynchronously
				}
			});
			thread.Start();
		}

	}
}
