package lab_01_GrybokMarkiyan;

import java.io.*;
import java.util.*;
import static java.lang.System.out;

public class Program 
{

    public static void main(String[] args) throws FileNotFoundException
    {
    	Scanner in = new Scanner(System.in);
    	File dataFile = new File("MyFile.txt");
    	PrintWriter fout = new PrintWriter(dataFile);
    	
    	
    	out.print("Введіть розмір квадратної матриці: ");
    	int nRows = in.nextInt();
    	
    	
    	char[][] arr = new char[nRows][];
    	
    	for(int i = 0; i < nRows; i++)
    	{
    		arr[i]= new char[i+1];
    	}
    	
    	
    	in.nextLine();
    	out.print("Введіть символ-заповнювач: ");
    	String filler = in.nextLine();
    	
    	
        exit:
        	for(int i = nRows-1; i >= 0; i--)
	    		{
		    		for(int j = 0; j < i+1; j++)
		    		{
			    		if(filler.length() == 1)
			    		{
				    		arr[i][j] = (char) filler.codePointAt(0);
				    		out.print(arr[i][j] + " ");
				    		fout.print(arr[i][j] + " ");
			    		}
			    		else if (filler.length() == 0)
			    		{
				    		out.print("\nНе введено символзаповнювач");
				    		break exit;
			    		}
			    		else
			    		{
				    		out.print("\nЗабагато символівзаповнювачів");
				    		break exit;
			    		}
		    		}
		    		
	    		out.print("\n");
	    		fout.print("\n");
	    		}
        
    		fout.flush();
    		fout.close();
    	
    	
    }
    
    
    
}