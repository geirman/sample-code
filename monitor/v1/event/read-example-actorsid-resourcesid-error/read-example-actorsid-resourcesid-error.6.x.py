# Download the helper library from https://www.twilio.com/docs/python/install
from twilio.rest import Client


# Your Account Sid and Auth Token from twilio.com/console
# DANGER! This is insecure. See http://twil.io/secure
account_sid = 'ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX'
auth_token = 'your_auth_token'
client = Client(account_sid, auth_token)

events = client.monitor.events \
                       .list(
                            actor_sid='USd0afd67cddff4ec7cb0022771a203cb1',
                            resource_sid='PN4aa51b930717ea83c91971b86d99018f',
                            limit=20
                        )

for record in events:
    print(record.sid)
