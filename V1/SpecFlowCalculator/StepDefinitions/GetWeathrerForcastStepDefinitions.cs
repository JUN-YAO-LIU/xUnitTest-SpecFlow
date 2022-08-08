using Microsoft.Extensions.Logging;
using V1;
using V1.Controllers;

namespace SpecFlowCalculator.StepDefinitions
{
    [Binding]
    public sealed class GetWeathrerForcastStepDefinitions
    {
        private WeatherForecastController _controller = new WeatherForecastController();
        private IEnumerable<WeatherForecast> _result;

        [Given(@"the input of values")]
        public void TheInputOfValues()
        {
        }

        [When(@"execute the api")]
        public void ExecuteTheAPi()
        {
            _result = _controller.Get();
        }

        [Then(@"the result is not null")]
        public void ChechTheReslult()
        {
            _result.Should().NotBeEmpty();
        }
    }
}