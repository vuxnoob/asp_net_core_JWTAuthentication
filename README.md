# asp_net_core_JWTAuthentication
JWT is represented as a combination of three base64url encoded parts concatenated with period ('.') characters and comprises the following three sections:

Header

Payload

Signature

**Install NuGet Package**
So far so good. The next step is to install the necessary NuGet Package(s). A NuGet package is represented as a file that has a .nupkg extension and is comprised of compiled code (also called DLLs), other related files, and a manifest that provides information related to the package such as version number, etc.

To install the required packages into your project, execute the following commands at the NuGet Package Manager Console.

dotnet add package Microsoft.AspNetCore.Authentication

dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer


