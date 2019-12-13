USE [ContainerDb]
GO

/****** Object:  Table [dbo].[tblContainerRows]    Script Date: 12/13/2019 8:13:31 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblContainerRows](
	[ContainerRowID] [int] IDENTITY(1,1) NOT NULL,
	[SomeTextValue] [nvarchar](max) NULL,
	[IterationNumber] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](255) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblContainerRows] ADD  CONSTRAINT [DF_tblContainerRows_CreatedOn]  DEFAULT (getutcdate()) FOR [CreatedOn]
GO

ALTER TABLE [dbo].[tblContainerRows] ADD  CONSTRAINT [DF_tblContainerRows_CreatedBy]  DEFAULT (suser_sname()) FOR [CreatedBy]
GO


