# WanWanHaGrpcDemo introduction

[Video Link](https://youtu.be/PXeCDExed7k)  
[视频教程](https://www.bilibili.com/video/BV1vA411C7dc/)  
[虚幻商场插件 链接](https://www.unrealengine.com/marketplace/zh-CN/product/websocket)  
[LINK for plugin in Unreal Market](https://www.unrealengine.com/marketplace/zh-CN/product/websocket)  

# step 1, generate code for proto
in Tools folder:   
![image](https://github.com/WanWanHa/MarketPlacePluginsDemo/assets/8192020/bd5a6b11-9a6d-416b-b41c-845e5d18caf7)   

use this bat script command:   
```cpp
.\generate_code.cmd missile.proto D:\OutSource\GRpc\Project_gRPC\Plugins\TurboLink\Tools
```
after this executed, two folder will be generated:   
![image](https://github.com/WanWanHa/MarketPlacePluginsDemo/assets/8192020/fac1a016-2f4e-4748-8385-5c2e3697c7ad)   

# step 2, copy generated two folder to your Plugins/WanWanHaGrpc/Source/ Folder   
![image](https://github.com/WanWanHa/MarketPlacePluginsDemo/assets/8192020/e1a22b90-5a9e-4ba3-9583-8fcc655e0a8e)    

# step 3, generate solution and compile it:   
![image](https://github.com/WanWanHa/MarketPlacePluginsDemo/assets/8192020/ced96fa8-191f-426a-aeec-59a417e68bb8)   

# step 4, set server address in configure panel of Unreal Editor:   
it should be in Project Settings:   
![image](https://github.com/WanWanHa/MarketPlacePluginsDemo/assets/8192020/dfd9556c-dc75-413c-8566-82bd43db3e3e)   

# step 5, connect to server:   
![image](https://github.com/WanWanHa/MarketPlacePluginsDemo/assets/8192020/79f28f3a-4d95-488d-b179-7bdadefc28a8)   
this Service Name should be GreeterService, it depends on your proto file Service definition:   
and then bind event of Service Status Change, and then call Connect:   
![image](https://github.com/WanWanHa/MarketPlacePluginsDemo/assets/8192020/41db3df4-681a-45e4-8907-5d41a00326f1)   

# step 6, sample 1 Client Call RPC to Server:   
![image](https://github.com/WanWanHa/MarketPlacePluginsDemo/assets/8192020/89976428-add2-4ab5-b4e1-76f9c7110a56)   
this rpc is call_showtime, will get time from server:   
![image](https://github.com/WanWanHa/MarketPlacePluginsDemo/assets/8192020/f9d1e939-8f0d-4f70-b9f3-bad724db093c)   

# step 6, sample 2 Server get client's info from RPC:   
we have three actor in Level, and their ID is ,1,2,3    
![image](https://github.com/WanWanHa/MarketPlacePluginsDemo/assets/8192020/c6d6ac5f-668c-436c-9f71-4a82ccde4a25)   
ID set here:   
![image](https://github.com/WanWanHa/MarketPlacePluginsDemo/assets/8192020/99e24ddc-7419-49eb-94b4-d63399fdc795)   
input id in server, you want to use:   
![image](https://github.com/WanWanHa/MarketPlacePluginsDemo/assets/8192020/034bd679-d88a-472e-ba65-a4d6200478bf)   

after input actor ID, we get these three actor's info:   

![image](https://github.com/WanWanHa/MarketPlacePluginsDemo/assets/8192020/26161652-138f-42e9-8e75-6f64afe221d6)   












