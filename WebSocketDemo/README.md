# WebSocketDemo introduction

# step 1, build the websocket server (if you already have a websocket server, ignore this step)   
clone code from this repo, [LINK](https://github.com/MacroGu/WebSocketServer)   
and run this server

# step 2, Create Websocket,    
you can use CreateCustomWebSocket to create a websocket, and it will init steps for you, but you can still create an attribute of CustomWebSocket, and use it for any operations   
fill the target server address here:   
![image](https://user-images.githubusercontent.com/8192020/215428208-5b1c0661-b301-4da5-95c3-8d90748b49dc.png)   
or you can change it in this function:   
![image](https://user-images.githubusercontent.com/8192020/215424368-befdeed7-ea3b-4c58-b273-34704bb88b62.png)   
bind event for each delegate you care about:   
the Connected event, will called when connected to server:   
![image](https://user-images.githubusercontent.com/8192020/215424558-36ec74fd-2eb5-4db2-b114-83f1cb7d66e6.png)   
the connection error event, will called when connected to server failed:   
![image](https://user-images.githubusercontent.com/8192020/215424664-e13600a6-afc8-485e-a366-8d226e7d4146.png)   
the message received event, will be called when received from server:   
![image](https://user-images.githubusercontent.com/8192020/215424809-e2a79c2a-0ccf-4496-8fd2-b1a0ad89265d.png)   
then Message Send event, will be called when message send to server successfully:   
![image](https://user-images.githubusercontent.com/8192020/215424924-66e521cb-2c9d-4efc-a0e2-18cf8b1a28cf.png)   

# Step 3, Connect to server   
use Connect to Server function to connect to server   
![image](https://user-images.githubusercontent.com/8192020/215425059-93428a57-4f82-4764-a080-85e0700fab43.png)   

# Step 4, send meesage to server   
use Send Message to Server to send message:   
![image](https://user-images.githubusercontent.com/8192020/215425189-abf5d5f2-172d-45ea-8659-6d8a8e9f31b7.png)   







