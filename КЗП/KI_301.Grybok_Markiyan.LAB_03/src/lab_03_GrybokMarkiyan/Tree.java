package lab_03_GrybokMarkiyan;

import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import static java.lang.System.out;
import static java.lang.System.err;

interface Growable 
{
    void grow();
}

 // Клас Дерево успадковує клас Рослина та реалізовує інтерфейс Growable.
public class Tree extends Plant implements Growable 
{

    private int age;  // Вік дерева
    private Stem height = new Stem(); // Висота дерева
    

     // ctor за замовчуванням
    public Tree() 
    {
        super();
        this.age = 0;
        log("Дерево створено.");
    }


     // конструктор з параметрами.
    public Tree(int age, int height) 
    {
        super();
        this.age = age;
        this.height.grow(height);
        log("Дерево створено з віком: " + age + " років і висотою: " + this.height.getHeight()  + " метрів.");
    }


     // полив дерева
    @Override
    public void water() 
    {
        log("Дерево поливають.");
        out.println("Дерево було полите.");
    }


     // процес росту дерева
    @Override
    public void grow() 
    {
        height.grow(1);
        age++;
        log("Дерево виросло. Висота: " + this.height.getHeight() + ", Вік: " + age);
        out.println("Дерево росте. Висота тепер: " + this.height.getHeight() + " метрів.");
    }


     // вік дерева.
    public int getAge() 
    {
        return age;
    }


     // gовертає висоту дерева
    public int getHeight() 
    {
        return height.getHeight();
    }
}




 // Клас Рослина представляє рослину з основними складовими: корінням, стеблом та листям.
abstract  class Plant 
{
	protected  Stem stem;
	protected  Leaf leaf;

	protected  PrintWriter logWriter;

    
     // ctor за замовчуванням
	protected  Plant() 
    {
        this(new Stem(), new Leaf());
    }


     // ctor з конкретними компонентами і винятком
	protected  Plant(Stem stem, Leaf leaf) 
    {
        this.stem = stem;
        this.leaf = leaf;
        try 
        {
            initLog();
            log("Рослину створено з індивідуальним корінням, стеблом та листям.");
        } 
        catch (IOException e) 
        {
            err.println("Помилка при відкритті файлу для логування: " + e.getMessage());
        }
    }

    // логування і виняток
	protected  void initLog() throws IOException 
    {
        logWriter = new PrintWriter(new FileWriter("plant_log.txt", true), true);
    }

    // запис у лог файл
	protected  void log(String message) 
    {
        if (logWriter != null) 
        {
            logWriter.println(message);
        }
    }
    
    
     // очищення файлу log
	protected  void clearLog() {
        try 
        {
            PrintWriter clearWriter = new PrintWriter(new FileWriter("plant_log.txt", false));
            clearWriter.print("");
            clearWriter.close();
            out.println("<Файл логування успішно очищено>\n");
        } 
        catch (IOException e) 
        {
            err.println("Помилка при очищенні файлу логування: " + e.getMessage());
        }
    }

   
    public abstract void water();

     // добриво для рослини
    protected  void fertilize() 
    {
        log("Рослину удобрюють.");
    }


     // підстригати листя
    protected  void trimLeaves() 
    {
        log("Листя рослини підстригли.");
    }


     // збільшити висоту стебла
    protected  void growStem(int height) 
    {
        stem.grow(height);
        log("Стебло рослини виросло на " + height + " см.");
    }


    
     // нове листя
    protected  void growLeaves(int count) 
    {
        leaf.grow(count);
        log("Рослина виростила " + count + " нових листків.");
    }


     // поточнй стан рослини
    protected  void displayStatus() 
    {
        log("Відображення стану рослини.");
        out.println("Стан рослини: ");
        out.println("Стебло: " + stem.getHeight() + " см");
        out.println("Листя: " + leaf.getCount() + " листків");
    }

     // закриття файлу логування
    protected  void closeLog() 
    {
        if (logWriter != null) 
        {
            logWriter.close();
        }
    }
}





class Stem 
{
    private int height;

    public Stem() 
    {
        this.height = 15;
    }

    public void grow(int amount) 
    {
        this.height += amount;
    }

    public int getHeight() 
    {
        return this.height;
    }
}


class Leaf 
{

    private int count;

    public Leaf() 
    {
        this.count = 5; 
    }

    public void grow(int newLeaves) 
    {
        this.count += newLeaves;
    }

    public int getCount() 
    {
        return this.count;
    }
}



