USE [MoviesDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateMovie]    Script Date: 06-Mar-20 8:22:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[SP_UpdateMovie]
(
@MovieId int=0,
@MovieTitle varchar(50)='',
@DateReleased datetime =''

)

AS
  BEGIN
     Update Movie set MovieTitle=@MovieTitle, DateReleased=@DateReleased 
	 
END