FROM microsoft/dotnet:1.0.1-sdk-projectjson
COPY . /app
WORKDIR /app
 
RUN ["dotnet", "restore"]
RUN ["dotnet", "publish", "./src/Mic.Fraz.Api/"]

EXPOSE 5000/tcp
ENV ASPNETCORE_URLS http://*:5000


ENTRYPOINT ["dotnet","./src/Mic.Fraz.Api/bin/Debug/netcoreapp1.0/publish/Mic.Fraz.Api.dll"]