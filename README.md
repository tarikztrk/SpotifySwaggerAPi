[![.NET](https://github.com/tarikztrk/SpotifySwaggerAPi/actions/workflows/dotnet.yml/badge.svg)](https://github.com/tarikztrk/SpotifySwaggerAPi/actions/workflows/dotnet.yml)

# SpotifyApiWrapper

.NET 6 wrapper for the Spotify Web API.

-SwaggerUI

-Dockerized

-With Client Credentials

# Quick Start

You require to replace appsetting.json with your own Client ID and Client Secret.

````
 "ClientAuthorization": {
    "ClientId": "your_client_id",
    "ClientSecret": "your_client_secret",
    "GrantType": "client_credentials",
    "Uri": "https://accounts.spotify.com/api/token",
    "RedirectUri": "https://localhost:44344/callback"
  }
````

If you want to run this application with Docker you can follow this instructions.

-Go to project file 

-Open powershell

-Run the following command

````
docker build . -t spotifyapiwrapper

````

````
 docker run --name spotifapiwrapper -p 8081:80 -d spotifyapiwrapper
````

After that application will run in the http://localhost:8081/swagger/index.html



![image](https://user-images.githubusercontent.com/24737692/165965696-13923d64-35cf-4b0e-95d2-a8786cf8c84f.png)


