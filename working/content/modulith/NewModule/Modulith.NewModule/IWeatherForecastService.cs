#if (WithUi)
using Modulith.NewModule.HttpModels;
#endif
namespace Modulith.NewModule;

internal interface IWeatherForecastService
{
  Task<IEnumerable<WeatherForecastResponse>> GetWeatherForecastAsync();
}
