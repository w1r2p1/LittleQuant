[Here is the English version](./README.md)

LittleQuant是一个支持多个交易品种的自动化交易程序/框架
======================================================

进展
====

- 本项目只是一个初步的实现，可能有设计不合理以及功能缺失的地方
- 目前支持以下交易所
    - 上海证券交易所
        - 个股期权交易，两个实现：CTP、金仕达
        - 股票交易，通过对兴业证券的web交易端执行http请求实现

存在的问题
----------

- 本项目中的一些交易所实现依赖第三方的C++/CLI对原生接口的封装（位于`/vendor`下），这些封装都很久没更新了，我只根据我的需要对这些封装的一部分做了修改，某些地方可能还存在问题

编译
====

- Visual Studio 2015
- 还原nuget包
- 编译你需要的项目，编译结果统一在`target/`文件夹
