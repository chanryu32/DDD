using DDD.WinForm.ViewModels;
using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using Moq;

namespace DDDTest.Tests
{
    [TestClass]
    public class WeatherListViewModelTest
    {
        [TestMethod]
        public void 天気一覧画面シナリオ()
        {

            var weatherMock = new Mock<IWeatherRepository>();

            weatherMock.Setup(x => x.GetData()).Returns(new List<WeatherEntity> {
                new WeatherEntity(
                     1,
                     "東京",
                     Convert.ToDateTime("2023/01/01 12:34:56"),
                     2,
                     12.3f),
                new WeatherEntity(
                     2,
                     "神戸",
                     Convert.ToDateTime("2023/01/02 12:34:56"),
                     1,
                     12.340f)});

            var viewModel = new WeatherListViewModel(weatherMock.Object);
            viewModel.Weathers.Count.Is(2);
            viewModel.Weathers[0].AreaId.Is("0001");
            viewModel.Weathers[0].AreaName.Is("東京");
            viewModel.Weathers[0].DataDate.Is("2023/01/01 12:34:56");
            viewModel.Weathers[0].Condition.Is("曇り");
            viewModel.Weathers[0].Temperature.Is("12.30 ℃");



        }
    }
}