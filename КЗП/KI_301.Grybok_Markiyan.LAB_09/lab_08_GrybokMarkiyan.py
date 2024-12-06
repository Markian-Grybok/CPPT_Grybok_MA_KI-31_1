class Plant:
    def __init__(self, _name):
        """
        Конструктор базового класу "Рослина". Ініціалізує назву рослини.
        
        :param _name: Назва рослини.
        """
        self.name = _name  # Встановлює ім'я рослини
        self.age = None  # Ініціалізує вік рослини (спочатку None, бо вік ще не задано)

    def changeName(self, _newname):
        """
        Змінює назву рослини.

        :param _newname: Нова назва рослини.
        """
        oldname = self.name  # Зберігає стару назву
        self.name = _newname  # Змінює назву на нову
        print(f"{oldname} change name to {self.name}")  # Виводить повідомлення про зміну назви
    
    def getName(self):
        """
        Виводить поточну назву рослини.
        """
        print(f"Name is: {self.name}")  # Виводить назву рослини

    def setAge(self, _age):
        """
        Встановлює вік рослини.

        :param _age: Вік рослини.
        """
        self.age = _age  # Встановлює вік рослини
    
    def changeAge(self, _newage):
        """
        Змінює вік рослини.

        :param _newage: Новий вік рослини.
        """
        self.age = _newage  # Змінює вік на новий
    
    def getAge(self):
        """
        Виводить вік рослини, якщо його було встановлено, інакше повідомляє, що вік не було задано.
        """
        if self.age is None:  # Перевіряє, чи встановлено вік
            print(f"{self.name} dont setAge")  # Якщо вік не встановлено, виводить повідомлення
        else:
            print(f"Age of {self.name} is {self.age}")  # Виводить вік рослини, якщо він встановлений


class Tree(Plant):
    def __init__(self, _name, _height):
        """
        Конструктор класу "Дерево". Ініціалізує назву та висоту дерева.
        
        :param _name: Назва дерева.
        :param _height: Висота дерева.
        """
        super().__init__(_name)  # Викликає конструктор базового класу Plant для ініціалізації назви
        self.height = _height  # Встановлює висоту дерева
        print(f"{self.name} was created")  # Виводить повідомлення про створення дерева
    
    def changeHeight(self, newheight):
        """
        Змінює висоту дерева.

        :param newheight: Нова висота дерева.
        """
        self.height = newheight  # Змінює висоту дерева
    
    def getHeight(self):
        """
        Виводить поточну висоту дерева.
        """
        print(f"Height of {self.name} is {self.height}m")  # Виводить висоту дерева


# Створюємо два об'єкти класу Tree (дерево)
t1 = Tree("Apple", 4)  # Створюємо дерево "Apple" з висотою 4 метри
t2 = Tree("Banana", 7)  # Створюємо дерево "Banana" з висотою 7 метрів

# Встановлюємо вік дерева "Banana"
t2.setAge(23)

# Виводимо вік для дерева "Apple" (вік ще не встановлено)
t1.getAge()

# Виводимо вік для дерева "Banana" (вік вже встановлено)
t2.getAge()

# Змінюємо назву дерева "Apple" на "Orange"
t1.changeName("Orange")

# Виводимо висоту дерева "Orange" (яке було раніше "Apple")
t1.getHeight()
