// See https://aka.ms/new-console-template for more information

using Task_8;


SimpleVacuumCleaner simple = new SimpleVacuumCleaner();
RobotVacuumCleaner robot = new RobotVacuumCleaner();
WashVacuumCleaner wash = new WashVacuumCleaner();

VacuumCleaner[] vacuumCleaner = new VacuumCleaner[3];
vacuumCleaner[0] = new SimpleVacuumCleaner();
vacuumCleaner[1] = new RobotVacuumCleaner();
vacuumCleaner[2] = new WashVacuumCleaner();

for (int i = 0; i< vacuumCleaner.Length; i++)
{
    vacuumCleaner[i].StartCleaning();
}