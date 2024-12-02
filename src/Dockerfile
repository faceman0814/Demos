
# 使用官方的 ASP.NET Core Runtime 镜像
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
# 设置工作目录
WORKDIR /app

# 开放应用所需的端口
EXPOSE 80

# 使用官方的.NET SDK镜像作为构建环境
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /src

# 复制项目文件到容器中
COPY ["FaceMan.EFTest/FaceMan.EFTest.csproj", "FaceMan.EFTest/"]
COPY ["FaceMan.WebTest/FaceMan.WebTest.csproj", "FaceMan.WebTest/"]

# 还原和编译项目
RUN dotnet restore "FaceMan.WebTest/FaceMan.WebTest.csproj"

# 复制整个项目到容器中
COPY . .

WORKDIR "/src/FaceMan.WebTest"

RUN dotnet build "FaceMan.WebTest.csproj" -c Release -o /app/build

FROM build AS publish

RUN dotnet publish "FaceMan.WebTest.csproj" -c Release -o /app/publish /p:UseAppHost=false

# 从构建环境中复制编译好的文件
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

#定义时区参数
ENV TZ=Asia/Shanghai
#设置时区
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo '$TZ' > /etc/timezone

# 设置容器启动时执行的命令
ENTRYPOINT ["dotnet", "FaceMan.WebTest.dll"]