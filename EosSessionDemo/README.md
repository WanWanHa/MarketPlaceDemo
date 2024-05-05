[虚幻商场插件 链接](https://www.unrealengine.com/marketplace/en-US/product/eossession)  
[LINK for plugin in Unreal Market](https://www.unrealengine.com/marketplace/en-US/product/eossession)  
[视频教程 1 链接](https://www.bilibili.com/video/BV1UC411E7wT/)  
[video tutorial 1 LINK](https://youtu.be/-clv9tRyyYE)  

# EosSessionDemo   
Create Session through EOS Epic Online Subsystem Platform   
通过 EOS Epic Online Subsystem 平台创建多人联机会话, 建立房间   多人游戏   
## Step 1: modify the DefaultEngine.ini to use EOS Epic Online Subsystem Session (修改 DefaultEngine.ini 文件, 来使用 EOS Epic  平台的 Online SubSystem )   
add/modify the configuration code below in your DefaultEngine.ini file:   
```
[OnlineSubsystemEOS]
bEnabled=true
bUseSessionPresenceAttribute=True

[OnlineSubsystem]
DefaultPlatformService=EOS

[/Script/Engine.GameEngine]
+NetDriverDefinitions=(DefName="GameNetDriver",DriverClassName="OnlineSubsystemEOS.NetDriverEOS",DriverClassNameFallback="OnlineSubsystemUtils.IpNetDriver")

[/Script/OnlineSubsystemEOS.NetDriverEOS]
bIsUsingP2PSockets=true
```
## Step 2: Use the EosSession Plugin in you uproject file / 在你的项目中使用这个 EosSession 插件   
```
		{
			"Name": "EosSession",
			"Enabled": true,
			"MarketplaceURL":          
         "com.epicgames.launcher://ue/marketplace/product/c842374dbed84135a5376fbd5f63cf6e"
		},
```      

## Step 3: use the EosSession module in you Porject.Build.cs file / 在你的 Project.build.cs 文件中使用这个 EosSession 模块:   
```
        PrivateDependencyModuleNames.AddRange(new string[]
        {
            "EosSession"
        });
```

## Step 4: Bind the Callback Delegate in the consturct function or Begin Play function/ 在UI 构造函数或者其他BeginPlay的函数中, 绑定需要的委托回调:   
### OnCreateSession,  this Delegate will be called after CreateRoomSession function Called, 这个回调将会在CreateRoomSession 函数被调用之后:   
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/7d42fa57-240d-437c-aeb1-42eaebaafd69)     
### OnFindSession, This Delegate will be called after FindSession function called, 这个回调将会在  FindRoomSession 函数被调用之后:   
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/bd291c26-b92e-499e-a5a1-90b7db89f1f4)    
### OnJoinSession, This Delegate will be called after JoinRoomSession Function called, 这个回调将会在 JoinRoomSession 函数被调用之后:   
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/b5f52750-964e-40c2-a448-eefbb4a14e6d)    

## Step 5: To Create Session in one Client PC,  here we use a button in UI with its callback function/ 创建 会话在一台机器的客户端中, 这里我们使用UI中的按钮回调来实现:   
### this Join Button / 这个是 登录 Epic Online Subsystem 按钮:    
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/c516a1b9-1fe3-484e-a225-7cb63aa92590)    
### this CREATE Button  /  这个 创建按钮:    
![image](https://user-images.githubusercontent.com/8192020/232369682-58dd110b-4583-48dd-b450-326ac104377f.png)     
### and in its callback function:   
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/5ab0ade0-0a95-4181-8106-e82669a9e1fd)      
### fill the parameter with these:   
```
Session Pair Key: MatchType
Session Pair Value: FreeForAll
```

### Login EOS first / 登录 EOS 
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/efed7c39-eb5d-4c58-ad91-5d09ca08c9fa)   
### after clicked this button, if the session is created successfully, / 在点击这个按钮之后, 如果会话会被成功创建    
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/4d9445f4-fd59-4950-b72b-17f646054c43)       
###  the client will enter new lobby level/ , 客户端会进入到新的场景:     
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/bce1e70f-670b-44e3-8582-2fe0580bba0e)     

## Step 6: To Join Session in the other Client PC, here we use a button in UI with its callback function/ 加入会话在另一台机器客户端中进行, 这里我们用UI中的加入按钮回调实现:   
### this JOIN Button/ 这个 加入按钮:    
![image](https://user-images.githubusercontent.com/8192020/232370693-93f88021-9e17-464f-96a8-03e16bdb8cba.png)   
### you can use the default parameter to fill/ 你可以使用默认的参数来加入   
![image](https://user-images.githubusercontent.com/8192020/232371297-7d2ab575-d4b4-495e-850e-8bc3d86a0aa4.png)   
### after clicked this button, if the session is found successfully,/ 在点击这个按钮之后, 如果会话被成功查找,   
![image](https://github.com/WanWanHa/MarketPlaceDemo/assets/8192020/84b9661c-f9a0-4cae-90dd-4e6cee907eda)   
   






