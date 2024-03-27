# FlyingAIDemo   
Fly Control AI   
飞行控制AI 相关   
Core Features：  
核心功能：   
1: Path Finding, Navigation in Air, not use A Star algorithm， efficient algorithm suitable for game development OR other models moving projects   
1：可以空中寻路，导航功能， 没有使用 A 星算法， 但是插件的算法更适合游戏 或者有模型相关移动项目    
2：Can find target in Air, do fly sight Perception in Air   
2：可以寻找目标, 可以在空中做视觉的感知   
3：Collision detection in the air, supporting dynamic and static objects，avoid obstacles   
3：在空中进行碰撞检测， 支持动态和静态物体，躲避障碍物   
4：Support adding flying nodes in the behavior tree for easy use   
4：支持在行为树中，添加飞行节点，方便使用   


## Step 1: Prepare items for testing   
### Create a Character for flying AI Control, call it fly bird   
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/d692ee8a-c593-401d-9699-05f222a48ea1)    
### Create Target for fly bird to find and fly to it, set it name BP_Target   
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/659cb305-d9a5-4c33-9abf-617e402ebeb9)   
### Create AIController from FlyingAIController, and it will provide all AI operations for out Fly Bird   
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/445a1369-332b-4d5e-91e7-a7f94a04e651)    
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/062ee379-fa83-44c2-999f-2e06fefd0bba)   
### Set AI Controller for Fly Bird   
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/dabb5d8c-ba67-472e-b620-6a0d99d1354c)   
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/2aeb7bd9-b713-40e5-a945-6c3b4e3e522b)   
### Create Behavior Tree and Black Board for  fly bird    
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/b1e02c7f-b369-4d79-a748-cf36655a4f6c)   
   
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/5261b224-42bf-42b6-81cf-c2a6e0bbbf0b)   
### add UBoxComponent for fly bird, it was used for collection check:   
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/65ee814a-ea47-4915-81a7-f64c39499091)    
This box should just be able to surround the fly bird itself, and then its collection check will be more accurate.   

## Step 2: Configuration for FlyAIController:   
### Configure key data for fly sight perception:      
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/f0265732-b6d6-454f-a8df-9c5b712b36df)   
you can change data as you wanted   

### override function of OnTargetPerceptionUpdate:      
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/8258116d-6202-41ce-b489-672ce62f0a14)     
### we set BP_FlyBird as the value of Enemy Actor we create:    
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/15aacdf7-9f85-4402-982a-b07ba5d70e57)    
### run behavior tree when on possess:    
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/fde532d4-3d70-42e0-8054-8e27eb11bf3e)    

### set fly speed for fly bird:    
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/1a55c432-d02d-4e1a-9296-ac6337f1132f)   


## Step 3: call flyto note in Behavior Tree:    
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/1227ad5f-69de-40d9-9123-1168f885dae8)    
#### and it fly to target actor automatically     
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/7de9bd5e-250a-46ab-8e19-97cf721606be)    
it is used like other nodes in Behavior Tree   


## Step 4: Testing Level preparation:     
1: is for ourself, the fly bird   
2: is for target , should find and fly to    
3: is obstacles, and path finding should avoid this obstacles  
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/504c106d-b885-4221-a790-8011fca874d4)     

## Step 3: Dynamic generate Navigation, path    
first, reset target for self    
second, call this function: StopCurrentNavigation in FlyingAIController:   


