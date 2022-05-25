# Monstarlab API Template 

## Install:
1. Clone this repo
2. To install this template in repo folder execute following command:

```bash
dotnet new --install ./
```

3. To create new project execute following command:

```bash
dotnet new monstarlab-api -n "YourClientName.ItsProjectName"
```

4. Ta-da!

---

If published to NuGet feed, this template can be installed by executing following command:

```bash
dotnet new --install Monstarlab.Templates.Api
```

## Uninstall

1. To uninstall this template in repo folder execute following command:

```bash
dotnet new --uninstall ./
```

## Update
1. To update this template in repo folder execute the following commands:

```bash
dotnet new --uninstall ./
dotnet new --install ./
```

---

More info:
- https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates
- https://github.com/dotnet/templating/wiki