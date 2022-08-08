USE [testShop]
GO

/****** Object:  Table [dbo].[Relations]    Script Date: 08.08.2022 14:20:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Relations](
	[IdProduct] [int] NOT NULL,
	[IdCategory] [int] NOT NULL,
 CONSTRAINT [PK_Relations] PRIMARY KEY CLUSTERED 
(
	[IdProduct] ASC,
	[IdCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Relations]  WITH CHECK ADD  CONSTRAINT [FK_Relations_Category] FOREIGN KEY([IdCategory])
REFERENCES [dbo].[Category] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Relations] CHECK CONSTRAINT [FK_Relations_Category]
GO

ALTER TABLE [dbo].[Relations]  WITH CHECK ADD  CONSTRAINT [FK_Relations_Products] FOREIGN KEY([IdProduct])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Relations] CHECK CONSTRAINT [FK_Relations_Products]
GO

