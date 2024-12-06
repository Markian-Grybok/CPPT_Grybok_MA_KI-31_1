package lab_02_GrybokMarkiyan;

public class Program 
{
    public static void main(String[] args) 
    {

            Plant plant = new Plant();
            
            plant.clearLog();
            
            plant.water();
            plant.fertilize();
            plant.trimLeaves();
            plant.growStem(5);
            plant.growRoots(3);
            plant.growLeaves(2);
            plant.displayStatus();

            plant.closeLog();

    }
}


