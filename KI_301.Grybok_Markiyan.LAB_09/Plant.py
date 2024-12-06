class Plant:
    def __init__(self, _name):
        self.name = _name
        self.age = None

    def changeName(self, _newname):
        oldname = self.name
        self.name = _newname
        print(f"{oldname} change name to {self.name}")
    
    def getName(self):
        print(f"Name is: {self.name}")

    def setAge(self, _age):
        self.age = _age
    
    def changeAge(self, _newage):
        self.age = _newage
    
    def getAge(self):
        if self.age == None:
            print(f"{self.name} dont setAge")
        else:
            print(f"Age of {self.name} is {self.age}")