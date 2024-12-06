package lab_03_GrybokMarkiyan;

public class Program 
{
    public static void main(String[] args) 
    {
        Tree tree = new Tree();
        
        tree.water();
        tree.grow();
        tree.grow();
        tree.closeLog();

        
        System.out.println("Вік дерева: " + tree.getAge());
        System.out.println("Висота дерева: " + tree.getHeight());
    }
}