package lab_05_GrybokMarkiyan;

import java.io.*;
import java.util.*;
import static java.lang.System.out;

public class Program 
{

	public static void main(String[] args) throws FileNotFoundException, IOException
	{
		// TODO Auto-generated method stub
		CalcWFio obj = new CalcWFio();
		Scanner s = new Scanner(System.in);
		
		out.print("Enter data: ");
		double data = s.nextDouble();
		
		obj.calculate(data);
		
		out.println("Result of Console: " + obj.getResult());
		obj.writeResTxt("textRes.txt");
		obj.writeResBin("BinRes.bin");
		
		obj.readResBin("BinRes.bin");
		out.println("Result of Bin: " + obj.getResult());
		
		obj.readResTxt("textRes.txt");
		out.println("Result of Txt: " + obj.getResult());
	}
	
	
	
}
