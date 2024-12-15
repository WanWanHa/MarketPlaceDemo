# SQLite Driver Demo    
## Provide operations of SELECT, DELETE, UPDATE, ADD for SQLite
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
##1: Execute SQL script:     
![image](https://github.com/user-attachments/assets/9fc8e2bf-ea7f-4580-a0da-86dd0c2e69a1)    
this interface called Execute SQL command,    
it only use for INSERT, UPDATE, USE, Etc command,  WITHOUT SELECT    
注意这个接口不包括  SELECT， 其他的命令都可以包括    


##2: SELECT:        
a: before we send SELECT query, we need to tell MySQL/MariaDB what DataBase we need to use:    
![image](https://github.com/user-attachments/assets/69662a7a-5195-4b24-ae2f-feb6b88d7361)     
yes, throught last command in STEP 1, then we use Execute SQLQuery interface :       
![image](https://github.com/user-attachments/assets/0a180b57-b0d6-43c9-966f-2cd280b0c2ee)     
### we need to add Event for this Query Command, and MySql/MariaDB will tell us data we need from this callback Event:    
![image](https://github.com/user-attachments/assets/4a38bacf-fc31-4dab-8e7b-483e24ccc58d)     
### we also need to tell SQLite what kind of value in this table, in this sample, we have Integer, String, Float three kind of value in this table:   
![image](https://github.com/user-attachments/assets/95309552-619c-412c-9879-9a4a70237f89)     
### so we create an Array of these three kind type of value:    
![image](https://github.com/user-attachments/assets/f96d3f2b-7c91-4cd1-9f7d-880bcc44d09f)       
### also we need to parse the result use the same order of value type     
![image](https://github.com/user-attachments/assets/b2350d30-f67e-45d9-9cd7-9a0752e6ae3e)     

## General Sample:    
![image](https://github.com/user-attachments/assets/48267b67-e5aa-4595-b3d9-c4e10e1b2726)       




    
