# -*- coding: utf-8 -*-

class jsmdata:
    #m - mine, b - bomb, bs - blaster
    #подаем на вход индукции ситуации по одной клетке (под роботом) в разные (последовательные) моменты времени, по ней же и учимся
    #пробуем учиться 5 секунд - это 10 примеров, которые берём каждые полсекунды
    #minereachable - доступность клетки для мины
    #damageoversth - целевой столбец (за 0.5 сек нанесено урона больше 10 - это положительный пример, то есть клетка опасна)
    #на выходе дсм наборы опасных фрагментов универсума (положительные) и безопасных фрагментов (отриц.), с ними мы будем сравнивать другие клетки
            
            #mine0|mine1|mine2|mine3|mine4|mine5|mine6|mine7|bomb0|bomb1|blaster0|blaster1|blaster2|minereachable|bombreachable|blasterreachable|damageoversth
    #case1
    #case2
    damagesth = 10#значение урона, которое учитывается как граница для целевого столбца
    table = {}#словарь словарей, представляющий таблицу кейсов
    time = 0
    universum = {"mine0","mine1","mine2","mine3","mine4","mine5","mine6",\
                "mine7","bomb0","bomb1","blaster0","blaster1","blaster2",\
                "minereachable","bombreachable","blasterreachable","damageoversth"}
    
    
    @staticmethod
    def addcase(casename, mine, bomb, blaster, damage):#передаются секунды с момента появления для каждого активного объекта, урон робота
        try:
            #проверка на вход в заданный диапазон
            if (mine not in range(8)) or (bomb not in range(2)) or (blaster not in range(3)) or (damage not in range(101)):
                raise Exception("Incorrect input values")
            
            d = {"mine0":0,"mine1":0,"mine2":0,"mine3":0,"mine4":0,"mine5":0,"mine6":0,\
                "mine7":0,"bomb0":0,"bomb1":0,"blaster0":0,"blaster1":0,"blaster2":0,\
                "minereachable":0,"bombreachable":0,"blasterreachable":0,"damageoversth":0}
            
            if mine > 0:
                d["minereachable"] = 1
            if bomb > 0:
                d["bombreachable"] = 1
            if blaster > 0:
                d["blasterreachable"] = 1


            if damage>jsmdata.damagesth:
                d["damageoversth"] = 1#нужно, чтобы разделить кейсы на положительные и отрицательные
            else:
                d["damageoversth"] = 0

            d["mine"+str(mine)] = 1
            d["bomb"+str(bomb)] = 1
            d["blaster"+str(blaster)] = 1

            jsmdata.table[casename] = d#записываем кейс в словарь
            jsmdata.time += 0.5#счётчик, по которому буду обращаться к бд

        except Exception as e:
            print(e)

    @staticmethod
    def makelistofsets():#преобразование словаря кейсов в список множеств с положительными и отрицательными кейсами (т.е. теми, где жизнь робота больше 50%)
        #each set in this list consists names of columns with "1" value
        t = jsmdata.table
        poslst = [{j for j in t[i] if t[i][j]} for i in t if t[i]["damageoversth"]]
        neglst = [{j for j in t[i] if t[i][j]} for i in t if not t[i]["damageoversth"]]
        return (poslst, neglst)



#переделать под новые требования, подготовить к взятию из бд
jsmdata.addcase("case1",1,0,2,15)
jsmdata.addcase("case2",0,1,1,5)
jsmdata.addcase("case3",0,1,0,3)
t = jsmdata.table
print(t)
print("_____________")
#plst = [{j for j in t[i] if t[i][j]} for i in t if t[i]["healthover50"]]

pos = jsmdata.makelistofsets()[0]
neg = jsmdata.makelistofsets()[1]
#print(pos, neg)
#print(pos)
print(jsmdata.universum - neg[0])
