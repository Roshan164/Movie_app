USE [MoviesDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetMovieById]    Script Date: 06-Mar-20 8:21:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[SP_GetMovieById]
( 
 @MovieId int
)

AS
  BEGIN
     Select * From Movie Where Id=@MovieId
	 
END