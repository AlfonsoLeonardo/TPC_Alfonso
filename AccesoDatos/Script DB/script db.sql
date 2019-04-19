use master
go
create database Ingredientes_DB
go


USE Ingredientes_DB
GO

/****** Object:  Table [dbo].[PERSONAJES]    Script Date: 6/4/2019 11:08:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[INGREDIENTES](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[CantidadIngrediente] [float] Null,
	
	[Precio] [float] NULL,
 CONSTRAINT [PK_INGREDIENTES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

