# MySQL & MariaDB Operator Demo    
## Provide operations of SELECT, DELETE, UPDATE, ADD for MySQL and MariaDB
### [获取plugin get plugin link](https://buy.stripe.com/3cs14f3K5cq198I7sw):     
[虚幻商场](https://www.unrealengine.com/marketplace/zh-CN/product/redisoperator)  
[Unreal Market](https://www.unrealengine.com/marketplace/en-US/product/redisoperator)  
introduction videos：   
[YouTuBe](https://youtu.be/RdY1BI64QqQ?si=FIuxmg-5Qh4Om8GD)  
[B站中国](https://www.bilibili.com/video/BV1r7UNY2EoB)  


支持多线程异步，效率高 :     
support multi thre， high performance    
支持数据库需要的，全部的操作，包括 增删改查       
Supports all operations required by the database, including adding, deleting, modifying and select.        


相关接口 :     
some interface ：    
##1: Create Operator Instance 创建 Operator:   
![image](https://github.com/user-attachments/assets/eef548a3-a83f-45be-859c-3d4131c5e2f7)     
URL should be like this:  tcp://127.0.0.1:20929,    
tcp is for protocol, MySql/MariaDB IP address, and Port For MySql/MariaDB    

##2: Execute SQL script:     
![image](https://github.com/user-attachments/assets/a264b154-58ac-4221-920a-5c0891534428)    
this interface called Execute SQL command,    
it only use for INSERT, UPDATE, USE, Etc command,  WITHOUT SELECT    
注意这个接口不包括  SELECT， 其他的命令都可以包括    


##3: SELECT:        
a: before we send SELECT query, we need to tell MySQL/MariaDB what DataBase we need to use:    
![image](https://github.com/user-attachments/assets/149fd044-aee3-490e-adf9-75734c7db33b)     
yes, throught last command in STEP 2, then we use Execute SQLQuery interface :       
![image](https://github.com/user-attachments/assets/c8a02236-9dc5-4356-adb1-c8b4347e4852)     
### we need to add Event for this Query Command, and MySql/MariaDB will tell us data we need from this callback Event:    
![image](https://github.com/user-attachments/assets/900afc4c-ee12-447a-9e3a-a2f3600b66c4)     
### we also need to tell MySql/MariaDB what kind of value in this table, in this sample, we have Integer, String, Float three kind of value in this table:   
![image](https://github.com/user-attachments/assets/95309552-619c-412c-9879-9a4a70237f89)     
### so we create an Array of these three kind type of value:    
![image](https://github.com/user-attachments/assets/fa9b91ca-91c8-458f-a0d9-7d43918265cc)     
### also we need to parse the result use the same order of value type     
![image](https://github.com/user-attachments/assets/69cc40f1-40bd-40c3-82ea-695e2d789533)     

## General Sample:    
![image](https://github.com/user-attachments/assets/1bf2692a-a28a-4262-8af8-69bb38d6b8d9)    




    
