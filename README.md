# otus_architecture_lab_4

Диаграмма классов программы. ISortMaker представляет собой абстрактную фабрику. конкретные фабрики MergeSorterMaker, InsertionSorterMaker и SelectionSorterMaker реализуют данный интерфейс.
Конкретная фабрика создается в билдере SortBuilder. Таким образом клиент Programm не знает ни тип конкретной фабрики ни тип продукта с которыми работает.

![alt text](https://github.com/AlexandrBashkirev/otus_architecture_lab_4/blob/master/otus_architecture_lab_4/class_diagram.png?raw=true)
