USE [wpfproject]
GO

/****** Object: Table [dbo].[WFRoles] Script Date: 30-Dec-21 17:00:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WFRoles] (
    [Id]   INT         NOT NULL,
    [Name] VARCHAR (5) NULL
);

USE [wpfproject]
GO

/****** Object: Table [dbo].[WFUser] Script Date: 30-Dec-21 17:00:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WFUser] (
    [Id]          INT          NOT NULL,
    [User_name]   VARCHAR (50) NOT NULL,
    [Password]    VARCHAR (50) NOT NULL,
    [Role_id]     INT          NULL,
    [First_name]  VARCHAR (10) NULL,
    [Last_name]   VARCHAR (10) NULL,
    [Gender]      BIT          NULL,
    [Birth_day]   DATETIME     NULL,
    [Create_time] DATETIME     NULL,
    [Status]      BIT          NULL
);


INSERT INTO [dbo].[WFRoles] ([Id], [Name]) VALUES (1, N'Admin')
INSERT INTO [dbo].[WFRoles] ([Id], [Name]) VALUES (2, N'User')


INSERT INTO [dbo].[WFUser] ([Id], [User_name], [Password], [Role_id], [First_name], [Last_name], [Gender], [Birth_day], [Create_time], [Status]) VALUES (1, N'admin', N'1', 1, N'Russ', N'Murdy', 1, N'2021-02-16 00:00:00', N'2021-03-13 00:00:00', 0)
INSERT INTO [dbo].[WFUser] ([Id], [User_name], [Password], [Role_id], [First_name], [Last_name], [Gender], [Birth_day], [Create_time], [Status]) VALUES (2, N'user', N'1', 2, N'Smith', N'Quirke', 0, N'2021-08-08 00:00:00', N'2021-09-29 00:00:00', 0)
INSERT INTO [dbo].[WFUser] ([Id], [User_name], [Password], [Role_id], [First_name], [Last_name], [Gender], [Birth_day], [Create_time], [Status]) VALUES (3, N'mlennox2', N'1', 2, N'Marijn', N'Lennox', 1, N'2021-12-22 00:00:00', N'2021-05-21 00:00:00', 0)
INSERT INTO [dbo].[WFUser] ([Id], [User_name], [Password], [Role_id], [First_name], [Last_name], [Gender], [Birth_day], [Create_time], [Status]) VALUES (4, N'nallston3', N'1', 2, N'Nedda', N'Allston', 0, N'2021-11-17 00:00:00', N'2021-01-02 00:00:00', 0)
INSERT INTO [dbo].[WFUser] ([Id], [User_name], [Password], [Role_id], [First_name], [Last_name], [Gender], [Birth_day], [Create_time], [Status]) VALUES (5, N'atilt4', N'1', 2, N'Ardelis', N'Tilt', 1, N'2021-11-30 00:00:00', N'2021-10-22 00:00:00', 0)
INSERT INTO [dbo].[WFUser] ([Id], [User_name], [Password], [Role_id], [First_name], [Last_name], [Gender], [Birth_day], [Create_time], [Status]) VALUES (6, N'jtroubridge5', N'1', 2, N'Juliane', N'Troubridge', 1, N'2021-11-27 00:00:00', N'2021-03-21 00:00:00', 0)
INSERT INTO [dbo].[WFUser] ([Id], [User_name], [Password], [Role_id], [First_name], [Last_name], [Gender], [Birth_day], [Create_time], [Status]) VALUES (7, N'snetting6', N'1', 2, N'Somerset', N'Netting', 1, N'2021-01-20 00:00:00', N'2021-12-25 00:00:00', 0)
INSERT INTO [dbo].[WFUser] ([Id], [User_name], [Password], [Role_id], [First_name], [Last_name], [Gender], [Birth_day], [Create_time], [Status]) VALUES (8, N'sgutans7', N'1', 2, N'Shae', N'Gutans', 1, N'2021-06-13 00:00:00', N'2021-02-12 00:00:00', 0)
INSERT INTO [dbo].[WFUser] ([Id], [User_name], [Password], [Role_id], [First_name], [Last_name], [Gender], [Birth_day], [Create_time], [Status]) VALUES (9, N'adownes8', N'1', 2, N'Augy', N'Downes', 1, N'2021-04-23 00:00:00', N'2021-06-05 00:00:00', 0)
INSERT INTO [dbo].[WFUser] ([Id], [User_name], [Password], [Role_id], [First_name], [Last_name], [Gender], [Birth_day], [Create_time], [Status]) VALUES (10, N'cmacsherry9', N'1', 2, N'Corbin', N'MacSherry', 1, N'2021-02-23 00:00:00', N'2021-10-18 00:00:00', 0)
