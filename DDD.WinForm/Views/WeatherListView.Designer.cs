namespace DDD.WinForm.Views
{
    partial class WeatherListView
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
            entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            WeatherDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)WeatherDataGrid).BeginInit();
            SuspendLayout();
            // 
            // entityCommand1
            // 
            entityCommand1.CommandTimeout = 0;
            entityCommand1.CommandTree = null;
            entityCommand1.Connection = null;
            entityCommand1.EnablePlanCaching = true;
            entityCommand1.Transaction = null;
            // 
            // WeatherDataGrid
            // 
            WeatherDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WeatherDataGrid.Dock = DockStyle.Fill;
            WeatherDataGrid.Location = new Point(0, 0);
            WeatherDataGrid.Name = "WeatherDataGrid";
            WeatherDataGrid.RowHeadersWidth = 51;
            WeatherDataGrid.RowTemplate.Height = 29;
            WeatherDataGrid.Size = new Size(665, 326);
            WeatherDataGrid.TabIndex = 0;
            // 
            // WeathersListView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 326);
            Controls.Add(WeatherDataGrid);
            Name = "WeathersListView";
            Text = "WeatherListView";
            ((System.ComponentModel.ISupportInitialize)WeatherDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private DataGridView WeatherDataGrid;
    }
}