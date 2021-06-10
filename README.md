# picacomic-api
- vs2019
- .net5.0
- 因为post方式使用了HttpClient,在不改变post方式之前最多支持.net4.5
- nuget只编译了5.0,可以下载源码自行编译4.5+
 
## 如何使用

 - **[NuGet](https://www.nuget.org/packages/picacomic/)** 
 
 - **所有api都在`picacomic.PicacomicUrl`,在调用`picacomic.Header.SetAuthorization("");`保存好token以后就可以使用所有api**
 
 - **所有返回的数据已经解析好对应类返回,错误信息会以异常抛出.**
 
 - **个别几个api会返回空的类,没有数据供解析,没有异常就是正常post**
 
 - **未实现接口`Recommendation`的数据解析,一直返回的数据都是空的,大概接口目前不可用?**
 
 - **未实现下载图片接口,只提供图片下载地址的拼接函数`public static string DownloadBook(string fileServer, string path)`**
 
### 示例
 ```
  var login = await PicacomicUrl.Login("username", "password");
  if (login != null)
  {
     //这个token有使用时长,不建议长期保存,可以运行程序时登录一次
     Header.SetAuthorization(login.Authorization);
  } 
 ```
 
 
# 感谢
  [https://github.com/tonquer/picacg-windows](https://github.com/tonquer/picacg-windows)
  
# 衍生项目
  [哔咔自动签到](https://github.com/FirmianaMarsili/picacomic-Punch)
