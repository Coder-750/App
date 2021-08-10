using System;
using NativeUiLib;

namespace CounterApp
{
	public class Program
	{
		public void Main()
		{
			Ui.RunOnUiThread(()=> MainUi());
		}
		
		private void MainUi()
		{
			var count=1;
			var linear = new LinearLayout();
			var btn = linear.AddButton(true);
			var txt = linear.AddTextView(true);
			var myApp = linear.AddTextView(true);
			myApp.Text="~Made By Hattori Sololearner!";
			myApp.SetTextColor(Android.Graphics.Color.Tan);
			txt.Text=count.ToString();
			txt.SetTextSize(Android.Util.ComplexUnitType.Sp,50);
			btn.Text = "Hey Click Me To Increment!";
			btn.SetTextColor(Android.Graphics.Color.Teal);
			btn.SetBackgroundColor(Android.Graphics.Color.LightPink);
			
			btn.Click+=delegate{
			count+=1;
			btn.Text="Thanks For Clicking!";
		    txt.Text=count.ToString();
			
		};
		
		linear.Show();
		
	}
}
} 
