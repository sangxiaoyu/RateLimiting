
# RateLimiting component
I have packed  middleware,you can register it to startup or service.

such as :

```C#
//config it
services.AddAIpRateLimiting(Configuration);
```
and then 
```C#
app.UseMiddleware<RateLimitingMiddleware>(Array.Empty<object>());
```
finally,to add appsettings.json parameters that  adapt you application scenarios
```C#
  "RateLimiting": {
    "Times": 5000
  },
```

That's all.If you have any questions, please commit an issue.
