package lab_05_GrybokMarkiyan;

import java.io.*;
import java.util.*;

public class CalcWFio 
{
	private double result;
	
	public void calculate(double x)
	{
		result = Math.tan(x) / (3 * x);
	}
	
	public double getResult()
	{
		return result;
	}
	
	public void writeResTxt(String fName) throws FileNotFoundException
	{
		PrintWriter f = new PrintWriter(fName);
		f.printf("%f ",result);
		f.close();
	}
	
	public void writeResBin(String fName) throws FileNotFoundException, IOException
	{
		DataOutputStream f = new DataOutputStream(new FileOutputStream(fName));
		f.writeDouble(result);
		f.close();
	}
	
	public void readResTxt(String fName)
	{
		try
		{
			File f = new File (fName);
			if (f.exists())
			{
				Scanner s = new Scanner(f);
				result = s.nextDouble();
				s.close();
			}
			else
			{
				throw new FileNotFoundException("File " + fName + " not found");
			}
			
		}
		catch (FileNotFoundException ex)
		{
			System.out.print(ex.getMessage());
		}
	}
	
	public void readResBin(String fName) throws FileNotFoundException, IOException
	{
		DataInputStream f = new DataInputStream(new FileInputStream(fName));
		result = f.readDouble();
		f.close();
	}
	
	
	
}

