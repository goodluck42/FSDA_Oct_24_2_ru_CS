class Calculator
{
	public double Divide(double num1, double num2)
	{
		if (num2 == 0)
		{
			throw new ZeroDivisionException("Divided by zero!");
		}
		
		return num1 / num2;
	}
}