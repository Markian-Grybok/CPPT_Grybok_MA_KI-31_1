package lab_04_GrybokMarkiyan;

import java.util.Scanner;
import java.io.*;
import static java.lang.System.out;

class CalcException extends ArithmeticException
{
	public CalcException()
	{
		
	}
	
	public CalcException(String cause)
	{
		super(cause);
	}
}

public class Equations 
{

	public double calculate(int x) throws CalcException
	{
		double res;
			try
			{
				res = Math.tan(x) / (3 * x);
				// Якщо результат не є числом, то генеруємо виключення
				if ( res==Double.NaN 
						|| res==Double.NEGATIVE_INFINITY 
						|| res==Double.POSITIVE_INFINITY 
						|| res==0 )
				{
					throw new ArithmeticException();
				}
				
			}
			catch (ArithmeticException ex)
			{
				// створимо виключення вищого рівня з поясненням причини
				// виникнення помилки
				if (x==0)
					throw new CalcException("Exception reason: X = 0");
				else
					throw new CalcException("Unknown reason of the exception during exception calculation");
		
			}
		return res;
	}
	
	
	
}
