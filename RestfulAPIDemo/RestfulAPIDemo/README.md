# RestfulAPIDemo
Http operations and json parser, web token
plugin link:   
[虚幻商场](https://www.unrealengine.com/marketplace/zh-CN/product/restful-api-json-web-token-http?lang=zh-CN)  
[Unreal Market](https://www.unrealengine.com/marketplace/en-US/product/restful-api-json-web-token-http)  
introduction videos：   
[B站中国 第一部分](https://www.bilibili.com/video/BV1cF411A7Ex?share_source=copy_web&vd_source=74c5a7ee7e63695eed9e0f75ba7bbc88)  
[B站中国 第二部分](https://www.bilibili.com/video/BV1Z94y1D7BV?share_source=copy_web&vd_source=74c5a7ee7e63695eed9e0f75ba7bbc88)  
[B站中国 3](https://www.bilibili.com/video/BV1n8411K7fg/?spm_id_from=333.999.0.0&vd_source=a469877844c9c82cdc57fc0d3c386028)  
[YouTuBe](https://www.youtube.com/watch?v=OoNrNrngZdA&t=5s)  
[YouTuBe Part One](https://youtu.be/jYEhRYz5ZXA)  
[YouTuBe Part Two](https://youtu.be/OoNrNrngZdA)  
[YouTuBe Part 3](https://youtu.be/c4_Fp8S95ts)  

for plugin usage :  
step 1:
get the plugin and place it in folder:  
![image](https://user-images.githubusercontent.com/8192020/181268201-59b1387d-bc52-47b6-a2b7-3ec017441f09.png)
![image](https://user-images.githubusercontent.com/8192020/181268329-57fee350-0846-4c66-abcf-11e88faedfe6.png)

step 2:  
generate the solution of visual studio  
![image](https://user-images.githubusercontent.com/8192020/181284254-7f144f34-4afd-4ffb-89d2-0eeaf56b3f35.png)


step 3:  
build solution  
![image](https://user-images.githubusercontent.com/8192020/181269230-808c14b9-0e37-4d00-8959-45f92bc97518.png)

step 4:  
open project in Unreal Editor, and open the default level blueprint   

step 5:   
get token:  
![image](https://user-images.githubusercontent.com/8192020/181269757-0064fbfc-5f82-4906-90ba-d447ef92c326.png)
fill the parameter to get token need  
![image](https://user-images.githubusercontent.com/8192020/181289187-c343f45a-8b41-4ed5-8842-2533827daf2d.png)  
add the on success and on failed event for send get token request  
![image](https://user-images.githubusercontent.com/8192020/181289314-91674359-1aab-4675-87c4-ba7a66132d8f.png)
store the token we get from the server and it could be used later  
![image](https://user-images.githubusercontent.com/8192020/181289508-5bb4c84c-b263-4010-9cf0-279fe130ab0c.png)



step 6:  
use token send request:   
![image](https://user-images.githubusercontent.com/8192020/181269853-c323401e-84ae-4350-86a0-741f1f740807.png)  
this blueprint interface is used to send request to server with token  
![image](https://user-images.githubusercontent.com/8192020/181289832-61c8065e-a8aa-4fa4-8a1a-f6cfb426eda3.png)  
here is the token we got before  
![image](https://user-images.githubusercontent.com/8192020/181289880-8747286e-889f-4ac9-971c-44672f133992.png)  
add the on success and on failed event of this request  
![image](https://user-images.githubusercontent.com/8192020/181291126-def97897-0dbd-4c80-a8a1-539a2c919dfb.png)  


