namespace Task_8;

public class WashVacuumCleaner:VacuumCleaner
{
    private int _room;
    public  WashVacuumCleaner(): base()
    {
        
    }

    public void StartCleaning()
    {
        Console.WriteLine("Это 3 метод.");
    }
    
}
