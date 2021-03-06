// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using Twilio;
using Twilio.Rest.Sync.V1.Service.SyncMap;


class Program 
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Token at twilio.com/console
        // DANGER! This is insecure. See http://twil.io/secure
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";

        TwilioClient.Init(accountSid, authToken);

        var syncMapItems = SyncMapItemResource.Read(
            from: "steph_curry",
            order: SyncMapItemResource.QueryResultOrderEnum.Asc,
            pathServiceSid: "ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
            pathMapSid: "Players",
            limit: 20
        );

        foreach(var record in syncMapItems)
        {
           Console.WriteLine(record.Key);
        }
    }
}
