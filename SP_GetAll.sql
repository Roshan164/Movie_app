USE [MoviesDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllMovie]    Script Date: 06-Mar-20 8:20:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[SP_GetAllMovie]
AS
  BEGIN
     Select *from Movie
END