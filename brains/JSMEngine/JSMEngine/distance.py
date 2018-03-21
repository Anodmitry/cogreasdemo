import math

mapMinCoord = -2
mapMaxCoord = 2


class ActObj:
    type = ""
    name = ""
    x = 0#horizontal
    y = 0#vertical
    time = ""

    def __init__(self,x,y,type="none",name="none",time="none"):
        self.name = name
        self.time = time
        self.type = type
        if (x in range(mapMinCoord,mapMaxCoord+1)) and (y in range(mapMinCoord,mapMaxCoord+1)):
            self.x = x
            self.y = y
        else:
            raise Exception("Coordinates are not in correct range!")

    
    def __str__(self):
        return "("+str(self.x)+";"+str(self.y)+")"
        

#distance between aim cell and cell where the active object stays
def Distance(aimcell,actobjcell):
    if not (isinstance(aimcell, ActObj) and isinstance(actobjcell, ActObj)): raise Exception("Incorrect type of argument!")
    if actobjcell.type in ["none", "bomb", "mine", "medkit"]: return math.sqrt((aimcell.x - actobjcell.x)**2 + (aimcell.y - actobjcell.y)**2)
    #FOR BLASTER (distance to line where it is)
    if actobjcell.type == "blaster":
        if abs(actobjcell.x) == abs(mapMaxCoord+1):
            return abs(aimcell.y - actobjcell.y)
        elif abs(actobjcell.y) == abs(mapMaxCoord+1):
            return abs(aimcell.x - actobjcell.x)
    

#calculate proximitydegree


try:
    ao1 = ActObj(-2,2,"aimcell")
    lst = [ActObj(0,0),ActObj(-1,-2),ActObj(0,-1)]
    
    print(Distance(lst[0],lst[1]))
    #for i in lst: print i,#for inline output print i,

    #count proximitydegree

except Exception as e:
    print(e)




