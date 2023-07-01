# picacomic-api
- .net6.0
 
## 如何使用

 - **[NuGet](https://www.nuget.org/packages/picacomic/)** 
 
 - **所有api都在[Picacomic.PicAcgReq](https://github.com/FirmianaMarsili/picacomic-api/blob/c58b3c2d47e48caa0205fac578992251913888c4/picacomic/Http/PicAcgReq.cs#L125),登陆成功以后调用[Picacomic.Header.SetAuthorization("");](https://github.com/FirmianaMarsili/picacomic-api/blob/c58b3c2d47e48caa0205fac578992251913888c4/picacomic/Http/Header.cs#L167)保存好token以后就可以使用所有api**
 
 - **所有返回的数据已经解析好对应类返回,错误信息会以[异常](https://github.com/FirmianaMarsili/picacomic-api/blob/c58b3c2d47e48caa0205fac578992251913888c4/picacomic/Http/HttpWeb.cs#L42)抛出.**
 
 - **个别几个api会返回空的类,没有数据供解析,没有异常就是正常post**
   
 - **返回的数据绝大多数都已添加注释。~~不然自己隔两年用都要想一下~~** 
 
### 示例
 ```
  //登录
  var login = await PicAcgReq.Login("username","password");
  //设置token，这个token有使用时长,不建议长期保存,可以运行程序时登录一次
  Header.SetAuthorization(login.Authorization);
  //获取热词
  Console.WriteLine( string.Join('\n', PicAcgReq.GetKeywords().Result.Keyword));
 ```
 
 
# 感谢
  [https://github.com/tonquer/picacg-windows](https://github.com/tonquer/picacg-windows)
  
# 衍生项目
  [哔咔自动签到](https://github.com/FirmianaMarsili/picacomic-Punch)
