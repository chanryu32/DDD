using DDD.WinForm.ViewModels;

namespace DDD.WinForm.Views
{
    public partial class WeatherListView : Form
    {

        private WeatherListViewModel _viewModel = new();
        public WeatherListView()
        {
            InitializeComponent();
            WeatherDataGrid.DataBindings.Add("DataSource", _viewModel, nameof(_viewModel.Weathers));
        }
    }
}
