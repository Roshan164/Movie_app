USE [MoviesDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteMovie]    Script Date: 06-Mar-20 8:17:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[SP_DeleteMovie]
( 
 @MovieId int
)

AS
  BEGIN
     Delete From Movie Where Id=@MovieId
	 
END