# Redis Operator Demo
operations for redis:    
1：异步多线程方式操作Redis, 效率高，不会阻塞主线程   
2：接口简单， 容易使用    
3：不仅仅支持常用 SET/GET/AUTH 命令，也支持 PUBLISH/PUBLISH 等等
1: Asynchronous multi-threaded operation of Redis, high efficiency, will not block the main thread
2: Simple interface, easy to use
3: Not only supports common SET/GET/AUTH commands, but also supports PUBLISH/PUBLISH, etc.

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
![image](https://github.com/user-attachments/assets/776a0097-4494-4747-8ade-f451aa00f573)   

2: auth:     
![image](https://github.com/user-attachments/assets/87e0b1b8-c211-4d3b-b65a-8955424b42be)    

3: set/get:    
![image](https://github.com/user-attachments/assets/72874791-702e-412c-91a9-36099202f9cb)     
    
4: sub/pub:    
![image](https://github.com/user-attachments/assets/b4f5ba34-96db-48cd-8abd-a5f7b0d176ef)    
