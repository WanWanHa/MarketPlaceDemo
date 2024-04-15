# EosSessionDemo   
Create Session through Steam Platform   
通过Steam 平台创建多人联机会话, 建立房间   多人游戏   
## Step 1: modify the DefaultEngine.ini to use Steam Online SubSystem Session (修改 DefaultEngine.ini 文件, 来使用 Steam平台的 Online SubSystem )   
add/modify the configuration code below in your DefaultEngine.ini file:   
```
[/Script/Engine.GameEngine]
+NetDriverDefinitions=(DefName="GameNetDriver",DriverClassName="OnlineSubsystemSteam.SteamNetDriver",DriverClassNameFallback="OnlineSubsystemUtils.IpNetDriver")


[OnlineSubsystem]
DefaultPlatformService=Steam

[OnlineSubsystemSteam]
bEnabled=true
SteamDevAppId=480
bInitServerOnClient=true


[/Script/OnlineSubsystemSteam.SteamNetDriver]
NetConnectionClassName="OnlineSubsystemSteam.SteamNetConnection"
```
## Step 2: Use the EosSession Plugin in you uproject file / 在你的项目中使用这个 EosSession 插件   
```
{
   "Name": "EosSession",
   "Enabled": true,
   "MarketplaceURL": "com.epicgames.launcher://ue/marketplace/product/c842374dbed84135a5376fbd5f63cf6e"
}
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
![image](https://user-images.githubusercontent.com/8192020/232368982-739fdeac-e894-4d69-8089-ead2bba0552c.png)     
### OnFindSession, This Delegate will be called after FindSession function called, 这个回调将会在  FindRoomSession 函数被调用之后:   
![image](https://user-images.githubusercontent.com/8192020/232369156-4997e304-a0eb-4c1b-81c0-667c4956aab8.png)   
### OnJoinSession, This Delegate will be called after JoinRoomSession Function called, 这个回调将会在 JoinRoomSession 函数被调用之后:   
![image](https://user-images.githubusercontent.com/8192020/232369313-dd80b5dc-3bf7-47f6-85fd-3efa967927a1.png)   

## Step 5: To Create Session in one Client PC,  here we use a button in UI with its callback function/ 创建 会话在一台机器的客户端中, 这里我们使用UI中的按钮回调来实现:   
### this CREATE Button  /  这个 创建按钮:   
![image](https://user-images.githubusercontent.com/8192020/232369682-58dd110b-4583-48dd-b450-326ac104377f.png)   
### and in its callback function:   
![image](https://user-images.githubusercontent.com/8192020/232369777-78db6b1c-d19d-419f-9cfa-e9f100ef403e.png)   
### fill the parameter with these:   
```
Session Pair Key: MatchType
Session Pair Value: FreeForAll
```
### after clicked this button, if the session is created successfully, / 在点击这个按钮之后, 如果会话会被成功创建    
![image](https://user-images.githubusercontent.com/8192020/232370217-327c72f8-5e10-45c6-b7a4-95adf7bbd65d.png)     
###  the client will enter new lobby level/ , 客户端会进入到新的场景:     
![image](https://user-images.githubusercontent.com/8192020/232370295-0285fab7-0bc8-44ed-a718-1616bc84fbfa.png)   

## Step 6: To Join Session in the other Client PC, here we use a button in UI with its callback function/ 加入会话在另一台机器客户端中进行, 这里我们用UI中的加入按钮回调实现:   
### this JOIN Button/ 这个 加入按钮:    
![image](https://user-images.githubusercontent.com/8192020/232370693-93f88021-9e17-464f-96a8-03e16bdb8cba.png)   
### you can use the default parameter to fill/ 你可以使用默认的参数来加入   
![image](https://user-images.githubusercontent.com/8192020/232371297-7d2ab575-d4b4-495e-850e-8bc3d86a0aa4.png)   
### after clicked this button, if the session is found successfully,/ 在点击这个按钮之后, 如果会话被成功查找,   
![image](https://user-images.githubusercontent.com/8192020/232370836-396422ff-fe8f-4a8f-9f3b-a7ea4a2a93e4.png)   
### this delegate will be called / 这个回调会被调用:   
![image](https://user-images.githubusercontent.com/8192020/232370995-5b440537-c342-40a7-b55b-225f4edf34dc.png)   
###  we will call the JoinRoomSession to join session after we found sessions successfully/ 我们会调用 JoinRoomSession 来加入会话, 在我们发现会话成功之后:   
![image](https://user-images.githubusercontent.com/8192020/232371206-429261f6-cd51-458e-9a72-6226e64cd89e.png)    
###  after we join session success, client will enter into new level which the host created before / 在加入会话成功之后,  客户端会进入另一个场景, 也就是主机创建的地图    
![image](https://user-images.githubusercontent.com/8192020/232371731-25c7ef3f-633f-41a5-99d9-6ed5b8327465.png)   
### we can see the old client before  / 我们可以看到之前的客户端:   
![image](https://user-images.githubusercontent.com/8192020/232372012-a9a8ad20-8b59-454c-bb0f-e07827442b3e.png)





