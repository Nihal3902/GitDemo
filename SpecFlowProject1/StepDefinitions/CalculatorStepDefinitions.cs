using NUnit.Framework;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
           Console.WriteLine($"first number :{number}");
            
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            Console.WriteLine($"second number :{number}");
        }

        [When("the two numbers are added")]
        public void  WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine($"{nameof(WhenTheTwoNumbersAreAdded)}");
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
           Console.WriteLine($"{ThenTheResultShouldBe} : {result}");
        }
    }
}