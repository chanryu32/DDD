namespace DDD.WinForm
{
    partial class WeatherLatestView
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DataDateLabel = new Label();
            ConditionLabel = new Label();
            TemperatureLabel = new Label();
            LatestButton = new Button();
            AreasComboBox = new ComboBox();
            ListShow = new Button();
            AddButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 88);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "地域";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 146);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "日時";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 198);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "状態";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 249);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "温度";
            // 
            // DataDateLabel
            // 
            DataDateLabel.AutoSize = true;
            DataDateLabel.Location = new Point(114, 146);
            DataDateLabel.Name = "DataDateLabel";
            DataDateLabel.Size = new Size(50, 20);
            DataDateLabel.TabIndex = 4;
            DataDateLabel.Text = "label5";
            // 
            // ConditionLabel
            // 
            ConditionLabel.AutoSize = true;
            ConditionLabel.Location = new Point(114, 198);
            ConditionLabel.Name = "ConditionLabel";
            ConditionLabel.Size = new Size(50, 20);
            ConditionLabel.TabIndex = 5;
            ConditionLabel.Text = "label6";
            // 
            // TemperatureLabel
            // 
            TemperatureLabel.AutoSize = true;
            TemperatureLabel.Location = new Point(114, 249);
            TemperatureLabel.Name = "TemperatureLabel";
            TemperatureLabel.Size = new Size(50, 20);
            TemperatureLabel.TabIndex = 6;
            TemperatureLabel.Text = "label7";
            // 
            // LatestButton
            // 
            LatestButton.Location = new Point(277, 83);
            LatestButton.Name = "LatestButton";
            LatestButton.Size = new Size(75, 30);
            LatestButton.TabIndex = 7;
            LatestButton.Text = "直近値";
            LatestButton.UseVisualStyleBackColor = true;
            LatestButton.Click += LatestButton_Click;
            // 
            // AreasComboBox
            // 
            AreasComboBox.FormattingEnabled = true;
            AreasComboBox.Location = new Point(97, 85);
            AreasComboBox.Name = "AreasComboBox";
            AreasComboBox.Size = new Size(151, 28);
            AreasComboBox.TabIndex = 8;
            // 
            // ListShow
            // 
            ListShow.Location = new Point(42, 27);
            ListShow.Name = "ListShow";
            ListShow.Size = new Size(122, 30);
            ListShow.TabIndex = 9;
            ListShow.Text = "List";
            ListShow.UseVisualStyleBackColor = true;
            ListShow.Click += ListShow_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(230, 27);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(122, 30);
            AddButton.TabIndex = 10;
            AddButton.Text = "追加";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // WeatherLatestView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(AddButton);
            Controls.Add(ListShow);
            Controls.Add(AreasComboBox);
            Controls.Add(LatestButton);
            Controls.Add(TemperatureLabel);
            Controls.Add(ConditionLabel);
            Controls.Add(DataDateLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WeatherLatestView";
            Text = "WeatherLatestView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DataDateLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Button LatestButton;
        private ComboBox AreasComboBox;
        private Button ListShow;
        private Button AddButton;
    }
}

