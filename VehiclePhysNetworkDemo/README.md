# VehiclePhysNetworkDemo introduction

[Video Link](https://youtu.be/PXeCDExed7k)  
[视频教程](https://www.bilibili.com/video/BV1vA411C7dc/)  
[虚幻商场插件 链接](https://www.unrealengine.com/marketplace/zh-CN/product/VehiclePhysNetwork)  
[LINK for plugin in Unreal Market](https://www.unrealengine.com/marketplace/zh-CN/product/VehiclePhysNetwork)  

# step 1, if you use 5.3 or later version you can inherited from AWheeledVehiclePawn but use this UVehiclePhysNetworkMovementComponent instead
in c++ code, just use UVehiclePhysNetworkMovementComponent to instead the default VehicleMovementComponent    
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/8f14929c-95a4-4199-aa0b-563d8765b867)   
or you can also create this movementcomponent in other Actor    
in Blueprint Code, just create this UVehiclePhysNetworkMovementComponent in components:   
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/2f45382d-f1dd-45a3-9bb3-7c9c3d0dfe56)   

# step 2, if you use 4.27, please sepcify 4.27-chaos branch to make sure the Engine Support the Chaos,    
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/e2ccef4d-bd98-416c-9bc2-59ddac83358f)    
and you should use the Engine by compiled from source code:   
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/af937787-0555-447e-8895-032fc1ae60a4)    
from this version of Engine    



# Step 3, configure the wheels by your vehicle:     
I use a car for testing, so I configure four wheels:    
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/29efce13-3c08-4b9f-9b3d-0f93e9d0c9ec)    
if you use like tank or more than 4 wheels you should configure more:   
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/411c2b40-a074-4221-aeeb-138faef77316)   


