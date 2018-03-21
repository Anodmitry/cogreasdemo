# -*- coding: utf-8 -*-

class jsmdata:
    #m - mine, b - bomb, bs - blaster
            #m0|m1|m2|m3|m4|m5|m6|m7|b0|b1|bs0|bs1|bs2|damage015|damage1530|damage3040|damageover40
    #case1
    #case2
    table = {}#словарь словарей, представляющий таблицу кейсов
    time = 0
    
    @staticmethod
    def addcase(casename, mine, bomb, blaster, damage, curhealth):#передаётся, сколько прошло секунд с момента появления каждого активного объекта, урон робота и текущее здоровье
        try:
            #проверка на вход в заданный диапазон
            if (mine not in range(8)) or (bomb not in range(2)) or (blaster not in range(3)) or (damage not in range(101)) or (curhealth not in range(101)):
                raise Exception("Incorrect input values")
            
            d = {"mine0":0,"mine1":0,"mine2":0,"mine3":0,"mine4":0,"mine5":0,"mine6":0,\
                "mine7":0,"bomb0":0,"bomb1":0,"blaster0":0,"blaster1":0,"blaster2":0,\
                "damage015":0,"damage1530":0,"damage3040":0,"damageover40":0,"healthover50":0}
            
            if curhealth>50:
                d["healthover50"] = 1#нужно, чтобы разделить кейсы на положительные и отрицательные
            elif curhealth<=50:
                d["healthover50"] = 0

            d["mine"+str(mine)] = 1
            d["bomb"+str(bomb)] = 1
            d["blaster"+str(blaster)] = 1
            if damage in range(0,16):
                d["damage015"] = 1
            elif damage in range(16,31):
                d["damage1530"] = 1
            elif damage in range(31,41):
                d["damage3040"] = 1
            elif damage>40:
                d["damageover40"] = 1

            jsmdata.table[casename] = d#??????? ????
            jsmdata.time += 0.5#???????? ??????? ??????? ?? ??????????

        except Exception as e:
            print(e)

    @staticmethod
    def takeposcaseset():#преобразование словаря кейсов в список множеств с положительными кейсам (т.е. теми, где жизнь робота больше 50%)
        lst = []
        for i in range(len(jsmdata.table)):
            c = jsmdata.table["case"+str(i)]
            if c["healthover50"]:
                #НО ВЕДЬ МНОЖЕСТВА ТОЖЕ НЕ СОХРАНЯЮТ ПОРЯДОК ЭЛЕМЕНТОВ, так что лучше хранить в списках!!!
                case = [c["mine0"],c["mine1"],c["mine2"],c["mine3"],c["mine4"],c["mine5"],c["mine6"],c["mine7"],\
                    c["bomb0"],c["bomb1"],c["blaster0"],c["blaster1"],c["blaster2"],\
                    c["damage015"],c["damage1530"],c["damage3040"],c["damageover40"],c["healthover50"]]
                print(case)
                lst.append(case)
        
        print(lst)





jsmdata.addcase("case0",0,0,0,15,85)
#print(jsmdata.table)
#print(jsmdata.time)
jsmdata.addcase("case1",7,1,2,30,55)
#print(jsmdata.table)
#print(jsmdata.time)
jsmdata.takeposcaseset()