USE [user_entries]
GO

/****** Object:  Table [dbo].[systems]    Script Date: 6/15/2021 8:22:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[systems](
	[uid] [varchar](50) NULL,
	[name] [varchar](50) NULL,
	[rvTotalSize] [float] NULL,
	[IBandSize] [float] NULL,
	[sBandSize] [float] NULL
) ON [PRIMARY]
GO


