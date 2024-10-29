FROM mcr.microsoft.com/dotnet/sdk:latest AS build
WORKDIR /operator

COPY ./ ./
RUN dotnet tool install KubeOps.Cli
RUN dotnet restore --disable-parallel
RUN dotnet publish --no-restore -c Release /p:AssemblyName=operator -o out

# The runner for the application
FROM mcr.microsoft.com/dotnet/runtime:latest AS final

RUN addgroup k8s-operator && useradd -G k8s-operator operator-user

WORKDIR /operator
COPY --from=build /operator/out/ ./
RUN chown operator-user:k8s-operator -R .

USER operator-user

ENTRYPOINT [ "dotnet", "operator.dll" ]