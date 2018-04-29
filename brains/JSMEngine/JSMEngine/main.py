# -*- coding: utf-8 -*-

import clr, re, Norris
clr.AddReference('System.Data')
from System.Data import *



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

    minedamage = 20
    bombdamage = 10
    blasterdamage = 30


    damagesth = 10#значение урона, которое учитывается как граница для целевого столбца
    table = {}#словарь словарей, представляющий таблицу кейсов
    time = 0
    universum = {"mine0","mine1","mine2","mine3","mine4","mine5","mine6",\
                "mine7","bomb0","bomb1","blaster0","blaster1","blaster2",\
                "minereachable","bombreachable","blasterreachable","damageoversth"}
    
    
    @staticmethod
    def addcase(casename, mine, bomb, blaster, damage):#передаются секунды с момента появления для каждого активного объекта, урон робота
        try:
            #print(mine,bomb,blaster)
            #проверка на вход в заданный диапазон
            if (mine not in range(-1,8)) or (bomb not in range(-1,2)) or (blaster not in range(-1,3)) or (damage not in range(101)):
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
                
            #чтобы не добавлять несуществующие
            if mine >= 0: d["mine"+str(mine)] = 1
            if bomb >= 0: d["bomb"+str(bomb)] = 1
            if blaster >= 0: d["blaster"+str(blaster)] = 1


            if damage>jsmdata.damagesth:
                d["damageoversth"] = 1#нужно, чтобы разделить кейсы на положительные и отрицательные
            else:
                d["damageoversth"] = 0      
            

            jsmdata.table[casename] = d#записываем кейс в словарь
            jsmdata.time += 0.5#счётчик, по которому буду обращаться к бд

        except Exception as e:
            print(e)

    @staticmethod
    def makelistofsets():#преобразование словаря кейсов в список множеств с положительными и отрицательными кейсами (т.е. теми, где жизнь робота больше 50%)
        #each set in this list consists names of columns with "1" value
        t = jsmdata.table
        #не надо включать в множество целевой столбец - damageoversth
        poslst = [{j for j in t[i] if t[i][j] and j != "damageoversth"} for i in t if t[i]["damageoversth"]]
        neglst = [{j for j in t[i] if t[i][j]} for i in t if not t[i]["damageoversth"]]
        

        return (poslst, neglst)

    @staticmethod
    def getage():#получаем данные о возрасте каждого из активных на данный момент объектов
        connstr = "Data Source=127.0.0.1\sqlexpress01;" + "user id = admin;" + "password = adminadmin;" + "Initial Catalog=envdb_mini;"
        dbconn = SqlClient.SqlConnection(connstr)
        dbconn.Open()
        sqlExpression = """SELECT DISTINCT[actobj_name], 
                                CAST((SELECT MAX([timefromstart]) 
                                      FROM [dbo].[History]) AS float) - 
		                        CAST((SELECT MIN([timefromstart])
                                      FROM [dbo].[History]
                                      WHERE [actobj_name] = [reshistory].[actobj_name]) AS float) AS 'age'
                           FROM [dbo].[History] AS reshistory 
                           WHERE [isactive] = 1"""
        thisCommand = SqlClient.SqlCommand(sqlExpression, dbconn)
        thisReader = thisCommand.ExecuteReader()
        fieldCount = thisReader.FieldCount
        ages = {"mine":-1,"bomb":-1,"blaster":-1}#чтобы обозначить отсутствие объекта в клетке
        while thisReader.Read():
            if thisReader[0].find("mine") >= 0:
                ages["mine"] = int(thisReader[1])
            if thisReader[0].find("bomb") >= 0:
                ages["bomb"] = int(thisReader[1])
            if thisReader[0].find("blaster") >= 0:
                ages["blaster"] = int(thisReader[1])
            #print(thisReader[0],thisReader[1])
        #print(ages)
        return ages


    #@staticmethod
    #def runcommand(sqlExpression):
    #    connstr = "Data Source=127.0.0.1\sqlexpress01;" + "user id = admin;" + "password = adminadmin;" + "Initial Catalog=envdb_mini;"
    #    dbconn = SqlClient.SqlConnection(connstr)
    #    dbconn.Open()
    #    sqlExpression = "SELECT * FROM ActiveObjects"#"INSERT INTO Active_objects (ao_name, id_type) VALUES ('test_171117', '1')";
        
    #    thisCommand = SqlClient.SqlCommand(sqlExpression, dbconn)
    #    thisReader = thisCommand.ExecuteReader()
    #    fieldCount = thisReader.FieldCount
    #    print(fieldCount)
    #    while thisReader.Read():
    #        print(thisReader[0],thisReader[1])

    #    thisReader.Close()
    #    dbconn.Close()
        
###Олег должен мне скинуть в history bool "объект активен", тогда мне будет проще вычислять возраст объекта по запросу
###как только объект сработал, Олег проставляет isactive = false для всех строк с тем объектом



#код далее выполняется при каждом формировании кейса
#tmpages = jsmdata.getage()
#print(tmpages)
#print("_____________")

#вычисление принесённого урона
#sumdamage = 0
#if tmpages["mine"] == 7: sumdamage += jsmdata.minedamage
#if tmpages["bomb"] == 1: sumdamage += jsmdata.bombdamage
#if tmpages["blaster"] == 2: sumdamage += jsmdata.blasterdamage
#
#print(sumdamage)

#формирование кейса

#jsmdata.addcase("case1",tmpages["mine"],tmpages["bomb"],tmpages["blaster"],sumdamage)
#t = jsmdata.table
#print(t)
#print("_____________")
#pos = jsmdata.makelistofsets()[0]
#neg = jsmdata.makelistofsets()[1]
#print(pos)
#print("_____________")
#print(neg)



#----------------------------------------------------------------------ВЫЗОВ ДСМ
def JSMInduction(OPlus,OMinus,BOC=False):
    # Порождение сходств
    CPCPlus=JSMCreateSimilarities(OPlus)
    CPCMinus=JSMCreateSimilarities(OMinus)
    # Фильтрация по мощности экстенсионала и интенсионала
    FCPCPlus=JSMFiltration(CPCPlus)
    FCPCMinus=JSMFiltration(CPCMinus)
    # Фальсификация
    PCPlus=JSMFalsification(FCPCPlus,FCPCMinus,OMinus,BOC)
    PCMinus=JSMFalsification(FCPCMinus,FCPCPlus,OPlus,BOC)
    # Возвращаем возможные причины
    return (PCPlus,PCMinus)#положительные и отрицательные причины

def JSMCreateSimilarities(O,Method=Norris.Norris):
    return Method(O)

def JSMFiltration(CPC,ExtThreshold=2,IntThreshold=1):
    Ext=0;Int=1
    L=[]
    for i in range(len(CPC)):
        if len(CPC[i][Ext])>=ExtThreshold and len(CPC[i][Int])>=IntThreshold:
            L.append(CPC[i][Int])
    return L

def JSMFalsification(C1,C2,O,BOC=False):
    L=[]
    for a in C1:
        if BOC:
            if [o for o in O if a<=o]==[]:
                L.append(a)
        else:
            if a not in C2:
                L.append(a)
    return L


#---------------------------------------------------------Testing
#---------------------------------------------------------
jsmdata.addcase("case1",1,0,2,15)
jsmdata.addcase("case4",1,1,1,20)
jsmdata.addcase("case2",0,1,1,5)
jsmdata.addcase("case3",0,1,0,3)
t = jsmdata.table
#print(t)
print("_____________")

pos = jsmdata.makelistofsets()[0]
neg = jsmdata.makelistofsets()[1]
print("Положительные примеры:")
print(pos)
print("Отрицательные примеры:")
print(neg)
print("_____________")
print("_____________")
res = JSMInduction(pos, neg)
print("PCPlus")
print(res[0])
print("_____________")
print("PCMinus")
print(res[1])