
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxKHOpenAPILib;

namespace ASTC_Client
{
	public partial class frmMain : Form
	{
		List<stockInfo> stockList;

		public frmMain()
		{
			InitializeComponent();
			axKHOpenAPI.OnEventConnect += OnEventConnect;
			axKHOpenAPI.OnReceiveTrData += OnReceiveTrData; // 3. EventListener 등록
			axKHOpenAPI.OnReceiveRealData += OnReceiveRealData;
		}

		private void OnEventConnect(object sender, _DKHOpenAPIEvents_OnEventConnectEvent e)
		{
			stockList = new List<stockInfo>();

			if (e.nErrCode == 0)
			{
				AutoCompleteStringCollection stockcollection = new AutoCompleteStringCollection();

				string stockCode = axKHOpenAPI.GetCodeListByMarket(null);
				string[] stockCodeArray = stockCode.Split(';');
				for (int i = 0; i < stockCodeArray.Length; i++)
				{
					stockList.Add(new stockInfo(stockCodeArray[i], axKHOpenAPI.GetMasterCodeName(stockCodeArray[i])));
				}
				for (int i = 0; i < stockList.Count; i++)
				{
					stockcollection.Add(stockList[i].stockName);
				}
				stockTextBox.AutoCompleteCustomSource = stockcollection;
			}
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

		private void OnReceiveRealData(object sender, _DKHOpenAPIEvents_OnReceiveRealDataEvent e)
		{
			if (e.sRealType == "주식시세")
			{
				if (e.sRealKey == txtCode.Text)
				{
					long stockPrice = long.Parse(axKHOpenAPI.GetCommRealData(txtCode.Text, 10));
					labRealData.Text = String.Format("{0:#,###}", stockPrice);
				}
			}
			MessageBox.Show("A!");
			labRealData.Text = e.sRealData;
			//if("실시간정보".Equals())
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
			}else if("예수금조회".Equals(e.sRQName))
			{
				for (int i = 0; i <= receiveCnt; i++)
				{
					string rPrice = axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, i, "예수금"); // 4. GetCommData 메소드를 통해 데이터 접근
					rPrice = String.Format("{0:#,###}원",int.Parse(rPrice));
					labSeedMoney.Text = rPrice;
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

		private void FrmMain_Load(object sender, EventArgs e)
		{

		}

		private void BtnGetRealData_Click(object sender, EventArgs e)
		{

		}

		private void LabGetUserInfo_Click(object sender, EventArgs e)
		{
			if (axKHOpenAPI.GetConnectState() == 0) return;
			accountList.Items.Clear();
			labID.Text = axKHOpenAPI.GetLoginInfo("USER_ID");
			labName.Text = axKHOpenAPI.GetLoginInfo("USER_NAME");

			string[] accountArr = axKHOpenAPI.GetLoginInfo("ACCNO").Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

			accountList.Items.AddRange(accountArr);
			accountList.SelectedIndex = 0;
		}

		private void AccountList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (accountList.SelectedIndex == -1) return;
			axKHOpenAPI.SetInputValue("계좌번호", accountList.Items[accountList.SelectedIndex].ToString());
			axKHOpenAPI.SetInputValue("비밀번호", "");
			axKHOpenAPI.SetInputValue("비밀번호입력매체구분", "00");

			axKHOpenAPI.SetInputValue("조회구분", "2");
			int ret = axKHOpenAPI.CommRqData("예수금조회", "OPW00001", 0, "1000"); // 2. CommRqData 를 통해 데이터 요청
			if (ret < 0)
			{
				MessageBox.Show("요청 실패\nError Code : " + ret, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
				labSeedMoney.Text = "Err";
			}
		}
	}
}
class stockInfo
{
	public string stockCode;
	public string stockName;
	public stockInfo(string code, string name)
	{
		this.stockCode = code;
		this.stockName = name;
	}
}