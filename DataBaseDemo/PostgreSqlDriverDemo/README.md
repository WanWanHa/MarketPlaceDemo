# PostgreSQL Driver Demo    
## Provide operations of SELECT, DELETE, UPDATE, ADD for PostgreSQL
plugin link:   
[虚幻商场](https://www.unrealengine.com/marketplace/zh-CN/product/redisoperator)  
[Unreal Market](https://www.unrealengine.com/marketplace/en-US/product/redisoperator)  
introduction videos：   
[B站中国](https://www.bilibili.com/video/BV1cF411A7Ex?share_source=copy_web&vd_source=74c5a7ee7e63695eed9e0f75ba7bbc88)  
[YouTuBe](https://www.youtube.com/watch?v=OoNrNrngZdA&t=5s)  


支持多线程异步，效率高 :     
support multi thre， high performance    
支持数据库需要的，全部的操作，包括 增删改查       
Supports all operations required by the database, including adding, deleting, modifying and select.        


相关接口 :     
some interface ：    
##1: Create Operator Instance 创建 Operator:   
![image](https://github.com/user-attachments/assets/9e04b013-387d-4880-bd65-3b8e288f23f8)      
URL should be like this:  postgresql://accounting@localhost/company,    
address is postgresql ip, database name, username, password      

##2: Execute SQL script:     
![image](https://github.com/user-attachments/assets/fd626791-519b-42d7-bb38-b2be5dbc6291)     
this interface called Execute SQL command,    
it only use for INSERT, UPDATE, USE, Etc command,  WITHOUT SELECT    
注意这个接口不包括  SELECT， 其他的命令都可以包括    


##3: SELECT:        
a: before we send SELECT query, we need to tell PostgreSQL what DataBase we need to use:    
![image](https://github.com/user-attachments/assets/149fd044-aee3-490e-adf9-75734c7db33b)     
yes, throught last command in STEP 2, then we use Execute SQLQuery interface :       
![image](https://github.com/user-attachments/assets/c8a02236-9dc5-4356-adb1-c8b4347e4852)     
### we need to add Event for this Query Command, and PostgreSQL will tell us data we need from this callback Event:    
![image](https://github.com/user-attachments/assets/900afc4c-ee12-447a-9e3a-a2f3600b66c4)     
### we also need to tell PostgreSQL what kind of value in this table, in this sample, we have Integer, String, Float three kind of value in this table:   
![image](https://github.com/user-attachments/assets/95309552-619c-412c-9879-9a4a70237f89)     
### so we create an Array of these three kind type of value:    
![image](https://github.com/user-attachments/assets/fa9b91ca-91c8-458f-a0d9-7d43918265cc)     
### also we need to parse the result use the same order of value type     
![image](https://github.com/user-attachments/assets/69cc40f1-40bd-40c3-82ea-695e2d789533)     

## General Sample:    
![image](https://github.com/user-attachments/assets/c3cb3da3-f969-4331-aa34-3661a501bf82)     




    
