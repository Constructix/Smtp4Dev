# Smtp4Dev
Smtp4Dev implementation with docker and C# code.
# Sending Email from .NET Core

Reference: https://github.com/rnwood/smtp4dev

Docker location for SMTP4Dev: docker run --rm -it -p 3000:80 -p 2525:25 rnwood/smtp4dev

Smtp4dev web interface can be accessed on port 3000 and port 2525 used for SMTP.

ie: http://localhost:3000/

Also, System.Net.Smtp is now obsolete, refer to :https://learn.microsoft.com/en-us/answers/questions/365369/why-doesn39t-smtpclient-work-correctly-in-vs-2019.html

