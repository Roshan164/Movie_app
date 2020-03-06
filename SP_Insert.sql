USE [MoviesDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertMovie]    Script Date: 06-Mar-20 8:21:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[SP_InsertMovie]
(
@MovieTitle varchar(50)='',
@DateReleased datetime =''

)

AS
  BEGIN
     Insert into Movie (MovieTitle, DateReleased)
	 Values (@MovieTitle, @DateReleased)
END