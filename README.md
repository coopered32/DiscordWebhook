Simple Discord Webhook
Basic C# library to send messages using discord webhooks

**How to use**
> Importing Library
```CSharp
using Discord.Webhook;
```
> Create hook
```CSharp
DiscordWebhook hook = new();
hook.Url = "https://discord.com/api/webhooks/hook-url";
hook.User = "Mark Zuckerberg";
```

> Sending message
```CSharp
// string message
hook.Send(message);
```
