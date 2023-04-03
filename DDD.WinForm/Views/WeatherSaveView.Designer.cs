namespace DDD.WinForm.Views
{
    partial class WeatherSaveView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SaveButton = new Button();
            label1 = new Label();
            AreaIdComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DateTimeTextBox = new DateTimePicker();
            ConditionComboBox = new ComboBox();
            TemperatureTextBox = new TextBox();
            UnitLabel = new Label();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(27, 21);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 68);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 1;
            label1.Text = "地域";
            // 
            // AreaIdComboBox
            // 
            AreaIdComboBox.FormattingEnabled = true;
            AreaIdComboBox.Location = new Point(113, 65);
            AreaIdComboBox.Name = "AreaIdComboBox";
            AreaIdComboBox.Size = new Size(151, 28);
            AreaIdComboBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 107);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 3;
            label2.Text = "日時";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 146);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 4;
            label3.Text = "状態";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 184);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 5;
            label4.Text = "温度";
            // 
            // DateTimeTextBox
            // 
            DateTimeTextBox.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            DateTimeTextBox.Format = DateTimePickerFormat.Custom;
            DateTimeTextBox.Location = new Point(113, 102);
            DateTimeTextBox.Name = "DateTimeTextBox";
            DateTimeTextBox.Size = new Size(250, 27);
            DateTimeTextBox.TabIndex = 6;
            // 
            // ConditionComboBox
            // 
            ConditionComboBox.FormattingEnabled = true;
            ConditionComboBox.Location = new Point(113, 143);
            ConditionComboBox.Name = "ConditionComboBox";
            ConditionComboBox.Size = new Size(151, 28);
            ConditionComboBox.TabIndex = 7;
            // 
            // TemperatureTextBox
            // 
            TemperatureTextBox.Location = new Point(113, 181);
            TemperatureTextBox.Name = "TemperatureTextBox";
            TemperatureTextBox.Size = new Size(125, 27);
            TemperatureTextBox.TabIndex = 8;
            // 
            // UnitLabel
            // 
            UnitLabel.AutoSize = true;
            UnitLabel.Location = new Point(260, 184);
            UnitLabel.Name = "UnitLabel";
            UnitLabel.Size = new Size(27, 20);
            UnitLabel.TabIndex = 9;
            UnitLabel.Text = "XX";
            // 
            // WeatherSaveView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 295);
            Controls.Add(UnitLabel);
            Controls.Add(TemperatureTextBox);
            Controls.Add(ConditionComboBox);
            Controls.Add(DateTimeTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AreaIdComboBox);
            Controls.Add(label1);
            Controls.Add(SaveButton);
            Name = "WeatherSaveView";
            Text = "WeatherSaveView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Label label1;
        private ComboBox AreaIdComboBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker DateTimeTextBox;
        private ComboBox ConditionComboBox;
        private TextBox TemperatureTextBox;
        private Label UnitLabel;
    }
}