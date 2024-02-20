# Clean Architecture (Onion Architecture)

The Onion Architecture is a software architectural pattern that emphasizes the separation of concerns within an application. It was introduced by Jeffrey Palermo and is particularly popular in the .NET ecosystem. The Onion Architecture is based on the principles of dependency inversion and the single responsibility principle.

![Project_Layers](https://github.com/manusoft/CleanArchitecture/assets/83714923/8bbce9d8-77e6-4694-895f-3d61726bc0c7)

The architecture is composed of several layers, each representing a different level of abstraction and responsibility. These layers are typically arranged in concentric circles, resembling the layers of an onion. The layers include:

1. **Outermost Layer (UI Layer or Presentation Layer)**:
   - This layer represents the user interface of the application.
   - It includes components responsible for presenting data to users and handling user interactions.
   - In the context of a Blazor web application, this layer typically consists of Blazor components, pages, and other UI-related artifacts.

2. **Application Layer**:
   - This layer contains application-specific logic and orchestrates interactions between the UI layer and the domain layer.
   - It may include services, controllers, or use cases that coordinate the flow of data and operations within the application.
   - In a Blazor web application, this layer might contain code related to handling user inputs, managing authentication, authorization, and routing.

3. **Domain Layer**:
   - The domain layer contains the core business logic and entities of the application.
   - It defines the fundamental concepts and rules that govern the behavior of the application.
   - This layer should be independent of any infrastructure concerns or external dependencies.
   - In a Blazor web application, the domain layer may include domain models, business rules, and services that encapsulate domain logic.

4. **Infrastructure Layer**:
   - This layer provides implementations for external concerns such as data access, communication with external services, and other infrastructure-related tasks.
   - It typically includes repositories, data access objects, external service clients, and other infrastructure components.
   - In a Blazor web application, the infrastructure layer may include database access code, API clients, configuration management, logging, and other cross-cutting concerns.

The key principles of the Onion Architecture are:

- **Dependency Inversion**: High-level modules should not depend on low-level modules; both should depend on abstractions. In other words, dependencies should be abstracted away, allowing for flexibility and easier testing.
- **Single Responsibility Principle (SRP)**: Each module or class should have only one reason to change. This principle helps keep code modular, maintainable, and easier to understand.
- **Separation of Concerns (SoC)**: Different parts of the application should address separate concerns and should not unnecessarily overlap in functionality.

In a Blazor web application, the relationship between these layers can be visualized as follows:

- The UI layer interacts with the Application Layer to handle user interactions and trigger application-specific logic.
- The Application Layer coordinates the flow of data and operations between the UI layer and the Domain Layer.
- The Domain Layer encapsulates the core business logic and entities of the application, providing a clean separation from infrastructure concerns.
- The Infrastructure Layer provides implementations for external concerns such as data access and communication with external services, while remaining decoupled from the core business logic.

By adhering to the principles of the Onion Architecture, developers can create applications that are more maintainable, testable, and adaptable to change.

Sure, here's a typical folder structure for each project in a Blazor web application following the Onion Architecture:

## Structure of Projects

1. **UI Layer (Blazor WebAssembly or Blazor Server)**:
   ```
   MyBlazorApp.Client
   │
   ├── Pages                 # Contains Blazor component pages
   │   ├── Home.razor
   │   ├── About.razor
   │   ├── Contact.razor
   │   └── ...
   │
   ├── Shared                # Contains shared components, layouts, and resources
   │   ├── MainLayout.razor
   │   ├── ErrorBoundary.razor
   │   ├── NavMenu.razor
   │   └── ...
   │
   ├── wwwroot               # Static files served to the client
   │   ├── css
   │   ├── js
   │   ├── images
   │   └── ...
   │
   ├── App.razor             # Root component
   └── Program.cs            # Entry point for the client-side Blazor application
   ```

2. **Application Layer**:
   ```
   MyBlazorApp.Application
   │
   ├── Services               # Application services and use cases
   │   ├── AuthenticationService.cs
   │   ├── ProductService.cs
   │   └── ...
   │
   ├── Validators             # Input validation logic
   │   ├── ProductValidator.cs
   │   └── ...
   │
   └── AutoMapperProfiles     # AutoMapper profiles for object mapping
       ├── MappingProfile.cs
       └── ...
   ```

3. **Domain Layer**:
   ```
   MyBlazorApp.Domain
   │
   ├── Entities               # Domain entities or models
   │   ├── Product.cs
   │   ├── User.cs
   │   └── ...
   │
   ├── Services               # Domain services containing core business logic
   │   ├── ProductService.cs
   │   ├── UserService.cs
   │   └── ...
   │
   └── ValueObjects           # Immutable objects representing domain concepts
       ├── Money.cs
       ├── Address.cs
       └── ...
   ```

4. **Infrastructure Layer**:
   ```
   MyBlazorApp.Infrastructure
   │
   ├── Data                   # Data access layer
   │   ├── Repositories       # Database repositories
   │   │   ├── ProductRepository.cs
   │   │   ├── UserRepository.cs
   │   │   └── ...
   │   └── ApplicationDbContext.cs   # EF Core DbContext
   │
   ├── Services               # External services or clients
   │   ├── EmailService.cs
   │   ├── PaymentService.cs
   │   └── ...
   │
   ├── Configuration          # Configuration settings
   │   ├── AppSettings.cs
   │   ├── EmailSettings.cs
   │   └── ...
   │
   ├── Logging                # Logging infrastructure
   │   ├── Logger.cs
   │   └── ...
   │
   ├── Extensions             # Extension methods and helper classes
   │   ├── ServiceCollectionExtensions.cs
   │   └── ...
   │
   └── Migrations             # Entity Framework Core migrations
       ├── 20220101000000_InitialCreate.cs
       └── ...
   ```

This folder structure organizes the application into separate concerns, facilitating modularity, maintainability, and testability. Each layer focuses on specific responsibilities and can be developed, tested, and deployed independently of the other layers.
