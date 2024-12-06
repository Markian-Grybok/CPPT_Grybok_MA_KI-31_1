package lab_02_GrybokMarkiyan;

import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import static java.lang.System.out;
import static java.lang.System.err;


 // Клас Рослина представляє рослину з основними складовими: корінням, стеблом та листям.
public class Plant 
{
    private Root root;
    private Stem stem;
    private Leaf leaf;

    private PrintWriter logWriter;

    
     // ctor за замовчуванням
    public Plant() 
    {
        this(new Root(), new Stem(), new Leaf());
    }


     // ctor з конкретними компонентами і винятком
    public Plant(Root root, Stem stem, Leaf leaf) 
    {
        this.root = root;
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
    private void initLog() throws IOException 
    {
        logWriter = new PrintWriter(new FileWriter("plant_log.txt", true), true);
    }

    // запис у лог файл
    private void log(String message) 
    {
        if (logWriter != null) 
        {
            logWriter.println(message);
        }
    }
    
    
     // очищення файлу log
    public void clearLog() {
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

    
     // поливати рослину
    public void water() 
    {
        log("Рослину поливають.");
    }


     // добриво для рослини
    public void fertilize() 
    {
        log("Рослину удобрюють.");
    }


     // підстригати листя
    public void trimLeaves() 
    {
        log("Листя рослини підстригли.");
    }


     // збільшити висоту стебла
    public void growStem(int height) 
    {
        stem.grow(height);
        log("Стебло рослини виросло на " + height + " см.");
    }


     // збільшити коріння
    public void growRoots(int length) 
    {
        root.grow(length);
        log("Коріння рослини виросло на " + length + " см.");
    }

    
     // нове листя
    public void growLeaves(int count) 
    {
        leaf.grow(count);
        log("Рослина виростила " + count + " нових листків.");
    }


     // поточнй стан рослини
    public void displayStatus() 
    {
        log("Відображення стану рослини.");
        out.println("Стан рослини: ");
        out.println("Коріння: " + root.getLength() + " см");
        out.println("Стебло: " + stem.getHeight() + " см");
        out.println("Листя: " + leaf.getCount() + " листків");
    }

     // закриття файлу логування
    public void closeLog() 
    {
        if (logWriter != null) 
        {
            logWriter.close();
        }
    }
}




class Root 
{
    private int length;

    public Root() 
    {
        this.length = 10;
    }

    public void grow(int amount) 
    {
        this.length += amount;
    }

    public int getLength() 
    {
        return this.length;
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


