# Hey, welcome to SharpCord.

SharpCord is a new, unofficial API wrapper for DIscord.

## Getting Started

First, create a C# project and install SharpCord.Core and SharpCord.Rest.

After that, create a bot and get its token.

Then, you can create an instance of `DiscordRestClient` to access Discord's API:

```csharp
using SharpCord.Rest;

var token = "<Enter bot token>"; // NEVER store your token in plain text like this.
var client = new DiscordRestClient();

await client.LoginAsync(token);

Console.WriteLine("Successfully logged in as " + client.CurrentUser?.Username);
```

## Documentation

Our documentation for entities such as `IUser` and `IGuild` have been copied directly from Discord's API Reference.

We understand that Discord's documentation may be lacking in some parts, and we invite you to open pull requests expanding the documentation.