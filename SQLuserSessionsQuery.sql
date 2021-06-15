USE [user_entries]
GO

/****** Object:  Table [dbo].[userSessions]    Script Date: 6/15/2021 8:24:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[userSessions](
	[uid] [varchar](50) NULL,
	[downloadID] [varchar](50) NULL,
	[searchID] [varchar](50) NULL,
	[userID] [varchar](50) NULL,
	[timeStart] [datetime] NULL,
	[timeEnd] [datetime] NULL,
	[ipAddress] [varchar](50) NULL
) ON [PRIMARY]
GO


