# What Is N-Tier Architecture?
Multi-tier architecture can help you build more secure, flexible, and easy to manage software through more efficient development.

N-tier architecture is also called multi-tier architecture because the software is engineered to have the processing, data management, and presentation functions physically and logically separated.  That means that these different functions are hosted on several machines or clusters, ensuring that services are provided without resources being shared and, as such, these services are delivered at top capacity. The “N” in the name n-tier architecture refers to any number from 1.

Not only does your software gain from being able to get services at the best possible rate, but it’s also easier to manage. This is because when you work on one section, the changes you make will not affect the other functions.  And if there is a problem, you can easily pinpoint where it originates.


## Why do we need n-tier architecture?

The n-tier architecture is an industry-proven software architecture model. It is suitable to support enterprise level client-server applications by providing solutions to scalability, security, fault tolerance, reusability, and maintainability. It helps developers to create flexible and reusable applications.

## 3-Tier Architecture

![3](https://user-images.githubusercontent.com/103368662/212729207-15be9bd5-705e-4772-ad0a-49e088150750.png)

- **The application logic tier:** The application logic tier is where all the “thinking” happens, and it knows what is allowed by your application and what is possible, and it makes other decisions.  This logic tier is also the one that writes and reads data into the data tier.

- **The data tier:** The data tier is where all the data used in your application are stored.  You can securely store data on this tier, do transactions, and even search through volumes and volumes of data in a matter of seconds.

- **The presentation tier:** The presentation tier is the user interface.  This is what the software user sees and interacts with. This is where they enter the needed information.  This tier also acts as a go-between for the data tier and the user, passing on the user’s different actions to the logic tier.

## 4-Tier Architecture

While the most widespread use of multi-tier architecture is 3-tier architecture, in the book Domain Driven Design there are 4 layers which are the presentation layer, the application layer, the business layer, and the data access layer.

The presentation layer means the layer of UI (user interface) or view layer. It may be built with different technologies like Razor pages, Blazor, or modern web libraries and frameworks like Angular, React, Vue, Svelte, etc.

The application layer is also known as the service layer or GRASP controller layer.

The business layer is also known as the business logic layer (BLL) or domain logic layer. This is where the logical part of the application happens like calculations, CRUD (create-read-update-delete) operations, data analysis, etc.

The data access layer is where the entities live and it is simply a model of the database like in the Model-View-Controller pattern. This is actually the reason why we call it a model since it is the model of the database.
