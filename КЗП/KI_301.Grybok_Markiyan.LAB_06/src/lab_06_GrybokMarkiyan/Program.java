package lab_06_GrybokMarkiyan;

import java.util.*;
import java.io.*;

class Building <T extends Data>
{
	private ArrayList<T> arr;
	
	public Building()
	{
		arr = new ArrayList<T>();
	}
	
	public T findMax()
	{
		if (!arr.isEmpty())
		{
			
			T max = arr.get(0);
			for (int i=1; i< arr.size(); i++)
			{
				if ( arr.get(i).compareTo(max) > 0 )
				max = arr.get(i);
			}
			
			return max;
		}
		
		return null;
	}
	
	public void AddBuild(T data)
	{
		arr.add(data);
		System.out.print("Building added: ");
		data.print();
	}
	
	public void DeleteBuild(int i)
	{
		arr.remove(i);
	}
}


class Residential implements Data
{
	private String _name;
	private int _age;
	private int _rating;
	
	public Residential(String Name, int Age, int Rating)
	{
		_name = Name;
		_age = Age;
		_rating = Rating;
	}
	
	public void setName(String Name)
	{
		_name = Name;
	}
	
	public String getName()
	{
		return _name;
	}
	
	public void setAge(int Age)
	{
		_age = Age;
	}
	
	public int getAge()
	{
		return _age;
	}
	
	public void setRating(int Rating)
	{
		_rating = Rating;
	}
	
	public int getRating()
	{
		return _rating;
	}
	
	public int compareTo(Data p)
	{
		Integer s = _rating;
		return s.compareTo(p.getRating());
	}
	
	public void print()
	{
		System.out.print("\n\tResidential Building Name: " + _name + ", Age: " + _age + ", Rating: " + _rating + "%;\n");
	}
}


interface Data extends Comparable<Data>
{
	public int getRating();
	public void print();
}


class Decorative implements Data
{
	private String _name;
	private int _age;
	private int _rating;
	
	public Decorative(String Name, int Age, int Rating)
	{
		_name = Name;
		_age = Age;
		_rating = Rating;
	}
	
	public void setName(String Name)
	{
		_name = Name;
	}
	
	public String getName()
	{
		return _name;
	}
	
	public void setAge(int Age)
	{
		_age = Age;
	}
	
	public int getAge()
	{
		return _age;
	}
	
	public void setRating(int Rating)
	{
		_rating = Rating;
	}
	
	public int getRating()
	{
		return _rating;
	}
	
	public int compareTo(Data p)
	{
		Integer s = _rating;
		return s.compareTo(p.getRating());
	}
	
	public void print()
	{
		System.out.print("\n\tDecorative Building Name: " + _name + ", Age: " + _age + ", Rating: " + _rating + "%;\n");
	}
}


public class Program 
{
	public static void main(String[] args)
	{
	
		Building <? super Data> build = new Building <Data>();	
		
		build.AddBuild(new Residential("Burj Khalifa" , 25, 97));
		build.AddBuild(new Decorative("Big Ben", 243, 94));
		
		Data res = build.findMax();
		System.out.print("Max rating has Buliding: ");
		res.print();
	}
}

