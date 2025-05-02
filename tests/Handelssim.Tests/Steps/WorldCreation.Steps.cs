using Handelssim.Domain;
using System.Linq;
using TechTalk.SpecFlow;
using Xunit;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging;

namespace Handelssim.Tests.Steps
{
    [Binding]
    public class WorldCreationSteps
    {
        private World _world;

        [Given(@"I create a new world")]
        public void GivenICreateANewWorld()
        {
            _world = new World(TestLogging.CreateLogger<World>());
            _world.GenerateCities();
        }

        [Then(@"the world should contain (.*) cities")]
        public void ThenTheWorldShouldContainCities(int expectedCount)
        {
            Assert.Equal(expectedCount, _world.Cities.Count);
        }
    }
}