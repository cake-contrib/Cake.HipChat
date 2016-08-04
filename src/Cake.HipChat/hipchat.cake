#r "Cake.HipChat.dll"

	var authToken = EnvironmentVariable("HIPCHAT_AUTH_TOKEN");	
	var roomId = EnvironmentVariable("HIPCHAT_ROOM_ID");
	var senderName = EnvironmentVariable("HIPCHAT_SENDER_NAME");         
		 
try
{
    SendMessage(authToken, roomId, senderName, "Testing, 3, 2, 1");
}
catch(Exception ex)
{
    Error("{0}", ex);
}