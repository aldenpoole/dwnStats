USE [user_entries]
GO

/****** Object:  Table [dbo].[downloads]    Script Date: 6/15/2021 8:21:11 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[downloads](
	[uid] [varchar](50) NULL,
	[trajectoryID] [varchar](50) NULL,
	[systemID] [varchar](50) NULL,
	[downloadSize] [float] NULL,
	[downloadTime] [datetime] NULL
) ON [PRIMARY]
GO


