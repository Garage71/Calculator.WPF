namespace Calculator.CalculatorViewModel
{
    /// <summary>
    /// View-model locator class
    /// </summary>
    public class ViewModelLocator
    {
        private static CalculatorViewModel _calculatorViewModel;

        public CalculatorViewModel CalculatorViewModel
		{
            get
            {
                return _calculatorViewModel ?? (_calculatorViewModel = new CalculatorViewModel());
            }
		}
	}
}