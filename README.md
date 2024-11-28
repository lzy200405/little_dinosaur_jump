# 小恐龙快跑

*这是我的windows程序设计课程的期末作业,现在使用GitHub Page展示出来*

## 软件层次
小恐龙快跑采用三层架构:表示层,业务逻辑层,数据处理层,每一层负责特定的功能。三层架构的主要目的是增强系统的可扩展性、可维护性和可重用性.通过将不同的功能模块分开，可以更方便地进行开发、测试和维护.
使得应用的层次更加分明,符合现代的程序开发流程.

## 数据库
小恐龙快跑使用了结构化的数据库进行存储,对于登陆注册,游戏的得分和商店的处理,采用了三个数据表进行存储.
文件已经提供表的创建sql文件

## 开发工具
该项目采用了来自微软的virtual studio 2022进行开发,数据库采用的同样是来自微软的SQL Server,采用了EF框架,分别使用Microsoft.EntityFrameworkCore.SqlServe 版本：最新稳定版8.0.5,
Microsoft.EntityFrameworkCore.Design 版本：最新稳定版8.0.5,Microsoft.EntityFrameworkCore.Tools 版本：最新稳定版8.0.5

