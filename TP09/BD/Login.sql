USE [Login]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 2/10/2023 08:21:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[NombreUsuario] [nvarchar](50) NULL,
	[Contraseña] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Telefono] [int] NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL
) ON [PRIMARY]
GO