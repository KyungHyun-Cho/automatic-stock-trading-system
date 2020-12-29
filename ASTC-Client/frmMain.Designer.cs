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
			((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).BeginInit();
			this.SuspendLayout();
			// 
			// axKHOpenAPI
			// 
			this.axKHOpenAPI.Enabled = true;
			this.axKHOpenAPI.Location = new System.Drawing.Point(12, 388);
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
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblCode);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnLoginTest);
			this.Controls.Add(this.axKHOpenAPI);
			this.Name = "frmMain";
			this.Text = "ASTS-Client";
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
	}
}

