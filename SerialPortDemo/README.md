同时支持多个串口通信使用，Support multi serial Port Communication at the same time    
# How To Get Plugin 如何获取插件
[虚幻商场插件 链接](https://www.unrealengine.com/marketplace/en-US/product/serialport-01)  
[LINK for plugin in Unreal Market](https://www.unrealengine.com/marketplace/en-US/product/serialport-01)  

# Step 1    
## 1: bind callback function for get message from serial port communication message    
## 1: 绑定从串口读取消息的回调函数   
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/ed117493-eef1-4fad-ba7a-bde1a90697cb)    
   
# Step 2    
## 2: Create Serial Port    
## 2: 创建串行端口    
only one parameter you need to fill is Port Number, other parameter you can use default value for initialize     
只有一个参数是你必须要填写的，  其他的参数你可以使用默认值来初始化    
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/b0696983-6ca1-4e05-960b-ef051b1332cd)    

#  FINISHED !!!
## TEST    
我们输出每次从串行端口获取到的数据， 每次回调， 都会说明是哪个串行端口输出的数据：   
we print data received from serial Port, each time call back function, it will tell you these data are from which port exactly    
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/20e02994-3a66-4e09-ada9-12bd60675f66)    

通信成功输出， 结果  Output Result of serial port communication:    
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/fa4570f6-c77f-4ff4-a829-a18166c330ee)    
