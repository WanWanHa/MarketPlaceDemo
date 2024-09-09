# Redis Operator Demo
operations for redis:      
1：异步多线程方式操作Redis, 效率高，不会阻塞主线程     
2：接口简单， 容易使用     
3：不仅仅支持常用 SET/GET/AUTH 命令，也支持 SUBSCRIBE/PUBLISH 等等
4：同时支持这些命令支持，不阻塞      
1: Asynchronous multi-threaded operation of Redis, high efficiency, will not block the main thread    
2: Simple interface, easy to use    
3: Not only supports common SET/GET/AUTH commands, but also supports PUBLISH/PUBLISH, etc.     
4：do these operations at the same time without any block    

plugin link:   
[虚幻商场](https://www.unrealengine.com/marketplace/zh-CN/product/redisoperator)  
[Unreal Market](https://www.unrealengine.com/marketplace/en-US/product/redisoperator)  
introduction videos：   
[B站中国](https://www.bilibili.com/video/BV1cF411A7Ex?share_source=copy_web&vd_source=74c5a7ee7e63695eed9e0f75ba7bbc88)  
[YouTuBe](https://www.youtube.com/watch?v=OoNrNrngZdA&t=5s)    


支持多线程异步，效率高 :     
support multi thre， high performance    
使用虚幻的多线程实现，而不是 STL    
use original Unreal Engine Multi Thread Not STL    


相关接口 :     
some interface ：    
1: connect:   
![image](https://github.com/user-attachments/assets/fa9aa035-1f6e-4c2f-9c8f-f1163cb22522)     
   

2: auth:     
![image](https://github.com/user-attachments/assets/1bfd6be4-9efb-4430-9aa8-982f256f301a)    

3: set/get:    
![image](https://github.com/user-attachments/assets/003513d2-c37a-4598-9c77-215573cc2c14)      
     
    
4: sub/pub:    
![image](https://github.com/user-attachments/assets/6553857e-4f38-4273-b8f7-54a70eaed3d9)    
    
