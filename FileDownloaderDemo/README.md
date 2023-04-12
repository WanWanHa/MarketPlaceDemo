# FileDownloaderDemo
use HTTP protocol to download any kinds of file

## 1 when the file download completed, bind this delegate, OnFileDownloadCompleted
![image](https://user-images.githubusercontent.com/8192020/215802376-dacd015f-d178-43ef-a0fb-f4bedb87b14c.png)   

## 2 when we download a big size file, we need to know the percentage of file we have already downloaded, we bind this delegate: 
![image](https://user-images.githubusercontent.com/8192020/215802655-536f4799-1d08-4c67-99ce-62d2dee94c0a.png)   
this Proggress shows percentage we downloaded, like this 97%   
![image](https://user-images.githubusercontent.com/8192020/215803201-d6d51956-0e0c-4c5c-8ce4-51a63619157f.png)   


## 3 when download file failed, we should bind this error delegate:   
![image](https://user-images.githubusercontent.com/8192020/215802907-4e761e26-4921-4856-b927-2c76a0c166b0.png)   

## 4 we can compared local downloaded file is changed in server, just bind this delegate to check file if is changed in server:   
![image](https://user-images.githubusercontent.com/8192020/215803769-61e40ae2-3134-4777-a8d1-4f6ad1286498.png)   


# file download path   :   
in Saved/PersistentDownloadDir dir, will create Files directory to save all files we downloaded   
![image](https://user-images.githubusercontent.com/8192020/215806661-576a5374-df4b-4ed9-8753-e886211bbeef.png)
![image](https://user-images.githubusercontent.com/8192020/215806867-1f6626e2-8348-403a-bd05-da6bf1d1b225.png)   
![image](https://user-images.githubusercontent.com/8192020/215806947-2c311650-9845-4d21-b52d-a9b1193f903c.png)   
