// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using Twilio;
using Twilio.Rest.Video.V1.Room;


class Program 
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Token at twilio.com/console
        // DANGER! This is insecure. See http://twil.io/secure
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";

        TwilioClient.Init(accountSid, authToken);

        var recordings = RoomRecordingResource.Read(
            pathRoomSid: "RMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
            limit: 20
        );

        foreach(var record in recordings)
        {
           Console.WriteLine(record.Sid);
        }
    }
}
