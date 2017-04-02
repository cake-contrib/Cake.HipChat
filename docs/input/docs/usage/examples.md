# Build Script

You can reference Cake.HipChat in your build script as a cake addin:

```cake
#addin "Cake.HipChat"
```

or nuget reference:

```cake
#addin "nuget:https://www.nuget.org/api/v2?package=Cake.HipChat"
```

Then some examples:

This version of the AddIn requires you use a v1 API token:

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
```