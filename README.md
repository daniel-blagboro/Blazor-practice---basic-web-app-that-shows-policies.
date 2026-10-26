# Blazor Policy Dashboard

A small practice project for learning how Blazor pages work. It uses a policy dashboard to explore routing, rendering C# data in Razor markup, dependency injection, event handling, and filtering.

## Run the app

You need the .NET 10 SDK. From the project directory, run:

```sh
dotnet run
```

Open the local URL printed by the command. The policy dashboard is available at `/policies`.

## What the page demonstrates

The dashboard is implemented in `Components/Pages/Policies.razor`:

- `@page "/policies"` maps the component to the `/policies` route.
- `@rendermode InteractiveServer` enables interactive server-side rendering.
- `@inject PolicyService PolicyService` gets the policy service through dependency injection.
- `OnInitialized` loads the initial policy list when the component is initialized.
- Razor expressions and `@foreach` render policy values and rows from C# data.
- `@bind` connects the status selector and search field to component state.
- `@onclick` connects the refresh button to a C# event handler.
- `FilteredPolicies` combines the selected status and search text to determine which rows are shown.
- `ActivePolicies` and `PendingPolicies` calculate summary counts from the policy list.

The refresh button currently updates the status message; it does not fetch new data.

## Project structure

- `Components/Pages/Policies.razor` — interactive policy dashboard page.
- `Components/Pages/Home.razor` — home page at `/`.
- `Components/Layout/NavMenu.razor` — navigation links for Home and Policies.
- `Models/Policy.cs` — policy data model.
- `Services/PolicyService.cs` — in-memory sample policy data.
- `Program.cs` — registers the policy service and configures interactive Razor components.

The sample policies are stored in memory in `PolicyService`; this project does not use a database or external API.
