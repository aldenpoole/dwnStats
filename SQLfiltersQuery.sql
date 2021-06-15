USE [user_entries]
GO

/****** Object:  Table [dbo].[filters]    Script Date: 6/15/2021 8:22:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[filters](
	[uid] [varchar](50) NULL,
	[launchCountry] [varchar](50) NULL,
	[launchLocation] [varchar](50) NULL,
	[launchTime] [datetime] NULL
) ON [PRIMARY]
GO


