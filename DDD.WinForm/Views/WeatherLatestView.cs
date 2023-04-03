using DDD.Domain.Entities;
using DDD.WinForm.ViewModels;
using DDD.WinForm.Views;

namespace DDD.WinForm
{
    public partial class WeatherLatestView : Form
    {

        private WeatherLatestViewModel _viewModel = new();

        public WeatherLatestView()
        {
            InitializeComponent();
            AreasComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AreasComboBox.DataBindings.Add("SelectedValue", _viewModel, nameof(_viewModel.SelectedAreaId));
            AreasComboBox.DataBindings.Add("DataSource", _viewModel, nameof(_viewModel.Areas));
            AreasComboBox.ValueMember = nameof(AreaEntity.AreaId);
            AreasComboBox.DisplayMember = nameof(AreaEntity.AreaName);

            DataDateLabel.DataBindings.Add("Text", _viewModel, nameof(_viewModel.DataDateText));
            ConditionLabel.DataBindings.Add("Text", _viewModel, nameof(_viewModel.ConditionText));
            TemperatureLabel.DataBindings.Add("Text", _viewModel, nameof(_viewModel.TemperatureText));

        }

        private void LatestButton_Click(object sender, EventArgs e)
        {
            _viewModel.Search();
        }

        private void ListShow_Click(object sender, EventArgs e)
        {
            using var f = new WeatherListView();
            f.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using var f = new WeatherSaveView();
            f.ShowDialog();
        }
    }
}
