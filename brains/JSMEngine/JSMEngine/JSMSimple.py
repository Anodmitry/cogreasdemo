# -*- coding: utf-8 -*-

import Norris

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


def JSMAnalogy(OPlus,OMinus,OTau,OContra,CPlus,CMinus):
    StopCondition=True
    OTau2=OTau[:]#чтобы скопировался список, а не только ссылка на него
    for o in OTau2:
        PlusCondition=([c for c in CPlus if c<=o]!=[])
        MinusCondition=([c for c in CMinus if c<=o]!=[])
        if PlusCondition and not MinusCondition:
            OPlus.append(o); OTau.remove(o); StopCondition=False
        elif MinusCondition and not PlusCondition:
            OMinus.append(o); OTau.remove(o); StopCondition=False
        elif PlusCondition and MinusCondition: 
            OContra.append(o); OTau.remove(o); StopCondition=False
    return StopCondition

def WriteResult(k,OPlus,OMinus,OTau,OContra,CPlus,CMinus):
    print()
    print("Iteration ",k)
    if k>0:
        print("CPlus =",CPlus,"(",len(CPlus),")")
        print("CMinus=",CMinus,"(",len(CMinus),")")        
    print("OPlus =",OPlus,"(",len(OPlus),")")
    print("OMinus =",OMinus,"(",len(OMinus),")")
    print("OContra =",OContra,"(",len(OContra),")")
    print("OTau =",OTau,"(",len(OTau),")")
    

def JSMRun(OPlus,OMinus,OTau,OContra,BOC=False):
    StopCondition=False
    k=0
    WriteResult(k,OPlus,OMinus,OTau,OContra,[],[])
    while not StopCondition:
        k+=1
        CPlus,CMinus=JSMInduction(OPlus,OMinus,BOC)
        StopCondition=JSMAnalogy(OPlus,OMinus,OTau,OContra,CPlus,CMinus)
        WriteResult(k,OPlus,OMinus,OTau,OContra,CPlus,CMinus)
    
OPlus=[{"лук", "меч"}, {"лук", "копье"}, {"меч", "копье"}] 
OMinus=[{"мотыга", "серп"},{"серп", "соха"}, {"соха", "мотыга"}]
#OTau=[{"лук", "арбалет"},{"меч", "арбалет"},{"арбалет", "шпага"},
#      {"меч", "шпага"},{"шпага", "мушкет"},{"шпага", "пистолет"},
#      {"арбалет", "мушкет"},{"арбалет", "пистолет"},{"мушкет", "ружье"},
#      {"пистолет", "ружье"},{"ружье", "винтовка"},{"пистолет", "винтовка"},
#      {"винтовка", "пулемет"},{"пистолет", "пулемет"},{"пистолет", "револьвер"},
#      {"винтовка", "револьвер"},{"серп", "коса"},{"мотыга", "коса"},
#      {"мотыга", "плуг"},{"соха", "плуг"},{"коса", "косилка"},
#      {"плуг", "косилка"},{"плуг", "трактор"},{"косилка", "трактор"}]
#OContra=[]#противоречивые примеры, которые пополняются во время аналогии
#JSMRun(OPlus,OMinus,OTau,OContra)





    
    
