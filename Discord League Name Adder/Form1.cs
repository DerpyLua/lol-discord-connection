using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using DarkUI.Controls;
using DarkUI.Forms;

namespace Discord_League_Name_Adder
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : DarkForm
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000003 RID: 3
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000004 RID: 4 RVA: 0x00002068 File Offset: 0x00000268
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000206C File Offset: 0x0000026C
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[Form1.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020B8 File Offset: 0x000002B8
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				Form1.ReleaseCapture();
				Form1.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020F4 File Offset: 0x000002F4
		public void PutObject(string postUrl, string postdata, string second)
		{
			try
			{
				WebRequest webRequest = WebRequest.Create("https://discordapp.com/api/v6/users/@me/connections/leagueoflegends/authorize");
				webRequest.Method = "PUT";
				byte[] bytes = Encoding.UTF8.GetBytes(postdata);
				webRequest.ContentType = "application/json";
				webRequest.ContentLength = (long)bytes.Length;
				webRequest.Headers.Add("Authorization", second);
				Stream stream = webRequest.GetRequestStream();
				stream.Write(bytes, 0, bytes.Length);
				stream.Close();
				WebResponse response = webRequest.GetResponse();
				Stream responseStream;
				stream = (responseStream = response.GetResponseStream());
				try
				{
					StreamReader streamReader = new StreamReader(stream);
					string text = streamReader.ReadToEnd();
				}
				finally
				{
					if (responseStream != null)
					{
						((IDisposable)responseStream).Dispose();
					}
				}
				response.Close();
			}
			catch
			{
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000021D4 File Offset: 0x000003D4
		public void Serialize(Stream output, object input)
		{
			DataContractSerializer dataContractSerializer = new DataContractSerializer(input.GetType());
			dataContractSerializer.WriteObject(output, input);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021F7 File Offset: 0x000003F7
		private void DarkButton2_Click(object sender, EventArgs e)
		{
			this.PutObject("", "{\"name\":\"" + this.TextBoxUsername.Text + "\",\"friend_sync\":true}", this.TextBoxAuth.Text);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000222B File Offset: 0x0000042B
		private void DarkButton1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x04000001 RID: 1
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000002 RID: 2
		public const int HT_CAPTION = 2;

		// Token: 0x04000003 RID: 3
		private static Random random = new Random();
	}
}
