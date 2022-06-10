namespace DataBindingSamples.Data {
    public class WeatherForecastService {
        private static readonly string[] Summaries = new[] {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate) => GetForecastAsync(startDate, CancellationToken.None);
        public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate, CancellationToken token) {
            await Task.Delay(1000, token);
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast {
                Id = index,
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 30),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray();
        }
    }
}
