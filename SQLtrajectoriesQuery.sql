USE [user_entries]
GO

/****** Object:  Table [dbo].[trajectories]    Script Date: 6/15/2021 8:23:28 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[trajectories](
	[uid] [varchar](50) NULL,
	[systemID] [varchar](50) NULL,
	[name] [varchar](50) NULL,
	[launchTime] [datetime] NULL,
	[launchName] [varchar](50) NULL,
	[launchLocation] [float] NULL
) ON [PRIMARY]
GO


