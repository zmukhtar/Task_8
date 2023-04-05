namespace Task_8;

public class RobotVacuumCleaner:VacuumCleaner
{
   private string _model = "Робот пылесос";
   
   public override string Model { get => _model; set=>_model = value; }

   public override void StartCleaning()
   {
      Console.WriteLine(Model);
      
   }  
   
}