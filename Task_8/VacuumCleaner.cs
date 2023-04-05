﻿namespace Task_8;
/*● Создать класс, описывающий пылесос
○ В классе должен быть виртуальное свойство Model для получения наименования модели пылесоса
○ В классе должен быть виртуальный метод StartCleaning, который пишет в консоль о том, что началась
уборка
○ Создать перегрузку метода StartCleaning, которая принимает параметром комнату, в которой нужно
сделать уборку

● Создать 3 класса наследника
○ Например: обычный пылесос, робот пылесос, моющий пылесос и тд
○ В 1 наследнике оставить тело метода StartCleaning родителя
○ В 2 наследнике переопределить метод StartCleaning, написав в начале уборки о том, какая модель
пылесоса начала уборку
○ В 3 наследнике реализовать сокрытие метода StartCleaning
● Каждый класс описать в отдельном файле
● Создать массив базового типа, добавить в него объекты класса пылесос. В цикле у
всех объектов вызвать метод StartCleaning*/




public class VacuumCleaner
{
  private  string _model;
  
  public virtual string Model 
  { 
    get => _model;
    set => _model = value;
  }   
  public virtual void StartCleaning()
  {
    Console.WriteLine("Началась уборка!!!");
  }

  public void StartCleaning(int room)
  {
    Console.WriteLine($"Неубрана комната №{room}");
  }
}