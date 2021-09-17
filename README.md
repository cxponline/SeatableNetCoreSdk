<p align="center">
  <a href="https://gitee.com/cxponline/seatable-net-core-sdk">
    <img width="96" src="https://seatable-sdk.oss-cn-qingdao.aliyuncs.com/seatable-sdk.png">
  </a>
</p>

<h1 align="center">SeatableNetCoreSdk</h1>

<div align="center">

一套基于 .NET Core 开发的Seatable SDK集，它极大简化了API调用流程。

[![Build status][github-action-image]][github-action-url]
[![MIT][license-image]](LICENSE.md)

[github-action-image]: https://img.shields.io/github/workflow/status/essensoft/paylink/build/main.svg?style=flat-square
[github-action-url]: https://github.com/essensoft/paylink/actions/workflows/build.yml?query=branch%3Amain
[license-image]: https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square

</div>

## SeatableNetCoreSdk NuGet 包

Package  | NuGet | Downloads | TargetFrameworks
-------- | :---- | :-------- | ---------------
[JackieSoft.SeatableNetCoreSdk][nuget-netcore-sdk-url] | ![NuGet][nuget-netcore-sdk-v-image] | ![Downloads][nuget-netcore-sdk-dt-image] | ![net5.0][net5.0-Y-image]
[JackieSoft.SeatableNetCoreSdk.Auth][nuget-netcore-sdk-auth-url] | ![NuGet][nuget-netcore-sdk-auth-v-image] | ![Downloads][nuget-netcore-sdk-auth-dt-image] | ![net5.0][net5.0-Y-image]
[JackieSoft.SeatableNetCoreSdk.Domain][nuget-netcore-sdk-domain-url] | ![NuGet][nuget-netcore-sdk-domain-v-image] | ![Downloads][nuget-netcore-sdk-domain-dt-image] | ![net5.0][net5.0-Y-image]
[JackieSoft.SeatableNetCoreSdk.DTableDb][nuget-netcore-sdk-dtable-db-url] | ![NuGet][nuget-netcore-sdk-dtable-db-v-image] | ![Downloads][nuget-netcore-sdk-dtable-db-dt-image] | ![net5.0][net5.0-Y-image]
[JackieSoft.SeatableNetCoreSdk.DTableServer][nuget-netcore-sdk-dtable-server-url] | ![NuGet][nuget-netcore-sdk-dtable-server-v-image] | ![Downloads][nuget-netcore-sdk-dtable-server-dt-image] | ![net5.0][net5.0-Y-image]
[JackieSoft.SeatableNetCoreSdk.DTableWeb][nuget-netcore-sdk-dtable-web-url] | ![NuGet][nuget-netcore-sdk-dtable-web-v-image] | ![Downloads][nuget-netcore-sdk-dtable-web-dt-image] | ![net5.0][net5.0-Y-image]
[JackieSoft.SeatableNetCoreSdk.DTableWeb.Admin][nuget-netcore-sdk-dtable-web-admin-url] | ![NuGet][nuget-netcore-sdk-dtable-web-admin-v-image] | ![Downloads][nuget-netcore-sdk-dtable-web-admin-dt-image] | ![net5.0][net5.0-Y-image]
[JackieSoft.SeatableNetCoreSdk.DTableWeb.Org][nuget-netcore-sdk-dtable-web-org-url] | ![NuGet][nuget-netcore-sdk-dtable-web-org-v-image] | ![Downloads][nuget-netcore-sdk-dtable-web-org-dt-image] | ![net5.0][net5.0-Y-image]
[JackieSoft.SeatableNetCoreSdk.Shared][nuget-netcore-sdk-shared-url] | ![NuGet][nuget-netcore-sdk-shared-v-image] | ![Downloads][nuget-netcore-sdk-shared-dt-image] | ![net5.0][net5.0-Y-image]

[nuget-netcore-sdk-url]: https://www.nuget.org/packages/JackieSoft.SeatableNetCoreSdk/
[nuget-netcore-sdk-v-image]: https://img.shields.io/nuget/v/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-netcore-sdk-dt-image]: https://img.shields.io/nuget/dt/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-netcore-sdk-auth-url]: https://www.nuget.org/packages/JackieSoft.SeatableNetCoreSdk.Auth/
[nuget-netcore-sdk-auth-v-image]: https://img.shields.io/nuget/v/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-netcore-sdk-auth-dt-image]: https://img.shields.io/nuget/dt/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-netcore-sdk-domain-url]: https://www.nuget.org/packages/JackieSoft.SeatableNetCoreSdk.Domain/
[nuget-netcore-sdk-domain-v-image]: https://img.shields.io/nuget/v/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-netcore-sdk-domain-dt-image]: https://img.shields.io/nuget/dt/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-netcore-sdk-dtable-db-url]: https://www.nuget.org/packages/JackieSoft.SeatableNetCoreSdk.DTableDb/
[nuget-netcore-sdk-dtable-db-v-image]: https://img.shields.io/nuget/v/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-netcore-sdk-dtable-db-dt-image]: https://img.shields.io/nuget/dt/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-netcore-sdk-dtable-server-url]: https://www.nuget.org/packages/JackieSoft.SeatableNetCoreSdk.DTableServer/
[nuget-netcore-sdk-dtable-server-v-image]: https://img.shields.io/nuget/v/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-netcore-sdk-dtable-server-dt-image]: https://img.shields.io/nuget/dt/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-netcore-sdk-dtable-web-url]: https://www.nuget.org/packages/JackieSoft.SeatableNetCoreSdk.DTableWeb/
[nuget-netcore-sdk-dtable-web-v-image]: https://img.shields.io/nuget/v/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-netcore-sdk-dtable-web-dt-image]: https://img.shields.io/nuget/dt/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-netcore-sdk-dtable-web-admin-url]: https://www.nuget.org/packages/JackieSoft.SeatableNetCoreSdk.DTableWeb.Admin/
[nuget-netcore-sdk-dtable-web-admin-v-image]: https://img.shields.io/nuget/v/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-netcore-sdk-dtable-web-admin-dt-image]: https://img.shields.io/nuget/dt/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-netcore-sdk-dtable-web-org-url]: https://www.nuget.org/packages/JackieSoft.SeatableNetCoreSdk.DTableWeb.Org/
[nuget-netcore-sdk-dtable-web-org-v-image]: https://img.shields.io/nuget/v/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-netcore-sdk-dtable-web-org-dt-image]: https://img.shields.io/nuget/dt/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-netcore-sdk-shared-url]: https://www.nuget.org/packages/JackieSoft.SeatableNetCoreSdk.Shared/
[nuget-netcore-sdk-shared-v-image]: https://img.shields.io/nuget/v/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-netcore-sdk-shared-dt-image]: https://img.shields.io/nuget/dt/Essensoft.Paylink.Alipay.svg?style=flat-square
[net5.0-Y-image]: https://img.shields.io/badge/net5.0-Y-brightgreen.svg?style=flat-square

---

## 开发环境

* Windows 10
* [Visual Studio 2019 16.10](https://visualstudio.microsoft.com)
* [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)

## 运行环境

- [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)

## 使用方式

* [示例项目](https://e.gitee.com/jiejiang_network/repos/jiejiang_network/seatable-netcore-sdk/tree/dev/SeatableNetCoreSdk%2Fsamples%2FWebApplicationSample)

## 捐赠

[捐赠名单](FUNDING.md)

---

<img src="https://seatable-sdk.oss-cn-qingdao.aliyuncs.com/qrcode-pay.png" width="600">

## 社区互助

如果您在使用的过程中碰到问题，可以通过下面几个途径寻求帮助，同时我们也鼓励资深用户通过下面的途径给新人提供帮助。

* QQ群
    - [SeatableNetCoreSdk 交流①群: 744458914](https://seatable-sdk.oss-cn-qingdao.aliyuncs.com/seatable-netcore-sdk-qqun.jpg)        

## 支持渠道

Seatable [文档中心](https://docs.seatable.cn/published/seatable-api/home.md)部分API。

* 同步
    - [home](https://docs.seatable.cn/published/seatable-api/home.md)
    - [dtable-server](https://docs.seatable.cn/published/seatable-api/dtable-server)
        - [base](https://docs.seatable.cn/published/seatable-api/dtable-server/bases.md)
        - [rows](https://docs.seatable.cn/published/seatable-api/dtable-server/rows.md)
    - [dtable-web-v2.1](https://docs.seatable.cn/published/seatable-api/dtable-web-v2.1)
        - [access-token](https://docs.seatable.cn/published/seatable-api/dtable-web-v2.1/access-token.md)
        - [workspaces](https://docs.seatable.cn/published/seatable-api/dtable-web-v2.1/workspaces.md)

    
## 致谢

- [RestSharp](https://restsharp.dev/)
- [Seatable](https://www.seatable.cn/)

## 项目地址

- [GitHub](https://github.com/cxponline/SeatableNetCoreSdk)
- [Gitee](https://gitee.com/cxponline/seatable-net-core-sdk)
