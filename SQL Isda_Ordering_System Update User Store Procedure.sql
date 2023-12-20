Create Procedure sp_UpdateUser1
	(
		@uID int,
		@uFN nvarchar(128),
		@uLN nvarchar(128),
		@uN nvarchar(128),
		@uP nvarchar(128),
		@rId int,
		@uC nvarchar(128)
	)
	As
	Begin
	Update UserAccount Set FirstName = @uFN, LastName = @uLN, Username = @uN, [Password] = @uP, RoleId = @rId, ContactInfo = @uC Where UserId = @uID
	End