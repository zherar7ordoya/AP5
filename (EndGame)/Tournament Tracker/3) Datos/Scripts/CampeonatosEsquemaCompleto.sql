USE [master]

go

/*** Object:  Database [Campeonatos] ******************************************/
CREATE DATABASE [Campeonatos] containment = none ON PRIMARY ( NAME =
N'Campeonatos', filename =
N'C:\Documents\AP5\(EndGame)\Tournament Tracker\3) Datos\Campeonatos.mdf', size
= 8192kb, maxsize = unlimited, filegrowth = 65536kb ) log ON ( NAME =
N'Campeonatos_log', filename =
N'C:\Documents\AP5\(EndGame)\Tournament Tracker\3) Datos\Campeonatos_log.ldf',
size = 8192kb, maxsize = 2048gb, filegrowth = 65536kb ) WITH catalog_collation =
database_default

go

ALTER DATABASE [Campeonatos]

SET compatibility_level = 150

go

IF ( 1 = Fulltextserviceproperty('IsFullTextInstalled') )
  BEGIN
      EXEC [Campeonatos].[dbo].[Sp_fulltext_database]
        @action = 'enable'
  END

go

ALTER DATABASE [Campeonatos]

SET ansi_null_default OFF

go

ALTER DATABASE [Campeonatos]

SET ansi_nulls OFF

go

ALTER DATABASE [Campeonatos]

SET ansi_padding OFF

go

ALTER DATABASE [Campeonatos]

SET ansi_warnings OFF

go

ALTER DATABASE [Campeonatos]

SET arithabort OFF

go

ALTER DATABASE [Campeonatos]

SET auto_close ON

go

ALTER DATABASE [Campeonatos]

SET auto_shrink OFF

go

ALTER DATABASE [Campeonatos]

SET auto_update_statistics ON

go

ALTER DATABASE [Campeonatos]

SET cursor_close_on_commit OFF

go

ALTER DATABASE [Campeonatos]

SET cursor_default global

go

ALTER DATABASE [Campeonatos]

SET concat_null_yields_null OFF

go

ALTER DATABASE [Campeonatos]

SET numeric_roundabort OFF

go

ALTER DATABASE [Campeonatos]

SET quoted_identifier OFF

go

ALTER DATABASE [Campeonatos]

SET recursive_triggers OFF

go

ALTER DATABASE [Campeonatos]

SET disable_broker

go

ALTER DATABASE [Campeonatos]

SET auto_update_statistics_async OFF

go

ALTER DATABASE [Campeonatos]

SET date_correlation_optimization OFF

go

ALTER DATABASE [Campeonatos]

SET trustworthy OFF

go

ALTER DATABASE [Campeonatos]

SET allow_snapshot_isolation OFF

go

ALTER DATABASE [Campeonatos]

SET parameterization simple

go

ALTER DATABASE [Campeonatos]

SET read_committed_snapshot OFF

go

ALTER DATABASE [Campeonatos]

SET honor_broker_priority OFF

go

ALTER DATABASE [Campeonatos]

SET recovery simple

go

ALTER DATABASE [Campeonatos]

SET multi_user

go

ALTER DATABASE [Campeonatos]

SET page_verify checksum

go

ALTER DATABASE [Campeonatos]

SET db_chaining OFF

go

ALTER DATABASE [Campeonatos]

SET filestream( non_transacted_access = OFF )

go

ALTER DATABASE [Campeonatos]

SET target_recovery_time = 60 seconds

go

ALTER DATABASE [Campeonatos]

SET delayed_durability = disabled

go

ALTER DATABASE [Campeonatos]

SET accelerated_database_recovery = OFF

go

ALTER DATABASE [Campeonatos]

SET query_store = OFF

go

USE [Campeonatos]

go

/*** Object:  Table [dbo].[PartidoParticipantes] *****************************/
SET ansi_nulls ON

go

SET quoted_identifier ON

go

CREATE TABLE [dbo].[partidoparticipantes]
  (
     [id]              [INT] IDENTITY(1, 1) NOT NULL,
     [matchupid]       [INT] NOT NULL,
     [parentmatchupid] [INT] NULL,
     [teamcompetingid] [INT] NULL,
     [score]           [FLOAT] NULL,
     CONSTRAINT [PK_PartidoParticipantes] PRIMARY KEY CLUSTERED ( [id] ASC )WITH
     (pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF,
     allow_row_locks = on, allow_page_locks = on, optimize_for_sequential_key =
     OFF) ON [PRIMARY]
  )
ON [PRIMARY]

go

/****** Object:  Table [dbo].[Matchups]    Script Date: 21/10/2022 23:36:58 ******/
SET ansi_nulls ON

go

SET quoted_identifier ON

go

CREATE TABLE [dbo].[matchups]
  (
     [id]           [INT] IDENTITY(1, 1) NOT NULL,
     [tournamentid] [INT] NOT NULL,
     [winnerid]     [INT] NULL,
     [matchupround] [INT] NOT NULL,
     CONSTRAINT [PK_Matchups] PRIMARY KEY CLUSTERED ( [id] ASC )WITH (pad_index
     = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, allow_row_locks
     = on, allow_page_locks = on, optimize_for_sequential_key = OFF) ON
     [PRIMARY]
  )
ON [PRIMARY]

go

/****** Object:  Table [dbo].[People]    Script Date: 21/10/2022 23:36:58 ******/
SET ansi_nulls ON

go

SET quoted_identifier ON

go

CREATE TABLE [dbo].[people]
  (
     [id]              [INT] IDENTITY(1, 1) NOT NULL,
     [firstname]       [NVARCHAR](100) NOT NULL,
     [lastname]        [NVARCHAR](100) NOT NULL,
     [emailaddress]    [NVARCHAR](100) NOT NULL,
     [cellphonenumber] [VARCHAR](20) NULL,
     CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED ( [id] ASC )WITH (pad_index =
     OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, allow_row_locks =
     on, allow_page_locks = on, optimize_for_sequential_key = OFF) ON [PRIMARY]
  )
ON [PRIMARY]

go

/****** Object:  Table [dbo].[Prizes]    Script Date: 21/10/2022 23:36:58 ******/
SET ansi_nulls ON

go

SET quoted_identifier ON

go

CREATE TABLE [dbo].[prizes]
  (
     [id]              [INT] IDENTITY(1, 1) NOT NULL,
     [placenumber]     [INT] NOT NULL,
     [placename]       [NVARCHAR](50) NOT NULL,
     [prizeamount]     [MONEY] NOT NULL,
     [prizepercentage] [FLOAT] NOT NULL,
     CONSTRAINT [PK_Prizes] PRIMARY KEY CLUSTERED ( [id] ASC )WITH (pad_index =
     OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, allow_row_locks =
     on, allow_page_locks = on, optimize_for_sequential_key = OFF) ON [PRIMARY]
  )
ON [PRIMARY]

go

/****** Object:  Table [dbo].[TeamMembers]    Script Date: 21/10/2022 23:36:58 ******/
SET ansi_nulls ON

go

SET quoted_identifier ON

go

CREATE TABLE [dbo].[teammembers]
  (
     [id]       [INT] IDENTITY(1, 1) NOT NULL,
     [teamid]   [INT] NOT NULL,
     [personid] [INT] NOT NULL,
     CONSTRAINT [PK_TeamMembers] PRIMARY KEY CLUSTERED ( [id] ASC )WITH (
     pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF,
     allow_row_locks = on, allow_page_locks = on, optimize_for_sequential_key =
     OFF) ON [PRIMARY]
  )
ON [PRIMARY]

go

/****** Object:  Table [dbo].[Teams]    Script Date: 21/10/2022 23:36:58 ******/
SET ansi_nulls ON

go

SET quoted_identifier ON

go

CREATE TABLE [dbo].[teams]
  (
     [id]       [INT] IDENTITY(1, 1) NOT NULL,
     [teamname] [NVARCHAR](100) NOT NULL,
     CONSTRAINT [PK_Teams] PRIMARY KEY CLUSTERED ( [id] ASC )WITH (pad_index =
     OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, allow_row_locks =
     on, allow_page_locks = on, optimize_for_sequential_key = OFF) ON [PRIMARY]
  )
ON [PRIMARY]

go

/****** Object:  Table [dbo].[TournamentEntries]    Script Date: 21/10/2022 23:36:58 ******/
SET ansi_nulls ON

go

SET quoted_identifier ON

go

CREATE TABLE [dbo].[tournamententries]
  (
     [id]           [INT] IDENTITY(1, 1) NOT NULL,
     [tournamentid] [INT] NOT NULL,
     [teamid]       [INT] NOT NULL,
     CONSTRAINT [PK_TournamentEntries] PRIMARY KEY CLUSTERED ( [id] ASC )WITH (
     pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF,
     allow_row_locks = on, allow_page_locks = on, optimize_for_sequential_key =
     OFF) ON [PRIMARY]
  )
ON [PRIMARY]

go

/****** Object:  Table [dbo].[TournamentPrizes]    Script Date: 21/10/2022 23:36:58 ******/
SET ansi_nulls ON

go

SET quoted_identifier ON

go

CREATE TABLE [dbo].[tournamentprizes]
  (
     [id]           [INT] IDENTITY(1, 1) NOT NULL,
     [tournamentid] [INT] NOT NULL,
     [prizeid]      [INT] NOT NULL,
     CONSTRAINT [PK_TournamentPrizes] PRIMARY KEY CLUSTERED ( [id] ASC )WITH (
     pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF,
     allow_row_locks = on, allow_page_locks = on, optimize_for_sequential_key =
     OFF) ON [PRIMARY]
  )
ON [PRIMARY]

go

/****** Object:  Table [dbo].[Campeonatos]    Script Date: 21/10/2022 23:36:58 ******/
SET ansi_nulls ON

go

SET quoted_identifier ON

go

CREATE TABLE [dbo].[campeonatos]
  (
     [id]             [INT] IDENTITY(1, 1) NOT NULL,
     [tournamentname] [NVARCHAR](200) NOT NULL,
     [entryfee]       [MONEY] NOT NULL,
     [active]         [BIT] NOT NULL,
     CONSTRAINT [PK_Campeonatos] PRIMARY KEY CLUSTERED ( [id] ASC )WITH (
     pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF,
     allow_row_locks = on, allow_page_locks = on, optimize_for_sequential_key =
     OFF) ON [PRIMARY]
  )
ON [PRIMARY]

go

ALTER TABLE [dbo].[prizes]
  ADD CONSTRAINT [DF_Prizes_PrizeAmount] DEFAULT ((0)) FOR [PrizeAmount]

go

ALTER TABLE [dbo].[prizes]
  ADD CONSTRAINT [DF_Prizes_PrizePercentage] DEFAULT ((0)) FOR [PrizePercentage]

go

ALTER TABLE [dbo].[campeonatos]
  ADD CONSTRAINT [DF_Campeonatos_EntryFee] DEFAULT ((0)) FOR [EntryFee]

go

ALTER TABLE [dbo].[campeonatos]
  ADD CONSTRAINT [DF_Campeonatos_Active] DEFAULT ((1)) FOR [Active]

go

ALTER TABLE [dbo].[partidoparticipantes]
  WITH CHECK ADD CONSTRAINT [FK_PartidoParticipantes_MatchupId] FOREIGN KEY(
  [matchupid]) REFERENCES [dbo].[matchups] ([id])

go

ALTER TABLE [dbo].[partidoparticipantes]
  CHECK CONSTRAINT [FK_PartidoParticipantes_MatchupId]

go

ALTER TABLE [dbo].[partidoparticipantes]
  WITH CHECK ADD CONSTRAINT [FK_PartidoParticipantes_ParentMatchupId] FOREIGN
  KEY([parentmatchupid]) REFERENCES [dbo].[matchups] ([id])

go

ALTER TABLE [dbo].[partidoparticipantes]
  CHECK CONSTRAINT [FK_PartidoParticipantes_ParentMatchupId]

go

ALTER TABLE [dbo].[partidoparticipantes]
  WITH CHECK ADD CONSTRAINT [FK_PartidoParticipantes_TeamCompetingId] FOREIGN
  KEY([teamcompetingid]) REFERENCES [dbo].[teams] ([id])

go

ALTER TABLE [dbo].[partidoparticipantes]
  CHECK CONSTRAINT [FK_PartidoParticipantes_TeamCompetingId]

go

ALTER TABLE [dbo].[matchups]
  WITH CHECK ADD CONSTRAINT [FK_Matchups_TournamentId] FOREIGN KEY(
  [tournamentid]) REFERENCES [dbo].[campeonatos] ([id])

go

ALTER TABLE [dbo].[matchups]
  CHECK CONSTRAINT [FK_Matchups_TournamentId]

go

ALTER TABLE [dbo].[matchups]
  WITH CHECK ADD CONSTRAINT [FK_Matchups_WinnerId] FOREIGN KEY([winnerid])
  REFERENCES [dbo].[teams] ([id])

go

ALTER TABLE [dbo].[matchups]
  CHECK CONSTRAINT [FK_Matchups_WinnerId]

go

ALTER TABLE [dbo].[teammembers]
  WITH CHECK ADD CONSTRAINT [FK_TeamMembers_PersonId] FOREIGN KEY([personid])
  REFERENCES [dbo].[people] ([id])

go

ALTER TABLE [dbo].[teammembers]
  CHECK CONSTRAINT [FK_TeamMembers_PersonId]

go

ALTER TABLE [dbo].[teammembers]
  WITH CHECK ADD CONSTRAINT [FK_TeamMembers_TeamId] FOREIGN KEY([teamid])
  REFERENCES [dbo].[teams] ([id])

go

ALTER TABLE [dbo].[teammembers]
  CHECK CONSTRAINT [FK_TeamMembers_TeamId]

go

ALTER TABLE [dbo].[tournamententries]
  WITH CHECK ADD CONSTRAINT [FK_TournamentEntries_TeamId] FOREIGN KEY([teamid])
  REFERENCES [dbo].[teams] ([id])

go

ALTER TABLE [dbo].[tournamententries]
  CHECK CONSTRAINT [FK_TournamentEntries_TeamId]

go

ALTER TABLE [dbo].[tournamententries]
  WITH CHECK ADD CONSTRAINT [FK_TournamentEntries_TournamentId] FOREIGN KEY(
  [tournamentid]) REFERENCES [dbo].[campeonatos] ([id])

go

ALTER TABLE [dbo].[tournamententries]
  CHECK CONSTRAINT [FK_TournamentEntries_TournamentId]

go

ALTER TABLE [dbo].[tournamentprizes]
  WITH CHECK ADD CONSTRAINT [FK_TournamentPrizes_PrizeId] FOREIGN KEY([prizeid])
  REFERENCES [dbo].[prizes] ([id])

go

ALTER TABLE [dbo].[tournamentprizes]
  CHECK CONSTRAINT [FK_TournamentPrizes_PrizeId]

go

ALTER TABLE [dbo].[tournamentprizes]
  WITH CHECK ADD CONSTRAINT [FK_TournamentPrizes_TournamentId] FOREIGN KEY(
  [tournamentid]) REFERENCES [dbo].[campeonatos] ([id])

go

ALTER TABLE [dbo].[tournamentprizes]
  CHECK CONSTRAINT [FK_TournamentPrizes_TournamentId]

go

USE [master]

go

ALTER DATABASE [Campeonatos]

SET read_write

go 