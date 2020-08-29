USE [DroneDelivery]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 29/08/2020 18:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [uniqueidentifier] NOT NULL,
	[Latitude] [float] NOT NULL,
	[Longitude] [float] NOT NULL,
	[Endereco] [nchar](500) NOT NULL,
	[Nome] [nchar](100) NOT NULL,
	[Email] [nchar](100) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drone]    Script Date: 29/08/2020 18:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drone](
	[Id] [int] NOT NULL,
	[Capacidade] [int] NOT NULL,
	[Velocidade] [int] NOT NULL,
	[Autonomia] [int] NOT NULL,
	[Carga] [int] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Drone] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 29/08/2020 18:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[Id] [uniqueidentifier] NOT NULL,
	[Peso] [int] NOT NULL,
	[DataHora] [datetime] NOT NULL,
	[DistanciaParaOrigem] [float] NOT NULL,
	[IdCliente] [uniqueidentifier] NULL,
	[StatusPedido] [int] NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido_Drone]    Script Date: 29/08/2020 18:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido_Drone](
	[Pedido_Id] [uniqueidentifier] NOT NULL,
	[Drone_Id] [int] NOT NULL,
 CONSTRAINT [PK_Pedido_Drone] PRIMARY KEY CLUSTERED 
(
	[Pedido_Id] ASC,
	[Drone_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 29/08/2020 18:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [uniqueidentifier] NOT NULL,
	[Nome] [varchar](255) NOT NULL,
	[Senha] [varchar](255) NULL,
	[Papel] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Nome] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Usuario] FOREIGN KEY([Id])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Usuario]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Cliente]
GO
ALTER TABLE [dbo].[Pedido_Drone]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Drone_Drone] FOREIGN KEY([Drone_Id])
REFERENCES [dbo].[Drone] ([Id])
GO
ALTER TABLE [dbo].[Pedido_Drone] CHECK CONSTRAINT [FK_Pedido_Drone_Drone]
GO
ALTER TABLE [dbo].[Pedido_Drone]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Drone_Pedido] FOREIGN KEY([Pedido_Id])
REFERENCES [dbo].[Pedido] ([Id])
GO
ALTER TABLE [dbo].[Pedido_Drone] CHECK CONSTRAINT [FK_Pedido_Drone_Pedido]
GO
