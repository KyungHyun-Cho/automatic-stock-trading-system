namespace ASTC_Client
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.axKHOpenAPI = new AxKHOpenAPILib.AxKHOpenAPI();
			this.btnLoginTest = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.lblCode = new System.Windows.Forms.Label();
			this.btnGetRealData = new System.Windows.Forms.Button();
			this.labRealData = new System.Windows.Forms.Label();
			this.stockTextBox = new System.Windows.Forms.TextBox();
			this.accountList = new System.Windows.Forms.ListBox();
			this.labIDFor = new System.Windows.Forms.Label();
			this.labNameFor = new System.Windows.Forms.Label();
			this.labID = new System.Windows.Forms.Label();
			this.labName = new System.Windows.Forms.Label();
			this.labGetUserInfo = new System.Windows.Forms.Button();
			this.labSeedMoney = new System.Windows.Forms.Label();
			this.labSeedMoneyFor = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).BeginInit();
			this.SuspendLayout();
			// 
			// axKHOpenAPI
			// 
			this.axKHOpenAPI.Enabled = true;
			this.axKHOpenAPI.Location = new System.Drawing.Point(12, 403);
			this.axKHOpenAPI.Name = "axKHOpenAPI";
			this.axKHOpenAPI.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI.OcxState")));
			this.axKHOpenAPI.Size = new System.Drawing.Size(100, 50);
			this.axKHOpenAPI.TabIndex = 0;
			this.axKHOpenAPI.Visible = false;
			// 
			// btnLoginTest
			// 
			this.btnLoginTest.Location = new System.Drawing.Point(12, 12);
			this.btnLoginTest.Name = "btnLoginTest";
			this.btnLoginTest.Size = new System.Drawing.Size(231, 47);
			this.btnLoginTest.TabIndex = 1;
			this.btnLoginTest.Text = "로그인 테스트";
			this.btnLoginTest.UseVisualStyleBackColor = true;
			this.btnLoginTest.Click += new System.EventHandler(this.BtnLoginTest_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(177, 65);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(66, 21);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "정보 GET";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// txtCode
			// 
			this.txtCode.Location = new System.Drawing.Point(83, 65);
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(88, 21);
			this.txtCode.TabIndex = 3;
			this.txtCode.Text = "005930";
			// 
			// lblCode
			// 
			this.lblCode.AutoSize = true;
			this.lblCode.Location = new System.Drawing.Point(12, 72);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(65, 12);
			this.lblCode.TabIndex = 4;
			this.lblCode.Text = "종목 코드 :";
			// 
			// btnGetRealData
			// 
			this.btnGetRealData.Location = new System.Drawing.Point(12, 337);
			this.btnGetRealData.Name = "btnGetRealData";
			this.btnGetRealData.Size = new System.Drawing.Size(116, 32);
			this.btnGetRealData.TabIndex = 5;
			this.btnGetRealData.Text = "실시간 조회";
			this.btnGetRealData.UseVisualStyleBackColor = true;
			this.btnGetRealData.Click += new System.EventHandler(this.BtnGetRealData_Click);
			// 
			// labRealData
			// 
			this.labRealData.AutoSize = true;
			this.labRealData.Location = new System.Drawing.Point(134, 357);
			this.labRealData.Name = "labRealData";
			this.labRealData.Size = new System.Drawing.Size(11, 12);
			this.labRealData.TabIndex = 6;
			this.labRealData.Text = "0";
			// 
			// stockTextBox
			// 
			this.stockTextBox.Location = new System.Drawing.Point(12, 376);
			this.stockTextBox.Name = "stockTextBox";
			this.stockTextBox.Size = new System.Drawing.Size(78, 21);
			this.stockTextBox.TabIndex = 7;
			// 
			// accountList
			// 
			this.accountList.FormattingEnabled = true;
			this.accountList.ItemHeight = 12;
			this.accountList.Location = new System.Drawing.Point(12, 195);
			this.accountList.Name = "accountList";
			this.accountList.Size = new System.Drawing.Size(231, 136);
			this.accountList.TabIndex = 8;
			this.accountList.SelectedIndexChanged += new System.EventHandler(this.AccountList_SelectedIndexChanged);
			// 
			// labIDFor
			// 
			this.labIDFor.AutoSize = true;
			this.labIDFor.Location = new System.Drawing.Point(12, 102);
			this.labIDFor.Name = "labIDFor";
			this.labIDFor.Size = new System.Drawing.Size(49, 12);
			this.labIDFor.TabIndex = 9;
			this.labIDFor.Text = "아이디 :";
			// 
			// labNameFor
			// 
			this.labNameFor.AutoSize = true;
			this.labNameFor.Location = new System.Drawing.Point(24, 129);
			this.labNameFor.Name = "labNameFor";
			this.labNameFor.Size = new System.Drawing.Size(41, 12);
			this.labNameFor.TabIndex = 10;
			this.labNameFor.Text = "이름 : ";
			// 
			// labID
			// 
			this.labID.AutoSize = true;
			this.labID.Location = new System.Drawing.Point(67, 102);
			this.labID.Name = "labID";
			this.labID.Size = new System.Drawing.Size(43, 12);
			this.labID.TabIndex = 11;
			this.labID.Text = "(labID)";
			// 
			// labName
			// 
			this.labName.AutoSize = true;
			this.labName.Location = new System.Drawing.Point(67, 129);
			this.labName.Name = "labName";
			this.labName.Size = new System.Drawing.Size(66, 12);
			this.labName.TabIndex = 12;
			this.labName.Text = "(labName)";
			// 
			// labGetUserInfo
			// 
			this.labGetUserInfo.Location = new System.Drawing.Point(208, 96);
			this.labGetUserInfo.Name = "labGetUserInfo";
			this.labGetUserInfo.Size = new System.Drawing.Size(34, 70);
			this.labGetUserInfo.TabIndex = 13;
			this.labGetUserInfo.Text = "조회";
			this.labGetUserInfo.UseVisualStyleBackColor = true;
			this.labGetUserInfo.Click += new System.EventHandler(this.LabGetUserInfo_Click);
			// 
			// labSeedMoney
			// 
			this.labSeedMoney.AutoSize = true;
			this.labSeedMoney.Location = new System.Drawing.Point(67, 154);
			this.labSeedMoney.Name = "labSeedMoney";
			this.labSeedMoney.Size = new System.Drawing.Size(100, 12);
			this.labSeedMoney.TabIndex = 15;
			this.labSeedMoney.Text = "(labSeedMoney)";
			// 
			// labSeedMoneyFor
			// 
			this.labSeedMoneyFor.AutoSize = true;
			this.labSeedMoneyFor.Location = new System.Drawing.Point(12, 154);
			this.labSeedMoneyFor.Name = "labSeedMoneyFor";
			this.labSeedMoneyFor.Size = new System.Drawing.Size(49, 12);
			this.labSeedMoneyFor.TabIndex = 14;
			this.labSeedMoneyFor.Text = "예수금 :";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(253, 450);
			this.Controls.Add(this.labSeedMoney);
			this.Controls.Add(this.labSeedMoneyFor);
			this.Controls.Add(this.labGetUserInfo);
			this.Controls.Add(this.labName);
			this.Controls.Add(this.labID);
			this.Controls.Add(this.labNameFor);
			this.Controls.Add(this.labIDFor);
			this.Controls.Add(this.accountList);
			this.Controls.Add(this.stockTextBox);
			this.Controls.Add(this.labRealData);
			this.Controls.Add(this.btnGetRealData);
			this.Controls.Add(this.lblCode);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnLoginTest);
			this.Controls.Add(this.axKHOpenAPI);
			this.Name = "frmMain";
			this.Text = "ASTS-Client";
			this.Load += new System.EventHandler(this.FrmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI;
		private System.Windows.Forms.Button btnLoginTest;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.Label lblCode;
		private System.Windows.Forms.Button btnGetRealData;
		private System.Windows.Forms.Label labRealData;
		private System.Windows.Forms.TextBox stockTextBox;
		private System.Windows.Forms.ListBox accountList;
		private System.Windows.Forms.Label labIDFor;
		private System.Windows.Forms.Label labNameFor;
		private System.Windows.Forms.Label labID;
		private System.Windows.Forms.Label labName;
		private System.Windows.Forms.Button labGetUserInfo;
		private System.Windows.Forms.Label labSeedMoney;
		private System.Windows.Forms.Label labSeedMoneyFor;
	}
}

