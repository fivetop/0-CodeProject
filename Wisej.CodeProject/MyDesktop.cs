﻿using System;
using Wisej.Web;
using System.Threading;
using Wisej.CodeProject.Examples;
using Wisej.CodeProject.Setup;
using Wisej.ChatServer;

namespace Wisej.CodeProject
{
    public partial class MyDesktop : Desktop
	{
		private Popups.StartPopup startPopup;
		public event EventHandler ExampleCreated;

		Main MainWin { get; set; }
		HtmlEditorExample example2 { get; set; }
		MediaExample example3 { get; set; }
		CustomPainting example5 { get; set; }


		public MyDesktop()
		{
			InitializeComponent();

/*
			string connStr = @"Data Source=E:\0 신사업\demo\webPA\newrep\wisej\0 use\0 CodeProject\Wisej.CodeProject\bin\simplepaw.db;Pooling=true;FailIfMissing=false";

			try 
			{ 
				conn = new SQLiteConnection(connStr);
				conn.Open();

				// 테이블 유무 검사
				SQLiteCommand command = new SQLiteCommand(conn);
				command.CommandText = "SELECT COUNT(*) FROM sqlite_master WHERE type = 'table';";
				command.CommandType = CommandType.Text;
				int RowCount = 0;
				RowCount = Convert.ToInt32(command.ExecuteScalar());

				// 데이터 조회
				String SelectSQL = "SELECT * FROM sqlite_master WHERE type='table';";
				SQLiteCommand cmd = new SQLiteCommand(SelectSQL, conn);
				//var rdr = cmd.ExecuteScalar();
				//var rdr = cmd.ExecuteReaderAsync();
				SQLiteDataReader rdr = cmd.ExecuteReader();
				while (rdr.Read())
				{
					Console.WriteLine($"{rdr.GetString(0)} {rdr.GetString(1)} {rdr.GetString(2)}");
				}
				command.Dispose();

				DataContext db = new DataContext(conn);

				//var t2 = db.GetTable<UserTrees>();
			}
			catch (Exception e1)
			{
				Console.WriteLine(e1.Message);
			}

*/
			this.startPopup = new Popups.StartPopup()
			{
				Alignment = Placement.TopLeft
			};
			this.startPopup.ExampleCreated += StartPopup_ExampleCreated;

			this.customWallpaper1.RotationInterval = 5000;
		}

        internal void RcvSigR(SignalRMsg msg)
        {
			AlertBox.Show(msg.message);
			switch (msg.Msgtype)
			{
				case eSignalRMsgType.eEM:
					break;
				case eSignalRMsgType.eEM_FIRE:
					break;
				case eSignalRMsgType.eEM_PRESET_SW:
					break;
				case eSignalRMsgType.ePlay:
					break;
				case eSignalRMsgType.ePlayEnd:
					break;
				case eSignalRMsgType.ePlaying:
					break;
				case eSignalRMsgType.eStop:
					break;
			}
			MainWin.RcvSigR(msg);
		}

        private void MyDesktop_ItemClick(object sender, DesktopTaskBarItemClickEventArgs e)
		{
			panel1.TabIndex = 100; // .Show();

			try
			{
				switch (e.Item.Name)
				{
					case "desktopDateTime":
					case "desktopStart":
						MainWin.WindowState = FormWindowState.Minimized;
						example2.WindowState = FormWindowState.Minimized;
						example3.WindowState = FormWindowState.Minimized;
						example5.WindowState = FormWindowState.Minimized;

						break;
					case "desktopTaskBarItemCompras":
						break;
					default:

						break;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error en la aplicación." + ex.Message);
			}
		}

		private void justGage1_Click(object sender, EventArgs e)
		{
		}

		private void StartPopup_ExampleCreated(object sender, EventArgs e)
		{
		}


		private void MyDesktop_Load(object sender, EventArgs e)
		{

			// start gage background task.
			SatrtUpdatingGageItem();

			MainWin = new Main();
			example2 = new Examples.HtmlEditorExample();
			example3 = new Examples.MediaExample();
			example5 = new Examples.CustomPainting();
			this.ExampleCreated?.Invoke(MainWin, EventArgs.Empty);
			this.ExampleCreated?.Invoke(example2, EventArgs.Empty);
			this.ExampleCreated?.Invoke(example3, EventArgs.Empty);
			this.ExampleCreated?.Invoke(example5, EventArgs.Empty);
			MainWin.Show(); // .Active = true; // .Activate();
			example2.Show();
			example3.Show();
			example5.Show();
			MainWin.WindowState = FormWindowState.Minimized;
			example2.WindowState = FormWindowState.Minimized;
			example3.WindowState = FormWindowState.Minimized;
			example5.WindowState = FormWindowState.Minimized;

			g.signalRClient.owner = this;
			g.signalRClient.ConnectToSignalR();
		}

		private void MyDesktop_SizeChanged(object sender, EventArgs e)
		{
			if (MainWin == null)
				return;
			MainWin.WindowState = FormWindowState.Maximized;
			example2.WindowState = FormWindowState.Maximized;
			example3.WindowState = FormWindowState.Maximized;
			example5.WindowState = FormWindowState.Maximized;
		}

		private void SatrtUpdatingGageItem()
		{
			Application.StartTask(() =>
			{

				while (!Application.IsTerminated)
				{
					this.justGage1.Value = Program.CPU;
					Application.Update(this);
					Thread.Sleep(1000);
				}
			});
		}

		// 환경설정
        private void button1_Click(object sender, EventArgs e)
        {
			var win1 = new MSet();
			this.ExampleCreated?.Invoke(win1, EventArgs.Empty);
			win1.Show();
		}


		// 휴일 관리
		private void button2_Click(object sender, EventArgs e)
        {
			var win1 = new MHoliday();
			this.ExampleCreated?.Invoke(win1, EventArgs.Empty);
			win1.Show();

		}

		// 그룹 관리
		private void button3_Click(object sender, EventArgs e)
        {
			var win1 = new MGroup();
			this.ExampleCreated?.Invoke(win1, EventArgs.Empty);
			win1.Show();

		}

		// 음원관리 
		private void button4_Click(object sender, EventArgs e)
        {
			var win1 = new MMusic();
			this.ExampleCreated?.Invoke(win1, EventArgs.Empty);
			win1.Show();
		}

		// 알람 이벤트 
		private void button5_Click(object sender, EventArgs e)
        {
			var win1 = new MEvent();
			this.ExampleCreated?.Invoke(win1, EventArgs.Empty);
			win1.Show();

		}

		// 방송 이력 
		private void button6_Click(object sender, EventArgs e)
        {
			g.sendSigR("Hello Server..");
			//AlertBox.Show(msg1.em_status);
		}

		// 비상방송 이력 
		private void button7_Click(object sender, EventArgs e)
        {

        }

		// 스피커 볼륨 조정 
        private void button8_Click(object sender, EventArgs e)
        {
			var win1 = new Window1();
			this.ExampleCreated?.Invoke(win1, EventArgs.Empty);
			win1.Show();

		}

		// 장비 내역 
		private void button9_Click(object sender, EventArgs e)
        {
			var win1 = new SimpleChatClient();
			this.ExampleCreated?.Invoke(win1, EventArgs.Empty);
			win1.Show();

		}
		// 사용자 관리 
		private void button10_Click(object sender, EventArgs e)
        {
			var win1 = new MUser();
			this.ExampleCreated?.Invoke(win1, EventArgs.Empty);
			win1.Show();

		}

        private void MyDesktop_Resize(object sender, EventArgs e)
        {

        }

        private void MyDesktop_Activated(object sender, EventArgs e)
        {
			if (MainWin == null)
				return;
			this.MyDesktop_SizeChanged(null,null);

			MainWin.Invalidate(); // .re .re .WindowState = FormWindowState.Minimized;
			//example1.WindowState = FormWindowState.Minimized;
			example2.WindowState = FormWindowState.Minimized;
			example3.WindowState = FormWindowState.Minimized;
			example5.WindowState = FormWindowState.Minimized;
			this.ResizeRedraw = true;
			this.Invalidate();
		}
	}
}
