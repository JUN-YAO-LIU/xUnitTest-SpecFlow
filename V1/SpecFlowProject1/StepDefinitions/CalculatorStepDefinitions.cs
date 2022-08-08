using V1;
using V1.Controllers;

//https://docs.specflow.org/projects/getting-started/en/latest/GettingStarted/Step8.html
namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly WeatherForecastController _weatherForecastControlle;
        private IEnumerable<WeatherForecast> _result;

        [Given("there aren't input")]
        public void GivenTheFirstNumberIs()
        {
            // arrange
            // throw new PendingStepException();
        }

        [When("get the weather data")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic
            _result = _weatherForecastControlle.Get();
        }

        [Then("the result should not be null")]
        public void ThenTheResultShouldBe()
        {
            //TODO: implement assert (verification) logic
            _result.Should().NotBeNull();
        }
    }
}