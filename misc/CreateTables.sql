USE [ProjectControl]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--DROP TABLE [dbo].[PCTask]
CREATE TABLE [dbo].[PCTask](
	[CompanyID] [int] DEFAULT ((0)) NOT NULL,
	[TaskType] [char](2) NOT NULL,
	[TaskNbr] [nvarchar](15) NOT NULL,
	[Status] [char](1) NOT NULL,
	[Description] [nvarchar](60) NULL,
	[ParentTaskType] [char](2) NULL,
	[ParentTaskNbr] [nvarchar](15) NULL,
	[PMProjectID] [int] NULL,
	[PMTaskID] [int] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Duration] [int] NULL,
	[Estimate] [int] NULL,
	[EstimatorID] [int] NULL,
	[tstamp] [timestamp] NOT NULL,
	[CreatedByID] [uniqueidentifier] NOT NULL,
	[CreatedByScreenID] [char](8) NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[LastModifiedByID] [uniqueidentifier] NOT NULL,
	[LastModifiedByScreenID] [char](8) NOT NULL,
	[LastModifiedDateTime] [datetime] NOT NULL,
 CONSTRAINT [PCTask_PK] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC,
	[TaskType] ASC,
	[TaskNbr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--DROP TABLE [dbo].[PCTaskAssignment]
CREATE TABLE [dbo].[PCTaskAssignment](
	[CompanyID] [int] DEFAULT ((0)) NOT NULL,
	[TaskType] [char](2) NOT NULL,
	[TaskNbr] [nvarchar](15) NOT NULL,
	[ResourceID] [int] NOT NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[PercentAssigned] [int] NOT NULL,
	[Progress] [int] NOT NULL,
	[tstamp] [timestamp] NOT NULL,
	[CreatedByID] [uniqueidentifier] NOT NULL,
	[CreatedByScreenID] [char](8) NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[LastModifiedByID] [uniqueidentifier] NOT NULL,
	[LastModifiedByScreenID] [char](8) NOT NULL,
	[LastModifiedDateTime] [datetime] NOT NULL,
 CONSTRAINT [PCTaskAssignment_PK] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC,
	[TaskType] ASC,
	[TaskNbr] ASC,
	[ResourceID] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--DROP TABLE [dbo].[PCResource]
CREATE TABLE [dbo].[PCResource](
	[CompanyID] [int] DEFAULT ((0)) NOT NULL,
	[BAccountID] [int] NOT NULL,
	[ExpertiseLevel] [int] NOT NULL,
	[SunAssignableDay] [bit] NOT NULL,
	[SunAssignableTime] [int] NULL,
	[MonAssignableDay] [bit] NOT NULL,
	[MonAssignableTime] [int] NULL,
	[TueAssignableDay] [bit] NOT NULL,
	[TueAssignableTime] [int] NULL,
	[WedAssignableDay] [bit] NOT NULL,
	[WedAssignableTime] [int] NULL,
	[ThuAssignableDay] [bit] NOT NULL,
	[ThuAssignableTime] [int] NULL,
	[FriAssignableDay] [bit] NOT NULL,
	[FriAssignableTime] [int] NULL,
	[SatAssignableDay] [bit] NOT NULL,
	[SatAssignableTime] [int] NULL,
	[DeletedDatabaseRecord] [bit] DEFAULT ((0)) NOT NULL,
 CONSTRAINT [PCResource_PK] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC,
	[BAccountID] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


--DROP TABLE [dbo].[PCTaskType]
CREATE TABLE [dbo].[PCTaskType](
	[CompanyID] [int] DEFAULT ((0)) NOT NULL,
	[TaskType] [char](2) NOT NULL,
	[Active] [bit] NOT NULL,
	[Description] [nvarchar](60) NULL,
	[NumberingID] [nvarchar](10) NOT NULL,
	[IsBillable] [bit] NOT NULL,
	[RequiresEstimate] [bit] NOT NULL,
	[tstamp] [timestamp] NOT NULL,
	[CreatedByID] [uniqueidentifier] NOT NULL,
	[CreatedByScreenID] [char](8) NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[LastModifiedByID] [uniqueidentifier] NOT NULL,
	[LastModifiedByScreenID] [char](8) NOT NULL,
	[LastModifiedDateTime] [datetime] NOT NULL,
	[DeletedDatabaseRecord] [bit] DEFAULT ((0)) NOT NULL

 CONSTRAINT [PCTaskType_PK] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC,
	[TaskType] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--DROP TABLE [dbo].[PCTaskTypeResource]
CREATE TABLE [dbo].[PCTaskTypeResource](
	[CompanyID] [int] DEFAULT ((0)) NOT NULL,
	[TaskType] [char](2) NOT NULL,
	[BAccountID] [int] NOT NULL,
	[tstamp] [timestamp] NOT NULL,
	[CreatedByID] [uniqueidentifier] NOT NULL,
	[CreatedByScreenID] [char](8) NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[LastModifiedByID] [uniqueidentifier] NOT NULL,
	[LastModifiedByScreenID] [char](8) NOT NULL,
	[LastModifiedDateTime] [datetime] NOT NULL,

 CONSTRAINT [PCTaskTypeResource_PK] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC,
	[TaskType] ASC,
	[BAccountID] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
