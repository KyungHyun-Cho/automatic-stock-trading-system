
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASTC_Client
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
			axKHOpenAPI.OnReceiveTrData += OnReceiveTrData; // 3. EventListener 등록
		}

		private void BtnLoginTest_Click(object sender, EventArgs e)
		{
			if (axKHOpenAPI.CommConnect() == 0)
			{
				MessageBox.Show("로그인창 열기 성공");
			}
			else
			{
				MessageBox.Show("로그인창 열기 실패");
			}
		}

		private void OnReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
		{
			int receiveCnt = axKHOpenAPI.GetRepeatCnt(e.sTrCode, e.sRQName);
			if ("주식기본정보".Equals(e.sRQName))
			{
				for (int i = 0; i <= receiveCnt; i++)
				{
					string jName = axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "종목명"); // 4. GetCommData 메소드를 통해 데이터 접근
					string jPrice = axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "현재가"); // 4. GetCommData 메소드를 통해 데이터 접근
					jName = jName.Trim();
					jPrice = jPrice.Trim();
					MessageBox.Show("[" + jName + "]\n현재가 : " + jPrice);
				}
			}
		}
		private void BtnSearch_Click(object sender, EventArgs e)
		{
			axKHOpenAPI.SetInputValue("종목코드", txtCode.Text); // 1. SetInputValue
			int ret = axKHOpenAPI.CommRqData("주식기본정보", "OPT10001", 0, "1002"); // 2. CommRqData 를 통해 데이터 요청
			if (ret < 0)
			{
				MessageBox.Show("요청 실패\nError Code : " + ret, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
