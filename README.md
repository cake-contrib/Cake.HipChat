# Cake.HipChat
Cake AddIn that extends Cake with HipChat messaging features

[![Build status](https://ci.appveyor.com/api/projects/status/4atnp8h2oqkx36ai?svg=true)](https://ci.appveyor.com/project/scene316/cake-hipchat)

## Usage

This version of the AddIn requires you use a v1 API token

```csharp
#addin "Cake.HipChat"

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

