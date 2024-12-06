import Plant

class Tree(Plant):
    def __init__(self, _name, _height):
        super().__init__(_name)
        self.height = _height
        print(f"{self.name} was created")
    
    def changeHeight(self, newheight):
        self.height = newheight
    
    def getHeight(self):
        print(f"Height of {self.name} is {self.height}m")