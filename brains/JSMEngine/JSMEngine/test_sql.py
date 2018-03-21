#import clr
#clr.AddReference('System.Data')
#from System.Data import *

#def start():
#    try:
#        TheConnection = SqlClient.SqlConnection("server=DESKTOP-KUCHETF\SQLEXPRESS;database=envdb_mini;uid=admin;password=adminadmin;timeout=0")
#        TheConnection.Open()

#        MyAction = SqlClient.SqlCommand("Select * from move_history_for_jsm", TheConnection)
#        MyReader = MyAction.ExecuteReader()

#        objects = []#objects on the map
#        robot_coord = []
#        objects_coord = []
#        was_seen = []#["23:11:00"]#the time which was seen earlier
#        while MyReader.Read():
#            if MyReader[5] in was_seen:
#                continue
        
#            if MyReader[1] == '4':#if robot
#                robot_coord = [MyReader[3],MyReader[4]]
#                continue

#            tmp = [MyReader[0],MyReader[1],MyReader[2],MyReader[3],MyReader[4],MyReader[5]]
#            objects.append(tmp)
        
#            tmp.pop()#without time
#            objects_coord.append(tmp)
#            #print(str(MyReader[0])+"|"+str(MyReader[1])+"|"+str(MyReader[2])+"|"+str(MyReader[3])+"|"+str(MyReader[4])+"|"+str(MyReader[5]))

#        print(objects, robot_coord)
#        print(objects_coord)

#        MyReader.Close()
#        TheConnection.Close()

#        print("success")

#        #threat_type(robot_coord, objects_coord)
#    except Exception as e:
#        print(e)


#def threat_type(robot_coord, objects_coord):
#    #sum(robot_coord, objects_coord)
#    return "name of threat type"


#start()