# How To Get Plugin 如何获取插件
[虚幻商场插件 链接](https://www.unrealengine.com/marketplace/zh-CN/product/image-tools)  
[LINK for plugin in Unreal Market](https://www.unrealengine.com/marketplace/zh-CN/product/image-tools)  

# Features list 功能列表
## 1: get image type of image file, get image of image binary   
## 1: 从图片文件来获取该图片的类型， 从图片的二进制数据获取图片的类型
GetImageCategoryFromImageFile:   
![image](https://user-images.githubusercontent.com/8192020/213403079-bc2940bb-2b33-44e5-b5d9-dcbd02e2940b.png)   
GetImageCategoryImageFromBinary:   
![image](https://user-images.githubusercontent.com/8192020/213403204-26427367-163a-417d-a1f9-ae664f0f024b.png)


## 2: Dynamic Get Image file and show it in UI, from image file or image binary
## 2: 动态读取图片文件或者图片数据， 显示在UI 上
two interface:  
![image](https://user-images.githubusercontent.com/8192020/214828363-0cc7bb9b-e19e-427a-90b8-fac06d4c8971.png)   
![image](https://user-images.githubusercontent.com/8192020/214828395-8096740f-9819-4c0d-9bed-06a51448396b.png)   
why we do not use the original interface,    
![image](https://user-images.githubusercontent.com/8192020/214828488-b6957edf-b724-4361-a1b1-23d159780ddb.png)   
because this one can not be provided each pixel color 


## 3: get image color of each pixel, from image file or from image binary
## 3: 从图片文件获取该图片每个像素点的颜色
interface:   
![image](https://user-images.githubusercontent.com/8192020/214828641-8d80ce11-a348-499c-83fb-53684bf1b026.png)   
![image](https://user-images.githubusercontent.com/8192020/214828696-2825c841-a256-417b-91fb-c05473d055ec.png)   
and then we create same color of actor and spawn it in level:   
![image](https://user-images.githubusercontent.com/8192020/214828887-c1b98d3e-bd54-452f-b302-64a42b48ba3a.png)


## 4: save file to asset
## 4: 保存图片为 asset 资源
![image](https://user-images.githubusercontent.com/8192020/226088590-a519c9cb-f6bd-43dc-a07f-e119f24d490e.png)   



Main function for this feature is:
GetImageCategoryFromImageFile:   
![image](https://user-images.githubusercontent.com/8192020/213403079-bc2940bb-2b33-44e5-b5d9-dcbd02e2940b.png)   
GetImageCategoryImageFromBinary:   
![image](https://user-images.githubusercontent.com/8192020/213403204-26427367-163a-417d-a1f9-ae664f0f024b.png)


