USE [user_entries]
GO

/****** Object:  Table [dbo].[users_info]    Script Date: 6/15/2021 8:23:49 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[users_info](
	[uid] [varchar](50) NULL,
	[firstName] [varchar](50) NULL,
	[lastName] [varchar](50) NULL,
	[userName] [varchar](50) NULL,
	[password] [varchar](50) NULL
) ON [PRIMARY]
GO


