# 小恐龙快跑

![Language](https://img.shields.io/badge/language-C%23-blue)
![License](https://img.shields.io/badge/license-MIT-green)

“小恐龙快跑”是一个模仿 Chrome 浏览器离线小游戏“恐龙快跑”的 Windows 应用程序，作为 Windows 程序设计课程的成果。

## 软件架构

本项目采用三层架构：

- **表示层（UI）：** 负责与用户交互，显示游戏界面和相关信息。
- **业务逻辑层（BLL）：** 处理游戏的核心逻辑，包括用户操作、得分计算等。
- **数据访问层（DAL）：** 负责与数据库交互，进行数据的存取和管理。

这种架构增强了系统的可扩展性、可维护性和可重用性。

## 数据库设计

项目使用结构化数据库存储数据，涉及以下功能：

- **用户登录注册：** 管理用户账户的创建和验证。
- **游戏得分记录：** 保存玩家的历史成绩。
- **商店系统：** 处理游戏内商店的购买记录。

仓库中提供了数据库表的创建 SQL 文件（`little_dinosaur.sql`），可用于初始化数据库。

## 开发工具

- **集成开发环境（IDE）：** Microsoft Visual Studio 2022
- **数据库管理系统（DBMS）：** Microsoft SQL Server
- **实体框架（ORM）：** Entity Framework Core 8.0.5

## 项目运行

1. 使用 Visual Studio 2022 打开解决方案文件 `little_dinosaur_jump.sln`。
2. 在 SQL Server 中执行提供的 SQL 脚本（`little_dinosaur.sql`）以创建所需的数据库和数据表。
3. 在项目中配置数据库连接字符串，确保其指向正确的 SQL Server 实例。
4. 编译并运行项目，开始体验小恐龙快跑游戏。

请确保在运行项目之前，已正确安装并配置所需的开发工具和数据库环境。


## 贡献

欢迎对本项目提出建议或贡献代码。请遵循以下步骤：

1. Fork 本仓库
2. 创建您的特性分支 (`git checkout -b feature/AmazingFeature`)
3. 提交您的更改 (`git commit -m 'Add some AmazingFeature'`)
4. 推送到分支 (`git push origin feature/AmazingFeature`)
5. 打开一个 Pull Request


如需更多信息，请访问项目的 GitHub 页面：


